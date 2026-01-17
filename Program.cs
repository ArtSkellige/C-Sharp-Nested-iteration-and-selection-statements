string[] ListOfOrderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string orderID in ListOfOrderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"The orderID {orderID} starts with a 'B' letter!");
    }
}