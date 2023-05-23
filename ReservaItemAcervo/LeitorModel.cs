using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaItemAcervo
{
    [Table("mvtBibLeitor")]
    public class LeitorModel
    {
        [Key()]
        public string CodLeitor { get; set; }

        public string NomeLeitor { get; set; }
    }
}
