using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergedLibraryNeo
{
    internal class Names //You get a name, you get a name, everybody gets a name!!!
    {

        public String RandomName()
        {
            Random random = new Random();
            if(random.Next(2) == 1)
            {
                return MaleName();
            } else
            {
                return FemaleName();
            }
        }
        public String MaleName()
        {
            Random rand = new Random();
            String name = "Error";
            ArrayList names = new ArrayList();
            names.Add("Carl");
            names.Add("Lenny");
            names.Add("Andrew");
            names.Add("Jack");
            names.Add("Zeck");
            names.Add("Tony");
            names.Add("Dave");
            names.Add("Kevin");
            names.Add("Stuart");
            names.Add("Bob"); //the whole gang is here
            names.Add("Michael");
            names.Add("Liam");
            names.Add("Noah");
            names.Add("William");
            names.Add("James");
            names.Add("Thomas");
            names.Add("Ethan");
            names.Add("Daniel");
            names.Add("Jacob");
            names.Add("Oven");
            names.Add("Samuel");

            return (string)names[rand.Next(names.Count)];
        }
        public String FemaleName()
        {

            Random rand = new Random();
            String name = "Error";
            ArrayList names = new ArrayList();
            names.Add("Kate");
            names.Add("Jenny");
            names.Add("Anne");
            names.Add("Abigail");
            names.Add("Tina");
            names.Add("Dominika");
            names.Add("Charlie");
            names.Add("Noelle");
            names.Add("Natasha");
            names.Add("Janette");
            names.Add("Olivia");
            names.Add("Emma");
            names.Add("Charlotte");
            names.Add("Sophia");
            names.Add("Amy");
            names.Add("Evelyn");
            names.Add("Harper");
            names.Add("Camila");
            names.Add("Luna");
            names.Add("Emily");


            return (string)names[rand.Next(names.Count)];
        }
        public String Surname()
        {
            Random rand = new Random();
            String name = "Error";
            ArrayList names = new ArrayList();
            names.Add("Black");
            names.Add("Butcher");
            names.Add("Thompson");
            names.Add("Stain");
            names.Add("Smith");
            names.Add("Johnson");
            names.Add("Williams");
            names.Add("Brown");
            names.Add("Jones");
            names.Add("Garcia");
            names.Add("Miller");
            names.Add("Davis");
            names.Add("Rodriguez");
            names.Add("Wilson");
            names.Add("Anderson");
            names.Add("Thomas");
            names.Add("Moore");
            names.Add("Jackson");
            names.Add("Harris");
            names.Add("Green");
            names.Add("Adams");
            names.Add("Nelson");
            names.Add("Baker");
            names.Add("Hall");
            names.Add("Rivera");
            names.Add("Campbell");
            names.Add("Mitchell");
            names.Add("Carter");
            names.Add("Roberts");

            return (string)names[rand.Next(names.Count)];
        }

        public String TownNames()
        { //Names of cities were taken from here: https://www.britannica.com/topic/list-of-cities-and-towns-in-the-United-States-2023068
            Random rand = new Random();
            String name = "Error";
            ArrayList names = new ArrayList();
            names.Add("Alexander City"); //Alabama
            names.Add("Andalusia");
            names.Add("Anniston");
            names.Add("Athens");
            names.Add("Atmore");
            names.Add("Auburn");
            names.Add("Bessemer");
            names.Add("Birmingham");
            names.Add("Chickasaw");
            names.Add("Clanton");
            names.Add("Cullman");
            names.Add("Decatur");
            names.Add("Demopolis");
            names.Add("Dothan");
            names.Add("Enterprise");
            names.Add("Eufaula");
            names.Add("Florence");
            names.Add("Fort Payne");
            names.Add("Gadsden");
            names.Add("Greenville");
            names.Add("Guntersville");
            names.Add("Huntsville");
            names.Add("Jasper");
            names.Add("Marion");
            names.Add("Mobile");
            names.Add("Montgomery");
            names.Add("Opelika");
            names.Add("Ozark");
            names.Add("Phoenix City");
            names.Add("Prichard");
            names.Add("Scottsboro");
            names.Add("Selma");
            names.Add("Sheffield");
            names.Add("Sylacauga");
            names.Add("Talladega");
            names.Add("Troy");
            names.Add("Tuscaloosa");
            names.Add("Tuscumbia");
            names.Add("Tuskegee");
            names.Add("Anchorage"); //Alaska
            names.Add("Cordova");
            names.Add("Fairbanks");
            names.Add("Haines");
            names.Add("Homer");
            names.Add("Juneau");
            names.Add("Ketchikan");
            names.Add("Kodiak");
            names.Add("Kotzebue");
            names.Add("Nome");
            names.Add("Palmer");
            names.Add("Seward");
            names.Add("Sitka");
            names.Add("Skagway");
            names.Add("Valdez");
            names.Add("Ajo"); //Arizona
            names.Add("Avondale");
            names.Add("Bisbee");
            names.Add("Casa Grande");
            names.Add("Chandler");
            names.Add("Clifton");
            names.Add("Douglas");
            names.Add("Flagstaff");
            names.Add("Florence");
            names.Add("Gila Bend");
            names.Add("Glendale");
            names.Add("Globe");
            names.Add("Kingman");
            names.Add("Lake Havasu");
            names.Add("Mesa");
            names.Add("Nogales");
            names.Add("Oraibi");
            names.Add("Phoenix");
            names.Add("Prescott");
            names.Add("Scottsdale");
            names.Add("Sierra Vista");
            names.Add("Tempe");
            names.Add("Tombstone");
            names.Add("Tuscon");
            names.Add("Walpi");
            names.Add("Window Rock");
            names.Add("Winslow");
            names.Add("Yuma");
            names.Add("Arkadelphia"); //Arkansas
            names.Add("Arkansas Post");
            names.Add("Batesville");
            names.Add("Benton");
            names.Add("Blytheville");
            names.Add("Camden");
            names.Add("Conway");
            names.Add("Crossett");
            names.Add("El Dorado");
            names.Add("Fayetteville");
            names.Add("Forrest");
            names.Add("Fort Smith");
            names.Add("Harrison");
            names.Add("Helena");
            names.Add("Hope");
            names.Add("Hot Springs");
            names.Add("Jacksonville");
            names.Add("Jonesboro");
            names.Add("Little Rock");
            names.Add("Magnolia");
            names.Add("Morrilton");
            names.Add("Newport");
            names.Add("North Little Rock");
            names.Add("Osceola");
            names.Add("Pine Bluff");
            names.Add("Rogers");
            names.Add("Searcy");
            names.Add("Stuttgart");
            names.Add("Van Buren");
            names.Add("West Memphis");


            return (string)names[rand.Next(names.Count)];
        }
    }
}
