using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Customer_Relationship_Management.Pages;

namespace TestCustomer_Relationship_Management
{
	public class TestAccountSample
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbExpansionPanelModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbCheckboxModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule));
			var componentUnderTest = ctx.RenderComponent<AccountSample>();
			Assert.NotNull(componentUnderTest);
		}
	}
}