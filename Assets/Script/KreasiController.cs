using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KreasiController : MonoBehaviour
{
[Header("Audio Settings")]
    public AudioClip audioClip;
    private AudioSource audioSource;
    private bool isPlaying = false;

    [Header("UI Settings")]
    public Image soundButtonImage;
    public Sprite speakerOnSprite;
    public Sprite speakerOffSprite;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.loop = true;

        // Tampilkan icon speaker off saat awal
        if (soundButtonImage != null && speakerOffSprite != null)
            soundButtonImage.sprite = speakerOffSprite;
    }

    public void Kembali()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();

        SceneManager.LoadScene("ScanAR");
    }

    public void ButtonSuara()
    {
        if (isPlaying)
        {
            audioSource.Pause();
            if (soundButtonImage != null && speakerOffSprite != null)
                soundButtonImage.sprite = speakerOffSprite;

            Debug.Log("Suara Dijeda");
        }
        else
        {
            audioSource.Play();
            if (soundButtonImage != null && speakerOnSprite != null)
                soundButtonImage.sprite = speakerOnSprite;

            Debug.Log("Suara Diputar");
        }

        isPlaying = !isPlaying;
    }
}
