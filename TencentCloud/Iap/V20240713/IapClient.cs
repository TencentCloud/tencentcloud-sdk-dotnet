/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Iap.V20240713
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iap.V20240713.Models;

   public class IapClient : AbstractClient{

       private const string endpoint = "iap.tencentcloudapi.com";
       private const string version = "2024-07-13";
       private const string sdkVersion = "SDK_NET_3.0.1159";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IapClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IapClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建用户OIDC配置。只能创建一个用户OIDC身份提供商，并且创建用户OIDC配置之后会自动关闭用户SAML SSO身份提供商。
        /// </summary>
        /// <param name="req"><see cref="CreateIAPUserOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateIAPUserOIDCConfigResponse"/></returns>
        public Task<CreateIAPUserOIDCConfigResponse> CreateIAPUserOIDCConfig(CreateIAPUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateIAPUserOIDCConfigResponse>(req, "CreateIAPUserOIDCConfig");
        }

        /// <summary>
        /// 创建用户OIDC配置。只能创建一个用户OIDC身份提供商，并且创建用户OIDC配置之后会自动关闭用户SAML SSO身份提供商。
        /// </summary>
        /// <param name="req"><see cref="CreateIAPUserOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateIAPUserOIDCConfigResponse"/></returns>
        public CreateIAPUserOIDCConfigResponse CreateIAPUserOIDCConfigSync(CreateIAPUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateIAPUserOIDCConfigResponse>(req, "CreateIAPUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询登录会话时长
        /// </summary>
        /// <param name="req"><see cref="DescribeIAPLoginSessionDurationRequest"/></param>
        /// <returns><see cref="DescribeIAPLoginSessionDurationResponse"/></returns>
        public Task<DescribeIAPLoginSessionDurationResponse> DescribeIAPLoginSessionDuration(DescribeIAPLoginSessionDurationRequest req)
        {
            return InternalRequestAsync<DescribeIAPLoginSessionDurationResponse>(req, "DescribeIAPLoginSessionDuration");
        }

        /// <summary>
        /// 查询登录会话时长
        /// </summary>
        /// <param name="req"><see cref="DescribeIAPLoginSessionDurationRequest"/></param>
        /// <returns><see cref="DescribeIAPLoginSessionDurationResponse"/></returns>
        public DescribeIAPLoginSessionDurationResponse DescribeIAPLoginSessionDurationSync(DescribeIAPLoginSessionDurationRequest req)
        {
            return InternalRequestAsync<DescribeIAPLoginSessionDurationResponse>(req, "DescribeIAPLoginSessionDuration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="DescribeIAPUserOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeIAPUserOIDCConfigResponse"/></returns>
        public Task<DescribeIAPUserOIDCConfigResponse> DescribeIAPUserOIDCConfig(DescribeIAPUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeIAPUserOIDCConfigResponse>(req, "DescribeIAPUserOIDCConfig");
        }

        /// <summary>
        /// 查询用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="DescribeIAPUserOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeIAPUserOIDCConfigResponse"/></returns>
        public DescribeIAPUserOIDCConfigResponse DescribeIAPUserOIDCConfigSync(DescribeIAPUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeIAPUserOIDCConfigResponse>(req, "DescribeIAPUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用用户SSO
        /// </summary>
        /// <param name="req"><see cref="DisableIAPUserSSORequest"/></param>
        /// <returns><see cref="DisableIAPUserSSOResponse"/></returns>
        public Task<DisableIAPUserSSOResponse> DisableIAPUserSSO(DisableIAPUserSSORequest req)
        {
            return InternalRequestAsync<DisableIAPUserSSOResponse>(req, "DisableIAPUserSSO");
        }

        /// <summary>
        /// 禁用用户SSO
        /// </summary>
        /// <param name="req"><see cref="DisableIAPUserSSORequest"/></param>
        /// <returns><see cref="DisableIAPUserSSOResponse"/></returns>
        public DisableIAPUserSSOResponse DisableIAPUserSSOSync(DisableIAPUserSSORequest req)
        {
            return InternalRequestAsync<DisableIAPUserSSOResponse>(req, "DisableIAPUserSSO")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改登录会话时长
        /// </summary>
        /// <param name="req"><see cref="ModifyIAPLoginSessionDurationRequest"/></param>
        /// <returns><see cref="ModifyIAPLoginSessionDurationResponse"/></returns>
        public Task<ModifyIAPLoginSessionDurationResponse> ModifyIAPLoginSessionDuration(ModifyIAPLoginSessionDurationRequest req)
        {
            return InternalRequestAsync<ModifyIAPLoginSessionDurationResponse>(req, "ModifyIAPLoginSessionDuration");
        }

        /// <summary>
        /// 修改登录会话时长
        /// </summary>
        /// <param name="req"><see cref="ModifyIAPLoginSessionDurationRequest"/></param>
        /// <returns><see cref="ModifyIAPLoginSessionDurationResponse"/></returns>
        public ModifyIAPLoginSessionDurationResponse ModifyIAPLoginSessionDurationSync(ModifyIAPLoginSessionDurationRequest req)
        {
            return InternalRequestAsync<ModifyIAPLoginSessionDurationResponse>(req, "ModifyIAPLoginSessionDuration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="UpdateIAPUserOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateIAPUserOIDCConfigResponse"/></returns>
        public Task<UpdateIAPUserOIDCConfigResponse> UpdateIAPUserOIDCConfig(UpdateIAPUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateIAPUserOIDCConfigResponse>(req, "UpdateIAPUserOIDCConfig");
        }

        /// <summary>
        /// 修改用户OIDC配置
        /// </summary>
        /// <param name="req"><see cref="UpdateIAPUserOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateIAPUserOIDCConfigResponse"/></returns>
        public UpdateIAPUserOIDCConfigResponse UpdateIAPUserOIDCConfigSync(UpdateIAPUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateIAPUserOIDCConfigResponse>(req, "UpdateIAPUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
