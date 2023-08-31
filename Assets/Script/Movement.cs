using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(1,1,0).normalized;

        transform.Translate(movement*speed*Time.deltaTime);
    }
}
