namespace BinärBaum
{
    internal class Binaerbaum<Typ>
    {
        public Knoten<Typ> Wurzel { get; set; }
        public Knoten<Typ> LinkenTeilbaum { get; set; }
        public Knoten<Typ> RechtenTeilbaum { get; set; }

        public Binaerbaum()
        {
            Wurzel = null;
            LinkenTeilbaum = null;
            RechtenTeilbaum = null;
        }

        public Binaerbaum(Typ pElement)
        {
            Wurzel = new Knoten<Typ>(pElement);
            LinkenTeilbaum = null;
            RechtenTeilbaum = null;
        }

        public bool IstLeer()
        {
            return (Wurzel == null);
        }

        public void AusgebenDatenInorder()
        {
            if (Wurzel != null)
            {
                Wurzel.AusgebenDatenInorder();
            }
        }

        public void AusgebenDatenPreorder()
        {
            if (Wurzel != null)
            {
                Wurzel.AusgebenDatenPreorder();
            }
        }
        public void AusgebenDatenPosorder()
        {
            if (Wurzel != null)
            {
                Wurzel.AusgebenDatenPosorder();
            }
        }
    }
}