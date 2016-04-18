using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GuestService.Models
{
    public class FeedbackFormContext
    {
        [DisplayName("ФИО:")]
        [DataType(DataType.Text), Required(ErrorMessage = "Введите ФИО"), MaxLength(50)]
        public string Name { get; set; }

        [DisplayName("E-mail:")]
        [DataType(DataType.EmailAddress), Required(ErrorMessage = "Введите e-mail"), MaxLength(50)]
        public string Email { get; set; }

        [DisplayName("Телефон:")]
        [DataType(DataType.PhoneNumber), MaxLength(50)]
        public string Phone { get; set; }

        [DisplayName("Тема:")]
        [DataType(DataType.Text), Required(ErrorMessage = "Введите тему"), MaxLength(100)]
        public string Subject { get; set; }

        [DisplayName("Сообщение:")]
        [DataType(DataType.MultilineText), Required(ErrorMessage = "Введите сообщение")]
        public string Message { get; set; }
    }
}
