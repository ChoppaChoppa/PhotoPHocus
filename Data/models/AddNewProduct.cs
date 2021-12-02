using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Data.models
{
    public class AddNewProduct
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Название")]
        [MinLength(0)]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string Name { get; set; }

        [Display(Name = "Короткое описание")]
        [MinLength(0)]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string ShortDescription { get; set; }

        [Display(Name = "длинное описание")]
        [MinLength(0)]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string LongDescription { get; set; }

        [Display(Name = "Расположение изображения")]
        [MinLength(5)]
        [Required(ErrorMessage = "Введите корректный путь")]
        public string img { get; set; }

        [Display(Name = "Цена")]
        public ushort Price { get; set; }

        public bool IsFavorite { get; set; }

        public bool available { get; set; }

        public int CategoryID { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
