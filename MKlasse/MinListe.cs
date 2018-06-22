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
            ListeElement Current = new ListeElement();

            ND.data=NewData;

            if (Head.data==null)
            {
                Head=ND;              
            }else
            {
                Current=Head;

                while(Current.Next!=null){
                    Current=Current.Next;
                }

                Current.Next=ND;
            }            
            
            
            

            System.Console.WriteLine("Data added");
        }

        public void PrintListe(){
            System.Console.WriteLine("Listen indeholder : ");

            ListeElement Current = new ListeElement();

            Current=Head;

            while(Current!=null){
                System.Console.WriteLine($"{Current.data.Id} - {Current.data.Navn}");
                Current=Current.Next;
            }
            
        }

    }
}