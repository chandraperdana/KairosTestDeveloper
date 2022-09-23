using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoalA.Models
{
    public class Barang
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        [DisplayName("Nama Barang")]
        public string Nama_Barang { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Kode barang")]
        public string Kode_Barang { get; set; }
        [Required]
        [DisplayName("Jumlah Barang")]
        public int Jumlah_Barang { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }
    }
}
