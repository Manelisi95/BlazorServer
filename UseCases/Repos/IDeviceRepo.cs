using BlazorServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Repos
{
    public interface IDeviceRepo
    {
        void AddDevice(Device device);
        Device GetDevices();
       
    }
}
