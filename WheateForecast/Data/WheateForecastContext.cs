using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WheateForecast.Models;

namespace WheateForecast.Data
{
    public class WheateForecastContext : DbContext
    {
        public WheateForecastContext (DbContextOptions<WheateForecastContext> options)
            : base(options)
        {
        }

        public DbSet<WheateForecast.Models.AlmoxarifatoModel> AlmoxarifatoModel { get; set; } = default!;

        public DbSet<WheateForecast.Models.CadastroFuncionarioModel> CadastroFuncionarioModel { get; set; }
    }
}
