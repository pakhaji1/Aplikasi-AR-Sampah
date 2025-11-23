using UnityEngine;
using UnityEngine.SceneManagement;

public class Keluar : MonoBehaviour
{
    public void Ya()
    {
        Application.Quit();
    }
    public void Tidak()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
