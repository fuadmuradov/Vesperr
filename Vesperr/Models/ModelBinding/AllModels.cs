using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models.ModelBinding
{
    public class AllModels
    {
        public Heroheader headers { get; set; }
        public About abouts { get; set; }
        public List<AboutCount> aboutcounts { get; set; }
        public List<ClientSection> clientsections { get; set; }
        public Contact contacts { get; set; }
        public List <Feature> features { get; set; }
        public List<MoreServiceSection> moreservicesections { get; set; }
        public List<Portfolio> portfolios { get; set; }
        public List<Pricing> pricings { get; set; }
        public List<Question> questions { get; set; }
        public List<ServiceSection> servicesections { get; set; }
        public List<Team> teams { get; set; }
        public List<Testimional> testimionals { get; set; }

    }
}
