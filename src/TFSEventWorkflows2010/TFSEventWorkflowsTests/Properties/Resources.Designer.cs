﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TFSEventWorkflowsTests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TFSEventWorkflowsTests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;configSections&gt;
        ///    &lt;section name=&quot;log4net&quot; type=&quot;log4net.Config.Log4NetConfigurationSectionHandler,log4net&quot;/&gt;
        ///  &lt;/configSections&gt;
        ///
        ///  &lt;log4net&gt;
        ///    &lt;appender name=&quot;OfficeFile&quot; type=&quot;log4net.Appender.FileAppender&quot;&gt;
        ///      &lt;file type=&quot;log4net.Util.PatternString&quot; value=&quot;\\sardc01\trash$\Office_%date{yyyyMMdd_HHmm}.log&quot;/&gt;
        ///      &lt;layout type=&quot;log4net.Layout.PatternLayout&quot;&gt;
        ///        &lt;param name=&quot;Header&quot; value=&quot;-- start of log. %newline&quot;/&gt;
        ///        &lt;param name=&quot;Foot [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test {
            get {
                return ResourceManager.GetString("test", resourceCulture);
            }
        }
    }
}