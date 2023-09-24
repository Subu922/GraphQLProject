using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLProject.Mutation;
using GraphQLProject.Query;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLProject.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
