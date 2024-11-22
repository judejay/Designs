using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Chain_of_responsibility
{
    public abstract class AbstractEmailHandler : IEmailHandler
    {
        private IEmailHandler _nextHandler;
        public virtual IEmailHandler NextHandler
        {
            set { _nextHandler = value; }
        }
        public virtual void ProcessHandler(string email)
        {
            bool wordFound = false;
            //If the word is in the list, this handler will process the email
            if (MatchingWords().Length == 0)
            {
                wordFound = true;
            }
            else
            {
                // look for any of the matching words
                foreach (string word in MatchingWords())
                {
                    if (email.IndexOf(word) >= 0)
                    {
                        wordFound = true;
                        break;
                    }
                }
            }
            //Can we handle the request in this object?
            if (wordFound)
            {
                HandleHere(email);
            }
            else
            {
                //Unable to handle here so forward to next in chain
                _nextHandler?.ProcessHandler(email);
            }


        }

        protected internal abstract string[] MatchingWords();
        protected internal abstract void HandleHere(string email);
    
    public static void Handle(string email) {

            // Create the handler objects
            IEmailHandler general = new GeneralEnquiriesEmailHandler();
            IEmailHandler service = new ServiceEmailHandler();
            IEmailHandler manager = new ManagerEmailHandler();
            IEmailHandler spam = new SpamEmailHandler();
            IEmailHandler sales = new SalesEmailHandler();

            //Chain them in the required order
            spam.NextHandler = sales;
            sales.NextHandler = service;
            service.NextHandler = manager;
            manager.NextHandler = general;

            //Start the handler process
            spam.ProcessHandler(email);
        }
    }
}