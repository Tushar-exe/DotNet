namespace BLL;

using BOL;

using DAL;

public class ProductManager
{
    public List<Product>showAllPro()
    {
        List<Product>allProducts=new List<Product>();

        allProducts=DBManager.showAllPro();
        return allProducts;
    }

}
