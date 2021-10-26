using System;
using System.Collections.Generic;

namespace String_Calc
{
    public class Class1
    {
        public static int Add(string data)
        {
            int answer = 0;
            // string neg_answer = "negatives not allowed";
            string[] values;
            var delim_list = new List<string>()
                {",","\n"};

            if (data == "")
            {
                return 0;
            }

            if (data.Contains("//"))
            {
                int delim_pos = data.IndexOf("\n");
                string delim = data.Substring(2,delim_pos-2);
                delim_list.Add(delim);
                data = data.Substring(delim_pos+1);
            }

            foreach (var delim in delim_list)
            {
                data = data.Replace(delim, delim_list[0]);
            }

            values = data.Split(",");

            foreach (var item in values)    
            {
                answer = answer + Convert.ToInt32(item);
            }

            return answer;
        }
    }
}