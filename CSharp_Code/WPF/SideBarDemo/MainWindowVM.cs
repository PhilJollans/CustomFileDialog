using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfCustomFileDialog;

namespace SideBarDemo
{
    internal class MainWindowVM : ObservableObject
    {
        private string      _filePath ;

        public ICommand     FileOpenCommandVariable { get; private set; }
        public ICommand     FileOpenCommandFixed { get; private set; }
        public string       FilePath { get => _filePath ; set => SetProperty (ref _filePath, value) ; }

        // Not MVVM :(
        public Window       Win { get; set; } 

        public MainWindowVM()
        {
            FileOpenCommandVariable = new RelayCommand ( Execute_FileOpenCommandVariable ) ;
            FileOpenCommandFixed = new RelayCommand ( Execute_FileOpenCommandFixed );
        }

        private void Execute_FileOpenCommandVariable ()
        {
            Execute_FileOpenCommand ( false );
        }

        private void Execute_FileOpenCommandFixed()
        {
            Execute_FileOpenCommand ( true ) ;
        }

        // This could also be defined as an ICommand with a parameter.
        private void Execute_FileOpenCommand ( bool isFized )
        {
            var ofd = new WpfCustomFileDialog.OpenFileDialog<SideBar>();
            ofd.Filter = "avi files (*.avi)|*.avi|wmv files (*.wmv)|*.wmv|All files (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.Title = "Select Media file using a control";
            ofd.FileDlgStartLocation = AddonWindowLocation.Right;
            ofd.FileDlgDefaultViewMode = NativeMethods.FolderViewMode.Tiles;
            ofd.FileDlgOkCaption = "&Select";
            ofd.FileDlgEnableOkBtn = false;
            ofd.FixedSize = isFized ;
            ofd.SetPlaces ( new object[] { @"c:\", (int)Places.MyComputer, (int)Places.Favorites, (int)Places.All_Users_MyVideo, (int)Places.MyVideos } );
            bool? res = ofd.ShowDialog(Win);

            if ( res.Value == true )
            {
                FilePath = ofd.FileName;
            }
        }
    }
}
