﻿namespace Abp.Notifications
{
    /// <summary>
    /// Extension methods for <see cref="UserNotificationInfo"/>.
    /// </summary>
    public static class UserNotificationInfoExtensions
    {
        /// <summary>
        /// Converts <see cref="UserNotificationInfo"/> to <see cref="UserNotification"/>.
        /// </summary>
        public static UserNotification ToUserNotification(this UserNotificationInfo userNotificationInfo, Notification Notification)
        {
            return new UserNotification
            {
                Id = userNotificationInfo.Id,
                Notification = Notification,
                UserId = userNotificationInfo.UserId,
                State = userNotificationInfo.State,
            };
        }
    }
}