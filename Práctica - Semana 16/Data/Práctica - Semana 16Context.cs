using Microsoft.EntityFrameworkCore;
using Práctica___Semana_16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Práctica___Semana_16.Data
{
    public class Práctica___Semana_16 
    {
        public class Práctica__Semana_16Context : DbContext
        {
            public Práctica___Semana_16Context(DbContextOptions<Práctica___Semana_16Context> options) : base (options)
            {

            }
        }
    }
}
