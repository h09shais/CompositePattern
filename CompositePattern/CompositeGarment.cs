namespace CompositePattern
{
    using System.Collections.Generic;

    public class CompositeGarment : IGarment
    {
        private readonly List<IGarment> garments;

        public CompositeGarment()
        {
            this.garments = new List<IGarment>();
        }

        public void Add(IGarment garment)
        {
            this.garments.Add(garment);
        }

        public void AddRange(IGarment[] garments)
        {
            this.garments.AddRange(garments);
        }

        public void Delete(IGarment garment)
        {
            this.garments.Remove(garment);
        }

        public void Print()
        {
            foreach (var garment in this.garments)
            {
                garment.Print();
            }
        }
    }
}
