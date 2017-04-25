namespace CompositePattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var garment = new CompositeGarment();
            var garment1 = new CompositeGarment();
            var garment2 = new CompositeGarment();

            var coat1 = new Coat();
            var coat2 = new Coat();
            var hat1 = new Hat();
            var hat2 = new Hat();

            garment1.Add(coat1);
            garment1.Add(hat2);
            garment1.Add(hat1);

            garment2.Add(coat2);

            garment.Add(garment1);
            garment.Add(garment2);

            garment.Print();

            garment.Delete(garment1);
            garment.Print();

            Console.ReadLine();
        }
    }
}
