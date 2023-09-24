﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQLProject.Mutation
{
    public class RootMutation:ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation").Resolve(context => new { });
            Field<CategoryMutation>("categoryMutation").Resolve(context => new { });
            Field<ReservationMutation>("reservationMutation").Resolve(context => new { });
        }
    }
}