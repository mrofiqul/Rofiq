using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CountryCityApp.Models
{
    public class City
    {
        public int CityId { set; get; }
        [Display(Name ="City Name")]
        public string Name { set; get; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "City About")]
        public string About { set; get; }

        [Display(Name="No of dwellers")]
        public int NoOfDwelers { set; get; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "City Location")]
        public string Location { set; get; }
        
        [DataType(DataType.MultilineText)]
        [Display(Name = "City Weather")]
        public string Weather { set; get; }
        public int CountryId { set; get; }
        public virtual Country CityCountry { set; get; }

    }
}