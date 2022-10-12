using System;
using System.ComponentModel.DataAnnotations;
namespace Commutator.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Модель")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        public string Title { get; set; }

        [Display(Name = "IP-адрес")]
        [RegularExpression("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$", ErrorMessage = "Введённое значение не соответствует IP-адресу")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        public string IP { get; set; }

        [Display(Name = "MAC-адрес")]
        [RegularExpression("^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$", ErrorMessage = "Введённое значение не соответствует MAC-адресу")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        public string Mac { get; set; }

        [Display(Name = "Управляющий VLAN")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        public string VLAN { get; set; }

        [Display(Name = "Серийный номер")]
        [RegularExpression("^[A-Z0-9]+$", ErrorMessage = "Вводить можно только цифры и большие буквы")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        [StringLength(15, ErrorMessage = "Максимальная длина 15 символов")]
        public string Sern { get; set; }

        [Display(Name = "Инвентарный номер")]
        [RegularExpression("^\\d+$", ErrorMessage = "Можно вводить только цифры")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        [StringLength(20, ErrorMessage = "Максимальная длина 20 символов")]
        public string Invn { get; set; }


        [Display(Name = "Дата покупки")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        [DataType(DataType.Date)]
        public DateTime BuyDate { get; set; }


        [Display(Name = "Дата установки")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        [DataType(DataType.Date)]
        public DateTime UstDate { get; set; }

        [Display(Name = "Этаж")]
        [Required(ErrorMessage = "Это поле нельзя оставлять пустым")]
        public int Atug { get; set; }

        [Display(Name = "Комментарий")]
        public string Koment { get; set; }

    }
}
