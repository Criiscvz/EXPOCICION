// Interfaz común para componentes y decoradores
public interface IComponente
{
    void Operacion();
}

// Componente base
public class Componente : IComponente
{
    public void Operacion()
    {
        Console.WriteLine("Operación del componente base");
    }
}

// Decorador base
public abstract class Decorador : IComponente
{
    protected IComponente componente;

    public Decorador(IComponente componente)
    {
        this.componente = componente;
    }

    public virtual void Operacion()
    {
        componente.Operacion();
    }
}

// Decorador con funcionalidad adicional
public class DecoradorA : Decorador
{
    public DecoradorA(IComponente componente) : base(componente)
    {
    }

    public override void Operacion()
    {
        base.Operacion();
        Console.WriteLine("Operación adicional del Decorador A");
    }
}

// Decorador con otra funcionalidad adicional
public class DecoradorB : Decorador
{
    public DecoradorB(IComponente componente) : base(componente)
    {
    }

    public override void Operacion()
    {
        base.Operacion();
        Console.WriteLine("Operación adicional del Decorador B");
    }
}

// Uso del patrón decorador
public class Program
{
    public static void Main(string[] args)
    {
        // Crear un componente base
        IComponente componente = new Componente();

        // Envolver el componente base con decoradores
        componente = new DecoradorA(componente);
        componente = new DecoradorB(componente);

        // Llamar a la operación en el componente decorado
        componente.Operacion();
    }
}
