
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




#if AADOTWEEN
using UnityEngine;
using System.Collections;
using DG.Tweening;

/// <summary>
/// Attached to all game object we want with a dark color
/// </summary>
public class ColorDarkLogic : ColorBase
{
	public override void OnColorChanged (AAColor c)
	{
		SetColor(c.colorDark);
	}

	public override void SetColor(Color c)
	{
		if(Time.realtimeSinceStartup < 0.1f)
			SetColor(c, 0);
		else
			SetColor(c, timeAnim);
	}

	public void SetColor(Color c, float time)
	{
		if(cam != null)
			cam.DOColor(c,time);

		if(sr != null)
			sr.DOColor(c,time);

		if(im != null)
			im.DOColor(c,time);

		if(txt != null)
			txt.DOColor(c,time);
	}
}
#endif