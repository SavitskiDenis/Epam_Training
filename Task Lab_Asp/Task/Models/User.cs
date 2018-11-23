using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Task.Models
{
    public class User
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Не верный размер текста")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Не верный размер текста")]
        public string MiddleName { get; set; }

        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Не верный размер текста")]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [EmailAddress(ErrorMessage = "Некорректный e-mail")]
        public string E_mail { get; set; }

        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Не верный размер текста")]
        public string Password { get; set; }

        
        [Display(Name = "Подтвержение")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string Re_Password { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Range(18, 99, ErrorMessage = "Не верный дипозон")]
        public byte Age { get; set; }

        [Display(Name = "Номер телефона")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DataType(DataType.PhoneNumber)]
       [RegularExpression(@"\+\([0-9]{3}\)-[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}",ErrorMessage = "Номер должен быть в формате +(nnn)-nn-nnn-nn-nn")]
        public string Phone { get; set; }

        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 20, ErrorMessage = "Не верный размер текста")]
        public string Address { get; set; }
    }
}