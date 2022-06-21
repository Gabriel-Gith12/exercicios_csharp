using BaseDeDados.Pessoas;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using System.Collections.Generic;

namespace Negocio.Pessoas
{
    public class TipoUsuarioNG
    {
        public readonly TipoUsuarioBD _bd;

        public TipoUsuarioNG()
        {
            _bd = new TipoUsuarioBD();
        }
        // metodo que busca o codigo e a descricao do tipo de usuario
        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigoUsuario)
        {
            return _bd.BuscarTipoUsuarioDoUsuario(codigoUsuario);
        }
        public TipoUsuario Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }
    }
}
