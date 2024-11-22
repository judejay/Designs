using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class Command
    {

        // Encapsulate a request as an object, thereby letting you parameterize clients with different requests,
        // queue or log requests, and support undoable operations.

        //Create a radio and it's up/down command objects

        public void Run()
        {
            Radio radio = new Radio();
            radio.TurnOn();
            IVoiceCommand volumeUp = new VolumnUpCommand(radio);
            IVoiceCommand volumeDown = new VolumnDownCommand(radio);
            

            //Create a window and it's up/down command objects

            ElectricWindow window = new ElectricWindow();
            IVoiceCommand windowUp = new WindowUpCommand(window);
            IVoiceCommand windowDown = new WindowDownCommand(window);


            //Create a speech recogniser and set the command objects
            SpeechRecogniser speechRecogniser = new SpeechRecogniser();
            speechRecogniser.SetCommands(volumeUp, volumeDown);
            Console.WriteLine("Speech Recogniser is now controlling the radio");
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearDownSpoken();

            // Now set the command objects to control the window
            speechRecogniser.SetCommands(windowUp, windowDown);
            Console.WriteLine("Speech Recogniser is now controlling the window");
            speechRecogniser.HearDownSpoken();
            speechRecogniser.HearUpSpoken();
            Console.ReadLine();
        }

    }
}
