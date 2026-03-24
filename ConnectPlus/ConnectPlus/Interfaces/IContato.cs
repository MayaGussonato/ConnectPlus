using ConnectPlus.Models;

namespace ContatoAPI.Interfaces;

public interface IContatoRepository
{
    // Retorna todos os contatos
    List<Contato> Listar();

    // Cadastra um contato novo
    void Cadastrar(Contato novo);

    // Atualiza um contato existente
    void Atualizar(Guid id, Contato contatoAtualizado);

    // Deleta um contato pelo Id
    void Deletar(Guid id);

    // Busca um contato pelo Id
    Contato BuscarPorId(Guid id);        
}