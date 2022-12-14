using System;
using System.ComponentModel.DataAnnotations;

namespace YouInvestMe.Models
{
    public class Idea
    {
        public int IdeaId { get; set; }

        public string Title { get; set; }

        public string Abstract { get; set; }

        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime PublishedDate { get; set; }

        [Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime ExpiriesDate { get; set; }

        [Display(Name = "Product Type")]
        public string ProductType { get; set; }

        public string Instruments { get; set; }

        public string Currency { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        [Display(Name = "Created by")]
        public string UserID { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<ClientIdea> ClientIdeas { get; set; }
    }

}