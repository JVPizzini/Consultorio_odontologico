using ProjetoTCC2020.Models;

namespace ProjetoTCC2020.DAO
{
    interface IDataAccessObject<T>
    {
        T Get(int id);

        RetornoBanco Insert(T obj);

        RetornoBanco Update(T obj);

    }
}
