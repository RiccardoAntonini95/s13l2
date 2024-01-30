using System.Runtime.CompilerServices;

namespace s13l2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i dati:");
            Console.Write("Nome: ");
            string readName = Console.ReadLine();
            Console.Write("Cognome: ");
            string readSurname = Console.ReadLine();
            Console.Write("Eta': ");
            byte readAge = byte.Parse(Console.ReadLine());
            Persona persona1 = new Persona(readName, readSurname, readAge);
            Console.WriteLine($"Nome inserito: {persona1.GetNome()}");
            Console.WriteLine($"Cognome inserito: {persona1.GetCognome()}");
            Console.WriteLine($"Età inserita: {persona1.GetEta()}");
            Console.WriteLine(persona1.GetDettagli());


        }

        public class Persona
        {
            //fields 
            private string name;
            private string surname;
            private byte age;

            //Properties

            public string Nome
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string Cognome
            {
                get
                {
                    return surname;
                }
                set
                {
                    surname = value;
                }
            }

            public byte Eta
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }

            //Methods
            public string GetNome()
            {
                if (Nome.Length == 0)
                {
                    return "Non hai inserito un nome";
                }
                else
                {
                    return Nome.ToUpper();
                }
            }

            public string GetCognome()
            {
                if (Cognome.Length == 0)
                {
                    return "Non hai inserito un cognome";
                }
                else
                {
                    return Cognome.ToUpper();
                }
            }

            public byte GetEta()
            {
                return Eta;
            }

            public string GetDettagli()
            {
                return $"Nome:{GetNome} Cognome:{GetCognome} Età:{GetEta}";
            }

            //Constructor
            public Persona(string nome, string cognome, byte eta)
            {
                name = nome;
                surname = cognome;
                age = eta;
            }


        }
    }
}

