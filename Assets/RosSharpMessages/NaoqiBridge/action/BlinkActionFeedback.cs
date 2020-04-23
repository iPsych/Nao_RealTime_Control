/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.NaoqiBridge
{
    public class BlinkActionFeedback : ActionFeedback<BlinkFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "naoqi_bridge_msgs/BlinkActionFeedback";

        public BlinkActionFeedback() : base()
        {
            this.feedback = new BlinkFeedback();
        }

        public BlinkActionFeedback(Header header, GoalStatus status, BlinkFeedback feedback) : base(header, status)
        {
            this.feedback = feedback;
        }
    }
}
