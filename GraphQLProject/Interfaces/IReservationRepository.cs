using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
