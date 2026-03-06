using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class buttonScripts: MonoBehaviour, IPointerDownHandler
{

    public bool First = false;
    public bool Second = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.transform.position);

        if (this.tag == "Play")
        {
            Debug.Log("Played");
            SceneManager.LoadScene("LevelSelect");
        }
        else if (this.tag == "Level1")
        {
            SceneManager.LoadScene("currentLevel");
        }
        else if (this.tag == "Level2" && First)
        {
            SceneManager.LoadScene("Level 2");
        }
        else if (this.tag == "Level3" && Second)
        {
            SceneManager.LoadScene("Level 3");
        }
    }
}
