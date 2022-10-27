using Chapter.Models;

namespace Chapter.Interface
{
    public interface IUsuarioRepository
    {
        List<Usuario> Lista();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario usuario);

        void Atualizar(int id, Usuario usuario);

        void Deletar(int id);

        Usuario Login(string email, string senha);
    }
}
