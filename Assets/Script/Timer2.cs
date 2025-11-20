using System.Collections;
// using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Waktu;

    public int MaximumWaktu;
    public TMP_Text TextTimer;
    public bool WaktuBerjalan = true;

    // public KeyCode StartCoroutineKey;
    // public KeyCode StoptCoroutineKey;

    public Coroutine HitungTimerCoroutine;

    //reference ke progress
    public Image ProgressFill;

    void Start()
    {
        // Waktu = Waktu + 1;
        // TextTimer.text = Waktu.ToString();
        StartCoroutine(HitungTimer());
    }
    // public void Update()
    // {
    //     if (Input.GetKeyDown(StartCoroutineKey))
    //     {
    //         if (HitungTimerCoroutine == null)
    //         {
    //             HitungTimerCoroutine = StartCoroutine(HitungTimer());
    //         }
    //     }
    //     if (Input.GetKeyDown(StoptCoroutineKey))
    //     {
    //         if (HitungTimerCoroutine != null)
    //         {
    //             StopCoroutine(HitungTimerCoroutine);
    //             HitungTimerCoroutine = null;
    //         }
    //     }
    // }
    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true && Waktu < MaximumWaktu)
        {
            Waktu = Waktu + 1;
            TextTimer.text = Waktu.ToString();
            ProgressFill.fillAmount = Waktu / MaximumWaktu;
            yield return new WaitForSeconds(1);
        }
    }
}
