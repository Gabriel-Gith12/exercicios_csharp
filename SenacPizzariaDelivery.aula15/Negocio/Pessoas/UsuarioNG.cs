using BaseDeDados;
using BaseDeDados.Pessoas;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using System;
using System.Collections.Generic;

namespace Negocio.Pessoas
{
    public class UsuarioNG
    {
        private readonly UsuarioBD _bd;
        private readonly FuncoesBD _funcoesBD;

        public UsuarioNG()
        {
            _bd = new UsuarioBD();
            _funcoesBD = new FuncoesBD();
        }

        public List<Usuario> ListarUsuarios()
        {
            return _bd.ListarUsuarios();
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }

        public Usuario Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }
        public int BuscarProximoCodigo()
        {
            return _funcoesBD.BuscarProximoCodigo("SHOW TABLE STATUS LIKE 'usuario'");
        }

        public bool Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
