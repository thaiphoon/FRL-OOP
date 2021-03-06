﻿using System;
using System.Speech.Synthesis;

namespace ClassExempel.Model
{
    class Dog : Animal
    {
        public Dog(string name, string color, Gender gender, int age)
        {
            Name = name;
            Color = color;
            _gender = gender;
            _dateOfBirth = DateTime.Now.AddYears((-1 * age));
        }

        public Dog()
        {
               
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woff Woff");
        }

        public string Bark(string bark)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer() { };
            //synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Speak(bark);
            return bark;
        }
        
    }
}
