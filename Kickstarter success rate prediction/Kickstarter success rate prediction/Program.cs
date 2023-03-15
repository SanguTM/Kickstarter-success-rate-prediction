// See https://aka.ms/new-console-template for more information'
using Microsoft.ML;
using Kickstarter_success_rate_prediction;

// Create single instance of sample data from first line of dataset for model input
MLModel1.ModelInput sampleData = new MLModel1.ModelInput();
/*{
    Category = @"Narrative Film",
    Goal = 30000F,
    Backers = 15F,
};*/

Console.WriteLine("In which category your project belong to?");
sampleData.Category = Console.ReadLine();

Console.WriteLine("How much money you want to collect?");
sampleData.Goal = float.Parse(Console.ReadLine());

Console.WriteLine("How much backers you expect?");
sampleData.Backers = float.Parse(Console.ReadLine());

Console.WriteLine("How long is your deadline in days?");
sampleData.Days = float.Parse(Console.ReadLine());

Console.WriteLine("Using model to make single prediction -- Comparing actual State with predicted State from sample data...\n\n");

Console.WriteLine($"Category: {sampleData.Category}");
Console.WriteLine($"Goal: {sampleData.Goal}");
Console.WriteLine($"Expected Backers: {sampleData.Backers}");
Console.WriteLine($"Deadline days: {sampleData.Days}");

var sortedScoresWithLabel = MLModel1.PredictAllLabels(sampleData);
Console.WriteLine($"{"Class",-40}{"Score",-20}");
Console.WriteLine($"{"-----",-40}{"-----",-20}");

foreach (var score in sortedScoresWithLabel)
{
    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");;
}

//Load model and predict output
Console.WriteLine("=============== Predicted state ===============");
var result = MLModel1.Predict(sampleData);
Console.WriteLine(result.PredictedLabel);

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();