using BlazorServer.Model;
using BlazorServer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InMemoryData
{
    public class OperationInMemory : IOperationRepo
    {

        private List<Operation> operations;
      
        public OperationInMemory()
        {
            operations = new List<Operation>()
            {
                new Operation { OperationID = 1,Name= "First Opertion",OrderInWhichToPerform=1,ImageData= new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 }, device = new Device() { DeviceID = 1, Name = "Jam Jam", DeviceType = DeviceType.BarcodeScanner} },

              //  new Operation { OperationID =1,Name= "second Opertion",OrderInWhichToPerform=2,ImageData= new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 },}
            };
        }

        public void AddOperation(Operation operation, Device device)
        {
            
            if (operations.Any(x => x.Name.Equals(operation.Name, StringComparison.OrdinalIgnoreCase)))
                return;
            if (operations != null && operations.Count > 0)
            {
                var operationId = operations.Max(x => x.OperationID);
                var deviceId = operations.Max(x => x.device.DeviceID);

                operation.OperationID = operationId + 1;

                

                operation.device = new Device()
                {
                    DeviceID = deviceId + 1,
                    Name = device.Name,
                    DeviceType = device.DeviceType
                };
            }
            else
            {
                operation.OperationID = 1;
            }

            operations.Add(operation);
            
        }

        public void DeleteOperation(int OperationId)
        {

            operations?.Remove(GetOperationById(OperationId));
        }

        public Operation GetOperationById(int OperationId)
        {
            return operations?.FirstOrDefault(x => x.OperationID == OperationId);
        }

        public List<Operation> GetOperations()
        {
            return operations;
        }

        public void UpdateOperation(Operation operation,Device device)
        {
            var UpdateOperation = GetOperationById(operation.OperationID);

            if(UpdateOperation != null)
            {

                operation.device  = new Device()
                {
                    Name = device.Name,
                    DeviceType = device.DeviceType
                };

                UpdateOperation = operation;
            }
        }
    }
}