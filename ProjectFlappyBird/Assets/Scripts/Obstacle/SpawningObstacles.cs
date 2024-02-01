using System.Collections;
using UnityEngine;

public class SpawningObstacles : MonoBehaviour
{

    [SerializeField] private GameObject obstacle;
    [SerializeField] private GameObject spawner;
    [SerializeField] private float timeBetweenSpawn;
    [SerializeField] private float firstSpawn;
    private bool asSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FirstSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (asSpawn)
        {
            StartCoroutine(Spawning());
        }
    }


    private IEnumerator Spawning()
    {
        asSpawn = false;
        yield return new WaitForSecondsRealtime(timeBetweenSpawn);
        var parentPosition = spawner.gameObject.transform.position;
        var min = parentPosition.y - 2f;
        var max = parentPosition.y + 2f;
        GameObject cloneObstacle = Instantiate(obstacle, new Vector3(parentPosition.x, Random.Range(min, max), parentPosition.z), gameObject.transform.rotation);
        Rigidbody2D rb2D = cloneObstacle.GetComponent<Rigidbody2D>();
        rb2D.velocity = transform.TransformDirection(Vector3.left);
        asSpawn = true;
    }


    private IEnumerator FirstSpawn()
    {
        yield return new WaitForSecondsRealtime(firstSpawn);
        asSpawn = true;
    }


}
