using UnityEngine;
using UnityEngine.SceneManagement;

namespace BaseGame.LevelMenu
{
    public class LevelMenu : MonoBehaviour
    {
        [SerializeField]
        private GameObject _windowLevelMenu;
        [SerializeField]
        private string[] _scenes;

        private void Start()
        {
            ChangeMenuState(false);    
        }

        public void LoadLevel(int index)
        {
            SceneManager.LoadScene(_scenes[index]);
        }

        public void ChangeMenuState(bool state)
        {
            _windowLevelMenu.SetActive(state);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

