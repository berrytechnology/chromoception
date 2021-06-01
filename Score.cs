
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        float start = player.position.z + 40;
        scoreText.text = start.ToString("0");
    }
}


