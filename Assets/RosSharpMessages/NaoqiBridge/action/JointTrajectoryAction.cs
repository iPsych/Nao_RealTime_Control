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
    public class JointTrajectoryAction : Action<JointTrajectoryActionGoal, JointTrajectoryActionResult, JointTrajectoryActionFeedback, JointTrajectoryGoal, JointTrajectoryResult, JointTrajectoryFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "naoqi_bridge_msgs/JointTrajectoryAction";

        public JointTrajectoryAction() : base()
        {
            this.action_goal = new JointTrajectoryActionGoal();
            this.action_result = new JointTrajectoryActionResult();
            this.action_feedback = new JointTrajectoryActionFeedback();
        }

    }
}
