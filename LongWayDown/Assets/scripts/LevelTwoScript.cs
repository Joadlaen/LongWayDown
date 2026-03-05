using UnityEngine;

public class LevelTwoScript : MonoBehaviour
{

    public GameObject blankSquare;
    public GameObject Playerchar;

    Vector3 CharPOS;

    public int gridHorSize = 20;
    public int gridVertSize = 30;


    float[,] heightmap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Playerchar.transform.position = CharPOS;
        float[,] heightmap = new float[gridHorSize, gridVertSize];
        for (int i = 0; i < gridHorSize; i++)
        {
            for (int j = 0; j < gridVertSize; j++)
            {
                if (i <= 10)
                {
                    heightmap[i, j] = Random.Range(0.1f, 0.5f);
                    Instantiate(blankSquare, new Vector3(i, 1 + heightmap[i, j], j), Quaternion.identity);
                }
                else
                {
                    heightmap[i, j] = Random.Range(0.1f, 0.5f);
                    Instantiate(blankSquare, new Vector3(i, heightmap[i, j], j), Quaternion.identity);
                }

            }
        }

        CharPOS.x = 10;
        CharPOS.y = 1.5f + heightmap[(int)CharPOS.x, (int)CharPOS.y];
        CharPOS.z = 15;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
