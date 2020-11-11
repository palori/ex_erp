using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;
using erp_api.Repositories;
using erp_api.Data.DTO;

namespace erp_api.Services
{
    public class StatisticsService: IService
    {
        private readonly ClientProfileContactService clients;
        private readonly OrdersRepository orders;
        private readonly OrderItemsRepository orderItems;
        private readonly TradingInfosRepository tradingInfos;
        public StatisticsService(){}
        public StatisticsService(
            ClientProfileContactService clients,
            OrdersRepository orders,
            OrderItemsRepository orderItems,
            TradingInfosRepository tradingInfos
            )
        {
            this.clients = clients;
            this.orders = orders;
            this.orderItems = orderItems;
            this.tradingInfos = tradingInfos;
        }

        public async Task<StatisticsDto<DateTime,int>> NewClientsMonth()
        {
            var now = DateTime.Now;
            var year = now.Year;
            var month = now.Month;

            const int numMonths = 6;

            var startMonth = month-numMonths+1;
            if (startMonth < 0) startMonth += 12;

            var startYear = year;
            if (startMonth > month) startYear -= 1; // not generic for any 'numMonths'

            // create time axis for 'numMonths' and initialize data values to 0
            StatisticsDto<DateTime,int> data = new StatisticsDto<DateTime,int>();
            data.Title = "New clients per month";
            data.X = new List<DateTime>();
            data.Y = new List<int>();
            int mm = startMonth;
            int yy = startYear;
            for (int i=0; i<numMonths; i++)
            {
                // X axis
                data.X.Add(new DateTime(yy,mm,1));
                mm++;
                if(mm>12)
                {
                    mm = 1;
                    yy += 1;
                }

                // Y axis (initialize to 0)
                data.Y.Add(0);
            }

            // calculate number of new clients for the last 'numMonths'
            List<ClientDto> clients = await this.clients.GetAll();
            foreach (var client in clients)
            {
                var yearC = client.Registered.Year;
                var monthC = client.Registered.Month;
                var x = new DateTime(year,month,1);
                
                for (int i=0; i<numMonths; i++)
                {
                    if (x == data.X[i])
                    {
                        data.Y[i]++;
                        break;
                    }
                }
            }

            return data;
        }
        public async Task<List<StatisticsDto<string,float>>> OrdersDay_AvgCart()
        {
            // data
            var ordersDay = new StatisticsDto<string,float>();
            var avgCartDay = new StatisticsDto<string,float>();
            
            // titles
            ordersDay.Title = "Orders per day of week";
            avgCartDay.Title = "Average cart per day of week";

            // X axis
            var days = DaysOfWeek();
            ordersDay.X = days;
            avgCartDay.X = days;

            // fetch data from DB
            List<Order> orders = await this.orders.GetAll();
            List<OrderItem> orderItems = await this.orderItems.GetAll();
            List<TradingInfo> tradingInfos = await this.tradingInfos.GetAll();
            
            // compute data
            List<List<float>> cartValuesDay = new List<List<float>>()
            {
                new List<float>(), // monday
                new List<float>(), // tuesaday
                new List<float>(), // ...
                new List<float>(),
                new List<float>(),
                new List<float>(),
                new List<float>()
            };
            foreach (var order in orders)
            {
                float cartTotal = 0F;
                if (order.ReferenceId.Contains('C'))
                {
                    foreach (var item in orderItems)
                    {
                        if (order.Id == item.OrderId)
                        {
                            foreach (var trad in tradingInfos)
                            {
                                if (item.TradingInfoId == trad.Id)
                                {
                                    cartTotal += trad.Price; // taxes (IVA) included
                                    break;
                                }
                            }
                        }
                    }
                    
                    if (cartTotal != 0F) // it should always be the case!
                    {
                        int index = 0;
                        switch (order.Ordered.DayOfWeek.ToString())
                        {
                            case "Monday": index = 0; break;
                            case "Tuesday": index = 1; break;
                            case "Wednesday": index = 2; break;
                            case "Thursday": index = 3; break;
                            case "Friday": index = 4; break;
                            case "Saturday": index = 5; break;
                            case "Sunday": index = 6; break;
                            default: index = 0; break;
                        }
                        cartValuesDay[index].Add(cartTotal);
                    }
                }
            }

            // Y axis
            ordersDay.Y = new List<float>();
            avgCartDay.Y = new List<float>();
            for (int i=0; i<days.Count; i++)
            {
                ordersDay.Y.Add(cartValuesDay[i].Count*1F);
                avgCartDay.Y.Add(cartValuesDay[i].Count > 0 ? cartValuesDay[i].Average() : 0.0F);
            }

            return new List<StatisticsDto<string,float>>()
            {
                ordersDay,
                avgCartDay
            };
        }

        private List<string> DaysOfWeek()
        {
            return new List<string>()
            {
                DayOfWeek.Monday.ToString(),
                DayOfWeek.Tuesday.ToString(),
                DayOfWeek.Wednesday.ToString(),
                DayOfWeek.Thursday.ToString(),
                DayOfWeek.Friday.ToString(),
                DayOfWeek.Saturday.ToString(),
                DayOfWeek.Sunday.ToString()
            };
        }
    }
}