namespace BusinessLogic;

public class Square : Shape
{
    public Square ()
    {
        MaterialHandler = new MaterialHandler();
    }
    public MaterialHandler MaterialHandler { get; set; }
    
    public override int Area()
    {
        return Side * Side;
    }

    public override int CalculateCost()
    {
        return Area() * MaterialHandler.GetMaterialCost(Material);
    }
    
    
}