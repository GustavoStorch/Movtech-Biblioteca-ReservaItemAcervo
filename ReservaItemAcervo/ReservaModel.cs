using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaItemAcervo
{
    [Table("mvtBibReserva")]
    public class ReservaModel
    {
        public string TipoMovimento { get; set; }

        public string DataReserva { get; set; }

        public string PrazoReserva { get; set; }

        //public string Encerrar { get; set; }

        [ForeignKey("mvtBibItemAcervo")]
        [Column("codItem")]
        public string CodItem { get; set; }

        public virtual ItemAcervoModel ItemAcervoModel { get; set; }

        [ForeignKey("mvtBibLeitor")]
        [Column("codLeitor")]
        public string CodLeitor { get; set; }

        public virtual LeitorModel LeitorModel { get; set; }
    }
}
