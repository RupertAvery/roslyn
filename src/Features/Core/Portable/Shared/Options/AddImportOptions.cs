﻿using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Shared.Options
{
    internal class AddImportOptions
    {
        public const string FeatureName = "AddImport";

        public static PerLanguageOption<bool> SuggestForTypesInReferenceAssemblies =
            new PerLanguageOption<bool>(FeatureName, nameof(SuggestForTypesInReferenceAssemblies), defaultValue: false,
                persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.SuggestForTypesInReferenceAssemblies"));

        public static PerLanguageOption<bool> SuggestForTypesInNuGetPackages =
            new PerLanguageOption<bool>(FeatureName, nameof(SuggestForTypesInNuGetPackages), defaultValue: false,
                persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.SuggestForTypesInNuGetPackages"));
    }
}
