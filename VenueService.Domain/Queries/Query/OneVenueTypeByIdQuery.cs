using VenueService.Data.Models;

namespace VenueService.Domain.Queries.Query
{
    public class OneVenueTypeByIdQuery : IQuery<VenueType>
    {
        public int Id { get; set; }

        public OneVenueTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
