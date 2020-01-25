using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform joueur;
    public Vector3 decalage;

    // Update is called once per frame
    void Update()
    {
        transform.position = joueur.position + decalage;
    }
}
