using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum DeliveryType
    {
        [Display(Name = "Самовывоз")]
        Pickup = 1,
        [Display(Name = "Доставка")]
        Delivery = 2,
    }
}
