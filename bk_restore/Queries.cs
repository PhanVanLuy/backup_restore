using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bk_restore
{
    public static class  Queries
    {
        public static string CREATE_DEVICE =
                "EXEC sys.sp_addumpdevice @devtype = 'disk', @logicalname = '{0}', @physicalname = N'{1}'";
        public static string BACKUP =
            "BACKUP DATABASE [{0}] TO [{1}]";
        public static string BACKUP_WITH_INIT =
            "BACKUP DATABASE [{0}] TO [{1}] WITH INIT";
        
        public static string RESTORE =
            "ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE\n" +
            "USE tempdb\n" +
            "RESTORE DATABASE [{0}] FROM [{1}] WITH FILE = {2}, REPLACE\n" +
            "ALTER DATABASE [{0}] SET MULTI_USER";
        
        public static string RESTORE_WITH_TIME =
            "ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE\n" +
            "BACKUP LOG [{0}] TO DISK = '{1}' WITH INIT\n" +
            "USE MASTER\n" +
            "RESTORE DATABASE [{0}] FROM [{2}] WITH FILE = {3}, REPLACE, NORECOVERY\n";
        
        public static string RESTORE_WITH_TIME_WITH_STOPAT =
            "RESTORE DATABASE [{0}] FROM DISK = '{1}' WITH STOPAT = '{2}'";

        public static string ERROR_RESTORE =
           "RESTORE DATABASE [{0}] FROM [{1}] WITH FILE = {2}\n" +
           "ALTER DATABASE [{0}] SET MULTI_USER";

        public static string DELETE_BACKUP =
            "DELETE FROM msdb.dbo.backupfile WHERE backup_set_id = {0}\n" +
            "DELETE FROM msdb.dbo.backupfilegroup WHERE backup_set_id = {0}\n" +
            "DELETE FROM msdb.dbo.backupset WHERE backup_set_id = {0}\n";

        public static string DELETE_RESTORE_HISTORY =
            "DELETE FROM msdb.dbo.restorefile WHERE restore_history_id = {0}\n" +
            "DELETE FROM msdb.dbo.restorefilegroup WHERE restore_history_id = {0}\n" +
            "DELETE FROM msdb.dbo.restorehistory WHERE restore_history_id = {0}\n";
       
        public static string SET_MULTI_USER =
            "ALTER DATABASE [{0}] SET MULTI_USER";



    }
}

