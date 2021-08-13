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
        public string Nome { get; set; }
        public Tipo TipoAlimento { get; set; }
    }
}
