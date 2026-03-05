using UnityEngine;

public class GridSet : MonoBehaviour
{

    public GameObject blankSquare;
    public int gridHorSize = 20;
    public int gridVertSize = 30;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < gridHorSize; i++)
        {
            for (int j = 0; j < gridVertSize; j++)
            {
                Instantiate(blankSquare, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
