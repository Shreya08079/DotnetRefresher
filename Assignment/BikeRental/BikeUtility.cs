using System.Collections.Generic;

namespace BikeRental
{
    public class BikeUtility
    {
        public SortedDictionary<int, Bike> bikeDetails;


        public BikeUtility(SortedDictionary<int, Bike> bikeDetails)
        {
            this.bikeDetails = bikeDetails;
        }


        public void AddBikeDetails(
            string model,
            string brand,
            int pricePerDay)
        {
            int key = bikeDetails.Count + 1;


            Bike bike = new Bike
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };


            bikeDetails.Add(key, bike);
        }



        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            SortedDictionary<string, List<Bike>> groupedBikes =
                new SortedDictionary<string, List<Bike>>();


            foreach (var item in bikeDetails)
            {
                Bike bike = item.Value;


                if (!groupedBikes.ContainsKey(bike.Brand))
                {
                    groupedBikes[bike.Brand] =
                        new List<Bike>();
                }


                groupedBikes[bike.Brand].Add(bike);
            }


            return groupedBikes;
        }
    }
}