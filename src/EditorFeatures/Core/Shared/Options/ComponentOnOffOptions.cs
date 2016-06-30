// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Editor.Shared.Options
{
    /// <summary>
    /// options to indicate whether a certain component in Roslyn is enabled or not
    /// </summary>
    internal static class EditorComponentOnOffOptions
    {
        public const string OptionName = "FeatureManager/Components";
        private const string LocalRegistryPath = @"Roslyn\Internal\OnOff\Components\";

        [ExportOption]
        public static readonly Option<bool> Adornment = new Option<bool>(OptionName, "Adornment", defaultValue: true,
            persistences: new LocalUserProfilePersistence(LocalRegistryPath + "Adornment"));

        [ExportOption]
        public static readonly Option<bool> Tagger = new Option<bool>(OptionName, "Tagger", defaultValue: true,
            persistences: new LocalUserProfilePersistence(LocalRegistryPath + "Tagger"));

        [ExportOption]
        public static readonly Option<bool> CodeRefactorings = new Option<bool>(OptionName, "Code Refactorings", defaultValue: true,
            persistences: new LocalUserProfilePersistence(LocalRegistryPath + "Code Refactorings"));
    }
}
