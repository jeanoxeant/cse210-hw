using System;


public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public void TotalCost()
    {
        return _price * _quantity;
    }

}