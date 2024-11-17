namespace BinärBaum
{
    public class Knoten<Typ>
    {
        public Typ Inhalt { get; set; }
        public Knoten<Typ> Links { get; set; }
        public Knoten<Typ> Rechts { get; set; }

        public Knoten(Typ inhalt)
        {
            Inhalt = inhalt;
            Links = null;
            Rechts = null;
        }

        public void AusgebenDatenInorder()
        {
            if (Links != null)
            {
                Links.AusgebenDatenInorder();
            }
            System.Console.WriteLine(Inhalt);
            if (Rechts != null)
            {
                Rechts.AusgebenDatenInorder();
            }
        }

        /// <summary>
        /// Gibt die Daten des Knotens und seiner Nachfolger im Preorder-Traversal aus.
        /// </summary>
        public void AusgebenDatenPreorder()
        {
            System.Console.WriteLine(Inhalt);
            if (Links != null)
            {
                Links.AusgebenDatenPreorder();
            }
            if (Rechts != null)
            {
                Rechts.AusgebenDatenPreorder();
            }
        }

        public void AusgebenDatenPosorder()
        {
            if (Links != null)
            {
                Links.AusgebenDatenPosorder();
            }
            if (Rechts != null)
            {
                Rechts.AusgebenDatenPosorder();
            }
            System.Console.WriteLine(Inhalt);
        }   
    }
}