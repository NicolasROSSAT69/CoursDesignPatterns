
using Bridge;

/**
 * Ce projet est un exemple de design pattern Bridge
 * Se programme permet de gérer
 */
public class Program
{

 static void Main(string[] args)
 {
  NintendoSwitchRemoteController nintendoSwitchRemoteController = new NintendoSwitchRemoteController(new NintendoSwitchGameConsole());
  nintendoSwitchRemoteController.SwitchOn();
  nintendoSwitchRemoteController.SetGame("Mario kart 8");
  nintendoSwitchRemoteController.SwitchOff();
  
  MicrosoftXboxRemoteController microsoftXboxRemoteController = new MicrosoftXboxRemoteController(new MicrosoftXboxGameConsole());
  microsoftXboxRemoteController.SwitchOn();
  microsoftXboxRemoteController.SetGame("GTA V");
  microsoftXboxRemoteController.SwitchOff();
            
 }

}
