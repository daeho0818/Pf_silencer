using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danger : MonoBehaviour
{
	Transform target;
	public Vector3 direction;
	public float velocity;
	public float acceleration;
	
	void Update()
	{
		MoveToTarget();
	}
	
	public void MoveToTarget()
	{
		// player의 현재 위치를 받아온다
		target = GameObject.Find("player").transform;
		// player의 위치와 이 객체의 위치를 빼고 단위 벡터화 한다.
		direction = (target.position - transform.position).normalized;
		// 가속도 지정 (추후 힘과 질량, 거리 등 계산해서 수정할 것)
		acceleration = 0.8f;
		// 초가 아닌 한 프레임으로 가속도 계산하여 속도 증가
		velocity = (velocity + acceleration * Time.deltaTime);
		// player와 객체 간의 거리 계산
		float distance = Vector3.Distance(target.position, transform.position);
		// 일정거리 안에 있을 시, 해당 방향으로 이동
		if (distance <= 14f && LightOnOff.light.enabled == true)
		{
			transform.position = new Vector3(transform.position.x + (direction.x * velocity),
												   transform.position.y + (direction.y * velocity),
													 transform.position.z);			
		}
		else if (distance <= 10.0f && LightOnOff.light.enabled == false)
			velocity = 0.0f;
		
		// 일정거리 밖에 있을 시, 속도 초기화
		else
		{
			velocity = 0.0f;
		}
	}
}