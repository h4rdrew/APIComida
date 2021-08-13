using APIComidaTeste.LIB.Interfaces;

namespace APIComidaTeste.Lib.Interfaces
{
    public interface IDatabase
    {
        void Config();
        IAlimento Alimento { get; }
    }
}
