DriveInfo[] drives = DriveInfo.GetDrives();

foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"Name: {drive.Name}");
    Console.WriteLine($"VolumeLabel: {drive.VolumeLabel}");
    Console.WriteLine($"RootDirectory: {drive.RootDirectory}");
    Console.WriteLine($"DriveType: {drive.DriveType}");
    Console.WriteLine($"DriveFormat: {drive.DriveFormat}");
    Console.WriteLine($"IsReady: {drive.IsReady}");
    Console.WriteLine($"TotalSize: {drive.TotalSize}");
    Console.WriteLine($"TotalFreeSpace: {drive.TotalFreeSpace}");
    Console.WriteLine($"AvailableFreeSpace: {drive.AvailableFreeSpace}");
    Console.WriteLine();
}