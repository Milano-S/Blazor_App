using BlazorApp.Data.Model;

namespace BlazorApp.Data
{
   
        public interface IOperationService
        {
            List<Operation> GetOperations();

            Operation GetOperation(Guid OperationId);

            void UpdateOperation(Operation Operation);

            void AddOperation(Operation Operation);
            void DeleteOperation(Guid OperationId);
        }
    
}
