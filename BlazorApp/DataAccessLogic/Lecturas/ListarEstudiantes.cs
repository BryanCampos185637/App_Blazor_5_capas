using MediatR;
using Microsoft.EntityFrameworkCore;
using Models;
using PersistenceData;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLogic.Lecturas
{
    public class ListarEstudiantes
    {
        public class Ejecuta : IRequest<List<Student>> { }
        public class Manejador : IRequestHandler<Ejecuta, List<Student>>
        {
            private readonly AppDbContext db;
            public Manejador(AppDbContext context)
            {
                db = context;
            }
            public async Task<List<Student>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    return await db.Students.ToListAsync();
                }
                catch (Exception)
                {
                    return null;

                }
            }
        }
    }
}
