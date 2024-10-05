using Bank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        private int _Edad;
        public string Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string  Telefono { get; set; }
        public string Email { get; set; }
        public string? Direccion { get; set; }

        public int Edad
        {
            get
            {
                if(this._Edad  <= 0)
                {
                    this._Edad = new DateTime(DateTime.Now.Subtract(this.FechaNacimiento).Ticks).Year - 1;
                }
                return this._Edad;
            }

        }
    }
}
