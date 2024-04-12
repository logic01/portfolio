
namespace Algorithms
{
    public static class Knapsack

    {
        /// <summary>
        /// When given the weights and profits of ‘N’ items, you are asked to put these items in a “knapsack” 
        /// with a capacity ‘C.’ The goal is to get the optimum profit out of the items in the knapsack.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="total"></param>
        public static void Do(string[] items, int[] weights, int[] profits, int capacity)
        {

            // 1. Combine all items to find what weights are < capacity
            // 2. Lists of combined items which have highest profit

        }

        private static double Recrusive(string[] items, int[] weights, int[] profits, int capacity)
        {
            int totalWeight = 0;
            int totalProfits = 0;

            for (int i = 0; i < items.Length - 1; i++)
            {
                totalWeight += weights[i];
                totalProfits += profits[i];
            }

            if (totalWeight < capacity)
                return totalProfits;

            int middleIndex = items.Length - 1 / 2;

            var leftProfit = Recrusive(items, weights, profits, capacity);
            var rightProfit = Recrusive(items, weights, profits, capacity);

            return leftProfit > rightProfit ? leftProfit : rightProfit;
        }
    }
}
