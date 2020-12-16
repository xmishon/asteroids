using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        private Camera _camera;
        private Ship _ship;

        public float Speed
        { get; set; }

        public void Start()
        {
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }

        public void AddAcceleration()
        {
            _ship.AddAcceleration();
        }

        public void RemoveAcceleration()
        {
            _ship.RemoveAcceleration();
        }

        public void Fire()
        {
            var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }

        public void Rotation(Vector3 direction)
        {
            _ship.Rotation(direction);
        }

        public void Move(float moveForward, float moveRight, float deltaTime)
        {
            _ship.Move(moveForward, moveRight, deltaTime);
        }
    }
}
