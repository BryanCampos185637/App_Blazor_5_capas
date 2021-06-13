using MediatR;
using Microsoft.EntityFrameworkCore;
using PersistenceData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLogic.Transactions
{
    public class GuardarEstudiante
    {
        public class Ejecuta : IRequest<string>
        {
            public int StudentId { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            public int Age { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, string>
        {
            private readonly AppDbContext db;
            public Manejador(AppDbContext context)
            {
                db = context;
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    if (request.StudentId > 0)
                    {
                        var obj = await db.Students.Where(p => p.StudentId.Equals(request.StudentId)).FirstOrDefaultAsync();
                        obj.Name = request.Name;
                        obj.LastName = request.LastName;
                        obj.Age = request.Age;
                        var rpt = await db.SaveChangesAsync();
                        if (rpt > 0)
                            return "Exito";
                        else
                            return "Ocurrio un error al modificar";
                    }
                    else
                    {
                        db.Students.Add(new Models.Student
                        {
                            Name = request.Name,
                            LastName = request.LastName,
                            Age = request.Age
                        });
                        var rpt = await db.SaveChangesAsync();
                        if (rpt > 0)
                            return "Exito";
                        else
                            return "Ocurrio un error al guardar";
                    }
                }
                catch (Exception e)
                {
                    return "Error " + e.Message;
                }
            }
        }
    }
}
