using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCharacter : MonoBehaviour
{
    [Header("Scene number")]
    public string Character;
    public void SwitchToChar()
    {
SceneManager.LoadScene("Character");
    }

}
