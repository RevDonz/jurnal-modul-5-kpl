namespace jurnal5_1302204051;

internal class MainClass
{
    public static void Main(string[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("Doni");

        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Spider-Man oleh Doni");
        user1.AddVideo(video1);
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film The Batman oleh Doni");
        user1.AddVideo(video2);
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Dr. Strange oleh Doni");
        user1.AddVideo(video3);
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Spongebob oleh Doni");
        user1.AddVideo(video4);
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Shingeki No Kyojin oleh Doni");
        user1.AddVideo(video5);
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Nanatsu No Taizai oleh Doni");
        user1.AddVideo(video6);
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Spider-Man oleh Doni");
        user1.AddVideo(video7);
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Spider-Man oleh Doni");
        user1.AddVideo(video8);
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Spider-Man oleh Doni");
        user1.AddVideo(video9);
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Spider-Man oleh Doni");
        user1.AddVideo(video10);

        video1.IncreasePlayCount(100);

        user1.PrintAllVideoPlaycount();
        Console.WriteLine(user1.GetTotalVideoPlayCount());
        //user1.GetTotalVideoPlayCount();
    }
}