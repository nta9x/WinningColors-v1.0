using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveScript : MonoBehaviour
{
	public Transform target;
	public PathType pathType = PathType.CatmullRom;
	public Transform endPoint;
	public float timeMove =4f;
	void Start()
	{
		// Create a path tween using the given pathType, Linear or CatmullRom (curved).
		// Use SetOptions to close the path
		// and SetLookAt to make the target orient to the path itself
		Tween t = target.DOMove(endPoint.position, timeMove);
	
		// Then set the ease to Linear and use infinite loops
		t.SetEase(Ease.Linear).SetLoops(-1);
	}
}
