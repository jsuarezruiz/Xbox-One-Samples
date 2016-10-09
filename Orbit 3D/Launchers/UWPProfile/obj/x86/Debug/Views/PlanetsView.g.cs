﻿#pragma checksum "C:\Microsoft Tech Summit 2016\Samples\Orbit 3D\Launchers\UWPProfile\Views\PlanetsView.DeviceFamily-Xbox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1AE69657C1916EFE2991026D2E164682"
#pragma checksum "C:\Microsoft Tech Summit 2016\Samples\Orbit 3D\Launchers\UWPProfile\Views\PlanetsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E51265A0BF1E96AC4FD115ABE7457014"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orbit.Views
{
    partial class PlanetsView : 
        global::Orbit.Views.Base.PageBase, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Orbit_Controls_TimelineStory_Item(global::Orbit.Controls.TimelineStory obj, global::Orbit.Models.Planet value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Orbit.Models.Planet) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Orbit.Models.Planet), targetNullValue);
                }
                obj.Item = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Orbit_Helpers_Composition_CompositionImage_Source(global::Orbit.Helpers.Composition.CompositionImage obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class PlanetsView_obj3_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPlanetsView_Bindings
        {
            private global::Orbit.Models.Planet dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Orbit.Controls.TimelineStory obj4;

            public PlanetsView_obj3_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Orbit.Controls.TimelineStory)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Orbit.Controls.TimelineItem)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Orbit.Models.Planet) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IPlanetsView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Orbit.Models.Planet)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Orbit.Models.Planet obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Orbit_Controls_TimelineStory_Item(this.obj4, obj, null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class PlanetsView_obj5_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPlanetsView_Bindings
        {
            private global::Orbit.Models.Planet dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Orbit.Helpers.Composition.CompositionImage obj12;

            public PlanetsView_obj5_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12:
                        this.obj12 = (global::Orbit.Helpers.Composition.CompositionImage)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Orbit.Models.Planet) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IPlanetsView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Orbit.Models.Planet)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Orbit.Models.Planet obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_SunDistance(obj.SunDistance, phase);
                        this.Update_Temperature(obj.Temperature, phase);
                        this.Update_Diameter(obj.Diameter, phase);
                        this.Update_Name(obj.Name, phase);
                        this.Update_Description(obj.Description, phase);
                        this.Update_Image(obj.Image, phase);
                    }
                }
            }
            private void Update_SunDistance(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj.ToString(), null);
                }
            }
            private void Update_Temperature(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                }
            }
            private void Update_Diameter(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj.ToString(), null);
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                }
            }
            private void Update_Image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Orbit_Helpers_Composition_CompositionImage_Source(this.obj12, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.RootElement = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.Timeline = (global::Orbit.Controls.Timeline)(target);
                    #line 19 "..\..\..\Views\PlanetsView.DeviceFamily-Xbox.xaml"
                    ((global::Orbit.Controls.Timeline)this.Timeline).Loaded += this.Timeline_Loaded;
                    #line 20 "..\..\..\Views\PlanetsView.DeviceFamily-Xbox.xaml"
                    ((global::Orbit.Controls.Timeline)this.Timeline).ItemInvoked += this.Timeline_ItemInvoked;
                    #line 21 "..\..\..\Views\PlanetsView.DeviceFamily-Xbox.xaml"
                    ((global::Orbit.Controls.Timeline)this.Timeline).KeyDown += this.Timeline_KeyDown;
                    #line 22 "..\..\..\Views\PlanetsView.DeviceFamily-Xbox.xaml"
                    ((global::Orbit.Controls.Timeline)this.Timeline).GotFocus += this.Timeline_GotFocus;
                    #line 23 "..\..\..\Views\PlanetsView.DeviceFamily-Xbox.xaml"
                    ((global::Orbit.Controls.Timeline)this.Timeline).LostFocus += this.Timeline_LostFocus;
                    #line default
                }
                break;
            case 3:
                {
                    global::Orbit.Controls.TimelineItem element3 = (global::Orbit.Controls.TimelineItem)(target);
                    #line 29 "..\..\..\Views\PlanetsView.DeviceFamily-Xbox.xaml"
                    ((global::Orbit.Controls.TimelineItem)element3).ItemGotFocus += this.TimelineItem_ItemGotFocus;
                    #line 30 "..\..\..\Views\PlanetsView.DeviceFamily-Xbox.xaml"
                    ((global::Orbit.Controls.TimelineItem)element3).ItemLostFocus += this.TimelineItem_ItemLostFocus;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Grid element5 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 19 "..\..\..\Views\PlanetsView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element5).SizeChanged += this.Template_SizeChanged;
                    #line 20 "..\..\..\Views\PlanetsView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element5).Loaded += this.Template_Loaded;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.Grid element6 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 44 "..\..\..\Views\PlanetsView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element6).Loaded += this.Grid_Loaded;
                    #line default
                }
                break;
            case 13:
                {
                    this.RootElement = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14:
                {
                    this.ItemListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 155 "..\..\..\Views\PlanetsView.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ItemListView).ItemClick += this.ListView_ItemClick;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 3:
                {
                    global::Orbit.Controls.TimelineItem element3 = (global::Orbit.Controls.TimelineItem)target;
                    PlanetsView_obj3_Bindings bindings = new PlanetsView_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Grid element5 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    PlanetsView_obj5_Bindings bindings = new PlanetsView_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element5.DataContext);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
