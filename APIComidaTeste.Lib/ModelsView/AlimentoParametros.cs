using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static APIComidaTeste.Lib.EnumHelper;

namespace APIComidaTeste.Lib.ModelsView
{
    public class AlimentoParametros
    {
        public Guid? ID { get; set; }
        public string Nome { get; set; }
        public TipoAlimento TipoAlimento { get; set; }
    }
}
