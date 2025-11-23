using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Scan()
    {
        SceneManager.LoadScene("ScanAR");
    }
    public void Sampah()
    {
        SceneManager.LoadScene("Sampah");
    }
    public void Petunjuk()
    {
        SceneManager.LoadScene("Petunjuk");
    }
    public void Keluar()
    {
        SceneManager.LoadScene("Keluar");
    }
}
