using Application;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
            var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            services.AddApplication();

            var serviceProvider = services.BuildServiceProvider();
            var mediator = serviceProvider.GetRequiredService<MediatR.IMediator>();

            var pingQuery = new Application.UseCases.PingPong.PingQuery();
            var result = mediator.Send(pingQuery).Result;

            Console.WriteLine(result.Message);  
    }
}