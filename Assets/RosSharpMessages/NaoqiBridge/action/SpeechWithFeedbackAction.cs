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
    public class SpeechWithFeedbackAction : Action<SpeechWithFeedbackActionGoal, SpeechWithFeedbackActionResult, SpeechWithFeedbackActionFeedback, SpeechWithFeedbackGoal, SpeechWithFeedbackResult, SpeechWithFeedbackFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "naoqi_bridge_msgs/SpeechWithFeedbackAction";

        public SpeechWithFeedbackAction() : base()
        {
            this.action_goal = new SpeechWithFeedbackActionGoal();
            this.action_result = new SpeechWithFeedbackActionResult();
            this.action_feedback = new SpeechWithFeedbackActionFeedback();
        }

    }
}