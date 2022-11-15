namespace TestRunner
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// Class that contains generated ReadMe.txt file content.
    /// </summary>
    public class ReadMe
    {
        /// <summary>
        /// Generated ReadMe.txt file content.
        /// </summary>
        public string readMeFileContent =
            @"################################# TestRunnerGUI #################################" +
            "\n################################# Version 1.0.0 #################################" +
            "\n################################# This Readme.txt file was generened: " + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + " #################################" +
            "\n################################# Contacts: " + "anatolii.butko3@gmail.com" + "#################################" +
            "\n################################# How to use: #################################" +
            "\n" +
            "\n1. Specify the path or select folders and .exe file for the repository, configurations, framework/tool, and logs in the reference fields or via the appropriate buttons. " +
            "Do not worry, the program provides a message when an invalid file is selected and will not allow you to select another file type (for the framework/instrument)." +
            "\n2. After loading the data, the path will appear in the corresponding labels, and trees of the repository and configuration hierarchies will be built in the corresponding windows, respectively. " +
            "Also, in the window of the content of the .bat file, the command cd path to the framework/tool will appear and move to the next line for the convenience of the user. " +
            "Even if you press the clear button, this line will not be deleted, as it is automatically added when the framework/tool path is selected (it will only change automatically when a different path is selected)." +
            "\n3. If you already have the desired .bat file with a list of tests and configurations for them, click the download button and select it. " +
            "After that, the contents of the selected file will be loaded in the .bat file contents window. You can make manual changes and add tests with co-configurations or tests themselves without configurations. " +
            "To learn more about this, go to point 4. If you do not need to add and want to start the terminal and execute commands, press the start button and go to point 5." +
            "\n\t4. a. In order to add only a test without configurations, double-click on the desired test with the left mouse button in the repository tree (when clicking on the tests folder, all the tests in the folder are added). " +
            "In the content window of the .bat file, the appropriate command will appear with the name of the framework/tool, the name of the project and the name of the test." +
            "\n\t4. b. " +
            "\n ???Profit!" +
            "\nP.S. You can always click on the help button/? and using the prompts to create and open this help file.";
    }
}
