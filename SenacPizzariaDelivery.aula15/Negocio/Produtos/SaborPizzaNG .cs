using BaseDeDados;
using BaseDeDados.Pessoas;
using BaseDeDados.Produtos;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Produtos;
using Entidades.Sistema;
using System;
using System.Collections.Generic;

namespace Negocio.Produtos
{
    public class SaborPizzaNG
    {
        private readonly SaborPizzaBD _bd;
        private readonly FuncoesBD _funcoesBD;

        public SaborPizzaNG()
        {
            _bd = new SaborPizzaBD();
            _funcoesBD = new FuncoesBD();
        }

        public List<SaborPizza> ListarSaboresPizza()
        {
            return _bd.ListarSaboresPizza();
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            return _bd.ListarEntidadesViewPesquisa(status);
        }

        public Adicional Buscar(int codigo)
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
