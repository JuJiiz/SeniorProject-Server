using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatlabPredict
{
    public static String predict(String hogClass, String hogValue)
    {
        MLApp.MLApp matlab = new MLApp.MLApp();
        matlab.Execute("cd " + AppDomain.CurrentDomain.BaseDirectory);
        object result = null;
        matlab.Feval("OSELM_predict", 2, out result, hogClass, hogValue);
        object[] res = result as object[];
        matlab.Quit();

        return Convert.ToString(res[0]);
    }
}

