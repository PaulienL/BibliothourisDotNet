using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris.Model.Repositories
{
    class RentalRepository
    {
        private List<Rental> rentals;

        public RentalRepository(List<Rental> rentals)
        {
            this.rentals = rentals;
        }

        public List<Rental> GetAllRentals()
        {
            return rentals;
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public void RemoveRental(Rental rental)
        {
            rentals.Remove(rental); 
        }
    }
}
