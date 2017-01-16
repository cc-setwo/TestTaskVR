using UnityEngine;
using System.Collections;

namespace Jifeng.DemoSoftVr
{
    // a simple on event listener.it receives slide button submit event.
    public class PlayButton : MonoBehaviour
    {
        public static string Room = "1";

        public void OnButtonConfirmed()
        {
            switch (gameObject.transform.parent.gameObject.name.ToLower())
            {
                case "front":
                {
                    if (Room == "2")
                    {
                        GameObject.FindGameObjectWithTag("Player").transform.position =
                            new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x + 50,
                                GameObject.FindGameObjectWithTag("Player").transform.position.y,
                                GameObject.FindGameObjectWithTag("Player").transform.position.z);
                        Room = "1";
                    }
                        if (Room == "3")
                        {
                            GameObject.FindGameObjectWithTag("Player").transform.position =
                                new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x - 50,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.y,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.z);
                            Room = "1";
                        }
                    }
                    break;
                case "right":
                {
                        if (Room == "1")
                        {
                            GameObject.FindGameObjectWithTag("Player").transform.position =
                                new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x + 50,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.y,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.z);
                            Room = "2";
                        }
                        if (Room == "3")
                        {
                            GameObject.FindGameObjectWithTag("Player").transform.position =
                                new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x + 100,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.y,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.z);
                            Room = "2";
                        }
                    }
                    break;
                case "left":
                {
                        if (Room == "1")
                        {
                            GameObject.FindGameObjectWithTag("Player").transform.position =
                                new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x - 50,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.y,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.z);
                            Room = "3";
                        }
                        if (Room == "2")
                        {
                            GameObject.FindGameObjectWithTag("Player").transform.position =
                                new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x + 100,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.y,
                                    GameObject.FindGameObjectWithTag("Player").transform.position.z);
                            Room = "3";
                        }
                    }
                    break;
                case "back":
                {
                    //Application.LoadLevel("JfExperienceDemo");
                }
                    break;
            }
        }
    }
}
