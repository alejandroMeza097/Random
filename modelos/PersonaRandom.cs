﻿namespace RandomAPI.modelos
{
    public class PersonaRandom
    {
        public string NombreHombreHRandom()
        {
            Random rnd = new Random();



            //lista de nombres de hombres...
            string[] InputHombres =
{
                "Juan",
"Carlos",
"Luis",
"Andrés",
"Javier",
"Alejandro",
"Diego",
"Manuel",
"Fernando",
"Miguel",
"José",
"Daniel",
"Rafael",
"Antonio",
"Mario",
"Pedro",
"Ricardo",
"Gabriel",
"Ignacio",
"Sergio",
"Francisco",
"David",
"Guillermo",
"Hugo",
"Eduardo",
"Emilio",
"Roberto",
"Oscar",
"Raúl",
"Ernesto",
"Arturo",
"Marco",
"Rodrigo",
"Alberto",
"Nicolás",
"Iván",
"Adrián",
"Julio",
"Joaquín",
"Alejandro",
"Orlando",
"Samuel",
"Ramón",
"Héctor",
"Jorge",
"Benjamín",
"Gonzalo",
"Leonardo",
"Mauricio",
"Mateo",
"Martín",
"Vicente",
"Tomás",
"Agustín",
"Felipe",
"Baltasar",
"Rodrigo",
"Lorenzo",
"Lucas",
"Cristian",
"Rubén",
"Ezequiel",
"Aníbal",
"Germán",
"Ariel",
"Patricio",
"Valentín",
"Javier",
"Adrián",
"Marcelo",
"Ángel",
"Juan Pablo",
"Enrique",
"Santiago",
"Facundo",
"Federico",
"Horacio",
"Guido",
"Leonardo",
"Alexis",
"Osvaldo",
"Raúl",
"Diego",
"Daniel",
"Guillermo",
"Alfredo",
"Hugo",
"Eduardo",
"José Luis",
"Alejandro",
"Antonio",
"Mario",
"Miguel Ángel",
"Rodrigo",
"Juan Carlos",
"Jorge Luis",
"Pedro",
"Alberto",
"Ricardo",
"Carlos Alberto",
"Luis Alberto",
"Omar",
"Roberto Carlos",
"Emilio",
"Rafael",
"Jesús",
"Andrés",
"Marco Antonio",
"Francisco Javier",
"David",
"Ignacio",
"José Antonio",
"Leonardo",
"Armando",
"Ernesto",
"Nicolás",
"Sergio",
"Israel",
"Esteban",
"Javier",
"Federico",
"Ricardo",
"Eduardo",
"Gabriel",
"Marcelo",
"Matías",
"Luis",
"Daniel",
"Juan José",
"Manuel",
"Antonio",
"Mario",
"Miguel",
"Alejandro",
"Guillermo",
"Carlos",
"Roberto",
"Rafael",
"Pedro",
"José Luis",
"Jorge",
"Fernando",
"Cristian",
"Gonzalo",
"Leonardo",
"Marcelo",
"Ángel",
"Adrián",
"Ricardo",
"Ignacio",
"Sebastián",
"Joaquín",
"Mauricio",
"Vicente",
"Eduardo",
"Ariel",
"Alejandro",
"Matías",
"Manuel",
"Daniel",
"Carlos",
"Juan José",
"Roberto",
"Luis",
"Mario",
"Miguel",
"Pedro",
"Guillermo",
"Antonio",
"Gabriel",
"Javier",
"Jorge",
"Ricardo",
"Diego",
"Emilio",
"Francisco",
"Ignacio",
"Rafael",
"Ernesto",
"Fernando",
"Adrián",
"Leonardo",
"Ángel",
"Cristian",
"Héctor",
"Matías",
"Nicolás",
"Samuel",
"Sebastián",
"Alejandro",
"Vicente",
"Mauricio",
"Ariel",
"David",
"Patricio",
"Eduardo",
"Fernando",
"Roberto",
"Manuel",
"Javier",
"Juan",
"Carlos",
"Miguel",
"Andrés",
"Gabriel",
"Alejandro",
"Diego",
"Luis",
"José",
"Ricardo",
"Antonio",
"Daniel",
"Mario",
"Rafael",
"Pedro",
"Emilio",
"Ignacio",
"Francisco",
"Javier",
"Ernesto",
"Guillermo",
"Hugo",
"Eduardo",
"Roberto",
"Oscar",
"Raúl",
"Arturo",
"Marco",
"Rodrigo",
"Alberto",
"Nicolás",
"Iván",
"Adrián",
"Julio",
"Joaquín",
"Alejandro",
"Orlando",
"Samuel",
"Ramón",
"Héctor",
"Jorge",
"Benjamín",
"Gonzalo",
"Leonardo",
"Mauricio",
"Mateo",
"Martín",
"Vicente"


            };
            List<string> ListaHombres = new List<string>();
            ListaHombres.AddRange(InputHombres);


            //Generacion de lista de hombres aleatoria...
            string nombreHombreRandom = "";
            int index = rnd.Next(0, ListaHombres.Count);
            nombreHombreRandom = ListaHombres[index];
            return nombreHombreRandom;
        }

        public string NombreMujerRandom()
        {
            Random rnd = new Random();

            //lista de nombres de mujeres...
            string[] InputMujeres = {
"María",
"Sofía",
"Isabella",
"Valentina",
"Emma",
"Mia",
"Camila",
"Valeria",
"Lucía",
"Daniela",
"Martina",
"Sara",
"Ana",
"Carolina",
"Paula",
"Gabriela",
"Fernanda",
"Emily",
"Renata",
"Andrea",
"Nicole",
"Antonia",
"Julieta",
"Ximena",
"Victoria",
"Amanda",
"Zoe",
"Regina",
"Catalina",
"Natalia",
"Isabel",
"Alma",
"Alba",
"Clara",
"Laura",
"Elena",
"Luisa",
"Olivia",
"Marina",
"Rosa",
"Eva",
"Beatriz",
"Cecilia",
"Mónica",
"Alexa",
"Isidora",
"Patricia",
"Adriana",
"Giselle",
"Vanessa",
"Alejandra",
"Miranda",
"María José",
"Jazmín",
"Valery",
"Raquel",
"Ana María",
"Luna",
"Gabriella",
"Ivanna",
"Samantha",
"Martha",
"Elizabeth",
"Luz",
"Teresa",
"Paola",
"Xiomara",
"Luna",
"Ana Sofía",
"Angélica",
"Rafaela",
"Montserrat",
"Paulina",
"Mariana",
"Karla",
"Verónica",
"Valerie",
"Sofía",
"María Fernanda",
"Jacqueline",
"Lorena",
"Rocio",
"Julianna",
"Ángela",
"Patricia",
"Roberta",
"Adela",
"Lilian",
"Carla",
"Estefanía",
"Maya",
"Gloria",
"Renata",
"María Victoria",
"Elsa",
"Regina",
"Luciana",
"Isabel",
"María Elena",
"Guadalupe",
"Jazmín",
"Rita",
"Roxana",
"Ruth",
"María Isabel",
"Carmen",
"Rocío",
"Sofía",
"Fabiana",
"Diana",
"Luz María",
"Emilia",
"Romina",
"María Luisa",
"Miriam",
"Ana Laura",
"Cristina",
"Sara",
"Nadia",
"Anabella",
"María Paula",
"Irene",
"Leticia",
"Victoria",
"Natalia",
"Amelia",
"Liliana",
"Esperanza",
"Rosalía",
"María Alejandra",
"Alicia",
"Fátima",
"Isabella",
"Rosario",
"Silvia",
"Camila",
"Milagros",
"Renata",
"Valentina",
"Rosa",
"Valeria",
"Luna",
"Catalina",
"Antonia",
"Martina",
"Victoria",
"Sofía",
"Fernanda",
"Elena",
"Daniela",
"Isabella",
"Valentina",
"Emma",
"Mia",
"Camila",
"Valeria",
"Lucía",
"Daniela",
"Martina",
"Sara",
"Ana",
"Carolina",
"Paula",
"Gabriela",
"Fernanda",
"Emily",
"Renata",
"Andrea",
"Nicole",
"Antonia",
"Julieta",
"Ximena",
"Victoria",
"Amanda",
"Zoe",
"Regina",
"Catalina",
"Natalia",
"Isabel",
"Alma",
"Alba",
"Clara",
"Laura",
"Elena",
"Luisa",
"Olivia",
"Marina",
"Rosa",
"Eva",
"Beatriz",
"Cecilia",
"Mónica",
"Alexa",
"Isidora",
"Patricia",
"Adriana",
"Giselle",
"Vanessa",
"Alejandra",
"Miranda",
"María José",
"Jazmín",
"Valery",
"Raquel",
"Ana María",
"Luna",
"Gabriella",
"Ivanna",
"Samantha",
"Martha",
"Elizabeth",
"Luz",
"Teresa",
"Paola",
"Xiomara",
"Luna",
"Ana Sofía",
"Angélica",
"Rafaela",
"Montserrat",
"Paulina",
"Mariana",
"Karla",
"Verónica",
"Valerie",
"Sofía",
"María Fernanda",
"Jacqueline",
"Lorena",
"Rocio",
"Julianna",
"Ángela",
"Patricia",
"Roberta",
"Adela",
"Lilian",
"Carla",
"Estefanía",
"Maya",
"Gloria",
"Renata",
"María Victoria",
"Elsa",
"Regina",
"Luciana",
"Isabel",
"María Elena",
"Guadalupe",
"Jazmín",
"Rita",
"Roxana",
"Ruth",
"María Isabel",
"Carmen",
"Rocío",
"Sofía",
"Fabiana",
"Diana",
"Luz María",
"Emilia",
"Romina",
"María Luisa",
"Miriam",
"Ana Laura",
"Cristina",
"Sara",
"Nadia",
"Anabella",
"María Paula",
"Irene",
"Leticia",
"Victoria",
"Natalia",
"Amelia",
"Liliana",
"Esperanza",
"Rosalía",
"María Alejandra",
"Alicia",
"Fátima",
"Isabella",
"Rosario",
"Silvia",
"Camila",
"Milagros",
"Renata",
"Valentina",
"Rosa",
"Valeria",
"Luna",
"Catalina",
"Antonia",
"Martina",
"Victoria",
"Sofía",
"Fernanda",
"Elena",
"Daniela",
"Isabella",
"Valentina",
"Emma",
"Mia",
"Camila",
"Valeria",
"Lucía",
"Daniela",
"Martina",
"Sara",
"Ana",
"Carolina",
"Paula",
"Gabriela",
"Fernanda",
"Emily",
"Renata",
"Andrea",
"Nicole",
"Antonia",
"Julieta",
"Ximena",
"Victoria",
"Amanda",
"Zoe",
"Regina",
"Catalina",
"Natalia",
"Isabel",
"Alma",
"Alba",
"Clara",
"Laura",
"Elena",
"Luisa",
"Olivia",
"Marina",
"Rosa",
"Eva",
"Beatriz",
"Cecilia",
"Mónica",
"Alexa",
"Isidora",
"Patricia",
"Adriana",
"Giselle",
"Vanessa",
"Alejandra",
"Miranda",
"María José",
"Jazmín",
"Valery",
"Raquel",
"Ana María",
"Luna",
"Gabriella",
"Ivanna",
"Samantha",
"Martha",
"Elizabeth",
"Luz",
"Teresa",
"Paola",
"Xiomara",
"Luna",
"Ana Sofía",
"Angélica",
"Rafaela",
"Montserrat",
"Paulina",
"Mariana"
            };

            List<string> ListaMujeres = new List<string>();
            ListaMujeres.AddRange(InputMujeres);


            //Generacion de lista de hombres aleatoria...
            string nombreMujerRandom = "";
            int index = rnd.Next(0, ListaMujeres.Count);
            nombreMujerRandom = ListaMujeres[index];
            return nombreMujerRandom;

        }

        public string ApellidoRandom()
        {
            Random rnd = new Random();
            //lista de apellidos...
            string[] InputApellidos =
            {
                "Rodríguez",
"García",
"López",
"Martínez",
"Hernández",
"González",
"Pérez",
"Sánchez",
"Ramírez",
"Torres",
"Flores",
"Rivera",
"Díaz",
"Cruz",
"Ortiz",
"Reyes",
"Morales",
"Castillo",
"Álvarez",
"Romero",
"Vargas",
"Fernández",
"Ruiz",
"Chávez",
"Medina",
"Rojas",
"Silva",
"Mendoza",
"Ramos",
"Rangel",
"Cortés",
"Montes",
"Delgado",
"Jiménez",
"Núñez",
"Cabrera",
"Ríos",
"Acosta",
"Soto",
"Escobar",
"Zamora",
"Méndez",
"Vega",
"Aguilar",
"Navarro",
"Miranda",
"Campos",
"Valdez",
"Guerrero",
"Velasco",
"Barrera",
"Salazar",
"Cervantes",
"Ibarra",
"Andrade",
"Aguirre",
"Castañeda",
"Herrera",
"Arroyo",
"Ayala",
"Padilla",
"Orozco",
"Peña",
"Solís",
"Villarreal",
"Mora",
"Rueda",
"Pacheco",
"Galindo",
"Cisneros",
"Juárez",
"Cortez",
"Ochoa",
"Cárdenas",
"Arias",
"Bustamante",
"Estrada",
"Ponce",
"Peralta",
"Avila",
"Avalos",
"Carrasco",
"Munguía",
"Bautista",
"Lara",
"Carvajal",
"Cordero",
"Guzmán",
"Luna",
"Aragón",
"Villanueva",
"Córdova",
"Zúñiga",
"Salinas",
"Ortega",
"Cuevas",
"Mejía",
"Del Toro",
"Tovar",
"Paredes",
"Jaimes",
"Esquivel",
"Samaniego",
"Espinosa",
"Sepúlveda",
"Quintero",
"Camey",
"Robles",
"Rico",
"Téllez",
"Chavarría",
"Segura",
"Barajas",
"Salcedo",
"Gallardo",
"Gómez",
"Benítez",
"Valencia",
"Cazares",
"Roldán",
"Verdugo",
"Palafox",
"Salas",
"Contreras",
"Gama",
"Escobedo",
"Villatoro",
"Valenzuela",
"Holguín",
"Laguna",
"Esparza",
"Miramontes",
"Olvera",
"Olivares",
"Cisneroz",
"Valadez",
"Franco",
"Lomelí",
"Olivo",
"Parra",
"Berumen",
"Romo",
"Cadena",
"Dávila",
"Fierro",
"Samaniego",
"Lugo",
"Enríquez",
"Mora",
"Lucero",
"Becerra",
"Saldivar",
"León",
"Galarza",
"Barrientos",
"Lucio",
"Toro",
"Becerril",
"Cuenca",
"Sarabia",
"Dorantes",
"Meza",
"Chávez",
"Amador",
"Quintana",
"Salmerón",
"Esqueda",
"Quintero",
"Medellín",
"Mojica",
"Grijalva",
"Cervantez",
"Ruelas",
"Barrios",
"Navarrete",
"Raya",
"Zavala",
"Carmona",
"Olivas",
"Loya",
"Balderas",
"Tapia",
"Macías",
"Uribe",
"Montiel",
"Zepeda",
"Gracia",
"Báez",
"Yáñez",
"Campa",
"Gallardo",
"Ceballos",
"Trejo",
"Mungía",
"Jurado",
"Jimeno",
"Davalos",
"Cornejo",
"Salguero",
"Chacón",
"Villaseñor",
"Lechuga",
"Pantoja",
"Casares",
"Escalante",
"Valladares",
"Aguiar",
"Lizárraga",
"Huesca",
"Bárcenas",
"Huerta",
"Salazar",
"Amaya",
"Raya",
"Zavala",
"Ibarra",
"Martínez",
"Negrete"



            };
            List<string> ListaApellidos = new List<string>();
            ListaApellidos.AddRange(InputApellidos);



            //Generacion de lista de apellidos aleatoria...
            string apellidoRandom = "";
            int index = rnd.Next(0, ListaApellidos.Count);
            apellidoRandom = ListaApellidos[index];
            return apellidoRandom;

        }
    }
}
