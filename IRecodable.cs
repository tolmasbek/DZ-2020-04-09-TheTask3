namespace DZ_IRecodableSpace
{
    public class IRecodable
    {
        void Record()
        {
            System.Console.WriteLine("Is recorded ...");        // Записывается 
        }
        void Pause()
        {
            System.Console.WriteLine("On pause ...");           // На паузе
        }
        void Stop()
        {  
            System.Console.WriteLine("Stopped ...");           // Остановлен
        }
    }
}