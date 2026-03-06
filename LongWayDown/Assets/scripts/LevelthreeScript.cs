using UnityEngine;

public class LevelthreeScript : MonoBehaviour
{

    public GameObject blankSquare;
    public GameObject Playerchar;

    Vector3 CharPOS;

    public float CharX;
    public float CharY;
    public float CharZ;

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
                if (i-5 >= j)
                {
                    heightmap[i, j] = Random.Range(0.1f, 0.5f) + 1;
                    Instantiate(blankSquare, new Vector3(i, heightmap[i, j], j), Quaternion.identity);
                }
                else
                {
                    heightmap[i, j] = Random.Range(0.1f, 0.5f);
                    Instantiate(blankSquare, new Vector3(i, heightmap[i, j], j), Quaternion.identity);
                }

            }
        }

        CharPOS.x = CharX;
        CharPOS.y = CharY + heightmap[(int)CharPOS.x, (int)CharPOS.y];
        CharPOS.z = CharZ;
        Playerchar.transform.position = CharPOS;
    }

    // Update is called once per frame
    void Update()
    {

    }
}