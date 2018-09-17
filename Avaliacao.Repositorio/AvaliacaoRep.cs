using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.Repositorio
{
    public class AvaliacaoRep
    {
        private readonly Contexto db = new Contexto();
        public void Avaliar(Dominio.Avaliacao avaliacao)
        {
                db.Avaliacao.Add(avaliacao);   
        }

        public async Task<decimal> GetPontuacaoPorU
            arioAsync(int idUsuario, int idCliente)
        {
            var avaliacoes = db.Avaliacao.Where(c => c.UsuarioAvaliadoId == idUsuario && c.Ativo == true && c.IdCliente == idCliente).ToList();
            decimal resultado = 0;
            foreach (var item in avaliacoes)
                resultado += item.Estrelas;
            return  (resultado / avaliacoes.Count);

        }

        public async Task<List<Dominio.Avaliacao>> GetAvaliacoesPorUsuario(int idUsuario, int idCliente)
        {
            return await db.Avaliacao.Where(c => c.Ativo == true && c.IdCliente == idCliente && c.UsuarioAvaliadoId == idUsuario).ToListAsync();
        }

        
    }
}
