 public class PersonalInfo
    {
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string SocialSecurityNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string ZipCode { get; set; } = "";
        public string City { get; set; } = "";

        public string Info()
        {
            return $"{Name} {LastName}, Telefonnummer: {PhoneNumber}, Personnummer: {SocialSecurityNumber}, Adress: {Address}, {ZipCode} {City}";
        }
    }
