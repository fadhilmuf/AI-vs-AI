using UnityEngine;
using TMPro;

public class ObjectCounter : MonoBehaviour
{
    public int papercount, rockcount, scissorscount;
    public TextMeshProUGUI rocktext, papertext, scissorstext;

    void Update()
    {
        PaperCounter();
        RockCounter();
        ScissorsCounter();
    }

    void PaperCounter()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Paper");
        papercount = objectsWithTag.Length;
        papertext.text = papercount.ToString();
    }
    void RockCounter()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Rock");
        rockcount = objectsWithTag.Length;
        rocktext.text = rockcount.ToString();
    }
    void ScissorsCounter()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Scissor");
        scissorscount = objectsWithTag.Length;
        scissorstext.text = scissorscount.ToString();
    }
}
