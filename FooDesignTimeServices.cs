using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.EntityFrameworkCore.Scaffolding.Internal
{
    public class FooDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IModelCodeGenerator, FooCSharpModelGenerator>();
            serviceCollection.AddSingleton<ICSharpEntityTypeGenerator, FooCSharpEntityTypeGenerator>();
            serviceCollection.AddSingleton<ICSharpDbContextGenerator, FooCSharpDbContextGenerator>();
        }
    }
}
