using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody2D rigidbody2;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        StartCoroutine(WaitToPlay());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Jump();
        }
    }

    public void Jump()
    {
        rigidbody2.velocity = Vector2.up * jumpForce;
    }

    private IEnumerator WaitToPlay()
    {
        rigidbody2.mass = 0;
        yield return new WaitForSeconds(2);
        rigidbody2.mass = 1;
        yield return null;
    }
}
