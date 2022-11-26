
namespace SingletonProject.Infrastructure
{
    public class ViewCounter 
    {
        private static ViewCounter _instance;

        public int Count { get; set; } = 0;

        private ViewCounter()
        {

        }

        public static ViewCounter GetInstance()
        {
            if (_instance == null)
                _instance = new ViewCounter();
            return _instance;

        }
  public void AddCount()
        {
            Count++;
        }
    }
}
