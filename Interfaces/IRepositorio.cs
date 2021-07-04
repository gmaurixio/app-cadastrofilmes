using System.Collections.Generic; //Implementa os métodos, tipo genérico, independente do tipo de classe

namespace GM.Filmes.Interfaces
{
    public interface IRepositorio<T>
    {
     List<T> Lista();
     T RetornaPorId(int id);
     void Insere(T entidade);
     void Exclui(int id);
     void Atualiza(int id, T entidade);
     int ProximoId();
    }
}