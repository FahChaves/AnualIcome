namespace annually.Entitis{

    abstract class TaxPayer{
        public string Name { get; set; }
        public double Anuallncome { get; set; }

        public TaxPayer(){

        }

        public TaxPayer(string name, double anuallncome){
            Name = name;
            Anuallncome = anuallncome;
        }

        public abstract double Tax();

    }
}