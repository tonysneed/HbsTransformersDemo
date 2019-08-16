using EntityFrameworkCore.Scaffolding.Handlebars;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

// dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=NorthwindSlim; Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -o Models -c NorthwindSlimContext -f --context-dir Contexts -t Category -t Product

    namespace HbsTransformersDemo
{
    public class ScaffoldingDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            services.AddHandlebarsScaffolding();
            services.AddHandlebarsTransformers(
                entityNameTransformer: n => "Prefix" + n,
                entityFileNameTransformer: n => "Prefix" + n,
                constructorTransformer: e => new EntityPropertyInfo("Prefix" + e.PropertyType, e.PropertyName),
                navPropertyTransformer: e => new EntityPropertyInfo("Prefix" + e.PropertyType, e.PropertyName));
        }
    }
}
