using System;
using Grpc.Net.ClientFactory;
using Microsoft.Extensions.DependencyInjection;

namespace Devlooped.Grok;

public static class GrokServiceCollectionExtensions
{
    public static IServiceCollection AddGrokClient(this IServiceCollection services, Action<GrpcClientFactoryOptions>? configure = null)
    {
        var address = new Uri("https://api.x.ai:443");
        
        services.AddGrpcClient<Auth.AuthClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        services.AddGrpcClient<Chat.ChatClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        services.AddGrpcClient<Embedder.EmbedderClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        services.AddGrpcClient<Image.ImageClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        services.AddGrpcClient<Models.ModelsClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        services.AddGrpcClient<Sample.SampleClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        services.AddGrpcClient<Tokenize.TokenizeClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        services.AddGrpcClient<Documents.DocumentsClient>(options =>
        {
            options.Address = address;
            configure?.Invoke(options);
        });

        return services;
    }
}
