using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyScript: MonoBehaviour
{
    public GameObject Key;
    public GameObject Goal;
    public GameObject Player;

    public buttonScripts buttonSet;

    public bool KeyFlag = false;

    public void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == "Key")
        {
            KeyFlag = true;
            Destroy(this.gameObject);
        }

        else if (this.gameObject.tag == "Goal")
        {
            if (KeyFlag)
            {
                KeyFlag = false;
                if (SceneManager.GetActiveScene().name == "CurrentLevel")
                {
                    buttonSet.First = true;
                }
                else if (SceneManager.GetActiveScene().name == "Level2")
                {
                    buttonSet.Second = true;
                }
                SceneManager.LoadScene("LevelSelect");
            }
        }
    }
}
