﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client.inventory.inventory.maintenance.kits.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/ctDynamicsSL/kits.asmx")]
        public string client_inventory_inventory_maintenance_kits_ctDynamicsSL_inventory_inventory_maintenance_kits_kits {
            get {
                return ((string)(this["client_inventory_inventory_maintenance_kits_ctDynamicsSL_inventory_inventory_main" +
                    "tenance_kits_kits"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/ctDynamicsSL/inventoryItems.asmx")]
        public string client_inventory_inventory_maintenance_kits_ctDynamicsSL_inventory_inventory_maintenance_inventoryItems_inventoryItems {
            get {
                return ((string)(this["client_inventory_inventory_maintenance_kits_ctDynamicsSL_inventory_inventory_main" +
                    "tenance_inventoryItems_inventoryItems"]));
            }
        }
    }
}
