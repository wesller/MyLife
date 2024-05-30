using MyLifeModel.Domain;

namespace MyLifeApi.DataBase.DAL
{
    public class AnotacaoDAL : GenericDAL<Anotacao>
    {
        private readonly DataBaseContext _context;

        public AnotacaoDAL(DataBaseContext context) : base(context) { }

    }
}
