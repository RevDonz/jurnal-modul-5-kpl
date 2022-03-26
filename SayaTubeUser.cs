using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_1302204051
{
    internal class SayaTubeUser
    {
        int id;
        string username;
        List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            Random rnd = new Random();
            this.id = rnd.Next(0, 100000);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + this.username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul : " + this.uploadedVideos[i].getTitle());
            }
        }
    }
}
