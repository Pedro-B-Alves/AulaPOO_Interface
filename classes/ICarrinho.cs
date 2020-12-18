namespace AulaPOO_Interface.classes
{
    public interface ICarrinho
    {
         // Criamos uma espécie de "contrato" para deixar obriatória a
         // implementação de todos os métodos e estruturas que herdarem dessa interdace
         void Listar();
         void Cadastrar(Produto produto);
         void Alterar(int _codigo, Produto produto);
         void Deletar(Produto produto);
    }
}