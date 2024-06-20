namespace IntroduccionCsharp.Ejemplos.Herencia
{
    internal class EmpleadoPorHora : Empleado
    {
        public EmpleadoPorHora(
            string nombre, int id, decimal salarioBase, int horasTrabajadas, decimal tarfaPorHora): base(nombre, id, salarioBase) 
        {
            this.HorasTrabajadas = horasTrabajadas;
            this.TarifaPorHora = tarfaPorHora;

        }
        public int HorasTrabajadas { get; set; }
        public decimal TarifaPorHora { get; set; }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}
