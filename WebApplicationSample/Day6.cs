namespace WebApplicationSample
{
    internal class Day6
    {
        public int[] getChange(float price_of_item,int money_given_to_purchase)
        {
            float changeInRupies = money_given_to_purchase - price_of_item;

            int[] coins = { 100, 50, 25, 10, 5, 1 };
            int[] result = { 0, 0, 0, 0, 0, 0 };

            int changeInPainsa = (int)(changeInRupies * 100);

            for (int i = 0; i < coins.Length; i++)
            {
                while (changeInPainsa >= coins[i])
                {
                    changeInPainsa -= coins[i];
                    result[i]++;
                }
            }
            return result;
        }
    }
}
