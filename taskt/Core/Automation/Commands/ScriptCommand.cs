﻿using System;
using System.Xml.Serialization;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace taskt.Core.Automation.Commands
{
    [Serializable]
    [XmlInclude(typeof(SendKeysCommand))]
    [XmlInclude(typeof(SendAdvancedKeyStrokesCommand))]
    [XmlInclude(typeof(SendMouseMoveCommand))]
    [XmlInclude(typeof(PauseCommand))]
    [XmlInclude(typeof(ActivateWindowCommand))]
    [XmlInclude(typeof(MoveWindowCommand))]
    [XmlInclude(typeof(CommentCommand))]
    [XmlInclude(typeof(ThickAppClickItemCommand))]
    [XmlInclude(typeof(ThickAppGetTextCommand))]
    [XmlInclude(typeof(UIAutomationCommand))]
    [XmlInclude(typeof(ResizeWindowCommand))]
    [XmlInclude(typeof(WaitForWindowCommand))]
    [XmlInclude(typeof(MessageBoxCommand))]
    [XmlInclude(typeof(StopProcessCommand))]
    [XmlInclude(typeof(StartProcessCommand))]
    [XmlInclude(typeof(AddVariableCommand))]
    [XmlInclude(typeof(VariableCommand))]
    [XmlInclude(typeof(RunScriptCommand))]
    [XmlInclude(typeof(CloseWindowCommand))]
    [XmlInclude(typeof(SetWindowStateCommand))]
    [XmlInclude(typeof(BeginExcelDatasetLoopCommand))]
    [XmlInclude(typeof(ExitLoopCommand))]
    [XmlInclude(typeof(EndLoopCommand))]
    [XmlInclude(typeof(ClipboardGetTextCommand))]
    [XmlInclude(typeof(ClipboardSetTextCommand))]
    [XmlInclude(typeof(ScreenshotCommand))]
    [XmlInclude(typeof(ExcelOpenWorkbookCommand))]
    [XmlInclude(typeof(ExcelCreateApplicationCommand))]
    [XmlInclude(typeof(ExcelAddWorkbookCommand))]
    [XmlInclude(typeof(ExcelGoToCellCommand))]
    [XmlInclude(typeof(ExcelSetCellCommand))]
    [XmlInclude(typeof(ExcelCloseApplicationCommand))]
    [XmlInclude(typeof(ExcelGetCellCommand))]
    [XmlInclude(typeof(ExcelRunMacroCommand))]
    [XmlInclude(typeof(ExcelActivateSheetCommand))]
    [XmlInclude(typeof(ExcelDeleteRowCommand))]
    [XmlInclude(typeof(ExcelDeleteCellCommand))]
    [XmlInclude(typeof(ExcelGetLastRowCommand))]
    [XmlInclude(typeof(ExcelSaveAsCommand))]
    [XmlInclude(typeof(ExcelSaveCommand))]
    [XmlInclude(typeof(SeleniumBrowserCreateCommand))]
    [XmlInclude(typeof(SeleniumBrowserNavigateURLCommand))]
    [XmlInclude(typeof(SeleniumBrowserNavigateForwardCommand))]
    [XmlInclude(typeof(SeleniumBrowserNavigateBackCommand))]
    [XmlInclude(typeof(SeleniumBrowserRefreshCommand))]
    [XmlInclude(typeof(SeleniumBrowserCloseCommand))]
    [XmlInclude(typeof(SeleniumBrowserElementActionCommand))]
    [XmlInclude(typeof(SeleniumBrowserExecuteScriptCommand))]
    [XmlInclude(typeof(SeleniumBrowserSwitchWindowCommand))]
    [XmlInclude(typeof(SeleniumBrowserInfoCommand))]
    [XmlInclude(typeof(SMTPSendEmailCommand))]
    [XmlInclude(typeof(ErrorHandlingCommand))]
    [XmlInclude(typeof(StringSubstringCommand))]
    [XmlInclude(typeof(StringSplitCommand))]
    [XmlInclude(typeof(BeginIfCommand))]
    [XmlInclude(typeof(EndIfCommand))]
    [XmlInclude(typeof(ElseCommand))]
    [XmlInclude(typeof(OCRCommand))]
    [XmlInclude(typeof(HTTPRequestCommand))]
    [XmlInclude(typeof(HTTPQueryResultCommand))]
    [XmlInclude(typeof(ImageRecognitionCommand))]
    [XmlInclude(typeof(SendMouseClickCommand))]
    [XmlInclude(typeof(ExcelCreateDataSetCommand))]
    [XmlInclude(typeof(DatabaseRunQueryCommand))]
    [XmlInclude(typeof(BeginNumberOfTimesLoopCommand))]
    [XmlInclude(typeof(BeginListLoopCommand))]
    [XmlInclude(typeof(BeginContinousLoopCommand))]
    [XmlInclude(typeof(SequenceCommand))]
    [XmlInclude(typeof(StopTaskCommand))]
    [XmlInclude(typeof(RunTaskCommand))]
    [XmlInclude(typeof(WriteTextFileCommand))]
    [XmlInclude(typeof(ReadTextFileCommand))]
    [XmlInclude(typeof(MoveFileCommand))]
    [XmlInclude(typeof(DeleteFileCommand))]
    [XmlInclude(typeof(RenameFileCommand))]
    [XmlInclude(typeof(WaitForFileToExistCommand))]
    [XmlInclude(typeof(RunCustomCodeCommand))]
    [XmlInclude(typeof(DateCalculationCommand))]
    [XmlInclude(typeof(RegExExtractorCommand))]
    [XmlInclude(typeof(TextExtractorCommand))]
    [XmlInclude(typeof(FormatDataCommand))]
    [XmlInclude(typeof(LogDataCommand))]
    [XmlInclude(typeof(StringReplaceCommand))]
    [XmlInclude(typeof(ExecuteDLLCommand))]
    [XmlInclude(typeof(ParseJsonCommand))]
    [XmlInclude(typeof(SetEngineDelayCommand))]
    [XmlInclude(typeof(PDFTextExtractionCommand))]
    [XmlInclude(typeof(UserInputCommand))]
    [XmlInclude(typeof(GetWordCountCommand))]
    [XmlInclude(typeof(GetWordLengthCommand))]
    [XmlInclude(typeof(HTMLInputCommand))]
    [XmlInclude(typeof(UploadDataCommand))]
    [XmlInclude(typeof(GetDataCommand))]
    [XmlInclude(typeof(RESTCommand))]
    [XmlInclude(typeof(ParseJSONArrayCommand))]
    [XmlInclude(typeof(StopwatchCommand))]
    [XmlInclude(typeof(SystemActionCommand))]
    [XmlInclude(typeof(RemoteDesktopCommand))]
    [XmlInclude(typeof(EnvironmentVariableCommand))]
    [XmlInclude(typeof(OSVariableCommand))]
    [XmlInclude(typeof(ModifyVariableCommand))]
    [XmlInclude(typeof(NLGCreateInstanceCommand))]
    [XmlInclude(typeof(NLGSetParameterCommand))]
    [XmlInclude(typeof(NLGGeneratePhraseCommand))]
    [XmlInclude(typeof(IEBrowserCreateCommand))]
    [XmlInclude(typeof(IEBrowserCloseCommand))]
    [XmlInclude(typeof(IEBrowserFindBrowserCommand))]
    [XmlInclude(typeof(IEBrowserElementActionCommand))]
    [XmlInclude(typeof(IEBrowserNavigateURLCommand))]
    [XmlInclude(typeof(AddToVariableCommand))]
    [XmlInclude(typeof(SetVariableIndexCommand))]
    [XmlInclude(typeof(ShowEngineContextCommand))]
    [XmlInclude(typeof(DatabaseDefineConnectionCommand))]
    [XmlInclude(typeof(DatabaseExecuteQueryCommand))]
    [XmlInclude(typeof(ParseDatasetRowCommand))]
    [XmlInclude(typeof(TryCommand))]
    [XmlInclude(typeof(CatchExceptionCommand))]
    [XmlInclude(typeof(FinallyCommand))]
    [XmlInclude(typeof(EndTryCommand))]
    public abstract class ScriptCommand
    {
        [XmlAttribute]
        public string CommandID { get; set; }
        [XmlAttribute]
        public string CommandName { get; set; }
        [XmlAttribute]
        public bool IsCommented { get; set; }
        [XmlAttribute]
        public string SelectionName { get; set; }
        [XmlAttribute]
        public int DefaultPause { get; set; }
        [XmlAttribute]
        public int LineNumber { get; set; }
        [XmlAttribute]
        public bool PauseBeforeExeucution { get; set; }
        [XmlIgnore]
        public Color DisplayForeColor { get; set; }
        [XmlAttribute]
        [Attributes.PropertyAttributes.PropertyDescription("Comment Field (Optional)")]
        [Attributes.PropertyAttributes.InputSpecification("Optional field to enter a custom comment which could potentially describe this command or the need for this command, if required")]
        [Attributes.PropertyAttributes.SampleUsage("I am using this command to ...")]
        [Attributes.PropertyAttributes.Remarks("Optional")]
        public string v_Comment { get; set; }
        [XmlAttribute]
        public bool CommandEnabled { get; set; }

        [XmlIgnore]
        public bool CustomRendering { get; set; }

        [XmlIgnore]
        [NonSerialized]
        public List<Control> RenderedControls;

        public ScriptCommand()
        {
            this.DisplayForeColor = System.Drawing.Color.SteelBlue;
            this.CommandEnabled = false;
            this.DefaultPause = 0;
            this.IsCommented = false;
            this.CustomRendering = false;
            this.GenerateID();
        }

        public void GenerateID()
        {
            var id = Guid.NewGuid();
            this.CommandID = id.ToString();
        }

        public virtual void RunCommand(object sender)
        {
            System.Threading.Thread.Sleep(DefaultPause);
        }
        public virtual void RunCommand(object sender, Core.Script.ScriptAction command)
        {
            System.Threading.Thread.Sleep(DefaultPause);
        }

        public virtual string GetDisplayValue()
        {
            if (String.IsNullOrEmpty(v_Comment))
            {
                return SelectionName;
            }
            else
            {
                return SelectionName + " [" + v_Comment + "]";
            }
        }

        public virtual List<Control> Render(UI.Forms.frmCommandEditor editor)
        {
            RenderedControls = new List<Control>();
            return RenderedControls;
        }

        public virtual List<Control> Render()
        {
            RenderedControls = new List<Control>();
            return RenderedControls;
        }

        public virtual void Refresh(UI.Forms.frmCommandEditor editor = null)
        {

        }

    }
}