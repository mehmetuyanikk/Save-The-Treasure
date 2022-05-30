using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerController
{
    float HorizontalAxis { get; }
    float JumpAxis { get; }
}
