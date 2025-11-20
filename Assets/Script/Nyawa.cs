using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Nyawa : MonoBehaviour
{
    public TMP_Text TextNyawa;
    public TMP_Text TextHiScore;
    public int Nyawa2 = 10;
    // public int HighScore;

    public Image ProgressFill;

    void Start()
    {
        updateTextScore();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            KurangNyawa();
            updateTextScore();
            // jump.lompat();
            // MunculDariAtas();
        }
    }

    public void KurangNyawa()
    {
        Nyawa2--;
    }

    public void updateTextScore()
    {
        TextNyawa.text  = "Nyawa = " + Nyawa2.ToString();
        ProgressFill.fillAmount = Nyawa2 - 1;
    }
}
