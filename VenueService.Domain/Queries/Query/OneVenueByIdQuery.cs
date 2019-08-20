using VenueService.Data.Models;

namespace VenueService.Domain.Queries.Query
{
    public class OneVenueByIdQuery : IQuery<Venue>
    {
        public int Id { get; set; }

        public OneVenueByIdQuery(int id)
        {
            Id = id;
        }
    }
}
