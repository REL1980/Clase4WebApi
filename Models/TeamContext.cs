// Ésta clase es la que hace el trabajo de "MAPEAR"
// Clase Manejador de todos los demás modelos como la class Team 
// Va a configurar que éstas clases van a estar en la base de datos
// Por detras va a crear el script que va a crear la tabla detras y crea
//las columnas y crea los id y hace todo lo que tiene que hacer 
using Clase3Mvc.Models;
using Microsoft.EntityFrameworkCore;

public class TeamContext : DbContext
{
    public TeamContext(DbContextOptions<TeamContext> options) : base(options)
    {
                
    }
    public DbSet<Team> Teams { get; set; }
}