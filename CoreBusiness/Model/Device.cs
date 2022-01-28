using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Model
{
     public class Device
     {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType {get;set;}
     }
}
