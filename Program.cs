using Product;
using  Review;

public class Program{
    public static void Main(){

        var myproduct = new Product.Product();

        myproduct.name = "niconaitor";

        var myreview = new Review.Review();
        var myreview2 = new Review.Review();

        myreview.desc = "El mejor producto de la HIS TO RIA";
        myreview2.desc = "El mejor producto de la HIS TO RIA X2";

        myproduct.addReview(myreview);
        myproduct.addReview(myreview2);

        myproduct.getReviews();

    }
}