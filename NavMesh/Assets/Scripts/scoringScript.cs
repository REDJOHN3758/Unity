using UnityEngine;
using UnityEngine.UI;

public class scoringScript : MonoBehaviour
{
    public Text sc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sc.text = "Score : " + ColliderScript.score.ToString() + "\nLevel "+ ColliderScript.label.ToString();

    }
}
