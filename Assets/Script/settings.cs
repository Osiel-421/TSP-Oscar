//using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class settings : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<GameObject> ListaInstrucciones;
    public int currentIndex = 0;
    public List<string> mensajesInstrucciones;
    public TextMeshProUGUI textMeshProUGUI;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        //Actualizar visibilidad de paneles
        UpdateVisibility();
    }

    void Update()
    {

    }

    private void UpdateVisibility()
    {
        for (int i = 0; i < ListaInstrucciones.Count; i++)
        {
            ListaInstrucciones[i].SetActive(i == currentIndex);
        }
        // Update is called once per frame

    }
    //Metodo para cambiar entre paneles

    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CycleObjects()
    {
        currentIndex = (currentIndex+1) % ListaInstrucciones.Count;
        UpdateVisibility();
    }

    private void UpdateText()
    {
        if (mensajesInstrucciones.Count >0)
        {

        }
    }


    public void ExitGame()
    {
        Debug.Log("Va a salir");
        Application.Quit();
    }
}
