using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace SunnyvaleNailBar.Models
{
    public class CommonData
    {
        
        public static string EncodeMD5(string key)
        {
            MD5 md5 = MD5.Create();
            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in bHash)
            {
                sbHash.Append(String.Format("{0:x2}", b));
            }
            return sbHash.ToString();
        }

        public static string decrypt(string cypherString)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(cypherString));
        }

        public static bool CheckEmail(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }

        public static DateTime GetFirsDayOfMonth(DateTime date)
        {
            DateTime firsDate = new DateTime(date.Year, date.Month, 1);
            return firsDate;
        }

        public static DateTime GetLastDayOfMonth(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }

        public static string GetAutoNum(string NUMBERNAME, string CURRENTPREFIX)
        {
            SunnyvaleEntities db_wh = new SunnyvaleEntities();

            var AutoNum = db_wh.AUTONUMs.Where(w => w.NUMBERNAME == NUMBERNAME).FirstOrDefault();
            if (AutoNum != null)
            {
                var Digits = Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(AutoNum.DIGITSWIDTH - 1)));//1.000.000
                if (AutoNum.CURRENTDIGITS == AutoNum.MAXVALUE)
                {
                    return CURRENTPREFIX;
                }
                var CurrentDigits_Interval = AutoNum.CURRENTDIGITS + AutoNum.VALUEINTERVAL;//+1  
                var CurrentDigits_Num = Digits + CurrentDigits_Interval;//1.000.001 
                AutoNum.CURRENTDIGITS = CurrentDigits_Interval;
               
                db_wh.Entry(AutoNum).State = EntityState.Modified;
                db_wh.SaveChanges();

                string str_CurrentDigits_Num = CurrentDigits_Num.ToString();
                //str_CurrentDigits_Num = str_CurrentDigits_Num.Substring(1, str_CurrentDigits_Num.Length - 1);

                NUMBERNAME += str_CurrentDigits_Num;
            }

            return NUMBERNAME;
        }
    }
}