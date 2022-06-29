using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain.Services
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

        internal string ServiceType { get; set; }
        internal double PercentageDiscount { get; set; }
        internal int TotalAttendance { get; set; }
    }
}
