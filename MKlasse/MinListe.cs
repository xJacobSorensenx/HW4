namespace HW4.MKlasse
{
    public class MinListe
    {
        ListeElement Head;

        public MinListe()
        {
            Head= new ListeElement();
        }

        public void AddData(MinData NewData){
            ListeElement ND = new ListeElement();

            ND.data=NewData;
            Head=ND;
            System.Console.WriteLine("Data added");
        }

        public void PrintListe(){
            System.Console.WriteLine("Listen indeholder : ");
            System.Console.WriteLine($"{Head.data.Id} - {Head.data.Navn}");
        }

    }
}