using System;
using System.Collections.Generic;
using GM.Filmes.Interfaces;

namespace GM.Filmes
{
    public class FilmeRepositorio: IRepositorio<Filme> //Implementa uma interface IRepositorio de Séries, reaproveitando a interface com esses tipos genéricos.
    {
      private List<Filme> listaFilme = new List<Filme>();
      public void Atualiza(int id, Filme objeto)
      {
          listaFilme[id] = objeto;
      }
      public void Exclui(int id)
      {
          listaFilme[id].Excluir(); //remover item do vetor (REMOVEAT), ele vai reclassificar os proximos itens.
      }
      public void Insere(Filme objeto)
		{
			listaFilme.Add(objeto);
		}

		public List<Filme> Lista()
		{
			return listaFilme;
		}

		public int ProximoId()
		{
			return listaFilme.Count;
		}

		public Filme RetornaPorId(int id)
		{
			return listaFilme[id];
		}
    }
}