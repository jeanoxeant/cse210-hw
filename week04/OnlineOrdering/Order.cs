using System;


public class Order
{
    List<string> Customers;
    List<string> Products;

    public int GetTotalCostOrder()
    {
        return TotalCost() + ShipingLabel();
    }

    public string PackingLabel()
    {
        List<Products> _name;
        //List<Products> _productId;
    }

    public string ShipingLabel(double shippingCost)
    {
        List<customers> _name;
        List<Customers> _streetAdress;
        
        if (GetInfo == USA)
        {
            return shippingCost = 5;
        }
        else
        {
            return shippingCost = 35;
        }

    }
}