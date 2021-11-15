using System;
namespace API.Models
{
    public class Adress
    {
        #region Propriètés
        /// <summary>
        /// Un Numéro de rue pour chaque adress
        /// </summary>

        public string StreetNb { get; set; }

        /// <summary>
        /// Un Nom de rue pour chaque adress
        /// </summary>

        public string StreetName { get; set; }

        /// <summary>
        /// Un Nom de ville pour chaque adress
        /// </summary>

        public string CityName { get; set; }

        /// <summary>
        /// Un Code Postal pour chaque adress
        /// </summary>

        public string CP { get; set; }

        #endregion

        #region constructor

        public Adress(string streetNb, string streetName, string cityName, string cp)
        {
            StreetNb = streetNb;
            StreetName = streetName;
            CityName = cityName;
            CP = cp;
        }

        #endregion


    }
}
