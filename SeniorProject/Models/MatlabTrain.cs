using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class MatlabTrain
    {
        public static void train(int nHiddenNeurons, int N0, int Block)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute("cd " + AppDomain.CurrentDomain.BaseDirectory + "Matlab\\");
            object result = null;
            matlab.Feval("OSELM_train", 2, out result, "trainResource.txt", 1, nHiddenNeurons, "sig", N0, Block);
            object[] res = result as object[];
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.ReadLine();
            matlab.Quit();
        }
    }

