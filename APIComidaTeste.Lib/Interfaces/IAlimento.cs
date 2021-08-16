using APIComidaTeste.Lib.ModelsView;
using APIComidaTeste.LIB.ModelsDB;
using System;
using System.Collections.Generic;

namespace APIComidaTeste.LIB.Interfaces
{
    public interface IAlimento
    {
        Model_Alimento BuscarAlimento(string nomeAlimento);
        Model_Alimento BuscarAlimento(Guid guid);
        IEnumerable<Model_Alimento> ListarAlimentos();
        int CadastroAlimento(Model_Alimento alimento);
        List<Model_Alimento> RandomAliemento();
        int AtualizarAlimento(Model_Alimento alimento);
    }
}
