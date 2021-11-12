using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name ="Введіть ім'я")]
        [StringLength(25)]
        [Required(ErrorMessage ="Довжина імені не менше 2 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть Прізвище")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина прізвища не менше 5 символів")]
        public string surname { get; set; }

        [Display(Name = "Введіть адресу")]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина адреси не менше 10 символів")]
        public string adress { get; set; }

        [Display(Name = "Введіть номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина імені не менше 10 символів")]
        public string phone { get; set; }

        [Display(Name = "Введіть Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина імені не менше 2 символів")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}