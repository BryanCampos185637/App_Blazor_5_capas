using BussinesLogic.Interfaces;
using MediatR;
using Models;
using DataAccessLogic.Lecturas;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLogic.Transactions;

namespace BussinesLogic.Servicios
{
    public class StudentBL : IStudentBL
    {
        private readonly IMediator mediator;
        public StudentBL(IMediator imediador)
        {
            mediator = imediador;
        }

        public async Task<string> Guardar(GuardarEstudiante.Ejecuta student)
        {
            return await mediator.Send(student);
        }

        public async Task<List<Student>> Listar()
        {
            return await mediator.Send(new ListarEstudiantes.Ejecuta());
        }

        public async Task<GuardarEstudiante.Ejecuta> ObtenerPorId(int id)
        {
            return await mediator.Send(new ObtenerEstudiantePorId.Ejecuta { id = id });
        }
    }
}
