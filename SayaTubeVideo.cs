using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_1302204051
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(0, 100000);
            this.playCount = 0;

            Debug.Assert(title != null);
            
            Debug.Assert(title.Length <= 200, "Title tdak boleh lebih dari 200 karakter");

            this.title = title;
        }

        public void IncreasePlayCount(int data)
        {
            Debug.Assert(this.playCount <= int.MaxValue);
            Debug.Assert(data <= 25000000, "Input tidak boleh lebih dari 25 juta");
            Debug.Assert(data > 0, "Input tidak boleh bilangan negatif");

            int test;
            try
            {
                test = checked(this.playCount + data);
                this.playCount += data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                this.playCount = this.playCount;
            }

        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Id : " + this.id);
            Console.WriteLine("Title : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount + "\n");
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
