using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigasiUtama : MonoBehaviour
{
    public AudioSource BGM_Gameplay;

    public AudioSource BGM_MainMenu;

    public AudioSource SFX_GameOver;

    public Score score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        // if (scene.name == "GameOver")
        // {
        //     StartCoroutine(delaySuara());           
        // }
    }

    public void Credit()
    {
        BGM_MainMenu.Stop();
        // _SFXTombolKlik.Play();
        SceneManager.LoadScene("Credit");
    }
    public void MainMenu()
    {
        BGM_MainMenu.Stop();
        // _SFXTombolKlik.Play();
        SceneManager.LoadScene("MainMenu");
        // skor.SimpanSkorTertinggi();
    }
    public void Exit()
    {
        // skor.SimpanSkorTertinggi();
        StartCoroutine(DelayExit());
    }
    public void GamePlay()
    {
        StartCoroutine(DelayPlay());
        // skor.SimpanSkorTertinggi();
        SceneManager.LoadScene("GamePlay");
       
    }

    public IEnumerator delaySuara()
    {
        // _SFXEndGame.Play();
        yield return new WaitForSeconds(2f);
        BGM_MainMenu.Play();
    }

    public IEnumerator DelayExit()
    {
        BGM_MainMenu.Stop();
        // _SFXExit.Play();
        yield return new WaitForSeconds(0.1f);
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public IEnumerator DelayPlay()
    {
        BGM_MainMenu.Stop();
        // _SFXStartGame.Play();
        yield return new WaitForSeconds(1f);
    }

}
