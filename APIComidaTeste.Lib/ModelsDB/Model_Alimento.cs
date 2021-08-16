using Simple.DatabaseWrapper.Attributes;
using System;
using static APIComidaTeste.Lib.EnumHelper;

namespace APIComidaTeste.LIB.ModelsDB
{
    public class Model_Alimento
    {
        [PrimaryKey]
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public TipoAlimento TipoAlimento { get; set; }

    }
}
