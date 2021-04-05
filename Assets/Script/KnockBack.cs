using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
	[SerializeField]
	float Knock = 10f;
	public GameObject player;

	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject == player)
		{
			if (transform.position.x < player.transform.position.x)
			{
				transform.Translate(-Knock, -5, 0);
			}
			else
			{
				transform.Translate(Knock, -5, 0);
			}
		}
	}
}
