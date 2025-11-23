using UnityEngine;
using UnityEngine.SceneManagement;

public class SampahController : MonoBehaviour
{
    [Header("Target Scene Name")]
    public string targetScene;

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(targetScene))
        {
            Debug.Log($"{gameObject.name} membuka scene: {targetScene}");
            SceneManager.LoadScene(targetScene);
        }
        else
        {
            Debug.LogWarning("targetScene belum diatur di Inspector!");
        }
    }
}
