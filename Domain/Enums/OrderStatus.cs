using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum OrderStatus 
    {
        [Display(Name = "В ожидании")]
        Await = 1,
        [Display(Name = "В доставке")]
        Delivery = 2,
        [Display(Name = "Доставлен")]
        Done = 3,
    }
}
