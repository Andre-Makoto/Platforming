using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Referência ao texto de vitória.
    public GameObject winText;
    public GameObject loseText;
    public GameObject restartButton;

    // Função chamada quando o jogador VENCE
    public void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }
    
    // Função chamada quando o jogador PERDE
    public void Lose()
    {
        loseText.SetActive(true);
        restartButton.SetActive(true);

    }

    public void RestartGame()
    {
        // SceneManager.GetActiveScene().name pega o nome da cena atual
        // LoadScene() recarrega essa cena do zero, resetando tudo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
