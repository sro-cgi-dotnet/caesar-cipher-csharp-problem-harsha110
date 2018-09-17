using System;
using System.Linq;
using System.Text;
namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
           StringBuilder sb = new StringBuilder();
         //char[] str2 = new char[str.Length];

         if(shiftKey==0 || shiftKey==26)
         {
             return text;
         }
          int j=0;
         for (int i= 0; i < text.Length; i++)
         {
            j=text[i];
            if(j>=65 && j<=90)
            {
                if(j+shiftKey<=90)
                {
                    j=(j+shiftKey);
                   sb.Insert(i,(char)j);
                   //str2[i]=(char)j;
                }
                else
                {
                    j=((j+shiftKey)%90)+64;
                    sb.Insert(i,(char)j);
                    //str2[i]=(char)j;
                }
            }
            else if(j>=97&&j<=122)
            {
                if(j+shiftKey<=122)
                {
                    j=j+shiftKey;
                    //str2[i]=(char)j;
                    sb.Insert(i,(char)j);
                }
                else
                {
                   j=((j+shiftKey)%122)+96;
                   sb.Insert(i,(char)j);
                    //str2[i]=(char)j;
                }
            }
            else{
                //str2[i]=(char)j;
                sb.Insert(i,(char)j);
            }
         }
        //string charsStr = new string(str2);
        string ans = Convert.ToString(sb);
         return ans;
        }
    }
}
