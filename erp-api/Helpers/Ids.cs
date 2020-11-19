using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System;
// using erp_api.Models;
// using erp_api.Data.DTO;

namespace erp_api.Helpers
{
    public class GenerateId
    {
        private string PATH = @"/Helpers/ids.json";//"../appsettings.json";
        private string path {get; set;}
        private JObject Ids {get; set;}
        private string Type {get; set;}

        public GenerateId(string path2root, string type)
        {
            this.Type = type;
            this.path = path2root + this.PATH;
        }

        public string Generate()
        {
            string newId = this.Type;
            Ids ids = Read();
            if (this.Type == "C")
            {
                ids.Client +=1;
                newId+=ids.Client.ToString();
            }
            else if (this.Type == "II")
            {
                ids.ItemInfo +=1;
                newId+=ids.ItemInfo.ToString();
            }
            else if (this.Type == "O")
            {
                ids.Order +=1;
                newId+=ids.Order.ToString();
            }
            else if (this.Type == "OI")
            {
                ids.OrderItem +=1;
                newId+=ids.OrderItem.ToString();
            }
            else if (this.Type == "P")
            {
                ids.Process +=1;
                newId+=ids.Process.ToString();
            }
            else if (this.Type == "PI")
            {
                ids.ProcessInfo +=1;
                newId+=ids.ProcessInfo.ToString();
            }
            else if (this.Type == "S")
            {
                ids.Supplier +=1;
                newId+=ids.Supplier.ToString();
            }
            else if (this.Type == "TM")
            {
                ids.TeamMember +=1;
                newId+=ids.TeamMember.ToString();
            }
            else if (this.Type == "TI")
            {
                ids.TradingInfo +=1;
                newId+=ids.TradingInfo.ToString();
            }
            Write(ids);
            return newId;
        }

        private Ids Read()
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                Ids ids = (Ids)serializer.Deserialize(file, typeof(Ids));
                Console.WriteLine(ids.Client);
                return ids;
            }
        }

        private void Write(Ids ids)
        {
            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, ids);
            }
        }
    }

    public class Ids
    {
        public int Client { get; set; }
        public int ItemInfo { get; set; }
        public int Order { get; set; }
        public int OrderItem { get; set; }
        public int Process { get; set; }
        public int ProcessInfo { get; set; }
        public int Supplier { get; set; }
        public int TeamMember { get; set; }
        public int TradingInfo { get; set; }
    }
}