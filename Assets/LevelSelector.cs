
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public SceneFader sceneFader;
    public float r;
    public float g;
    public float b;

    public void SelectLevel(string level)
    {
        sceneFader.FadeTo(level,r,g,b);

    }

}
