using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services
{
    public interface IBookingService
    {
        Booking AddBooking(Booking booking);
        int FindRemainingQuantityByProduct(Product product);
        List<Booking> GetAllBookingsForCustomer(int customerId);
        Booking GetBookingById(int id);
        void SaveChanges();
    }
}
