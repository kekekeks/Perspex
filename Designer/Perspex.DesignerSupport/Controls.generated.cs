namespace Perspex.DesignerSupport
{
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Border :  IWpfWrapper
	{
		public  Perspex.Controls.Border _base   = new Perspex.Controls.Border();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.Single CornerRadius
		{
			get
			{
				return _base.CornerRadius;
			}
			set
			{
				_base.CornerRadius = value;
			}
		}
		public  Perspex.Controls.Control Child
		{
			get
			{
				return _base.Child;
			}
			set
			{
				_base.Child = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class MenuItem :  IWpfWrapper
	{
		public  Perspex.Controls.MenuItem _base   = new Perspex.Controls.MenuItem();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Windows.Input.ICommand Command
		{
			get
			{
				return _base.Command;
			}
			set
			{
				_base.Command = value;
			}
		}
		public  System.Object CommandParameter
		{
			get
			{
				return _base.CommandParameter;
			}
			set
			{
				_base.CommandParameter = value;
			}
		}
		public  System.Object Header
		{
			get
			{
				return _base.Header;
			}
			set
			{
				_base.Header = value;
			}
		}
		public  System.Object Icon
		{
			get
			{
				return _base.Icon;
			}
			set
			{
				_base.Icon = value;
			}
		}
		public  System.Boolean IsSelected
		{
			get
			{
				return _base.IsSelected;
			}
			set
			{
				_base.IsSelected = value;
			}
		}
		public  System.Boolean IsSubMenuOpen
		{
			get
			{
				return _base.IsSubMenuOpen;
			}
			set
			{
				_base.IsSubMenuOpen = value;
			}
		}
		public  System.Boolean HasSubMenu
		{
			get
			{
				return _base.HasSubMenu;
			}
		}
		public  System.Boolean IsTopLevel
		{
			get
			{
				return _base.IsTopLevel;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Menu :  IWpfWrapper
	{
		public  Perspex.Controls.Menu _base   = new Perspex.Controls.Menu();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean IsOpen
		{
			get
			{
				return _base.IsOpen;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Button :  IWpfWrapper
	{
		public  Perspex.Controls.Button _base   = new Perspex.Controls.Button();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.ClickMode ClickMode
		{
			get
			{
				return _base.ClickMode;
			}
			set
			{
				_base.ClickMode = value;
			}
		}
		public  System.Windows.Input.ICommand Command
		{
			get
			{
				return _base.Command;
			}
			set
			{
				_base.Command = value;
			}
		}
		public  System.Object CommandParameter
		{
			get
			{
				return _base.CommandParameter;
			}
			set
			{
				_base.CommandParameter = value;
			}
		}
		public  System.Boolean IsDefault
		{
			get
			{
				return _base.IsDefault;
			}
			set
			{
				_base.IsDefault = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class DropDown :  IWpfWrapper
	{
		public  Perspex.Controls.DropDown _base   = new Perspex.Controls.DropDown();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  System.Boolean IsDropDownOpen
		{
			get
			{
				return _base.IsDropDownOpen;
			}
			set
			{
				_base.IsDropDownOpen = value;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Deck :  IWpfWrapper
	{
		public  Perspex.Controls.Deck _base   = new Perspex.Controls.Deck();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Animation.IPageTransition Transition
		{
			get
			{
				return _base.Transition;
			}
			set
			{
				_base.Transition = value;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ProgressBar :  IWpfWrapper
	{
		public  Perspex.Controls.ProgressBar _base   = new Perspex.Controls.ProgressBar();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Double Minimum
		{
			get
			{
				return _base.Minimum;
			}
			set
			{
				_base.Minimum = value;
			}
		}
		public  System.Double Maximum
		{
			get
			{
				return _base.Maximum;
			}
			set
			{
				_base.Maximum = value;
			}
		}
		public  System.Double Value
		{
			get
			{
				return _base.Value;
			}
			set
			{
				_base.Value = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class RadioButton :  IWpfWrapper
	{
		public  Perspex.Controls.RadioButton _base   = new Perspex.Controls.RadioButton();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean IsChecked
		{
			get
			{
				return _base.IsChecked;
			}
			set
			{
				_base.IsChecked = value;
			}
		}
		public  Perspex.Controls.ClickMode ClickMode
		{
			get
			{
				return _base.ClickMode;
			}
			set
			{
				_base.ClickMode = value;
			}
		}
		public  System.Windows.Input.ICommand Command
		{
			get
			{
				return _base.Command;
			}
			set
			{
				_base.Command = value;
			}
		}
		public  System.Object CommandParameter
		{
			get
			{
				return _base.CommandParameter;
			}
			set
			{
				_base.CommandParameter = value;
			}
		}
		public  System.Boolean IsDefault
		{
			get
			{
				return _base.IsDefault;
			}
			set
			{
				_base.IsDefault = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class CheckBox :  IWpfWrapper
	{
		public  Perspex.Controls.CheckBox _base   = new Perspex.Controls.CheckBox();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean IsChecked
		{
			get
			{
				return _base.IsChecked;
			}
			set
			{
				_base.IsChecked = value;
			}
		}
		public  Perspex.Controls.ClickMode ClickMode
		{
			get
			{
				return _base.ClickMode;
			}
			set
			{
				_base.ClickMode = value;
			}
		}
		public  System.Windows.Input.ICommand Command
		{
			get
			{
				return _base.Command;
			}
			set
			{
				_base.Command = value;
			}
		}
		public  System.Object CommandParameter
		{
			get
			{
				return _base.CommandParameter;
			}
			set
			{
				_base.CommandParameter = value;
			}
		}
		public  System.Boolean IsDefault
		{
			get
			{
				return _base.IsDefault;
			}
			set
			{
				_base.IsDefault = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ColumnDefinition :  IWpfWrapper
	{
		public  Perspex.Controls.ColumnDefinition _base   = new Perspex.Controls.ColumnDefinition();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Double ActualWidth
		{
			get
			{
				return _base.ActualWidth;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  Perspex.Controls.GridLength Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.String SharedSizeGroup
		{
			get
			{
				return _base.SharedSizeGroup;
			}
			set
			{
				_base.SharedSizeGroup = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ContentControl :  IWpfWrapper
	{
		public  Perspex.Controls.ContentControl _base   = new Perspex.Controls.ContentControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class GridSplitter :  IWpfWrapper
	{
		public  Perspex.Controls.GridSplitter _base   = new Perspex.Controls.GridSplitter();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ListBoxItem :  IWpfWrapper
	{
		public  Perspex.Controls.ListBoxItem _base   = new Perspex.Controls.ListBoxItem();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean IsSelected
		{
			get
			{
				return _base.IsSelected;
			}
			set
			{
				_base.IsSelected = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ListBox :  IWpfWrapper
	{
		public  Perspex.Controls.ListBox _base   = new Perspex.Controls.ListBox();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Control :  IWpfWrapper
	{
		public  Perspex.Controls.Control _base   = new Perspex.Controls.Control();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Decorator :  IWpfWrapper
	{
		public  Perspex.Controls.Decorator _base   = new Perspex.Controls.Decorator();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Control Child
		{
			get
			{
				return _base.Child;
			}
			set
			{
				_base.Child = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class DefinitionBase :  IWpfWrapper
	{
		public  Perspex.Controls.DefinitionBase _base   = new Perspex.Controls.DefinitionBase();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.String SharedSizeGroup
		{
			get
			{
				return _base.SharedSizeGroup;
			}
			set
			{
				_base.SharedSizeGroup = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Grid :  IWpfWrapper
	{
		public  Perspex.Controls.Grid _base   = new Perspex.Controls.Grid();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.ColumnDefinitions ColumnDefinitions
		{
			get
			{
				return _base.ColumnDefinitions;
			}
			set
			{
				_base.ColumnDefinitions = value;
			}
		}
		public  Perspex.Controls.RowDefinitions RowDefinitions
		{
			get
			{
				return _base.RowDefinitions;
			}
			set
			{
				_base.RowDefinitions = value;
			}
		}
		public  Perspex.Controls.Controls Children
		{
			get
			{
				return _base.Children;
			}
			set
			{
				_base.Children = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Image :  IWpfWrapper
	{
		public  Perspex.Controls.Image _base   = new Perspex.Controls.Image();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Imaging.Bitmap Source
		{
			get
			{
				return _base.Source;
			}
			set
			{
				_base.Source = value;
			}
		}
		public  Perspex.Media.Stretch Stretch
		{
			get
			{
				return _base.Stretch;
			}
			set
			{
				_base.Stretch = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ItemsControl :  IWpfWrapper
	{
		public  Perspex.Controls.ItemsControl _base   = new Perspex.Controls.ItemsControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Panel :  IWpfWrapper
	{
		public  Perspex.Controls.Panel _base   = new Perspex.Controls.Panel();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Controls Children
		{
			get
			{
				return _base.Children;
			}
			set
			{
				_base.Children = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ToolTip :  IWpfWrapper
	{
		public  Perspex.Controls.ToolTip _base   = new Perspex.Controls.ToolTip();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class UserControl :  IWpfWrapper
	{
		public  Perspex.Controls.UserControl _base   = new Perspex.Controls.UserControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	public partial class Window :  IWpfWrapper
	{
		public  Perspex.Controls.Window _base   = new Perspex.Controls.Window();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Platform.IWindowImpl PlatformImpl
		{
			get
			{
				return _base.PlatformImpl;
			}
		}
		public  Perspex.Controls.SizeToContent SizeToContent
		{
			get
			{
				return _base.SizeToContent;
			}
			set
			{
				_base.SizeToContent = value;
			}
		}
		public  System.String Title
		{
			get
			{
				return _base.Title;
			}
			set
			{
				_base.Title = value;
			}
		}
		public  Perspex.Size ClientSize
		{
			get
			{
				return _base.ClientSize;
			}
		}
		public  System.Boolean IsActive
		{
			get
			{
				return _base.IsActive;
			}
		}
		public  Perspex.Layout.ILayoutManager LayoutManager
		{
			get
			{
				return _base.LayoutManager;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class RowDefinition :  IWpfWrapper
	{
		public  Perspex.Controls.RowDefinition _base   = new Perspex.Controls.RowDefinition();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Double ActualHeight
		{
			get
			{
				return _base.ActualHeight;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  Perspex.Controls.GridLength Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.String SharedSizeGroup
		{
			get
			{
				return _base.SharedSizeGroup;
			}
			set
			{
				_base.SharedSizeGroup = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ScrollViewer :  IWpfWrapper
	{
		public  Perspex.Controls.ScrollViewer _base   = new Perspex.Controls.ScrollViewer();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Size Extent
		{
			get
			{
				return _base.Extent;
			}
		}
		public  Perspex.Vector Offset
		{
			get
			{
				return _base.Offset;
			}
			set
			{
				_base.Offset = value;
			}
		}
		public  Perspex.Size Viewport
		{
			get
			{
				return _base.Viewport;
			}
		}
		public  System.Boolean CanScrollHorizontally
		{
			get
			{
				return _base.CanScrollHorizontally;
			}
			set
			{
				_base.CanScrollHorizontally = value;
			}
		}
		public  Perspex.Controls.Primitives.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return _base.HorizontalScrollBarVisibility;
			}
			set
			{
				_base.HorizontalScrollBarVisibility = value;
			}
		}
		public  Perspex.Controls.Primitives.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return _base.VerticalScrollBarVisibility;
			}
			set
			{
				_base.VerticalScrollBarVisibility = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class StackPanel :  IWpfWrapper
	{
		public  Perspex.Controls.StackPanel _base   = new Perspex.Controls.StackPanel();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Double Gap
		{
			get
			{
				return _base.Gap;
			}
			set
			{
				_base.Gap = value;
			}
		}
		public  Perspex.Controls.Orientation Orientation
		{
			get
			{
				return _base.Orientation;
			}
			set
			{
				_base.Orientation = value;
			}
		}
		public  Perspex.Controls.Controls Children
		{
			get
			{
				return _base.Children;
			}
			set
			{
				_base.Children = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TabControl :  IWpfWrapper
	{
		public  Perspex.Controls.TabControl _base   = new Perspex.Controls.TabControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.TabItem SelectedTab
		{
			get
			{
				return _base.SelectedTab;
			}
		}
		public  Perspex.Animation.IPageTransition Transition
		{
			get
			{
				return _base.Transition;
			}
			set
			{
				_base.Transition = value;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TabItem :  IWpfWrapper
	{
		public  Perspex.Controls.TabItem _base   = new Perspex.Controls.TabItem();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean IsSelected
		{
			get
			{
				return _base.IsSelected;
			}
			set
			{
				_base.IsSelected = value;
			}
		}
		public  System.Object Header
		{
			get
			{
				return _base.Header;
			}
			set
			{
				_base.Header = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TextBlock :  IWpfWrapper
	{
		public  Perspex.Controls.TextBlock _base   = new Perspex.Controls.TextBlock();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  System.String Text
		{
			get
			{
				return _base.Text;
			}
			set
			{
				_base.Text = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.FontWeight FontWeight
		{
			get
			{
				return _base.FontWeight;
			}
			set
			{
				_base.FontWeight = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Media.FormattedText FormattedText
		{
			get
			{
				return _base.FormattedText;
			}
		}
		public  Perspex.Controls.TextWrapping TextWrapping
		{
			get
			{
				return _base.TextWrapping;
			}
			set
			{
				_base.TextWrapping = value;
			}
		}
		public  Perspex.Media.TextAlignment TextAlignment
		{
			get
			{
				return _base.TextAlignment;
			}
			set
			{
				_base.TextAlignment = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TextBox :  IWpfWrapper
	{
		public  Perspex.Controls.TextBox _base   = new Perspex.Controls.TextBox();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean AcceptsReturn
		{
			get
			{
				return _base.AcceptsReturn;
			}
			set
			{
				_base.AcceptsReturn = value;
			}
		}
		public  System.Boolean AcceptsTab
		{
			get
			{
				return _base.AcceptsTab;
			}
			set
			{
				_base.AcceptsTab = value;
			}
		}
		public  System.Int32 CaretIndex
		{
			get
			{
				return _base.CaretIndex;
			}
			set
			{
				_base.CaretIndex = value;
			}
		}
		public  System.Int32 SelectionStart
		{
			get
			{
				return _base.SelectionStart;
			}
			set
			{
				_base.SelectionStart = value;
			}
		}
		public  System.Int32 SelectionEnd
		{
			get
			{
				return _base.SelectionEnd;
			}
			set
			{
				_base.SelectionEnd = value;
			}
		}
		public  System.String Text
		{
			get
			{
				return _base.Text;
			}
			set
			{
				_base.Text = value;
			}
		}
		public  Perspex.Controls.TextWrapping TextWrapping
		{
			get
			{
				return _base.TextWrapping;
			}
			set
			{
				_base.TextWrapping = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TreeView :  IWpfWrapper
	{
		public  Perspex.Controls.TreeView _base   = new Perspex.Controls.TreeView();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Generators.ITreeItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TreeViewItem :  IWpfWrapper
	{
		public  Perspex.Controls.TreeViewItem _base   = new Perspex.Controls.TreeViewItem();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean IsExpanded
		{
			get
			{
				return _base.IsExpanded;
			}
			set
			{
				_base.IsExpanded = value;
			}
		}
		public  System.Boolean IsSelected
		{
			get
			{
				return _base.IsSelected;
			}
			set
			{
				_base.IsSelected = value;
			}
		}
		public  System.Object Header
		{
			get
			{
				return _base.Header;
			}
			set
			{
				_base.Header = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Ellipse :  IWpfWrapper
	{
		public  Perspex.Controls.Shapes.Ellipse _base   = new Perspex.Controls.Shapes.Ellipse();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Geometry DefiningGeometry
		{
			get
			{
				return _base.DefiningGeometry;
			}
		}
		public  Perspex.Media.Brush Fill
		{
			get
			{
				return _base.Fill;
			}
			set
			{
				_base.Fill = value;
			}
		}
		public  Perspex.Media.Geometry RenderedGeometry
		{
			get
			{
				return _base.RenderedGeometry;
			}
		}
		public  Perspex.Media.Stretch Stretch
		{
			get
			{
				return _base.Stretch;
			}
			set
			{
				_base.Stretch = value;
			}
		}
		public  Perspex.Media.Brush Stroke
		{
			get
			{
				return _base.Stroke;
			}
			set
			{
				_base.Stroke = value;
			}
		}
		public  Perspex.Collections.PerspexList<System.Double> StrokeDashArray
		{
			get
			{
				return _base.StrokeDashArray;
			}
			set
			{
				_base.StrokeDashArray = value;
			}
		}
		public  System.Double StrokeThickness
		{
			get
			{
				return _base.StrokeThickness;
			}
			set
			{
				_base.StrokeThickness = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Path :  IWpfWrapper
	{
		public  Perspex.Controls.Shapes.Path _base   = new Perspex.Controls.Shapes.Path();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Geometry Data
		{
			get
			{
				return _base.Data;
			}
			set
			{
				_base.Data = value;
			}
		}
		public  Perspex.Media.Geometry DefiningGeometry
		{
			get
			{
				return _base.DefiningGeometry;
			}
		}
		public  Perspex.Media.Brush Fill
		{
			get
			{
				return _base.Fill;
			}
			set
			{
				_base.Fill = value;
			}
		}
		public  Perspex.Media.Geometry RenderedGeometry
		{
			get
			{
				return _base.RenderedGeometry;
			}
		}
		public  Perspex.Media.Stretch Stretch
		{
			get
			{
				return _base.Stretch;
			}
			set
			{
				_base.Stretch = value;
			}
		}
		public  Perspex.Media.Brush Stroke
		{
			get
			{
				return _base.Stroke;
			}
			set
			{
				_base.Stroke = value;
			}
		}
		public  Perspex.Collections.PerspexList<System.Double> StrokeDashArray
		{
			get
			{
				return _base.StrokeDashArray;
			}
			set
			{
				_base.StrokeDashArray = value;
			}
		}
		public  System.Double StrokeThickness
		{
			get
			{
				return _base.StrokeThickness;
			}
			set
			{
				_base.StrokeThickness = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Rectangle :  IWpfWrapper
	{
		public  Perspex.Controls.Shapes.Rectangle _base   = new Perspex.Controls.Shapes.Rectangle();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Geometry DefiningGeometry
		{
			get
			{
				return _base.DefiningGeometry;
			}
		}
		public  Perspex.Media.Brush Fill
		{
			get
			{
				return _base.Fill;
			}
			set
			{
				_base.Fill = value;
			}
		}
		public  Perspex.Media.Geometry RenderedGeometry
		{
			get
			{
				return _base.RenderedGeometry;
			}
		}
		public  Perspex.Media.Stretch Stretch
		{
			get
			{
				return _base.Stretch;
			}
			set
			{
				_base.Stretch = value;
			}
		}
		public  Perspex.Media.Brush Stroke
		{
			get
			{
				return _base.Stroke;
			}
			set
			{
				_base.Stroke = value;
			}
		}
		public  Perspex.Collections.PerspexList<System.Double> StrokeDashArray
		{
			get
			{
				return _base.StrokeDashArray;
			}
			set
			{
				_base.StrokeDashArray = value;
			}
		}
		public  System.Double StrokeThickness
		{
			get
			{
				return _base.StrokeThickness;
			}
			set
			{
				_base.StrokeThickness = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class AccessText :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.AccessText _base   = new Perspex.Controls.Primitives.AccessText();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Char AccessKey
		{
			get
			{
				return _base.AccessKey;
			}
		}
		public  System.Boolean ShowAccessKey
		{
			get
			{
				return _base.ShowAccessKey;
			}
			set
			{
				_base.ShowAccessKey = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  System.String Text
		{
			get
			{
				return _base.Text;
			}
			set
			{
				_base.Text = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.FontWeight FontWeight
		{
			get
			{
				return _base.FontWeight;
			}
			set
			{
				_base.FontWeight = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Media.FormattedText FormattedText
		{
			get
			{
				return _base.FormattedText;
			}
		}
		public  Perspex.Controls.TextWrapping TextWrapping
		{
			get
			{
				return _base.TextWrapping;
			}
			set
			{
				_base.TextWrapping = value;
			}
		}
		public  Perspex.Media.TextAlignment TextAlignment
		{
			get
			{
				return _base.TextAlignment;
			}
			set
			{
				_base.TextAlignment = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Popup :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.Popup _base   = new Perspex.Controls.Primitives.Popup();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Control Child
		{
			get
			{
				return _base.Child;
			}
			set
			{
				_base.Child = value;
			}
		}
		public  System.Boolean IsOpen
		{
			get
			{
				return _base.IsOpen;
			}
			set
			{
				_base.IsOpen = value;
			}
		}
		public  Perspex.Controls.PlacementMode PlacementMode
		{
			get
			{
				return _base.PlacementMode;
			}
			set
			{
				_base.PlacementMode = value;
			}
		}
		public  Perspex.Controls.Control PlacementTarget
		{
			get
			{
				return _base.PlacementTarget;
			}
			set
			{
				_base.PlacementTarget = value;
			}
		}
		public  Perspex.Controls.Primitives.PopupRoot PopupRoot
		{
			get
			{
				return _base.PopupRoot;
			}
		}
		public  System.Boolean StaysOpen
		{
			get
			{
				return _base.StaysOpen;
			}
			set
			{
				_base.StaysOpen = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class AdornerDecorator :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.AdornerDecorator _base   = new Perspex.Controls.Primitives.AdornerDecorator();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Primitives.AdornerLayer AdornerLayer
		{
			get
			{
				return _base.AdornerLayer;
			}
		}
		public  Perspex.Controls.Control Child
		{
			get
			{
				return _base.Child;
			}
			set
			{
				_base.Child = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class AdornerLayer :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.AdornerLayer _base   = new Perspex.Controls.Primitives.AdornerLayer();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Controls Children
		{
			get
			{
				return _base.Children;
			}
			set
			{
				_base.Children = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class HeaderedContentControl :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.HeaderedContentControl _base   = new Perspex.Controls.Primitives.HeaderedContentControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Object Header
		{
			get
			{
				return _base.Header;
			}
			set
			{
				_base.Header = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class HeaderedItemsControl :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.HeaderedItemsControl _base   = new Perspex.Controls.Primitives.HeaderedItemsControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Object Header
		{
			get
			{
				return _base.Header;
			}
			set
			{
				_base.Header = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Track :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.Track _base   = new Perspex.Controls.Primitives.Track();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Double Minimum
		{
			get
			{
				return _base.Minimum;
			}
			set
			{
				_base.Minimum = value;
			}
		}
		public  System.Double Maximum
		{
			get
			{
				return _base.Maximum;
			}
			set
			{
				_base.Maximum = value;
			}
		}
		public  System.Double Value
		{
			get
			{
				return _base.Value;
			}
			set
			{
				_base.Value = value;
			}
		}
		public  System.Double ViewportSize
		{
			get
			{
				return _base.ViewportSize;
			}
			set
			{
				_base.ViewportSize = value;
			}
		}
		public  Perspex.Controls.Orientation Orientation
		{
			get
			{
				return _base.Orientation;
			}
			set
			{
				_base.Orientation = value;
			}
		}
		public  Perspex.Controls.Primitives.Thumb Thumb
		{
			get
			{
				return _base.Thumb;
			}
			set
			{
				_base.Thumb = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class Thumb :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.Thumb _base   = new Perspex.Controls.Primitives.Thumb();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class PopupRoot :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.PopupRoot _base   = new Perspex.Controls.Primitives.PopupRoot();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Platform.IPopupImpl PlatformImpl
		{
			get
			{
				return _base.PlatformImpl;
			}
		}
		public  Perspex.Size ClientSize
		{
			get
			{
				return _base.ClientSize;
			}
		}
		public  System.Boolean IsActive
		{
			get
			{
				return _base.IsActive;
			}
		}
		public  Perspex.Layout.ILayoutManager LayoutManager
		{
			get
			{
				return _base.LayoutManager;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class SelectingItemsControl :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.SelectingItemsControl _base   = new Perspex.Controls.Primitives.SelectingItemsControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ScrollBar :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.ScrollBar _base   = new Perspex.Controls.Primitives.ScrollBar();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Double ViewportSize
		{
			get
			{
				return _base.ViewportSize;
			}
			set
			{
				_base.ViewportSize = value;
			}
		}
		public  Perspex.Controls.Primitives.ScrollBarVisibility Visibility
		{
			get
			{
				return _base.Visibility;
			}
			set
			{
				_base.Visibility = value;
			}
		}
		public  Perspex.Controls.Orientation Orientation
		{
			get
			{
				return _base.Orientation;
			}
			set
			{
				_base.Orientation = value;
			}
		}
		public  System.Double Minimum
		{
			get
			{
				return _base.Minimum;
			}
			set
			{
				_base.Minimum = value;
			}
		}
		public  System.Double Maximum
		{
			get
			{
				return _base.Maximum;
			}
			set
			{
				_base.Maximum = value;
			}
		}
		public  System.Double Value
		{
			get
			{
				return _base.Value;
			}
			set
			{
				_base.Value = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TabStrip :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.TabStrip _base   = new Perspex.Controls.Primitives.TabStrip();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.TabItem SelectedTab
		{
			get
			{
				return _base.SelectedTab;
			}
			set
			{
				_base.SelectedTab = value;
			}
		}
		public  System.Boolean AutoSelect
		{
			get
			{
				return _base.AutoSelect;
			}
			set
			{
				_base.AutoSelect = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  System.Object SelectedItem
		{
			get
			{
				return _base.SelectedItem;
			}
			set
			{
				_base.SelectedItem = value;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.Presenters.IItemsPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
			set
			{
				_base.Presenter = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TemplatedControl :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.TemplatedControl _base   = new Perspex.Controls.Primitives.TemplatedControl();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ToggleButton :  IWpfWrapper
	{
		public  Perspex.Controls.Primitives.ToggleButton _base   = new Perspex.Controls.Primitives.ToggleButton();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Boolean IsChecked
		{
			get
			{
				return _base.IsChecked;
			}
			set
			{
				_base.IsChecked = value;
			}
		}
		public  Perspex.Controls.ClickMode ClickMode
		{
			get
			{
				return _base.ClickMode;
			}
			set
			{
				_base.ClickMode = value;
			}
		}
		public  System.Windows.Input.ICommand Command
		{
			get
			{
				return _base.Command;
			}
			set
			{
				_base.Command = value;
			}
		}
		public  System.Object CommandParameter
		{
			get
			{
				return _base.CommandParameter;
			}
			set
			{
				_base.CommandParameter = value;
			}
		}
		public  System.Boolean IsDefault
		{
			get
			{
				return _base.IsDefault;
			}
			set
			{
				_base.IsDefault = value;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Controls.Presenters.ContentPresenter Presenter
		{
			get
			{
				return _base.Presenter;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return _base.HorizontalContentAlignment;
			}
			set
			{
				_base.HorizontalContentAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return _base.VerticalContentAlignment;
			}
			set
			{
				_base.VerticalContentAlignment = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  Perspex.Media.Brush BorderBrush
		{
			get
			{
				return _base.BorderBrush;
			}
			set
			{
				_base.BorderBrush = value;
			}
		}
		public  System.Double BorderThickness
		{
			get
			{
				return _base.BorderThickness;
			}
			set
			{
				_base.BorderThickness = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Thickness Padding
		{
			get
			{
				return _base.Padding;
			}
			set
			{
				_base.Padding = value;
			}
		}
		public  Perspex.Controls.Templates.ControlTemplate Template
		{
			get
			{
				return _base.Template;
			}
			set
			{
				_base.Template = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class DeckPresenter :  IWpfWrapper
	{
		public  Perspex.Controls.Presenters.DeckPresenter _base   = new Perspex.Controls.Presenters.DeckPresenter();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
			set
			{
				_base.ItemContainerGenerator = value;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  System.Int32 SelectedIndex
		{
			get
			{
				return _base.SelectedIndex;
			}
			set
			{
				_base.SelectedIndex = value;
			}
		}
		public  Perspex.Controls.IPanel Panel
		{
			get
			{
				return _base.Panel;
			}
		}
		public  Perspex.Animation.IPageTransition Transition
		{
			get
			{
				return _base.Transition;
			}
			set
			{
				_base.Transition = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ScrollContentPresenter :  IWpfWrapper
	{
		public  Perspex.Controls.Presenters.ScrollContentPresenter _base   = new Perspex.Controls.Presenters.ScrollContentPresenter();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Size Extent
		{
			get
			{
				return _base.Extent;
			}
		}
		public  Perspex.Vector Offset
		{
			get
			{
				return _base.Offset;
			}
			set
			{
				_base.Offset = value;
			}
		}
		public  Perspex.Size Viewport
		{
			get
			{
				return _base.Viewport;
			}
		}
		public  System.Boolean CanScrollHorizontally
		{
			get
			{
				return _base.CanScrollHorizontally;
			}
		}
		public  Perspex.Controls.IControl Child
		{
			get
			{
				return _base.Child;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ContentPresenter :  IWpfWrapper
	{
		public  Perspex.Controls.Presenters.ContentPresenter _base   = new Perspex.Controls.Presenters.ContentPresenter();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.IControl Child
		{
			get
			{
				return _base.Child;
			}
		}
		public  System.Object Content
		{
			get
			{
				return _base.Content;
			}
			set
			{
				_base.Content = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class ItemsPresenter :  IWpfWrapper
	{
		public  Perspex.Controls.Presenters.ItemsPresenter _base   = new Perspex.Controls.Presenters.ItemsPresenter();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  Perspex.Controls.Generators.IItemContainerGenerator ItemContainerGenerator
		{
			get
			{
				return _base.ItemContainerGenerator;
			}
			set
			{
				_base.ItemContainerGenerator = value;
			}
		}
		public  System.Collections.IEnumerable Items
		{
			get
			{
				return _base.Items;
			}
			set
			{
				_base.Items = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IPanel> ItemsPanel
		{
			get
			{
				return _base.ItemsPanel;
			}
			set
			{
				_base.ItemsPanel = value;
			}
		}
		public  Perspex.Controls.IPanel Panel
		{
			get
			{
				return _base.Panel;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
	[System.Windows.Markup.ContentProperty( "WpfChildren") ]
	public partial class TextPresenter :  IWpfWrapper
	{
		public  Perspex.Controls.Presenters.TextPresenter _base   = new Perspex.Controls.Presenters.TextPresenter();
		public  System.Collections.ObjectModel.ObservableCollection<object> WpfChildren {get;set;}  = new System.Collections.ObjectModel.ObservableCollection<object>();
		public  object PerspexObject
		{
			get
			{
				return _base;
			}
		}
		public  System.Int32 CaretIndex
		{
			get
			{
				return _base.CaretIndex;
			}
			set
			{
				_base.CaretIndex = value;
			}
		}
		public  System.Int32 SelectionStart
		{
			get
			{
				return _base.SelectionStart;
			}
			set
			{
				_base.SelectionStart = value;
			}
		}
		public  System.Int32 SelectionEnd
		{
			get
			{
				return _base.SelectionEnd;
			}
			set
			{
				_base.SelectionEnd = value;
			}
		}
		public  Perspex.Media.Brush Background
		{
			get
			{
				return _base.Background;
			}
			set
			{
				_base.Background = value;
			}
		}
		public  System.String Text
		{
			get
			{
				return _base.Text;
			}
			set
			{
				_base.Text = value;
			}
		}
		public  System.String FontFamily
		{
			get
			{
				return _base.FontFamily;
			}
			set
			{
				_base.FontFamily = value;
			}
		}
		public  System.Double FontSize
		{
			get
			{
				return _base.FontSize;
			}
			set
			{
				_base.FontSize = value;
			}
		}
		public  Perspex.Media.FontStyle FontStyle
		{
			get
			{
				return _base.FontStyle;
			}
			set
			{
				_base.FontStyle = value;
			}
		}
		public  Perspex.Media.FontWeight FontWeight
		{
			get
			{
				return _base.FontWeight;
			}
			set
			{
				_base.FontWeight = value;
			}
		}
		public  Perspex.Media.Brush Foreground
		{
			get
			{
				return _base.Foreground;
			}
			set
			{
				_base.Foreground = value;
			}
		}
		public  Perspex.Media.FormattedText FormattedText
		{
			get
			{
				return _base.FormattedText;
			}
		}
		public  Perspex.Controls.TextWrapping TextWrapping
		{
			get
			{
				return _base.TextWrapping;
			}
			set
			{
				_base.TextWrapping = value;
			}
		}
		public  Perspex.Media.TextAlignment TextAlignment
		{
			get
			{
				return _base.TextAlignment;
			}
			set
			{
				_base.TextAlignment = value;
			}
		}
		public  Perspex.Styling.Classes Classes
		{
			get
			{
				return _base.Classes;
			}
			set
			{
				_base.Classes = value;
			}
		}
		public  System.Object DataContext
		{
			get
			{
				return _base.DataContext;
			}
			set
			{
				_base.DataContext = value;
			}
		}
		public  Perspex.Controls.ITemplate<Perspex.Controls.IControl> FocusAdorner
		{
			get
			{
				return _base.FocusAdorner;
			}
			set
			{
				_base.FocusAdorner = value;
			}
		}
		public  Perspex.Controls.Templates.DataTemplates DataTemplates
		{
			get
			{
				return _base.DataTemplates;
			}
			set
			{
				_base.DataTemplates = value;
			}
		}
		public  System.String Name
		{
			get
			{
				return _base.Name;
			}
			set
			{
				_base.Name = value;
			}
		}
		public  Perspex.Styling.Styles Styles
		{
			get
			{
				return _base.Styles;
			}
			set
			{
				_base.Styles = value;
			}
		}
		public  Perspex.Controls.IControl Parent
		{
			get
			{
				return _base.Parent;
			}
		}
		public  System.Object Tag
		{
			get
			{
				return _base.Tag;
			}
			set
			{
				_base.Tag = value;
			}
		}
		public  Perspex.Styling.ITemplatedControl TemplatedParent
		{
			get
			{
				return _base.TemplatedParent;
			}
		}
		public  System.Boolean Focusable
		{
			get
			{
				return _base.Focusable;
			}
			set
			{
				_base.Focusable = value;
			}
		}
		public  System.Boolean IsEnabled
		{
			get
			{
				return _base.IsEnabled;
			}
			set
			{
				_base.IsEnabled = value;
			}
		}
		public  System.Boolean IsFocused
		{
			get
			{
				return _base.IsFocused;
			}
		}
		public  System.Boolean IsHitTestVisible
		{
			get
			{
				return _base.IsHitTestVisible;
			}
			set
			{
				_base.IsHitTestVisible = value;
			}
		}
		public  System.Boolean IsPointerOver
		{
			get
			{
				return _base.IsPointerOver;
			}
		}
		public  System.Double Width
		{
			get
			{
				return _base.Width;
			}
			set
			{
				_base.Width = value;
			}
		}
		public  System.Double Height
		{
			get
			{
				return _base.Height;
			}
			set
			{
				_base.Height = value;
			}
		}
		public  System.Double MinWidth
		{
			get
			{
				return _base.MinWidth;
			}
			set
			{
				_base.MinWidth = value;
			}
		}
		public  System.Double MaxWidth
		{
			get
			{
				return _base.MaxWidth;
			}
			set
			{
				_base.MaxWidth = value;
			}
		}
		public  System.Double MinHeight
		{
			get
			{
				return _base.MinHeight;
			}
			set
			{
				_base.MinHeight = value;
			}
		}
		public  System.Double MaxHeight
		{
			get
			{
				return _base.MaxHeight;
			}
			set
			{
				_base.MaxHeight = value;
			}
		}
		public  Perspex.Thickness Margin
		{
			get
			{
				return _base.Margin;
			}
			set
			{
				_base.Margin = value;
			}
		}
		public  Perspex.Layout.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _base.HorizontalAlignment;
			}
			set
			{
				_base.HorizontalAlignment = value;
			}
		}
		public  Perspex.Layout.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _base.VerticalAlignment;
			}
			set
			{
				_base.VerticalAlignment = value;
			}
		}
		public  Perspex.Size DesiredSize
		{
			get
			{
				return _base.DesiredSize;
			}
			set
			{
				_base.DesiredSize = value;
			}
		}
		public  System.Boolean IsMeasureValid
		{
			get
			{
				return _base.IsMeasureValid;
			}
		}
		public  System.Boolean IsArrangeValid
		{
			get
			{
				return _base.IsArrangeValid;
			}
		}
		public  System.Boolean UseLayoutRounding
		{
			get
			{
				return _base.UseLayoutRounding;
			}
			set
			{
				_base.UseLayoutRounding = value;
			}
		}
		public  Perspex.Rect Bounds
		{
			get
			{
				return _base.Bounds;
			}
		}
		public  System.Boolean ClipToBounds
		{
			get
			{
				return _base.ClipToBounds;
			}
			set
			{
				_base.ClipToBounds = value;
			}
		}
		public  System.Boolean IsEffectivelyVisible
		{
			get
			{
				return _base.IsEffectivelyVisible;
			}
		}
		public  System.Boolean IsVisible
		{
			get
			{
				return _base.IsVisible;
			}
			set
			{
				_base.IsVisible = value;
			}
		}
		public  System.Double Opacity
		{
			get
			{
				return _base.Opacity;
			}
			set
			{
				_base.Opacity = value;
			}
		}
		public  Perspex.Media.Transform RenderTransform
		{
			get
			{
				return _base.RenderTransform;
			}
			set
			{
				_base.RenderTransform = value;
			}
		}
		public  Perspex.Origin TransformOrigin
		{
			get
			{
				return _base.TransformOrigin;
			}
			set
			{
				_base.TransformOrigin = value;
			}
		}
		public  System.Int32 ZIndex
		{
			get
			{
				return _base.ZIndex;
			}
			set
			{
				_base.ZIndex = value;
			}
		}
		public  Perspex.Animation.PropertyTransitions PropertyTransitions
		{
			get
			{
				return _base.PropertyTransitions;
			}
			set
			{
				_base.PropertyTransitions = value;
			}
		}
	}
}
