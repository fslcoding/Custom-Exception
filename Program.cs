using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string postCode;
    Console.WriteLine ("Please enter postcode:");
    address adrs = new address();
    try
    {
      postCode = Console.ReadLine();
      adrs.PostCode(postCode)

    }
    
    catch(PostCodeException pex)
    {
      Console.WriteLine("The following error occurred "+ pex.ToString();
    }
  }
}
