using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour
{

	// 중력 가속도
	const float Gravity = 9.81f;

	// 중력의 적용 상태
	public float gravityScale = 1.0f;


	
	// Update is called once per frame
	void Update ()
	{
	
		Vector3 vector = new Vector3 ();


		//if (Application.isEditor)
		{
			// 키 입력을 검출하는 벡터를 설정
			vector.x = Input.GetAxis("Horizontal");
			vector.z = Input.GetAxis("Vertical");

			// 높이 방향의 판정은 z 키로 한다.
			if (Input.GetKey("z"))
			{
				vector.y = 1.0f;
			}
			else
			{
				vector.y = -1.0f;
			}
		}
//		else
//		{
//			vector.x = Input.acceleration.x;
//			vector.z = Input.acceleration.y;
//			vector.y = Input.acceleration.z;
//		}	

		Physics.gravity = Gravity * vector.normalized * gravityScale;
	}
}
