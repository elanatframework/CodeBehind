namespace CodeBehind
{
    internal class CodeBehindOptions
    {
        private string OptionsFilePath = "code_behind/options.ini";
        internal string ViewPath { private set; get; }
        internal bool MoveViewFromWwwroot { private set; get; }
        internal string DllPath { private set; get; }
        internal bool MoveDllFromWwwrootBin { private set; get; }
        internal bool RewriteAspxFileToDirectory { private set; get; }
        internal bool AccessAspxFileAfterRewrite { private set; get; }
        internal bool IgnoreDefaultAfterRewrite { private set; get; }
        internal bool StartTrimInAspxFile { private set; get; }
        internal bool InnerTrimInAspxFile { private set; get; }
        internal bool EndTrimInAspxFile { private set; get; }
        internal bool SetBreakForLayoutPage { private set; get; }
        internal bool ConvertCsHtmlToAspx { private set; get; }
        internal bool ShowMinorErrors { private set; get; }
        internal string ErrorPagePath { private set; get; }
        internal bool PreventAccessDefaultAspx { private set; get; }
        internal string DefaultRole { private set; get; }
        internal string WebFormsScriptPath { private set; get; }
        internal bool AutoCreateWebFormsScript { private set; get; }
        internal bool RecreateWebFormsScriptAfterRecompile { private set; get; }
        internal bool UseDefaultController { private set; get; }
        internal string DefaultController { private set; get; }
        internal bool UseSegmentInDefaultController { private set; get; }
        internal bool SetBreakForDefaultController { private set; get; }
        internal bool AccessControllerByLowerCase { private set; get; }
        internal bool JustAccessControllerByLowerCase { private set; get; }
        internal string IgnorePrefixController { private set; get; }
        internal string IgnoreSuffixController { private set; get; }
        internal bool PutTwoUnderlinesEqualToDashForController { private set; get; }
        internal bool SetDefaultPages { private set; get; }
        internal int MaxWebSocketConnectionsPerClient { private set; get; }
        internal int WebSocketBufferSize { private set; get; }
        internal bool SendViewOnlyInGetMethod { private set; get; }
        internal bool IgnoreLayoutForPostBack { private set; get; }
        internal bool SetTextHtmlContentTypeForPostBack { private set; get; }
        internal int SseInterval { private set; get; }
        internal int MaxSSEConnectionsPerClient { private set; get; }

        internal CodeBehindOptions()
        {
            if (!Directory.Exists("code_behind"))
                Directory.CreateDirectory("code_behind");

            SetValue();
        }

        private void SetValue()
        {
            SetFirstValue();

            using (StreamReader reader = new StreamReader(OptionsFilePath))
            {
                reader.ReadLine();

                ViewPath = reader.ReadLine().GetTextAfterValue("=");
                MoveViewFromWwwroot = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                DllPath = reader.ReadLine().GetTextAfterValue("=");
                MoveDllFromWwwrootBin = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                RewriteAspxFileToDirectory = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                AccessAspxFileAfterRewrite = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                IgnoreDefaultAfterRewrite = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                StartTrimInAspxFile = (reader.ReadLine().GetTextAfterValue("=").Trim().Trim() == "true");
                InnerTrimInAspxFile = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                EndTrimInAspxFile = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                SetBreakForLayoutPage = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                ConvertCsHtmlToAspx = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                ShowMinorErrors = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                ErrorPagePath = reader.ReadLine().GetTextAfterValue("=");
                PreventAccessDefaultAspx = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                DefaultRole = reader.ReadLine().GetTextAfterValue("=").Trim();
                WebFormsScriptPath = reader.ReadLine().GetTextAfterValue("=");
                AutoCreateWebFormsScript = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                RecreateWebFormsScriptAfterRecompile = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                UseDefaultController = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                DefaultController = reader.ReadLine().GetTextAfterValue("=").Trim();
                UseSegmentInDefaultController = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                SetBreakForDefaultController = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                AccessControllerByLowerCase = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                JustAccessControllerByLowerCase = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                IgnorePrefixController = reader.ReadLine().GetTextAfterValue("=").Trim();
                IgnoreSuffixController = reader.ReadLine().GetTextAfterValue("=").Trim();
                PutTwoUnderlinesEqualToDashForController = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                SetDefaultPages = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                MaxWebSocketConnectionsPerClient = reader.ReadLine().GetTextAfterValue("=").Trim().ToNumber();
                WebSocketBufferSize = reader.ReadLine().GetTextAfterValue("=").Trim().ToNumber();
                SendViewOnlyInGetMethod = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                IgnoreLayoutForPostBack = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                SetTextHtmlContentTypeForPostBack = (reader.ReadLine().GetTextAfterValue("=").Trim() == "true");
                SseInterval = reader.ReadLine().GetTextAfterValue("=").Trim().ToNumber();
                MaxSSEConnectionsPerClient = reader.ReadLine().GetTextAfterValue("=").Trim().ToNumber();
            }
        }

        private void SetFirstValue()
        {
            List<string> OptionsList = new List<string>
            {
                "[CodeBehind-options]",
                "view_path=wwwroot",
                "move_view_from_wwwroot=true",
                "dll_path=wwwroot/bin",
                "move_dll_from_wwwroot_bin=true",
                "rewrite_aspx_file_to_directory=false",
                "access_aspx_file_after_rewrite=false",
                "ignore_default_after_rewrite=true",
                "start_trim_in_aspx_file=true",
                "inner_trim_in_aspx_file=true",
                "end_trim_in_aspx_file=true",
                "set_break_for_layout_page=true",
                "convert_cshtml_to_aspx=false",
                "show_minor_errors=false",
                "error_page_path=/error.aspx/{value}",
                "prevent_access_default_aspx=false",
                "default_role=guest",
                "web_forms_script_path=/script",
                "auto_create_web_forms_script=true",
                "recreate_web_forms_script_after_recompile=false",
                "use_default_controller=true",
                "default_controller=DefaultController",
                "use_segment_in_default_controller=true",
                "set_break_for_default_controller=true",
                "access_controller_by_lower_case=true",
                "just_access_controller_by_lower_case=true",
                "ignore_prefix_controller=.",
                "ignore_suffix_controller=.",
                "put_two_underlines_equal_to_dash_for_controller=false",
                "set_default_pages=true",
                "max_web_socket_connections_per_client=3",
                "web_socket_buffer_size=4096",
                "send_view_only_in_get_method=false",
                "ignore_layout_for_post_back=false",
                "set_text_html_content_type_for_post_back=true",
                "sse_interval=1000",
                "max_sse_connections_per_client=3"
            };

            Dictionary<string, string> UserOptions = new Dictionary<string, string>();
            List<string> OutdatedOptions = new List<string>();

            if (File.Exists(OptionsFilePath))
            {
                using (StreamReader reader = new StreamReader(OptionsFilePath))
                {
                    reader.ReadLine();

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim().StartsWith(";"))
                            continue;

                        string key = line.GetTextBeforeValue("=");

                        if (string.IsNullOrEmpty(key))
                            continue;

                        UserOptions[key] = line.GetTextAfterValue("=");
                    }
                }
            }

            List<string> NewOptionsList = new List<string>
            {
                OptionsList[0]
            };

            HashSet<string> NewOptionKeys = new HashSet<string>();

            foreach (string option in OptionsList.Skip(1))
            {
                string key = option.GetTextBeforeValue("=");
                string defaultValue = option.GetTextAfterValue("=");

                NewOptionKeys.Add(key);

                if (UserOptions.TryGetValue(key, out string value))
                {
                    NewOptionsList.Add(key + "=" + value);
                    UserOptions.Remove(key);
                }
                else
                {
                    NewOptionsList.Add(key + "=" + defaultValue);
                }
            }

            // Options that no longer exist in the new version.
            foreach (var option in UserOptions)
            {
                if (!NewOptionKeys.Contains(option.Key))
                {
                    OutdatedOptions.Add(option.Key + "=" + option.Value);
                }
            }

            // Add outdated options.
            foreach (string option in OutdatedOptions)
            {
                NewOptionsList.Add("");
                NewOptionsList.Add(";outdate");
                NewOptionsList.Add(option);
            }

            bool RewriteOptionsFile = !File.Exists(OptionsFilePath);

            if (!RewriteOptionsFile)
            {
                List<string> CurrentOptions = new List<string>();

                using (StreamReader reader = new StreamReader(OptionsFilePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                        CurrentOptions.Add(line);
                }

                if (CurrentOptions.Count != NewOptionsList.Count)
                {
                    RewriteOptionsFile = true;
                }
                else
                {
                    for (int i = 0; i < CurrentOptions.Count; i++)
                    {
                        if (CurrentOptions[i] != NewOptionsList[i])
                        {
                            RewriteOptionsFile = true;
                            break;
                        }
                    }
                }
            }

            if (RewriteOptionsFile)
            {
                using (StreamWriter writer = new StreamWriter(OptionsFilePath, false))
                {
                    foreach (string line in NewOptionsList)
                        writer.WriteLine(line);
                }
            }
        }
    }
}
