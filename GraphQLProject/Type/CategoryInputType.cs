using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("imageurl");
            Field<StringGraphType>("name");
        }
    }
}
