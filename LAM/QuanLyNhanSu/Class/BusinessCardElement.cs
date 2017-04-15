using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Design;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using System;

namespace QuanLyNhanSu.Class
{
	public class BusinessCardElement: RadItem
	{
		private TextPrimitive captionTextPrimitive;
		private FillPrimitive captionFillPrimitive;
		private FillPrimitive bodyFillPrimitive;
		private RadItemOwnerCollection items;
		private ImagePrimitive picturePrimitive;

		static BusinessCardElement()
		{
			ThemeResolutionService.RegisterThemeFromStorage(ThemeStorageType.Resource,
				"QuanLyNhanSu.Resources.BusinessCardElementDefault.xml");
		}

		public static RadProperty NameProperty = RadProperty.Register(
			"Name",
			typeof(string),
			typeof(BusinessCardElement),
			new RadElementPropertyMetadata("", ElementPropertyOptions.None));

		public string Name
		{
			get
			{
				return (string)this.GetValue(NameProperty);
			}
			set
			{
				this.SetValue(NameProperty, value);
			}
		}

		public static RadProperty PictureProperty = RadProperty.Register(
			"Picture",
			typeof(Image), typeof(BusinessCardElement),
			new RadElementPropertyMetadata(null, ElementPropertyOptions.None));

		public Image Picture
		{
			get
			{
				return (Image)this.GetValue(PictureProperty);
			}
			set
			{
				this.SetValue(PictureProperty, value);
			}
		}

		public static RadProperty CompanyProperty = RadProperty.Register(
			"Company",
			typeof(string),
			typeof(BusinessCardElement),
			new RadElementPropertyMetadata("", ElementPropertyOptions.None));

		public string Company
		{
			get
			{
				return (string)this.GetValue(CompanyProperty);
			}
			set
			{
				this.SetValue(CompanyProperty, value);
			}
		}

		public static RadProperty PositionProperty = RadProperty.Register(
			"Position",
			typeof(string),
			typeof(BusinessCardElement),
			new RadElementPropertyMetadata("", ElementPropertyOptions.None));

		public string Position
		{
			get
			{
				return (string)this.GetValue(PositionProperty);
			}
			set
			{
				this.SetValue(PositionProperty, value);
			}
		}

		public static RadProperty PhoneProperty = RadProperty.Register(
			"Phone",
			typeof(string),
			typeof(BusinessCardElement),
			new RadElementPropertyMetadata("", ElementPropertyOptions.None));

		public string Phone
		{
			get
			{
				return (string)this.GetValue(PhoneProperty);
			}
			set
			{
				this.SetValue(PhoneProperty, value);
			}
		}

		public static RadProperty FaxProperty = RadProperty.Register(
			"Fax",
			typeof(string),
			typeof(BusinessCardElement),
			new RadElementPropertyMetadata("", ElementPropertyOptions.None));

		public string Fax
		{
			get
			{
				return (string)this.GetValue(FaxProperty);
			}
			set
			{
				this.SetValue(FaxProperty, value);
			}
		}

		public static RadProperty EmailProperty = RadProperty.Register(
			"Email",
			typeof(string),
			typeof(BusinessCardElement),
			new RadElementPropertyMetadata("", ElementPropertyOptions.None));

		public string Email
		{
			get
			{
				return (string)this.GetValue(EmailProperty);
			}
			set
			{
				this.SetValue(EmailProperty, value);
			}
		}

		public static RadProperty AddressProperty = RadProperty.Register(
			"Address",
			typeof(string),
			typeof(BusinessCardElement),
			new RadElementPropertyMetadata("", ElementPropertyOptions.None));

		public string Address
		{
			get
			{
				return (string)this.GetValue(AddressProperty);
			}
			set
			{
				this.SetValue(AddressProperty, value);
			}
		}

		public BusinessCardElement()
		{
			this.items = new RadItemOwnerCollection();
			this.items.ItemTypes = new Type[] { typeof(RadButtonElement) };
		}

		private List<VisualElement> optionalItems = new List<VisualElement>();

		protected override void CreateChildElements()
		{
            
            this.BackColor = Color.Gray;
			this.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.AutoSizeMode = RadAutoSizeMode.WrapAroundChildren;
			this.Margin = new Padding(10);
			ElementWithCaptionLayoutPanel layoutPanel = new ElementWithCaptionLayoutPanel();
			layoutPanel.CaptionOnTop = true;

			captionFillPrimitive = new FillPrimitive();
			captionFillPrimitive.Class = "CaptionFill";
			captionFillPrimitive.ShouldHandleMouseInput = true;
			captionFillPrimitive.AutoSizeMode = RadAutoSizeMode.Auto;
            //Set higher level of z-order, to allow caption to appear above any inner elements
		    captionFillPrimitive.ZIndex = 0;
			captionFillPrimitive.NotifyParentOnMouseInput = true;

			bodyFillPrimitive = new FillPrimitive();
			bodyFillPrimitive.Class = "BodyFill";
			bodyFillPrimitive.AutoSizeMode = RadAutoSizeMode.Auto;

			StripLayoutPanel stripPanel = new StripLayoutPanel();
			stripPanel.AutoSizeMode = RadAutoSizeMode.WrapAroundChildren;
			stripPanel.Orientation = Orientation.Horizontal;

			picturePrimitive = new ImagePrimitive();
			picturePrimitive.BindProperty(ImagePrimitive.ImageProperty, this, BusinessCardElement.PictureProperty, PropertyBindingOptions.OneWay);
			picturePrimitive.Visibility = ElementVisibility.Collapsed;
			picturePrimitive.Margin = new Padding(10);
			picturePrimitive.MinSize = new Size(25, 110);
			stripPanel.Children.Add(picturePrimitive);
			this.optionalItems.Add(picturePrimitive);

			StripLayoutPanel textStripPanel = new StripLayoutPanel();
		    textStripPanel.Class = "DetailsPanel";
			textStripPanel.Orientation = Orientation.Vertical;
			textStripPanel.AutoSizeMode = RadAutoSizeMode.WrapAroundChildren;
			textStripPanel.Padding = new Padding(5);

			TextPrimitive nameTextPrimitive = new TextPrimitive();
			nameTextPrimitive.Text = "Name";
			nameTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.NameProperty, PropertyBindingOptions.OneWay);
			textStripPanel.Children.Add(nameTextPrimitive);

