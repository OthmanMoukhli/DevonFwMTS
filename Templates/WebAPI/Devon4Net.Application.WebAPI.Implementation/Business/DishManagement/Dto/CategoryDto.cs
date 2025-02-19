using System.Collections.Generic;

namespace Devon4Net.Application.WebAPI.Implementation.Business.DishManagement.Dto
{
public class CategoryDto
    {
        public long id { get; set; }
        public int? modificationCounter { get; set; }
        public int revision { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int? showOrder { get; set; }
    }
}
