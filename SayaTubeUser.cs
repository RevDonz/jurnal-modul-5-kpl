using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_1302204051
{
    internal class SayaTubeUser
    {
        int id;
        public string username { get; set; }
        List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            Random rnd = new Random();
            this.id = rnd.Next(0, 100000);
            this.uploadedVideos = new List<SayaTubeVideo>();

            Debug.Assert(username != null, "username tidak boleh kosong");
            
            Debug.Assert(username.Length <= 100, "Username tidak boleh lebih dari 100 karakter");

            this.username = username;
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
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul : " + this.uploadedVideos[i].getTitle());
            }
        }
    }
}
