using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// Classe que contém a função OnClick(), que é chamada ao clicarmos no botão
public class Salir : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // A função OnClick() troca de cena
    // Lembrem que adicionamos as cenas que nosso jogo conterá em File->Build Settings
    public void ClickExit()

    {
        Application.Quit();
    }

}
