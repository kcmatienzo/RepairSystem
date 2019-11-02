using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairSystem.Models
{
    public static class Repository
    {
        // private to protect the data
        private static List<CarRegistration> registration = new List<CarRegistration>();

        public static IEnumerable<CarRegistration> Registrations
        {
            // it will return list of car registered
            get
            {
                return registration;
            }
        }

        public static void AddRegistration(CarRegistration carRegistration)
        {
            registration.Add(carRegistration);
        }
    }
}
