using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    [SerializeField] private string scenePlay;
    [SerializeField] private string menuScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(scenePlay);
    }

}
