using System;

class address{

private string postCode;

{
  public address()
  {

  }

  public string Postcode
  {
    get
    {
      return postCode;
    }

    set
    {
      if(validPostcode(value))
      {
        postCode=value;
      }
      else
      {
        throw new PostCodeException("Post code is not valid. Please re-enter postcode in the correct format")
      }
    }

    
  }

  public bool validPostcode(string pCode)
  {
    bool invalid=true;

    return invalid;
  }

}
}
