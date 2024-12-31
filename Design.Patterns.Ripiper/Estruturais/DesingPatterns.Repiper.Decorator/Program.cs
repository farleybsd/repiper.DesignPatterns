/* Padrao Decorator
* Adiciona Funcionalidades de forma dinamica
* Estende funcionalidades em tempo de execulcao
* Encapsula novos comportamentos  
*/

// Uso Decorator

using DesingPatterns.Repiper.Decorator.GOOD;

var basicNotification = new BasicNotification();
var encryptedNotification = new EncryptedNotifcationDecorator(basicNotification);
var signedAndEncryptedNotification = new SignedSmSNotificationDecorator(encryptedNotification);

signedAndEncryptedNotification.Send("Hello World");