namespace ClasesTestUnitarios
{
    public class Prueba
    {
        private int numero;
        private string cadena;

        public int Numero { get { return this.numero; } set { this.numero = value; } }
        
        public string Cadena { get { return this.cadena; } set { this.ValidarCadena(value); } }

        public int AumentarNumero(int valor)
        {
            this.numero += valor;

            return this.numero;
        }

        public void ValidarCadena(string cadena)
        {
            if(cadena == "" || cadena.Length <= 3)
            {
                throw new CadenaException("La cadena es muy corta para asignar");
            }

            this.cadena = cadena;
        }

        public static bool operator ==(Prueba p, string cadena)
        {
            if(p.cadena == cadena)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Prueba p, string cadena)
        {
            return !(p == cadena);
        }
    }
}