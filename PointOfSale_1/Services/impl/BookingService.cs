using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using PointOfSale_1.Context;
using PointOfSale_1.Models;
using System.Data.Entity.Core.Objects;
using Microsoft.EntityFrameworkCore;

namespace PointOfSale_1.Services.impl
{
    internal class BookingService : IBookingService
    {
        private readonly DbPosContext _dbContext;

        public BookingService(DbPosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Booking AddBooking(Booking booking)
        {
            try
            {
                if (booking == null)
                    throw new ArgumentNullException(nameof(booking));

                var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(booking);
                var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                if (!Validator.TryValidateObject(booking, validationContext, validationResults, true))
                {
                    string errorMessage = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                _dbContext.Bookings.Add(booking);
                SaveChanges();

                MessageBox.Show("Booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return booking;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error booking: {ex.Message}");
                MessageBox.Show("An error occurred while booking. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();

        }
        
        public List<Booking> GetAllBookingsForCustomer(int customerId)
        {
            return _dbContext.Bookings.Where(p => p.CustomerId == customerId).ToList();
        }

        public Booking GetBookingById(int id)
        {
            return _dbContext.Bookings.Find(id);
        }

        public int FindRemainingQuantityByProduct(Product product)
        {
            int totalBookedQuantity = _dbContext.Bookings
                           .Where(b => b.ProductId == product.Id)
                           .Sum(b => b.Quantity);

            int remainingQuantity = product.Quantity - totalBookedQuantity;

            return remainingQuantity;
        }
    }
}
