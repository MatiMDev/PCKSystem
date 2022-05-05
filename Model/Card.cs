using System;
using System.Collections.Generic;
using System.Text;

namespace PCKSystem.Model
{
    internal class Card
    {
        //patient info
        public string Gender { get; set; } = "Male";
        public int Age { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        //respiratory system
        public int BreathingFrequency { get; set; }
        public bool Dyspnoe { get; set; }
        public bool Cyanosis { get; set; }
        public bool Apnea { get; set; }
        public int Saturation { get; set; }

        //circulatory system
        public int Pulse { get; set; }
        public bool Centrally { get; set; }
        public bool Peripherally { get; set; }
        public int SystolicPressure { get; set; }
        public int DiastolicPressure { get; set; }

        //symptoms
        public bool Schock { get; set; }
        public bool SCA { get; set; }
        public bool MeningealSymptoms { get; set; }
        public bool Seizures { get; set; }
        public bool Aphasia { get; set; }
        public bool Vomiting { get; set; }

        //skin
        //appearence
        public bool PaleSkin { get; set; }
        public bool Erythema { get; set; }
        public bool Yellowing { get; set; }
        public bool CentralCyanosis { get; set; }
        public bool PeripheralCyanosis { get; set; }
        //temperature
        public bool SkinTemperatureNormal { get; set; }
        public bool SkinTemperatureCold { get; set; }
        public bool SkinTemperatureWarm { get; set; }

        //psychomotor assessment
        public bool PsychoMotorNormal { get; set; }
        public bool PsychoMotorSlowedDown { get; set; }
        public bool PsychoMotorAgitated { get; set; }
        public bool PsychoMotorAggressive { get; set; }

        //smell from the mouth
        public bool OrganicSolvent { get; set; }
        public bool Alcohol { get; set; }
        public string OtherSmells { get; set;}

        //paresis/paralysis
        public bool UpperRightLimb { get; set; }
        public bool UpperLeftLimb { get; set; }
        public bool LowerRightLimb { get; set; }
        public bool LowerLeftLimb { get; set; }

        //others
        public bool Pregnancy { get; set; }
        public bool Birth { get; set; }
        public bool InfectiousDesease { get; set; }

        //injuries

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

        //interview
        public string Interview { get; set; }
        public string Description { get; set; }
    }
}
