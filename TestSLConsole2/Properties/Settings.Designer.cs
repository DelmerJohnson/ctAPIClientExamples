﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestSLConsole.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("CTAPI")]
        public string SoftwareName {
            get {
                return ((string)(this["SoftwareName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowSelfSignedServiceCalls {
            get {
                return ((bool)(this["AllowSelfSignedServiceCalls"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://testServer/ctDynamicsSL/orders.asmx")]
        public string TestSLConsole_ctDynamicsSL_orders_orders {
            get {
                return ((string)(this["TestSLConsole_ctDynamicsSL_orders_orders"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://catalina/ctDynamicssl/invoiceAndMemo.asmx")]
        public string TestSLConsole_ctDynamicsSL_invoiceAndMemo_invoiceAndMemo {
            get {
                return ((string)(this["TestSLConsole_ctDynamicsSL_invoiceAndMemo_invoiceAndMemo"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1/1/2018")]
        public string LicenseExpiration {
            get {
                return ((string)(this["LicenseExpiration"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("333DCC0A0883D25D1BB0C3798254D97B6F03C584")]
        public string LicenseKey {
            get {
                return ((string)(this["LicenseKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CTAPI")]
        public string SiteKey {
            get {
                return ((string)(this["SiteKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0060")]
        public string CpnyID {
            get {
                return ((string)(this["CpnyID"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CATALINA DEMO SYSTEM")]
        public string LicenseName {
            get {
                return ((string)(this["LicenseName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://catalina/ctDynamicssl/purchaseOrders.asmx")]
        public string TestSLConsole_ctDynamicsSL_purchaseOrders_purchaseOrders {
            get {
                return ((string)(this["TestSLConsole_ctDynamicsSL_purchaseOrders_purchaseOrders"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://catalina/ctDynamicssl/projectMaintenance.asmx")]
        public string TestSLConsole_ctDynamicsSL_projectMaintenance_projectMaintenance {
            get {
                return ((string)(this["TestSLConsole_ctDynamicsSL_projectMaintenance_projectMaintenance"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DEFAULT")]
        public string SiteID {
            get {
                return ((string)(this["SiteID"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://catalina/ctDynamicssl/voucherAndAdjustmentEntry.asmx?WSDL")]
        public string TestSLConsole_ctDynamicsSL_voucherAndAdjustmentEntry_voucherAndAdjustmentEntry {
            get {
                return ((string)(this["TestSLConsole_ctDynamicsSL_voucherAndAdjustmentEntry_voucherAndAdjustmentEntry"]));
            }
        }
    }
}
