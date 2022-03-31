using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
    public class OwnerFormViewModel
    {
        //here we are getting the properties for all the Owner form fields
        public Owner Owner { get; set; }
        //this is a list of available neighborhood options for our drop down menu on the form
        public List<Neighborhood> Neighborhoods { get; set; }
    }
}
