using RSRC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class NumberMethods
    {
        const int _Twenty = 20;
        const int _Hundred = 100;
        static String[] _ArrUnits = { FarsiNum.Zero, FarsiNum.One, FarsiNum.Two, FarsiNum.Three,
    FarsiNum.Four, FarsiNum.Five, FarsiNum.Six, FarsiNum.Seven, FarsiNum.Eight, FarsiNum.Nine, FarsiNum.Ten, FarsiNum.Eleven,
    FarsiNum.Twelve, FarsiNum.Thirteen, FarsiNum.Fourteen, FarsiNum.Fifteen, FarsiNum.Sixteen,
    FarsiNum.Seventeen, FarsiNum.Eighteen, FarsiNum.Nineteen };

        static String[] _ArrtTens = { string.Empty, string.Empty, FarsiNum.Twenty, FarsiNum.Thirty, FarsiNum.Forty,
    FarsiNum.Fifty, FarsiNum.Sixty, FarsiNum.Seventy, FarsiNum.Eighty, FarsiNum.Ninety };

        public static string ConvertAmount(this double TmpAmount)
        {
            Int64 TmpAmountInt = (Int64)TmpAmount;
            Int64 TmpAmountDec = (Int64)Math.Round(
                (TmpAmount - (double)(TmpAmountInt)) * _Hundred);
            if (TmpAmountDec == 0)
                return  Convert(TmpAmountInt);
            else
                return Convert(TmpAmountInt) + " " + FarsiNum.Point + " " +
                    Convert(TmpAmountDec);

        }
        public static string Convert(this Int64 TmpAmountInt)
        {
            if (TmpAmountInt < _Twenty)
                return _ArrUnits[TmpAmountInt];
            else if (TmpAmountInt < _Hundred)
                return _ArrtTens[TmpAmountInt / 10] +
                          ((TmpAmountInt % 10 > 0) ? " " + Convert(TmpAmountInt % 10) : string.Empty);
            else
                return FarsiNum.ThreeDots;
        }
        public static string InsertComma(this string TmpNum)
        {
            var TmpComma = string.Empty;
            if (TmpNum == string.Empty || TmpNum == FarsiNum.Zero0) return TmpNum;
            decimal TmpPrice;
            TmpPrice = decimal.Parse(TmpNum, System.Globalization.NumberStyles.Currency);
            TmpComma = TmpPrice.ToString("#,#");
            return TmpComma;
        }
        public static string RemoveComma(this string TmpNum)
        {
            var TmpArrTmpNum = TmpNum.Split(',');
            var TmpNotComma = string.Empty;
            var TmpSB = new StringBuilder();

            foreach (var TmpArrTmpNumItem in TmpArrTmpNum)
            {
                TmpSB.Append(TmpArrTmpNumItem);
            }
            TmpNotComma = TmpSB.ToString();
            return TmpNotComma;

        }


    }
}
