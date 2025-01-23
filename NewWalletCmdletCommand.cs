using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Solnet.Wallet;
using Solnet.Wallet.Bip39;

namespace DeSH.PsWallet
{
    [Cmdlet(VerbsCommon.New,"SolWallet")]
    public class NewWalletCmdletCommand : PSCmdlet
    {
        private Solnet.Wallet.Wallet NewWallet { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
            NewWallet = new Solnet.Wallet.Wallet(WordCount.TwentyFour, WordList.English);
            WriteObject(NewWallet);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            
             
             //IRpcClient rpcClient = ClientFactory.GetClient(Cluster.DevNet);
             
             //var balance = rpcClient.GetBalanceAsync(NewWallet.Account.PublicKey);
             //WriteVerbose(balance.Result.ToString());
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            
            
           
            //WriteVerbose("End!");
        }
    }

}