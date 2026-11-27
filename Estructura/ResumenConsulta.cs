using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MundoAnimal.Models
{
    [EntidadVeterinaria("Resumen de una consulta veterinaria")]
    public record ResumenConsulta(
        int ConsultaId,
        int MascotaId,
        DateTime Fecha,
        string Motivo,
        string Diagnostico
    );
}
