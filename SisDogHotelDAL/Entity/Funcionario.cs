using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisDogHotelDAL.Entity
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdFuncionario")]
        public int IdFuncionario { get; set; }

        [Column("Nome")]
        [StringLength(50)]
        [Required]
        public string Nome { get; set; }

        [Column("LoginFuncionario")]
        [StringLength(20)]
        [Required]
        [Index("idxLoginFuncionario", IsUnique = true)]
        public string LoginFuncionario { get; set; }

        [Column("SenhaFuncionario")]
        [StringLength(50)]
        [Required]
        public string SenhaFuncionario { get; set; }

        [Column("CargoIDFK")]
        [Required]
        public int CargoID { get; set; }

        [ForeignKey("CargoID")]
        public virtual Cargo Cargo { get; set; }
    }
}
