using ConnectPlus.Models;
using ContatoAPI.Interfaces;
using System.Data.SqlClient;

namespace ContatoAPI.Repositories;

public class ContatoRepository : IContatoRepository
{
    public void Atualizar(Guid id, Contato contatoAtualizado)
    {
        throw new NotImplementedException();
    }

    public Contato BuscarPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Contato novo)
    {
        throw new NotImplementedException();
    }

    public void Deletar(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Contato> Listar()
    {
        throw new NotImplementedException();
    }
}