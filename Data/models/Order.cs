using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Имя")]
        [MinLength(2)]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [MinLength(0)]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string surename { get; set; }

        [Display(Name = "Адрес")]
        [MinLength(0)]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Введите корректный номер телефона")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [MinLength(5)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Введите корректный email")]
        public string email { get; set; }
        
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime oderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
