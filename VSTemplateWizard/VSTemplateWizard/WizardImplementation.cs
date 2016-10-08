using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using EnvDTE;
using System.Windows.Forms;

namespace VSTemplateWizard
{
    public class WizardImplementation : IWizard
    {
        private UserInputForm _inputForm;
        private string _customMessage;

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
                _inputForm = new UserInputForm();
                _inputForm.ShowDialog();

                _customMessage = UserInputForm.CustomMessage;

                // Add custom parameters.
                replacementsDictionary.Add("$custommessage$", _customMessage);
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
