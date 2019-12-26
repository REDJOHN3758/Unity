using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class ColliderScript : MonoBehaviour
{
    Material m_Material;
    public GameObject nextLevel;
    public static int score = 0;
    public static int label = 1;
    //AudioSource audioData;
    public static bool IsCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        //audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        IsCollision = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "coin")
        {
            IsCollision = true;
            collision.gameObject.SetActive(false);
            score += 1;
            //Debug.Log("Score "+score);
            //audioData.Play(0);
            //Debug.Log("started");
            if(score > 4)
            {
                nextLevel.SetActive(true);
            }
        }
        if (collision.gameObject.tag == "nextLevel")
        {
            IsCollision = true;
            collision.gameObject.SetActive(false);
            label += 1;
            m_Material.color = Color.red;
        }
    }
}
