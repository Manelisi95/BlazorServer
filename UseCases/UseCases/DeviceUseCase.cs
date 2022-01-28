using BlazorServer.Model;
using BlazorServer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.UseCases
{
    public class DeviceUseCase : IDeviceRepo
    {
        private readonly IDeviceRepo deviceRepo;

        public DeviceUseCase(IDeviceRepo deviceRepo)
        {
            this.deviceRepo = deviceRepo;
        }

        public void AddDevice(Device device)
        {
            deviceRepo.AddDevice(device);
        }

        public Device GetDevices()
        {
            return deviceRepo.GetDevices();
        }
    }
}
