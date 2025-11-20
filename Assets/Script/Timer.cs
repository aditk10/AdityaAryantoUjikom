using System.Collections;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerTimer : MonoBehaviour
{
    public TMP_Text TeksWaktuMundur;
    

    public float WaktuMundur = 20;

    void Start()
    {
       StartCoroutine(TimerMundur());
    }
    IEnumerator TimerMundur()
    {
        while(true)
        {
            if (WaktuMundur > 0)
            {
                WaktuMundur--;
                TeksWaktuMundur.text = WaktuMundur.ToString();
            } else
            {
                SceneManager.LoadScene("GameOver");
            }
            yield return new WaitForSeconds(1);
        }
    }
}
