namespace annually.Entitis{
    class Company : TaxPayer{
        public int NumberOfEmployess { get; set; }

        public Company(){

        }

        public Company(string name, double anuallncome,int numberOfEmployess): base (name, anuallncome){
            NumberOfEmployess = numberOfEmployess;
        }

        public override double Tax()
        {
            if(NumberOfEmployess > 10){
                return Anuallncome * 0.14;

            }
            else{
            return Anuallncome * 0.16;
            }
        }
    }
}