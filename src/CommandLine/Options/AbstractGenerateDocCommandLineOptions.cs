﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using CommandLine;
using Roslynator.Documentation;

namespace Roslynator.CommandLine
{
    public abstract class AbstractGenerateDocCommandLineOptions : BaseCommandLineOptions
    {
        [Option(longName: "assemblies", shortName: 'a', Required = true)]
        public IEnumerable<string> Assemblies { get; set; }

        [Option(longName: "heading", shortName: 'h', Required = true)]
        public string Heading { get; set; }

        [Option(longName: "output", shortName: 'o', Required = true)]
        public string OutputPath { get; set; }

        [Option(longName: "references", shortName: 'r', Required = true)]
        public IEnumerable<string> References { get; set; }

        [Option(longName: "depth", Default = DocumentationOptions.DefaultValues.Depth)]
        public DocumentationDepth Depth { get; set; }

        [Option(longName: "ignored-names")]
        public IEnumerable<string> IgnoredNames { get; set; }

        [Option(longName: "no-class-hierarchy")]
        public bool NoClassHierarchy { get; set; }

        [Option(longName: "no-mark-obsolete")]
        public bool NoMarkObsolete { get; set; }

        [Option(longName: "no-precedence-for-system")]
        public bool NoPrecedenceForSystem { get; set; }

        [Option(longName: "scroll-to-content")]
        public bool ScrollToContent { get; set; }

        [Option(longName: "visibility", Default = nameof(DocumentationVisibility.Publicly))]
        public string Visibility { get; set; }
    }
}
