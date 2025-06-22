using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
