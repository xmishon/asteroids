using UnityEngine;

namespace Asteroids
{
    class InputController : IExecute
    {
        [SerializeField] private Player _player;
        [SerializeField] private Camera _camera;

        public InputController(Player player, Camera camera)
        {
            _player = player;
            _camera = camera;
        }

        public void Execute()
        {
            _player.Rotation(Input.mousePosition - _camera.WorldToScreenPoint(_player.transform.position));
            _player.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _player.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _player.RemoveAcceleration();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _player.Fire();
            }
        }
    }
}
