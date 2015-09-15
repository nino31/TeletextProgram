using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeletextProgramFAB.FABClasses
{
    public static class CommunicationFAB
    {
        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_OPENSESSION();

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_CLOSESESSION(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_DISCONNECTSESSION(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SAFEOPENSESSION(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_TERMINATE();

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SETOPTION(int session, int value);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_GETOPTION(int session, ref int value);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SETAUTOMODE(int session, int value);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SETOUTPUTDIR(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string aOutputDir);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_IDLE(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_GETVERSION();

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SENDCOMMAND(int session, [MarshalAs(UnmanagedType.VBByRefStr)] ref string command);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_READCOMMAND(int session, [MarshalAs(UnmanagedType.AnsiBStr)] ref string command);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_ISFABERROR(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_HANGUPMODEM(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_ISMODEMONLINE(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SETCONNECTION(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string connectionName);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_GETCONNECTION(int session,
            [MarshalAs(UnmanagedType.AnsiBStr)] ref string connectionName, int maxLen);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SENDFILES(int session, [MarshalAs(UnmanagedType.VBByRefStr)] ref string files,
            int inBlocks);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_WRITETOPAGELINE(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string aText, int aLen, int aX, int aY);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_WRITETOPAGELINET(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string aText, int aLen, int aX, int aY);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_READFROMPAGELINE(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string aText, int maxLen, int aX, int aY);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_WRITETOPAGERECT(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string atext, int alen, int ax, int aY);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_READFROMPAGERECT(int session, [MarshalAs(UnmanagedType.AnsiBStr)] ref string aText,
            int maxLen, int aX, int aY);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_WRITETOPAGERECTANGLE(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string aText, int aLen, int aX, int aY, int dX, int dY);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_READFROMPAGERECTANGLE(int session,
            [MarshalAs(UnmanagedType.AnsiBStr)] ref string aText, int maxLen, int aX, int aY, int dX, int dY);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_WRITETOPAGELINKS(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string link1,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string link2,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string link3,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string link4,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string indexLink);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_READFROMPAGELINKS(int session,
            [MarshalAs(UnmanagedType.AnsiBStr)] ref string link1, [MarshalAs(UnmanagedType.AnsiBStr)] ref string link2,
            [MarshalAs(UnmanagedType.AnsiBStr)] ref string link3, [MarshalAs(UnmanagedType.AnsiBStr)] ref string link4,
            [MarshalAs(UnmanagedType.AnsiBStr)] ref string indexLink);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_GETMARGINS(int session, ref int left, ref int top, ref int right, ref int bottom);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SETMARGINS(int session, int left, int top, int right, int bottom);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_CLEARSUBPAGE(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_LOADPAGE(int session, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fileName);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_LOADSUBPAGE(int session, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fileName,
            int subpNo);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_LOADPAGEBINARY(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string fileName);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_LOADSUBPAGEBINARY(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string fileName, int subpNo);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SAVEPAGEAS(int session, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fileName,
            int fileType);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SAVESUBPAGEAS(int session,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string fileName, int fileType);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_OPENSUBPAGE(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_CLOSESUBPAGE(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_CLOSESUBPAGES(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_SETCURSUBPAGE(int session, int subPage);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_GETCURSUBPAGE(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_GETSUBPAGECOUNT(int session);

        [DllImport("ETTWAC32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ETTW_PRINTSUBPAGE(int session);


        public static void OpenProgramFABTeletextEditor()
        {
            var putanjaProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            const string putanjaEttFoldera = "\\" + "FAB Teletext Editor" + "\\" + "ettwin.exe";

            var ettwinPrograma = putanjaProgramFiles + putanjaEttFoldera;
            Process.Start(ettwinPrograma);
        }

        public static int OpenSession()
        {
            return ETTW_OPENSESSION();
        }
 
        public static int WriteToPageLine(int idSesija, string tekst, int brojRetka)
        {
            return ETTW_WRITETOPAGELINE(idSesija, ref tekst, tekst.Length, 0, brojRetka);
        }
    }
}
