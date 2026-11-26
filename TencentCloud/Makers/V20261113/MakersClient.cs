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

namespace TencentCloud.Makers.V20261113
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Makers.V20261113.Models;

   public class MakersClient : AbstractClient{

       private const string endpoint = "makers.tencentcloudapi.com";
       private const string version = "2026-11-13";
       private const string sdkVersion = "SDK_NET_3.0.1544";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MakersClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MakersClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 封禁或解封当前账号指定站点下的项目及域名。Status 支持 Ban或Normal。
        /// </summary>
        /// <param name="req"><see cref="BlockProjectRequest"/></param>
        /// <returns><see cref="BlockProjectResponse"/></returns>
        public Task<BlockProjectResponse> BlockProject(BlockProjectRequest req)
        {
            return InternalRequestAsync<BlockProjectResponse>(req, "BlockProject");
        }

        /// <summary>
        /// 封禁或解封当前账号指定站点下的项目及域名。Status 支持 Ban或Normal。
        /// </summary>
        /// <param name="req"><see cref="BlockProjectRequest"/></param>
        /// <returns><see cref="BlockProjectResponse"/></returns>
        public BlockProjectResponse BlockProjectSync(BlockProjectRequest req)
        {
            return InternalRequestAsync<BlockProjectResponse>(req, "BlockProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建部署。上传制品时 ViaMeta 和 Provider 传 Upload，TempBucketPath 传已上传对象的路径。
        /// </summary>
        /// <param name="req"><see cref="CreateDeploymentRequest"/></param>
        /// <returns><see cref="CreateDeploymentResponse"/></returns>
        public Task<CreateDeploymentResponse> CreateDeployment(CreateDeploymentRequest req)
        {
            return InternalRequestAsync<CreateDeploymentResponse>(req, "CreateDeployment");
        }

        /// <summary>
        /// 创建部署。上传制品时 ViaMeta 和 Provider 传 Upload，TempBucketPath 传已上传对象的路径。
        /// </summary>
        /// <param name="req"><see cref="CreateDeploymentRequest"/></param>
        /// <returns><see cref="CreateDeploymentResponse"/></returns>
        public CreateDeploymentResponse CreateDeploymentSync(CreateDeploymentRequest req)
        {
            return InternalRequestAsync<CreateDeploymentResponse>(req, "CreateDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建项目。上传制品时 Provider 传 Upload，Channel 传 Custom。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 创建项目。上传制品时 Provider 传 Upload，Channel 传 Custom。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 把一个自定义域名绑到项目的指定环境。
        /// </summary>
        /// <param name="req"><see cref="CreateZoneCustomDomainRequest"/></param>
        /// <returns><see cref="CreateZoneCustomDomainResponse"/></returns>
        public Task<CreateZoneCustomDomainResponse> CreateZoneCustomDomain(CreateZoneCustomDomainRequest req)
        {
            return InternalRequestAsync<CreateZoneCustomDomainResponse>(req, "CreateZoneCustomDomain");
        }

        /// <summary>
        /// 把一个自定义域名绑到项目的指定环境。
        /// </summary>
        /// <param name="req"><see cref="CreateZoneCustomDomainRequest"/></param>
        /// <returns><see cref="CreateZoneCustomDomainResponse"/></returns>
        public CreateZoneCustomDomainResponse CreateZoneCustomDomainSync(CreateZoneCustomDomainRequest req)
        {
            return InternalRequestAsync<CreateZoneCustomDomainResponse>(req, "CreateZoneCustomDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目。进行中的构建会阻止删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 删除项目。进行中的构建会阻止删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按域名解绑项目的自定义域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectCustomDomainsRequest"/></param>
        /// <returns><see cref="DeleteProjectCustomDomainsResponse"/></returns>
        public Task<DeleteProjectCustomDomainsResponse> DeleteProjectCustomDomains(DeleteProjectCustomDomainsRequest req)
        {
            return InternalRequestAsync<DeleteProjectCustomDomainsResponse>(req, "DeleteProjectCustomDomains");
        }

        /// <summary>
        /// 按域名解绑项目的自定义域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectCustomDomainsRequest"/></param>
        /// <returns><see cref="DeleteProjectCustomDomainsResponse"/></returns>
        public DeleteProjectCustomDomainsResponse DeleteProjectCustomDomainsSync(DeleteProjectCustomDomainsRequest req)
        {
            return InternalRequestAsync<DeleteProjectCustomDomainsResponse>(req, "DeleteProjectCustomDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按 EnvVars 删除环境变量。按 Id 或 Key 匹配。Value 必填但不参与匹配，可传任意值。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectEnvsRequest"/></param>
        /// <returns><see cref="DeleteProjectEnvsResponse"/></returns>
        public Task<DeleteProjectEnvsResponse> DeleteProjectEnvs(DeleteProjectEnvsRequest req)
        {
            return InternalRequestAsync<DeleteProjectEnvsResponse>(req, "DeleteProjectEnvs");
        }

        /// <summary>
        /// 按 EnvVars 删除环境变量。按 Id 或 Key 匹配。Value 必填但不参与匹配，可传任意值。
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectEnvsRequest"/></param>
        /// <returns><see cref="DeleteProjectEnvsResponse"/></returns>
        public DeleteProjectEnvsResponse DeleteProjectEnvsSync(DeleteProjectEnvsRequest req)
        {
            return InternalRequestAsync<DeleteProjectEnvsResponse>(req, "DeleteProjectEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取上传制品用的 COS 桶、地域、目标路径和临时密钥。
        /// </summary>
        /// <param name="req"><see cref="DescribeCosTempTokenRequest"/></param>
        /// <returns><see cref="DescribeCosTempTokenResponse"/></returns>
        public Task<DescribeCosTempTokenResponse> DescribeCosTempToken(DescribeCosTempTokenRequest req)
        {
            return InternalRequestAsync<DescribeCosTempTokenResponse>(req, "DescribeCosTempToken");
        }

        /// <summary>
        /// 获取上传制品用的 COS 桶、地域、目标路径和临时密钥。
        /// </summary>
        /// <param name="req"><see cref="DescribeCosTempTokenRequest"/></param>
        /// <returns><see cref="DescribeCosTempTokenResponse"/></returns>
        public DescribeCosTempTokenResponse DescribeCosTempTokenSync(DescribeCosTempTokenRequest req)
        {
            return InternalRequestAsync<DescribeCosTempTokenResponse>(req, "DescribeCosTempToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回构建日志的访问地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentLogRequest"/></param>
        /// <returns><see cref="DescribeDeploymentLogResponse"/></returns>
        public Task<DescribeDeploymentLogResponse> DescribeDeploymentLog(DescribeDeploymentLogRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentLogResponse>(req, "DescribeDeploymentLog");
        }

        /// <summary>
        /// 返回构建日志的访问地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentLogRequest"/></param>
        /// <returns><see cref="DescribeDeploymentLogResponse"/></returns>
        public DescribeDeploymentLogResponse DescribeDeploymentLogSync(DescribeDeploymentLogRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentLogResponse>(req, "DescribeDeploymentLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目的部署记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentsRequest"/></param>
        /// <returns><see cref="DescribeDeploymentsResponse"/></returns>
        public Task<DescribeDeploymentsResponse> DescribeDeployments(DescribeDeploymentsRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentsResponse>(req, "DescribeDeployments");
        }

        /// <summary>
        /// 查询项目的部署记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentsRequest"/></param>
        /// <returns><see cref="DescribeDeploymentsResponse"/></returns>
        public DescribeDeploymentsResponse DescribeDeploymentsSync(DescribeDeploymentsRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentsResponse>(req, "DescribeDeployments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目下的环境，含内置 Production、Preview 和自定义环境。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// 查询项目下的环境，含内置 Production、Preview 和自定义环境。
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目环境变量。不传 Env 时返回全部作用域。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectEnvsRequest"/></param>
        /// <returns><see cref="DescribeProjectEnvsResponse"/></returns>
        public Task<DescribeProjectEnvsResponse> DescribeProjectEnvs(DescribeProjectEnvsRequest req)
        {
            return InternalRequestAsync<DescribeProjectEnvsResponse>(req, "DescribeProjectEnvs");
        }

        /// <summary>
        /// 查询项目环境变量。不传 Env 时返回全部作用域。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectEnvsRequest"/></param>
        /// <returns><see cref="DescribeProjectEnvsResponse"/></returns>
        public DescribeProjectEnvsResponse DescribeProjectEnvsSync(DescribeProjectEnvsRequest req)
        {
            return InternalRequestAsync<DescribeProjectEnvsResponse>(req, "DescribeProjectEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询站点下的项目。Offset 是页码偏移，后端按 Offset * Limit 跳过。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 分页查询站点下的项目。Offset 是页码偏移，后端按 Offset * Limit 跳过。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目在站点下的自定义域名和预设域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneCustomDomainsRequest"/></param>
        /// <returns><see cref="DescribeZoneCustomDomainsResponse"/></returns>
        public Task<DescribeZoneCustomDomainsResponse> DescribeZoneCustomDomains(DescribeZoneCustomDomainsRequest req)
        {
            return InternalRequestAsync<DescribeZoneCustomDomainsResponse>(req, "DescribeZoneCustomDomains");
        }

        /// <summary>
        /// 查询项目在站点下的自定义域名和预设域名。
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneCustomDomainsRequest"/></param>
        /// <returns><see cref="DescribeZoneCustomDomainsResponse"/></returns>
        public DescribeZoneCustomDomainsResponse DescribeZoneCustomDomainsSync(DescribeZoneCustomDomainsRequest req)
        {
            return InternalRequestAsync<DescribeZoneCustomDomainsResponse>(req, "DescribeZoneCustomDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改项目名称和构建配置。未传的字段保持原值。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 修改项目名称和构建配置。未传的字段保持原值。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按传入的 EnvVars 写入环境变量。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectEnvsRequest"/></param>
        /// <returns><see cref="ModifyProjectEnvsResponse"/></returns>
        public Task<ModifyProjectEnvsResponse> ModifyProjectEnvs(ModifyProjectEnvsRequest req)
        {
            return InternalRequestAsync<ModifyProjectEnvsResponse>(req, "ModifyProjectEnvs");
        }

        /// <summary>
        /// 按传入的 EnvVars 写入环境变量。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectEnvsRequest"/></param>
        /// <returns><see cref="ModifyProjectEnvsResponse"/></returns>
        public ModifyProjectEnvsResponse ModifyProjectEnvsSync(ModifyProjectEnvsRequest req)
        {
            return InternalRequestAsync<ModifyProjectEnvsResponse>(req, "ModifyProjectEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 把已绑定的自定义域名切到另一个环境。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCustomDomainEnvRequest"/></param>
        /// <returns><see cref="ModifyZoneCustomDomainEnvResponse"/></returns>
        public Task<ModifyZoneCustomDomainEnvResponse> ModifyZoneCustomDomainEnv(ModifyZoneCustomDomainEnvRequest req)
        {
            return InternalRequestAsync<ModifyZoneCustomDomainEnvResponse>(req, "ModifyZoneCustomDomainEnv");
        }

        /// <summary>
        /// 把已绑定的自定义域名切到另一个环境。
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCustomDomainEnvRequest"/></param>
        /// <returns><see cref="ModifyZoneCustomDomainEnvResponse"/></returns>
        public ModifyZoneCustomDomainEnvResponse ModifyZoneCustomDomainEnvSync(ModifyZoneCustomDomainEnvRequest req)
        {
            return InternalRequestAsync<ModifyZoneCustomDomainEnvResponse>(req, "ModifyZoneCustomDomainEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
