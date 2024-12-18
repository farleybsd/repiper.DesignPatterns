namespace Design.Patterns.Bridge.BAD;

/*
 * Ploriferacao de classes
 * Forte Acoplamento
 * Baixa Flexibilidade
 */

// Classe para um Dispositivo Especifico (TV)
public class Tv
{
    public void TurnOn()
    {
        Console.WriteLine("Turning on the tv");
    }
    
    public void TurnOff()
    {
        Console.WriteLine("Turning of the tv");
    }
    
    public void SetChanel(int channel)
    {
        Console.WriteLine($"Setting Tv channel {channel}");
    }
}

// Classe para Controle Remoto Basico que funciona apenas com a TV
public class BasicRemoteForTv
{
    private readonly Tv _tv;

    public BasicRemoteForTv(Tv tv)
    {
        _tv = tv;
    }

    public void Power()
    {
        Console.WriteLine("Powe button pressed on the basic remote.");
        _tv.TurnOn();
    }

    public void SetChanel(int channel)
    {
        _tv.SetChanel(channel);
    }
}

// Classe para um dispositivo especifico (Radio)
public class Radio
{
    public void TurnOn()
    {
        Console.WriteLine("Turning on the Radio");
    }
    
    public void TurnOff()
    {
        Console.WriteLine("Turning of the Radio");
    }
    
    public void SetFrequency(double frequency)
    {
        Console.WriteLine($"Setting Radio frequency to {frequency} MHz");
    }
}

// Classe para controle remoto basico que funciona apenas com o radio
public class BasicRemoteForRadio
{
    private readonly Radio _radio;

    public BasicRemoteForRadio(Radio radio)
    {
        _radio = radio;
    }
    
    public void Power()
    {
        Console.WriteLine("Powe button pressed on the basic Radio.");
        _radio.TurnOn();
    }

    public void SetChanel(double frequency)
    {
        _radio.SetFrequency(frequency);
    }
}