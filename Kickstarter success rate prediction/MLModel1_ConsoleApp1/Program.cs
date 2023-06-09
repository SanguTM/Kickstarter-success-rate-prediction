﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModel1_ConsoleApp1;

// Create single instance of sample data from first line of dataset for model input
MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
{
    Category = @"Narrative Film",
    Goal = 30000F,
    Backers = 15F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual State with predicted State from sample data...\n\n");


Console.WriteLine($"Category: {@"Narrative Film"}");
Console.WriteLine($"Goal: {30000F}");
Console.WriteLine($"State: {@"failed"}");
Console.WriteLine($"Backers: {15F}");


var sortedScoresWithLabel = MLModel1.PredictAllLabels(sampleData);
Console.WriteLine($"{"Class",-40}{"Score",-20}");
Console.WriteLine($"{"-----",-40}{"-----",-20}");

foreach (var score in sortedScoresWithLabel)
{
    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
}

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

