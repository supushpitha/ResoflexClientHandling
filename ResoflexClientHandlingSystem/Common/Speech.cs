using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Common
{
    class Speech
    {
        public static void speak(string text)
        {
            if (text != null)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();

                synth.SetOutputToDefaultAudioDevice();
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);

                synth.Speak(text);

                synth.Dispose();
            }
        }
    }
}
