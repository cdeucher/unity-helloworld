using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float startSpeed = 0.2f;

	[HideInInspector]
	public float speed =0.1f;

	public float startHealth = 100;
	private float health;

	[Header("Unity Stuff")]
	public Image healthBar;

	private bool isDead = false;

	void Start ()
	{

	}



}
