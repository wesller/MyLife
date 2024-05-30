namespace MyLifeApi.DataBase.DAL
{
    public abstract class GenericDAL<T> where T : class
    {
        private readonly DataBaseContext _context;

        protected GenericDAL(DataBaseContext context)
        {
            _context = context;
        }

        public IEnumerable<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Set<T>().Update(obj);
            _context.SaveChanges();
        }

        public void Del(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Find<T>(id);
        }



    }
}
