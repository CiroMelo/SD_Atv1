using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Computer
    {
        public int id { get; set; }
        public string placa_mae { get; set; }
        public string processador { get; set; }
        public int memoria_ram { get; set; }
        public int armazenamento { get; set; }
        public string gpu { get; set; }
        public string fonte { get; set; }
    }
}