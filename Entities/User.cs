namespace DataTransferObjectIntro.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CreditCardNumber { get; private set; }

        public User(int id, string name, string creditCardNumber)
        {
            this.Id = id;
            this.Name = name;
            this.CreditCardNumber = creditCardNumber;
        }
    }
}