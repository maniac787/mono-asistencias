
// This file has been generated by the GUI designer. Do not modify.
namespace org.maniacSoft.form.login
{
	public partial class LoginWnd
	{
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.Table table1;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Entry txtPassword;
		private global::Gtk.Entry txtUser;
		private global::Gtk.Label GtkLabel1;
		private global::Gtk.Button btnLogin;
		private global::Gtk.EventBox eventboxMessage;
		private global::Gtk.Table tblMessage;
		private global::Gtk.Image imgErrorLog;
		private global::Gtk.Label lblErrorLog;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget org.maniacSoft.form.login.LoginWnd
			this.Name = "org.maniacSoft.form.login.LoginWnd";
			this.Title = global::Mono.Unix.Catalog.GetString ("Asistencia MAX");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("prjAsistencias.commons.images.calendar.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child org.maniacSoft.form.login.LoginWnd.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Usuario");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Clave");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtPassword = new global::Gtk.Entry ();
			this.txtPassword.CanFocus = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.IsEditable = true;
			this.txtPassword.Visibility = false;
			this.txtPassword.InvisibleChar = '•';
			this.table1.Add (this.txtPassword);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtPassword]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtUser = new global::Gtk.Entry ();
			this.txtUser.CanFocus = true;
			this.txtUser.Name = "txtUser";
			this.txtUser.IsEditable = true;
			this.txtUser.InvisibleChar = '•';
			this.table1.Add (this.txtUser);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtUser]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table1);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Login</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel1;
			this.fixed1.Add (this.frame1);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.frame1]));
			w7.X = 32;
			w7.Y = 19;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnLogin = new global::Gtk.Button ();
			this.btnLogin.CanFocus = true;
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.UseUnderline = true;
			this.btnLogin.Label = global::Mono.Unix.Catalog.GetString ("Iniciar");
			this.fixed1.Add (this.btnLogin);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnLogin]));
			w8.X = 118;
			w8.Y = 105;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.eventboxMessage = new global::Gtk.EventBox ();
			this.eventboxMessage.Name = "eventboxMessage";
			// Container child eventboxMessage.Gtk.Container+ContainerChild
			this.tblMessage = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.tblMessage.Name = "tblMessage";
			this.tblMessage.RowSpacing = ((uint)(6));
			this.tblMessage.ColumnSpacing = ((uint)(6));
			// Container child tblMessage.Gtk.Table+TableChild
			this.imgErrorLog = new global::Gtk.Image ();
			this.imgErrorLog.Name = "imgErrorLog";
			this.imgErrorLog.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("prjAsistencias.commons.images.calendar.png");
			this.tblMessage.Add (this.imgErrorLog);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tblMessage [this.imgErrorLog]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tblMessage.Gtk.Table+TableChild
			this.lblErrorLog = new global::Gtk.Label ();
			this.lblErrorLog.Name = "lblErrorLog";
			this.lblErrorLog.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.lblErrorLog.UseMarkup = true;
			this.tblMessage.Add (this.lblErrorLog);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tblMessage [this.lblErrorLog]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.eventboxMessage.Add (this.tblMessage);
			this.fixed1.Add (this.eventboxMessage);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.eventboxMessage]));
			w12.X = 110;
			w12.Y = 144;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 406;
			this.DefaultHeight = 249;
			this.eventboxMessage.Hide ();
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnLogin.Clicked += new global::System.EventHandler (this.OnBtnLoginClicked);
		}
	}
}
