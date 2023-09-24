using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.PartySize);
            Field(m => m.PhoneNumber);
            Field(m => m.ReservationDate);
            Field(m => m.SpecialRequest);
            Field(m => m.CustomerName);
            Field(m => m.Email);
        }
    }
}
