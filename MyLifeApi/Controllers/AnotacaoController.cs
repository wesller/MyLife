using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLifeApi.DataBase;
using MyLifeApi.DataBase.DAL;
using MyLifeModel.Domain;

namespace MyLifeApi.Controllers
{
    [ApiController]
    [Route("/anotacao")]
    public class AnotacaoController : ControllerBase
    {
        [HttpGet(Name = "Listar")]
        public IEnumerable<Anotacao> Get()
        {
            DataBaseContext context = new DataBaseContext();
            AnotacaoDAL anotacao = new AnotacaoDAL(context);

            return anotacao.List();
        }

        [HttpGet("{id}")]
        public Anotacao Get(int id) {
            DataBaseContext context = new DataBaseContext();
            AnotacaoDAL anotacao = new AnotacaoDAL(context);
            
            return anotacao.Get(id);
        }

        [HttpPost(Name = "Add")]
        public Anotacao Add(Anotacao anotacao)
        {
            Console.WriteLine($"Inicio a rota ADD com {anotacao.ToString()}");
            DataBaseContext context = new DataBaseContext();
            AnotacaoDAL anotacaoDAL = new AnotacaoDAL(context);
            anotacaoDAL.Add(anotacao);
            return anotacao;
        }

    }
}
