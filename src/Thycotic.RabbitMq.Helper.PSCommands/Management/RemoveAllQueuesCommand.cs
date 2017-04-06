﻿using System;
using System.Management.Automation;

namespace Thycotic.RabbitMq.Helper.PSCommands.Management
{
    /// <summary>
    ///     Deletes all queues in the current instance of RabbitMq
    /// </summary>
    /// <para type="synopsis">Deletes all queues in the current instance of RabbitMq</para>
    /// <para type="description"></para>
    /// <para type="link" uri="http://www.thycotic.com">Thycotic Software Ltd</para>
    /// <example>
    ///     <para>PS C:\></para> 
    ///     <code>Remove-AllQueues</code>
    /// </example>
    [Cmdlet(VerbsCommon.Remove, "AllQueues")]
    public class RemoveAllQueuesCommand : ManagementConsoleCmdlet
    {
        /// <summary>
        ///     Processes the record.
        /// </summary>
        protected override void ProcessRecord()
        {
            throw new NotImplementedException();

//            $cred = Get - Credential
//$result = iwr - ContentType 'application/json' - Method Get - Credential $cred   'http://localhost:15672/api/queues' | % {
//                ConvertFrom - Json  $_.Content } | % { $_ } | ? { $_.messages - eq 0} | % {
//                iwr - method DELETE - Credential $cred - uri  $("http://localhost:15672/api/queues/{0}/{1}" - f[System.Web.HttpUtility]::UrlEncode($_.vhost),  $_.name)
// }

//            Write - Host 'Empty queues were deleted'


            ////we have to use local host because guest account does not work under FQDN
            //const string pluginUrl = "http://localhost:15672/";
            //const string executable = "rabbitmq-plugins.bat";
            //var pluginsExecutablePath = Path.Combine(InstallationConstants.RabbitMq.BinPath, executable);

            //var externalProcessRunner = new ExternalProcessRunner
            //{
            //    EstimatedProcessDuration = TimeSpan.FromSeconds(15)
            //};

            //const string parameters2 = "enable rabbitmq_management";

            //externalProcessRunner.Run(pluginsExecutablePath, WorkingPath, parameters2);

            //if (OpenConsoleAfterInstall)
            //{
            //    WriteVerbose(string.Format("Opening management console at {0}", pluginUrl));
            //    Process.Start(pluginUrl);
            //}
        }
    }
}