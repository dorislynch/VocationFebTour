using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Vocation.Feb.Tour.RNVocationFebTour
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNVocationFebTourModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNVocationFebTourModule"/>.
        /// </summary>
        internal RNVocationFebTourModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNVocationFebTour";
            }
        }
    }
}
