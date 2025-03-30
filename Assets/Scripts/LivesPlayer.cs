using UnityEngine;

public class LivesPlayer : MonoBehaviour
{
    public int vidas = 3;
    public static LivesPlayer instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
