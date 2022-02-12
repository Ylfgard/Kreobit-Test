using UnityEngine;
using CustomAttributes;

namespace LevelScreen
{
    public class ShapeSpawner : MonoBehaviour
    {
        [SerializeField]
        private Transform _transform;
        [SerializeField]
        private GameObject _circle;
        [SerializeField]
        private GameObject _cube;
        [SerializeField]
        private GameObject _triangle; 

        [EditorButton ("Spawn Circle")]
        public void SpawnCircle()
        {
            Instantiate(_circle, _transform.position, Quaternion.identity, _transform);
        }

        [EditorButton ("Spawn Cube")]
        public void SpawnCube()
        {
            Instantiate(_cube, _transform.position, Quaternion.identity, _transform);
        }

        [EditorButton ("Spawn Triangle")]
        public void SpawnTriangle()
        {
            Instantiate(_triangle, _transform.position, Quaternion.identity, _transform);
        }
    }
}