using PCKSystem.Model;
using PCKSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PCKSystem.ViewModel
{
    internal class AddCardViewModel : INotifyPropertyChanged
    {
        int rotation;
        public ICommand InjuriesCommand { get; }
        public ICommand CheckedChangedCommand { get; }
        public ICommand CheckedChangedReversedCommand { get; }
        Card card = new Card();
        bool isMale = true;
        bool IsChanged = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Gender 
        {
            set 
            {
                card.Gender = value;
            } 
        }
        public int Age 
        {
            set
            {
                card.Age = value;
            } 
        }
        public string Name 
        { 
            set
            { 
                    card.Name = value;
            }
        }
        public string Surname 
        {
            set
            {
                card.Surname = value;
            }
        }
        public bool IsMale
        {
            get
            {
                return isMale;
            }
        }
        public int BreathingFrequency
        {
            set 
            {
                card.BreathingFrequency = value; 
            }
        }
        public bool Dyspnoe
        {
            set 
            { 
                card.Dyspnoe = value; 
            }
        }
        public bool Cyanosis
        {
            set
            {
                card.Cyanosis = value;
            }
        }
        public bool Apnea
        {
            set
            {
                card.Apnea = value;
            }
        }
        public int Saturation
        {
            set
            {
                card.Saturation = value;
            }
        }
        public int Pulse
        {
            set
            {
                card.Pulse = value;
            }
        }
        public bool Centrally
        {
            set
            {
                card.Centrally = value;
            }
        }
        public bool Peripherally
        {
            set
            {
                card.Peripherally = value;
            }
        }
        public int SystolicPressure
        {
            set
            {
                card.SystolicPressure = value;
            }
        }       
        public int DiastolicPressure
        {
            set
            {
                card.DiastolicPressure = value;
            }
        }
        public bool Schock
        {
            set 
            { 
                card.Schock = value; 
            }
        }
        public bool SCA
        {
            set 
            { 
                card.SCA = value; 
            }
        }
        public bool MeningealSymptoms
        {
            set
            {
                card.MeningealSymptoms = value;
            }
        }
        public bool Seizures
        {
            set 
            { 
                card.Seizures = value; 
            }
        }
        public bool Aphasia
        {
            set 
            { 
                card.Aphasia = value;
            }
        }
        public bool Vomiting
        {
            set 
            { 
                card.Vomiting = value; 
            }
        }
        public bool PaleSkin
        {
            set 
            { 
                card.PaleSkin = value; 
            }
        }
        public bool Erythema
        {
            set
            {
                card.Erythema = value;
            }
        }
        public bool Yellowing
        {
            set 
            { 
                card.Yellowing = value; 
            }
        }
        public bool CentralCyanosis
        {
            set 
            { 
                card.CentralCyanosis = value;
            }
        }
        public bool PeripheralCyanosis
        {
            set 
            { 
                card.PeripheralCyanosis = value;
            }
        }
        public bool SkinTemperatureNormal
        {
            set 
            { 
                card.SkinTemperatureNormal = value; 
            }
        }
        public bool SkinTemperatureCold
        {
            set 
            { 
                card.SkinTemperatureCold = value;
            }
        }
        public bool SkinTemperatureWarm
        {
            set
            {
                card.SkinTemperatureWarm = value;
            }
        }
        public bool PsychoMotorNormal
        {
            set
            {
                card.PsychoMotorNormal = value;
            }
        }
        public bool PsychoMotorSlowedDown
        {
            set
            {
                card.PsychoMotorSlowedDown = value;
            }
        }
        public bool PsychoMotorAgitated
        {
            set
            {
                card.PsychoMotorAgitated = value;
            }
        }
        public bool PsyhoMotorAggressive
        {
            set
            {
                card.PsychoMotorAggressive = value;
            }
        }
        public bool OrganicSolvent
        {
            set
            {
                card.OrganicSolvent = value;
            }
        }
        public bool Alcohol
        {
            set
            {
                card.Alcohol = value;
            }
        }
        public string OtherSmells
        {
            set
            {
                card.OtherSmells = value;
            }
        }
        public bool UpperRightLimb
        {
            set
            {
                card.UpperRightLimb = value;
            }
        }
        public bool UpperLeftLimb
        {
            set
            {
                card.UpperLeftLimb = value;
            }
        }
        public bool LowerRightLimb
        {
            set
            {
                card.LowerRightLimb = value;
            }
        }
        public bool LowerLeftLimb
        {
            set
            {
                card.LowerRightLimb |= value;
            }
        }
        public bool Pregnancy
        {
            set 
            {
                card.Pregnancy = value;
            }
        }
        public bool Birth
        {
            set
            {
                card.Birth = value;
            }
        }
        public bool InfectiousDesease
        {
            set 
            {
                card.InfectiousDesease = value;
            }
        }
        public string Interview
        {
            set
            {
                card.Interview = value;
            }
        }
        public string Decription
        {
            set
            {
                card.Description = value;
            }
        }

        public AddCardViewModel()
        {
            InjuriesCommand = new Command(OpenInjuriesView);
            CheckedChangedCommand = new Command(ChangeGenderNormal);
            CheckedChangedReversedCommand = new Command(ChangeGenderReversed);
            PictureAggregator.OnSavedButtonClicked += AddInjuries;
        }

        protected internal void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        void ChangeGenderNormal()
        {
            if (IsChanged)
            {
                ChangeGender();
                IsChanged = false;
            }
        }
        void ChangeGenderReversed()
        {
            if(!IsChanged)
            {
                ChangeGender();
                IsChanged = true;
            }
        }
        void ChangeGender()
        {
            isMale = !isMale;
            OnPropertyChanged("IsMale");
            if (IsMale)
            {
                card.Gender = "Male";
            }
            else
            {
                card.Gender = "Female";
            }
        }

        public int Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        async void OpenInjuriesView()
        {
            PictureView pictureView = new PictureView();
            await Application.Current.MainPage.Navigation.PushAsync(pictureView);
        }

        void AddInjuries(PictureSavedEventArgs e)
        {
            card.FrontRightShoulder = e.FrontRightShoulder;
            card.FrontLeftShoulder = e.FrontLeftShoulder;
            card.FrontRightElbow = e.FrontRightElbow;
            card.FrontLeftElbow = e.FrontLeftElbow;
            card.FrontRightWrist = e.FrontRightWrist;
            card.FrontLeftWrist = e.FrontLeftWrist;
            card.FrontRightHip = e.FrontRightHip;
            card.FrontLeftHip = e.FrontLeftHip;
            card.FrontRightKnee = e.FrontRightKnee;
            card.FrontLeftKnee = e.FrontLeftKnee;
            card.FrontRightFoot = e.FrontRightFoot;
            card.FrontLeftFoot = e.FrontLeftFoot;

            card.BackRightShoulder = e.BackRightShoulder;
            card.BackLeftShoulder = e.BackLeftShoulder;
            card.BackRightElbow = e.BackRightElbow;
            card.BackLeftElbow = e.BackLeftElbow;
            card.BackRightWrist = e.BackRightWrist;
            card.BackLeftWrist = e.BackLeftWrist;
            card.BackRightHip = e.BackRightHip;
            card.BackLeftHip = e.BackLeftHip;
            card.BackRightKnee = e.BackRightKnee;
            card.BackLeftKnee = e.BackLeftKnee;
            card.BackRightFoot = e.BackRightFoot;
            card.BackLeftFoot = e.BackLeftFoot;
        }
    }
}
