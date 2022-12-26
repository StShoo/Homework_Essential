using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_E_4_task_2
{
    internal class Player: IRecodable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Music is playing");
        }
        public void Record()
        {
            Console.WriteLine("Music is recording");
        }
        public void Pause()
        {
            Console.WriteLine("Music is on pause");
        }
        public void Stop()
        {
            Console.WriteLine("Music is stoped");
        }
    }
}
