namespace Homework_E_4_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayable playerPlay = new Player();
            playerPlay.Play();
            playerPlay.Pause();
            playerPlay.Stop();

            IRecodable playerRecord = new Player();
            playerRecord.Record();
            playerRecord.Pause();
            playerRecord.Stop();
        }
    }
}