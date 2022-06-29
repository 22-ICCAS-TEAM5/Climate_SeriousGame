using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;


    void Start()
    {

    }


    void Update()
    {
        LimitTime += 0.08f * Time.deltaTime;
        text_Timer.text = System.Math.Round(LimitTime, 2) + "กษ";
    }
}