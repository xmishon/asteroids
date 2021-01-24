using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        public void Start()
        {
            EnemyPool enemyPool = new EnemyPool(5);

            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);

            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new Health(100.0f, 100.0f));


        }
    }
}
