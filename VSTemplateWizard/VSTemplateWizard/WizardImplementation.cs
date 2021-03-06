﻿using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using EnvDTE;
using System.Windows.Forms;
using System.IO;

namespace VSTemplateWizard
{
    public class WizardImplementation : IWizard
    {
        private SprocInputForm _inputForm;

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

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects 
                // input for the custom message.
                _inputForm = new SprocInputForm();
                if (_inputForm.ShowDialog() != DialogResult.OK)
                    throw new WizardCancelledException();

                // Add custom parameters.
                replacementsDictionary.Add("$databasename$", SprocInputForm.DatabaseName);
                replacementsDictionary.Add("$sprocname$", SprocInputForm.SprocName);
                replacementsDictionary.Add("$rollbackrequired$", SprocInputForm.Rollback);
                replacementsDictionary.Add("$action$", SprocInputForm.Action);
                replacementsDictionary.Add("$itemnumber$", SprocInputForm.Item);
                replacementsDictionary.Add("$revision$", SprocInputForm.Revision);
                replacementsDictionary.Add("$editorname$", SprocInputForm.Username);
                replacementsDictionary.Add("$date$", SprocInputForm.Date);
                replacementsDictionary.Add("$tasknumber$", SprocInputForm.Task);
                replacementsDictionary.Add("$changecomments$", SprocInputForm.Comments);
            }
            catch (WizardCancelledException)
            {
                var path = string.Format("{0}{1}\\{2}", replacementsDictionary["$solutiondirectory$"],
                    replacementsDictionary["$rootnamespace$"], replacementsDictionary["$rootname$"]);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                throw;
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
