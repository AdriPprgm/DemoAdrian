using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument menu;

    private Button Abutton;

    private Button Bbutton;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        Abutton = root.Q<Button>("Abutton");
        Bbutton = root.Q<Button>("Bbutton");

        //Callbacks
        Abutton.RegisterCallback<ClickEvent, String>(IniciarJuego, "Game");
        Bbutton.RegisterCallback<ClickEvent, String>(IniciarJuego, "Mapa");
    }

    private void IniciarJuego(ClickEvent evt, String escena){
        SceneManager.LoadScene(escena);
    }

    // private void StartLevelA(ClickEvent evt)
    // {
    //     SceneManager.LoadScene("Game");
    // }

    // private void StartLevelB(ClickEvent evt)
    // {
    //     SceneManager.LoadScene("Mapa");
    // }
}
