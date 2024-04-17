using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPGApi.Data;
using RPGApi.Models;

namespace RPGApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ArmasController : ControllerBase
    {
        private static List<Arma> armas = new List<Arma>()
        {
        new Arma() { Id = 1, Nome = "Adaga", Dano =25},
        new Arma() { Id = 2, Nome = "Espada", Dano =43},
        new Arma() { Id = 3, Nome = "Ácido", Dano =103},
        new Arma() { Id = 4, Nome = "Bastão", Dano =2},
        new Arma() { Id = 5, Nome = "Pistola", Dano =89},
        new Arma() { Id = 6, Nome = "Granada", Dano =250},
        new Arma() { Id = 7, Nome = "Arco e flecha", Dano =124}
        };

    private readonly DataContext _context;

    public ArmasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")] //buscar pelo id
            public async Task<IActionResult> GetSingle(int id)
            {
                try
                {
                    Arma p = await _context.TB_ARMAS
                        .FirstOrDefaultAsync(pBusca => pBusca.Id == id);
                    return Ok(p);
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpGet("GetAll")]
            public async Task<IActionResult> Get()
            {
                try
                {
                    List<Arma> lista = await _context.TB_ARMAS.ToListAsync();
                    return Ok(lista);
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpPost]
            public async Task<IActionResult> Add(Arma novaArma)
            {
                try
                {
                    await _context.TB_ARMAS.AddAsync(novaArma);
                    await _context.SaveChangesAsync();
                    return Ok(novaArma.Id);
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                try
                {
                    Arma pRemover = await _context.TB_ARMAS.FirstOrDefaultAsync(p => p.Id == id);
                    
                    _context.TB_ARMAS.Remove(pRemover);
                    int linhaAfetadas = await _context.SaveChangesAsync();
                    return Ok(linhaAfetadas);
                }
                catch (System.Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
    }
}