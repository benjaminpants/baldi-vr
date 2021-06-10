using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

// Token: 0x02000030 RID: 48
public class WarningScreenScript : MonoBehaviour
{
	// Token: 0x060000F2 RID: 242 RVA: 0x00008278 File Offset: 0x00006678
	private void Update()
	{
		if (SteamVR_Input.GetFloat("UseItem", SteamVR_Input_Sources.LeftHand) > 0f)
		{
			SceneManager.LoadScene("MainMenu");
		}
	}
}
