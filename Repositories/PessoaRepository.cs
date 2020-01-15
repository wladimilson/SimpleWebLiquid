using System.Collections.Generic;
using System.Linq;
using SimpleWebLiquid.Models;

namespace SimpleWebLiquid.Repositories
{
    public class PessoaRepository
    {
        private static Dictionary<int, Pessoa> pessoas = new Dictionary<int, Pessoa>();

        public List<Pessoa> GetAll(){
            return pessoas.Values.ToList();
        }

        public void Add(Pessoa pessoa){
            pessoa.Id = pessoas.Count + 1;
            pessoas.Add(pessoa.Id, pessoa);
        }
    }
}