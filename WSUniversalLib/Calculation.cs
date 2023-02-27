using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            const float materialType1 = 0.003f;
            const float materialType2 = 0.0012f;

            const float productType1 = 1.1f;
            const float productType2 = 2.5f;
            const float productType3 = 8.43f;

            float a = count * width * length;

            switch (productType)
            {
                default:
                    return -1;

                case 1:
                    a *= productType1;
                    break;

                case 2:
                    a *= productType2;
                    break;

                case 3:
                    a *= productType3;
                    break;
            }

            switch (materialType)
            {
                default:
                    return -1;
                case 1:
                    a += materialType1 * a;
                    break;

                case 2:
                    a += materialType2 * a;
                    break;
            }

            return Convert.ToInt32(Math.Round((decimal)a, 0, MidpointRounding.AwayFromZero));
        }
    }
}