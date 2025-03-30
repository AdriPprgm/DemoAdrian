using UnityEngine;
using UnityEngine.UI;

public class healthui : MonoBehaviour
{
    public Slider HPui;
    public playerhealth playerhp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setmaxhp(){
         HPui.value = HPui.maxValue;
    }

    public void Sethp(float lives){
         HPui.value = lives * 1f /playerhp.max_lives;
    }
}
