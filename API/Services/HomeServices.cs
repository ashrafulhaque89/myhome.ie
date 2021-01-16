using System;
using System.Linq;
using System.Threading.Tasks;
using API.Contracts;
using Application.Homes;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Services
{
    public class HomeServices : IHomeService
    {
        private readonly DataContext _context;

        public HomeServices(DataContext context)
        {
            _context = context;
        }

        // Method to determine whether the Price is Decimal Value or a string (i.e POA)
        public static dynamic ConvertPrice(string price)
        {
            bool IsNumereic(string price)
            {
                decimal test;
                return decimal.TryParse(price, out test);
            }

            if(IsNumereic(price) == true)
            {
                return Convert.ToDecimal(price);
            }
            return price;
        }

        // Service to Add new Property
        public async Task<Home> CreateAsync(Home request)
        {
            var home = new Home
            {
                PropertyId = request.PropertyId,
                GroupLogoUrl = request.GroupLogoUrl,
                BedsString = request.BedsString,
                Price = request.Price,
                SizeStringMeters = request.SizeStringMeters,
                DisplayAddress = request.DisplayAddress,
                PropertyType = request.PropertyType,
                BathString = request.BathString,
                BerRating = request.BerRating,
                MainPhoto = request.MainPhoto,
                Photos = request.Photos   
            };
            _context.Home.Add(home);
            var success = await _context.SaveChangesAsync() > 0;
            if(success) return home;
            throw new Exception("Problem saving changes");
        }

        // Service to Delete A Property
        public async Task<dynamic> DeleteAsync(int id)
        {
            var home = await _context.Home.FindAsync(id);

            if(home == null)
            {
                throw new Exception("Could not find the Property!");
            }
            else
            {
                _context.Remove(home);
            }
            var success = await _context.SaveChangesAsync() > 0;

            if(success) return new {message = "Property has been deleted!"};

            throw new Exception("Problem saving changes");
        }

        // Service to View A property By property Id
        public async Task<HomeDTO> DetailsAsync(int id)
        {
            var home = await _context.Home.FindAsync(id);

            if (home == null)
                throw new Exception ("Property Not found!");

            var property_by_id = new HomeDTO
            {
                PropertyId = home.PropertyId,
                GroupLogoUrl = home.GroupLogoUrl,
                BedsString = home.BedsString,
                Price = ConvertPrice(home.Price),
                SizeStringMeters = home.SizeStringMeters,
                DisplayAddress = home.DisplayAddress,
                PropertyType = home.PropertyType,
                BathString = home.BathString,
                BerRating = home.BerRating,
                MainPhoto = home.MainPhoto,
                Photo = home.Photos.Split(',',StringSplitOptions.None)
            };
        
            return property_by_id;
        }

        // Modify A property 
        public async Task<Home> EditAsync(int id, Home request)
        {
            var home = await _context.Home.FindAsync(id);

            if(home == null)
            {
                throw new Exception("Could not find the Property!");
            }
            
            home.GroupLogoUrl = request.GroupLogoUrl ?? request.GroupLogoUrl;
            home.BedsString = request.BedsString ?? request.BedsString;
            home.Price = request.Price ?? request.Price;
            home.SizeStringMeters = Double.Parse(request.SizeStringMeters.ToString() ?? request.SizeStringMeters.ToString());
            home.DisplayAddress = request.DisplayAddress ?? request.DisplayAddress;
            home.PropertyType = request.PropertyType ?? request.PropertyType;
            home.BathString = request.BathString ?? request.BathString;
            home.BerRating = request.BerRating ?? request.BerRating;
            home.MainPhoto = request.MainPhoto ?? request.MainPhoto;
            home.Photos = request.Photos ?? request.Photos;  

            var success = await _context.SaveChangesAsync() > 0;

            if(success) return home;

            throw new Exception("Problem updating changes");
        }

        // List All properties
        public async Task<SearchResult> ListAsync()
        {
            var homes = await _context.Home.Select(home => new HomeDTO
            {
                PropertyId = home.PropertyId,
                GroupLogoUrl = home.GroupLogoUrl,
                BedsString = home.BedsString,
                Price = ConvertPrice(home.Price),
                SizeStringMeters = home.SizeStringMeters,
                DisplayAddress = home.DisplayAddress,
                PropertyType = home.PropertyType,
                BathString = home.BathString,
                BerRating = home.BerRating,
                MainPhoto = home.MainPhoto,
                Photo = home.Photos.Split(',',StringSplitOptions.None)
            }).ToListAsync();

            var result = new SearchResult()
            {
                SearchResults = homes
            };
            return result;
        }
    }
}