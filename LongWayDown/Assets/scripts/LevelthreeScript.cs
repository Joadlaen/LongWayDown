using UnityEngine;

public class LevelthreeScript : MonoBehaviour
{

    public GameObject blankSquare;
    public GameObject Playerchar;
    public GameObject Key;
    public GameObject Goal;

    Vector3 CharPOS;
    Vector3 KeyPOS;
    Vector3 GoalPOS;


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

        KeyPOS.x = 20;
        KeyPOS.y = 1 + heightmap[(int)KeyPOS.x, (int)KeyPOS.z];
        KeyPOS.z = 1;
        Key.transform.position = KeyPOS;

        GoalPOS.x = 20;
        GoalPOS.y = 1 + heightmap[(int)GoalPOS.x, (int)GoalPOS.z];
        GoalPOS.z = 30;
        Goal.transform.position = GoalPOS;
    }

    // Update is called once per frame
    void Update()
    {

    }
}