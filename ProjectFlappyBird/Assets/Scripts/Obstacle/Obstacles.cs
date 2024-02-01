using UnityEngine;
using UnityEngine.Events;

public class Obstacles : MonoBehaviour
{
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("entered");
            uiManager.ScoreChanger();
        }
    }
}
