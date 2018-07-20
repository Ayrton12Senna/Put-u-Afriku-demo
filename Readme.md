The road to Africa, respectively "Put u Afriku" on Croatian is a simple application which is developed as unofficial list of necessary items that every volunteer must pick up on a road.
Application is in demo stage. 

It is thought that the application is being used by volunteers and volunteer centers, respectively road organizers.
Application contain a 3 listbox. First listbox contain a list of items, second listbox contain a list of vendors who provide these items and third listbox who represent the backpack. 

We are created a library who contain a 3 class. The class "Ruksak" has three contructors which is executed when we instance a new object type "Ruksak".
When we create a class in library, Dobavljac for vendor, Predmet for item and Ruksak for backpack, we can create as much as we need object with that type.

There is code who create a objects type vendor and item:
        public List<Dobavljac> Dobavljaci { get; set; }
        public List<Predmet> Predmeti { get; set; }
        
There is constructor who create a list of vendors and items:
        public Ruksak()
        {
            Dobavljaci = new List<Dobavljac>();
            Predmeti = new List<Predmet>();
        }


So, we can easily add item onto their listbox with code like ruksak.Dobavljaci.Add(new Dobavljac { NazivTvrtke = "Ljekarna"}); 
or ruksak.Predmeti.Add(new Predmet {Naziv = "Povratna karta", OpisProizvoda = "Obrazovna potrebština", Cijena = 3500M, dobavljacProizvoda = ruksak.Dobavljaci[1] });

The items are added in the backpack listbox with click on button with this code:

        private void dodajURuksak_Click(object sender, EventArgs e)
        {
          Predmet odabraniPredmet = (Predmet)predmetiListbox.SelectedItem;
          predmetiURuksaku.Add(odabraniPredmet);
          poveziRuksak.ResetBindings(false);
        }
        
When user click on another button, they pick up the backpack. That means label show what is total cost of road and how much organizer pay for every individual volunteer.
With that information, organizer can manage with activities before road and organize enough food, tickets, clothes, and other items for peoples who go on road.

In that demo version, additional feature is adding new items or vendor what volunteers and volunteer centers are needed if a member of list does not exist.

There is a recommendation report to authors of application every new list member what is added, so they can deploy it on every insance of application for all users.
