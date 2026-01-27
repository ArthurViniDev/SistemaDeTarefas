using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> BuscarPorId(int id);
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<bool> Deletar(int id);
    }
}
