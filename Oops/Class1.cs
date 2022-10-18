namespace Oops
{
    public class Rectangle 
    {
        public string Name {get;set;}
        public Rectangle()
        {
            this.Name = "Rectangle";
        }
        public Rectangle(float plength, float pbreadth):this()
        {
            this.Length = plength;
            this.Breadth = pbreadth;
        }

        public float Length { get; set; }
        public float Breadth{ get; set; }

        public  float CalculateArea()
        {
            return Length * Breadth;
        }
    }
}