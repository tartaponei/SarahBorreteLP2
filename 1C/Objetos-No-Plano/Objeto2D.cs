using System;


    public class Objeto2D
    {
        public int x, y;

        public void AndarParaADireita()
        {
            x += 1;
        }
        public string Coordenadas()
        {
            return String.Format("{0}, {1}", x, y);
        }
    }
