// Criando uma TV e associando-a a um controle remoto básico

using Design.Patterns.Bridge.GOOD;

IDevice tv = new Tv();
RemoteControl basicRemoteForTv = new BasicRemote(tv);

Console.WriteLine("Using Basic Remote with TV:");
basicRemoteForTv.Power();       // Liga a TV
basicRemoteForTv.SetChannel(10); // Altera o canal da TV para 10

Console.WriteLine();

// Criando um rádio e associando-o a um controle remoto avançado
IDevice radio = new Radio();
RemoteControl advancedRemoteForRadio = new AdvancedRemote(radio);

Console.WriteLine("Using Advanced Remote with Radio:");
advancedRemoteForRadio.Power();        // Liga o rádio
advancedRemoteForRadio.SetChannel(99); // Define a frequência do rádio para 99 MHz