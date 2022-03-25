using Microsoft.Management.Infrastructure;

// ManagementScope scope = new ManagementScope("\\\\.\\root\\cimv2");
// scope.Connect();
// ObjectQuery query = new ObjectQuery(@"SELECT DeviceID, Model, Name, Size, Status, Partitions, 
//   TotalTracks, TotalSectors, BytesPerSector, SectorsPerTrack, TotalCylinders, TotalHeads, 
//   TracksPerCylinder, CapabilityDescriptions 
//   FROM Win32_DiskDrive WHERE MediaType = 'Fixed hard disk media'");
// ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
// foreach (ManagementObject wmi_HD in searcher.Get())
// {
//     foreach (PropertyData property in wmi_HD.Properties)
//         Console.WriteLine($"{property.Name} = {property.Value}");
//     var capabilities = wmi_HD["CapabilityDescriptions"] as string[];
//     if (capabilities != null)
//     {
//         Console.WriteLine("Capabilities");
//         foreach (var capability in capabilities)
//             Console.WriteLine($"  {capability}");
//     }
//     Console.WriteLine("-----------------------------------");
// }

var instances = CimSession.Create(null)
                .QueryInstances(@"root\cimv2", "WQL", @"SELECT DeviceID, Model, Name, Size, Status, Partitions, 
   TotalTracks, TotalSectors, BytesPerSector, SectorsPerTrack, TotalCylinders, TotalHeads, 
   TracksPerCylinder, CapabilityDescriptions 
   FROM Win32_DiskDrive WHERE MediaType = 'Fixed hard disk media'");
foreach (var instance in instances)
{
    foreach (var property in instance.CimInstanceProperties)
        Console.WriteLine($"{property.Name} = {property.Value}");
    var capabilities = instance.CimInstanceProperties["CapabilityDescriptions"].Value as string[];
    if (capabilities != null)
    {
        Console.WriteLine("Capabilities");
        foreach (var capability in capabilities)
            Console.WriteLine($"  {capability}");
    }
    Console.WriteLine("-----------------------------------");
}




