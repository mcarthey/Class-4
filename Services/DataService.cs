using Class_4.Dao;

namespace Class_4.Services
{
    public class DataService : IDataService
    {
        private IDataDao _dao;

        // constructor
        public DataService(IDataDao dao)
        {
            _dao = dao;
        }

        public void Invoke()
        {
            _dao.Read();
        }
    }
}
