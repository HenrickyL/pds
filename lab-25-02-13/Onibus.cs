public class Onibus : ASubject{
    public OnibusEstados Estado { get; private set; }
    public void MudaEstado(OnibusEstados estado) {
        this.Estado = estado;
        Console.WriteLine("--------"); 
        this.Notify();
    }
}