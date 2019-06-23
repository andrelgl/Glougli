using System.Collections.Generic;
using System.Linq;
using app.Models;
using Microsoft.AspNetCore.Mvc;
using OpenNLP.Tools.Chunker;
using OpenNLP.Tools.Tokenize;

namespace app.Controllers
{
    [Route("api/search")]
    public class SearchController : Controller
    {
        public GlougliDbCOntext Context { get; }

        public SearchController(GlougliDbCOntext context)
        {
            Context = context;
        }

        [HttpGet()]
        public ActionResult Get([FromQuery]string query)
        {

//var sentence = new Sentence("Your text should go here");
//var lemmas = sentence.Lemmas;
//var pos = sentence.PosTags;

            // English tokenizer
            var tokenizer = new EnglishRuleBasedTokenizer(false);
            var tokens = tokenizer.Tokenize(query);

            var consulta = Context.Conteudo.Where(conteudo => tokens.Contains(conteudo.Palavra));

            var paginas = from pag in Context.Pagina
                          let count = consulta.Where(x => x.Id == pag.Id).Count()
                          select new PaginaRank()
                          {
                              Titulo = pag.Titulo,
                              Link = pag.Link,
                              Avaliacao = count
                          };

            paginas = paginas.OrderBy(x => x.Avaliacao); // Ordena a Lista de Páginas pela quantidade de Avaliacoes

            return Ok(paginas);
        }
    }
}