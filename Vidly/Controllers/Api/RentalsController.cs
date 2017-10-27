using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {

            /*var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            if (customerInDb == null)
                return NotFound();*/

            foreach (var movieId in newRental.MovieIds)
            {
                Rental rental = new Rental();
                rental.CustomerId = newRental.CustomerId;
                rental.MovieId = movieId;
                _context.Rentals.Add(rental);
            }

            return Ok();
        }
    }
}
