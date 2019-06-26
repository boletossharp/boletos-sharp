namespace BoletosSharp
{
    public class Cedente
    {
        public Cedente(string convenio)
        {
            Convenio = convenio ?? throw new System.ArgumentNullException(nameof(convenio));
        }
        public string Convenio { get; }
    }
}
