using PCKSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PCKSystem.ViewModel
{
    internal class PictureViewModel
    {
        public ICommand GoBackCommand { get; }
        public delegate void EventHandler (object sender, EventArgs e);
        public event EventHandler PictureSaved;
        PictureSavedEventArgs pictureSavedEventArgs = new PictureSavedEventArgs();

        public int FrontRightShoulderSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontRightShoulder = (Injury)value;
            }
        }
        public int FrontRightElbowSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontRightElbow = (Injury)value;
            }
        }
        public int FrontRightWristSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontRightWrist = (Injury)value;
            }
        }
        public int FrontRightHipSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontRightHip = (Injury)value;
            }
        }
        public int FrontRightKneeSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontRightKnee = (Injury)value;
            }
        }
        public int FrontRightFootSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontRightFoot = (Injury)value;
            }
        }

        public int FrontLeftShoulderSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontLeftShoulder = (Injury)value;
            }
        }
        public int FrontLeftElbowSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontLeftElbow = (Injury)value;
            }
        }
        public int FrontLeftWristSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontLeftWrist = (Injury)value;
            }
        }
        public int FrontLeftHipSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontLeftHip = (Injury)value;
            }
        }
        public int FrontLeftKneeSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontLeftKnee = (Injury)value;
            }
        }
        public int FrontLeftFootSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.FrontLeftFoot = (Injury)value;
            }
        }

        public int BackRightShoulderSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackRightShoulder = (Injury)value;
            }
        }
        public int BackRightElbowSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackRightElbow = (Injury)value;
            }
        }
        public int BackRightWristSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackRightWrist = (Injury)value;
            }
        }
        public int BackRightHipSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackRightHip = (Injury)value;
            }
        }
        public int BackRightKneeSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackRightKnee = (Injury)value;
            }
        }
        public int BackRightFootSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackRightFoot = (Injury)value;
            }
        }

        public int BackLeftShoulderSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackLeftShoulder = (Injury)value;
            }
        }
        public int BackLeftElbowSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackLeftElbow = (Injury)value;
            }
        }
        public int BackLeftWristSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackLeftWrist = (Injury)value;
            }
        }
        public int BackLeftHipSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackLeftHip = (Injury)value;
            }
        }
        public int BackLeftKneeSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackLeftKnee = (Injury)value;
            }
        }
        public int BackLeftFootSelectedIndex
        {
            set
            {
                pictureSavedEventArgs.BackLeftFoot = (Injury)value;
            }
        }

        public PictureViewModel()
        {
            GoBackCommand = new Command(GoBack);
        }

        async void GoBack()
        {
            PictureAggregator.Broadcast(pictureSavedEventArgs);
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        protected virtual void OnPictureSaved(PictureSavedEventArgs e)
        {
            PictureSaved?.Invoke(this, e);
        }
    }
}
