

namespace Shippers.Models
{
  public class Parcel
  {
    public float Height { get; set; }
    public float Length { get; set; }
    public float Width { get; set; }
    public float Weight { get; set; }
    public float Volume { get; set; }
    public float Price { get; set; }

    public Parcel(float height, float length, float width, float weight)
    {
      Height = height;
      Length = length;
      Width = width;
      Weight = weight;
      Volume = 0;
      Price = 0;
    }

    public void GetVolume()
    {
      Volume = Height * Length * Width;
    }

    public void CostToShip()
    {
      float price = 0;
      if (Weight < 1)
      {
        price = 5 + (0.05f * Volume);
      }
      else
      {
        price = 10 + (0.05f * Volume);
      }
      Price = price;
    }
  }
}