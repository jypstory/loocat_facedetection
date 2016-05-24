using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CATSEE_GATE_SYSTEM
{
    class Config
    {

        private string connStrLocal = "";
        private string connStrRemote = "";
        private string runMode = "";
        private string dataRootDir = "";
        private string activeKey = "";
        private string trackerMemoryFile = "";

        public Config()
        {
            connStrLocal = "";
            connStrRemote = "";
            runMode = "";
            dataRootDir = "";
            activeKey = "";
            setConfig();
        }

        private void setConfig()
        {
            connStrLocal = Properties.Settings.Default.sqlUrlLocal.ToString();
            connStrRemote = Properties.Settings.Default.sqlUrlRemote.ToString();
            runMode = Properties.Settings.Default.runMode.ToString();
            dataRootDir = Properties.Settings.Default.dataRootDir.ToString();
            activeKey = Properties.Settings.Default.activeKey.ToString();
            trackerMemoryFile = Properties.Settings.Default.trackerMemoryFile.ToString();
        }

        public String getConnStrLocal(){
            return connStrLocal;
        }

        public String getConnStrRemote()
        {
            return connStrRemote;
        }

        public String getRunMode()
        {
            return runMode;
        }

        public String getDataRootDir()
        {
            return dataRootDir;
        }

        public String getActiveKey()
        {
            return activeKey;
        }

        public String getTrackerMemoryFile()
        {
            return trackerMemoryFile;
        }


    }
}
