﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CATSEE_GATE_SYSTEM.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server = 218.38.221.109; database = LLI; uid = uhc; pwd = uhc;Character Set=utf8")]
        public string sqlUrlRemote {
            get {
                return ((string)(this["sqlUrlRemote"]));
            }
            set {
                this["sqlUrlRemote"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server = localhost; database = LC; uid = root; pwd = 1q2w3e")]
        public string sqlUrlLocal {
            get {
                return ((string)(this["sqlUrlLocal"]));
            }
            set {
                this["sqlUrlLocal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("local")]
        public string runMode {
            get {
                return ((string)(this["runMode"]));
            }
            set {
                this["runMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\myWorkspace\\catsee\\data")]
        public string dataRootDir {
            get {
                return ((string)(this["dataRootDir"]));
            }
            set {
                this["dataRootDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F075PNIdg6xLbhgWfvsq+/Vcumdcafw3cDqAbPf+6ehQssjK9oJX89mgM+VlBqAbx6caRieef41Zp5pBf" +
            "oaCk7ROER/LMiA7n1Ev8GyzVytzNud23jR669meIwZLNCpMltCL5mZzK2vWZNATa826CKaLqkoDFTn+m" +
            "tsx+vwDGoQ=")]
        public string activeKey {
            get {
                return ((string)(this["activeKey"]));
            }
            set {
                this["activeKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tracker.dat")]
        public string trackerMemoryFile {
            get {
                return ((string)(this["trackerMemoryFile"]));
            }
            set {
                this["trackerMemoryFile"] = value;
            }
        }
    }
}