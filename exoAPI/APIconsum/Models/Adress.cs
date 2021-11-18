namespace APIconsum.Models
{
    public class Adress
    {
        #region Propriètés
        /// <summary>
        /// Un id pour chaque adress
        /// </summary>

        public int Id { get; set; }

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
    }
}