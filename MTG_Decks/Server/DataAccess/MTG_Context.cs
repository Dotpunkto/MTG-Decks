using Microsoft.EntityFrameworkCore;
using MTG_Decks.Entities;

namespace MTG_Decks.Server.DataAccess
{
	public class MTG_Context : DbContext
    {
        public MTG_Context() { }

        public DbSet<User> User { get; set; }
        public DbSet<CardDto> Card { get; set; }
    }
}
