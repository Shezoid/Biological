namespace Application.Common.Normalization;

public interface INormalizer
{
    double Normalize(
        double value,
        double min,
        double max);
}