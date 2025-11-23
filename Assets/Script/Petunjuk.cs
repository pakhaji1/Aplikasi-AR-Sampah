using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Petunjuk : MonoBehaviour
{
    public void Kembali()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
