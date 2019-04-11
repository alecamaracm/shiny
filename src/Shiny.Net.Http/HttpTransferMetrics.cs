﻿using System;


namespace Shiny.Net.Http
{
    public class HttpTransferMetrics
    {
        public IHttpTransfer Transfer { get; internal set; }
        public long BytesPerSecond { get; internal set; }
        public TimeSpan EstimatedCompletionTime { get; internal set; }

        internal DateTime? LastChanged { get; set; }
        internal long LastBytesTransferred { get; set; }
        //internal HttpTransferState PreviousStatus { get; set; }
    }
}