			TextPrimitive companyTextPrimitive = new TextPrimitive();
			companyTextPrimitive.Text = "Company";
			companyTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.CompanyProperty, PropertyBindingOptions.OneWay);
			textStripPanel.Children.Add(companyTextPrimitive);

			TextPrimitive departmentTextPrimitive = new TextPrimitive();
			departmentTextPrimitive.Text = "Position";
			departmentTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.PositionProperty, PropertyBindingOptions.OneWay);
			departmentTextPrimitive.Visibility = ElementVisibility.Collapsed;
            departmentTextPrimitive.Class = "DetailsItem";
			textStripPanel.Children.Add(departmentTextPrimitive);
			this.optionalItems.Add(departmentTextPrimitive);

			TextPrimitive phoneTextPrimitive = new TextPrimitive();
			phoneTextPrimitive.Text = "Phone";
			phoneTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.PhoneProperty, PropertyBindingOptions.OneWay);
			phoneTextPrimitive.Visibility = ElementVisibility.Collapsed;
            phoneTextPrimitive.Class = "DetailsItem";
			textStripPanel.Children.Add(phoneTextPrimitive);
			this.optionalItems.Add(phoneTextPrimitive);

			TextPrimitive faxTextPrimitive = new TextPrimitive();
			faxTextPrimitive.Text = "Fax";
			faxTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.FaxProperty, PropertyBindingOptions.OneWay);
			faxTextPrimitive.Visibility = ElementVisibility.Collapsed;
            faxTextPrimitive.Class = "DetailsItem";
			textStripPanel.Children.Add(faxTextPrimitive);
			this.optionalItems.Add(faxTextPrimitive);

			TextPrimitive emailTextPrimitive = new TextPrimitive();
			emailTextPrimitive.Text = "E-mail";
			emailTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.EmailProperty, PropertyBindingOptions.OneWay);
			emailTextPrimitive.Visibility = ElementVisibility.Collapsed;
            emailTextPrimitive.Class = "DetailsItem";
			textStripPanel.Children.Add(emailTextPrimitive);
			this.optionalItems.Add(emailTextPrimitive);

			TextPrimitive addressTextPrimitive = new TextPrimitive();
			addressTextPrimitive.Text = "Address";
			addressTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.AddressProperty, PropertyBindingOptions.OneWay);
			addressTextPrimitive.Visibility = ElementVisibility.Collapsed;
            addressTextPrimitive.Class = "DetailsItem";
			textStripPanel.Children.Add(addressTextPrimitive);
			this.optionalItems.Add(addressTextPrimitive);

			stripPanel.Children.Add(textStripPanel);
			bodyFillPrimitive.Children.Add(stripPanel);
			
			captionTextPrimitive = new TextPrimitive();
			captionTextPrimitive.Text = "Name";
			captionTextPrimitive.Font = new Font(this.Font, FontStyle.Bold);
			captionTextPrimitive.BindProperty(TextPrimitive.TextProperty, this, BusinessCardElement.NameProperty, PropertyBindingOptions.OneWay);
			captionTextPrimitive.MinSize = new Size(120, 10);
			captionFillPrimitive.Children.Add(captionTextPrimitive);

			layoutPanel.Children.Add(captionFillPrimitive);
			captionFillPrimitive.SetValue(ElementWithCaptionLayoutPanel.CaptionElementProperty, true);

			layoutPanel.Children.Add(bodyFillPrimitive);
			this.Children.Add(layoutPanel);

			BorderPrimitive borderPrimitive = new BorderPrimitive();
			borderPrimitive.BorderThickness = new Padding(2);
			this.Children.Add(borderPrimitive);
            
		}


		public void ShowOptionalElements()
		{
			this.SetOptionalElementsVisibility(ElementVisibility.Visible);
		}

		public void HideOptionalElements()
		{
			this.SetOptionalElementsVisibility(ElementVisibility.Collapsed);
		}

		public void SetOptionalElementsVisibility(ElementVisibility visibility)
		{
			if (visibility == ElementVisibility.Collapsed)
			{
				this.captionTextPrimitive.MinSize = new Size(120, 10);
			}
			else if (visibility == ElementVisibility.Visible)
			{
				this.captionTextPrimitive.MinSize = new Size(240, 10);
			}

			for (int i = 0; i < this.optionalItems.Count; i++)
			{
				this.optionalItems[i].Visibility = visibility;
			}
		}
	}
}