using APIComidaTeste.LIB.ModelsDB;
using System;
using System.Collections.Generic;

namespace APIComidaTeste.LIB.Interfaces
{
    public interface IAlimento
    {
        Model_Alimento BuscarAlimento(Guid ID);
        Model_Alimento BuscarAlimento(string nomeAlimento);
        IEnumerable<Model_Alimento> ListarAlimentos();
        void CadastroAlimento(Model_Alimento alimento);
        Model_Alimento RandomAliemento();
    }
}
