﻿#pragma checksum "C:\Users\Callum\Desktop\Windows-universal-samples-master\Windows-universal-samples-master\Samples\BluetoothLE\cs\Scenario2_Client.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5E161A7738D6B9CF77B6CC00EC2B8E12"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDKTemplate
{
    partial class Scenario2_Client : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Documents_Run_Text(global::Windows.UI.Xaml.Documents.Run obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Scenario2_Client_obj2_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IScenario2_Client_Bindings
        {
            private global::SDKTemplate.BluetoothLEAttributeDisplay dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;

            public Scenario2_Client_obj2_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Scenario2_Client.xaml line 23
                        this.obj2 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 3: // Scenario2_Client.xaml line 34
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // Scenario2_Client.xaml line 31
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj2.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::SDKTemplate.BluetoothLEAttributeDisplay) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IScenario2_Client_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::SDKTemplate.BluetoothLEAttributeDisplay)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SDKTemplate.BluetoothLEAttributeDisplay obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AttributeDisplayType(obj.AttributeDisplayType, phase);
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_AttributeDisplayType(global::SDKTemplate.AttributeType obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Scenario2_Client.xaml line 34
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj.ToString(), null);
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Scenario2_Client.xaml line 31
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Scenario2_Client_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IScenario2_Client_Bindings
        {
            private global::SDKTemplate.Scenario2_Client dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.ComboBox obj7;
            private global::Windows.UI.Xaml.Controls.ComboBox obj8;
            private global::Windows.UI.Xaml.Controls.Button obj12;
            private global::Windows.UI.Xaml.Controls.Button obj13;
            private global::Windows.UI.Xaml.Controls.Button obj14;
            private global::Windows.UI.Xaml.Controls.Button obj15;
            private global::Windows.UI.Xaml.Documents.Run obj16;

            public Scenario2_Client_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Scenario2_Client.xaml line 53
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.OnConnect();
                        };
                        break;
                    case 6: // Scenario2_Client.xaml line 54
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ConnectButton_Click();
                        };
                        break;
                    case 7: // Scenario2_Client.xaml line 55
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        ((global::Windows.UI.Xaml.Controls.ComboBox)target).SelectionChanged += (global::System.Object sender, global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e) =>
                        {
                            this.dataRoot.ServiceList_SelectionChanged();
                        };
                        break;
                    case 8: // Scenario2_Client.xaml line 58
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        ((global::Windows.UI.Xaml.Controls.ComboBox)target).SelectionChanged += (global::System.Object sender, global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e) =>
                        {
                            this.dataRoot.CharacteristicList_SelectionChanged();
                        };
                        break;
                    case 12: // Scenario2_Client.xaml line 69
                        this.obj12 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.CharacteristicWriteButtonInt_Click();
                        };
                        break;
                    case 13: // Scenario2_Client.xaml line 70
                        this.obj13 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.CharacteristicWriteButton_Click();
                        };
                        break;
                    case 14: // Scenario2_Client.xaml line 62
                        this.obj14 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.CharacteristicReadButton_Click();
                        };
                        break;
                    case 15: // Scenario2_Client.xaml line 64
                        this.obj15 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot.ValueChangedSubscribeToggle_Click();
                        };
                        break;
                    case 16: // Scenario2_Client.xaml line 51
                        this.obj16 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    default:
                        break;
                }
            }

            // IScenario2_Client_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::SDKTemplate.Scenario2_Client)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SDKTemplate.Scenario2_Client obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ServiceCollection(obj.ServiceCollection, phase);
                        this.Update_CharacteristicCollection(obj.CharacteristicCollection, phase);
                        this.Update_rootPage(obj.rootPage, phase);
                    }
                }
            }
            private void Update_ServiceCollection(global::System.Collections.ObjectModel.ObservableCollection<global::SDKTemplate.BluetoothLEAttributeDisplay> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Scenario2_Client.xaml line 55
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_CharacteristicCollection(global::System.Collections.ObjectModel.ObservableCollection<global::SDKTemplate.BluetoothLEAttributeDisplay> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Scenario2_Client.xaml line 58
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                }
            }
            private void Update_rootPage(global::SDKTemplate.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_rootPage_SelectedBleDeviceName(obj.SelectedBleDeviceName, phase);
                    }
                }
            }
            private void Update_rootPage_SelectedBleDeviceName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Scenario2_Client.xaml line 51
                    XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj16, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 5: // Scenario2_Client.xaml line 53
                {
                    this.wsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // Scenario2_Client.xaml line 54
                {
                    this.ConnectButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Scenario2_Client.xaml line 55
                {
                    this.ServiceList = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 8: // Scenario2_Client.xaml line 58
                {
                    this.CharacteristicList = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9: // Scenario2_Client.xaml line 67
                {
                    this.CharacteristicWritePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10: // Scenario2_Client.xaml line 72
                {
                    this.CharacteristicLatestValue = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Scenario2_Client.xaml line 68
                {
                    this.CharacteristicWriteValue = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // Scenario2_Client.xaml line 62
                {
                    this.CharacteristicReadButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 15: // Scenario2_Client.xaml line 64
                {
                    this.ValueChangedSubscribeToggle = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Scenario2_Client.xaml line 13
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Scenario2_Client_obj1_Bindings bindings = new Scenario2_Client_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 2: // Scenario2_Client.xaml line 23
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Scenario2_Client_obj2_Bindings bindings = new Scenario2_Client_obj2_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element2.DataContext);
                    element2.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element2, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element2, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

