using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramTaxes.Entities
{
    class Company : TaxPayer
    {
       
        public int EmpNumbers { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int empNumbers):base (name,anualIncome)
        {
            
            EmpNumbers = empNumbers;
        }

        public override double Tax()
        {
            if (EmpNumbers > 10)
            {
                return AnualIncome * 0.14;
            }
            else 
            { 
                return AnualIncome * 0.16;
            }
        }





    }
}
