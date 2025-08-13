using Singleton.RealWorldExample;



EventLogger Logger= EventLogger.GetInstance();

Logger.LogEvent("Starting app. 1");
Logger.LogEvent("Starting app. 2");

EventLogger Logger2 = EventLogger.GetInstance();

Logger2.LogEvent("Starting app. 3");
Logger2.LogEvent("Starting app. 4");

EventLogger Logger3 = EventLogger.GetInstance();

Logger3.DisplayLogs();



