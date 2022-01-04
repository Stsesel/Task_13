using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Building
    {
        string adress;
        double length;
        double width;
        double hight;

        double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                    length = 0;
                else if (value >= 200)
                    length = 200;
                else
                    length = value;

            }
        }

        double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                    width = 0;
                else if (value >= 200)
                    width = 200;
                else
                    width = value;

            }
        }


        double Hight
        {
            get
            {
                return hight;
            }
            set
            {
                if (value <= 0)
                    hight = 0;
                else if (value >= 200)
                    hight = 200;
                else
                    hight = value;

            }
        }



        public Building (string adress, double length, double width, double hight)
        {
            this.adress = adress;
            this.Length = length;
            this.Width = width;
            this.Hight = hight;

        }

        public string Print()
        {
            return $"Адрес здания: {adress} \nДлина здания: {length} м \nШирина здания: {width} м \nВысота здания: {hight} м";
        }
    }
}
