using BlazorServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Repos
{
   public interface IOperationRepo
    {
        List<Operation> GetOperations();
        void AddOperation(Operation operation, Device device);
        void DeleteOperation(int id);
        Operation GetOperationById(int OperationId);

        void UpdateOperation(Operation operation,Device device);
    }
}
