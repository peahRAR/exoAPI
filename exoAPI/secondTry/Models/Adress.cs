using System;
namespace API.Models
{
    public class Adress
    {
        #region Propriètés
        /// <summary>
        /// Un Numéro de rue pour chaque adress
        /// </summary>

        private string StreetNb { get; set; }

        /// <summary>
        /// Un Nom de rue pour chaque adress
        /// </summary>

        private string StreetName { get; set; }

        /// <summary>
        /// Un Nom de ville pour chaque adress
        /// </summary>

        private string CityName { get; set; }

        /// <summary>
        /// Un Code Postal pour chaque adress
        /// </summary>

        private string CP { get; set; }

        #endregion

        #region constructor

        public Adress(string streetNb, string streetName, string cityName, string cP)
        {
            StreetNb = streetNb;
            StreetName = streetName;
            CityName = cityName;
            CP = cP;
        }

        #endregion


    }
}
