using System;

namespace Bai1_Chuong3_Part2
{
    class tamgiac
    {
        protected int a, b, c;
        protected double dientich;
        public tamgiac()
        {
            a = b = c = 0;
        }
        public tamgiac(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public virtual void nhap()
        {
            Console.WriteLine("nhap canh thu nhat ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap canh thu hai ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap canh thu ba ");
            c = Convert.ToInt32(Console.ReadLine());
        }
         public virtual double tinhdientich()
        {
            double p = (a + b + c) * 0.5;
            dientich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return dientich;
        }
         public virtual void xuat()
        {
            Console.WriteLine("thong tin tam giac vua nhap la \n cac canh lan luot la: {0} , {1} ,{2}  \n co dien tich la {3}", a, b, c, dientich);
        }

    }
    class TuDien:tamgiac
    {
        private double chieucao;
        private double thetich;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap vao chieu cao ");
            chieucao = Convert.ToDouble(Console.ReadLine());

        }
        public double tinhthetich()
        {
            thetich = (dientich  * chieucao)/3;
            return thetich;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("the tich cua tu dien la " + thetich);
        }
    }
    class danhsachtamgiac
    {
        public int n;
        public tamgiac[] DS;
        public void nhap()
        {
            Console.WriteLine("nhap so luong phan tu  ");
            n = Int32.Parse(Console.ReadLine());
            DS = new tamgiac[n];
            for (int i = 0; i < n; i++)
            {
                DS[i] = new tamgiac();
                DS[i].nhap();
            }
        }
        public void xuat()
        {
            for (int i = 0; i < n; i++)
            {
                DS[i].tinhdientich();
                DS[i].xuat();

            }
        }    

    }
    class Program
    {
        static void Main(string[] args)
        {
            //tamgiac tg1;
            //tg1 = new tamgiac(3, 4, 5);
            //////tg1 = new tamgiac();
            ////tg1.nhap();
            //tg1.tinhdientich();
            //tg1.tinhdientich();
            //tg1.xuat();

            //TuDien td1;
            //td1 = new TuDien();
            //td1.nhap();
            //td1.tinhdientich();
            //td1.tinhthetich();
            //td1.xuat();
            danhsachtamgiac ds1;
            ds1 = new danhsachtamgiac();
            ds1.nhap();
            ds1.xuat();

            Console.ReadLine();
        }
    }
}
