using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene("Mapa");
            Time.timeScale = 1;
        }
    }

    public void Setup(){
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }
}
