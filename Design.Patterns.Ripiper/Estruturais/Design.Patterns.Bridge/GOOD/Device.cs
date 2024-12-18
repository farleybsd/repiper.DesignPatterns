/*
 *  Reducao de Classe
 *  Desacoplamento
 * Alta Flexibiliade
 */

namespace Design.Patterns.Bridge.GOOD;

// Interface Implementor Para Dispositivo
public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
}
// Implementacao Concreta para TV
public class Tv : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Turning on the tv");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning off the tv");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Setting Tv channel {channel}");
    }
}

// Implenetacao conreta para Radio 
public class Radio : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Turning on the Radio");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning of the Radio");
    }

    public void SetChannel(int frequency)
    {
        Console.WriteLine($"Setting Radio frequency to {frequency} MHz");
    }
}
//Abstracao para Controle Remoto
public abstract class RemoteControl
{
    protected IDevice Device;

    public RemoteControl(IDevice device)
    {
        Device = device;
    }

    public abstract void Power();
    public abstract void SetChannel(int channel);
}
// Implementacao Concreta do controle Remoto Basico
public class BasicRemote : RemoteControl
{
    public BasicRemote(IDevice device) : base(device)
    {
    }

    public override void Power()
    {
        Console.WriteLine("Powe button pressed on the basic Radio.");
        Device.TurnOn();
    }

    public override void SetChannel(int channel)
    {
        Device.SetChannel(channel);
    }
}

// Implementacao concreta do controle remoto avancado
public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base(device)
    {
    }

    public override void Power()
    {
        Console.WriteLine("Powe button pressed on the basic Radio.");
        Device.TurnOn();
    }

    public override void SetChannel(int channel)
    {
        Device.SetChannel(channel);
    }
}