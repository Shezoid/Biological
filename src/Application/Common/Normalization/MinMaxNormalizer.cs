namespace Application.Common.Normalization;

public class MinMaxNormalizer : INormalizer
{
    public double Normalize(
        double value,
        double min,
        double max)
    {
        if (Math.Abs(max - min) < 0.001)
            return 0;

        return Math.Clamp(
            (value - min) / (max - min), 0, 1);
    }
}