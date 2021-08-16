using APIComidaTeste.Lib.ModelsView;
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
        public int CadastroAlimento(Model_Alimento alimento)
        {
            var codigo = DB.InsertOrReplace(alimento);
            return (int)codigo;
        }
        public List<Model_Alimento> RandomAliemento()
        {
            Random r = new();
            var listaAlimentos = ListarAlimentos().ToList();
            var randomAlimentos = new List<Model_Alimento>();

            for (int i = 0; i < 4; i++)
            {
                int number = r.Next(listaAlimentos.Count());
                randomAlimentos.Add(listaAlimentos.ElementAt(number));
                listaAlimentos.RemoveAt(number);
            }

            return randomAlimentos;
        }
    }
}