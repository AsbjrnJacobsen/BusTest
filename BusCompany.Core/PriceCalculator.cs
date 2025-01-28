namespace BusCompany.Core;

public class PriceCalculator
{
    public static int CalculatePrice(int distanceKm)
    {
        const int initialFee = 2500;

        if (distanceKm <= 100)
        {
            return initialFee + distanceKm * 10;
        }
        else if(distanceKm <= 500)
        {
            return initialFee + 100 * 10 + (distanceKm - 100) * 8;
        }
        else
        {
            return initialFee + 100 * 10 + 400 * 8 + (distanceKm - 500) * 6;
        }
        
        return 2500;
    }
}