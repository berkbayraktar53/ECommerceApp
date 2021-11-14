using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApp.WebUI.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage = "İsim boş geçilemez")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Soyisim boş geçilemez")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Email boş geçilemez")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Şehir boş geçilemez")]
        public string City { get; set; }

        //[Required(ErrorMessage = "Adres boş geçilemez")]
        //[MinLength(10,ErrorMessage ="Minimum 10 karakter olmalıdır")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Yaş boş geçilemez")]
        //[Range(18, 65)]
        public int Age { get; set; }
    }
}