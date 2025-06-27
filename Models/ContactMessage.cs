using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ComputerShopll.Models
{
    public class ContactMessage 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ và tên là bắt buộc.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung phản hồi.")]
        public string Message { get; set; }
    }
}
