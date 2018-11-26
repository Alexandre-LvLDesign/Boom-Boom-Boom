using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonMovement : MonoBehaviour 
{
	[Header("HORIZONTAL.MOVEMENT.MANAGER")]
	public Rails rail;
	public PlayMode mode;
	public float speed = 2.5f;
	public bool isReversed;
	public bool isLooping;
	public bool pingPong;

	private GetInput m_InputScript;
	private int currentSeg;
	private float transition;
	private bool isCompleted;


	[Header("ROTATION.MANAGER")]
	 [SerializeField] private GameObject head;
	 [SerializeField] private GameObject body;
    public float ySpeed = 40f;
    public float xRotationSpeed = 40f;

    [Header("Clamp X (Vertical)")]
    public float minXRotation = 0;
    public float maxXRotation = 0;

    [Header("Clamp Y (Horizontal)")]
    public float minYRotation = 0;
    public float maxYRotation = 0;


    public float currrentYAngle = 0;
    public float currrentXAngle = 0;

	private void Start() 
	{
		m_InputScript = GetComponent<GetInput>();	
	}

	private void Update() 
	{
		if (!rail)
		{
			return;
		}
		if(!isCompleted)
			Play(!isReversed);

		currrentXAngle = Mathf.Clamp(currrentXAngle + m_InputScript.RotationX, minXRotation, maxXRotation);
        currrentYAngle = Mathf.Clamp(currrentYAngle + m_InputScript.RotationY * ySpeed, minYRotation, maxYRotation);

		body.transform.localEulerAngles = new Vector3(0, currrentYAngle, 0);
		head.transform.localEulerAngles = new Vector3(currrentXAngle, 0, 0);
        //transform.localEulerAngles = new Vector3(currrentXAngle, currrentYAngle, 0);	
	}

	private void Play(bool forward = true)
	{
		float m = (rail.nodes[currentSeg + 1].position - rail.nodes[currentSeg].position).magnitude;
		float s = (Time.deltaTime * 1 /m) * speed;
		
		
		if(m_InputScript.HorizontalMovement >= 0.1)
		{
			
			transition += (forward) ? s : -s;
		}
		if(m_InputScript.HorizontalMovement  <= -0.1)
		{
			
			transition -= (forward) ? s : -s;
		}

		if (transition >1 )
		{
			transition = 0;
			currentSeg++;
			if(currentSeg == rail.nodes.Length -1)
			{
				if (isLooping)
				{
					if(pingPong)
					{
						transition = 1;
						currentSeg = rail.nodes.Length-2;
						isReversed = !isReversed;

					}
					else
					{
						currentSeg =0;
					}
				}
				else
				{
					isCompleted = true;
					return;
				}
			}
		}
		else if (transition <0 )
		{
			transition =1;
			currentSeg--;
			if(currentSeg == -1)
			{
				if (isLooping)
				{
					if(pingPong)
					{
						transition = 0;
						currentSeg = 0;
						isReversed = !isReversed;

					}
					else
					{
						currentSeg =rail.nodes.Length -2;
					}
				}
				else
				{
					isCompleted = true;
					return;
				}
			}
		}

		transform.position = rail.PositionOnRail(currentSeg, transition, mode);
		transform.rotation = rail.Orientation(currentSeg, transition);
	}

}
