using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        public void Start()
        {
            Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));

            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new Health(100.0f, 100.0f));


        }
    }
}
