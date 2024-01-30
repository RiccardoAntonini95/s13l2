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
            Console.WriteLine($"Nome inserito: {persona1.GetNome(readName)}");
            Console.WriteLine($"Cognome inserito: {persona1.GetCognome(readSurname)}");
            Console.WriteLine($"Età inserita: {persona1.GetEta(readAge)}");
            Console.WriteLine(persona1.GetDettagli(readName, readSurname, readAge));


        }

        public class Persona(string _nome, string _cognome, byte _eta)

        //Properties
        {
            public string Nome
            {
                get
                {
                    return _nome;
                }
                set
                {
                    _nome = value;
                }
            }

            public string Cognome
            {
                get
                {
                    return _cognome;
                }
                set
                {
                    _cognome = value;
                }
            }
            public byte Eta
            {
                get
                {
                    return _eta;
                }
                set { _eta = value; }
            }
            //Methods
            public string GetNome(string _nome)
            {
                if(_nome.Length == 0)
                {
                    return "Non hai inserito un nome";
                }
                else
                {
                return _nome.ToUpper();
                }
            }

            public string GetCognome(string _cognome)
            {
                if(_cognome.Length == 0)
                {
                    return "Non hai inserito un cognome";
                }
                else
                {
                return _cognome.ToUpper();
                }
            }

            public byte GetEta(byte _eta)
            {
                return _eta;
            }

            public string GetDettagli(string nome, string cognome, byte eta)
            {
                return $"Nome:{GetNome(nome)} Cognome:{GetCognome(cognome)} Età:{GetEta(eta)}";
            }


        }

    }
}

