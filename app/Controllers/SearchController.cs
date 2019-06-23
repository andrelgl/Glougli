using System.Collections.Generic;
using System.Linq;
using app.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers {
    [Route ("api/search")]
    public class SearchController : Controller {
        public GlougliDbCOntext Context { get; }

        public SearchController (GlougliDbCOntext context) {
            Context = context;
        }

        [HttpGet()]
        public ActionResult Get ([FromQuery]string query) {

            List<PaginaRank> paginas = new List<PaginaRank> ();

            var consulta = Context.Conteudo.Where(x => x.Palavra.Contains (query));
            
            var paginasBd = Context.Pagina;

            paginas.AddRange(from pag in paginasBd
                             let count = consulta.Where(x => x.Id == pag.Id).Count()
                             select new PaginaRank()
                             {
                                 Titulo = pag.Titulo,
                                 Link = pag.Link,
                                 Avaliacao = count
                             });
            paginas = paginas.OrderBy (x => x.Avaliacao).ToList (); // Ordena a Lista de Páginas pela quantidade de Avaliacoes

            return Ok (paginas);
        }
    }
}