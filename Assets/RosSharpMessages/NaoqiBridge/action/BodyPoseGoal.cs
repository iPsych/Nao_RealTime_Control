/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.NaoqiBridge
{
    public class BodyPoseGoal : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "naoqi_bridge_msgs/BodyPoseGoal";

        //  goal: a registered body pose name
        public string pose_name;

        public BodyPoseGoal()
        {
            this.pose_name = "";
        }

        public BodyPoseGoal(string pose_name)
        {
            this.pose_name = pose_name;
        }
    }
}