using System;
using System.Collections.Generic;
using System.Text;

namespace PCKSystem.Model
{
    public static class PictureAggregator
    {
        public static void Broadcast(PictureSavedEventArgs e)
        {
            OnSavedButtonClicked(e);
        }

        public static Action<PictureSavedEventArgs> OnSavedButtonClicked;
    }
}
