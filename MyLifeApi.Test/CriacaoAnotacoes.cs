using MyLifeModel.Domain;

namespace MyLifeApi.Test
{
    public class CriacaoAnotacoes
    {
        [Fact]
        public void NovaAnotacao()
        {
            //arrange
            Anotacao anotacao = new Anotacao();
            anotacao.Id = 1;
            anotacao.Descricao = "Anotacao 1";
            

            //act
            
            //assert
            Assert.Equal("Anotacao 1", anotacao.Descricao);
        }
    }
}