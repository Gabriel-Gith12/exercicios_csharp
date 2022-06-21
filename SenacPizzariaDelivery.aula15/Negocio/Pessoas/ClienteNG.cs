using BaseDeDados;
using BaseDeDados.Pessoas;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using System;
using System.Collections.Generic;

namespace Negocio.Pessoas
{
    public class ClienteNG
    {
        private readonly ClienteBD _bd;
        private readonly FuncoesBD _funcoesBD;

        public ClienteNG()
        {
            _bd = new ClienteBD();
            _funcoesBD = new FuncoesBD();
        }


        public List<EntidadeViewPesquisaCliente> ListarPesquisaCliente(Status status, string termoBusca)
        {
            return _bd.ListarPesquisaCliente(status, termoBusca);
        }

        public int BuscarProximoCodigo()
        {
            return _funcoesBD.BuscarProximoCodigo("SHOW TABLE STATUS LIKE 'cliente'");
        }

        public bool Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Cliente Buscar(int codigo)
        {
            return _bd.Buscar(codigo);
        }
        public Cliente BuscarPorContato(long numeroContato)
        {
            return _bd.BuscarPorContato(numeroContato);
        }

        public bool Inserir(Cliente oCliente)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(Cliente oCliente)
        {
            throw new NotImplementedException();
        }
    }
}
