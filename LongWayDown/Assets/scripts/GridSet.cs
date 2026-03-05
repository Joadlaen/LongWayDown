using UnityEngine;

public class GridSet : MonoBehaviour
{

    public GameObject BlankSquare;
    public GameObject PlayerChar;
    public GameObject EndKey;
    public GameObject EndGoal;

    Vector3 CharPOS;

    public int gridHorSize = 20;
    public int gridVertSize = 30;


    float[,] heightmap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float[,] heightmap = new float[gridHorSize, gridVertSize];
        for (int i = 0; i < gridHorSize; i++)
        {
            for (int j = 0; j < gridVertSize; j++)
            {
                heightmap[i, j] = Random.Range(0.1f,0.5f);
                Instantiate(BlankSquare, new Vector3(i, heightmap[i,j], j), Quaternion.identity);

            }
        }

        CharPOS.x = 10;
        CharPOS.y = 1.5f + heightmap[(int)CharPOS.x,(int)CharPOS.y];
        CharPOS.z = 15;
        PlayerChar.transform.position = CharPOS;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
