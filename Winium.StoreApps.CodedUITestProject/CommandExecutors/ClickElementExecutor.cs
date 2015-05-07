﻿namespace Winium.StoreApps.CodedUITestProject.CommandExecutors
{
    #region

    using Winium.StoreApps.Common;

    #endregion

    public class ClickElementExecutor : CommandExecutorBase
    {
        #region Methods

        protected override string DoImpl()
        {
            var registredId = this.ExecutedCommand.Parameters["ID"].ToObject<string>();

            var element = this.ElementsRegistry.GetRegistredElement(registredId);
            element.Click();

            return this.JsonResponse(ResponseStatus.Success, null);
        }

        #endregion
    }
}