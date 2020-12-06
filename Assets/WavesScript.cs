using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WavesScript : MonoBehaviour
{
	public float moveTime = 4f;
	public Transform target;
	public PathType pathType = PathType.CatmullRom;
	public Vector3[] waypoints = new[] {
		new Vector3(0, 0, 0),
		new Vector3(1, 0.5f, 0),
		new Vector3(1.5f, 0, 0),
		new Vector3(1,-0.5f, 0),

	};

	void Start()
	{
		// Create a path tween using the given pathType, Linear or CatmullRom (curved).
		// Use SetOptions to close the path
		// and SetLookAt to make the target orient to the path itself
		//this.transform.position = waypoints[0];
		Tween t = target.DOPath(waypoints, moveTime, pathType)
			.SetOptions(true)
			.SetLookAt(0.001f);
		// Then set the ease to Linear and use infinite loops
		t.SetEase(Ease.Linear).SetLoops(-1);
	}
}
