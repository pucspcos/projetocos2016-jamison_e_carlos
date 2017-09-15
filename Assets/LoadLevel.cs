using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadLevel : MonoBehaviour {

    public void MudarDeNivel(string Nivel)
    {
        SceneManager.LoadScene(Nivel);
    }
}
