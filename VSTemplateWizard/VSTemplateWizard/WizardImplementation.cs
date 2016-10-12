using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using EnvDTE;
using System.Windows.Forms;

namespace VSTemplateWizard
{
    public class WizardImplementation : IWizard
    {
        private SprocInputForm _inputForm;
        private string _dbName;
        private string _sprocName;
        private string _rollback;
        private string _action;
        private string _item;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects 
                // input for the custom message.
                _inputForm = new SprocInputForm();
                _inputForm.ShowDialog();

                _dbName = SprocInputForm.DatabaseName;
                _sprocName = SprocInputForm.SprocName;
                _rollback = SprocInputForm.Rollback;
                _action = SprocInputForm.Action;
                _item = SprocInputForm.Item;

                // Add custom parameters.
                replacementsDictionary.Add("$databasename$", _dbName);
                replacementsDictionary.Add("$sprocname$", _sprocName);
                replacementsDictionary.Add("$rollbackrequired$", _rollback);
                replacementsDictionary.Add("$action$", _action);
                replacementsDictionary.Add("$itemnumber$", _item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
