
// This file has been generated by the GUI designer. Do not modify.
namespace Launchpad_Launcher
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action EditAction;
		private global::Gtk.Action SettingsAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Label label2;
		private global::Gtk.HBox hbox3;
		private global::Gtk.ProgressBar progressbar2;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Button button4;
		private global::Gtk.Button button3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Launchpad_Launcher.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("Edit"), null, null);
			this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Options");
			w1.Add (this.EditAction, null);
			this.SettingsAction = new global::Gtk.Action ("SettingsAction", global::Mono.Unix.Catalog.GetString ("Settings"), null, null);
			this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Settings");
			w1.Add (this.SettingsAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "Launchpad_Launcher.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Launchpad");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("Launchpad_Launcher.resource.Icons8-Android-Transport-Rocket.ico");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.DefaultWidth = 725;
			this.DefaultHeight = 375;
			// Container child Launchpad_Launcher.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='EditAction' action='EditAction'><menuitem name='SettingsAction' action='SettingsAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			this.hbox2.BorderWidth = ((uint)(4));
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			this.alignment2.Add (this.scrolledwindow2);
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment2]));
			w4.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.alignment1.Add (this.label2);
			this.vbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment1]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox2.Add (this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w8.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			this.hbox3.BorderWidth = ((uint)(4));
			// Container child hbox3.Gtk.Box+BoxChild
			this.progressbar2 = new global::Gtk.ProgressBar ();
			this.progressbar2.Name = "progressbar2";
			this.hbox3.Add (this.progressbar2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.progressbar2]));
			w9.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button ();
			this.button4.Sensitive = false;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString ("Verify Installation");
			this.hbox4.Add (this.button4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.button4]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString ("MainButton");
			this.hbox4.Add (this.button3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.button3]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.hbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbox4]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.SettingsAction.Activated += new global::System.EventHandler (this.OnSettingsActionActivated);
		}
	}
}
