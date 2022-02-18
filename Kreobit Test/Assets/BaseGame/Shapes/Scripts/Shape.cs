using UnityEngine;

namespace BaseGame.Shapes
{
    public abstract class Shape : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _spriteRenderer;

        public void SelectShape()
        {
            _spriteRenderer.color *= 1.3f;
        }

        public void UnselectShape()
        {
            _spriteRenderer.color /= 1.3f;
        }
    }
}