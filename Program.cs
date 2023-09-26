using System;
using System.Reflection.Metadata;

namespace Tugaspbo
{
    class Vga
    {
        public string merk;
        public Vga(string merk)
        {
            this.merk = merk;
        }
    }

    class Nvidia : Vga
    {
        public Nvidia(string merk) : base(merk)
        {
            merk = "Nvidia";
        }
    }

    class Amd : Vga
    {
        public Amd(string merk) : base(merk)
        {
            merk = "AMD";
        }
    }

    class Processor
    {
        public string merk;
        public string tipe;
        public Processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
    }

    class Intel : Processor
    {
        public Intel(string merk, string tipe) : base("Intel", tipe)
        {
        }
    }

    class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        {
        }
    }

    class Corei3 : Intel
    {
        public Corei3(string merk) : base(merk, "Core i3")
        {
        }
    }

    class Corei5 : Intel
    {
        public Corei5(string merk) : base(merk, "Core i5")
        {
        }
    }

    class Corei7 : Intel
    {
        public Corei7(string merk) : base(merk, "Core i7")
        {
        }
    }

    class Ryzen : AMD
    {
        public Ryzen(string tipe) : base("RAYZEN")
        {
        }
    }

    class Athlon : AMD
    {
        public Athlon(string tipe) : base("ATHLON")
        {
        }
    }

    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;
        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop yang bermerk {this.merk} bertipe {this.tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop yang bermerk {this.merk} bertipe {this.tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(string merk, string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
        {
        }
    }

    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
        {
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
        {
        }
    }

    class ROG : ASUS
    {
        public ROG(string merk, string tipe, Vga vga, Processor processor) : base(merk, "ROG", vga, processor)
        {
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Vivobook", vga, processor)
        {
        }
        public void Ngoding()
        {
            Console.WriteLine($"Ctak Ctak Ctak, error lagi");
        }
    }

    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
        {
        }
    }

    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
        {
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop yang bermerk {this.merk} bertipe {this.tipe} sedang bermain game");
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
        }
    }

    class Legion : Lenovo
    {
        public Legion(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Legion", vga, processor)
        {
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Nvidia vga1 = new Nvidia("Vga Nvidia");
            Amd vga2 = new Amd("Vga AMD");
            Corei5 processor1 = new Corei5("Processor Core i5");
            Ryzen processor2 = new Ryzen("Processor Ryzen");
            Corei7 processor3 = new Corei7("Processor Core i7");

            Laptop laptop1 = new Vivobook("ASUS", "Vivobook", vga1, processor1);
            Laptop laptop2 = new IdeaPad("Lenovo", "Ideapad", vga2, processor2);
            Predator predator = new Predator(vga2, processor3);

            //no1
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            //no2
            //laptop1.Ngoding();

            //no3
            //Console.WriteLine($"Spesifikasi laptop1:");
            //Console.WriteLine($"- VGA: {laptop1.vga.merk}");
            //Console.WriteLine($"- Merk Processor: {laptop1.processor.merk}");
            //Console.WriteLine($"- Tipe Processor: {laptop1.processor.tipe}");

            //no4
            //predator.BermainGame();

            //no5
            //ACER acer = new Predator(vga2,processor3);
            //acer.BermainGame();
        }
    }
}