namespace Katas.Interfaces
{
    public interface ICalculationStats
    {
        int GetMinValue(int[] arr);
        int GetMaxValue(int[] arr);
        int Count(int[] arr);
        decimal GetAverageValue(int[] arr);
    }
}
