using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLogic.Transactions;

namespace BussinesLogic.Interfaces
{
    public interface IStudentBL
    {
        Task<List<Student>> Listar();
        Task <GuardarEstudiante.Ejecuta> ObtenerPorId(int id);
        Task<string> Guardar(GuardarEstudiante.Ejecuta student);
    }
}
