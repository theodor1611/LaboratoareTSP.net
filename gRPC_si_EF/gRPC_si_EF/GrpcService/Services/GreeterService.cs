using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using gRPC_si_EF;
using Microsoft.Extensions.Logging;
using Google.Protobuf.WellKnownTypes;

namespace GrpcService
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        public override Task<AddPostReply> AddPost(AddPostRequest request, ServerCallContext context)
        {
            Post post = new Post();

            return Task.FromResult(new AddPostReply
            {
                B = post.AddPost()
            });
        }

        public override Task<PostModel> UpdatePost(PostModel request, ServerCallContext context)
        {
            Post post = new Post();
            Post newPost = new Post(request.PostId, request.Description, request.Domain, request.Date.ToDateTime());
            Post oldPost = new Post();
            oldPost=post.UpdatePost(newPost);
            PostModel p = new PostModel();
            p.PostId = oldPost.PostId;
            p.Description = oldPost.Description;
            p.Domain = oldPost.Domain;
            p.Date = Timestamp.FromDateTime(oldPost.Date ?? DateTime.Now);
            return Task.FromResult(p);
        }

        public override Task<DeletePostReply> DeletePost(DeletePostRequest request, ServerCallContext context)
        {
            Post post = new Post();
            
            return Task.FromResult(new DeletePostReply
            {
                PostId = post.DeletePost(request.PostId)
            });
        }

        public override Task<PostModel> GetPostById(GetPostByIdRequest request, ServerCallContext context)
        {
            Post post = new Post();
            Post rPost = new Post();
            PostModel p = new PostModel();
            rPost = post.GetPostById(request.PostId);
            p.PostId = rPost.PostId;
            p.Description = rPost.Description;
            p.Domain = rPost.Domain;
            p.Date = Timestamp.FromDateTime(rPost.Date ?? DateTime.Now);
            return Task.FromResult(p);
        }
    }
}
