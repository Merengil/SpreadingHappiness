using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalGirlPlaceholderController : AbstractMagicalGirlController
{
	public bool isAngryAtStart;
	
	public MagicalGirlPlaceholderController () : base()
	{
		angryState = new AngryStatePlaceholder();
		happyState = new HappyStatePlaceholder();
		if (isAngryAtStart)
			magicalGirlState = angryState;
		else magicalGirlState = happyState;
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
