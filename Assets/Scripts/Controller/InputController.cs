using UnityEngine;

namespace Asteroids
{
    class InputController
    {
        [SerializeField] private Player _player;
        [SerializeField] private Camera _camera;

        private void Update()
        {
            _player.SetDirection(Input.mousePosition - _camera.WorldToScreenPoint(_player.transform.position));
            _player.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
}
