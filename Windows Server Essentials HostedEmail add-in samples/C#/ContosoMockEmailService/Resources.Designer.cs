﻿//
//  <copyright file="Resources.Designer.cs" company="Microsoft">
//    Copyright (C) Microsoft. All rights reserved.
//  </copyright>
//

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contoso.EmailService {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Contoso.EmailService.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:simpleType name=&quot;ErrorCodeEnum&quot;&gt;
        ///    &lt;xs:restriction base=&quot;xs:string&quot;&gt;
        ///      &lt;xs:enumeration value=&quot;ServiceNotReachable&quot; /&gt;
        ///      &lt;xs:enumeration value=&quot;InsufficientPermission&quot; /&gt;
        ///      &lt;xs:enumeration value=&quot;AuthenticationFailure&quot; /&gt;
        ///      &lt;xs:enumeration value=&quot;AccountAlreadyExists&quot; /&gt;
        ///      &lt;xs:enumeration value=&quot;AccountNotExists&quot; /&gt;
        ///      &lt;xs:enumeration value=&quot;InvalidEmailAddress&quot; /&gt;
        ///      &lt;xs [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConfigurationSchema {
            get {
                return ResourceManager.GetString("ConfigurationSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!-- Copyright (c) Microsoft Corporation. All rights reserved --&gt;
        ///&lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Configuration&gt;
        ///  &lt;DefaultOperationDuration&gt;2&lt;/DefaultOperationDuration&gt;
        ///  &lt;Operations&gt;
        ///    &lt;!--Credential operations--&gt;
        ///    &lt;Operation Name=&quot;VerifyAdminAccount&quot;&gt;
        ///      &lt;DurationInSeconds&gt;1&lt;/DurationInSeconds&gt;
        ///    &lt;/Operation&gt;
        ///    &lt;!--Connection operations--&gt;
        ///    &lt;Operation Name=&quot;Logon&quot;&gt;
        ///      &lt;DurationInSeconds&gt;1&lt;/DurationInSeconds&gt;
        ///    &lt;/Operation&gt;
        ///    &lt;Operation Name=&quot;LogOff&quot;&gt;
        ///      &lt;Du [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultConfgiuration {
            get {
                return ResourceManager.GetString("DefaultConfgiuration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string string1 {
            get {
                return ResourceManager.GetString("string1", resourceCulture);
            }
        }
    }
}