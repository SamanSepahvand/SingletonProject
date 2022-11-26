namespace SingletonProject.Infrastructure
{


    public interface IRepository
    {
        void Save();
        List<int> GetAll();
    }



    public class SQLRepository : IRepository
    {
        public List<int> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class LocalRepository : IRepository
    {
        public List<int> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class NullRepo : IRepository
    {
        public List<int> GetAll()

        {
            throw new NotImplementedException();
        }

        public void Save()

        {

            throw new NotImplementedException();

        }
    }

    public interface IRepoFactory
    {
        IRepository GetRepository(string type);
    }




    public class Factory : IRepoFactory
    {
        public IRepository GetRepository(string type)
        {



            switch (type)
            {

                case "lOCAL":
                    return new LocalRepository();
                  
                case "SQL":
                    return new SQLRepository();
                
                default:
                    return new  NullRepo();
            }
        }
    }
}
