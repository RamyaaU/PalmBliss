using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBliss.Infrastructure.Data
{
    public class PalmBlissDBContext : DbContext
    {
        public PalmBlissDBContext(DbContextOptions<PalmBlissDBContext> options) : base(options)
        {
                
        }
    }
}
