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

namespace TencentCloud.Cloudstudio.V20230508
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudstudio.V20230508.Models;

   public class CloudstudioClient : AbstractClient{

       private const string endpoint = "cloudstudio.tencentcloudapi.com";
       private const string version = "2023-05-08";
       private const string sdkVersion = "SDK_NET_3.0.1189";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudstudioClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudstudioClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public Task<CreateWorkspaceResponse> CreateWorkspace(CreateWorkspaceRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceResponse>(req, "CreateWorkspace");
        }

        /// <summary>
        /// 创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public CreateWorkspaceResponse CreateWorkspaceSync(CreateWorkspaceRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceResponse>(req, "CreateWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作空间临时访问凭证，重复调用会创建新的 Token，旧的 Token 将会自动失效
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceTokenRequest"/></param>
        /// <returns><see cref="CreateWorkspaceTokenResponse"/></returns>
        public Task<CreateWorkspaceTokenResponse> CreateWorkspaceToken(CreateWorkspaceTokenRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceTokenResponse>(req, "CreateWorkspaceToken");
        }

        /// <summary>
        /// 创建工作空间临时访问凭证，重复调用会创建新的 Token，旧的 Token 将会自动失效
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceTokenRequest"/></param>
        /// <returns><see cref="CreateWorkspaceTokenResponse"/></returns>
        public CreateWorkspaceTokenResponse CreateWorkspaceTokenSync(CreateWorkspaceTokenRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceTokenResponse>(req, "CreateWorkspaceToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig");
        }

        /// <summary>
        /// 获取用户配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// 获取基础镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public Task<DescribeWorkspacesResponse> DescribeWorkspaces(DescribeWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkspacesResponse>(req, "DescribeWorkspaces");
        }

        /// <summary>
        /// 获取用户工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspacesRequest"/></param>
        /// <returns><see cref="DescribeWorkspacesResponse"/></returns>
        public DescribeWorkspacesResponse DescribeWorkspacesSync(DescribeWorkspacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkspacesResponse>(req, "DescribeWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改工作空间
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceResponse"/></returns>
        public Task<ModifyWorkspaceResponse> ModifyWorkspace(ModifyWorkspaceRequest req)
        {
            return InternalRequestAsync<ModifyWorkspaceResponse>(req, "ModifyWorkspace");
        }

        /// <summary>
        /// 修改工作空间
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkspaceRequest"/></param>
        /// <returns><see cref="ModifyWorkspaceResponse"/></returns>
        public ModifyWorkspaceResponse ModifyWorkspaceSync(ModifyWorkspaceRequest req)
        {
            return InternalRequestAsync<ModifyWorkspaceResponse>(req, "ModifyWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceResponse"/></returns>
        public Task<RemoveWorkspaceResponse> RemoveWorkspace(RemoveWorkspaceRequest req)
        {
            return InternalRequestAsync<RemoveWorkspaceResponse>(req, "RemoveWorkspace");
        }

        /// <summary>
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceResponse"/></returns>
        public RemoveWorkspaceResponse RemoveWorkspaceSync(RemoveWorkspaceRequest req)
        {
            return InternalRequestAsync<RemoveWorkspaceResponse>(req, "RemoveWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运行空间
        /// </summary>
        /// <param name="req"><see cref="RunWorkspaceRequest"/></param>
        /// <returns><see cref="RunWorkspaceResponse"/></returns>
        public Task<RunWorkspaceResponse> RunWorkspace(RunWorkspaceRequest req)
        {
            return InternalRequestAsync<RunWorkspaceResponse>(req, "RunWorkspace");
        }

        /// <summary>
        /// 运行空间
        /// </summary>
        /// <param name="req"><see cref="RunWorkspaceRequest"/></param>
        /// <returns><see cref="RunWorkspaceResponse"/></returns>
        public RunWorkspaceResponse RunWorkspaceSync(RunWorkspaceRequest req)
        {
            return InternalRequestAsync<RunWorkspaceResponse>(req, "RunWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止运行空间
        /// </summary>
        /// <param name="req"><see cref="StopWorkspaceRequest"/></param>
        /// <returns><see cref="StopWorkspaceResponse"/></returns>
        public Task<StopWorkspaceResponse> StopWorkspace(StopWorkspaceRequest req)
        {
            return InternalRequestAsync<StopWorkspaceResponse>(req, "StopWorkspace");
        }

        /// <summary>
        /// 停止运行空间
        /// </summary>
        /// <param name="req"><see cref="StopWorkspaceRequest"/></param>
        /// <returns><see cref="StopWorkspaceResponse"/></returns>
        public StopWorkspaceResponse StopWorkspaceSync(StopWorkspaceRequest req)
        {
            return InternalRequestAsync<StopWorkspaceResponse>(req, "StopWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
