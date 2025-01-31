using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video("The morning breaks", "Parley P. Pratt", 231);
        Video video2 = new Video("The Spirit of God", "William W. Phelps", 354);
        Video video3 = new Video("Now Let Us Rejoice", "William W. Phelps", 207);

        video1.AddComment(new Comment("Juan", "This hymn is beautiful!"));
        video1.AddComment(new Comment("Jaime", "Amazing song, very inspiring."));
        video1.AddComment(new Comment("Lady", "This brings me peace."));

        video2.AddComment(new Comment("David", "One of my favorites!"));
        video2.AddComment(new Comment("Adriana", "So powerful and uplifting."));
        video2.AddComment(new Comment("Felipe", "A true masterpiece."));

        video3.AddComment(new Comment("Michelle", "This fills my soul with joy."));
        video3.AddComment(new Comment("Yurani", "Absolutely wonderful."));
        video3.AddComment(new Comment("Kaori", "Such a great message!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds.");
            Console.WriteLine($"Total of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()} => '{comment.GetComment()}'");
            }
            Console.WriteLine("   ");

        }
    }
}