package supermarket;

import supermarket.model.core.EAN;
import supermarket.model.core.Product;

public class EANGenerator
{
    private static int modulusEan9 = (int)1E9;

    public static EAN getEANFromHash(Product product)
    {
        String hash = getAllDigitHash(product.getName(), 9, modulusEan9);
        return EAN.newEAN(hash);
    }

    private static String getAllDigitHash(String text, int numDigits, int modulus)
    {
        int shorthash = Math.abs(text.hashCode());
        shorthash = shorthash % modulus;

        String digits = String.valueOf(shorthash);
        for (int i = 0; i < numDigits - digits.length(); i++) {
        	digits += "0";
		}
        
		return digits;
    }
}