using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    class Affiliate
    {
        /// <summary>
        /// Affiliate country.
        /// </summary>
        public string Country { get; set; }
        
        /// <summary>
        /// Affiliate city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Affiliate phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Affiliate street adress.
        /// </summary>
        public string StreetAdress { get; set; }

        /// <summary>
        /// Affiliate e-mail.
        /// </summary>
        public string Email { get; set; }
    }
}
