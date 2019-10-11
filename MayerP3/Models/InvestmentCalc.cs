using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MayerP3.Models
{
    public class InvestmentCalc
    {
        private int cmpPerYr;
        private double interest;
        private double principle;
        private int years;

        public InvestmentCalc() : this(1, 1, 0.0, 1)
        {

        }

        public InvestmentCalc(double principle, int years, double interest, int numTimes)
        {
            this.principle = principle;
            this.years = years;
            this.interest = interest;
            this.cmpPerYr = numTimes;
            Calc();
        }

        [Required, Range(1, 24)]
        public int CmpPerYr
        {
            get => cmpPerYr;

            set
            {
                cmpPerYr = value;
                Calc();
            }
        }

        [Required, Range(0.0, 100.0)]
        public double Interest
        {
            get => interest;

            set
            {
                interest = value;
                Calc();
            }
        }

        [Required, Range(0, Double.MaxValue)]
        public double Principle
        {
            get => principle;

            set
            {
                principle = value;
                Calc();
            }
        }

        [Required, Range(1, 30)]
        public int Years
        {
            get
            {
                return years;
            }

            set
            {
                years = value;
                Calc();
            }
        }

        [DisplayFormat(DataFormatString = "{0:C)")]
        public double FutureValue { get; private set; }

        private void Calc()
        {
            //Formula: A = P(1+r/n)^nt
            //  A is future value
            //  P is principle
            //  r is interest rate
            //  n is numer of times compounded per year
            //  y is num years 

            //Calculating this formule in discrete steps for debugging purposes
            // (1+(r/n))
            double parens = (1 + ((interest / 100.0) / (double)cmpPerYr));
            // nt
            double exponent = cmpPerYr * years;
            // P(1+(r/n))^nt
            double result = principle * Math.Pow(parens, exponent);
            //Finally use Round method to round to hundredths place.
            FutureValue = Math.Round(result, 2, MidpointRounding.AwayFromZero); 
        }
        
    }
}
