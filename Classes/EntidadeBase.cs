namespace GM.Filmes //Retirar o .Classes, faz valer pra todos itens do namespace.
{
    public abstract class EntidadeBase
    {
        public int Id {get; protected set;}
        //Todas classes que herdam dela tem o Id (identificador).
    }
}