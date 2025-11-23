using UnityEngine;
using UnityEngine.SceneManagement;

public class SampahKembaliController : MonoBehaviour
{
    [Header("Target Scene Name")]
    public string targetSceneName;

    public void Kembali()
    {
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            Debug.Log($"{gameObject.name} kembali ke scene: {targetSceneName}");
            SceneManager.LoadScene(targetSceneName);
        }
        else
        {
            Debug.LogWarning("targetSceneName belum di atur di Inspector!");
        }
    }
}
