using UnityEngine;
using UnityEngine.SceneManagement;

namespace BaseGame.LevelMenu
{
    public class LevelMenu : MonoBehaviour
    {
        [SerializeField]
        private GameObject _windowLevelMenu;
        [SerializeField]
        private Object[] scenes;

        private void Start()
        {
            ChangeMenuState(false);    
        }

        public void LoadLevel(int index)
        {
            SceneManager.LoadScene(scenes[index].name);
        }

        public void ChangeMenuState(bool state)
        {
            _windowLevelMenu.SetActive(state);
        }
    }
}

