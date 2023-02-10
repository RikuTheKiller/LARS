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

    public class AttachmentWireTool : DistanceWireTool
    {
        protected override void OnJointCreate(DistanceJoint2D joint)
        {
            AttachmentWireBehaviour attachmentWireBehaviour = gameObject.AddComponent<AttachmentWireBehaviour>();
        }
    }

    public class AttachmentWireBehaviour : DistanceJointWireBehaviour
    {
        HingeJoint2D joint;
        LimbBehaviour limb;
        LimbBehaviour connectedLimb;
        CirculationBehaviour circulation;
        CirculationBehaviour connectedCirculation;

        protected override void Created()
        {
            base.Created();
            joint = gameObject.GetComponent<HingeJoint2D>();
            limb = gameObject.GetComponent<LimbBehaviour>();
            connectedLimb = joint.connectedBody.GetComponent<LimbBehaviour>();
            circulation = gameObject.GetComponent<CirculationBehaviour>();
            connectedCirculation = gameObject.GetComponent<CirculationBehaviour>();
            if (!joint || !limb || !connectedLimb || !circulation || !connectedCirculation)
            {
                Destroy(this);
                return;
            }
        }
    }
}