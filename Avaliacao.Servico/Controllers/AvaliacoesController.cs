using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avaliacao.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao.Servico.Controllers
{
    [Produces("application/json")]
    [Route("api/Avaliacoes")]
    public class AvaliacoesController : Controller
    {
        private readonly AvaliacaoRep _rep = new AvaliacaoRep();
        public string Avaliar(Dominio.Avaliacao avaliacao)
        {
            try
            {
                 _rep.Avaliar(avaliacao);
                return "Avaliação registrada com sucesso!";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<decimal> GetPontuacaoPorUsuarioAsync(int idUsuario, int idCliente)
        {
            try
            {
                return await _rep.GetPontuacaoPorUsuarioAsync(idUsuario, idCliente);
            }   
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Dominio.Avaliacao>> GetAvaliacoesPorUsuario(int idUsuario, int idCliente)
        {
            try
            {
                return await _rep.GetAvaliacoesPorUsuario(idUsuario, idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



    }
}