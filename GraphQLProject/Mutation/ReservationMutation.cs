using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationRepository reservationRepository)
        {
            Field<CategoryType>("CreateReservation").Arguments(new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" })).Resolve(context =>
            {
                return reservationRepository.AddReservation(context.GetArgument<Reservation>("reservation"));
            });
        }
    }
}
