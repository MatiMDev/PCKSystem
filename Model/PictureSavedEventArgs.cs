using System;
using System.Collections.Generic;
using System.Text;

namespace PCKSystem.Model
{
    public class PictureSavedEventArgs : EventArgs
    {
        //Front
            //Right
        public Injury FrontRightShoulder { get; set; } = Injury.D;
        public Injury FrontRightElbow { get; set; } = Injury.D;
        public Injury FrontRightWrist { get; set; } = Injury.D;
        public Injury FrontRightHip { get; set; } = Injury.D;
        public Injury FrontRightKnee { get; set; } = Injury.D;
        public Injury FrontRightFoot { get; set; } = Injury.D;
            //Left
        public Injury FrontLeftShoulder { get; set; } = Injury.D;
        public Injury FrontLeftElbow { get; set; } = Injury.D;
        public Injury FrontLeftWrist { get; set; } = Injury.D;
        public Injury FrontLeftHip { get; set; } = Injury.D;
        public Injury FrontLeftKnee { get; set; } = Injury.D;
        public Injury FrontLeftFoot { get; set; } = Injury.D;

        //Back
            //Right
        public Injury BackRightShoulder { get; set; } = Injury.D;
        public Injury BackRightElbow { get; set; } = Injury.D;
        public Injury BackRightWrist { get; set; } = Injury.D;
        public Injury BackRightHip { get; set; } = Injury.D;
        public Injury BackRightKnee { get; set; } = Injury.D;
        public Injury BackRightFoot { get; set; } = Injury.D;
            //Left
        public Injury BackLeftShoulder { get; set; } = Injury.D;
        public Injury BackLeftElbow { get; set; } = Injury.D;
        public Injury BackLeftWrist { get; set; } = Injury.D;
        public Injury BackLeftHip { get; set; } = Injury.D;
        public Injury BackLeftKnee { get; set; } = Injury.D;
        public Injury BackLeftFoot { get; set; } = Injury.D;
    }
}
