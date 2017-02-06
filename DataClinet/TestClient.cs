using Information.System.Data;
using InfotmationSystem.Data.Models;
using System;
using System.Linq;

namespace DataClinet
{
    public class TestClient
    {
        static InformationSystemDbContext Data = new InformationSystemDbContext();

        public static void Main()
        {


            Topic topic = new Topic()
            {
                TopicName = "My first sex",
                View = 12,
                Id = 123,
                Reating = 12,
                SubTopicId = 123,
            };
            //Data.Topics.Add(topic);
            //Data.SaveChanges();

            SubTopic subtopic = new SubTopic();

            subtopic.Topics = new Topic()
            { SubTopicId= 1 };
            subtopic.View = 23;
            subtopic.SubTopicName = "anal";
            subtopic.Reating = 12;
            //Data.SubTopics.Add(subtopic);
            //Data.SaveChanges();


            Vote vote = new Vote();
            vote.PostId = 1;

            Post post = new Post();
            post.Answer = "that topic is so facking cool";
            post.ParentPost = 1;
            post.VoteId = 1;



            //Data.Posts.Add(post);
            //Data.SaveChanges();

            var posts = Data.Posts.Where(pt => pt.Id == 1);

            foreach (var item in posts)
            {
                Console.WriteLine(item.Answer);
                if(item.Answer.Any())
                {
                    var date  = item.ModifiedOn.ToString();
                    string adad = date.Substring(0,10);
                    Console.WriteLine(adad);
                    Console.ReadKey(true);
                }
            }
            Console.WriteLine("finished");
        }
    }
}
