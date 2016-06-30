// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Editor.Shared.Options
{
    internal static class FeatureOnOffOptions
    {
        public const string OptionName = "EditorFeaturesOnOff";

        // This value is only used by Visual Basic, and so is using the old serialization name that was used by VB.
        [ExportOption]
        public static readonly PerLanguageOption<bool> EndConstruct = new PerLanguageOption<bool>(OptionName, "End Construct", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.AutoEndInsert"));

        // This value is only used by Visual Basic, and so is using the old serialization name that was used by VB.
        [ExportOption]
        public static readonly PerLanguageOption<bool> AutomaticInsertionOfAbstractOrInterfaceMembers = new PerLanguageOption<bool>(OptionName, "Automatic Insertion of Abstract or Interface Members", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.AutoRequiredMemberInsert"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> LineSeparator = new PerLanguageOption<bool>(OptionName, "Line Separator", defaultValue: false,
            persistences: new RoamingProfilePersistence(language => language == LanguageNames.VisualBasic ? "TextEditor.%LANGUAGE%.Specific.DisplayLineSeparators" : "TextEditor.%LANGUAGE%.Specific.Line Separator"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> Outlining = new PerLanguageOption<bool>(OptionName, "Outlining", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.Outlining"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> KeywordHighlighting = new PerLanguageOption<bool>(OptionName, "Keyword Highlighting", defaultValue: true,
            persistences: new RoamingProfilePersistence(language => language == LanguageNames.VisualBasic ? "TextEditor.%LANGUAGE%.Specific.EnableHighlightRelatedKeywords" : "TextEditor.%LANGUAGE%.Specific.Keyword Highlighting"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> ReferenceHighlighting = new PerLanguageOption<bool>(OptionName, "Reference Highlighting", defaultValue: true,
            persistences: new RoamingProfilePersistence(language => language == LanguageNames.VisualBasic ? "TextEditor.%LANGUAGE%.Specific.EnableHighlightReferences" : "TextEditor.%LANGUAGE%.Specific.Reference Highlighting"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> FormatOnPaste = new PerLanguageOption<bool>(OptionName, "FormatOnPaste", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.FormatOnPaste"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> AutoXmlDocCommentGeneration = new PerLanguageOption<bool>(OptionName, "Automatic XML Doc Comment Generation", defaultValue: true,
            persistences: new RoamingProfilePersistence(language => language == LanguageNames.VisualBasic ? "TextEditor.%LANGUAGE%.Specific.AutoComment" : "TextEditor.%LANGUAGE%.Specific.Automatic XML Doc Comment Generation"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> AutoInsertBlockCommentStartString = new PerLanguageOption<bool>(OptionName, "Auto Insert Block Comment Start String", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.Auto Insert Block Comment Start String"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> PrettyListing = new PerLanguageOption<bool>(OptionName, "Pretty List On Line Commit", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.PrettyListing"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> AutoFormattingOnCloseBrace = new PerLanguageOption<bool>(OptionName, "Auto Formatting On Close Brace", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.Auto Formatting On Close Brace"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> AutoFormattingOnSemicolon = new PerLanguageOption<bool>(OptionName, "Auto Formatting On Semicolon", defaultValue: true,
            persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.Auto Formatting On Semicolon"));

        [ExportOption]
        public static readonly PerLanguageOption<bool> RenameTrackingPreview = new PerLanguageOption<bool>(OptionName, "Rename Tracking Preview", defaultValue: true,
            persistences: new RoamingProfilePersistence(language => language == LanguageNames.VisualBasic ? "TextEditor.%LANGUAGE%.Specific.RenameTrackingPreview" : "TextEditor.%LANGUAGE%.Specific.Rename Tracking Preview"));

        /// <summary>
        /// This option is currently used by Roslyn, but we might want to implement it in the 
        /// future. Keeping the option while it's unimplemented allows all upgrade paths to 
        /// maintain any customized value for this setting, even through versions that have not
        /// implemented this feature yet.
        /// </summary>
        [ExportOption]
        public static readonly PerLanguageOption<bool> RenameTracking = new PerLanguageOption<bool>(OptionName, "Rename Tracking", defaultValue: true);

        /// <summary>
        /// This option is currently used by Roslyn, but we might want to implement it in the 
        /// future. Keeping the option while it's unimplemented allows all upgrade paths to 
        /// maintain any customized value for this setting, even through versions that have not
        /// implemented this feature yet.
        /// </summary>
        [ExportOption]
        public static readonly PerLanguageOption<bool> RefactoringVerification = new PerLanguageOption<bool>(OptionName, "Refactoring Verification", defaultValue: false);

        [ExportOption]
        public static readonly PerLanguageOption<bool> StreamingFindReferences = new PerLanguageOption<bool>(OptionName, nameof(StreamingFindReferences), defaultValue: true);
    }
}
