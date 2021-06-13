using DataAccessLogic.Transactions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PersistenceData;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLogic.Lecturas
{
    public class ObtenerEstudiantePorId
    {
        public class Ejecuta : IRequest<GuardarEstudiante.Ejecuta>
        {
            [Required]
            public int id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, GuardarEstudiante.Ejecuta>
        {
            private readonly AppDbContext db;
            public Manejador(AppDbContext context)
            {
                db = context;
            }
            public async Task<GuardarEstudiante.Ejecuta> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var obj= await db.Students.Where(p => p.StudentId.Equals(request.id)).FirstOrDefaultAsync();
                return new GuardarEstudiante.Ejecuta
                {
                    StudentId = obj.StudentId,
                    Name = obj.Name,
                    LastName = obj.LastName,
                    Age = obj.Age
                };
            }
        }
    }
}
