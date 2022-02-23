using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk3_1.Models;

namespace MegaDesk3_1.Data
{
    public class MegaDesk3_1Context : DbContext
    {
        public MegaDesk3_1Context (DbContextOptions<MegaDesk3_1Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk3_1.Models.DeskQuote> DeskQuote { get; set; }
    }
}
