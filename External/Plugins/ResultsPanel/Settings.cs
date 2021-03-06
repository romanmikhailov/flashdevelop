﻿using System;
using System.ComponentModel;
using PluginCore.Localization;

namespace ResultsPanel
{
    [Serializable]
    public class Settings
    {
        private Boolean scrollToBottom = false;
        private GroupingMethod defaultGroup = GroupingMethod.File;

        [DisplayName("Scroll To Bottom")]
        [LocalizedDescription("ResultsPanel.Description.ScrollToBottom"), DefaultValue(false)]
        public Boolean ScrollToBottom
        {
            get { return scrollToBottom; }
            set { scrollToBottom = value; }
        }

        [DisplayName("Default Grouping")]
        [LocalizedDescription("ResultsPanel.Description.DefaultGrouping"), DefaultValue(GroupingMethod.File)]
        public GroupingMethod DefaultGrouping
        {
            get { return defaultGroup; }
            set { defaultGroup = value; }
        }
    }

}
