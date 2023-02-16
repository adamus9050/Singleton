

public class Singleton
{
    private static Singleton instance = null;
    private static readonly object _lock = new object(); 
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (_lock)  //jesli lock active to znaczy, że jakiś wątek działa na tej instancji i inny nie może wejść.                {
                    if(instance==null)
                    {
                        instance = new Singleton();
                    }

                }
                
            }
            return instance;
        }
    }
}