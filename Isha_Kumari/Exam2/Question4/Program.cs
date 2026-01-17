namespace Question4;

class Supplier
{
    public string SupplierID{get; set;}
    public string Name{get; set;}
    public string Contact{get; set;}
    public int ProductsSupplied{get; set;}
    public double Rating{get; set;}

    public Supplier(string supplierId, string name, string contact, int productsSupplied, double rating)
    {
        SupplierID = supplierId;
        Name = name;
        Contact = contact;
        ProductsSupplied = productsSupplied;
        Rating = rating;
    }
}
class SupplierOperations
{
    List<Supplier> suppliers = new List<Supplier>();

    //add supplier
    public void AddSupplier(Supplier s)
    {
        suppliers.Add(s);
    }

    //update supplier
    public void UpdateSupplier(string id, Supplier updated)
    {
        for(int i=0; i<suppliers.Count; i++)
        {
            if(suppliers[i].SupplierID == id)
            {
                suppliers[i] = updated;
            }
        }
    }

    //delete supplier
    public void DeleteSupplier(string id)
    {
        for(int i=0; i<suppliers.Count; i++)
        {
            if(suppliers[i].SupplierID == id)
            {
                suppliers.RemoveAt(i);
            }
        }
    }

    //get supplier by id
    public Supplier GetSupplierById(string id)
    {
        Supplier found = null;
        foreach(Supplier s in suppliers)
        {
            if(s.SupplierID == id)
            {
                found = s;
            }
        }
        return found;
    }

    //display all suppliers
    public void DisplayAllSuppliers()
    {
        foreach(Supplier s in suppliers)
        {
            Console.WriteLine($"Supplier ID : {s.SupplierID}\tName : {s.Name}\tContact : {s.Contact}\tProducts Supplied : {s.ProductsSupplied}\tRating : {s.Rating}");
        }
    }

    //Search suppliers by rating
    public void SearchSuppliers(double minRating)
    {
        Supplier found = null;
        foreach(Supplier s in suppliers)
        {
            if(s.Rating > minRating)
            {
                Console.WriteLine($"Supplier ID : {s.SupplierID}\tName : {s.Name}\tContact : {s.Contact}\tProducts Supplied : {s.ProductsSupplied}\tRating : {s.Rating}");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        SupplierOperations operations = new SupplierOperations();
        operations.AddSupplier(new Supplier("1029","Microsoft","7384901256",25,4.5));
        operations.AddSupplier(new Supplier("6437","Google","6478632744",20,3.9));
        operations.AddSupplier(new Supplier("2378","Apple","7476842891",50,4.2));
        operations.AddSupplier(new Supplier("0345","Meta","3681392890",30,3.8));
        operations.AddSupplier(new Supplier("1246","Gemini","9784874738",15,3.5));
        operations.AddSupplier(new Supplier("1238","Cognizant","9749327832",35,4.1));
        operations.AddSupplier(new Supplier("8464","Capgemini","7904743827",45,4.2));
        //updating
        operations.UpdateSupplier("2378",new Supplier("7634","Infosys","7462864196",50,4.2));
        operations.UpdateSupplier("0346",new Supplier("7430","TCS","7498661812",30,3.8));
        //deleteing
        operations.DeleteSupplier("1246");
        //searching
        Console.WriteLine("Searching all suppliers with rating greater than 4.0");
        operations.SearchSuppliers(4.0);
        Console.WriteLine();
        //displaying all
        Console.WriteLine("Displaying all Suppliers");
        operations.DisplayAllSuppliers();
        Console.WriteLine();

    }
}
