using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{

    public Image img;
    public AnimationCurve curve;

    void Start()
    {

        StartCoroutine(FadeIn());

    }

    public void FadeTo(string scene, float r, float g, float b)
    {

        StartCoroutine(FadeOut(scene,r,g,b));

    }
    IEnumerator FadeIn()
    {

        float t = 1f*1.5f;

        while (t>0)
        {

            t -= Time.deltaTime;

            float a = curve.Evaluate(t);

            img.color = new Color(1f,0f,0f,a);

            yield return 0;

        }

    }

    IEnumerator FadeOut(string scene,float r,float g,float b)
    {

        float t = 0f;

        while (t <1f)
        {

            t += Time.deltaTime;

            float a = curve.Evaluate(t);

            img.color = new Color(r, g, b, a);

            yield return 0;

        }

        SceneManager.LoadScene(scene);

    }
}
