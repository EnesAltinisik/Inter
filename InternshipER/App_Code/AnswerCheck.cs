using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace InternshipER.App_Code
{
    public class AnswerCheck
    {
        string[] filePaths = Directory.GetFiles(@"C:\Internshiper\snapshot\flag\");


        public void print()
        {
            for (int i = 0; i < filePaths.Length; i++)
            {
                string path = filePaths[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }
        }

        


    }

}

