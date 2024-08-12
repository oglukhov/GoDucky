using System;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   public Color deathColor;
   private SpriteRenderer _sr;
   public GameObject explosion, losePanel, startBtn, logo;
   private AudioSource _audioLose;
   private Transform _tr;

   private void Awake()
   {
      
      _sr = GetComponent<SpriteRenderer>();
      _audioLose = GetComponent<AudioSource>();
      _tr = GetComponent<Transform>();
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.CompareTag("Knife"))
      {
         StartGame.isStart = false;
         Destroy(collision.gameObject.transform.parent.gameObject);
         _sr.color = deathColor;

         ContactPoint2D contact = collision.contacts[0];
         Vector3 pos = contact.point;
         GameObject explode = Instantiate(explosion, pos, Quaternion.identity);
         Destroy(explode, 1f);
         _audioLose.Play();
         _tr.Translate(new Vector2(gameObject.transform.position.x * 0.05f * Time.deltaTime, -10f));
         losePanel.SetActive(true);
         
      }
         
   }
}
