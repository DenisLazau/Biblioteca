using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FormatAfisare : IAbstractElemVisitor
    {
        public string Visit(AbstractElem elem)
        {
            switch (elem)
            {
                case Carte carte:
                    return Visit(carte);
                case Revista revista:
                    return Visit(revista);
                case ElemInSala elemInSala:
                    return Visit(elemInSala);
                case ElemCuTaxa elemCuTaxa:
                    return Visit(elemCuTaxa);
                default:
                    return "Element necunoscut";
            }
        }
        public string Visit(Carte carte)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Carte: ");
            sb.Append(carte.Titlu);
            sb.Append(" de ");
            sb.Append(carte.Autor);

            return sb.ToString();
        }
        public string Visit(Revista revista)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Revista: ");
            sb.Append(revista.Titlu);
            sb.Append(" numarul ");
            sb.Append(revista.Numar);

            return sb.ToString();
        }

        public string Visit(ElemInSala carte)
        {
            string descriereCarte = Visit(carte.Element);
            StringBuilder sb = new StringBuilder();
            sb.Append(descriereCarte);
            sb.Append(" in sala ");
            sb.Append(carte.Sala);

            return sb.ToString();
        }
        public string Visit(ElemCuTaxa revista)
        {
            string descriereRevista = Visit(revista.Element);
            StringBuilder sb = new StringBuilder();
            sb.Append(descriereRevista);
            sb.Append(" cu taxa ");
            sb.Append(revista.Taxa);

            return sb.ToString();
        }
    }
}
