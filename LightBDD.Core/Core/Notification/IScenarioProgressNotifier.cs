﻿using LightBDD.Core.Metadata;
using LightBDD.Core.Results;

namespace LightBDD.Core.Notification
{
    public interface IScenarioProgressNotifier
    {
        void NotifyScenarioStart(IScenarioInfo scenario);
        void NotifyScenarioFinished(IScenarioResult scenario);

        void NotifyStepStart(IStepInfo step);
        void NotifyStepFinished(IStepResult step);

        void NotifyStepComment(IStepInfo step, string comment);
    }
}