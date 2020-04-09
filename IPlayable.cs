namespace DZ_IPlayableSpace
{
    public class IPlayable
    { 
        void Play()
        {
            System.Console.WriteLine("Is being played ...");     // Проигрывается
        }
        void Pause()
        {
            System.Console.WriteLine("On pause ...");           // На паузе
        }
         void Stop()
        {
            System.Console.WriteLine("Stopped ...");            // Остановлен
        }
    }
}