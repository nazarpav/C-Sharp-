using System;

namespace _30._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            figure f = new figure();

            try
            {
                f.SwichColor();
                f.Draw();
            }
            catch
            {

            }
            finally
            {
            f.Dispose();

            }
        }
    }
}
