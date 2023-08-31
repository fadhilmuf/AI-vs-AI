using UnityEngine;
using TMPro;

public class Timers : MonoBehaviour
{
    private float timer;
    private float tm = 0.01f;
    public TextMeshProUGUI timetext, wintext;
    public ObjectCounter counter;
    public ObjectSpawner spawner;

    void Update()
    {
        Debug.Log(spawner.max);
        
        timer += tm;
        timer = (float)System.MathF.Round(timer,2);

        timetext.text = "timer: " + timer + "s";

        if(counter.rockcount == spawner.max)
        {
            Debug.Log("Rock Wins!");
            tm = 0;
            wintext.text = "Rock Wins!";
            wintext.color = Color.red;
            wintext.enabled = true;
        }
        else if(counter.papercount == spawner.max)
        {
            Debug.Log("Paper Wins!");
            tm = 0;
            wintext.text = "Paper Wins!";
            wintext.color = Color.white;
            wintext.enabled = true;
        }
        else if(counter.scissorscount == spawner.max)
        {
            Debug.Log("Scissor Wins!");
            tm = 0;
            wintext.text = "Scissors Wins!";
            wintext.color = Color.yellow;
            wintext.enabled = true;
        }
    }
}
