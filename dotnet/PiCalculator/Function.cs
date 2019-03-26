using System.Collections.Generic;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PiCalculator
{
    public class Function
    {
        private List<double> history = new List<double>();

        public double FunctionHandler(string input, ILambdaContext context)
        {
            context.Logger.LogLine($"Starting. Iterations: {input}");

            var number = int.Parse(input);
            var sign = 1;
            var pi = 0.0;
            for (var index = 0; index < number; index++)
            {
                pi += sign * 4 / (double) (index * 2 + 1);
                sign *= -1;
                history.Add(pi);
            }

            context.Logger.LogLine($"Done. List length: {history.Count}");

            return pi;
        }
    }
}