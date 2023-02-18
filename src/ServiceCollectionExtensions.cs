namespace Matr.EFCore;

public static ServiceCollectionExtensions
{
    public static IServiceCollection AddContext<TContext>(this IServiceCollection services)
    {
        return services;
    } 
}