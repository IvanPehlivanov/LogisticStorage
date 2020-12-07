using System.Windows;

namespace LogisticStorage
{
    class EinlagernFunktion : Einlagern
    {

        public EinlagernFunktion(string auswahl)
        {

            if (auswahl == Operator[0])
            {
                MessageBox.Show(Operator[0]);
            }
            else if (auswahl == Operator[1])
            {
                MessageBox.Show(Operator[1]);
            }
            else if (auswahl == Operator[2])
            {
                MessageBox.Show(Operator[2]);
            }
            else if (auswahl == Operator[3])
            {
                MessageBox.Show(Operator[3]);
            }

        }
    }
}