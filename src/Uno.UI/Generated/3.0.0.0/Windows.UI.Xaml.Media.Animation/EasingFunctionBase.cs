#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class EasingFunctionBase : global::Windows.UI.Xaml.DependencyObject
	{
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Animation.EasingMode EasingMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Animation.EasingMode)this.GetValue(EasingModeProperty);
			}
			set
			{
				this.SetValue(EasingModeProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty EasingModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"EasingMode", typeof(global::Windows.UI.Xaml.Media.Animation.EasingMode), 
			typeof(global::Windows.UI.Xaml.Media.Animation.EasingFunctionBase), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Animation.EasingMode)));
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EasingFunctionBase.EasingMode.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EasingFunctionBase.EasingMode.set
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  double Ease( double normalizedTime)
		{
			throw new global::System.NotImplementedException("The member double EasingFunctionBase.Ease(double normalizedTime) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EasingFunctionBase.EasingModeProperty.get
	}
}