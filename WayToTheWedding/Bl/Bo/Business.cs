using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Bo
{
    public class Business
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Category { get; set; }

        public int? CityId { get; set; }

        public string Adress { get; set; }

        public string PhoneNum { get; set; }

        public string OpeningHours { get; set; }

        public string MoreInfo { get; set; }

    }
}
