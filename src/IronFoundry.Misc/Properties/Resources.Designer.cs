﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IronFoundry.Misc.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IronFoundry.Misc.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled Exception in timer callback! Exiting!.
        /// </summary>
        internal static string ActionTimer_UnhandledException_Message {
            get {
                return ResourceManager.GetString("ActionTimer_UnhandledException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ExecCmd: &apos;{0} {1}&apos;.
        /// </summary>
        internal static string ExecCmd_Cmd_Fmt {
            get {
                return ResourceManager.GetString("ExecCmd_Cmd_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0} {1}&apos; failed: {2}.
        /// </summary>
        internal static string ExecCmd_CmdFailed_Fmt {
            get {
                return ResourceManager.GetString("ExecCmd_CmdFailed_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command not found: &apos;{0}&apos;.
        /// </summary>
        internal static string ExecCmd_PathNotFound_Fmt {
            get {
                return ResourceManager.GetString("ExecCmd_PathNotFound_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find the powershell installation directory..
        /// </summary>
        internal static string PowershellExecutor_CantFindDir_Message {
            get {
                return ResourceManager.GetString("PowershellExecutor_CantFindDir_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find the powershell.exe executable..
        /// </summary>
        internal static string PowershellExecutor_CantFindExe_Message {
            get {
                return ResourceManager.GetString("PowershellExecutor_CantFindExe_Message", resourceCulture);
            }
        }
    }
}
