﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Security.Claims;
using System.Security.Principal;

using OpenIddict.Abstractions;
using OpenIddict.Validation;

using Volo.Abp.MultiTenancy;

using X.Abp.Identity.Session;

namespace X.Abp.Account.Web.Pages.Account
{
    public class OpenIddictValidateIdentitySessionValidationHandler :
      IOpenIddictValidationHandler<OpenIddictValidationEvents.ValidateTokenContext>
    {
        public static OpenIddictValidationHandlerDescriptor Descriptor { get; } = OpenIddictValidationHandlerDescriptor.CreateBuilder<OpenIddictValidationEvents.ValidateTokenContext>().UseSingletonHandler<OpenIddictValidateIdentitySessionValidationHandler>().SetOrder(OpenIddictValidationHandlers.Protection.ValidatePrincipal.Descriptor.Order + 1000).SetType(OpenIddictValidationHandlerType.Custom).Build();

        protected IdentitySessionChecker IdentitySessionChecker { get; }

        protected ICurrentTenant CurrentTenant { get; }

        public OpenIddictValidateIdentitySessionValidationHandler(
          IdentitySessionChecker identitySessionChecker,
          ICurrentTenant currentTenant)
        {
            IdentitySessionChecker = identitySessionChecker;
            CurrentTenant = currentTenant;
        }

        public virtual async ValueTask HandleAsync(OpenIddictValidationEvents.ValidateTokenContext context)
        {
            ClaimsPrincipal principal = context != null ? context.Principal : throw new ArgumentNullException(nameof(context));
            string sessionId = principal != null ? principal.FindSessionId() : null;
            if (sessionId.IsNullOrWhiteSpace())
            {
                context.Logger.LogWarning("No SessionId was found in the token.");
            }
            else
            {
                using (CurrentTenant.Change(context.Principal.FindTenantId()))
                {
                    if (!await IdentitySessionChecker.IsValidateAsync(sessionId))
                    {
                        context.Logger.LogWarning("The token is no longer valid because the user's session expired.");
                        context.Reject(OpenIddictConstants.Errors.InvalidToken, "The token is no longer valid because the user's session expired.");
                    }
                }
            }
        }
    }
}