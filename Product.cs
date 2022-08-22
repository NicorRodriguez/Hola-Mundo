namespace Product;
using Review;

public class Product{
    public string name {get; set;} = "";
    private List<Review> _review = new List<Review>();
    public int price {get; set;} = 0;

    public void cleanReview(Review newreview){
        new List<Review>();
    }

    public void addReview(Review newreview){
        _review.Add(newreview);
    }

    public void getReviews(){
        foreach (var rev in _review){
            Console.WriteLine(rev.desc);
        }
    }

}