using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD_2_classes
{
    public class Person
    {
        // Declaramos la variable Name pública
        public string Name;

        // Declaramos la variable _pointsOfLife privada, solo es accesible desde la propia clase Person
        private int _pointsOfLife;

        // Declaramos la variable PointsOfLife para hacerla de lectura y ver los puntos de vida de Person
        public int PointOfLife
        {
            get
            {
                return _pointsOfLife;
            }
        }

        // Declaramos un constructor, y le pasamos por parámetro el nombre y los puntos de vida iniciales
        public Person(string name, int pointsOfLife)
        {
            this.Name = name;
            this._pointsOfLife = pointsOfLife;
        }

        // Declaramos el método público SayHello para que el objeto diga su nombre y sus puntos de vida
        public void SayHello()
        {
            // Mostramos su nombre y los puntos de vida
            Console.WriteLine($"Hi!, my name is {this.Name} and I have {this._pointsOfLife} points of life.");
        }

        // Declaramos el método público Attack para que pueda atacar a otra Person, y establecemos los puntos de ataque
        public void Attack(Person attackedPerson, int attackPoints)
        {
            // Mostramos el ataque a `personAttacked`
            Console.WriteLine($"{this.Name} attack to {attackedPerson.Name} with {attackPoints} attack points");

            // Restamos los puntos de vida (attackPoints) a personAttacked mediante el método TakeDamage
            attackedPerson.TakeDamage(attackPoints);
        }

        // Declaramos el método publico TakeDamage para que una Person pueda recibir daño
        public void TakeDamage(int pointsOfDamage)
        {
            // Restamos puntos de vida
            this._pointsOfLife -= pointsOfDamage;
        }
    }
}
