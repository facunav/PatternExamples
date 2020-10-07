using System;

namespace StructuralPatterns.Proxy
{
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee2 employee;

        public SharedFolderProxy(Employee2 emp)
        {
            employee = emp;
        }

        public void PerformRWOperations()
        {
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
