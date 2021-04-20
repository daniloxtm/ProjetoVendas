using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DateNascimento { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dateNascimento, double baseSalario, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DateNascimento = dateNascimento;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }
        public void AddVendas(RegistroVendas rg)
        {
            Vendas.Add(rg);
        }
        public void RemoveVendas(RegistroVendas rg)
        {
            Vendas.Remove(rg);
        }
        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(rg => rg.Data >= inicial && rg.Data <= final).Sum(rg => rg.Quantidade);
        }
    }
}
