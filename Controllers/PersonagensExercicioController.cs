using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGApi.Models;
using RPGApi.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace RPGApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=19, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=169, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=1158, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo},
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=369, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago},
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=478, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=498, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo},
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago}
        };
        
        //  Exercício A
        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByNome(string nome)
        {
            List<Personagem> listaBusca = personagens.FindAll(p => p.Nome == nome);
            if(listaBusca.Count == 0){
            return NotFound("Personagem não encontrado!");
            }
            else{
            return Ok(listaBusca);
            }
        }
        
        // Exercício B
        [HttpPost("PostValidacao")]  
        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if(novoPersonagem.Defesa < 10 && novoPersonagem.Inteligencia > 30)
            return BadRequest("O personagem não pode conter esses valores.");

            personagens.Add(novoPersonagem);
            return Ok(personagens);
        }

        // Exercício C
        [HttpPost("PostValidacaoMago")]  
        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if(novoPersonagem.Inteligencia < 35)
            return BadRequest("Inteligência não pode ter seu valor menor que 35.");
            
            personagens.Add(novoPersonagem);
            return Ok(novoPersonagem);
        }

        // Exercício D
        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago()
        {
            Personagem pRemove = personagens.Find(p => p.Classe == ClasseEnum.Cavaleiro);
            personagens.Remove(pRemove);
            List<Personagem> listaBusca = personagens.OrderByDescending(p => p.PontosVida).ToList();
            return Ok(listaBusca);
        }

        // Exercício E
        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {
            return Ok("Quantidade de personagens: " + personagens.Count + " Soma das inteligências: " + personagens.Sum(p => p.Inteligencia));
        }

        // Exercício F
        [HttpGet("GetByClasse/{enumId}")]
        public IActionResult GetByClasse(int enumId)
        {
            ClasseEnum enumDigitado = (ClasseEnum)enumId;
            List<Personagem> listaBusca = personagens.FindAll(p => p.Classe == enumDigitado);
            return Ok(listaBusca);
        }
    }
}