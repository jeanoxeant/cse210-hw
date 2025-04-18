using System;


public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _quantity;

    public void TotalCost()
    {
        return _productPrice * _quantity;
    }

}