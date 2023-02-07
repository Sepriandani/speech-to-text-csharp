using System;
using System.Speech.Recognition;

namespace SpeechToText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi engine speech recognition
            using (SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("id-ID")))
            {
                // Membuat grammar untuk mengakui kalimat dasar
                GrammarBuilder grammarBuilder = new GrammarBuilder();
                grammarBuilder.AppendDictation();
                Grammar grammar = new Grammar(grammarBuilder);
                recognizer.LoadGrammar(grammar);

                // Mulai menerima masukan suara
                Console.WriteLine("Berbicara sekarang.");
                recognizer.SetInputToDefaultAudioDevice();
                RecognitionResult result = recognizer.Recognize();

                // Menampilkan teks hasil analisis
                Console.WriteLine("Anda berkata: " + result.Text);
            }
        }
    }
}
