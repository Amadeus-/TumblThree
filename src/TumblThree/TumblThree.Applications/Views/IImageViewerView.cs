﻿using System.Waf.Applications;

namespace TumblThree.Applications.Views
{
    public interface IImageViewerView : IView
    {
        void ShowDialog(object owner);
    }
}
