using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationRepository reservationRepository)
        {
            Field<ListGraphType<ReservationType>>("Reservations").Resolve(context =>
            {
                return reservationRepository.GetReservations();
            });
        }
    }
}
