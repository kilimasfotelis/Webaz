using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webaz.Models
{
    public class PlayerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}