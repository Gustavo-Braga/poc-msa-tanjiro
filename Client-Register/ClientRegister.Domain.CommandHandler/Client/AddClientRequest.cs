namespace ClientRegister.Domain.CommandHandler.Client
{
    public class AddClientRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ZipCode { get; set; }
    }
}
