using DZ_IPlayableSpace;
using DZ_IRecodableSpace;

namespace DZ_PlayerSpace
{
    public class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            System.Console.WriteLine("Is being played | Проигрывается ...");    
        }
        public void Record()
        {
            System.Console.WriteLine("Is recorded | Записывается ...");   
        }  
        public void Pause()
        {
            System.Console.WriteLine("On pause | На паузе ...");  
        }
        public void Stop()
        {  
            System.Console.WriteLine("Stopped | Остановлен ...");           
        }
    }
}