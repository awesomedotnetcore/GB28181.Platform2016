// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gb28181config.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Manage {
  public static partial class ManageGbService
  {
    static readonly string __ServiceName = "manage.ManageGbService";

    static readonly grpc::Marshaller<global::Manage.QueryGb28181ConfigRequest> __Marshaller_QueryGb28181ConfigRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Manage.QueryGb28181ConfigRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Manage.QueryGb28181ConfigReply> __Marshaller_QueryGb28181ConfigReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Manage.QueryGb28181ConfigReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Manage.QueryGb28181ConfigRequest, global::Manage.QueryGb28181ConfigReply> __Method_GetGb28181ServiceConfig = new grpc::Method<global::Manage.QueryGb28181ConfigRequest, global::Manage.QueryGb28181ConfigReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGb28181ServiceConfig",
        __Marshaller_QueryGb28181ConfigRequest,
        __Marshaller_QueryGb28181ConfigReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Manage.Gb28181ConfigReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ManageGbService</summary>
    public abstract partial class ManageGbServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Manage.QueryGb28181ConfigReply> GetGb28181ServiceConfig(global::Manage.QueryGb28181ConfigRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ManageGbService</summary>
    public partial class ManageGbServiceClient : grpc::ClientBase<ManageGbServiceClient>
    {
      /// <summary>Creates a new client for ManageGbService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ManageGbServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ManageGbService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ManageGbServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ManageGbServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ManageGbServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Manage.QueryGb28181ConfigReply GetGb28181ServiceConfig(global::Manage.QueryGb28181ConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGb28181ServiceConfig(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Manage.QueryGb28181ConfigReply GetGb28181ServiceConfig(global::Manage.QueryGb28181ConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGb28181ServiceConfig, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Manage.QueryGb28181ConfigReply> GetGb28181ServiceConfigAsync(global::Manage.QueryGb28181ConfigRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGb28181ServiceConfigAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Manage.QueryGb28181ConfigReply> GetGb28181ServiceConfigAsync(global::Manage.QueryGb28181ConfigRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGb28181ServiceConfig, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ManageGbServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ManageGbServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ManageGbServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetGb28181ServiceConfig, serviceImpl.GetGb28181ServiceConfig).Build();
    }

  }
}
#endregion
