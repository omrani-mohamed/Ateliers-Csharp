﻿using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane : IService<Plane>
    {
        IList<Passenger> GetPassengers(Plane plane);
        IList<Flight> GetFlights(int n);
        bool AvailablePlane(int n, Flight flight);
        public void DeleteOldPlanes();
    }
}
