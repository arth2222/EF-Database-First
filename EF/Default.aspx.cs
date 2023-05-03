using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //snippet for å vise insert. dette kan legges i en dblayer som metoder
            var db=new PersonsEntities();
            var person=new Person();
            person.Id = 2;
            person.PostalCode = 1630;
            person.FirstName = "Nico";
            person.LastName = "Luring";
            db.Person.Add(person);
            db.SaveChanges();
        }
    }
}

//database script
