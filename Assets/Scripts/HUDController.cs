using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    public static HUDController instance;
    private VisualElement vida_1;
    private VisualElement vida_2;
    private VisualElement vida_3;
    private VisualElement gameover;
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        vida_1 = root.Q<VisualElement>("Life1");
        vida_2 = root.Q<VisualElement>("Life2");
        vida_3 = root.Q<VisualElement>("Life3");
        gameover = root.Q<VisualElement>("GameOver");
        gameover.style.display = DisplayStyle.None;
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene("Mapa");
            Time.timeScale = 1;
        }
    }
    public void UpdateLives()
    {
        int vidas = LivesPlayer.instance.vidas;
        if ( vidas == 0 ) {
            vida_1.style.display = DisplayStyle.None;
        } else if ( vidas == 1 ) {
            vida_2.style.display = DisplayStyle.None;
        } else if ( vidas == 2 ) {
            vida_3.style.display = DisplayStyle.None;
        }
    }

    public void GameOver(){
        gameover.style.display = DisplayStyle.Flex;
        Time.timeScale = 0;
    }
}
