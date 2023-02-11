using UnityEngine;
using System.Collections.Generic;
using Mod;
using static Mod.ModUtils;

namespace Tools
{
    class Class1
    {
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
            ConnectedNodeBehaviour nodeBehaviour;
            ConnectedNodeBehaviour connectedNodeBehaviour;

            protected override void Created()
            {
                base.Created();
                joint = gameObject.GetComponent<HingeJoint2D>();
                limb = gameObject.GetComponent<LimbBehaviour>();
                connectedLimb = joint.connectedBody.GetComponent<LimbBehaviour>();
                circulation = gameObject.GetComponent<CirculationBehaviour>();
                connectedCirculation = joint.connectedBody.GetComponent<CirculationBehaviour>();
                nodeBehaviour = gameObject.GetComponent<ConnectedNodeBehaviour>();
                connectedNodeBehaviour = joint.connectedBody.GetComponent<ConnectedNodeBehaviour>();

                if (!joint || !limb || !connectedLimb || !circulation || !connectedCirculation || !nodeBehaviour || !connectedNodeBehaviour)
                {
                    Destroy(this);
                    return;
                }
            }
        }
    }
}