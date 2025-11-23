using UnityEngine;
using UnityEngine.SceneManagement;

public class ScanAR : MonoBehaviour
{
    private GameObject activeModel = null;
    public GameObject iconScan;
    public GameObject buttonKreasi;
    public GameObject rotateLeft;
    public GameObject rotateRight;
    public GameObject zoomIn;
    public GameObject zoomOut;

    [Header("Zoom Settings")]
    // Faktor relatif terhadap skala asli model:
    // minScale = 0.3f → model bisa diperkecil hingga 30% dari ukuran aslinya
    // maxScale = 3.0f → model bisa diperbesar hingga 300% dari ukuran aslinya
    public float minScale = 0.3f;  // Faktor minimum (relatif)
    public float maxScale = 3.0f;  // Faktor maksimum (relatif)

    // Untuk menyimpan skala awal model
    private Vector3 originalScale = Vector3.one;

    void Start()
    {
        // Reset semua state setiap kali scene dimuat
        ResetARState();
        Debug.Log("🔷 Start() dipanggil. activeModel = " + (activeModel ? activeModel.name : "null"));
    }

    public void ResetARState()
    {
        Debug.Log("🔄 ResetARState dipanggil. activeModel = " + (activeModel ? activeModel.name : "null"));

        if (activeModel != null)
        {

            // Nonaktifkan model aktif saat ini
            if (activeModel != null)
            {
                activeModel.SetActive(false);
                activeModel = null;
            }
        }

        // Nonaktifkan SEMUA model dengan tag "Model3D" (untuk keamanan)
        GameObject[] allModels = GameObject.FindGameObjectsWithTag("Model3D");
        foreach (GameObject model in allModels)
        {
            if (model != null)
                model.SetActive(false);
        }

        UpdateController();
    }

    public void ShowModel(GameObject model)
    {
        if (activeModel != null)
        {
            activeModel.SetActive(false);
        }
        model.SetActive(true);
        activeModel = model;

        // Simpan skala awal model (sebelum diubah)
        originalScale = model.transform.localScale;

        Debug.Log($"Model aktif:  + {model.name} | Skala awal: {originalScale}");
        UpdateController();
    }

    private void UpdateController()
    {
        bool hasActiveModel = activeModel != null;

        if (iconScan != null)
            iconScan.SetActive(!hasActiveModel);

        if (buttonKreasi != null)
            buttonKreasi.SetActive(hasActiveModel);

        if (rotateLeft != null)
            rotateLeft.SetActive(hasActiveModel);
        if (rotateRight != null)
            rotateRight.SetActive(hasActiveModel);
        if (zoomIn != null)
            zoomIn.SetActive(hasActiveModel);
        if (zoomOut != null)
            zoomOut.SetActive(hasActiveModel);
    }

    public void RotateLeft()
    {
        if (activeModel != null)
        {
            // Mendapatkan posisi pusat model
            Vector3 centerPoint = activeModel.transform.position;
            // Memutar di sekitar pusat tersebut dengan sumbu Vector3.up
            activeModel.transform.RotateAround(centerPoint, Vector3.up, -15f);
        }
    }

    public void RotateRight()
    {
        if (activeModel != null)
        {
            // Mendapatkan posisi pusat model
            Vector3 centerPoint = activeModel.transform.position;
            // Memutar di sekitar pusat tersebut dengan sumbu Vector3.up
            activeModel.transform.RotateAround(centerPoint, Vector3.up, 15f);
        }
    }

    public void ZoomIn()
    {
        if (activeModel == null) return;

        Vector3 currentScale = activeModel.transform.localScale;
        Vector3 newScale = currentScale * 1.1f;

        // Hitung batas berdasarkan skala asli
        float maxBound = originalScale.x * maxScale;

        if (newScale.x <= maxBound)
        {
            activeModel.transform.localScale = newScale;
        }
    }

    // Fungsi untuk memperkecil (Zoom Out)
    public void ZoomOut()
    {
        if (activeModel == null) return;

        Vector3 currentScale = activeModel.transform.localScale;
        Vector3 newScale = currentScale * 0.9f;

        float minBound = originalScale.x * minScale;

        if (newScale.x >= minBound)
        {
            activeModel.transform.localScale = newScale;
        }
    }

    public void Kreasi()
    {
        if (activeModel == null) return;

        string modelName = activeModel.name;

        // Simpan nama model ke PlayerPrefs
        PlayerPrefs.SetString("LastActiveModel", modelName);
        PlayerPrefs.Save();

        // Tentukan scene kreasi berdasarkan nama model
        string sceneToLoad = GetSceneNameFromModel(modelName);
        SceneManager.LoadScene(sceneToLoad);
    }

    private string GetSceneNameFromModel(string modelName)
    {
        if (modelName.Contains("KulitJeruk") || modelName.Contains("Jeruk"))
            return "KreasiKulit";
        if (modelName.Contains("StikEskrim") || modelName.Contains("Stik"))
            return "KreasiStik";
        if (modelName.Contains("BotolPlastik") || modelName.Contains("Botol"))
            return "KreasiBotol";
        if (modelName.Contains("CangkangTelur") || modelName.Contains("Telur"))
            return "KreasiCangkang";
        if (modelName.Contains("Daun"))
            return "KreasiDaun";
        if (modelName.Contains("Kardus"))
            return "KreasiKardus";
        if (modelName.Contains("Sedotan"))
            return "KreasiSedotan";
        if (modelName.Contains("Bola"))
            return "KreasiBola";

        Debug.LogWarning("Model tidak dikenali: " + modelName);
        return "KreasiDefault";
    }
    public void Kembali()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
