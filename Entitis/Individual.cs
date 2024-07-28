namespace annually.Entitis{

    class Individual : TaxPayer{
        public double HeathExpenditures { get; set; }

        public Individual(){

        }

        public Individual(string name, double anuallncome, double heathExpenditures) : base (name, anuallncome){
            HeathExpenditures = heathExpenditures;
        }

        public override double Tax()
        {if(Anuallncome < 2000.00){
            return Anuallncome *0.15 - HeathExpenditures *0.5;
        }
        else{
           return Anuallncome *0.25 - HeathExpenditures * 0.5;
        }
        }
    }
}