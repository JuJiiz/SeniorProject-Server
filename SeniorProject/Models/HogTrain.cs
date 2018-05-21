using Accord.Video.FFMPEG;
using System.Drawing;
using AForge.Imaging.Filters;
using Accord.Imaging;
using System.Collections.Generic;

public class HogTrain
{
	public static double[,] hog(VideoFileReader vdoRead)
	{
        Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
        CannyEdgeDetector canny = new CannyEdgeDetector(0, 5);
        double[,] hogArray = new double[vdoRead.FrameCount - 1, 288];

        for (int i = 0; i < vdoRead.FrameCount - 1; i++)
        {
            Bitmap image = vdoRead.ReadVideoFrame(i);
            Bitmap resize = new Bitmap(image, 400, 300);
            Bitmap imgGray = grayscale.Apply(resize);
            Bitmap imgCanny = canny.Apply(imgGray);

            HistogramsOfOrientedGradients hog = new HistogramsOfOrientedGradients(9, 2, 16);
            Bitmap resizeHOG = new Bitmap(imgCanny, 64, 128);
            List<double[]> resultHOG = hog.ProcessImage(resizeHOG);
            double[][] valueHog = new double[8][];
            resultHOG.CopyTo(valueHog);
            int count = 0;
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 36; k++)
                {
                    if (count < 288)
                    {
                        hogArray[i, count] = valueHog[j][k];
                        count++;
                    }
                }
            }

            //Clear value(Reduce RAM usage)
            image.Dispose();
            resize.Dispose();
            imgGray.Dispose();
            imgCanny.Dispose();
        }

        return hogArray;
    }
}
