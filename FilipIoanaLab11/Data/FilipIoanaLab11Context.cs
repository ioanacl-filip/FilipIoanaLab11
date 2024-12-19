using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilipIoanaLab11.Models;

namespace FilipIoanaLab11.Data
{
    public class FilipIoanaLab11Context : DbContext
    {
        public FilipIoanaLab11Context (DbContextOptions<FilipIoanaLab11Context> options)
            : base(options)
        {
        }

        public DbSet<FilipIoanaLab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
