using PostCommentRazerPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            PostCommentClient client = new PostCommentClient();
            Post post = new Post();
            // Use the 'client' variable to call operations on the service.
            client.AddPost(post);
            // Always close the client.
            client.Close();
        }
    }
}
