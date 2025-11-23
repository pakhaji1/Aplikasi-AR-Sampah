using UnityEngine;
using UnityEngine.SceneManagement;

public class Sampah : MonoBehaviour
{
    public void Kembali()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SampahOrganik()
    {
        SceneManager.LoadScene("SampahOrganik");
    }
    public void SampahAnorganik()
    {
        SceneManager.LoadScene("SampahAnorganik");
    }
}
