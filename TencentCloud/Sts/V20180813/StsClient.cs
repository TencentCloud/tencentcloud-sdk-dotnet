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

namespace TencentCloud.Sts.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sts.V20180813.Models;

   public class StsClient : AbstractClient{

       private const string endpoint = "sts.tencentcloudapi.com";
       private const string version = "2018-08-13";
       private const string sdkVersion = "SDK_NET_3.0.1048";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public StsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public StsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 申请扮演角色临时访问凭证。
        /// 
        /// 1、角色策略组成
        /// 
        /// （1）角色信任策略：指定谁可以扮演该角色；
        /// 
        /// （2）角色权限策略：指定扮演角色后可以执行哪些操作。
        /// 
        /// 
        /// 2、角色可扮演条件
        /// 
        /// （1）给用户绑定允许调用AssumeRole的策略 ；
        /// 
        /// （2）将用户添加为角色信任策略中的主体。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public Task<AssumeRoleResponse> AssumeRole(AssumeRoleRequest req)
        {
            return InternalRequestAsync<AssumeRoleResponse>(req, "AssumeRole");
        }

        /// <summary>
        /// 申请扮演角色临时访问凭证。
        /// 
        /// 1、角色策略组成
        /// 
        /// （1）角色信任策略：指定谁可以扮演该角色；
        /// 
        /// （2）角色权限策略：指定扮演角色后可以执行哪些操作。
        /// 
        /// 
        /// 2、角色可扮演条件
        /// 
        /// （1）给用户绑定允许调用AssumeRole的策略 ；
        /// 
        /// （2）将用户添加为角色信任策略中的主体。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public AssumeRoleResponse AssumeRoleSync(AssumeRoleRequest req)
        {
            return InternalRequestAsync<AssumeRoleResponse>(req, "AssumeRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（AssumeRoleWithSAML）用于根据 SAML 断言申请角色临时访问凭证。
        /// 
        /// 注意：当使用签名方法 V3 调用本接口时，请求头无须传入 X-TC-Token, 但 Authorization 需要传入值 SKIP。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAML(AssumeRoleWithSAMLRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithSAMLResponse>(req, "AssumeRoleWithSAML");
        }

        /// <summary>
        /// 本接口（AssumeRoleWithSAML）用于根据 SAML 断言申请角色临时访问凭证。
        /// 
        /// 注意：当使用签名方法 V3 调用本接口时，请求头无须传入 X-TC-Token, 但 Authorization 需要传入值 SKIP。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAMLSync(AssumeRoleWithSAMLRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithSAMLResponse>(req, "AssumeRoleWithSAML")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请OIDC角色临时访问凭证。
        /// 
        /// 注意：当使用签名方法 V3 调用本接口时，请求头无须传入 X-TC-Token, 但 Authorization 需要传入值 SKIP。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithWebIdentityResponse>(req, "AssumeRoleWithWebIdentity");
        }

        /// <summary>
        /// 申请OIDC角色临时访问凭证。
        /// 
        /// 注意：当使用签名方法 V3 调用本接口时，请求头无须传入 X-TC-Token, 但 Authorization 需要传入值 SKIP。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentitySync(AssumeRoleWithWebIdentityRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithWebIdentityResponse>(req, "AssumeRoleWithWebIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前调用者的身份信息。
        /// 
        /// 接口支持主账号，子账号长期密钥以及AssumeRole，GetFederationToken生成的临时访问凭证身份获取。
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public Task<GetCallerIdentityResponse> GetCallerIdentity(GetCallerIdentityRequest req)
        {
            return InternalRequestAsync<GetCallerIdentityResponse>(req, "GetCallerIdentity");
        }

        /// <summary>
        /// 获取当前调用者的身份信息。
        /// 
        /// 接口支持主账号，子账号长期密钥以及AssumeRole，GetFederationToken生成的临时访问凭证身份获取。
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public GetCallerIdentityResponse GetCallerIdentitySync(GetCallerIdentityRequest req)
        {
            return InternalRequestAsync<GetCallerIdentityResponse>(req, "GetCallerIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// **使用说明**
        /// 
        /// 返回一组临时访问凭证，典型的应用场景是代理应用程序集中申请临时访问凭证，下发给企业网络内其他分布式终端应用，比如终端应用上传文件到COS场景，本接口仅支持永久密钥调用。
        /// 
        /// **最佳实践**
        /// 
        /// 1. 临时访问凭据在有效期内都可以使用，建议在有效期内重复使用，以避免业务请求速率上升后被限频
        /// 2. 授予临时访问凭证权限的CAM策略，建议按权限最小化原则
        /// 3. 调用接口的永久密钥，建议不要使用主账号
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public Task<GetFederationTokenResponse> GetFederationToken(GetFederationTokenRequest req)
        {
            return InternalRequestAsync<GetFederationTokenResponse>(req, "GetFederationToken");
        }

        /// <summary>
        /// **使用说明**
        /// 
        /// 返回一组临时访问凭证，典型的应用场景是代理应用程序集中申请临时访问凭证，下发给企业网络内其他分布式终端应用，比如终端应用上传文件到COS场景，本接口仅支持永久密钥调用。
        /// 
        /// **最佳实践**
        /// 
        /// 1. 临时访问凭据在有效期内都可以使用，建议在有效期内重复使用，以避免业务请求速率上升后被限频
        /// 2. 授予临时访问凭证权限的CAM策略，建议按权限最小化原则
        /// 3. 调用接口的永久密钥，建议不要使用主账号
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public GetFederationTokenResponse GetFederationTokenSync(GetFederationTokenRequest req)
        {
            return InternalRequestAsync<GetFederationTokenResponse>(req, "GetFederationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取API密钥列表
        /// </summary>
        /// <param name="req"><see cref="QueryApiKeyRequest"/></param>
        /// <returns><see cref="QueryApiKeyResponse"/></returns>
        public Task<QueryApiKeyResponse> QueryApiKey(QueryApiKeyRequest req)
        {
            return InternalRequestAsync<QueryApiKeyResponse>(req, "QueryApiKey");
        }

        /// <summary>
        /// 拉取API密钥列表
        /// </summary>
        /// <param name="req"><see cref="QueryApiKeyRequest"/></param>
        /// <returns><see cref="QueryApiKeyResponse"/></returns>
        public QueryApiKeyResponse QueryApiKeySync(QueryApiKeyRequest req)
        {
            return InternalRequestAsync<QueryApiKeyResponse>(req, "QueryApiKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
