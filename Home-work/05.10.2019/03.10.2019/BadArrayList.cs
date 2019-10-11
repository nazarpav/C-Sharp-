using System;
using System.Collections;
using System.Text;

namespace _03._10._2019
{
    class BadArrayList
    {
        ArrayList list = new ArrayList();
        Random rand = new Random();

        public void start()
        {
            for (int i = 0; i < 25; i++)
            switch (rand.Next(0,3))
            {
                case 0:
                        list.Add(Convert.ToBoolean(rand.Next(0,2)));
                    break;
                case 1:
                        list.Add(rand.Next(0, 16578));
                    break;
                case 2:
                        list.Add((double)rand.Next(0, 16578)*MathF.PI);
                    break;
                default:
                    throw new Exception("invalid type");
            }
            ArrayList listbool = new ArrayList();
            ArrayList listint = new ArrayList();
            ArrayList listdouble = new ArrayList();
            for (int i = 0; i < list.Count; i++)
                if (list[i].GetType() == typeof(int)) listbool.Add(list[i]);
                else if (list[i].GetType() == typeof(bool)) listint.Add(list[i]);
                else if (list[i].GetType() == typeof(double)) listdouble.Add(list[i]);
                else throw new Exception("invalid type");
            foreach (var i in listbool)
                Console.WriteLine(i);
            foreach (var i in listint)
                Console.WriteLine(i);
            foreach (var i in listdouble)
                Console.WriteLine(i);


        }
    }
}
