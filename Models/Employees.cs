using Newtonsoft.Json;
using System.IO;

namespace FlexiTools.Model
{
    public class Employees
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Departamento { get; set; }
        public string? Hash { get; set; }
        public string? Gerente { get; set; }
        public string? Email { get; set; }
    }
}
