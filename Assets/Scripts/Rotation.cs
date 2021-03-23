using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    float xSpinning;
    [SerializeField]
    float ySpinning;
    [SerializeField]
    float zSpinning;

     //FixedUpdate appelé à des temps fixes VS Update dépend du taux de rafraichissement (once by frame)
    void FixedUpdate()
    {
        transform.Rotate(xSpinning * Time.deltaTime, ySpinning * Time.deltaTime, zSpinning * Time.deltaTime); 
    }
}
