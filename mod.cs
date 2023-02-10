using UnityEngine;
using System.Collections.Generic;

namespace Mod
{
    public class Mod : MonoBehaviour
    {
        public const string ModTag = " [LARS]";

        public static void Main()
        {
            
        }
    }

    public static class ModUtils
    {

    }

    public class LimbAttachmentWireTool : DistanceWireTool
    {
        protected override void OnJointCreate(DistanceJoint2D joint)
        {

        }
    }
}