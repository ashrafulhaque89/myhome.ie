using API.Contracts;
using Application.Homes;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_tests
{
    public class APITestServiceFake : IHomeService
    {
        private readonly SearchResult _searchResult;
        private readonly List<Home> _home;

        public APITestServiceFake()
        {
            List<HomeDTO> PropertyList = new List<HomeDTO>();
            SearchResult searchResult = new SearchResult();
            List<Home> homes = new List<Home>();
            var home1 = new HomeDTO
            {
                PropertyId = 4292232,
                GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                BedsString = "2 beds",
                Price = "395000",
                SizeStringMeters = 52.95,
                DisplayAddress = "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2",
                PropertyType = "Apartment",
                BerRating = "D2",
                MainPhoto = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                Photo = new string[]
                {
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg",
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
                }
            };

            var home2 = new HomeDTO
            {
                PropertyId = 4292232,
                GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                BedsString = "2 beds",
                Price = "395000",
                SizeStringMeters = 52.95,
                DisplayAddress = "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2",
                PropertyType = "Apartment",
                BerRating = "D2",
                MainPhoto = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                Photo = new string[]
                {
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg",
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
                }
            };

            var home3 = new HomeDTO
            {
                PropertyId = 4292232,
                GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                BedsString = "2 beds",
                Price = "395000",
                SizeStringMeters = 52.95,
                DisplayAddress = "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2",
                PropertyType = "Apartment",
                BerRating = "D2",
                MainPhoto = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                Photo = new string[]
                {
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg",
                    "https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
                }
            };

            var home = new Home
            {
                PropertyId = 4292232,
                GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                BedsString = "2 beds",
                Price = "395000",
                SizeStringMeters = 52.95,
                DisplayAddress = "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2",
                PropertyType = "Apartment",
                BerRating = "D2",
                MainPhoto = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                Photos = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg, https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
            };

            PropertyList.Add(home1);
            PropertyList.Add(home2);
            PropertyList.Add(home3);
            homes.Add(home);
            searchResult.SearchResults = PropertyList;
            _searchResult = searchResult;
            _home = homes;
        }
        public async Task<SearchResult> ListAsync()
        {
            return _searchResult;
        }

        public async Task<HomeDTO> DetailsAsync(int id)
        {
            return _searchResult.SearchResults.SingleOrDefault(x => x.PropertyId == id);
        }

        public async Task<Home> CreateAsync(Home request)
        {
            request.PropertyId = Int32.MaxValue;
            _home.Add(request);
            return request;
        }

        public async Task<dynamic> DeleteAsync(int id)
        {
            var existing = _searchResult.SearchResults.SingleOrDefault(x => x.PropertyId == id);
            _searchResult.SearchResults.Remove(existing);
            return new { message = "Propery has been deleted!"};
        }

        public async Task<Home> EditAsync(int id, Home request)
        {
            var home = _home.SingleOrDefault(x => x.PropertyId == id);
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

            return request;
        }
    }
}
