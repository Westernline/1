using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    public HeroMovementController movement;


    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag =="obstacle")
        {
            movement.enabled = false;
            losePanel.SetActive(true);
            //Time.timeScale = 0;    
        }
    }

    
}
