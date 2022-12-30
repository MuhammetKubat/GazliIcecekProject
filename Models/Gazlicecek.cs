using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Gazlicecek
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        [DisplayName("Marka")]
        [Required(ErrorMessage ="Bu alan doldurunuz.")]
        [MaxLength(12,ErrorMessage ="Sadece 12 karakter olmali.")]
        public string Marka { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Tür")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Tur { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Boyut")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Boyut { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Detail")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string Detail { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Seker")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Seker { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Calories")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Calories{ get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Carbohy.")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Carbohydrates{ get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Ulke")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Ulke{ get; set; }
        
        [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Ozellik1")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Ozellik1{ get; set; }
          [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Ozellik2")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Ozellik2{ get; set; }
          [Column(TypeName = "nvarchar(30)")]
        [DisplayName("Ozellik3")]
        [Required(ErrorMessage = "Bu alan doldurunuz.")]
        public string Ozellik3{ get; set; }

        [DisplayName("KuruluşYılı")]
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime KYili { get; set; }
        public string IcecekPath{get; set;}
        public string IcecekFileName{get; set;}
          
       [NotMapped]
        public IFormFile ImageFile{get; set;}
  
        }

}
