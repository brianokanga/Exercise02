using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    public static class BigIntExTension
    {
        public static string Towards(this String Number)
        {
            string word = "";
           
            bool isDone = false;//test if already translated
            double dblNum = (Convert.ToDouble(Number));
            
            if (dblNum > 0)
            {
      
                int digitsCount = Number.Length;
                int position = 0;//store digit grouping
                String place = "";//digit grouping name:hundres,thousand,etc...
                switch (digitsCount)
                {
                    case 1://ones' range

                        word = Ones(Number);
                        isDone = true;
                        break;
                    case 2://tens' range
                        word = Tens(Number);
                        isDone = true;
                        break;
                    case 3://hundreds' range
                        position = (digitsCount % 3) + 1;
                        place = " Hundred ";
                        break;
                    case 4://thousands' range
                    case 5:
                    case 6:
                        position = (digitsCount % 4) + 1;
                        place = " Thousand ";
                        break;
                    case 7://millions' range
                    case 8:
                    case 9:
                        position = (digitsCount % 7) + 1;
                        place = " Million ";
                        break;
                    case 10://Billions's range
                    case 11:
                    case 12:

                        position = (digitsCount % 10) + 1;
                        place = " Billion ";
                        break;
                    case 13:
                    case 14:
                    case 15:

                        position = (digitsCount % 13) + 1;
                        place = " Trillion ";
                        break;
                    case 16:
                    case 17:
                    case 18:

                        position = (digitsCount % 16) + 1;
                        place = " Quadrillion ";
                        break;
                    case 19:
                    case 20:
                    case 21:

                        position = (digitsCount % 19) + 1;
                        place = " Quintillion ";
                        break;
                    default:
                        isDone = true;
                        break;
                }
                if (!isDone)
                {
                    if (Number.Substring(0, position) != "0" && Number.Substring(position) != "0")
                    {
                        try
                        {
                            word = ConvertWholeNumber(Number.Substring(0, position)) + place + ConvertWholeNumber(Number.Substring(position));
                        }
                        catch { }
                    }
                    else
                    {
                        word = ConvertWholeNumber(Number.Substring(0, position)) + ConvertWholeNumber(Number.Substring(position));
                    }

                    
                }
                //ignore digit grouping names
                if (word.Trim().Equals(place.Trim())) word = "";
            }
            
            return word.Trim();
        }
        public static String ConvertWholeNumber(String Number)
        {
            string word = "";
            
            bool isDone = false;//test if already translated
            double dblNum = (Convert.ToDouble(Number));
            //if ((dblNum > 0) && number.StartsWith("0"))
            if (dblNum > 0)
            {
                int digitsCount = Number.Length;
                int position = 0;//store digit grouping
                String place = "";
                switch (digitsCount)
                {
                    case 1://ones' range

                        word = Ones(Number);
                        isDone = true;
                        break;
                    case 2://tens' range
                        word = Tens(Number);
                        isDone = true;
                        break;
                    case 3://hundreds' range
                        position = (digitsCount % 3) + 1;
                        place = " Hundred ";
                        break;
                    case 4://thousands' range
                    case 5:
                    case 6:
                        position = (digitsCount % 4) + 1;
                        place = " Thousand ";
                        break;
                    case 7://millions' range
                    case 8:
                    case 9:
                        position = (digitsCount % 7) + 1;
                        place = " Million ";
                        break;
                    case 10://Billions's range
                    case 11:
                    case 12:

                        position = (digitsCount % 10) + 1;
                        place = " Billion ";
                        break;
                    case 13:
                    case 14:
                    case 15:

                        position = (digitsCount % 13) + 1;
                        place = " Trillion ";
                        break;
                    case 16:
                    case 17:
                    case 18:

                        position = (digitsCount % 16) + 1;
                        place = " Quadrillion ";
                        break;
                    case 19:
                    case 20:
                    case 21:

                        position = (digitsCount % 19) + 1;
                        place = " Quintillion ";
                        break;
                    default:
                        isDone = true;
                        break;
                }
                if (!isDone)
                {
                    if (Number.Substring(0, position) != "0" && Number.Substring(position) != "0")
                    {
                        try
                        {
                            word = $"{ConvertWholeNumber(Number.Substring(0, position))}{place}{ConvertWholeNumber(Number.Substring(position))}";
                        }
                        catch { }
                    }
                    else
                    {
                        word = $"{ConvertWholeNumber(Number.Substring(0, position))}{ConvertWholeNumber(Number.Substring(position))}";
                    }

                        
                }
                
                if (word.Trim().Equals(place.Trim())) word = "";
            }
       
         
            return word.Trim();
        }

        public static String Tens(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = null;
            switch (_Number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = $"{Tens(Number.Substring(0, 1) + "0")} {Ones(Number.Substring(1))}";
                    }
                    break;
            }
            return name;
        }


        public static String Ones(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = "";
            switch (_Number)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }
    }
}
