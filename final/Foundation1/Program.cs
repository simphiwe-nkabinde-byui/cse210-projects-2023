using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Videos");
        string[] comments = System.IO.File.ReadAllLines("comments.txt");
        string[] names = System.IO.File.ReadAllLines("names.txt");
        string[] videoTitles = System.IO.File.ReadAllLines("videoTitles.txt");

        List<Video> videos = new List<Video>();

        Random random = new Random();
        int randomIndex = 0;
        for (int i = 0; i < 4; i++)
        {
            List<Comment> videoComments = new List<Comment>();
            for (int j = 0; j < 4; j++)
            {
                randomIndex = random.Next(0, 14);
                Comment newComment = new Comment(names[randomIndex], comments[randomIndex]);
                videoComments.Add(newComment);
            }
            randomIndex = random.Next(0, 14);
            string title = videoTitles[randomIndex];
            string author = names[randomIndex];
            int length = random.Next(0, 1000);

            Video video = new Video(title, author, length, videoComments);
            videos.Add(video);
        }

        // display data
        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.DisplayInfo();
            int commentCount = video.GetNumberOfComments();
            Console.WriteLine($"{commentCount} comments:");
            video.DisplayComments();
        }
    }
}