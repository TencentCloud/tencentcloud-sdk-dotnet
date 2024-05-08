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

namespace TencentCloud.Smh.V20210712
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Smh.V20210712.Models;

   public class SmhClient : AbstractClient{

       private const string endpoint = "smh.tencentcloudapi.com";
       private const string version = "2021-07-12";
       private const string sdkVersion = "SDK_NET_3.0.1000";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmhClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SmhClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="CreateLibraryRequest"/></param>
        /// <returns><see cref="CreateLibraryResponse"/></returns>
        public Task<CreateLibraryResponse> CreateLibrary(CreateLibraryRequest req)
        {
            return InternalRequestAsync<CreateLibraryResponse>(req, "CreateLibrary");
        }

        /// <summary>
        /// 创建 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="CreateLibraryRequest"/></param>
        /// <returns><see cref="CreateLibraryResponse"/></returns>
        public CreateLibraryResponse CreateLibrarySync(CreateLibraryRequest req)
        {
            return InternalRequestAsync<CreateLibraryResponse>(req, "CreateLibrary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraryRequest"/></param>
        /// <returns><see cref="DeleteLibraryResponse"/></returns>
        public Task<DeleteLibraryResponse> DeleteLibrary(DeleteLibraryRequest req)
        {
            return InternalRequestAsync<DeleteLibraryResponse>(req, "DeleteLibrary");
        }

        /// <summary>
        /// 删除 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraryRequest"/></param>
        /// <returns><see cref="DeleteLibraryResponse"/></returns>
        public DeleteLibraryResponse DeleteLibrarySync(DeleteLibraryRequest req)
        {
            return InternalRequestAsync<DeleteLibraryResponse>(req, "DeleteLibrary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrariesRequest"/></param>
        /// <returns><see cref="DescribeLibrariesResponse"/></returns>
        public Task<DescribeLibrariesResponse> DescribeLibraries(DescribeLibrariesRequest req)
        {
            return InternalRequestAsync<DescribeLibrariesResponse>(req, "DescribeLibraries");
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrariesRequest"/></param>
        /// <returns><see cref="DescribeLibrariesResponse"/></returns>
        public DescribeLibrariesResponse DescribeLibrariesSync(DescribeLibrariesRequest req)
        {
            return InternalRequestAsync<DescribeLibrariesResponse>(req, "DescribeLibraries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrarySecretRequest"/></param>
        /// <returns><see cref="DescribeLibrarySecretResponse"/></returns>
        public Task<DescribeLibrarySecretResponse> DescribeLibrarySecret(DescribeLibrarySecretRequest req)
        {
            return InternalRequestAsync<DescribeLibrarySecretResponse>(req, "DescribeLibrarySecret");
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrarySecretRequest"/></param>
        /// <returns><see cref="DescribeLibrarySecretResponse"/></returns>
        public DescribeLibrarySecretResponse DescribeLibrarySecretSync(DescribeLibrarySecretRequest req)
        {
            return InternalRequestAsync<DescribeLibrarySecretResponse>(req, "DescribeLibrarySecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询官方云盘实例
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialInstancesRequest"/></param>
        /// <returns><see cref="DescribeOfficialInstancesResponse"/></returns>
        public Task<DescribeOfficialInstancesResponse> DescribeOfficialInstances(DescribeOfficialInstancesRequest req)
        {
            return InternalRequestAsync<DescribeOfficialInstancesResponse>(req, "DescribeOfficialInstances");
        }

        /// <summary>
        /// 查询官方云盘实例
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialInstancesRequest"/></param>
        /// <returns><see cref="DescribeOfficialInstancesResponse"/></returns>
        public DescribeOfficialInstancesResponse DescribeOfficialInstancesSync(DescribeOfficialInstancesRequest req)
        {
            return InternalRequestAsync<DescribeOfficialInstancesResponse>(req, "DescribeOfficialInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询官方云盘实例概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialOverviewRequest"/></param>
        /// <returns><see cref="DescribeOfficialOverviewResponse"/></returns>
        public Task<DescribeOfficialOverviewResponse> DescribeOfficialOverview(DescribeOfficialOverviewRequest req)
        {
            return InternalRequestAsync<DescribeOfficialOverviewResponse>(req, "DescribeOfficialOverview");
        }

        /// <summary>
        /// 查询官方云盘实例概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialOverviewRequest"/></param>
        /// <returns><see cref="DescribeOfficialOverviewResponse"/></returns>
        public DescribeOfficialOverviewResponse DescribeOfficialOverviewSync(DescribeOfficialOverviewRequest req)
        {
            return InternalRequestAsync<DescribeOfficialOverviewResponse>(req, "DescribeOfficialOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询流量资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages");
        }

        /// <summary>
        /// 查询流量资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 PaaS 服务媒体库配置项
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraryRequest"/></param>
        /// <returns><see cref="ModifyLibraryResponse"/></returns>
        public Task<ModifyLibraryResponse> ModifyLibrary(ModifyLibraryRequest req)
        {
            return InternalRequestAsync<ModifyLibraryResponse>(req, "ModifyLibrary");
        }

        /// <summary>
        /// 修改 PaaS 服务媒体库配置项
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraryRequest"/></param>
        /// <returns><see cref="ModifyLibraryResponse"/></returns>
        public ModifyLibraryResponse ModifyLibrarySync(ModifyLibraryRequest req)
        {
            return InternalRequestAsync<ModifyLibraryResponse>(req, "ModifyLibrary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送用于换绑官方云盘实例的超级管理员账号的短信验证码
        /// </summary>
        /// <param name="req"><see cref="SendSmsCodeRequest"/></param>
        /// <returns><see cref="SendSmsCodeResponse"/></returns>
        public Task<SendSmsCodeResponse> SendSmsCode(SendSmsCodeRequest req)
        {
            return InternalRequestAsync<SendSmsCodeResponse>(req, "SendSmsCode");
        }

        /// <summary>
        /// 发送用于换绑官方云盘实例的超级管理员账号的短信验证码
        /// </summary>
        /// <param name="req"><see cref="SendSmsCodeRequest"/></param>
        /// <returns><see cref="SendSmsCodeResponse"/></returns>
        public SendSmsCodeResponse SendSmsCodeSync(SendSmsCodeRequest req)
        {
            return InternalRequestAsync<SendSmsCodeResponse>(req, "SendSmsCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证短信验证码以换绑官方云盘实例的超级管理员账号
        /// </summary>
        /// <param name="req"><see cref="VerifySmsCodeRequest"/></param>
        /// <returns><see cref="VerifySmsCodeResponse"/></returns>
        public Task<VerifySmsCodeResponse> VerifySmsCode(VerifySmsCodeRequest req)
        {
            return InternalRequestAsync<VerifySmsCodeResponse>(req, "VerifySmsCode");
        }

        /// <summary>
        /// 验证短信验证码以换绑官方云盘实例的超级管理员账号
        /// </summary>
        /// <param name="req"><see cref="VerifySmsCodeRequest"/></param>
        /// <returns><see cref="VerifySmsCodeResponse"/></returns>
        public VerifySmsCodeResponse VerifySmsCodeSync(VerifySmsCodeRequest req)
        {
            return InternalRequestAsync<VerifySmsCodeResponse>(req, "VerifySmsCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
