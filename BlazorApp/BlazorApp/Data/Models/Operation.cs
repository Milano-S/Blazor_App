namespace BlazorApp.Data.Model
{
    public class Operation
    {
        //I decided to use a Guid as the unique identifier as using an int caused errors when querying the data
        public Guid OperationId { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }

        //I used a string instead of a byte array as i had trouble
        //displaying and assigning values to it in the operationService 
        public string ImageData { get; set; }

        public Device Device { get; set; }

    }
}
