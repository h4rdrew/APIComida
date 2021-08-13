using APIComidaTeste.LIB.Interfaces;
using APIComidaTeste.LIB.ModelsDB;
using Simple.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIComidaTeste.DA.Views
{
    public class Alimento_SQLite : IAlimento
    {
        #region DB
        public SqliteDB DB { get; }
        
        public Alimento_SQLite(SqliteDB DB)
        {
            this.DB = DB;
            DB.CreateTables()
              .Add<Model_Alimento>()
              .Commit();
        }
        #endregion
        public Model_Alimento BuscarAlimento(Guid ID)
        {
            return DB.Get<Model_Alimento>(ID);
        }
        public Model_Alimento BuscarAlimento(string nomeAlimento)
        {
            return DB.Get<Model_Alimento>("Nome", nomeAlimento);
        }
        public IEnumerable<Model_Alimento> ListarAlimentos()
        {
            var resultado = DB.GetAll<Model_Alimento>();
            return resultado;
        }

        public void CadastroAlimento(Model_Alimento alimento)
        {
            DB.InsertOrReplace(alimento);
        }

        public Model_Alimento RandomAliemento()
        {
            Random rnd = new();
            int r = rnd.Next(ListarAlimentos().Count());
            return ListarAlimentos().ElementAt(r);
        }
    }
}
