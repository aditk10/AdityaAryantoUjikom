using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text TextScore;
    public TMP_Text TextHiScore;
    public int scorePlay;
    public int HighScore;

    void Start()
    {
        updateTextScore();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TambahScore();
            updateTextScore();
            // jump.lompat();
            // MunculDariAtas();
        }
    }

    public void TambahScore()
    {
        scorePlay++;
    }

    public void updateTextScore()
    {
        TextScore.text  = "Score = " + scorePlay.ToString();
    }

    
    // void MunculDariAtas()
    // {
    //     //ambil posisi dimana kursor mouse berada
    //     Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //     //ambil posisi titik paling atas layar
    //     Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
    //     //gunakan posisi kursor pada sumbu x dan posisi titik paling atas layar untuk vector3 bernama tempatJauh
    //     Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);

    //     //memunculkan object dengan nama bola jatuh di posisi tempatjatuh dan dengan rotasi Quarternion.identity
    //     Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity);
    // }
}
