using Information.System.Data;
using Infotmation.System.Models;
using System;

namespace System.Interact.Data
{
    public class Program
    {
        public static void Main()
        {
            var DBcontext = new InformationSystemDbContext();
            var Post = new Post
            {
                Answer = "Hello word in my firrst post",
                Id = 12,
            };
            var SubTopic = new SubTopic
            {
                Id = 123,
                SubTopicName = "Others"
            };
            DBcontext.Posts.Add(Post);
        }
    }
}
