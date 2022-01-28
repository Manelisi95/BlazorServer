using BlazorServer.Model;
using BlazorServer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.UseCases
{
    public class OperationUseCase : IOperationRepo
    {
        private readonly IOperationRepo operationRepo;

        public OperationUseCase(IOperationRepo operationRepo)
        {
            this.operationRepo = operationRepo;
        }


        public void AddOperation(Operation operation, Device device)
        {
            operationRepo.AddOperation(operation, device);
        }

        public void DeleteOperation(int id)
        {
            operationRepo.DeleteOperation(id);
        }

        public Operation GetOperationById(int OperationId)
        {
            return operationRepo.GetOperationById(OperationId);
        }

        public List<Operation> GetOperations()
        {
            return operationRepo.GetOperations();
        }

        public void UpdateOperation( Operation operation,Device device)
        {
                  
              operationRepo.UpdateOperation(operation,device);
        }
    }
}
