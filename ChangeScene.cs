using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //refrences to the timer script & scene names
    private TimerScript _timerScript;
    private HealthScript2 _healthScript2;
    private string sceneName;

    void Awake()
    {
        //Get the other script
        _timerScript = GetComponent<TimerScript>();
        _healthScript2 = GetComponent<HealthScript2>();

        //This gets the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Once the time is 0, the lose scene loads
    void Update()
    {

        if ((gameObject.name == "GameController") && (_timerScript.timeRemaining == 0))
        {
            SceneManager.LoadScene("Lose");
        }
        if ((gameObject.name == "Player 2") && (_healthScript2.cur_health <=0))
        {
            SceneManager.LoadScene("Lose");
        }
     }


        //This loads level 1
        public void GotoLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    //This loads the lose scene
    void OnCollisionEnter(Collision collision)
    {

        // only load lose scene if the there is a collision with the FallSensor object
        if (collision.gameObject.name == "FallSensor")

        {
            Debug.Log("Collision Recognized");
            SceneManager.LoadScene("Lose");
        }
        if ((collision.gameObject.name == "Enemy 2") || (collision.gameObject.name == "Enemy 3") || (collision.gameObject.name == "Enemy 4") || (collision.gameObject.name == "Enemies"))

        {
            Debug.Log("Collision Recognized");
            SceneManager.LoadScene("Lose");
        }
        if ((collision.gameObject.name == "WinSensor") && (sceneName == "Level1"))

        {
            SceneManager.LoadScene("MidWin");
        }

        if ((collision.gameObject.name == "WinSensor") && (sceneName == "Level2"))
        {
            SceneManager.LoadScene("3Win");
        }
        if ((collision.gameObject.name == "WinSensor") && (sceneName == "Level3"))
        {
            SceneManager.LoadScene("4Win");
        }
        if ((collision.gameObject.name == "WinSensor") && (sceneName == "Level4"))
        {
            SceneManager.LoadScene("Win");
        }
    }
//This loads the win scene
//void OnCoEnter(Collider WinSensor)

//{
//    if (collision.gameObject.name == "WinSensor")
//    {
//        if(sceneName == "Level1")
//         SceneManager.LoadScene("MidWin");
//        if (sceneName == "Level2")
//            SceneManager.LoadScene("3Win");
//        if (sceneName == "Level3")
//            SceneManager.LoadScene("4Win");
//        if (sceneName == "Level4")
//            SceneManager.LoadScene("Win");
//    }
//}


 public void GotoLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void GotoIntro()
    {
        SceneManager.LoadScene("Intro");
    }
    public void GotoInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void GotoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Goto3Win()
    {
        SceneManager.LoadScene("3Win");
    }
    public void Goto4Win ()
    {
        SceneManager.LoadScene("4Win");
    }
    public void GotoLevel4()
    {
        SceneManager.LoadScene("Level4");
    }
}
