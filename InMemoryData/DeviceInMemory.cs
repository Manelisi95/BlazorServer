using BlazorServer.Model;
using BlazorServer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InMemoryData
{
   public class DeviceInMemory:IDeviceRepo
    {
       
        public DeviceInMemory()
        {
           
        }
        private List<Device> devices;
        public void AddDevice(Device device)
        {
            if (devices.Any(x => x.Name.Equals(device.Name, StringComparison.OrdinalIgnoreCase)))
                return;
            if (devices != null && devices.Count > 0)
            {
                var maxId = devices.Max(x => x.DeviceID);
                device.DeviceID = maxId + 1;
            }
            else
            {
                device.DeviceID = 1;
            }

            devices.Add(device);
        }

        public Device GetDevices()
        {
            throw new NotImplementedException();
        }

        /* public Device GetDevices()
         {

         }*/
    }
}
