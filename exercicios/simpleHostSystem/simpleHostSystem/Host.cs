namespace simpleHostSystem {
    class Host {
        public string Name { get; set; } // nome do Hóspede
        public string Email { get; private set; } // e-mail

        public Host(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return $"{Name}, {Email}";
        }
    }
}
