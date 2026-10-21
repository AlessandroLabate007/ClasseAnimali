using System;
using System.Collections.Generic;
using System.Text;

namespace WFAnimali
{
    internal sealed class FileLogger
    {
        private static readonly Lazy<FileLogger> Logger = new(() => new FileLogger());
        private readonly object _lock = new();

        private FileLogger()
        {
            LogPath = Path.Combine(AppContext.BaseDirectory, "logs", "app.log");
            string? directory = Path.GetDirectoryName(LogPath);
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(LogPath))
            {
                File.Create(LogPath).Dispose();
            }
        }

        public static FileLogger Instance => Logger.Value;

        internal string LogPath { get; }

        public void Log(string message)
        {
            ArgumentNullException.ThrowIfNull(message);

            var entry = $"{DateTimeOffset.Now:O} {message}{Environment.NewLine}";
            lock (_lock)
            {
                File.AppendAllText(LogPath, entry, Encoding.UTF8);
            }
        }
    }
}
