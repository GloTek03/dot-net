namespace WinFormsApp
{
    internal class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Customer()
        {

        }

        public Customer(string id, string name, string birthdate, string gender, string address)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Gender = gender;
            Address = address;
        }
    }
}