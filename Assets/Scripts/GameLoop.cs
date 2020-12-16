using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    class GameLoop : MonoBehaviour
    {
        private List<IExecute> _fixedUpdateExecute;
        private List<IExecute> _updateExecute;
        private InputController _inputController;

        public void Start()
        {
            _updateExecute = new List<IExecute>();
            Player player = FindObjectOfType<Player>();
            _inputController = new InputController(player, Camera.main);
        }

        public void Update()
        {
            _inputController.Execute();
        }

        public void FixedUpdate()
        {

        }
    }
}
