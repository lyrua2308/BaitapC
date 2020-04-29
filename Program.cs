using System;

namespace Bai2_chuong3_part2
{
    class tiendien
    {
        protected string hoten;
        protected string diachi;
        protected int congtothangtrc;
        protected int congtothangnay;
        protected int dadung;
        protected int tien;
        public tiendien()
        {
            hoten = " ";
            diachi = " ";
            congtothangtrc = congtothangnay = 0;
                
        }    
        public tiendien(string hoten, string diachi, int trc , int nay )
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.congtothangtrc = trc;
            this.congtothangnay = nay;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ho ten cua chu ho ");
            hoten = Console.ReadLine();
            Console.WriteLine("nhap dia chi cua chu ho ");
            diachi = Console.ReadLine();
            Console.WriteLine("nhap so cong to thang truoc ");
            congtothangtrc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so cong to thang nay  ");
            congtothangnay = Convert.ToInt32(Console.ReadLine());
        }
        public double sodiendadung()
        {
            dadung = congtothangnay - congtothangtrc;
            return dadung;
        }
        public double tinhtien()
        {
            tien = dadung * 500;
            return tien;
        }
         public virtual void xuat()
        {
            Console.WriteLine("chu ho {0} \t dia chi {1} \t tong so dien da dung {2} \t so tien thang nay {3}", hoten, diachi, dadung, tien);
        }
    }
    class tiendienmoi:tiendien
    {
        protected int dinhmuc;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap dinh muc 500 hoac 600  ");
            dinhmuc = Convert.ToInt32(Console.ReadLine());

        }
        public double tinhtien()
        {
            tien = dadung * dinhmuc; 
            return tien;
        }
        public override void xuat()
        {
            base.xuat();
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            //tiendien td1;
            //td1 = new tiendien();
            //td1.nhap();
            //td1.sodiendadung();
            //td1.tinhtien();
            //td1.xuat();

            //tiendien td2;
            //td2 = new tiendien("nguyen thi ly ", "lam dien ", 2000, 3000);
            //td2.sodiendadung();
            //td2.tinhtien();
            //td2.xuat();
            tiendienmoi tdm;
            tdm = new tiendienmoi();
            tdm.nhap();
            tdm.sodiendadung();
            tdm.tinhtien();
            tdm.xuat();
            Console.Read();
        }
    }
}
