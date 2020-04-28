using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_DataEntities
{
    public class CountryInformation
    {
        public string Country { get; set; }
        public string Cases { get; set; }
        public string TodayCases { get; set; }
        public string Deaths { get; set; }
        public string TodayDeaths { get; set; }
        public string Recovered { get; set; }
        public string Active { get; set; }
        public string Critical { get; set; }
        public string CasesPerOneMillion { get; set; }
        public string DeathsPerOneMillion { get; set; }
        public string TotalTests { get; set; }
        public string TestsPerOneMillion { get; set; }
    }
}
