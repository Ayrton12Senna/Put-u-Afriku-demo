The road to Africa, respectively "Put u Afriku" in Croatian is a simple application which is developed as unofficial list of necessary items that every volunteer must pick up on a road.
Application is in demo stage. 

It is thought that the application is being used by volunteers and volunteer centers, respectively road organizers.
The application contain a 3 stage list box. The first listbox contains a list of items, the second list box contains a list of vendors who provide these items and the third list box shows who represent the backpack. 

We are created a library which contains a 3 class system. The class "Ruksak" has three constructors which is executed when we, for instance, have a new object type "Ruksak".
When we create a class in library, Dobavljac for vendor, Predmet for item and Ruksak for backpack, we can create as much as we need with the object of that type.

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
        
When the user clicks on another button, they pick up the backpack. That means the label shows what is he total cost of road and how much the organizer will pay for every individual volunteer.
With that information, the organizer can manage the activities before the road and organize enough food, tickets, clothes, and other items for people who go onto the road.

In that demo version, the additional feature is adding new items or vendor or what volunteers and volunteer centers are needed if a member of list does not exist.

There is a recommendation report to authors of application every new list member, what is added, so they can deploy it on every instance of the application for all users.
