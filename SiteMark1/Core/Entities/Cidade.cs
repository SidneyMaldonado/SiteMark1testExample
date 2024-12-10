using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMark1.Entities
{
    [Table("tb_cidade")]
    public class Cidade
    {
        [Key]
        [Column("id_cidade")]
        public int IdCidade { get; set; }

        [Column("nm_cidade")]
        public string NmCidade { get; set; }

        [Column("dm_situacao")]
        public bool DmSituacao { get; set; }

        [Column("cd_estado")]
        public int CdEstado { get; set; }
    }
}
