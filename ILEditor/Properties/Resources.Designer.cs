﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILEditor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ILEditor.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap application_go {
            get {
                object obj = ResourceManager.GetObject("application_go", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap books {
            get {
                object obj = ResourceManager.GetObject("books", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap bug {
            get {
                object obj = ResourceManager.GetObject("bug", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap comment_sign {
            get {
                object obj = ResourceManager.GetObject("comment_sign", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap compile {
            get {
                object obj = ResourceManager.GetObject("compile", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///
        ///&lt;html lang=&quot;en&quot; xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;style&gt;
        ///        body {
        ///            font-family: Arial, Helvetica, sans-serif;
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;h3&gt;Compiling a program&lt;/h3&gt;
        ///    &lt;p&gt;IlEditor will compile most ILE types by default. To compile a program&lt;/p&gt;
        ///    &lt;ul&gt;
        ///        &lt;li&gt;Use the Compile dropdown when the member is open, or&lt;/li&gt;
        ///        &lt;li&gt;Right click on a member in the member listi [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Compiling {
            get {
                return ResourceManager.GetString("Compiling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap computer {
            get {
                object obj = ResourceManager.GetObject("computer", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap cube {
            get {
                object obj = ResourceManager.GetObject("cube", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;SyntaxDefinition name=&quot;CLLE&quot;
        ///        xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;#F561E0&quot; /&gt;
        ///  &lt;Color name=&quot;String&quot; foreground=&quot;#F561E0&quot; /&gt;
        ///
        ///  &lt;!-- This is the main ruleset. --&gt;
        ///  &lt;RuleSet ignoreCase=&quot;true&quot;&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;//&quot; /&gt;
        ///
        ///    &lt;Span color=&quot;String&quot;  multiline=&quot;true&quot;&gt;
        ///      &lt;Begin&gt;&apos;&lt;/Begin&gt;
        ///      &lt;End&gt;&apos;&lt;/End&gt;
        ///    &lt;/Span&gt;
        ///
        ///    &lt;Span color=&quot;Comment&quot; multiline=&quot;true&quot;&gt;
        ///      &lt;Begin&gt;/\*&lt;/Begin&gt;
        ///      &lt;End&gt;\*/&lt;/End [rest of string was truncated]&quot;;.
        /// </summary>
        public static string darkCL {
            get {
                return ResourceManager.GetString("darkCL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;SyntaxDefinition name=&quot;COBOL&quot;
        ///        xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;Green&quot; /&gt;
        ///
        ///  &lt;RuleSet ignoreCase=&quot;true&quot;&gt;
        ///
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;/&quot; /&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;\*&quot; /&gt;
        ///    
        ///    &lt;Keywords foreground=&quot;#829BE5&quot;&gt;
        ///      &lt;Word&gt;access&lt;/Word&gt;
        ///      &lt;Word&gt;acquire&lt;/Word&gt;
        ///      &lt;Word&gt;actual&lt;/Word&gt;
        ///      &lt;Word&gt;address&lt;/Word&gt;
        ///      &lt;Word&gt;advancing&lt;/Word&gt;
        ///      &lt;Word&gt;after&lt;/Word&gt;
        ///      &lt;Word&gt;all&lt;/Word&gt;
        ///      &lt;W [rest of string was truncated]&quot;;.
        /// </summary>
        public static string darkCOBOL {
            get {
                return ResourceManager.GetString("darkCOBOL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;!-- syntaxdefinition for C/C++ 2001 by Andrea Paatz and Mike Krueger --&gt;
        ///&lt;!-- converted to AvalonEdit format by Siegfried Pammer in 2010 --&gt;
        ///&lt;SyntaxDefinition name=&quot;C++&quot; extensions=&quot;.c;.h;.cc;.cpp;.hpp&quot; xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///	&lt;Color name=&quot;Comment&quot; foreground=&quot;#4FB548&quot; /&gt;
        ///	&lt;Color name=&quot;Character&quot; foreground=&quot;#4FB548&quot; /&gt;
        ///	&lt;Color name=&quot;String&quot; foreground=&quot;#4FB548&quot; /&gt;
        ///	&lt;Color name=&quot;Preprocessor&quot; foreground=&quot;#9B9B9B&quot; /&gt;
        ///	&lt;Color name=&quot;Pun [rest of string was truncated]&quot;;.
        /// </summary>
        public static string darkCPP {
            get {
                return ResourceManager.GetString("darkCPP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///
        ///&lt;html lang=&quot;en&quot; xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///	&lt;meta charset=&quot;utf-8&quot; /&gt;
        ///	&lt;title&gt;&lt;/title&gt;
        ///	&lt;style&gt;
        ///		body {
        ///			font-family: Arial, Helvetica, sans-serif;
        ///		}
        ///	&lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///	&lt;h3&gt;Enabling Dark Mode&lt;/h3&gt;
        ///	&lt;p&gt;ILEditor has a built in Dark Mode, which turns tabs and editor dark.&lt;/p&gt;
        ///	&lt;ol&gt;
        ///		&lt;li&gt;Open up the Connection Settings: Tools-&gt;Connection Settings, or access via the Toolbox&lt;/li&gt;
        ///		&lt;li&gt;Click on the ILEditor tab&lt;/li&gt;
        ///		&lt;li&gt;Click on the Dark Mode chec [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DarkMode {
            get {
                return ResourceManager.GetString("DarkMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;SyntaxDefinition name=&quot;Python&quot; extensions=&quot;.py;.pyw&quot; xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///	&lt;Color name=&quot;Comment&quot; foreground=&quot;#6272a9&quot; exampleText=&quot;# comment&quot; /&gt;
        ///	&lt;Color name=&quot;String&quot; foreground=&quot;#047b22&quot; exampleText=&quot;name = &apos;abc&apos;&quot;/&gt;
        ///	&lt;Color name=&quot;MethodCall&quot; foreground=&quot;#8585e0&quot; exampleText=&quot;def Hello()&quot;/&gt;
        ///	&lt;Color name=&quot;NumberLiteral&quot; foreground=&quot;#72a6ff&quot; exampleText=&quot;3.1415f&quot;/&gt;
        ///	&lt;Color name=&quot;Keywords&quot; foreground=&quot;#ffb86c&quot; exampleText=&quot;if&quot;/&gt;
        ///
        ///	&lt;Pr [rest of string was truncated]&quot;;.
        /// </summary>
        public static string darkPython {
            get {
                return ResourceManager.GetString("darkPython", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;SyntaxDefinition name=&quot;RPGLE&quot;
        ///        xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;#4FB548&quot; /&gt;
        ///  &lt;Color name=&quot;String&quot; foreground=&quot;#4FB548&quot; /&gt;
        ///  &lt;Color name=&quot;ESQL&quot; foreground=&quot;LightBlue&quot; /&gt;
        ///
        ///  &lt;!-- This is the main ruleset. --&gt;
        ///  &lt;RuleSet ignoreCase=&quot;true&quot;&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;//&quot; /&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;\*\*&quot; /&gt;
        ///    
        ///    &lt;Span color=&quot;String&quot;&gt;
        ///      &lt;Begin&gt;&apos;&lt;/Begin&gt;
        ///      &lt;End&gt;&apos;&lt;/End&gt;
        ///    &lt;/Span&gt;
        ///    
        ///    &lt;Spa [rest of string was truncated]&quot;;.
        /// </summary>
        public static string darkRPG {
            get {
                return ResourceManager.GetString("darkRPG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;SyntaxDefinition name=&quot;sql&quot; extensions=&quot;.sql&quot;
        ///                  xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;String&quot; foreground=&quot;#FF71EC&quot; exampleText=&quot;string text = &amp;quot;Hello, World!&amp;quot;&quot;/&gt;
        ///  &lt;Color name=&quot;String2&quot; foreground=&quot;#FF71EC&quot; exampleText=&quot;string text = &amp;quot;Hello, World!&amp;quot;&quot;/&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;#FF71EC&quot; exampleText=&quot;string text = &amp;quot;Hello, World!&amp;quot;&quot;/&gt;
        ///  &lt;Color name=&quot;Punctuation&quot; foreground=&quot;Orange&quot; ex [rest of string was truncated]&quot;;.
        /// </summary>
        public static string darkSQL {
            get {
                return ResourceManager.GetString("darkSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap edit {
            get {
                object obj = ResourceManager.GetObject("edit", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap edit1 {
            get {
                object obj = ResourceManager.GetObject("edit1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap filedelete {
            get {
                object obj = ResourceManager.GetObject("filedelete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap folder {
            get {
                object obj = ResourceManager.GetObject("folder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///
        ///&lt;html lang=&quot;en&quot; xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;style&gt;
        ///        body {
        ///            font-family: Arial, Helvetica, sans-serif;
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;h3&gt;Library List in ILEditor&lt;/h3&gt;
        ///    &lt;p&gt;The library list will apply to every command sent from ILEditor, including all compiles. To open the library list editor:&lt;/p&gt;
        ///    &lt;ol&gt;
        ///        &lt;li&gt;Select the Tools dropdown&lt;/li&gt;
        ///        &lt;li&gt;Select Librar [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LibraryList {
            get {
                return ResourceManager.GetString("LibraryList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;SyntaxDefinition name=&quot;CLLE&quot;
        ///        xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;Green&quot; /&gt;
        ///  &lt;Color name=&quot;String&quot; foreground=&quot;Green&quot; /&gt;
        ///
        ///  &lt;!-- This is the main ruleset. --&gt;
        ///  &lt;RuleSet ignoreCase=&quot;true&quot;&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;//&quot; /&gt;
        ///
        ///    &lt;Span color=&quot;String&quot;  multiline=&quot;true&quot;&gt;
        ///      &lt;Begin&gt;&apos;&lt;/Begin&gt;
        ///      &lt;End&gt;&apos;&lt;/End&gt;
        ///    &lt;/Span&gt;
        ///
        ///    &lt;Span color=&quot;Comment&quot; multiline=&quot;true&quot;&gt;
        ///      &lt;Begin&gt;/\*&lt;/Begin&gt;
        ///      &lt;End&gt;\*/&lt;/End&gt;
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string lightCL {
            get {
                return ResourceManager.GetString("lightCL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;SyntaxDefinition name=&quot;COBOL&quot;
        ///        xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;Green&quot; /&gt;
        ///
        ///  &lt;RuleSet ignoreCase=&quot;true&quot;&gt;
        ///
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;/&quot; /&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;\*&quot; /&gt;
        ///    
        ///    &lt;Keywords foreground=&quot;DarkBlue&quot;&gt;
        ///      &lt;Word&gt;access&lt;/Word&gt;
        ///      &lt;Word&gt;acquire&lt;/Word&gt;
        ///      &lt;Word&gt;actual&lt;/Word&gt;
        ///      &lt;Word&gt;address&lt;/Word&gt;
        ///      &lt;Word&gt;advancing&lt;/Word&gt;
        ///      &lt;Word&gt;after&lt;/Word&gt;
        ///      &lt;Word&gt;all&lt;/Word&gt;
        ///      &lt; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string lightCOBOL {
            get {
                return ResourceManager.GetString("lightCOBOL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;!-- syntaxdefinition for C/C++ 2001 by Andrea Paatz and Mike Krueger --&gt;
        ///&lt;!-- converted to AvalonEdit format by Siegfried Pammer in 2010 --&gt;
        ///&lt;SyntaxDefinition name=&quot;C++&quot; extensions=&quot;.c;.h;.cc;.cpp;.hpp&quot; xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///	&lt;Color name=&quot;Comment&quot; foreground=&quot;Green&quot; /&gt;
        ///	&lt;Color name=&quot;Character&quot; foreground=&quot;Fuchsia&quot; /&gt;
        ///	&lt;Color name=&quot;String&quot; foreground=&quot;Fuchsia&quot; /&gt;
        ///	&lt;Color name=&quot;Preprocessor&quot; foreground=&quot;Green&quot; /&gt;
        ///	&lt;Color name=&quot;Punctua [rest of string was truncated]&quot;;.
        /// </summary>
        public static string lightCPP {
            get {
                return ResourceManager.GetString("lightCPP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;SyntaxDefinition name=&quot;Python&quot; extensions=&quot;.py;.pyw&quot; xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///	&lt;Color name=&quot;Comment&quot; foreground=&quot;Green&quot; exampleText=&quot;# comment&quot; /&gt;
        ///	&lt;Color name=&quot;String&quot; foreground=&quot;Gray&quot; exampleText=&quot;name = &apos;abc&apos;&quot;/&gt;
        ///	&lt;Color name=&quot;MethodCall&quot; foreground=&quot;Purple&quot; exampleText=&quot;def Hello()&quot;/&gt;
        ///	&lt;Color name=&quot;NumberLiteral&quot; foreground=&quot;DarkBlue&quot; exampleText=&quot;3.1415f&quot;/&gt;
        ///	&lt;Color name=&quot;Keywords&quot; fontWeight=&quot;bold&quot; foreground=&quot;Blue&quot; exampleText=&quot;if&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string lightPython {
            get {
                return ResourceManager.GetString("lightPython", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;SyntaxDefinition name=&quot;RPGLE&quot;
        ///        xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;Green&quot; /&gt;
        ///  &lt;Color name=&quot;String&quot; foreground=&quot;Green&quot; /&gt;
        ///  &lt;Color name=&quot;ESQL&quot; foreground=&quot;Blue&quot; /&gt;
        ///
        ///  &lt;!-- This is the main ruleset. --&gt;
        ///  &lt;RuleSet ignoreCase=&quot;true&quot;&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;//&quot; /&gt;
        ///    &lt;Span color=&quot;Comment&quot; begin=&quot;\*\*&quot; /&gt;
        ///    
        ///    &lt;Span color=&quot;String&quot;&gt;
        ///      &lt;Begin&gt;&apos;&lt;/Begin&gt;
        ///      &lt;End&gt;&apos;&lt;/End&gt;
        ///    &lt;/Span&gt;
        ///    
        ///    &lt;Span color=&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string lightRPG {
            get {
                return ResourceManager.GetString("lightRPG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;SyntaxDefinition name=&quot;sql&quot; extensions=&quot;.sql&quot;
        ///                  xmlns=&quot;http://icsharpcode.net/sharpdevelop/syntaxdefinition/2008&quot;&gt;
        ///  &lt;Color name=&quot;String&quot; foreground=&quot;Olive&quot; exampleText=&quot;string text = &amp;quot;Hello, World!&amp;quot;&quot;/&gt;
        ///  &lt;Color name=&quot;String2&quot; foreground=&quot;#993&quot; exampleText=&quot;string text = &amp;quot;Hello, World!&amp;quot;&quot;/&gt;
        ///  &lt;Color name=&quot;Comment&quot; foreground=&quot;Green&quot; exampleText=&quot;string text = &amp;quot;Hello, World!&amp;quot;&quot;/&gt;
        ///  &lt;Color name=&quot;Punctuation&quot; foreground=&quot;Red&quot; exampleText= [rest of string was truncated]&quot;;.
        /// </summary>
        public static string lightSQL {
            get {
                return ResourceManager.GetString("lightSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap notebook {
            get {
                object obj = ResourceManager.GetObject("notebook", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///
        ///&lt;html lang=&quot;en&quot; xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;style&gt;
        ///        body {
        ///            font-family: Arial, Helvetica, sans-serif;
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;h3&gt;Offline Mode in ILEditor&lt;/h3&gt;
        ///    &lt;p&gt;As of ILEditor 1.1.1.0, there has been an offline mode available so you can still work on your code while you&apos;re on the go.&lt;/p&gt;
        ///    &lt;p&gt;To use offline mode, start ILEditor and tick &apos;Offline Mode&apos; before sel [rest of string was truncated]&quot;;.
        /// </summary>
        public static string OfflineMode {
            get {
                return ResourceManager.GetString("OfflineMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///
        ///&lt;html lang=&quot;en&quot; xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
        ///&lt;head&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;title&gt;&lt;/title&gt;
        ///    &lt;style&gt;
        ///        body {
        ///            font-family: Arial, Helvetica, sans-serif;
        ///        }
        ///    &lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;h3&gt;Opening a specific member&lt;/h3&gt;
        ///    &lt;ol&gt;
        ///        &lt;li&gt;Select the File dropdown&lt;/li&gt;
        ///        &lt;li&gt;Select Open&lt;/li&gt;
        ///        &lt;li&gt;Select Member&lt;/li&gt;
        ///    &lt;/ol&gt;
        ///    &lt;p&gt;Or use the Ctrl+O shortcut to open the same window.&lt;/p&gt;
        ///
        ///    &lt;h3&gt;Opening a me [rest of string was truncated]&quot;;.
        /// </summary>
        public static string OpenMember {
            get {
                return ResourceManager.GetString("OpenMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap redo {
            get {
                object obj = ResourceManager.GetObject("redo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap refresh {
            get {
                object obj = ResourceManager.GetObject("refresh", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap save {
            get {
                object obj = ResourceManager.GetObject("save", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap script_add {
            get {
                object obj = ResourceManager.GetObject("script_add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap script_go {
            get {
                object obj = ResourceManager.GetObject("script_go", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap search {
            get {
                object obj = ResourceManager.GetObject("search", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap undo {
            get {
                object obj = ResourceManager.GetObject("undo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap zoom_in {
            get {
                object obj = ResourceManager.GetObject("zoom_in", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap zoom_out {
            get {
                object obj = ResourceManager.GetObject("zoom_out", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
