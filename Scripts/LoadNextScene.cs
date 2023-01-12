using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadNextScene : MonoBehaviour
{
    public KeyCode _key;
    private Button _button;

    void Start()
    {
        _button = GameObject.FindGameObjectWithTag("Button").GetComponent<Button>();
        Debug.Log(_button);
    }

    void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            Debug.Log("Space");
            _button.onClick.Invoke();
        }
    }

    public void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
