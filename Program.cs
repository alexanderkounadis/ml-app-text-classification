using MyMLAppML.Model;
using System;

namespace myMLApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Add input data
            ModelInput input = new ModelInput();

            input.SentimentText = "That is rude.";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
        }
    }
}
