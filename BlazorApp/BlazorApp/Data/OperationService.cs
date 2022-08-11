using BlazorApp.Data.Model;

namespace BlazorApp.Data
{
    public class OperationService : IOperationService
    {

        private List<Operation> operationsList = new List<Operation>
        {
            new Operation
            {
                OperationId = Guid.NewGuid(),
                Name = "First Operation",
                OrderInWhichToPerform = 10,
                ImageData = "123",
                Device = new Device
                {
                    DeviceId = 2,
                    Name = "Device One",
                    Type = DeviceType.Camera
                }
            },
             new Operation
            {
                OperationId = Guid.NewGuid(),
                Name = "Second Operation",
                OrderInWhichToPerform = 20,
                ImageData = "456",
                Device = new Device
                {
                    DeviceId = 3,
                    Name = "Device Two",
                    Type = DeviceType.Printer
                }
            }
        };

        public void AddOperation(Operation Operation)
        {
            var id = Guid.NewGuid();
            Operation.OperationId = id;
            operationsList.Add(Operation);
        }

        public void DeleteOperation(Guid OperationId)
        {
           var opertaion = GetOperation(OperationId);
            operationsList.Remove(opertaion);
        }

        public Operation GetOperation(Guid Id)
        {
            return operationsList.SingleOrDefault(x => x.OperationId == Id);
        }

        public List<Operation> GetOperations()
        {
            return operationsList;
        }

        public void UpdateOperation(Operation Operation)
        {
            var getOldOperation = GetOperation(Operation.OperationId);
            getOldOperation.Name = Operation.Name;
            getOldOperation.OrderInWhichToPerform = Operation.OrderInWhichToPerform;
            getOldOperation.ImageData = Operation.ImageData;
            getOldOperation.Device = Operation.Device;
            
        }
    }
}
