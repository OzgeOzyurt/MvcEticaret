using Microsoft.AspNetCore.Mvc;

public class ProductItemViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(string title, int startCount, double oldPrice, double price, string imageUrl, bool isSale)
    {
        var model = new ProductItemViewModel
        {
            Title = title,
            StartCount = startCount,
            OldPrice = oldPrice,
            Price = price,
            ImageUrl = imageUrl,
            IsSale = isSale
        };

        return View(model);
    }
}

public class ProductItemViewModel
{
    public string Title { get; set; }
    public int StartCount { get; set; }
    public double OldPrice { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public bool IsSale { get; set; }
}
