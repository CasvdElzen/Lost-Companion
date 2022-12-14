using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mouse : MonoBehaviour
{
    private int ButtonSwitch;
    private int PressedButton = 5;
    private GameObject PlayButton;
    private GameObject QuitButton;
    private GameObject Arrow;
        
    public Animator transition;
    public float wow;
    [SerializeField] private AudioSource MenuSwitch;
    [SerializeField] private AudioSource MenuSelect;

    private void Start()
    {
        PlayButton = GameObject.FindWithTag("PlayButton");
        QuitButton = GameObject.FindWithTag("QuitButton");
        Arrow = GameObject.FindWithTag("Selector");



        PlayButton.transform.localScale = PlayButton.transform.localScale + new Vector3(1f, 1f, 0f);
    }
    void Update()
    {

        

        if (ButtonSwitch == 0 && Input.GetKey(KeyCode.Space))
        {
            MenuSelect.Play();
            Debug.Log("Play");
            PlayButton.transform.localScale = PlayButton.transform.localScale + new Vector3(1f, 1f, 0f);
            ButtonSwitch = PressedButton;
            StartCoroutine(LoadLevel());
        }
        else if (ButtonSwitch == 1 && Input.GetKey(KeyCode.Space))
        {
            MenuSelect.Play();
            Debug.Log("Quit");
            QuitButton.transform.localScale = QuitButton.transform.localScale + new Vector3(1f, 1f, 0f);
            ButtonSwitch = PressedButton;
            StartCoroutine(LoadQuit());
        }

        
        if (ButtonSwitch == 0 && Input.GetKey(KeyCode.S))
        {
            MenuSwitch.Play();
            Debug.Log("Down");
            ButtonSwitch = 1;
            Arrow.transform.position = Arrow.transform.position + new Vector3(0f, -2.88f, 0f);
            QuitButton.transform.localScale = QuitButton.transform.localScale + new Vector3(1f, 1f, 0f);

            PlayButton.transform.localScale = PlayButton.transform.localScale + new Vector3(-1f, -1f, 0f);
        }
        else if (ButtonSwitch == 1 && Input.GetKey(KeyCode.W))
        {
            MenuSwitch.Play();
            Debug.Log("Up");
            ButtonSwitch = 0;
            Arrow.transform.position = Arrow.transform.position + new Vector3(0f, 2.88f, 0f);
            PlayButton.transform.localScale = PlayButton.transform.localScale + new Vector3(1f, 1f, 0f);

            QuitButton.transform.localScale = QuitButton.transform.localScale + new Vector3(-1f, -1f, 0f);

        }


        IEnumerator LoadLevel()
        {
            transition.SetTrigger("Start");

            yield return new WaitForSeconds(wow);

            SceneManager.LoadScene("Demo");
        }


        IEnumerator LoadQuit()
        {
            transition.SetTrigger("Start");

            yield return new WaitForSeconds(wow);

            Application.Quit();
        }



    }


}
