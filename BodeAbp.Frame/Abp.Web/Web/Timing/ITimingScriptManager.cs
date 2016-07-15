﻿using System.Threading.Tasks;

namespace Abp.Web.Timing
{
    /// <summary>
    /// Define interface to get timing scripts
    /// </summary>
    public interface ITimingScriptManager
    {
        /// <summary>
        /// Gets Javascript that contains all permission information.
        /// </summary>
        Task<string> GetScriptAsync();
    }
}
