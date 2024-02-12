using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    [SerializeField] private GameObject squareObject;
    private GameObject squareObjectExists;

    [SerializeField] private GameObject circleObject;
    private GameObject circleObjectExists;

    [SerializeField] private GameObject rectangleObject;
    private GameObject rectangleObjectExists;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (squareObjectExists == null)
            {
                squareObjectExists = Instantiate(squareObject);
            }
            else
            {
                Debug.Log("Square Already Exists");
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (circleObjectExists == null)
            {
                circleObjectExists = Instantiate(circleObject);
            }
            else
            {
                Debug.Log("Circle Already Exists");
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (rectangleObjectExists == null)
            {
                rectangleObjectExists = Instantiate(rectangleObject);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Destroy(rectangleObjectExists);
            }
            else
            {
                Debug.Log("Rectangle Already Exists");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            rectangleObjectExists.transform.position += new Vector3(0, 1, 0);
            circleObjectExists.transform.position += new Vector3(0, 1, 0);
            squareObjectExists.transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rectangleObjectExists.transform.position += new Vector3(0, -1, 0);
            circleObjectExists.transform.position += new Vector3(0, -1, 0);
            squareObjectExists.transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            rectangleObjectExists.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            circleObjectExists.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            squareObjectExists.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rectangleObjectExists.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
            circleObjectExists.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
            squareObjectExists.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            rectangleObjectExists.transform.Rotate(15f, 15f, 0f, Space.Self);
            circleObjectExists.transform.Rotate(15f, 15f, 0f, Space.Self);
            squareObjectExists.transform.Rotate(15f, 15f, 0f, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            rectangleObjectExists.transform.Rotate(-15f, -15f, 0f, Space.Self);
            circleObjectExists.transform.Rotate(-15f, -15f, 0f, Space.Self);
            squareObjectExists.transform.Rotate(-15f, -15f, 0f, Space.Self);
        }


    }
}

//----------------------------------------------------------------------------------------------------------------------------------
// if (rectangleObjectExists)
// {
//     Debug.Log("Rectangle Exists");
// }
// else
// {
//     if (Input.GetKeyDown(KeyCode.R))
//     {
//         Instantiate(rectangleObject);
//         rectangleObjectExists = true;
//     }
// }
// if (circleObjectExists)
// {
//     Debug.Log("Circle Exists");
// }
// else
// {
//     if (Input.GetKeyDown(KeyCode.C))
//     {
//         Instantiate(circleObject);
//         circleObjectExists = true;
//     }
// }
//--------------------------------------------------------------------------------------------------------------------------------
// if (GameObject.Find("Square(Clone)"))
// {
//     Debug.Log("Exists");
// }
// else
// {
//     if (Input.GetKeyDown("s"))
//     {
//         Instantiate(squareObject);
//     }
// }
// if (GameObject.Find("Circle(Clone)"))
// {
//     Debug.Log("Exists");
// }
// else
// {
//     if (Input.GetKeyDown("c"))
//     {
//         Instantiate(circleObject);
//     }
// }
// if (GameObject.Find("Rectangle(Clone)"))
// {
//     Debug.Log("Exists");
// }
// else
// {
//     if (Input.GetKeyDown("r"))
//     {
//         Instantiate(rectangleObject);
//     }
// }
//--------------------------------------------------------------------------------------------------------------------------------
// if (squareObject == null)
// {
//     Debug.Log("Square Object Already Spawned");
// }
// else
// {
//     if (Input.GetKeyDown("s"))
//     {
//         Instantiate(squareObject);
//     }
// }
// if (circleObject == null)
// {
//     if (Input.GetKeyDown("c"))
//     {
//         Instantiate(circleObject);
//     }
// }
// else
// {
//     Debug.Log("Cricle Object Already Spawned");
// }
// if (rectangleObject == null)
// {
//     if (Input.GetKeyDown("r"))
//     {
//         Instantiate(rectangleObject);
//     }
// }
// else
// {
//     Debug.Log("Rectangle Object Already Spawned");
// }
// if (GameObject.Find("squareObject") == null)
// {
//     if (Input.GetKeyDown("s"))
//     {
//         Instantiate(squareObject);
//     }
// }
// else
// {
//     Debug.Log("Square Object Already Spawned");
// }
//--------------------------------------------------------------------------------------------------------------------------------
// if (IsSquareObjectPresent())
// {
//     Debug.Log("Exists");
// }
// else
// {
//     if (Input.GetKeyDown(KeyCode.S))
//     {
//         Instantiate(squareObject);
//     }
// }
// bool IsSquareObjectPresent()
// {
//     return GameObject.FindObjectOfType(squareObject.GetType()) != null;
// }
