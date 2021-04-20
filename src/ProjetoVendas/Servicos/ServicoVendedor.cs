using ProjetoVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Servicos
{
    public class ServicoVendedor
    {
        public readonly ProjetoVendasContext _context;
        public ServicoVendedor(ProjetoVendasContext context)
        {
            _context = context;
        }

        public List<Vendedor> EncontrarTodos()
        {
            return _context.Vendedor.ToList();
        }

        public void Inserir(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
