using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Babies : MonoBehaviour
{
    bool isbaby = false;
    Timer time;
    public bool IsBaby
    {
        get { return isbaby; }
        set { isbaby = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
         time = gameObject.AddComponent<Timer>();
         time.AddTimerFinishedEventListener(FinishedTimerListener);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            if (isbaby)
            {
                Destroy(gameObject);
            }
        }
    }
    public void InvokeTimer()
    {
        isbaby = true;
        time.Duration = 4f;
        time.Run();
    }
    void FinishedTimerListener()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
}
