import { Component, OnInit } from '@angular/core';
import { Chart } from '../../../models';
import { StatisticsService } from '../../../services';

@Component({
  selector: 'app-orders-day-avg-cart',
  templateUrl: './orders-day-avg-cart.component.html',
  styleUrls: ['./orders-day-avg-cart.component.css']
})
export class OrdersDayAvgCartComponent implements OnInit {

    constructor(private statisticsService: StatisticsService) { }

    ngOnInit(): void {
        this.getData();
    }

    public chart = {
        barChartOptions: {
            scaleShowVerticalLines: false,
            responsive: true
        },
        barChartType: 'bar',
        barChartLegend: true
    } as Chart;
    
    public chart2 = {
        barChartOptions: {
            scaleShowVerticalLines: false,
            responsive: true
        },
        barChartType: 'line',
        barChartLegend: true
    } as Chart;

    getData():void{
        this.statisticsService.get_ordersDay_avgCart()
            .subscribe(stats => {
                this.chart.barChartLabels = stats[0].x;
                this.chart.barChartData = [{data: stats[0].y, label: '# Orders'}];
                this.chart.title = stats[0].title;
                
                this.chart2.barChartLabels = stats[1].x;
                this.chart2.barChartData = [{data: stats[1].y, label: 'Avg. cart [€]'}];
                this.chart2.title = stats[1].title;
            });
    }

}
