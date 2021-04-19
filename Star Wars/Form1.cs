using Star_Wars.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Wars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Person currentPerson = new Person();
        private async void ChangePerson(int id) 
        {
            currentPerson = await JSONHelper.GetPerson(id);

            labelName.Text = "Name: " + currentPerson.name;
            label1.Text = "Height: " + currentPerson.height;
            label2.Text = "Mass: " + currentPerson.mass;
            label3.Text = "Hair Color: " + currentPerson.hair_color;
            label4.Text = "Skin Color: " + currentPerson.skin_color;
            label5.Text = "Eye Color: " + currentPerson.eye_color;
            label6.Text = "Birth Year: " + currentPerson.birth_year;
            label7.Text = "Gender: " + currentPerson.gender;

            string homeworldText = currentPerson.homeworld;
            homeworldText = homeworldText.Substring(homeworldText.Length - 2, 1);
            Planet homeworld = new Planet();
            homeworld = await JSONHelper.GetPlanet(Int32.Parse(homeworldText));
            label8.Text = "Homeworld: " + homeworld.name;

            string shipsString = "";
            foreach (var link in currentPerson.starships)
            {
                if (link == currentPerson.starships[currentPerson.starships.Count-1])
                {
                    shipsString = shipsString + await JSONHelper.GetShipName(link) ;
                }
                else
                {
                    shipsString = shipsString + await JSONHelper.GetShipName(link) + ", ";
                }
            }
            label9.Text = "Ships associated with this person: " + shipsString;
        }

        Planet currentPlanet = new Planet();
        private async void ChangePlanet(int id)
        {
            currentPlanet = await JSONHelper.GetPlanet(id);

            labelName.Text = "Name: " + currentPlanet.name;
            label1.Text = "Rotation Period: " + currentPlanet.rotation_period;
            label2.Text = "Orbital Period: " + currentPlanet.orbital_period;
            label3.Text = "Diameter: " + currentPlanet.diameter;
            label4.Text = "Climate: " + currentPlanet.climate;
            label5.Text = "Gravity: " + currentPlanet.gravity;
            label6.Text = "Terrain: " + currentPlanet.terrain;
            label7.Text = "Surface Water: " + currentPlanet.surface_water;
            label8.Text = "Population: " + currentPlanet.population;
            label9.Text = "";  
        }

        AllSpecies speciesObject = new AllSpecies();
        private async void GetSpecies()
        {
            speciesObject = await JSONHelper.GetSpecies();
        }

        Species currentSpecies = new Species();
        private async void ChangeSpecies(int id)
        {
            speciesObject = await JSONHelper.GetSpecies();

            currentSpecies = new Species();

            currentSpecies = speciesObject.results[id];

            labelName.Text = "Name: " + currentSpecies.name;
            label1.Text = "Classification: " + currentSpecies.classification;
            label2.Text = "Designation: " + currentSpecies.designation;
            label3.Text = "Average Height: " + currentSpecies.average_height;
            label4.Text = "Skin Colors: " + currentSpecies.skin_colors;
            label5.Text = "Hair Colors: " + currentSpecies.hair_colors;
            label6.Text = "Eye Colors: " + currentSpecies.eye_colors;
            label7.Text = "Average Lifespan: " + currentSpecies.average_lifespan;
            label8.Text = "Homeworld: " + currentSpecies.homeworld;
            label9.Text = "Language: " + currentSpecies.language;
        }

        private void PopulateListBox()
        {
            foreach (Species s in speciesObject.results)
            {
                listSpecies.Items.Add(s.name + ", ");
            }
        }

        private void ClearTags()
        {
            labelName.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ClearTags();
            GetSpecies();
            speciesObject = await JSONHelper.GetSpecies();
            PopulateListBox();
        }

        private void PlanetGenerate_Click(object sender, EventArgs e)
        {
            ClearTags();
            int input = Int32.Parse(PlanetInput.Text);
            ChangePlanet(input);
        }

        private void PersonGenerate_Click(object sender, EventArgs e)
        {
            ClearTags();
            int input = Int32.Parse(PersonInput.Text);
            ChangePerson(input);
        }

        private void SpeciesGenerate_Click(object sender, EventArgs e)
        {
            ClearTags();
            int input = Int32.Parse(SpeciesInput.Text);
            ChangeSpecies(input);
        }
    }
}
