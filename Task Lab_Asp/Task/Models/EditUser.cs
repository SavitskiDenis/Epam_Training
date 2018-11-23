using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task.Models
{
    public class EditUser
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Не верный размер текста")]
        public string Name { get; set; }

        [Display(Name = "Middle name")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Не верный размер текста")]
        public string MiddleName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Не верный размер текста")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Range(18, 99, ErrorMessage = "Не верное значение")]
        public byte Age { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"\+\([0-9]{3}\)-[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}", ErrorMessage = "Номер должен быть в формате +(nnn)-nn-nnn-nn-nn")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 20, ErrorMessage = "Не верный размер текста")]
        public string Address { get; set; }
    }
}