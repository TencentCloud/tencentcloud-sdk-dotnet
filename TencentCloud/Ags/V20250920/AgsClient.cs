/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ags.V20250920
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ags.V20250920.Models;

   public class AgsClient : AbstractClient{

       private const string endpoint = "ags.tencentcloudapi.com";
       private const string version = "2025-09-20";
       private const string sdkVersion = "SDK_NET_3.0.1375";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AgsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AgsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取访问沙箱工具时所需要使用的访问Token，创建沙箱实例后需调用此接口获取沙箱实例访问Token。
        /// 此Token可用于调用代码沙箱实例执行代码，或浏览器沙箱实例进行浏览器操作等。
        /// </summary>
        /// <param name="req"><see cref="AcquireSandboxInstanceTokenRequest"/></param>
        /// <returns><see cref="AcquireSandboxInstanceTokenResponse"/></returns>
        public Task<AcquireSandboxInstanceTokenResponse> AcquireSandboxInstanceToken(AcquireSandboxInstanceTokenRequest req)
        {
            return InternalRequestAsync<AcquireSandboxInstanceTokenResponse>(req, "AcquireSandboxInstanceToken");
        }

        /// <summary>
        /// 获取访问沙箱工具时所需要使用的访问Token，创建沙箱实例后需调用此接口获取沙箱实例访问Token。
        /// 此Token可用于调用代码沙箱实例执行代码，或浏览器沙箱实例进行浏览器操作等。
        /// </summary>
        /// <param name="req"><see cref="AcquireSandboxInstanceTokenRequest"/></param>
        /// <returns><see cref="AcquireSandboxInstanceTokenResponse"/></returns>
        public AcquireSandboxInstanceTokenResponse AcquireSandboxInstanceTokenSync(AcquireSandboxInstanceTokenRequest req)
        {
            return InternalRequestAsync<AcquireSandboxInstanceTokenResponse>(req, "AcquireSandboxInstanceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建新的API密钥，用于调用Agent Sandbox接口。相较于腾讯云Secret ID Secret Key支持调用所有接口使用，仅有部分接口支持使用API密钥调用。
        /// </summary>
        /// <param name="req"><see cref="CreateAPIKeyRequest"/></param>
        /// <returns><see cref="CreateAPIKeyResponse"/></returns>
        public Task<CreateAPIKeyResponse> CreateAPIKey(CreateAPIKeyRequest req)
        {
            return InternalRequestAsync<CreateAPIKeyResponse>(req, "CreateAPIKey");
        }

        /// <summary>
        /// 创建新的API密钥，用于调用Agent Sandbox接口。相较于腾讯云Secret ID Secret Key支持调用所有接口使用，仅有部分接口支持使用API密钥调用。
        /// </summary>
        /// <param name="req"><see cref="CreateAPIKeyRequest"/></param>
        /// <returns><see cref="CreateAPIKeyResponse"/></returns>
        public CreateAPIKeyResponse CreateAPIKeySync(CreateAPIKeyRequest req)
        {
            return InternalRequestAsync<CreateAPIKeyResponse>(req, "CreateAPIKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="CreatePreCacheImageTaskResponse"/></returns>
        public Task<CreatePreCacheImageTaskResponse> CreatePreCacheImageTask(CreatePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<CreatePreCacheImageTaskResponse>(req, "CreatePreCacheImageTask");
        }

        /// <summary>
        /// 创建镜像预热任务
        /// </summary>
        /// <param name="req"><see cref="CreatePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="CreatePreCacheImageTaskResponse"/></returns>
        public CreatePreCacheImageTaskResponse CreatePreCacheImageTaskSync(CreatePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<CreatePreCacheImageTaskResponse>(req, "CreatePreCacheImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建沙箱工具
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxToolRequest"/></param>
        /// <returns><see cref="CreateSandboxToolResponse"/></returns>
        public Task<CreateSandboxToolResponse> CreateSandboxTool(CreateSandboxToolRequest req)
        {
            return InternalRequestAsync<CreateSandboxToolResponse>(req, "CreateSandboxTool");
        }

        /// <summary>
        /// 创建沙箱工具
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxToolRequest"/></param>
        /// <returns><see cref="CreateSandboxToolResponse"/></returns>
        public CreateSandboxToolResponse CreateSandboxToolSync(CreateSandboxToolRequest req)
        {
            return InternalRequestAsync<CreateSandboxToolResponse>(req, "CreateSandboxTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除API密钥。注意区别于腾讯云Secret ID Secret Key，本接口删除的是Agent Sandbox专用API key。
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIKeyRequest"/></param>
        /// <returns><see cref="DeleteAPIKeyResponse"/></returns>
        public Task<DeleteAPIKeyResponse> DeleteAPIKey(DeleteAPIKeyRequest req)
        {
            return InternalRequestAsync<DeleteAPIKeyResponse>(req, "DeleteAPIKey");
        }

        /// <summary>
        /// 删除API密钥。注意区别于腾讯云Secret ID Secret Key，本接口删除的是Agent Sandbox专用API key。
        /// </summary>
        /// <param name="req"><see cref="DeleteAPIKeyRequest"/></param>
        /// <returns><see cref="DeleteAPIKeyResponse"/></returns>
        public DeleteAPIKeyResponse DeleteAPIKeySync(DeleteAPIKeyRequest req)
        {
            return InternalRequestAsync<DeleteAPIKeyResponse>(req, "DeleteAPIKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除沙箱工具
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxToolRequest"/></param>
        /// <returns><see cref="DeleteSandboxToolResponse"/></returns>
        public Task<DeleteSandboxToolResponse> DeleteSandboxTool(DeleteSandboxToolRequest req)
        {
            return InternalRequestAsync<DeleteSandboxToolResponse>(req, "DeleteSandboxTool");
        }

        /// <summary>
        /// 删除沙箱工具
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxToolRequest"/></param>
        /// <returns><see cref="DeleteSandboxToolResponse"/></returns>
        public DeleteSandboxToolResponse DeleteSandboxToolSync(DeleteSandboxToolRequest req)
        {
            return InternalRequestAsync<DeleteSandboxToolResponse>(req, "DeleteSandboxTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取API密钥列表，包含API密钥简略信息，包含名称、创建时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIKeyListRequest"/></param>
        /// <returns><see cref="DescribeAPIKeyListResponse"/></returns>
        public Task<DescribeAPIKeyListResponse> DescribeAPIKeyList(DescribeAPIKeyListRequest req)
        {
            return InternalRequestAsync<DescribeAPIKeyListResponse>(req, "DescribeAPIKeyList");
        }

        /// <summary>
        /// 获取API密钥列表，包含API密钥简略信息，包含名称、创建时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAPIKeyListRequest"/></param>
        /// <returns><see cref="DescribeAPIKeyListResponse"/></returns>
        public DescribeAPIKeyListResponse DescribeAPIKeyListSync(DescribeAPIKeyListRequest req)
        {
            return InternalRequestAsync<DescribeAPIKeyListResponse>(req, "DescribeAPIKeyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像预热任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="DescribePreCacheImageTaskResponse"/></returns>
        public Task<DescribePreCacheImageTaskResponse> DescribePreCacheImageTask(DescribePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<DescribePreCacheImageTaskResponse>(req, "DescribePreCacheImageTask");
        }

        /// <summary>
        /// 查询镜像预热任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribePreCacheImageTaskRequest"/></param>
        /// <returns><see cref="DescribePreCacheImageTaskResponse"/></returns>
        public DescribePreCacheImageTaskResponse DescribePreCacheImageTaskSync(DescribePreCacheImageTaskRequest req)
        {
            return InternalRequestAsync<DescribePreCacheImageTaskResponse>(req, "DescribePreCacheImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询沙箱实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSandboxInstanceListResponse"/></returns>
        public Task<DescribeSandboxInstanceListResponse> DescribeSandboxInstanceList(DescribeSandboxInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxInstanceListResponse>(req, "DescribeSandboxInstanceList");
        }

        /// <summary>
        /// 查询沙箱实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSandboxInstanceListResponse"/></returns>
        public DescribeSandboxInstanceListResponse DescribeSandboxInstanceListSync(DescribeSandboxInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxInstanceListResponse>(req, "DescribeSandboxInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询沙箱工具列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxToolListRequest"/></param>
        /// <returns><see cref="DescribeSandboxToolListResponse"/></returns>
        public Task<DescribeSandboxToolListResponse> DescribeSandboxToolList(DescribeSandboxToolListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxToolListResponse>(req, "DescribeSandboxToolList");
        }

        /// <summary>
        /// 查询沙箱工具列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxToolListRequest"/></param>
        /// <returns><see cref="DescribeSandboxToolListResponse"/></returns>
        public DescribeSandboxToolListResponse DescribeSandboxToolListSync(DescribeSandboxToolListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxToolListResponse>(req, "DescribeSandboxToolList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停沙箱实例
        /// </summary>
        /// <param name="req"><see cref="PauseSandboxInstanceRequest"/></param>
        /// <returns><see cref="PauseSandboxInstanceResponse"/></returns>
        public Task<PauseSandboxInstanceResponse> PauseSandboxInstance(PauseSandboxInstanceRequest req)
        {
            return InternalRequestAsync<PauseSandboxInstanceResponse>(req, "PauseSandboxInstance");
        }

        /// <summary>
        /// 暂停沙箱实例
        /// </summary>
        /// <param name="req"><see cref="PauseSandboxInstanceRequest"/></param>
        /// <returns><see cref="PauseSandboxInstanceResponse"/></returns>
        public PauseSandboxInstanceResponse PauseSandboxInstanceSync(PauseSandboxInstanceRequest req)
        {
            return InternalRequestAsync<PauseSandboxInstanceResponse>(req, "PauseSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复沙箱实例
        /// </summary>
        /// <param name="req"><see cref="ResumeSandboxInstanceRequest"/></param>
        /// <returns><see cref="ResumeSandboxInstanceResponse"/></returns>
        public Task<ResumeSandboxInstanceResponse> ResumeSandboxInstance(ResumeSandboxInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSandboxInstanceResponse>(req, "ResumeSandboxInstance");
        }

        /// <summary>
        /// 恢复沙箱实例
        /// </summary>
        /// <param name="req"><see cref="ResumeSandboxInstanceRequest"/></param>
        /// <returns><see cref="ResumeSandboxInstanceResponse"/></returns>
        public ResumeSandboxInstanceResponse ResumeSandboxInstanceSync(ResumeSandboxInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSandboxInstanceResponse>(req, "ResumeSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StartSandboxInstanceRequest"/></param>
        /// <returns><see cref="StartSandboxInstanceResponse"/></returns>
        public Task<StartSandboxInstanceResponse> StartSandboxInstance(StartSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StartSandboxInstanceResponse>(req, "StartSandboxInstance");
        }

        /// <summary>
        /// 启动沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StartSandboxInstanceRequest"/></param>
        /// <returns><see cref="StartSandboxInstanceResponse"/></returns>
        public StartSandboxInstanceResponse StartSandboxInstanceSync(StartSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StartSandboxInstanceResponse>(req, "StartSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StopSandboxInstanceRequest"/></param>
        /// <returns><see cref="StopSandboxInstanceResponse"/></returns>
        public Task<StopSandboxInstanceResponse> StopSandboxInstance(StopSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StopSandboxInstanceResponse>(req, "StopSandboxInstance");
        }

        /// <summary>
        /// 停止沙箱实例
        /// </summary>
        /// <param name="req"><see cref="StopSandboxInstanceRequest"/></param>
        /// <returns><see cref="StopSandboxInstanceResponse"/></returns>
        public StopSandboxInstanceResponse StopSandboxInstanceSync(StopSandboxInstanceRequest req)
        {
            return InternalRequestAsync<StopSandboxInstanceResponse>(req, "StopSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新沙箱实例
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxInstanceRequest"/></param>
        /// <returns><see cref="UpdateSandboxInstanceResponse"/></returns>
        public Task<UpdateSandboxInstanceResponse> UpdateSandboxInstance(UpdateSandboxInstanceRequest req)
        {
            return InternalRequestAsync<UpdateSandboxInstanceResponse>(req, "UpdateSandboxInstance");
        }

        /// <summary>
        /// 更新沙箱实例
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxInstanceRequest"/></param>
        /// <returns><see cref="UpdateSandboxInstanceResponse"/></returns>
        public UpdateSandboxInstanceResponse UpdateSandboxInstanceSync(UpdateSandboxInstanceRequest req)
        {
            return InternalRequestAsync<UpdateSandboxInstanceResponse>(req, "UpdateSandboxInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新沙箱工具
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxToolRequest"/></param>
        /// <returns><see cref="UpdateSandboxToolResponse"/></returns>
        public Task<UpdateSandboxToolResponse> UpdateSandboxTool(UpdateSandboxToolRequest req)
        {
            return InternalRequestAsync<UpdateSandboxToolResponse>(req, "UpdateSandboxTool");
        }

        /// <summary>
        /// 更新沙箱工具
        /// </summary>
        /// <param name="req"><see cref="UpdateSandboxToolRequest"/></param>
        /// <returns><see cref="UpdateSandboxToolResponse"/></returns>
        public UpdateSandboxToolResponse UpdateSandboxToolSync(UpdateSandboxToolRequest req)
        {
            return InternalRequestAsync<UpdateSandboxToolResponse>(req, "UpdateSandboxTool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
