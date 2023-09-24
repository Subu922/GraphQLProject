using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQLProject.Query
{
    public class RootQuery:ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery").Resolve(context=>new { });
            Field<CategoryQuery>("categoryQuery").Resolve(context => new { });
            Field<ReservationQuery>("reservationQuery").Resolve(context => new { });
        }
    }
}
