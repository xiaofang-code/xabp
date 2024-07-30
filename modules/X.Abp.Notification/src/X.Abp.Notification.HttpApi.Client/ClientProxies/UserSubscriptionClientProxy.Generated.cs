// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using X.Abp.Notification;
using X.Abp.Notification.Dtos;

// ReSharper disable once CheckNamespace
namespace X.Abp.Notification;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IUserSubscriptionAppService), typeof(UserSubscriptionClientProxy))]
public partial class UserSubscriptionClientProxy : ClientProxyBase<IUserSubscriptionAppService>, IUserSubscriptionAppService
{
    public virtual async Task SubscribeAsync(SubscribeInput input)
    {
        await RequestAsync(nameof(SubscribeAsync), new ClientProxyRequestTypeValue
        {
            { typeof(SubscribeInput), input }
        });
    }

    public virtual async Task SubscribeToAllAvailableNotificationsAsync(UserIdentifier user)
    {
        await RequestAsync(nameof(SubscribeToAllAvailableNotificationsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(UserIdentifier), user }
        });
    }

    public virtual async Task UnSubscribeAsync(UnsubscribeInput input)
    {
        await RequestAsync(nameof(UnSubscribeAsync), new ClientProxyRequestTypeValue
        {
            { typeof(UnsubscribeInput), input }
        });
    }

    public virtual async Task<List<UserNotificationSubscriptionInfo>> GetSubscribedNotificationsAsync(UserIdentifier user)
    {
        return await RequestAsync<List<UserNotificationSubscriptionInfo>>(nameof(GetSubscribedNotificationsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(UserIdentifier), user }
        });
    }

    public virtual async Task<bool> IsSubscribedAsync(SubscribeInput input)
    {
        return await RequestAsync<bool>(nameof(IsSubscribedAsync), new ClientProxyRequestTypeValue
        {
            { typeof(SubscribeInput), input }
        });
    }
}
