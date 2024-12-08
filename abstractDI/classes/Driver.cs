//Esta clase implementa la inyección de dependencias en el constructor.
public class Driver
{
    private readonly Vehicle _vehicle;

    public Driver(Vehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public void Operate()
    {
        _vehicle.Drive();
    }
}
