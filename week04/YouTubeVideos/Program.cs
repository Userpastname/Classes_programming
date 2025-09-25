using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("dinosaurs", "the_dinoguy", 120);
        video1.AddComment(new Comment("theDinoguyCritic", "this video is stupid, velocioraptors clearly wore polos and fedoras"));
        video1.AddComment(new Comment("theDinoguyFan", "Classic vid from dinoguy"));
        video1.AddComment(new Comment("theRealDinoGuy", "STOP STEALING MY CONTENT"));

        video1.getVideo();
        video1.GetComments();
        Console.WriteLine("");

        Video video2 = new Video("music theory in 30 seconds", "that_music_theorist", 30);
        video2.AddComment(new Comment("thatMusicTheoristFan", "Classic vid from That_Music_Theorist!"));
        video2.AddComment(new Comment("theRealMusicTheorist", "You made the video wrong brother"));
        video2.AddComment(new Comment("MusicHater41", "You nerdy musician I hate you"));

        video2.getVideo();
        video2.GetComments();
        Console.WriteLine();

        Video video3 = new Video("biggest gaming event!", "Gamer1", 300);
        video3.AddComment(new Comment("gamer1Hater", "this video is too long!"));
        video3.AddComment(new Comment("gamer1Lover", "this video is perfectly lengthed"));
        video3.AddComment(new Comment("realGamer1", "you stupid reposter"));

        video3.getVideo();
        video3.GetComments();
    }
}