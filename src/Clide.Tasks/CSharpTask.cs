﻿using System.Threading;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.CodeAnalysis;
using System;

namespace Clide.Tasks
{
	public abstract class CSharpTask : Task, ICancelableTask
	{
		const string CSharp = "C#";
		CancellationTokenSource cancellation = new CancellationTokenSource();

		[Required]
		public string ProjectFullPath { get; set; }

		[Required]
		public string Language { get; set; }

		public string LogWarnings { get; set; }

		protected CancellationToken Cancellation { get { return cancellation.Token; } }

		protected Compilation Compilation { get; private set; }

		protected Project Project { get; private set; }

		public override bool Execute()
		{
			if (Language != CSharp)
			{
				Log.LogError("Unsupported language {0}.", Language);
				return false;
			}

			Project = this.GetOrAddProject(ProjectFullPath);
			if (cancellation.IsCancellationRequested)
			{
				Log.LogWarning("Cancellation was requested. Aborting task.");
				return false;
			}

			Compilation = Project.GetCompilationAsync(cancellation.Token).Result;

			var logWarnings = false;
			if (!string.IsNullOrEmpty(LogWarnings) && bool.TryParse(LogWarnings, out logWarnings) && logWarnings)
			{
				var diagnostics = Compilation.GetDiagnostics(cancellation.Token);
				if (diagnostics.Any(d => d.Severity == DiagnosticSeverity.Error))
					Log.LogWarning("Code generation may not be complete, since there are compilation errors: " +
						string.Join(Environment.NewLine, diagnostics.Select(d => d.GetMessage())));
			}

			return true;
		}

		public void Cancel()
		{
			cancellation.Cancel();
		}
	}
}
