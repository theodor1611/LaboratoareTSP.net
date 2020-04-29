// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "Greet.Greeter";

    static readonly grpc::Marshaller<global::GrpcService.HelloRequest> __Marshaller_Greet_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.HelloReply> __Marshaller_Greet_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.HelloReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.AddPostRequest> __Marshaller_Greet_AddPostRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.AddPostRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.AddPostReply> __Marshaller_Greet_AddPostReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.AddPostReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostModel> __Marshaller_Greet_PostModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.DeletePostRequest> __Marshaller_Greet_DeletePostRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.DeletePostRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.DeletePostReply> __Marshaller_Greet_DeletePostReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.DeletePostReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.GetPostByIdRequest> __Marshaller_Greet_GetPostByIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.GetPostByIdRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.HelloRequest, global::GrpcService.HelloReply> __Method_SayHello = new grpc::Method<global::GrpcService.HelloRequest, global::GrpcService.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_Greet_HelloRequest,
        __Marshaller_Greet_HelloReply);

    static readonly grpc::Method<global::GrpcService.AddPostRequest, global::GrpcService.AddPostReply> __Method_AddPost = new grpc::Method<global::GrpcService.AddPostRequest, global::GrpcService.AddPostReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_Greet_AddPostRequest,
        __Marshaller_Greet_AddPostReply);

    static readonly grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostModel> __Method_UpdatePost = new grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_Greet_PostModel,
        __Marshaller_Greet_PostModel);

    static readonly grpc::Method<global::GrpcService.DeletePostRequest, global::GrpcService.DeletePostReply> __Method_DeletePost = new grpc::Method<global::GrpcService.DeletePostRequest, global::GrpcService.DeletePostReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_Greet_DeletePostRequest,
        __Marshaller_Greet_DeletePostReply);

    static readonly grpc::Method<global::GrpcService.GetPostByIdRequest, global::GrpcService.PostModel> __Method_GetPostById = new grpc::Method<global::GrpcService.GetPostByIdRequest, global::GrpcService.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_Greet_GetPostByIdRequest,
        __Marshaller_Greet_PostModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Greeter</summary>
    public partial class GreeterClient : grpc::ClientBase<GreeterClient>
    {
      /// <summary>Creates a new client for Greeter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreeterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Greeter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreeterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreeterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreeterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcService.HelloReply SayHello(global::GrpcService.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::GrpcService.HelloReply SayHello(global::GrpcService.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcService.HelloReply> SayHelloAsync(global::GrpcService.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::GrpcService.HelloReply> SayHelloAsync(global::GrpcService.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual global::GrpcService.AddPostReply AddPost(global::GrpcService.AddPostRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.AddPostReply AddPost(global::GrpcService.AddPostRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddPost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.AddPostReply> AddPostAsync(global::GrpcService.AddPostRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.AddPostReply> AddPostAsync(global::GrpcService.AddPostRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddPost, null, options, request);
      }
      public virtual global::GrpcService.PostModel UpdatePost(global::GrpcService.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.PostModel UpdatePost(global::GrpcService.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostModel> UpdatePostAsync(global::GrpcService.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostModel> UpdatePostAsync(global::GrpcService.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePost, null, options, request);
      }
      public virtual global::GrpcService.DeletePostReply DeletePost(global::GrpcService.DeletePostRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.DeletePostReply DeletePost(global::GrpcService.DeletePostRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.DeletePostReply> DeletePostAsync(global::GrpcService.DeletePostRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.DeletePostReply> DeletePostAsync(global::GrpcService.DeletePostRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual global::GrpcService.PostModel GetPostById(global::GrpcService.GetPostByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.PostModel GetPostById(global::GrpcService.GetPostByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPostById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostModel> GetPostByIdAsync(global::GrpcService.GetPostByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.PostModel> GetPostByIdAsync(global::GrpcService.GetPostByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPostById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreeterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreeterClient(configuration);
      }
    }

  }
}
#endregion
