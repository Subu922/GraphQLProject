using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class ReservationInputType:InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<StringGraphType>("phoneNumber");
            Field<IntGraphType>("partySize");
            Field<StringGraphType>("specialRequest");
            Field<DateGraphType>("reservationDate");
        }
    }
}
