using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class CambiarEscena : MonoBehaviour
{
    [SerializeField]
    int numEscena;

    public void CambiaEscena(int numEscena)
    {
        SceneManager.LoadScene(numEscena);
    }

    public void OnPointerClick()
    {
        CambiaEscena(numEscena);
    }

    
}