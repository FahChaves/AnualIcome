using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using annually.Entitis;

namespace annually{
    class Program{
        static void Main(string[] args){

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                Console.Write($"tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                    double anuallncome =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(ch == 'i'){
                    Console.Write("Health expenditures: ");
                    double heathExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anuallncome, heathExpenditures));
                }
                else if(ch == 'c'){
                    Console.Write("Number of employees: ");
                    int numberOfEmployess = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anuallncome, numberOfEmployess));
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer t in list){
                double tax = t.Tax();
                Console.WriteLine(t.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}