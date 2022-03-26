namespace jurnal5_1302204051;

internal class MainClass
{
    public static void Main(string[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("Doni");

        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Spider-Man oleh Doni");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film The Batman oleh Doni");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Dr. Strange oleh Doni");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Spongebob oleh Doni");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Shingeki No Kyojin oleh Doni");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Nanatsu No Taizai oleh Doni");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Karakai Jouzu No Takagi-San oleh Doni");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Sono Bisque Doll wa Koi wo Suru oleh Doni");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Overlord oleh Doni");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Shuumatsu No Harem oleh Doni");

        user1.AddVideo(video1);
        user1.AddVideo(video2);
        user1.AddVideo(video3);
        user1.AddVideo(video4);
        user1.AddVideo(video5);
        user1.AddVideo(video6);
        user1.AddVideo(video7);
        user1.AddVideo(video8);
        user1.AddVideo(video9);
        user1.AddVideo(video10);

        user1.PrintAllVideoPlaycount();

        for (int i = 0; i < 86; i++)
        {
            video1.IncreasePlayCount(25000000);
        }

        Console.WriteLine("Total Play Count dari user " + user1.username + " : " + user1.GetTotalVideoPlayCount());


    }
}