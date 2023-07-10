namespace ShapeTracker.Models
{
    public class Rectangle
    {
        public int SidesA { get; set;}
        public int SidesB { get; set;}

        public Rectangle(int length1, int length2)
        {
            SidesA = length1;
            SidesB = length2;
        }

        public int GetArea()
        {
            return (SidesA * SidesB);
        }
    }
}