using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Form.Models;

namespace Form.Data
{
    public class FormContext : DbContext
    {
        public FormContext (DbContextOptions<FormContext> options)
            : base(options)
        {
        }

        public DbSet<Form.Models.Issue>? Issue { get; set; }
    }
}
