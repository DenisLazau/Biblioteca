﻿namespace Biblioteca
{
    public class Carte : AbstractElem
    {
        public Carte(Guid id, string titlu, string autor)
            : base(id, titlu)
        {
            Autor = autor;
        }

        public string Autor
        { get; set; }

        public bool Compara(Guid id)
        {
            throw new NotImplementedException();
        }

        public override void Accept(IAbstractElemVisitor viz)
        {
            //obiectul vizitator primit ca parametru "viziteaza" obiectul curent
            viz.Visit(this);
        }
    }
}
