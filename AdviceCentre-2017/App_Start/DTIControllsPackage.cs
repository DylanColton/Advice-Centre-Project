using System;

[assembly: WebActivatorEx.PreApplicationStartMethod(
    typeof(AdviceCentre_2017.App_Start.DTIControllsPackage), "PreStart")]

namespace AdviceCentre_2017.App_Start {
    public static class DTIControllsPackage {
        public static void PreStart() {
            DTIControls.Share.initializePathProvider();
        }
    }
}