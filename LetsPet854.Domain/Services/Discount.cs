using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    public class Discount
    {
        public Discount()
        {
        }

        public Discount(string serviceType, double percentageDiscount, int totalAttendance)
        {
            ServiceType = serviceType;
            PercentageDiscount = percentageDiscount;
            TotalAttendance = totalAttendance;
        }

        public string ServiceType { get; set; }
        public double PercentageDiscount { get; set; }
        public int TotalAttendance { get; set; }
    }
}
