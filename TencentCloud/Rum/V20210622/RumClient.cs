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

namespace TencentCloud.Rum.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rum.V20210622.Models;

   public class RumClient : AbstractClient{

       private const string endpoint = "rum.tencentcloudapi.com";
       private const string version = "2021-06-22";
       private const string sdkVersion = "SDK_NET_3.0.1526";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RumClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RumClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建字段配置规则
        /// </summary>
        /// <param name="req"><see cref="CreateFieldTransformRuleRequest"/></param>
        /// <returns><see cref="CreateFieldTransformRuleResponse"/></returns>
        public Task<CreateFieldTransformRuleResponse> CreateFieldTransformRule(CreateFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<CreateFieldTransformRuleResponse>(req, "CreateFieldTransformRule");
        }

        /// <summary>
        /// 创建字段配置规则
        /// </summary>
        /// <param name="req"><see cref="CreateFieldTransformRuleRequest"/></param>
        /// <returns><see cref="CreateFieldTransformRuleResponse"/></returns>
        public CreateFieldTransformRuleResponse CreateFieldTransformRuleSync(CreateFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<CreateFieldTransformRuleResponse>(req, "CreateFieldTransformRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建对应项目的文件记录
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public Task<CreateReleaseFileResponse> CreateReleaseFile(CreateReleaseFileRequest req)
        {
            return InternalRequestAsync<CreateReleaseFileResponse>(req, "CreateReleaseFile");
        }

        /// <summary>
        /// 创建对应项目的文件记录
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public CreateReleaseFileResponse CreateReleaseFileSync(CreateReleaseFileRequest req)
        {
            return InternalRequestAsync<CreateReleaseFileResponse>(req, "CreateReleaseFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 个人用户添加星标项目
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public Task<CreateStarProjectResponse> CreateStarProject(CreateStarProjectRequest req)
        {
            return InternalRequestAsync<CreateStarProjectResponse>(req, "CreateStarProject");
        }

        /// <summary>
        /// 个人用户添加星标项目
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public CreateStarProjectResponse CreateStarProjectSync(CreateStarProjectRequest req)
        {
            return InternalRequestAsync<CreateStarProjectResponse>(req, "CreateStarProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在指定业务系统下创建应用。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMApplicationRequest"/></param>
        /// <returns><see cref="CreateTDEMApplicationResponse"/></returns>
        public Task<CreateTDEMApplicationResponse> CreateTDEMApplication(CreateTDEMApplicationRequest req)
        {
            return InternalRequestAsync<CreateTDEMApplicationResponse>(req, "CreateTDEMApplication");
        }

        /// <summary>
        /// 在指定业务系统下创建应用。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMApplicationRequest"/></param>
        /// <returns><see cref="CreateTDEMApplicationResponse"/></returns>
        public CreateTDEMApplicationResponse CreateTDEMApplicationSync(CreateTDEMApplicationRequest req)
        {
            return InternalRequestAsync<CreateTDEMApplicationResponse>(req, "CreateTDEMApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建业务系统。InstanceId 由后端生成，格式 rum-<12 位随机字母数字>。重名返回 InvalidParameterValue。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMBusinessSystemRequest"/></param>
        /// <returns><see cref="CreateTDEMBusinessSystemResponse"/></returns>
        public Task<CreateTDEMBusinessSystemResponse> CreateTDEMBusinessSystem(CreateTDEMBusinessSystemRequest req)
        {
            return InternalRequestAsync<CreateTDEMBusinessSystemResponse>(req, "CreateTDEMBusinessSystem");
        }

        /// <summary>
        /// 创建业务系统。InstanceId 由后端生成，格式 rum-<12 位随机字母数字>。重名返回 InvalidParameterValue。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMBusinessSystemRequest"/></param>
        /// <returns><see cref="CreateTDEMBusinessSystemResponse"/></returns>
        public CreateTDEMBusinessSystemResponse CreateTDEMBusinessSystemSync(CreateTDEMBusinessSystemRequest req)
        {
            return InternalRequestAsync<CreateTDEMBusinessSystemResponse>(req, "CreateTDEMBusinessSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一条移动拨测任务。同一应用处于 active 的任务最多 50 条。四项启动范围都为空时不限制启动；填写多项时必须同时满足，同一项多个值命中任意一个即可。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMDialTaskRequest"/></param>
        /// <returns><see cref="CreateTDEMDialTaskResponse"/></returns>
        public Task<CreateTDEMDialTaskResponse> CreateTDEMDialTask(CreateTDEMDialTaskRequest req)
        {
            return InternalRequestAsync<CreateTDEMDialTaskResponse>(req, "CreateTDEMDialTask");
        }

        /// <summary>
        /// 创建一条移动拨测任务。同一应用处于 active 的任务最多 50 条。四项启动范围都为空时不限制启动；填写多项时必须同时满足，同一项多个值命中任意一个即可。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMDialTaskRequest"/></param>
        /// <returns><see cref="CreateTDEMDialTaskResponse"/></returns>
        public CreateTDEMDialTaskResponse CreateTDEMDialTaskSync(CreateTDEMDialTaskRequest req)
        {
            return InternalRequestAsync<CreateTDEMDialTaskResponse>(req, "CreateTDEMDialTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为应用创建字段值替换规则，单应用上限 50 条。替代已废弃的 CreateFieldTransformRule；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMFieldTransformRuleRequest"/></param>
        /// <returns><see cref="CreateTDEMFieldTransformRuleResponse"/></returns>
        public Task<CreateTDEMFieldTransformRuleResponse> CreateTDEMFieldTransformRule(CreateTDEMFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<CreateTDEMFieldTransformRuleResponse>(req, "CreateTDEMFieldTransformRule");
        }

        /// <summary>
        /// 为应用创建字段值替换规则，单应用上限 50 条。替代已废弃的 CreateFieldTransformRule；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMFieldTransformRuleRequest"/></param>
        /// <returns><see cref="CreateTDEMFieldTransformRuleResponse"/></returns>
        public CreateTDEMFieldTransformRuleResponse CreateTDEMFieldTransformRuleSync(CreateTDEMFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<CreateTDEMFieldTransformRuleResponse>(req, "CreateTDEMFieldTransformRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建漏斗
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMFunnelRequest"/></param>
        /// <returns><see cref="CreateTDEMFunnelResponse"/></returns>
        public Task<CreateTDEMFunnelResponse> CreateTDEMFunnel(CreateTDEMFunnelRequest req)
        {
            return InternalRequestAsync<CreateTDEMFunnelResponse>(req, "CreateTDEMFunnel");
        }

        /// <summary>
        /// 创建漏斗
        /// </summary>
        /// <param name="req"><see cref="CreateTDEMFunnelRequest"/></param>
        /// <returns><see cref="CreateTDEMFunnelResponse"/></returns>
        public CreateTDEMFunnelResponse CreateTDEMFunnelSync(CreateTDEMFunnelRequest req)
        {
            return InternalRequestAsync<CreateTDEMFunnelResponse>(req, "CreateTDEMFunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建白名单
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public Task<CreateWhitelistResponse> CreateWhitelist(CreateWhitelistRequest req)
        {
            return InternalRequestAsync<CreateWhitelistResponse>(req, "CreateWhitelist");
        }

        /// <summary>
        /// 创建白名单
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public CreateWhitelistResponse CreateWhitelistSync(CreateWhitelistRequest req)
        {
            return InternalRequestAsync<CreateWhitelistResponse>(req, "CreateWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除字段配置规则
        /// </summary>
        /// <param name="req"><see cref="DeleteFieldTransformRuleRequest"/></param>
        /// <returns><see cref="DeleteFieldTransformRuleResponse"/></returns>
        public Task<DeleteFieldTransformRuleResponse> DeleteFieldTransformRule(DeleteFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<DeleteFieldTransformRuleResponse>(req, "DeleteFieldTransformRule");
        }

        /// <summary>
        /// 删除字段配置规则
        /// </summary>
        /// <param name="req"><see cref="DeleteFieldTransformRuleRequest"/></param>
        /// <returns><see cref="DeleteFieldTransformRuleResponse"/></returns>
        public DeleteFieldTransformRuleResponse DeleteFieldTransformRuleSync(DeleteFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<DeleteFieldTransformRuleResponse>(req, "DeleteFieldTransformRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例，谨慎操作，不可恢复
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// 删除实例，谨慎操作，不可恢复
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除回放包元数据，并尽力删除COS上回放包与源码zip。不存在返回ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="DeleteMiniProgramReplayPackRequest"/></param>
        /// <returns><see cref="DeleteMiniProgramReplayPackResponse"/></returns>
        public Task<DeleteMiniProgramReplayPackResponse> DeleteMiniProgramReplayPack(DeleteMiniProgramReplayPackRequest req)
        {
            return InternalRequestAsync<DeleteMiniProgramReplayPackResponse>(req, "DeleteMiniProgramReplayPack");
        }

        /// <summary>
        /// 删除回放包元数据，并尽力删除COS上回放包与源码zip。不存在返回ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="DeleteMiniProgramReplayPackRequest"/></param>
        /// <returns><see cref="DeleteMiniProgramReplayPackResponse"/></returns>
        public DeleteMiniProgramReplayPackResponse DeleteMiniProgramReplayPackSync(DeleteMiniProgramReplayPackRequest req)
        {
            return InternalRequestAsync<DeleteMiniProgramReplayPackResponse>(req, "DeleteMiniProgramReplayPack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除给定的 rum 的项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 删除给定的 rum 的项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将对应 sourcemap 文件删除
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public Task<DeleteReleaseFileResponse> DeleteReleaseFile(DeleteReleaseFileRequest req)
        {
            return InternalRequestAsync<DeleteReleaseFileResponse>(req, "DeleteReleaseFile");
        }

        /// <summary>
        /// 将对应 sourcemap 文件删除
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public DeleteReleaseFileResponse DeleteReleaseFileSync(DeleteReleaseFileRequest req)
        {
            return InternalRequestAsync<DeleteReleaseFileResponse>(req, "DeleteReleaseFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户名下的星标项目
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public Task<DeleteStarProjectResponse> DeleteStarProject(DeleteStarProjectRequest req)
        {
            return InternalRequestAsync<DeleteStarProjectResponse>(req, "DeleteStarProject");
        }

        /// <summary>
        /// 删除用户名下的星标项目
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public DeleteStarProjectResponse DeleteStarProjectSync(DeleteStarProjectRequest req)
        {
            return InternalRequestAsync<DeleteStarProjectResponse>(req, "DeleteStarProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定的符号制品。
        /// </summary>
        /// <param name="req"><see cref="DeleteSymbolArtifactRequest"/></param>
        /// <returns><see cref="DeleteSymbolArtifactResponse"/></returns>
        public Task<DeleteSymbolArtifactResponse> DeleteSymbolArtifact(DeleteSymbolArtifactRequest req)
        {
            return InternalRequestAsync<DeleteSymbolArtifactResponse>(req, "DeleteSymbolArtifact");
        }

        /// <summary>
        /// 删除指定的符号制品。
        /// </summary>
        /// <param name="req"><see cref="DeleteSymbolArtifactRequest"/></param>
        /// <returns><see cref="DeleteSymbolArtifactResponse"/></returns>
        public DeleteSymbolArtifactResponse DeleteSymbolArtifactSync(DeleteSymbolArtifactRequest req)
        {
            return InternalRequestAsync<DeleteSymbolArtifactResponse>(req, "DeleteSymbolArtifact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 逻辑删除应用，ProjectKey 即刻失效。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMApplicationRequest"/></param>
        /// <returns><see cref="DeleteTDEMApplicationResponse"/></returns>
        public Task<DeleteTDEMApplicationResponse> DeleteTDEMApplication(DeleteTDEMApplicationRequest req)
        {
            return InternalRequestAsync<DeleteTDEMApplicationResponse>(req, "DeleteTDEMApplication");
        }

        /// <summary>
        /// 逻辑删除应用，ProjectKey 即刻失效。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMApplicationRequest"/></param>
        /// <returns><see cref="DeleteTDEMApplicationResponse"/></returns>
        public DeleteTDEMApplicationResponse DeleteTDEMApplicationSync(DeleteTDEMApplicationRequest req)
        {
            return InternalRequestAsync<DeleteTDEMApplicationResponse>(req, "DeleteTDEMApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除业务系统。名下存在未删除应用时返回 ResourceInUse。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMBusinessSystemRequest"/></param>
        /// <returns><see cref="DeleteTDEMBusinessSystemResponse"/></returns>
        public Task<DeleteTDEMBusinessSystemResponse> DeleteTDEMBusinessSystem(DeleteTDEMBusinessSystemRequest req)
        {
            return InternalRequestAsync<DeleteTDEMBusinessSystemResponse>(req, "DeleteTDEMBusinessSystem");
        }

        /// <summary>
        /// 删除业务系统。名下存在未删除应用时返回 ResourceInUse。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMBusinessSystemRequest"/></param>
        /// <returns><see cref="DeleteTDEMBusinessSystemResponse"/></returns>
        public DeleteTDEMBusinessSystemResponse DeleteTDEMBusinessSystemSync(DeleteTDEMBusinessSystemRequest req)
        {
            return InternalRequestAsync<DeleteTDEMBusinessSystemResponse>(req, "DeleteTDEMBusinessSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将拨测任务标记为已删除。已删除的任务再次删除视为成功。不物理删除任务行，也不删除历史拨测结果。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMDialTaskRequest"/></param>
        /// <returns><see cref="DeleteTDEMDialTaskResponse"/></returns>
        public Task<DeleteTDEMDialTaskResponse> DeleteTDEMDialTask(DeleteTDEMDialTaskRequest req)
        {
            return InternalRequestAsync<DeleteTDEMDialTaskResponse>(req, "DeleteTDEMDialTask");
        }

        /// <summary>
        /// 将拨测任务标记为已删除。已删除的任务再次删除视为成功。不物理删除任务行，也不删除历史拨测结果。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMDialTaskRequest"/></param>
        /// <returns><see cref="DeleteTDEMDialTaskResponse"/></returns>
        public DeleteTDEMDialTaskResponse DeleteTDEMDialTaskSync(DeleteTDEMDialTaskRequest req)
        {
            return InternalRequestAsync<DeleteTDEMDialTaskResponse>(req, "DeleteTDEMDialTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按规则 Id 删除字段值替换规则。替代已废弃的 DeleteFieldTransformRule；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMFieldTransformRuleRequest"/></param>
        /// <returns><see cref="DeleteTDEMFieldTransformRuleResponse"/></returns>
        public Task<DeleteTDEMFieldTransformRuleResponse> DeleteTDEMFieldTransformRule(DeleteTDEMFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<DeleteTDEMFieldTransformRuleResponse>(req, "DeleteTDEMFieldTransformRule");
        }

        /// <summary>
        /// 按规则 Id 删除字段值替换规则。替代已废弃的 DeleteFieldTransformRule；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMFieldTransformRuleRequest"/></param>
        /// <returns><see cref="DeleteTDEMFieldTransformRuleResponse"/></returns>
        public DeleteTDEMFieldTransformRuleResponse DeleteTDEMFieldTransformRuleSync(DeleteTDEMFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<DeleteTDEMFieldTransformRuleResponse>(req, "DeleteTDEMFieldTransformRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除漏斗
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMFunnelRequest"/></param>
        /// <returns><see cref="DeleteTDEMFunnelResponse"/></returns>
        public Task<DeleteTDEMFunnelResponse> DeleteTDEMFunnel(DeleteTDEMFunnelRequest req)
        {
            return InternalRequestAsync<DeleteTDEMFunnelResponse>(req, "DeleteTDEMFunnel");
        }

        /// <summary>
        /// 删除漏斗
        /// </summary>
        /// <param name="req"><see cref="DeleteTDEMFunnelRequest"/></param>
        /// <returns><see cref="DeleteTDEMFunnelResponse"/></returns>
        public DeleteTDEMFunnelResponse DeleteTDEMFunnelSync(DeleteTDEMFunnelRequest req)
        {
            return InternalRequestAsync<DeleteTDEMFunnelResponse>(req, "DeleteTDEMFunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public Task<DeleteWhitelistResponse> DeleteWhitelist(DeleteWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteWhitelistResponse>(req, "DeleteWhitelist");
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public DeleteWhitelistResponse DeleteWhitelistSync(DeleteWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteWhitelistResponse>(req, "DeleteWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询 app 监控多维分析数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDimensionMetricsRequest"/></param>
        /// <returns><see cref="DescribeAppDimensionMetricsResponse"/></returns>
        public Task<DescribeAppDimensionMetricsResponse> DescribeAppDimensionMetrics(DescribeAppDimensionMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAppDimensionMetricsResponse>(req, "DescribeAppDimensionMetrics");
        }

        /// <summary>
        /// 用于查询 app 监控多维分析数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDimensionMetricsRequest"/></param>
        /// <returns><see cref="DescribeAppDimensionMetricsResponse"/></returns>
        public DescribeAppDimensionMetricsResponse DescribeAppDimensionMetricsSync(DescribeAppDimensionMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAppDimensionMetricsResponse>(req, "DescribeAppDimensionMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 app 监控指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppMetricsDataRequest"/></param>
        /// <returns><see cref="DescribeAppMetricsDataResponse"/></returns>
        public Task<DescribeAppMetricsDataResponse> DescribeAppMetricsData(DescribeAppMetricsDataRequest req)
        {
            return InternalRequestAsync<DescribeAppMetricsDataResponse>(req, "DescribeAppMetricsData");
        }

        /// <summary>
        /// 获取 app 监控指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppMetricsDataRequest"/></param>
        /// <returns><see cref="DescribeAppMetricsDataResponse"/></returns>
        public DescribeAppMetricsDataResponse DescribeAppMetricsDataSync(DescribeAppMetricsDataRequest req)
        {
            return InternalRequestAsync<DescribeAppMetricsDataResponse>(req, "DescribeAppMetricsData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 app 监控个例样本详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseDetailListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseDetailListResponse"/></returns>
        public Task<DescribeAppSingleCaseDetailListResponse> DescribeAppSingleCaseDetailList(DescribeAppSingleCaseDetailListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseDetailListResponse>(req, "DescribeAppSingleCaseDetailList");
        }

        /// <summary>
        /// 查询 app 监控个例样本详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseDetailListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseDetailListResponse"/></returns>
        public DescribeAppSingleCaseDetailListResponse DescribeAppSingleCaseDetailListSync(DescribeAppSingleCaseDetailListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseDetailListResponse>(req, "DescribeAppSingleCaseDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 app 监控个例聚合列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseListResponse"/></returns>
        public Task<DescribeAppSingleCaseListResponse> DescribeAppSingleCaseList(DescribeAppSingleCaseListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseListResponse>(req, "DescribeAppSingleCaseList");
        }

        /// <summary>
        /// 查询 app 监控个例聚合列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseListResponse"/></returns>
        public DescribeAppSingleCaseListResponse DescribeAppSingleCaseListSync(DescribeAppSingleCaseListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseListResponse>(req, "DescribeAppSingleCaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用退出个例上报详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationExitReportDetailRequest"/></param>
        /// <returns><see cref="DescribeApplicationExitReportDetailResponse"/></returns>
        public Task<DescribeApplicationExitReportDetailResponse> DescribeApplicationExitReportDetail(DescribeApplicationExitReportDetailRequest req)
        {
            return InternalRequestAsync<DescribeApplicationExitReportDetailResponse>(req, "DescribeApplicationExitReportDetail");
        }

        /// <summary>
        /// 获取应用退出个例上报详情
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationExitReportDetailRequest"/></param>
        /// <returns><see cref="DescribeApplicationExitReportDetailResponse"/></returns>
        public DescribeApplicationExitReportDetailResponse DescribeApplicationExitReportDetailSync(DescribeApplicationExitReportDetailRequest req)
        {
            return InternalRequestAsync<DescribeApplicationExitReportDetailResponse>(req, "DescribeApplicationExitReportDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用退出个例上报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationExitReportListRequest"/></param>
        /// <returns><see cref="DescribeApplicationExitReportListResponse"/></returns>
        public Task<DescribeApplicationExitReportListResponse> DescribeApplicationExitReportList(DescribeApplicationExitReportListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationExitReportListResponse>(req, "DescribeApplicationExitReportList");
        }

        /// <summary>
        /// 获取应用退出个例上报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationExitReportListRequest"/></param>
        /// <returns><see cref="DescribeApplicationExitReportListResponse"/></returns>
        public DescribeApplicationExitReportListResponse DescribeApplicationExitReportListSync(DescribeApplicationExitReportListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationExitReportListResponse>(req, "DescribeApplicationExitReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 转发monitor查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public Task<DescribeDataResponse> DescribeData(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData");
        }

        /// <summary>
        /// 转发monitor查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public DescribeDataResponse DescribeDataSync(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataBridgeUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBridgeUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataBridgeUrlV2Response"/></returns>
        public Task<DescribeDataBridgeUrlV2Response> DescribeDataBridgeUrlV2(DescribeDataBridgeUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataBridgeUrlV2Response>(req, "DescribeDataBridgeUrlV2");
        }

        /// <summary>
        /// 获取DescribeDataBridgeUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBridgeUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataBridgeUrlV2Response"/></returns>
        public DescribeDataBridgeUrlV2Response DescribeDataBridgeUrlV2Sync(DescribeDataBridgeUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataBridgeUrlV2Response>(req, "DescribeDataBridgeUrlV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public Task<DescribeDataCustomUrlResponse> DescribeDataCustomUrl(DescribeDataCustomUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlResponse>(req, "DescribeDataCustomUrl");
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public DescribeDataCustomUrlResponse DescribeDataCustomUrlSync(DescribeDataCustomUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlResponse>(req, "DescribeDataCustomUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataCustomUrlV2Response"/></returns>
        public Task<DescribeDataCustomUrlV2Response> DescribeDataCustomUrlV2(DescribeDataCustomUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlV2Response>(req, "DescribeDataCustomUrlV2");
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataCustomUrlV2Response"/></returns>
        public DescribeDataCustomUrlV2Response DescribeDataCustomUrlV2Sync(DescribeDataCustomUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlV2Response>(req, "DescribeDataCustomUrlV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public Task<DescribeDataEventUrlResponse> DescribeDataEventUrl(DescribeDataEventUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataEventUrlResponse>(req, "DescribeDataEventUrl");
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public DescribeDataEventUrlResponse DescribeDataEventUrlSync(DescribeDataEventUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataEventUrlResponse>(req, "DescribeDataEventUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataEventUrlV2Response"/></returns>
        public Task<DescribeDataEventUrlV2Response> DescribeDataEventUrlV2(DescribeDataEventUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataEventUrlV2Response>(req, "DescribeDataEventUrlV2");
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataEventUrlV2Response"/></returns>
        public DescribeDataEventUrlV2Response DescribeDataEventUrlV2Sync(DescribeDataEventUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataEventUrlV2Response>(req, "DescribeDataEventUrlV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataFetchProject信息。已下线，请使用DescribeDataFetchUrl
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public Task<DescribeDataFetchProjectResponse> DescribeDataFetchProject(DescribeDataFetchProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchProjectResponse>(req, "DescribeDataFetchProject");
        }

        /// <summary>
        /// 获取DescribeDataFetchProject信息。已下线，请使用DescribeDataFetchUrl
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public DescribeDataFetchProjectResponse DescribeDataFetchProjectSync(DescribeDataFetchProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchProjectResponse>(req, "DescribeDataFetchProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public Task<DescribeDataFetchUrlResponse> DescribeDataFetchUrl(DescribeDataFetchUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlResponse>(req, "DescribeDataFetchUrl");
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public DescribeDataFetchUrlResponse DescribeDataFetchUrlSync(DescribeDataFetchUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlResponse>(req, "DescribeDataFetchUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataFetchUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public Task<DescribeDataFetchUrlInfoResponse> DescribeDataFetchUrlInfo(DescribeDataFetchUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlInfoResponse>(req, "DescribeDataFetchUrlInfo");
        }

        /// <summary>
        /// 获取DescribeDataFetchUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public DescribeDataFetchUrlInfoResponse DescribeDataFetchUrlInfoSync(DescribeDataFetchUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlInfoResponse>(req, "DescribeDataFetchUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataFetchUrlV2Response"/></returns>
        public Task<DescribeDataFetchUrlV2Response> DescribeDataFetchUrlV2(DescribeDataFetchUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlV2Response>(req, "DescribeDataFetchUrlV2");
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataFetchUrlV2Response"/></returns>
        public DescribeDataFetchUrlV2Response DescribeDataFetchUrlV2Sync(DescribeDataFetchUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlV2Response>(req, "DescribeDataFetchUrlV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取loginfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public Task<DescribeDataLogUrlInfoResponse> DescribeDataLogUrlInfo(DescribeDataLogUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlInfoResponse>(req, "DescribeDataLogUrlInfo");
        }

        /// <summary>
        /// 获取loginfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public DescribeDataLogUrlInfoResponse DescribeDataLogUrlInfoSync(DescribeDataLogUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlInfoResponse>(req, "DescribeDataLogUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public Task<DescribeDataLogUrlStatisticsResponse> DescribeDataLogUrlStatistics(DescribeDataLogUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsResponse>(req, "DescribeDataLogUrlStatistics");
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public DescribeDataLogUrlStatisticsResponse DescribeDataLogUrlStatisticsSync(DescribeDataLogUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsResponse>(req, "DescribeDataLogUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsV2Request"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsV2Response"/></returns>
        public Task<DescribeDataLogUrlStatisticsV2Response> DescribeDataLogUrlStatisticsV2(DescribeDataLogUrlStatisticsV2Request req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsV2Response>(req, "DescribeDataLogUrlStatisticsV2");
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsV2Request"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsV2Response"/></returns>
        public DescribeDataLogUrlStatisticsV2Response DescribeDataLogUrlStatisticsV2Sync(DescribeDataLogUrlStatisticsV2Request req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsV2Response>(req, "DescribeDataLogUrlStatisticsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public Task<DescribeDataPerformancePageResponse> DescribeDataPerformancePage(DescribeDataPerformancePageRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageResponse>(req, "DescribeDataPerformancePage");
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public DescribeDataPerformancePageResponse DescribeDataPerformancePageSync(DescribeDataPerformancePageRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageResponse>(req, "DescribeDataPerformancePage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageV2Request"/></param>
        /// <returns><see cref="DescribeDataPerformancePageV2Response"/></returns>
        public Task<DescribeDataPerformancePageV2Response> DescribeDataPerformancePageV2(DescribeDataPerformancePageV2Request req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageV2Response>(req, "DescribeDataPerformancePageV2");
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageV2Request"/></param>
        /// <returns><see cref="DescribeDataPerformancePageV2Response"/></returns>
        public DescribeDataPerformancePageV2Response DescribeDataPerformancePageV2Sync(DescribeDataPerformancePageV2Request req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageV2Response>(req, "DescribeDataPerformancePageV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取PvUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public Task<DescribeDataPvUrlInfoResponse> DescribeDataPvUrlInfo(DescribeDataPvUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlInfoResponse>(req, "DescribeDataPvUrlInfo");
        }

        /// <summary>
        /// 获取PvUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public DescribeDataPvUrlInfoResponse DescribeDataPvUrlInfoSync(DescribeDataPvUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlInfoResponse>(req, "DescribeDataPvUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public Task<DescribeDataPvUrlStatisticsResponse> DescribeDataPvUrlStatistics(DescribeDataPvUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsResponse>(req, "DescribeDataPvUrlStatistics");
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public DescribeDataPvUrlStatisticsResponse DescribeDataPvUrlStatisticsSync(DescribeDataPvUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsResponse>(req, "DescribeDataPvUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsV2Request"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsV2Response"/></returns>
        public Task<DescribeDataPvUrlStatisticsV2Response> DescribeDataPvUrlStatisticsV2(DescribeDataPvUrlStatisticsV2Request req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsV2Response>(req, "DescribeDataPvUrlStatisticsV2");
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsV2Request"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsV2Response"/></returns>
        public DescribeDataPvUrlStatisticsV2Response DescribeDataPvUrlStatisticsV2Sync(DescribeDataPvUrlStatisticsV2Request req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsV2Response>(req, "DescribeDataPvUrlStatisticsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public Task<DescribeDataReportCountResponse> DescribeDataReportCount(DescribeDataReportCountRequest req)
        {
            return InternalRequestAsync<DescribeDataReportCountResponse>(req, "DescribeDataReportCount");
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public DescribeDataReportCountResponse DescribeDataReportCountSync(DescribeDataReportCountRequest req)
        {
            return InternalRequestAsync<DescribeDataReportCountResponse>(req, "DescribeDataReportCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountV2Request"/></param>
        /// <returns><see cref="DescribeDataReportCountV2Response"/></returns>
        public Task<DescribeDataReportCountV2Response> DescribeDataReportCountV2(DescribeDataReportCountV2Request req)
        {
            return InternalRequestAsync<DescribeDataReportCountV2Response>(req, "DescribeDataReportCountV2");
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountV2Request"/></param>
        /// <returns><see cref="DescribeDataReportCountV2Response"/></returns>
        public DescribeDataReportCountV2Response DescribeDataReportCountV2Sync(DescribeDataReportCountV2Request req)
        {
            return InternalRequestAsync<DescribeDataReportCountV2Response>(req, "DescribeDataReportCountV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public Task<DescribeDataSetUrlStatisticsResponse> DescribeDataSetUrlStatistics(DescribeDataSetUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsResponse>(req, "DescribeDataSetUrlStatistics");
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public DescribeDataSetUrlStatisticsResponse DescribeDataSetUrlStatisticsSync(DescribeDataSetUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsResponse>(req, "DescribeDataSetUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsV2Request"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsV2Response"/></returns>
        public Task<DescribeDataSetUrlStatisticsV2Response> DescribeDataSetUrlStatisticsV2(DescribeDataSetUrlStatisticsV2Request req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsV2Response>(req, "DescribeDataSetUrlStatisticsV2");
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsV2Request"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsV2Response"/></returns>
        public DescribeDataSetUrlStatisticsV2Response DescribeDataSetUrlStatisticsV2Sync(DescribeDataSetUrlStatisticsV2Request req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsV2Response>(req, "DescribeDataSetUrlStatisticsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public Task<DescribeDataStaticProjectResponse> DescribeDataStaticProject(DescribeDataStaticProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectResponse>(req, "DescribeDataStaticProject");
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public DescribeDataStaticProjectResponse DescribeDataStaticProjectSync(DescribeDataStaticProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectResponse>(req, "DescribeDataStaticProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectV2Request"/></param>
        /// <returns><see cref="DescribeDataStaticProjectV2Response"/></returns>
        public Task<DescribeDataStaticProjectV2Response> DescribeDataStaticProjectV2(DescribeDataStaticProjectV2Request req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectV2Response>(req, "DescribeDataStaticProjectV2");
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectV2Request"/></param>
        /// <returns><see cref="DescribeDataStaticProjectV2Response"/></returns>
        public DescribeDataStaticProjectV2Response DescribeDataStaticProjectV2Sync(DescribeDataStaticProjectV2Request req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectV2Response>(req, "DescribeDataStaticProjectV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public Task<DescribeDataStaticResourceResponse> DescribeDataStaticResource(DescribeDataStaticResourceRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceResponse>(req, "DescribeDataStaticResource");
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public DescribeDataStaticResourceResponse DescribeDataStaticResourceSync(DescribeDataStaticResourceRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceResponse>(req, "DescribeDataStaticResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceV2Request"/></param>
        /// <returns><see cref="DescribeDataStaticResourceV2Response"/></returns>
        public Task<DescribeDataStaticResourceV2Response> DescribeDataStaticResourceV2(DescribeDataStaticResourceV2Request req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceV2Response>(req, "DescribeDataStaticResourceV2");
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceV2Request"/></param>
        /// <returns><see cref="DescribeDataStaticResourceV2Response"/></returns>
        public DescribeDataStaticResourceV2Response DescribeDataStaticResourceV2Sync(DescribeDataStaticResourceV2Request req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceV2Response>(req, "DescribeDataStaticResourceV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public Task<DescribeDataStaticUrlResponse> DescribeDataStaticUrl(DescribeDataStaticUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlResponse>(req, "DescribeDataStaticUrl");
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public DescribeDataStaticUrlResponse DescribeDataStaticUrlSync(DescribeDataStaticUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlResponse>(req, "DescribeDataStaticUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataStaticUrlV2Response"/></returns>
        public Task<DescribeDataStaticUrlV2Response> DescribeDataStaticUrlV2(DescribeDataStaticUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlV2Response>(req, "DescribeDataStaticUrlV2");
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlV2Request"/></param>
        /// <returns><see cref="DescribeDataStaticUrlV2Response"/></returns>
        public DescribeDataStaticUrlV2Response DescribeDataStaticUrlV2Sync(DescribeDataStaticUrlV2Request req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlV2Response>(req, "DescribeDataStaticUrlV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public Task<DescribeDataWebVitalsPageResponse> DescribeDataWebVitalsPage(DescribeDataWebVitalsPageRequest req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageResponse>(req, "DescribeDataWebVitalsPage");
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public DescribeDataWebVitalsPageResponse DescribeDataWebVitalsPageSync(DescribeDataWebVitalsPageRequest req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageResponse>(req, "DescribeDataWebVitalsPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageV2Request"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageV2Response"/></returns>
        public Task<DescribeDataWebVitalsPageV2Response> DescribeDataWebVitalsPageV2(DescribeDataWebVitalsPageV2Request req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageV2Response>(req, "DescribeDataWebVitalsPageV2");
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageV2Request"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageV2Response"/></returns>
        public DescribeDataWebVitalsPageV2Response DescribeDataWebVitalsPageV2Sync(DescribeDataWebVitalsPageV2Request req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageV2Response>(req, "DescribeDataWebVitalsPageV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public Task<DescribeErrorResponse> DescribeError(DescribeErrorRequest req)
        {
            return InternalRequestAsync<DescribeErrorResponse>(req, "DescribeError");
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public DescribeErrorResponse DescribeErrorSync(DescribeErrorRequest req)
        {
            return InternalRequestAsync<DescribeErrorResponse>(req, "DescribeError")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取异常问题详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeExceptionDetailRequest"/></param>
        /// <returns><see cref="DescribeExceptionDetailResponse"/></returns>
        public Task<DescribeExceptionDetailResponse> DescribeExceptionDetail(DescribeExceptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeExceptionDetailResponse>(req, "DescribeExceptionDetail");
        }

        /// <summary>
        /// 获取异常问题详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeExceptionDetailRequest"/></param>
        /// <returns><see cref="DescribeExceptionDetailResponse"/></returns>
        public DescribeExceptionDetailResponse DescribeExceptionDetailSync(DescribeExceptionDetailRequest req)
        {
            return InternalRequestAsync<DescribeExceptionDetailResponse>(req, "DescribeExceptionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取异常个例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExceptionReportListRequest"/></param>
        /// <returns><see cref="DescribeExceptionReportListResponse"/></returns>
        public Task<DescribeExceptionReportListResponse> DescribeExceptionReportList(DescribeExceptionReportListRequest req)
        {
            return InternalRequestAsync<DescribeExceptionReportListResponse>(req, "DescribeExceptionReportList");
        }

        /// <summary>
        /// 获取异常个例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExceptionReportListRequest"/></param>
        /// <returns><see cref="DescribeExceptionReportListResponse"/></returns>
        public DescribeExceptionReportListResponse DescribeExceptionReportListSync(DescribeExceptionReportListRequest req)
        {
            return InternalRequestAsync<DescribeExceptionReportListResponse>(req, "DescribeExceptionReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取FOOM内存分配问题详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMMallocProblemDetailRequest"/></param>
        /// <returns><see cref="DescribeFOOMMallocProblemDetailResponse"/></returns>
        public Task<DescribeFOOMMallocProblemDetailResponse> DescribeFOOMMallocProblemDetail(DescribeFOOMMallocProblemDetailRequest req)
        {
            return InternalRequestAsync<DescribeFOOMMallocProblemDetailResponse>(req, "DescribeFOOMMallocProblemDetail");
        }

        /// <summary>
        /// 获取FOOM内存分配问题详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMMallocProblemDetailRequest"/></param>
        /// <returns><see cref="DescribeFOOMMallocProblemDetailResponse"/></returns>
        public DescribeFOOMMallocProblemDetailResponse DescribeFOOMMallocProblemDetailSync(DescribeFOOMMallocProblemDetailRequest req)
        {
            return InternalRequestAsync<DescribeFOOMMallocProblemDetailResponse>(req, "DescribeFOOMMallocProblemDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取FOOM内存分配问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMMallocProblemListRequest"/></param>
        /// <returns><see cref="DescribeFOOMMallocProblemListResponse"/></returns>
        public Task<DescribeFOOMMallocProblemListResponse> DescribeFOOMMallocProblemList(DescribeFOOMMallocProblemListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMMallocProblemListResponse>(req, "DescribeFOOMMallocProblemList");
        }

        /// <summary>
        /// 获取FOOM内存分配问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMMallocProblemListRequest"/></param>
        /// <returns><see cref="DescribeFOOMMallocProblemListResponse"/></returns>
        public DescribeFOOMMallocProblemListResponse DescribeFOOMMallocProblemListSync(DescribeFOOMMallocProblemListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMMallocProblemListResponse>(req, "DescribeFOOMMallocProblemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取FOOM内存分配问题上报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMMallocReportListRequest"/></param>
        /// <returns><see cref="DescribeFOOMMallocReportListResponse"/></returns>
        public Task<DescribeFOOMMallocReportListResponse> DescribeFOOMMallocReportList(DescribeFOOMMallocReportListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMMallocReportListResponse>(req, "DescribeFOOMMallocReportList");
        }

        /// <summary>
        /// 获取FOOM内存分配问题上报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMMallocReportListRequest"/></param>
        /// <returns><see cref="DescribeFOOMMallocReportListResponse"/></returns>
        public DescribeFOOMMallocReportListResponse DescribeFOOMMallocReportListSync(DescribeFOOMMallocReportListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMMallocReportListResponse>(req, "DescribeFOOMMallocReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取FOOM问题详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMProblemDetailRequest"/></param>
        /// <returns><see cref="DescribeFOOMProblemDetailResponse"/></returns>
        public Task<DescribeFOOMProblemDetailResponse> DescribeFOOMProblemDetail(DescribeFOOMProblemDetailRequest req)
        {
            return InternalRequestAsync<DescribeFOOMProblemDetailResponse>(req, "DescribeFOOMProblemDetail");
        }

        /// <summary>
        /// 获取FOOM问题详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMProblemDetailRequest"/></param>
        /// <returns><see cref="DescribeFOOMProblemDetailResponse"/></returns>
        public DescribeFOOMProblemDetailResponse DescribeFOOMProblemDetailSync(DescribeFOOMProblemDetailRequest req)
        {
            return InternalRequestAsync<DescribeFOOMProblemDetailResponse>(req, "DescribeFOOMProblemDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取FOOM问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMProblemListRequest"/></param>
        /// <returns><see cref="DescribeFOOMProblemListResponse"/></returns>
        public Task<DescribeFOOMProblemListResponse> DescribeFOOMProblemList(DescribeFOOMProblemListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMProblemListResponse>(req, "DescribeFOOMProblemList");
        }

        /// <summary>
        /// 获取FOOM问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMProblemListRequest"/></param>
        /// <returns><see cref="DescribeFOOMProblemListResponse"/></returns>
        public DescribeFOOMProblemListResponse DescribeFOOMProblemListSync(DescribeFOOMProblemListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMProblemListResponse>(req, "DescribeFOOMProblemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取FOOM问题上报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMReportListRequest"/></param>
        /// <returns><see cref="DescribeFOOMReportListResponse"/></returns>
        public Task<DescribeFOOMReportListResponse> DescribeFOOMReportList(DescribeFOOMReportListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMReportListResponse>(req, "DescribeFOOMReportList");
        }

        /// <summary>
        /// 获取FOOM问题上报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFOOMReportListRequest"/></param>
        /// <returns><see cref="DescribeFOOMReportListResponse"/></returns>
        public DescribeFOOMReportListResponse DescribeFOOMReportListSync(DescribeFOOMReportListRequest req)
        {
            return InternalRequestAsync<DescribeFOOMReportListResponse>(req, "DescribeFOOMReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取字段配置规则
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldTransformRulesRequest"/></param>
        /// <returns><see cref="DescribeFieldTransformRulesResponse"/></returns>
        public Task<DescribeFieldTransformRulesResponse> DescribeFieldTransformRules(DescribeFieldTransformRulesRequest req)
        {
            return InternalRequestAsync<DescribeFieldTransformRulesResponse>(req, "DescribeFieldTransformRules");
        }

        /// <summary>
        /// 获取字段配置规则
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldTransformRulesRequest"/></param>
        /// <returns><see cref="DescribeFieldTransformRulesResponse"/></returns>
        public DescribeFieldTransformRulesResponse DescribeFieldTransformRulesSync(DescribeFieldTransformRulesRequest req)
        {
            return InternalRequestAsync<DescribeFieldTransformRulesResponse>(req, "DescribeFieldTransformRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TDEM字段值列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldValuesRequest"/></param>
        /// <returns><see cref="DescribeFieldValuesResponse"/></returns>
        public Task<DescribeFieldValuesResponse> DescribeFieldValues(DescribeFieldValuesRequest req)
        {
            return InternalRequestAsync<DescribeFieldValuesResponse>(req, "DescribeFieldValues");
        }

        /// <summary>
        /// 获取TDEM字段值列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFieldValuesRequest"/></param>
        /// <returns><see cref="DescribeFieldValuesResponse"/></returns>
        public DescribeFieldValuesResponse DescribeFieldValuesSync(DescribeFieldValuesRequest req)
        {
            return InternalRequestAsync<DescribeFieldValuesResponse>(req, "DescribeFieldValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS存储的临时密钥，具体到ProjectId
        /// </summary>
        /// <param name="req"><see cref="DescribeFileCertificateRequest"/></param>
        /// <returns><see cref="DescribeFileCertificateResponse"/></returns>
        public Task<DescribeFileCertificateResponse> DescribeFileCertificate(DescribeFileCertificateRequest req)
        {
            return InternalRequestAsync<DescribeFileCertificateResponse>(req, "DescribeFileCertificate");
        }

        /// <summary>
        /// 获取COS存储的临时密钥，具体到ProjectId
        /// </summary>
        /// <param name="req"><see cref="DescribeFileCertificateRequest"/></param>
        /// <returns><see cref="DescribeFileCertificateResponse"/></returns>
        public DescribeFileCertificateResponse DescribeFileCertificateSync(DescribeFileCertificateRequest req)
        {
            return InternalRequestAsync<DescribeFileCertificateResponse>(req, "DescribeFileCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按用户维度聚合某问题的受影响用户清单，服务端分页。AppId 与 IssueId 必填；AppVersion / StartTime / EndTime / Keyword 用于收窄范围，同时作用于清单与 Total，因此 Total 为当前条件下去重后的用户数， 条件全空时等于问题详情的影响用户数。OrderKey / OrderBy 只改变行序、不改变结果集合；排序一律由服务端执行， 并保留 uid 作为次级键以保证翻页不重不漏。接口只读。
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueAffectedUsersRequest"/></param>
        /// <returns><see cref="DescribeIssueAffectedUsersResponse"/></returns>
        public Task<DescribeIssueAffectedUsersResponse> DescribeIssueAffectedUsers(DescribeIssueAffectedUsersRequest req)
        {
            return InternalRequestAsync<DescribeIssueAffectedUsersResponse>(req, "DescribeIssueAffectedUsers");
        }

        /// <summary>
        /// 按用户维度聚合某问题的受影响用户清单，服务端分页。AppId 与 IssueId 必填；AppVersion / StartTime / EndTime / Keyword 用于收窄范围，同时作用于清单与 Total，因此 Total 为当前条件下去重后的用户数， 条件全空时等于问题详情的影响用户数。OrderKey / OrderBy 只改变行序、不改变结果集合；排序一律由服务端执行， 并保留 uid 作为次级键以保证翻页不重不漏。接口只读。
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueAffectedUsersRequest"/></param>
        /// <returns><see cref="DescribeIssueAffectedUsersResponse"/></returns>
        public DescribeIssueAffectedUsersResponse DescribeIssueAffectedUsersSync(DescribeIssueAffectedUsersRequest req)
        {
            return InternalRequestAsync<DescribeIssueAffectedUsersResponse>(req, "DescribeIssueAffectedUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定 Issue 当前事件或最新事件之前的 Breadcrumbs 面包屑序列
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueBreadcrumbsRequest"/></param>
        /// <returns><see cref="DescribeIssueBreadcrumbsResponse"/></returns>
        public Task<DescribeIssueBreadcrumbsResponse> DescribeIssueBreadcrumbs(DescribeIssueBreadcrumbsRequest req)
        {
            return InternalRequestAsync<DescribeIssueBreadcrumbsResponse>(req, "DescribeIssueBreadcrumbs");
        }

        /// <summary>
        /// 获取指定 Issue 当前事件或最新事件之前的 Breadcrumbs 面包屑序列
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueBreadcrumbsRequest"/></param>
        /// <returns><see cref="DescribeIssueBreadcrumbsResponse"/></returns>
        public DescribeIssueBreadcrumbsResponse DescribeIssueBreadcrumbsSync(DescribeIssueBreadcrumbsRequest req)
        {
            return InternalRequestAsync<DescribeIssueBreadcrumbsResponse>(req, "DescribeIssueBreadcrumbs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取日志下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueCrashLogDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeIssueCrashLogDownloadURLResponse"/></returns>
        public Task<DescribeIssueCrashLogDownloadURLResponse> DescribeIssueCrashLogDownloadURL(DescribeIssueCrashLogDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeIssueCrashLogDownloadURLResponse>(req, "DescribeIssueCrashLogDownloadURL");
        }

        /// <summary>
        /// 获取日志下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueCrashLogDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeIssueCrashLogDownloadURLResponse"/></returns>
        public DescribeIssueCrashLogDownloadURLResponse DescribeIssueCrashLogDownloadURLSync(DescribeIssueCrashLogDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeIssueCrashLogDownloadURLResponse>(req, "DescribeIssueCrashLogDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定 Issue 的摘要信息以及默认选中的最新事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueDetailRequest"/></param>
        /// <returns><see cref="DescribeIssueDetailResponse"/></returns>
        public Task<DescribeIssueDetailResponse> DescribeIssueDetail(DescribeIssueDetailRequest req)
        {
            return InternalRequestAsync<DescribeIssueDetailResponse>(req, "DescribeIssueDetail");
        }

        /// <summary>
        /// 获取指定 Issue 的摘要信息以及默认选中的最新事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueDetailRequest"/></param>
        /// <returns><see cref="DescribeIssueDetailResponse"/></returns>
        public DescribeIssueDetailResponse DescribeIssueDetailSync(DescribeIssueDetailRequest req)
        {
            return InternalRequestAsync<DescribeIssueDetailResponse>(req, "DescribeIssueDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定 Issue 下单个事件的完整详情，包括栈信息、上下文和符号化状态等字段
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueEventDetailRequest"/></param>
        /// <returns><see cref="DescribeIssueEventDetailResponse"/></returns>
        public Task<DescribeIssueEventDetailResponse> DescribeIssueEventDetail(DescribeIssueEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeIssueEventDetailResponse>(req, "DescribeIssueEventDetail");
        }

        /// <summary>
        /// 获取指定 Issue 下单个事件的完整详情，包括栈信息、上下文和符号化状态等字段
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueEventDetailRequest"/></param>
        /// <returns><see cref="DescribeIssueEventDetailResponse"/></returns>
        public DescribeIssueEventDetailResponse DescribeIssueEventDetailSync(DescribeIssueEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeIssueEventDetailResponse>(req, "DescribeIssueEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据条件获取指定 Issue 的错误事件列表，支持按时间范围、关键字和扩展过滤器查询，返回分页事件数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueEventsRequest"/></param>
        /// <returns><see cref="DescribeIssueEventsResponse"/></returns>
        public Task<DescribeIssueEventsResponse> DescribeIssueEvents(DescribeIssueEventsRequest req)
        {
            return InternalRequestAsync<DescribeIssueEventsResponse>(req, "DescribeIssueEvents");
        }

        /// <summary>
        /// 根据条件获取指定 Issue 的错误事件列表，支持按时间范围、关键字和扩展过滤器查询，返回分页事件数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueEventsRequest"/></param>
        /// <returns><see cref="DescribeIssueEventsResponse"/></returns>
        public DescribeIssueEventsResponse DescribeIssueEventsSync(DescribeIssueEventsRequest req)
        {
            return InternalRequestAsync<DescribeIssueEventsResponse>(req, "DescribeIssueEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定 Issue 在给定时间范围内的趋势分桶统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueTrendRequest"/></param>
        /// <returns><see cref="DescribeIssueTrendResponse"/></returns>
        public Task<DescribeIssueTrendResponse> DescribeIssueTrend(DescribeIssueTrendRequest req)
        {
            return InternalRequestAsync<DescribeIssueTrendResponse>(req, "DescribeIssueTrend");
        }

        /// <summary>
        /// 获取指定 Issue 在给定时间范围内的趋势分桶统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssueTrendRequest"/></param>
        /// <returns><see cref="DescribeIssueTrendResponse"/></returns>
        public DescribeIssueTrendResponse DescribeIssueTrendSync(DescribeIssueTrendRequest req)
        {
            return InternalRequestAsync<DescribeIssueTrendResponse>(req, "DescribeIssueTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据筛选条件分页查询 Issue 列表，支持环境、Issue 类型、状态、关键字、扩展过滤器和排序条件
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesRequest"/></param>
        /// <returns><see cref="DescribeIssuesResponse"/></returns>
        public Task<DescribeIssuesResponse> DescribeIssues(DescribeIssuesRequest req)
        {
            return InternalRequestAsync<DescribeIssuesResponse>(req, "DescribeIssues");
        }

        /// <summary>
        /// 根据筛选条件分页查询 Issue 列表，支持环境、Issue 类型、状态、关键字、扩展过滤器和排序条件
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesRequest"/></param>
        /// <returns><see cref="DescribeIssuesResponse"/></returns>
        public DescribeIssuesResponse DescribeIssuesSync(DescribeIssuesRequest req)
        {
            return InternalRequestAsync<DescribeIssuesResponse>(req, "DescribeIssues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取问题分布数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesDistributionRequest"/></param>
        /// <returns><see cref="DescribeIssuesDistributionResponse"/></returns>
        public Task<DescribeIssuesDistributionResponse> DescribeIssuesDistribution(DescribeIssuesDistributionRequest req)
        {
            return InternalRequestAsync<DescribeIssuesDistributionResponse>(req, "DescribeIssuesDistribution");
        }

        /// <summary>
        /// 获取问题分布数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesDistributionRequest"/></param>
        /// <returns><see cref="DescribeIssuesDistributionResponse"/></returns>
        public DescribeIssuesDistributionResponse DescribeIssuesDistributionSync(DescribeIssuesDistributionRequest req)
        {
            return InternalRequestAsync<DescribeIssuesDistributionResponse>(req, "DescribeIssuesDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesListRequest"/></param>
        /// <returns><see cref="DescribeIssuesListResponse"/></returns>
        public Task<DescribeIssuesListResponse> DescribeIssuesList(DescribeIssuesListRequest req)
        {
            return InternalRequestAsync<DescribeIssuesListResponse>(req, "DescribeIssuesList");
        }

        /// <summary>
        /// 获取问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesListRequest"/></param>
        /// <returns><see cref="DescribeIssuesListResponse"/></returns>
        public DescribeIssuesListResponse DescribeIssuesListSync(DescribeIssuesListRequest req)
        {
            return InternalRequestAsync<DescribeIssuesListResponse>(req, "DescribeIssuesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取问题趋势数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesStatisticsTrendRequest"/></param>
        /// <returns><see cref="DescribeIssuesStatisticsTrendResponse"/></returns>
        public Task<DescribeIssuesStatisticsTrendResponse> DescribeIssuesStatisticsTrend(DescribeIssuesStatisticsTrendRequest req)
        {
            return InternalRequestAsync<DescribeIssuesStatisticsTrendResponse>(req, "DescribeIssuesStatisticsTrend");
        }

        /// <summary>
        /// 获取问题趋势数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIssuesStatisticsTrendRequest"/></param>
        /// <returns><see cref="DescribeIssuesStatisticsTrendResponse"/></returns>
        public DescribeIssuesStatisticsTrendResponse DescribeIssuesStatisticsTrendSync(DescribeIssuesStatisticsTrendRequest req)
        {
            return InternalRequestAsync<DescribeIssuesStatisticsTrendResponse>(req, "DescribeIssuesStatisticsTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取卡顿ANR问题用户详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLagANRProblemAccountDetailRequest"/></param>
        /// <returns><see cref="DescribeLagANRProblemAccountDetailResponse"/></returns>
        public Task<DescribeLagANRProblemAccountDetailResponse> DescribeLagANRProblemAccountDetail(DescribeLagANRProblemAccountDetailRequest req)
        {
            return InternalRequestAsync<DescribeLagANRProblemAccountDetailResponse>(req, "DescribeLagANRProblemAccountDetail");
        }

        /// <summary>
        /// 获取卡顿ANR问题用户详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLagANRProblemAccountDetailRequest"/></param>
        /// <returns><see cref="DescribeLagANRProblemAccountDetailResponse"/></returns>
        public DescribeLagANRProblemAccountDetailResponse DescribeLagANRProblemAccountDetailSync(DescribeLagANRProblemAccountDetailRequest req)
        {
            return InternalRequestAsync<DescribeLagANRProblemAccountDetailResponse>(req, "DescribeLagANRProblemAccountDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取卡顿ANR问题用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLagANRProblemFeatureAccountsRequest"/></param>
        /// <returns><see cref="DescribeLagANRProblemFeatureAccountsResponse"/></returns>
        public Task<DescribeLagANRProblemFeatureAccountsResponse> DescribeLagANRProblemFeatureAccounts(DescribeLagANRProblemFeatureAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLagANRProblemFeatureAccountsResponse>(req, "DescribeLagANRProblemFeatureAccounts");
        }

        /// <summary>
        /// 获取卡顿ANR问题用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLagANRProblemFeatureAccountsRequest"/></param>
        /// <returns><see cref="DescribeLagANRProblemFeatureAccountsResponse"/></returns>
        public DescribeLagANRProblemFeatureAccountsResponse DescribeLagANRProblemFeatureAccountsSync(DescribeLagANRProblemFeatureAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLagANRProblemFeatureAccountsResponse>(req, "DescribeLagANRProblemFeatureAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取卡顿ANR问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLagANRProblemListRequest"/></param>
        /// <returns><see cref="DescribeLagANRProblemListResponse"/></returns>
        public Task<DescribeLagANRProblemListResponse> DescribeLagANRProblemList(DescribeLagANRProblemListRequest req)
        {
            return InternalRequestAsync<DescribeLagANRProblemListResponse>(req, "DescribeLagANRProblemList");
        }

        /// <summary>
        /// 获取卡顿ANR问题列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeLagANRProblemListRequest"/></param>
        /// <returns><see cref="DescribeLagANRProblemListResponse"/></returns>
        public DescribeLagANRProblemListResponse DescribeLagANRProblemListSync(DescribeLagANRProblemListRequest req)
        {
            return InternalRequestAsync<DescribeLagANRProblemListResponse>(req, "DescribeLagANRProblemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按AppId+BundleHash取已编译回放包正文。成功含Pack（tmpl/css/js/manifest/hash），不返回WXML/WXSS源码。不存在返回ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="DescribeMiniProgramReplayPackRequest"/></param>
        /// <returns><see cref="DescribeMiniProgramReplayPackResponse"/></returns>
        public Task<DescribeMiniProgramReplayPackResponse> DescribeMiniProgramReplayPack(DescribeMiniProgramReplayPackRequest req)
        {
            return InternalRequestAsync<DescribeMiniProgramReplayPackResponse>(req, "DescribeMiniProgramReplayPack");
        }

        /// <summary>
        /// 按AppId+BundleHash取已编译回放包正文。成功含Pack（tmpl/css/js/manifest/hash），不返回WXML/WXSS源码。不存在返回ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="DescribeMiniProgramReplayPackRequest"/></param>
        /// <returns><see cref="DescribeMiniProgramReplayPackResponse"/></returns>
        public DescribeMiniProgramReplayPackResponse DescribeMiniProgramReplayPackSync(DescribeMiniProgramReplayPackRequest req)
        {
            return InternalRequestAsync<DescribeMiniProgramReplayPackResponse>(req, "DescribeMiniProgramReplayPack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按AppId列出回放包元数据，不含Pack正文。可按Status过滤。Limit默认20、最大100。
        /// </summary>
        /// <param name="req"><see cref="DescribeMiniProgramReplayPacksRequest"/></param>
        /// <returns><see cref="DescribeMiniProgramReplayPacksResponse"/></returns>
        public Task<DescribeMiniProgramReplayPacksResponse> DescribeMiniProgramReplayPacks(DescribeMiniProgramReplayPacksRequest req)
        {
            return InternalRequestAsync<DescribeMiniProgramReplayPacksResponse>(req, "DescribeMiniProgramReplayPacks");
        }

        /// <summary>
        /// 按AppId列出回放包元数据，不含Pack正文。可按Status过滤。Limit默认20、最大100。
        /// </summary>
        /// <param name="req"><see cref="DescribeMiniProgramReplayPacksRequest"/></param>
        /// <returns><see cref="DescribeMiniProgramReplayPacksResponse"/></returns>
        public DescribeMiniProgramReplayPacksResponse DescribeMiniProgramReplayPacksSync(DescribeMiniProgramReplayPacksRequest req)
        {
            return InternalRequestAsync<DescribeMiniProgramReplayPacksResponse>(req, "DescribeMiniProgramReplayPacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TDEM性能指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribePerformanceMetricsRequest"/></param>
        /// <returns><see cref="DescribePerformanceMetricsResponse"/></returns>
        public Task<DescribePerformanceMetricsResponse> DescribePerformanceMetrics(DescribePerformanceMetricsRequest req)
        {
            return InternalRequestAsync<DescribePerformanceMetricsResponse>(req, "DescribePerformanceMetrics");
        }

        /// <summary>
        /// 获取TDEM性能指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribePerformanceMetricsRequest"/></param>
        /// <returns><see cref="DescribePerformanceMetricsResponse"/></returns>
        public DescribePerformanceMetricsResponse DescribePerformanceMetricsSync(DescribePerformanceMetricsRequest req)
        {
            return InternalRequestAsync<DescribePerformanceMetricsResponse>(req, "DescribePerformanceMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用上报抽样信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public Task<DescribeProjectLimitsResponse> DescribeProjectLimits(DescribeProjectLimitsRequest req)
        {
            return InternalRequestAsync<DescribeProjectLimitsResponse>(req, "DescribeProjectLimits");
        }

        /// <summary>
        /// 获取应用上报抽样信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public DescribeProjectLimitsResponse DescribeProjectLimitsSync(DescribeProjectLimitsRequest req)
        {
            return InternalRequestAsync<DescribeProjectLimitsResponse>(req, "DescribeProjectLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目列表（实例创建的团队下的项目列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 获取项目列表（实例创建的团队下的项目列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的PV列表
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public Task<DescribePvListResponse> DescribePvList(DescribePvListRequest req)
        {
            return InternalRequestAsync<DescribePvListResponse>(req, "DescribePvList");
        }

        /// <summary>
        /// 获取项目下的PV列表
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public DescribePvListResponse DescribePvListSync(DescribePvListRequest req)
        {
            return InternalRequestAsync<DescribePvListResponse>(req, "DescribePvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取上传文件存储的临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public Task<DescribeReleaseFileSignResponse> DescribeReleaseFileSign(DescribeReleaseFileSignRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFileSignResponse>(req, "DescribeReleaseFileSign");
        }

        /// <summary>
        /// 获取上传文件存储的临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public DescribeReleaseFileSignResponse DescribeReleaseFileSignSync(DescribeReleaseFileSignRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFileSignResponse>(req, "DescribeReleaseFileSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用对应sourcemap文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public Task<DescribeReleaseFilesResponse> DescribeReleaseFiles(DescribeReleaseFilesRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFilesResponse>(req, "DescribeReleaseFiles");
        }

        /// <summary>
        /// 获取应用对应sourcemap文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public DescribeReleaseFilesResponse DescribeReleaseFilesSync(DescribeReleaseFilesRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFilesResponse>(req, "DescribeReleaseFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从对象存储读取录屏帧数据
        /// </summary>
        /// <param name="req"><see cref="DescribeReplayDataRequest"/></param>
        /// <returns><see cref="DescribeReplayDataResponse"/></returns>
        public Task<DescribeReplayDataResponse> DescribeReplayData(DescribeReplayDataRequest req)
        {
            return InternalRequestAsync<DescribeReplayDataResponse>(req, "DescribeReplayData");
        }

        /// <summary>
        /// 从对象存储读取录屏帧数据
        /// </summary>
        /// <param name="req"><see cref="DescribeReplayDataRequest"/></param>
        /// <returns><see cref="DescribeReplayDataResponse"/></returns>
        public DescribeReplayDataResponse DescribeReplayDataSync(DescribeReplayDataRequest req)
        {
            return InternalRequestAsync<DescribeReplayDataResponse>(req, "DescribeReplayData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取回放日志
        /// </summary>
        /// <param name="req"><see cref="DescribeReplayDetailsRequest"/></param>
        /// <returns><see cref="DescribeReplayDetailsResponse"/></returns>
        public Task<DescribeReplayDetailsResponse> DescribeReplayDetails(DescribeReplayDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReplayDetailsResponse>(req, "DescribeReplayDetails");
        }

        /// <summary>
        /// 获取回放日志
        /// </summary>
        /// <param name="req"><see cref="DescribeReplayDetailsRequest"/></param>
        /// <returns><see cref="DescribeReplayDetailsResponse"/></returns>
        public DescribeReplayDetailsResponse DescribeReplayDetailsSync(DescribeReplayDetailsRequest req)
        {
            return InternalRequestAsync<DescribeReplayDetailsResponse>(req, "DescribeReplayDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取回放元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeReplayMetaRequest"/></param>
        /// <returns><see cref="DescribeReplayMetaResponse"/></returns>
        public Task<DescribeReplayMetaResponse> DescribeReplayMeta(DescribeReplayMetaRequest req)
        {
            return InternalRequestAsync<DescribeReplayMetaResponse>(req, "DescribeReplayMeta");
        }

        /// <summary>
        /// 获取回放元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeReplayMetaRequest"/></param>
        /// <returns><see cref="DescribeReplayMetaResponse"/></returns>
        public DescribeReplayMetaResponse DescribeReplayMetaSync(DescribeReplayMetaRequest req)
        {
            return InternalRequestAsync<DescribeReplayMetaResponse>(req, "DescribeReplayMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志聚合信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogRequest"/></param>
        /// <returns><see cref="DescribeRumGroupLogResponse"/></returns>
        public Task<DescribeRumGroupLogResponse> DescribeRumGroupLog(DescribeRumGroupLogRequest req)
        {
            return InternalRequestAsync<DescribeRumGroupLogResponse>(req, "DescribeRumGroupLog");
        }

        /// <summary>
        /// 获取项目下的日志聚合信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogRequest"/></param>
        /// <returns><see cref="DescribeRumGroupLogResponse"/></returns>
        public DescribeRumGroupLogResponse DescribeRumGroupLogSync(DescribeRumGroupLogRequest req)
        {
            return InternalRequestAsync<DescribeRumGroupLogResponse>(req, "DescribeRumGroupLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据label 聚合分析日志
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogV2Request"/></param>
        /// <returns><see cref="DescribeRumGroupLogV2Response"/></returns>
        public Task<DescribeRumGroupLogV2Response> DescribeRumGroupLogV2(DescribeRumGroupLogV2Request req)
        {
            return InternalRequestAsync<DescribeRumGroupLogV2Response>(req, "DescribeRumGroupLogV2");
        }

        /// <summary>
        /// 根据label 聚合分析日志
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogV2Request"/></param>
        /// <returns><see cref="DescribeRumGroupLogV2Response"/></returns>
        public DescribeRumGroupLogV2Response DescribeRumGroupLogV2Sync(DescribeRumGroupLogV2Request req)
        {
            return InternalRequestAsync<DescribeRumGroupLogV2Response>(req, "DescribeRumGroupLogV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogDetailsV2Request"/></param>
        /// <returns><see cref="DescribeRumLogDetailsV2Response"/></returns>
        public Task<DescribeRumLogDetailsV2Response> DescribeRumLogDetailsV2(DescribeRumLogDetailsV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogDetailsV2Response>(req, "DescribeRumLogDetailsV2");
        }

        /// <summary>
        /// 查询日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogDetailsV2Request"/></param>
        /// <returns><see cref="DescribeRumLogDetailsV2Response"/></returns>
        public DescribeRumLogDetailsV2Response DescribeRumLogDetailsV2Sync(DescribeRumLogDetailsV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogDetailsV2Response>(req, "DescribeRumLogDetailsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportResponse"/></returns>
        public Task<DescribeRumLogExportResponse> DescribeRumLogExport(DescribeRumLogExportRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportResponse>(req, "DescribeRumLogExport");
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportResponse"/></returns>
        public DescribeRumLogExportResponse DescribeRumLogExportSync(DescribeRumLogExportRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportResponse>(req, "DescribeRumLogExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建日志导出
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportV2Request"/></param>
        /// <returns><see cref="DescribeRumLogExportV2Response"/></returns>
        public Task<DescribeRumLogExportV2Response> DescribeRumLogExportV2(DescribeRumLogExportV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogExportV2Response>(req, "DescribeRumLogExportV2");
        }

        /// <summary>
        /// 创建日志导出
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportV2Request"/></param>
        /// <returns><see cref="DescribeRumLogExportV2Response"/></returns>
        public DescribeRumLogExportV2Response DescribeRumLogExportV2Sync(DescribeRumLogExportV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogExportV2Response>(req, "DescribeRumLogExportV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportsResponse"/></returns>
        public Task<DescribeRumLogExportsResponse> DescribeRumLogExports(DescribeRumLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportsResponse>(req, "DescribeRumLogExports");
        }

        /// <summary>
        /// 获取项目下的日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportsResponse"/></returns>
        public DescribeRumLogExportsResponse DescribeRumLogExportsSync(DescribeRumLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportsResponse>(req, "DescribeRumLogExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsV2Request"/></param>
        /// <returns><see cref="DescribeRumLogExportsV2Response"/></returns>
        public Task<DescribeRumLogExportsV2Response> DescribeRumLogExportsV2(DescribeRumLogExportsV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogExportsV2Response>(req, "DescribeRumLogExportsV2");
        }

        /// <summary>
        /// 获取日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsV2Request"/></param>
        /// <returns><see cref="DescribeRumLogExportsV2Response"/></returns>
        public DescribeRumLogExportsV2Response DescribeRumLogExportsV2Sync(DescribeRumLogExportsV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogExportsV2Response>(req, "DescribeRumLogExportsV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogListRequest"/></param>
        /// <returns><see cref="DescribeRumLogListResponse"/></returns>
        public Task<DescribeRumLogListResponse> DescribeRumLogList(DescribeRumLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumLogListResponse>(req, "DescribeRumLogList");
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogListRequest"/></param>
        /// <returns><see cref="DescribeRumLogListResponse"/></returns>
        public DescribeRumLogListResponse DescribeRumLogListSync(DescribeRumLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumLogListResponse>(req, "DescribeRumLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询原始日志总量
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogTotalV2Request"/></param>
        /// <returns><see cref="DescribeRumLogTotalV2Response"/></returns>
        public Task<DescribeRumLogTotalV2Response> DescribeRumLogTotalV2(DescribeRumLogTotalV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogTotalV2Response>(req, "DescribeRumLogTotalV2");
        }

        /// <summary>
        /// 查询原始日志总量
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogTotalV2Request"/></param>
        /// <returns><see cref="DescribeRumLogTotalV2Response"/></returns>
        public DescribeRumLogTotalV2Response DescribeRumLogTotalV2Sync(DescribeRumLogTotalV2Request req)
        {
            return InternalRequestAsync<DescribeRumLogTotalV2Response>(req, "DescribeRumLogTotalV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志列表，分钟级
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListRequest"/></param>
        /// <returns><see cref="DescribeRumStatsLogListResponse"/></returns>
        public Task<DescribeRumStatsLogListResponse> DescribeRumStatsLogList(DescribeRumStatsLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListResponse>(req, "DescribeRumStatsLogList");
        }

        /// <summary>
        /// 获取项目下的日志列表，分钟级
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListRequest"/></param>
        /// <returns><see cref="DescribeRumStatsLogListResponse"/></returns>
        public DescribeRumStatsLogListResponse DescribeRumStatsLogListSync(DescribeRumStatsLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListResponse>(req, "DescribeRumStatsLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询日志时间分布
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListV2Request"/></param>
        /// <returns><see cref="DescribeRumStatsLogListV2Response"/></returns>
        public Task<DescribeRumStatsLogListV2Response> DescribeRumStatsLogListV2(DescribeRumStatsLogListV2Request req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListV2Response>(req, "DescribeRumStatsLogListV2");
        }

        /// <summary>
        /// 查询日志时间分布
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListV2Request"/></param>
        /// <returns><see cref="DescribeRumStatsLogListV2Response"/></returns>
        public DescribeRumStatsLogListV2Response DescribeRumStatsLogListV2Sync(DescribeRumStatsLogListV2Request req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListV2Response>(req, "DescribeRumStatsLogListV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用的采样率
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleRateRequest"/></param>
        /// <returns><see cref="DescribeSampleRateResponse"/></returns>
        public Task<DescribeSampleRateResponse> DescribeSampleRate(DescribeSampleRateRequest req)
        {
            return InternalRequestAsync<DescribeSampleRateResponse>(req, "DescribeSampleRate");
        }

        /// <summary>
        /// 获取应用的采样率
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleRateRequest"/></param>
        /// <returns><see cref="DescribeSampleRateResponse"/></returns>
        public DescribeSampleRateResponse DescribeSampleRateSync(DescribeSampleRateRequest req)
        {
            return InternalRequestAsync<DescribeSampleRateResponse>(req, "DescribeSampleRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public Task<DescribeScoresResponse> DescribeScores(DescribeScoresRequest req)
        {
            return InternalRequestAsync<DescribeScoresResponse>(req, "DescribeScores");
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public DescribeScoresResponse DescribeScoresSync(DescribeScoresRequest req)
        {
            return InternalRequestAsync<DescribeScoresResponse>(req, "DescribeScores")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresV2Request"/></param>
        /// <returns><see cref="DescribeScoresV2Response"/></returns>
        public Task<DescribeScoresV2Response> DescribeScoresV2(DescribeScoresV2Request req)
        {
            return InternalRequestAsync<DescribeScoresV2Response>(req, "DescribeScoresV2");
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresV2Request"/></param>
        /// <returns><see cref="DescribeScoresV2Response"/></returns>
        public DescribeScoresV2Response DescribeScoresV2Sync(DescribeScoresV2Request req)
        {
            return InternalRequestAsync<DescribeScoresV2Response>(req, "DescribeScoresV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionListRequest"/></param>
        /// <returns><see cref="DescribeSessionListResponse"/></returns>
        public Task<DescribeSessionListResponse> DescribeSessionList(DescribeSessionListRequest req)
        {
            return InternalRequestAsync<DescribeSessionListResponse>(req, "DescribeSessionList");
        }

        /// <summary>
        /// 查询会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionListRequest"/></param>
        /// <returns><see cref="DescribeSessionListResponse"/></returns>
        public DescribeSessionListResponse DescribeSessionListSync(DescribeSessionListRequest req)
        {
            return InternalRequestAsync<DescribeSessionListResponse>(req, "DescribeSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取挣扎事件分布数据
        /// </summary>
        /// <param name="req"><see cref="DescribeStruggleDistributionRequest"/></param>
        /// <returns><see cref="DescribeStruggleDistributionResponse"/></returns>
        public Task<DescribeStruggleDistributionResponse> DescribeStruggleDistribution(DescribeStruggleDistributionRequest req)
        {
            return InternalRequestAsync<DescribeStruggleDistributionResponse>(req, "DescribeStruggleDistribution");
        }

        /// <summary>
        /// 获取挣扎事件分布数据
        /// </summary>
        /// <param name="req"><see cref="DescribeStruggleDistributionRequest"/></param>
        /// <returns><see cref="DescribeStruggleDistributionResponse"/></returns>
        public DescribeStruggleDistributionResponse DescribeStruggleDistributionSync(DescribeStruggleDistributionRequest req)
        {
            return InternalRequestAsync<DescribeStruggleDistributionResponse>(req, "DescribeStruggleDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取符号制品上传临时凭证。
        /// </summary>
        /// <param name="req"><see cref="DescribeSymbolArtifactUploadCredentialRequest"/></param>
        /// <returns><see cref="DescribeSymbolArtifactUploadCredentialResponse"/></returns>
        public Task<DescribeSymbolArtifactUploadCredentialResponse> DescribeSymbolArtifactUploadCredential(DescribeSymbolArtifactUploadCredentialRequest req)
        {
            return InternalRequestAsync<DescribeSymbolArtifactUploadCredentialResponse>(req, "DescribeSymbolArtifactUploadCredential");
        }

        /// <summary>
        /// 获取符号制品上传临时凭证。
        /// </summary>
        /// <param name="req"><see cref="DescribeSymbolArtifactUploadCredentialRequest"/></param>
        /// <returns><see cref="DescribeSymbolArtifactUploadCredentialResponse"/></returns>
        public DescribeSymbolArtifactUploadCredentialResponse DescribeSymbolArtifactUploadCredentialSync(DescribeSymbolArtifactUploadCredentialRequest req)
        {
            return InternalRequestAsync<DescribeSymbolArtifactUploadCredentialResponse>(req, "DescribeSymbolArtifactUploadCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询指定类型的符号制品。
        /// </summary>
        /// <param name="req"><see cref="DescribeSymbolArtifactsRequest"/></param>
        /// <returns><see cref="DescribeSymbolArtifactsResponse"/></returns>
        public Task<DescribeSymbolArtifactsResponse> DescribeSymbolArtifacts(DescribeSymbolArtifactsRequest req)
        {
            return InternalRequestAsync<DescribeSymbolArtifactsResponse>(req, "DescribeSymbolArtifacts");
        }

        /// <summary>
        /// 分页查询指定类型的符号制品。
        /// </summary>
        /// <param name="req"><see cref="DescribeSymbolArtifactsRequest"/></param>
        /// <returns><see cref="DescribeSymbolArtifactsResponse"/></returns>
        public DescribeSymbolArtifactsResponse DescribeSymbolArtifactsSync(DescribeSymbolArtifactsRequest req)
        {
            return InternalRequestAsync<DescribeSymbolArtifactsResponse>(req, "DescribeSymbolArtifacts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用列表，默认仅当前用户名下有权限的应用；可按业务系统 InstanceId 筛选。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeTDEMApplicationsResponse"/></returns>
        public Task<DescribeTDEMApplicationsResponse> DescribeTDEMApplications(DescribeTDEMApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMApplicationsResponse>(req, "DescribeTDEMApplications");
        }

        /// <summary>
        /// 查询应用列表，默认仅当前用户名下有权限的应用；可按业务系统 InstanceId 筛选。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMApplicationsRequest"/></param>
        /// <returns><see cref="DescribeTDEMApplicationsResponse"/></returns>
        public DescribeTDEMApplicationsResponse DescribeTDEMApplicationsSync(DescribeTDEMApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMApplicationsResponse>(req, "DescribeTDEMApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前用户名下业务系统列表（超管返回全部）。分页 Offset/Limit，默认 Limit=20 上限 100。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMBusinessSystemsRequest"/></param>
        /// <returns><see cref="DescribeTDEMBusinessSystemsResponse"/></returns>
        public Task<DescribeTDEMBusinessSystemsResponse> DescribeTDEMBusinessSystems(DescribeTDEMBusinessSystemsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMBusinessSystemsResponse>(req, "DescribeTDEMBusinessSystems");
        }

        /// <summary>
        /// 查询当前用户名下业务系统列表（超管返回全部）。分页 Offset/Limit，默认 Limit=20 上限 100。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMBusinessSystemsRequest"/></param>
        /// <returns><see cref="DescribeTDEMBusinessSystemsResponse"/></returns>
        public DescribeTDEMBusinessSystemsResponse DescribeTDEMBusinessSystemsSync(DescribeTDEMBusinessSystemsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMBusinessSystemsResponse>(req, "DescribeTDEMBusinessSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按一个维度拆分拨测指标。Dimension 取值说明：platform、app_version、device、net_type、operator、region、country、target_ip。target_region 不是合法值。region 对应客户端省份，country 对应国家。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialDimensionsRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialDimensionsResponse"/></returns>
        public Task<DescribeTDEMDialDimensionsResponse> DescribeTDEMDialDimensions(DescribeTDEMDialDimensionsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialDimensionsResponse>(req, "DescribeTDEMDialDimensions");
        }

        /// <summary>
        /// 按一个维度拆分拨测指标。Dimension 取值说明：platform、app_version、device、net_type、operator、region、country、target_ip。target_region 不是合法值。region 对应客户端省份，country 对应国家。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialDimensionsRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialDimensionsResponse"/></returns>
        public DescribeTDEMDialDimensionsResponse DescribeTDEMDialDimensionsSync(DescribeTDEMDialDimensionsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialDimensionsResponse>(req, "DescribeTDEMDialDimensions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回一个拨测批次的探测结果和路由追踪。Probes 的 Region、Operator 是目标 IP 归属。逐跳归属同时写在 Probes.MTR.Hops 和顶层 MTR.Hops。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialExecutionDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialExecutionDetailResponse"/></returns>
        public Task<DescribeTDEMDialExecutionDetailResponse> DescribeTDEMDialExecutionDetail(DescribeTDEMDialExecutionDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialExecutionDetailResponse>(req, "DescribeTDEMDialExecutionDetail");
        }

        /// <summary>
        /// 返回一个拨测批次的探测结果和路由追踪。Probes 的 Region、Operator 是目标 IP 归属。逐跳归属同时写在 Probes.MTR.Hops 和顶层 MTR.Hops。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialExecutionDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialExecutionDetailResponse"/></returns>
        public DescribeTDEMDialExecutionDetailResponse DescribeTDEMDialExecutionDetailSync(DescribeTDEMDialExecutionDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialExecutionDetailResponse>(req, "DescribeTDEMDialExecutionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按批次返回拨测执行记录，一批次一行。TargetIps 是目标地址，TargetIpGeo 是这些地址的地区和运营商。行上的 Region 和 Operator 仍是客户端地区和运营商。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialExecutionListRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialExecutionListResponse"/></returns>
        public Task<DescribeTDEMDialExecutionListResponse> DescribeTDEMDialExecutionList(DescribeTDEMDialExecutionListRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialExecutionListResponse>(req, "DescribeTDEMDialExecutionList");
        }

        /// <summary>
        /// 按批次返回拨测执行记录，一批次一行。TargetIps 是目标地址，TargetIpGeo 是这些地址的地区和运营商。行上的 Region 和 Operator 仍是客户端地区和运营商。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialExecutionListRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialExecutionListResponse"/></returns>
        public DescribeTDEMDialExecutionListResponse DescribeTDEMDialExecutionListSync(DescribeTDEMDialExecutionListRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialExecutionListResponse>(req, "DescribeTDEMDialExecutionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按时间窗汇总拨测批次。一次多 IP 探测计为 1 个批次。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialOverviewRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialOverviewResponse"/></returns>
        public Task<DescribeTDEMDialOverviewResponse> DescribeTDEMDialOverview(DescribeTDEMDialOverviewRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialOverviewResponse>(req, "DescribeTDEMDialOverview");
        }

        /// <summary>
        /// 按时间窗汇总拨测批次。一次多 IP 探测计为 1 个批次。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialOverviewRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialOverviewResponse"/></returns>
        public DescribeTDEMDialOverviewResponse DescribeTDEMDialOverviewSync(DescribeTDEMDialOverviewRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialOverviewResponse>(req, "DescribeTDEMDialOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用下未删除的拨测任务，包含启动范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialTasksRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialTasksResponse"/></returns>
        public Task<DescribeTDEMDialTasksResponse> DescribeTDEMDialTasks(DescribeTDEMDialTasksRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialTasksResponse>(req, "DescribeTDEMDialTasks");
        }

        /// <summary>
        /// 查询应用下未删除的拨测任务，包含启动范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialTasksRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialTasksResponse"/></returns>
        public DescribeTDEMDialTasksResponse DescribeTDEMDialTasksSync(DescribeTDEMDialTasksRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialTasksResponse>(req, "DescribeTDEMDialTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按小时或天返回拨测趋势。Granularity 不传时按小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialTrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialTrendResponse"/></returns>
        public Task<DescribeTDEMDialTrendResponse> DescribeTDEMDialTrend(DescribeTDEMDialTrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialTrendResponse>(req, "DescribeTDEMDialTrend");
        }

        /// <summary>
        /// 按小时或天返回拨测趋势。Granularity 不传时按小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMDialTrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMDialTrendResponse"/></returns>
        public DescribeTDEMDialTrendResponse DescribeTDEMDialTrendSync(DescribeTDEMDialTrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMDialTrendResponse>(req, "DescribeTDEMDialTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按 AppId+EventId 查询事件详情，含主表字段与可选符号化结果。Date 推荐传以命中分区；或用 StartDate+EndDate（<=2 天）。越权与不存在统一 ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventDetailResponse"/></returns>
        public Task<DescribeTDEMEventDetailResponse> DescribeTDEMEventDetail(DescribeTDEMEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventDetailResponse>(req, "DescribeTDEMEventDetail");
        }

        /// <summary>
        /// 按 AppId+EventId 查询事件详情，含主表字段与可选符号化结果。Date 推荐传以命中分区；或用 StartDate+EndDate（<=2 天）。越权与不存在统一 ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventDetailResponse"/></returns>
        public DescribeTDEMEventDetailResponse DescribeTDEMEventDetailSync(DescribeTDEMEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventDetailResponse>(req, "DescribeTDEMEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 错误指纹或 API/资源 URL（含按访问页、状态、标签）排行。读 tdem_events，不走主分析立方 GroupBy。Kind：error/api/resource/api_page/resource_page/api_status/api_status_top/resource_status/tag。 Kind=exception_dimension返回当前普通维度或标签值的同批完整分类计数；展开不另行取数。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventRankRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventRankResponse"/></returns>
        public Task<DescribeTDEMEventRankResponse> DescribeTDEMEventRank(DescribeTDEMEventRankRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventRankResponse>(req, "DescribeTDEMEventRank");
        }

        /// <summary>
        /// 错误指纹或 API/资源 URL（含按访问页、状态、标签）排行。读 tdem_events，不走主分析立方 GroupBy。Kind：error/api/resource/api_page/resource_page/api_status/api_status_top/resource_status/tag。 Kind=exception_dimension返回当前普通维度或标签值的同批完整分类计数；展开不另行取数。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventRankRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventRankResponse"/></returns>
        public DescribeTDEMEventRankResponse DescribeTDEMEventRankSync(DescribeTDEMEventRankRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventRankResponse>(req, "DescribeTDEMEventRank")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据探索事件明细分页。会话分类不得调用本接口（Category 禁止 session）。时间单位 Unix 毫秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventSearchRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventSearchResponse"/></returns>
        public Task<DescribeTDEMEventSearchResponse> DescribeTDEMEventSearch(DescribeTDEMEventSearchRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventSearchResponse>(req, "DescribeTDEMEventSearch");
        }

        /// <summary>
        /// 数据探索事件明细分页。会话分类不得调用本接口（Category 禁止 session）。时间单位 Unix 毫秒。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventSearchRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventSearchResponse"/></returns>
        public DescribeTDEMEventSearchResponse DescribeTDEMEventSearchSync(DescribeTDEMEventSearchRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventSearchResponse>(req, "DescribeTDEMEventSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同一筛选下的分类计数、访问用户、业务用户、窗口合计与分桶趋势。Category 可含 session。空窗返回 0 与空 Series。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventSearchSummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventSearchSummaryResponse"/></returns>
        public Task<DescribeTDEMEventSearchSummaryResponse> DescribeTDEMEventSearchSummary(DescribeTDEMEventSearchSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventSearchSummaryResponse>(req, "DescribeTDEMEventSearchSummary");
        }

        /// <summary>
        /// 同一筛选下的分类计数、访问用户、业务用户、窗口合计与分桶趋势。Category 可含 session。空窗返回 0 与空 Series。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMEventSearchSummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMEventSearchSummaryResponse"/></returns>
        public DescribeTDEMEventSearchSummaryResponse DescribeTDEMEventSearchSummarySync(DescribeTDEMEventSearchSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMEventSearchSummaryResponse>(req, "DescribeTDEMEventSearchSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询应用下字段值替换规则列表。替代已废弃的 DescribeFieldTransformRules；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFieldTransformRulesRequest"/></param>
        /// <returns><see cref="DescribeTDEMFieldTransformRulesResponse"/></returns>
        public Task<DescribeTDEMFieldTransformRulesResponse> DescribeTDEMFieldTransformRules(DescribeTDEMFieldTransformRulesRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFieldTransformRulesResponse>(req, "DescribeTDEMFieldTransformRules");
        }

        /// <summary>
        /// 查询应用下字段值替换规则列表。替代已废弃的 DescribeFieldTransformRules；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFieldTransformRulesRequest"/></param>
        /// <returns><see cref="DescribeTDEMFieldTransformRulesResponse"/></returns>
        public DescribeTDEMFieldTransformRulesResponse DescribeTDEMFieldTransformRulesSync(DescribeTDEMFieldTransformRulesRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFieldTransformRulesResponse>(req, "DescribeTDEMFieldTransformRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏斗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelDetailResponse"/></returns>
        public Task<DescribeTDEMFunnelDetailResponse> DescribeTDEMFunnelDetail(DescribeTDEMFunnelDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelDetailResponse>(req, "DescribeTDEMFunnelDetail");
        }

        /// <summary>
        /// 获取漏斗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelDetailResponse"/></returns>
        public DescribeTDEMFunnelDetailResponse DescribeTDEMFunnelDetailSync(DescribeTDEMFunnelDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelDetailResponse>(req, "DescribeTDEMFunnelDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏斗分析报告维度数据
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelDimensionsRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelDimensionsResponse"/></returns>
        public Task<DescribeTDEMFunnelDimensionsResponse> DescribeTDEMFunnelDimensions(DescribeTDEMFunnelDimensionsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelDimensionsResponse>(req, "DescribeTDEMFunnelDimensions");
        }

        /// <summary>
        /// 获取漏斗分析报告维度数据
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelDimensionsRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelDimensionsResponse"/></returns>
        public DescribeTDEMFunnelDimensionsResponse DescribeTDEMFunnelDimensionsSync(DescribeTDEMFunnelDimensionsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelDimensionsResponse>(req, "DescribeTDEMFunnelDimensions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏斗列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelListRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelListResponse"/></returns>
        public Task<DescribeTDEMFunnelListResponse> DescribeTDEMFunnelList(DescribeTDEMFunnelListRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelListResponse>(req, "DescribeTDEMFunnelList");
        }

        /// <summary>
        /// 获取漏斗列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelListRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelListResponse"/></returns>
        public DescribeTDEMFunnelListResponse DescribeTDEMFunnelListSync(DescribeTDEMFunnelListRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelListResponse>(req, "DescribeTDEMFunnelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏斗报告
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelReportRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelReportResponse"/></returns>
        public Task<DescribeTDEMFunnelReportResponse> DescribeTDEMFunnelReport(DescribeTDEMFunnelReportRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelReportResponse>(req, "DescribeTDEMFunnelReport");
        }

        /// <summary>
        /// 获取漏斗报告
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelReportRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelReportResponse"/></returns>
        public DescribeTDEMFunnelReportResponse DescribeTDEMFunnelReportSync(DescribeTDEMFunnelReportRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelReportResponse>(req, "DescribeTDEMFunnelReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏斗步骤会话
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelStepSessionListRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelStepSessionListResponse"/></returns>
        public Task<DescribeTDEMFunnelStepSessionListResponse> DescribeTDEMFunnelStepSessionList(DescribeTDEMFunnelStepSessionListRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelStepSessionListResponse>(req, "DescribeTDEMFunnelStepSessionList");
        }

        /// <summary>
        /// 获取漏斗步骤会话
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelStepSessionListRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelStepSessionListResponse"/></returns>
        public DescribeTDEMFunnelStepSessionListResponse DescribeTDEMFunnelStepSessionListSync(DescribeTDEMFunnelStepSessionListRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelStepSessionListResponse>(req, "DescribeTDEMFunnelStepSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏斗趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelTrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelTrendResponse"/></returns>
        public Task<DescribeTDEMFunnelTrendResponse> DescribeTDEMFunnelTrend(DescribeTDEMFunnelTrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelTrendResponse>(req, "DescribeTDEMFunnelTrend");
        }

        /// <summary>
        /// 获取漏斗趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMFunnelTrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMFunnelTrendResponse"/></returns>
        public DescribeTDEMFunnelTrendResponse DescribeTDEMFunnelTrendSync(DescribeTDEMFunnelTrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMFunnelTrendResponse>(req, "DescribeTDEMFunnelTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按单维度 GroupBy 查询分析指标分布。读 tdem_metric_agg。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMMetricDistributionRequest"/></param>
        /// <returns><see cref="DescribeTDEMMetricDistributionResponse"/></returns>
        public Task<DescribeTDEMMetricDistributionResponse> DescribeTDEMMetricDistribution(DescribeTDEMMetricDistributionRequest req)
        {
            return InternalRequestAsync<DescribeTDEMMetricDistributionResponse>(req, "DescribeTDEMMetricDistribution");
        }

        /// <summary>
        /// 按单维度 GroupBy 查询分析指标分布。读 tdem_metric_agg。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMMetricDistributionRequest"/></param>
        /// <returns><see cref="DescribeTDEMMetricDistributionResponse"/></returns>
        public DescribeTDEMMetricDistributionResponse DescribeTDEMMetricDistributionSync(DescribeTDEMMetricDistributionRequest req)
        {
            return InternalRequestAsync<DescribeTDEMMetricDistributionResponse>(req, "DescribeTDEMMetricDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定应用与时间窗内的分析指标区间合计。单查返回 Metrics；传 Queries 时返回 Results。读 tdem_metric_agg。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMMetricSummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMMetricSummaryResponse"/></returns>
        public Task<DescribeTDEMMetricSummaryResponse> DescribeTDEMMetricSummary(DescribeTDEMMetricSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMMetricSummaryResponse>(req, "DescribeTDEMMetricSummary");
        }

        /// <summary>
        /// 查询指定应用与时间窗内的分析指标区间合计。单查返回 Metrics；传 Queries 时返回 Results。读 tdem_metric_agg。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMMetricSummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMMetricSummaryResponse"/></returns>
        public DescribeTDEMMetricSummaryResponse DescribeTDEMMetricSummarySync(DescribeTDEMMetricSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMMetricSummaryResponse>(req, "DescribeTDEMMetricSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分析指标时序。可传 CompareStartTime/CompareEndTime 做对比窗（仅批量）。读 tdem_metric_agg。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMMetricTrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMMetricTrendResponse"/></returns>
        public Task<DescribeTDEMMetricTrendResponse> DescribeTDEMMetricTrend(DescribeTDEMMetricTrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMMetricTrendResponse>(req, "DescribeTDEMMetricTrend");
        }

        /// <summary>
        /// 查询分析指标时序。可传 CompareStartTime/CompareEndTime 做对比窗（仅批量）。读 tdem_metric_agg。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMMetricTrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMMetricTrendResponse"/></returns>
        public DescribeTDEMMetricTrendResponse DescribeTDEMMetricTrendSync(DescribeTDEMMetricTrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMMetricTrendResponse>(req, "DescribeTDEMMetricTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 客户端总览列表批量评分。按应用列表一次返回各计分项单项分与加权总分。AppIds 1-200；不归属当前用户的应用不出现在响应中。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMOverviewScoresRequest"/></param>
        /// <returns><see cref="DescribeTDEMOverviewScoresResponse"/></returns>
        public Task<DescribeTDEMOverviewScoresResponse> DescribeTDEMOverviewScores(DescribeTDEMOverviewScoresRequest req)
        {
            return InternalRequestAsync<DescribeTDEMOverviewScoresResponse>(req, "DescribeTDEMOverviewScores");
        }

        /// <summary>
        /// 客户端总览列表批量评分。按应用列表一次返回各计分项单项分与加权总分。AppIds 1-200；不归属当前用户的应用不出现在响应中。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMOverviewScoresRequest"/></param>
        /// <returns><see cref="DescribeTDEMOverviewScoresResponse"/></returns>
        public DescribeTDEMOverviewScoresResponse DescribeTDEMOverviewScoresSync(DescribeTDEMOverviewScoresRequest req)
        {
            return InternalRequestAsync<DescribeTDEMOverviewScoresResponse>(req, "DescribeTDEMOverviewScores")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会话时间线 / 页面子事件 / 错误前轨迹。Mode：timeline / page / breadcrumb。Limit 默认 200，上限 200。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMRelatedEventsRequest"/></param>
        /// <returns><see cref="DescribeTDEMRelatedEventsResponse"/></returns>
        public Task<DescribeTDEMRelatedEventsResponse> DescribeTDEMRelatedEvents(DescribeTDEMRelatedEventsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMRelatedEventsResponse>(req, "DescribeTDEMRelatedEvents");
        }

        /// <summary>
        /// 会话时间线 / 页面子事件 / 错误前轨迹。Mode：timeline / page / breadcrumb。Limit 默认 200，上限 200。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMRelatedEventsRequest"/></param>
        /// <returns><see cref="DescribeTDEMRelatedEventsResponse"/></returns>
        public DescribeTDEMRelatedEventsResponse DescribeTDEMRelatedEventsSync(DescribeTDEMRelatedEventsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMRelatedEventsResponse>(req, "DescribeTDEMRelatedEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按一个维度返回大模型对话次数和当前指标值，按指标值降序，最多 200 行。region 由 country 与 province 拼接。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSEDimensionsRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSEDimensionsResponse"/></returns>
        public Task<DescribeTDEMSSEDimensionsResponse> DescribeTDEMSSEDimensions(DescribeTDEMSSEDimensionsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSEDimensionsResponse>(req, "DescribeTDEMSSEDimensions");
        }

        /// <summary>
        /// 按一个维度返回大模型对话次数和当前指标值，按指标值降序，最多 200 行。region 由 country 与 province 拼接。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSEDimensionsRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSEDimensionsResponse"/></returns>
        public DescribeTDEMSSEDimensionsResponse DescribeTDEMSSEDimensionsSync(DescribeTDEMSSEDimensionsRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSEDimensionsResponse>(req, "DescribeTDEMSSEDimensions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回吞吐率、首次消息时延或流畅度的分档分布。档位左闭右开，最后一档有限区间右端闭合，超出右端的样本进入溢出档。错误率与卡死率返回 InvalidParameter。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSEDistributionRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSEDistributionResponse"/></returns>
        public Task<DescribeTDEMSSEDistributionResponse> DescribeTDEMSSEDistribution(DescribeTDEMSSEDistributionRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSEDistributionResponse>(req, "DescribeTDEMSSEDistribution");
        }

        /// <summary>
        /// 返回吞吐率、首次消息时延或流畅度的分档分布。档位左闭右开，最后一档有限区间右端闭合，超出右端的样本进入溢出档。错误率与卡死率返回 InvalidParameter。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSEDistributionRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSEDistributionResponse"/></returns>
        public DescribeTDEMSSEDistributionResponse DescribeTDEMSSEDistributionSync(DescribeTDEMSSEDistributionRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSEDistributionResponse>(req, "DescribeTDEMSSEDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回吞吐率、首次消息时延或流畅度在整个时间窗及各时间桶上的平均值和 P50、P75、P95、P99。错误率与卡死率返回 InvalidParameter。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSEPercentileRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSEPercentileResponse"/></returns>
        public Task<DescribeTDEMSSEPercentileResponse> DescribeTDEMSSEPercentile(DescribeTDEMSSEPercentileRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSEPercentileResponse>(req, "DescribeTDEMSSEPercentile");
        }

        /// <summary>
        /// 返回吞吐率、首次消息时延或流畅度在整个时间窗及各时间桶上的平均值和 P50、P75、P95、P99。错误率与卡死率返回 InvalidParameter。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSEPercentileRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSEPercentileResponse"/></returns>
        public DescribeTDEMSSEPercentileResponse DescribeTDEMSSEPercentileSync(DescribeTDEMSSEPercentileRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSEPercentileResponse>(req, "DescribeTDEMSSEPercentile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定应用与时间窗内的大模型对话汇总，包含对话次数、token 总数、吞吐率、首次消息时延、错误率、卡死率和流畅度。只读 tdem.tdem_events 中 event_type 为 sse_call 的事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSESummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSESummaryResponse"/></returns>
        public Task<DescribeTDEMSSESummaryResponse> DescribeTDEMSSESummary(DescribeTDEMSSESummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSESummaryResponse>(req, "DescribeTDEMSSESummary");
        }

        /// <summary>
        /// 查询指定应用与时间窗内的大模型对话汇总，包含对话次数、token 总数、吞吐率、首次消息时延、错误率、卡死率和流畅度。只读 tdem.tdem_events 中 event_type 为 sse_call 的事件。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSESummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSESummaryResponse"/></returns>
        public DescribeTDEMSSESummaryResponse DescribeTDEMSSESummarySync(DescribeTDEMSSESummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSESummaryResponse>(req, "DescribeTDEMSSESummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按时间桶返回大模型对话趋势。overall 填充 Points，其他维度按整个窗口的指标值从高到低取 TopN 并填充 Series。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSETrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSETrendResponse"/></returns>
        public Task<DescribeTDEMSSETrendResponse> DescribeTDEMSSETrend(DescribeTDEMSSETrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSETrendResponse>(req, "DescribeTDEMSSETrend");
        }

        /// <summary>
        /// 按时间桶返回大模型对话趋势。overall 填充 Points，其他维度按整个窗口的指标值从高到低取 TopN 并填充 Series。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSSETrendRequest"/></param>
        /// <returns><see cref="DescribeTDEMSSETrendResponse"/></returns>
        public DescribeTDEMSSETrendResponse DescribeTDEMSSETrendSync(DescribeTDEMSSETrendRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSSETrendResponse>(req, "DescribeTDEMSSETrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 读取当前生效的 Web 规则化采样文档。ProjectId 必填且 > 0。无行则返回内置缺省（Event.Enabled=true、Types 空、Replay 关闭且体验率 0），不自动插库。SnapshotId 无快照为 0。query handler 做 PascalCase ↔ 存储 snake_case 映射。非 Web 应用不得走本接口，继续 DescribeSampleRate。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSampleConfigRequest"/></param>
        /// <returns><see cref="DescribeTDEMSampleConfigResponse"/></returns>
        public Task<DescribeTDEMSampleConfigResponse> DescribeTDEMSampleConfig(DescribeTDEMSampleConfigRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSampleConfigResponse>(req, "DescribeTDEMSampleConfig");
        }

        /// <summary>
        /// 读取当前生效的 Web 规则化采样文档。ProjectId 必填且 > 0。无行则返回内置缺省（Event.Enabled=true、Types 空、Replay 关闭且体验率 0），不自动插库。SnapshotId 无快照为 0。query handler 做 PascalCase ↔ 存储 snake_case 映射。非 Web 应用不得走本接口，继续 DescribeSampleRate。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSampleConfigRequest"/></param>
        /// <returns><see cref="DescribeTDEMSampleConfigResponse"/></returns>
        public DescribeTDEMSampleConfigResponse DescribeTDEMSampleConfigSync(DescribeTDEMSampleConfigRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSampleConfigResponse>(req, "DescribeTDEMSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个应用的采集采样率与会话回放采样率。替代已废弃的 DescribeSampleRate；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSampleRateRequest"/></param>
        /// <returns><see cref="DescribeTDEMSampleRateResponse"/></returns>
        public Task<DescribeTDEMSampleRateResponse> DescribeTDEMSampleRate(DescribeTDEMSampleRateRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSampleRateResponse>(req, "DescribeTDEMSampleRate");
        }

        /// <summary>
        /// 查询单个应用的采集采样率与会话回放采样率。替代已废弃的 DescribeSampleRate；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSampleRateRequest"/></param>
        /// <returns><see cref="DescribeTDEMSampleRateResponse"/></returns>
        public DescribeTDEMSampleRateResponse DescribeTDEMSampleRateSync(DescribeTDEMSampleRateRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSampleRateResponse>(req, "DescribeTDEMSampleRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取回放时间线数据
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSessionReplayTimelineRequest"/></param>
        /// <returns><see cref="DescribeTDEMSessionReplayTimelineResponse"/></returns>
        public Task<DescribeTDEMSessionReplayTimelineResponse> DescribeTDEMSessionReplayTimeline(DescribeTDEMSessionReplayTimelineRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSessionReplayTimelineResponse>(req, "DescribeTDEMSessionReplayTimeline");
        }

        /// <summary>
        /// 获取回放时间线数据
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMSessionReplayTimelineRequest"/></param>
        /// <returns><see cref="DescribeTDEMSessionReplayTimelineResponse"/></returns>
        public DescribeTDEMSessionReplayTimelineResponse DescribeTDEMSessionReplayTimelineSync(DescribeTDEMSessionReplayTimelineRequest req)
        {
            return InternalRequestAsync<DescribeTDEMSessionReplayTimelineResponse>(req, "DescribeTDEMSessionReplayTimeline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按业务系统/应用查询用量明细（含行趋势、端类型、删除/停用标记）。Keyword 匹配业务系统名、应用名或应用 ID。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMUsageDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMUsageDetailResponse"/></returns>
        public Task<DescribeTDEMUsageDetailResponse> DescribeTDEMUsageDetail(DescribeTDEMUsageDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMUsageDetailResponse>(req, "DescribeTDEMUsageDetail");
        }

        /// <summary>
        /// 按业务系统/应用查询用量明细（含行趋势、端类型、删除/停用标记）。Keyword 匹配业务系统名、应用名或应用 ID。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMUsageDetailRequest"/></param>
        /// <returns><see cref="DescribeTDEMUsageDetailResponse"/></returns>
        public DescribeTDEMUsageDetailResponse DescribeTDEMUsageDetailSync(DescribeTDEMUsageDetailRequest req)
        {
            return InternalRequestAsync<DescribeTDEMUsageDetailResponse>(req, "DescribeTDEMUsageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前使用者名下（超管为全部）上报总量与趋势。时间 StartTime/EndTime 为 YYYY-MM-DD HH:00:00 小时对齐。不要求请求体带 AppId。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMUsageSummaryResponse"/></returns>
        public Task<DescribeTDEMUsageSummaryResponse> DescribeTDEMUsageSummary(DescribeTDEMUsageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMUsageSummaryResponse>(req, "DescribeTDEMUsageSummary");
        }

        /// <summary>
        /// 查询当前使用者名下（超管为全部）上报总量与趋势。时间 StartTime/EndTime 为 YYYY-MM-DD HH:00:00 小时对齐。不要求请求体带 AppId。
        /// </summary>
        /// <param name="req"><see cref="DescribeTDEMUsageSummaryRequest"/></param>
        /// <returns><see cref="DescribeTDEMUsageSummaryResponse"/></returns>
        public DescribeTDEMUsageSummaryResponse DescribeTDEMUsageSummarySync(DescribeTDEMUsageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTDEMUsageSummaryResponse>(req, "DescribeTDEMUsageSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询片区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public Task<DescribeTawAreasResponse> DescribeTawAreas(DescribeTawAreasRequest req)
        {
            return InternalRequestAsync<DescribeTawAreasResponse>(req, "DescribeTawAreas");
        }

        /// <summary>
        /// 查询片区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public DescribeTawAreasResponse DescribeTawAreasSync(DescribeTawAreasRequest req)
        {
            return InternalRequestAsync<DescribeTawAreasResponse>(req, "DescribeTawAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawInstancesRequest"/></param>
        /// <returns><see cref="DescribeTawInstancesResponse"/></returns>
        public Task<DescribeTawInstancesResponse> DescribeTawInstances(DescribeTawInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTawInstancesResponse>(req, "DescribeTawInstances");
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawInstancesRequest"/></param>
        /// <returns><see cref="DescribeTawInstancesResponse"/></returns>
        public DescribeTawInstancesResponse DescribeTawInstancesSync(DescribeTawInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTawInstancesResponse>(req, "DescribeTawInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询令牌
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public Task<DescribeTokenResponse> DescribeToken(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken");
        }

        /// <summary>
        /// 查询令牌
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public DescribeTokenResponse DescribeTokenSync(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询top问题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopIssuesRequest"/></param>
        /// <returns><see cref="DescribeTopIssuesResponse"/></returns>
        public Task<DescribeTopIssuesResponse> DescribeTopIssues(DescribeTopIssuesRequest req)
        {
            return InternalRequestAsync<DescribeTopIssuesResponse>(req, "DescribeTopIssues");
        }

        /// <summary>
        /// 查询top问题列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTopIssuesRequest"/></param>
        /// <returns><see cref="DescribeTopIssuesResponse"/></returns>
        public DescribeTopIssuesResponse DescribeTopIssuesSync(DescribeTopIssuesRequest req)
        {
            return InternalRequestAsync<DescribeTopIssuesResponse>(req, "DescribeTopIssues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户旅程数据
        /// </summary>
        /// <param name="req"><see cref="DescribeUserJourneySanKeyRequest"/></param>
        /// <returns><see cref="DescribeUserJourneySanKeyResponse"/></returns>
        public Task<DescribeUserJourneySanKeyResponse> DescribeUserJourneySanKey(DescribeUserJourneySanKeyRequest req)
        {
            return InternalRequestAsync<DescribeUserJourneySanKeyResponse>(req, "DescribeUserJourneySanKey");
        }

        /// <summary>
        /// 获取用户旅程数据
        /// </summary>
        /// <param name="req"><see cref="DescribeUserJourneySanKeyRequest"/></param>
        /// <returns><see cref="DescribeUserJourneySanKeyResponse"/></returns>
        public DescribeUserJourneySanKeyResponse DescribeUserJourneySanKeySync(DescribeUserJourneySanKeyRequest req)
        {
            return InternalRequestAsync<DescribeUserJourneySanKeyResponse>(req, "DescribeUserJourneySanKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的UV列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public Task<DescribeUvListResponse> DescribeUvList(DescribeUvListRequest req)
        {
            return InternalRequestAsync<DescribeUvListResponse>(req, "DescribeUvList");
        }

        /// <summary>
        /// 获取项目下的UV列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public DescribeUvListResponse DescribeUvListSync(DescribeUvListRequest req)
        {
            return InternalRequestAsync<DescribeUvListResponse>(req, "DescribeUvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public Task<DescribeWhitelistsResponse> DescribeWhitelists(DescribeWhitelistsRequest req)
        {
            return InternalRequestAsync<DescribeWhitelistsResponse>(req, "DescribeWhitelists");
        }

        /// <summary>
        /// 获取白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public DescribeWhitelistsResponse DescribeWhitelistsSync(DescribeWhitelistsRequest req)
        {
            return InternalRequestAsync<DescribeWhitelistsResponse>(req, "DescribeWhitelists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改字段配置规则
        /// </summary>
        /// <param name="req"><see cref="ModifyFieldTransformRuleRequest"/></param>
        /// <returns><see cref="ModifyFieldTransformRuleResponse"/></returns>
        public Task<ModifyFieldTransformRuleResponse> ModifyFieldTransformRule(ModifyFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<ModifyFieldTransformRuleResponse>(req, "ModifyFieldTransformRule");
        }

        /// <summary>
        /// 修改字段配置规则
        /// </summary>
        /// <param name="req"><see cref="ModifyFieldTransformRuleRequest"/></param>
        /// <returns><see cref="ModifyFieldTransformRuleResponse"/></returns>
        public ModifyFieldTransformRuleResponse ModifyFieldTransformRuleSync(ModifyFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<ModifyFieldTransformRuleResponse>(req, "ModifyFieldTransformRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 RUM 业务系统
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 修改 RUM 业务系统
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Issue 状态，支持 resolve、ignore、reopen 等状态流转动作
        /// </summary>
        /// <param name="req"><see cref="ModifyIssueStatusRequest"/></param>
        /// <returns><see cref="ModifyIssueStatusResponse"/></returns>
        public Task<ModifyIssueStatusResponse> ModifyIssueStatus(ModifyIssueStatusRequest req)
        {
            return InternalRequestAsync<ModifyIssueStatusResponse>(req, "ModifyIssueStatus");
        }

        /// <summary>
        /// 更新 Issue 状态，支持 resolve、ignore、reopen 等状态流转动作
        /// </summary>
        /// <param name="req"><see cref="ModifyIssueStatusRequest"/></param>
        /// <returns><see cref="ModifyIssueStatusResponse"/></returns>
        public ModifyIssueStatusResponse ModifyIssueStatusSync(ModifyIssueStatusRequest req)
        {
            return InternalRequestAsync<ModifyIssueStatusResponse>(req, "ModifyIssueStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新回放包元数据，仅支持改Release，不重编译。换源码请再调UploadMiniProgramSource。
        /// </summary>
        /// <param name="req"><see cref="ModifyMiniProgramReplayPackRequest"/></param>
        /// <returns><see cref="ModifyMiniProgramReplayPackResponse"/></returns>
        public Task<ModifyMiniProgramReplayPackResponse> ModifyMiniProgramReplayPack(ModifyMiniProgramReplayPackRequest req)
        {
            return InternalRequestAsync<ModifyMiniProgramReplayPackResponse>(req, "ModifyMiniProgramReplayPack");
        }

        /// <summary>
        /// 更新回放包元数据，仅支持改Release，不重编译。换源码请再调UploadMiniProgramSource。
        /// </summary>
        /// <param name="req"><see cref="ModifyMiniProgramReplayPackRequest"/></param>
        /// <returns><see cref="ModifyMiniProgramReplayPackResponse"/></returns>
        public ModifyMiniProgramReplayPackResponse ModifyMiniProgramReplayPackSync(ModifyMiniProgramReplayPackRequest req)
        {
            return InternalRequestAsync<ModifyMiniProgramReplayPackResponse>(req, "ModifyMiniProgramReplayPack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 RUM 应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 修改 RUM 应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增修改限流
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public Task<ModifyProjectLimitResponse> ModifyProjectLimit(ModifyProjectLimitRequest req)
        {
            return InternalRequestAsync<ModifyProjectLimitResponse>(req, "ModifyProjectLimit");
        }

        /// <summary>
        /// 新增修改限流
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public ModifyProjectLimitResponse ModifyProjectLimitSync(ModifyProjectLimitRequest req)
        {
            return InternalRequestAsync<ModifyProjectLimitResponse>(req, "ModifyProjectLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置tdem采样率
        /// </summary>
        /// <param name="req"><see cref="ModifySampleRateRequest"/></param>
        /// <returns><see cref="ModifySampleRateResponse"/></returns>
        public Task<ModifySampleRateResponse> ModifySampleRate(ModifySampleRateRequest req)
        {
            return InternalRequestAsync<ModifySampleRateResponse>(req, "ModifySampleRate");
        }

        /// <summary>
        /// 配置tdem采样率
        /// </summary>
        /// <param name="req"><see cref="ModifySampleRateRequest"/></param>
        /// <returns><see cref="ModifySampleRateResponse"/></returns>
        public ModifySampleRateResponse ModifySampleRateSync(ModifySampleRateRequest req)
        {
            return InternalRequestAsync<ModifySampleRateResponse>(req, "ModifySampleRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用，仅传需修改字段。AppId 必填。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMApplicationRequest"/></param>
        /// <returns><see cref="ModifyTDEMApplicationResponse"/></returns>
        public Task<ModifyTDEMApplicationResponse> ModifyTDEMApplication(ModifyTDEMApplicationRequest req)
        {
            return InternalRequestAsync<ModifyTDEMApplicationResponse>(req, "ModifyTDEMApplication");
        }

        /// <summary>
        /// 修改应用，仅传需修改字段。AppId 必填。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMApplicationRequest"/></param>
        /// <returns><see cref="ModifyTDEMApplicationResponse"/></returns>
        public ModifyTDEMApplicationResponse ModifyTDEMApplicationSync(ModifyTDEMApplicationRequest req)
        {
            return InternalRequestAsync<ModifyTDEMApplicationResponse>(req, "ModifyTDEMApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改业务系统名称或描述。越权 UnauthorizedOperation；不存在或已删除 ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMBusinessSystemRequest"/></param>
        /// <returns><see cref="ModifyTDEMBusinessSystemResponse"/></returns>
        public Task<ModifyTDEMBusinessSystemResponse> ModifyTDEMBusinessSystem(ModifyTDEMBusinessSystemRequest req)
        {
            return InternalRequestAsync<ModifyTDEMBusinessSystemResponse>(req, "ModifyTDEMBusinessSystem");
        }

        /// <summary>
        /// 修改业务系统名称或描述。越权 UnauthorizedOperation；不存在或已删除 ResourceNotFound。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMBusinessSystemRequest"/></param>
        /// <returns><see cref="ModifyTDEMBusinessSystemResponse"/></returns>
        public ModifyTDEMBusinessSystemResponse ModifyTDEMBusinessSystemSync(ModifyTDEMBusinessSystemRequest req)
        {
            return InternalRequestAsync<ModifyTDEMBusinessSystemResponse>(req, "ModifyTDEMBusinessSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改拨测任务。未出现在请求中的字段保持原值。启动范围传空字符串表示清空该项。Type 和 ExecutionTime 创建后不可修改。暂停和恢复通过 Status 完成，不提供单独的状态接口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMDialTaskRequest"/></param>
        /// <returns><see cref="ModifyTDEMDialTaskResponse"/></returns>
        public Task<ModifyTDEMDialTaskResponse> ModifyTDEMDialTask(ModifyTDEMDialTaskRequest req)
        {
            return InternalRequestAsync<ModifyTDEMDialTaskResponse>(req, "ModifyTDEMDialTask");
        }

        /// <summary>
        /// 修改拨测任务。未出现在请求中的字段保持原值。启动范围传空字符串表示清空该项。Type 和 ExecutionTime 创建后不可修改。暂停和恢复通过 Status 完成，不提供单独的状态接口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMDialTaskRequest"/></param>
        /// <returns><see cref="ModifyTDEMDialTaskResponse"/></returns>
        public ModifyTDEMDialTaskResponse ModifyTDEMDialTaskSync(ModifyTDEMDialTaskRequest req)
        {
            return InternalRequestAsync<ModifyTDEMDialTaskResponse>(req, "ModifyTDEMDialTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按规则 Id 修改字段值替换规则。替代已废弃的 ModifyFieldTransformRule；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMFieldTransformRuleRequest"/></param>
        /// <returns><see cref="ModifyTDEMFieldTransformRuleResponse"/></returns>
        public Task<ModifyTDEMFieldTransformRuleResponse> ModifyTDEMFieldTransformRule(ModifyTDEMFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<ModifyTDEMFieldTransformRuleResponse>(req, "ModifyTDEMFieldTransformRule");
        }

        /// <summary>
        /// 按规则 Id 修改字段值替换规则。替代已废弃的 ModifyFieldTransformRule；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMFieldTransformRuleRequest"/></param>
        /// <returns><see cref="ModifyTDEMFieldTransformRuleResponse"/></returns>
        public ModifyTDEMFieldTransformRuleResponse ModifyTDEMFieldTransformRuleSync(ModifyTDEMFieldTransformRuleRequest req)
        {
            return InternalRequestAsync<ModifyTDEMFieldTransformRuleResponse>(req, "ModifyTDEMFieldTransformRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改漏斗
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMFunnelRequest"/></param>
        /// <returns><see cref="ModifyTDEMFunnelResponse"/></returns>
        public Task<ModifyTDEMFunnelResponse> ModifyTDEMFunnel(ModifyTDEMFunnelRequest req)
        {
            return InternalRequestAsync<ModifyTDEMFunnelResponse>(req, "ModifyTDEMFunnel");
        }

        /// <summary>
        /// 修改漏斗
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMFunnelRequest"/></param>
        /// <returns><see cref="ModifyTDEMFunnelResponse"/></returns>
        public ModifyTDEMFunnelResponse ModifyTDEMFunnelSync(ModifyTDEMFunnelRequest req)
        {
            return InternalRequestAsync<ModifyTDEMFunnelResponse>(req, "ModifyTDEMFunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 整页保存 Web 规则化采样文档：校验 → INSERT 快照 → UPSERT 当前行 → 刷新 Redis 下发缓存。不写 tdem_sample_rate。采样率 0–100、最多两位小数；规则 Conditions 不可为空；Types 含非闭集 key 返回 InvalidParameter。校验失败不写库。无 Restore/Import/Export/Diff。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMSampleConfigRequest"/></param>
        /// <returns><see cref="ModifyTDEMSampleConfigResponse"/></returns>
        public Task<ModifyTDEMSampleConfigResponse> ModifyTDEMSampleConfig(ModifyTDEMSampleConfigRequest req)
        {
            return InternalRequestAsync<ModifyTDEMSampleConfigResponse>(req, "ModifyTDEMSampleConfig");
        }

        /// <summary>
        /// 整页保存 Web 规则化采样文档：校验 → INSERT 快照 → UPSERT 当前行 → 刷新 Redis 下发缓存。不写 tdem_sample_rate。采样率 0–100、最多两位小数；规则 Conditions 不可为空；Types 含非闭集 key 返回 InvalidParameter。校验失败不写库。无 Restore/Import/Export/Diff。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMSampleConfigRequest"/></param>
        /// <returns><see cref="ModifyTDEMSampleConfigResponse"/></returns>
        public ModifyTDEMSampleConfigResponse ModifyTDEMSampleConfigSync(ModifyTDEMSampleConfigRequest req)
        {
            return InternalRequestAsync<ModifyTDEMSampleConfigResponse>(req, "ModifyTDEMSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置或更新应用采集采样率；ReplaySampleRate 可选。替代已废弃的 ModifySampleRate；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMSampleRateRequest"/></param>
        /// <returns><see cref="ModifyTDEMSampleRateResponse"/></returns>
        public Task<ModifyTDEMSampleRateResponse> ModifyTDEMSampleRate(ModifyTDEMSampleRateRequest req)
        {
            return InternalRequestAsync<ModifyTDEMSampleRateResponse>(req, "ModifyTDEMSampleRate");
        }

        /// <summary>
        /// 设置或更新应用采集采样率；ReplaySampleRate 可选。替代已废弃的 ModifySampleRate；AppId 为 string。
        /// </summary>
        /// <param name="req"><see cref="ModifyTDEMSampleRateRequest"/></param>
        /// <returns><see cref="ModifyTDEMSampleRateResponse"/></returns>
        public ModifyTDEMSampleRateResponse ModifyTDEMSampleRateSync(ModifyTDEMSampleRateRequest req)
        {
            return InternalRequestAsync<ModifyTDEMSampleRateResponse>(req, "ModifyTDEMSampleRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据步骤配置直接生成漏斗预览报告（不保存漏斗，不需要FunnelId）
        /// </summary>
        /// <param name="req"><see cref="PreviewTDEMFunnelReportRequest"/></param>
        /// <returns><see cref="PreviewTDEMFunnelReportResponse"/></returns>
        public Task<PreviewTDEMFunnelReportResponse> PreviewTDEMFunnelReport(PreviewTDEMFunnelReportRequest req)
        {
            return InternalRequestAsync<PreviewTDEMFunnelReportResponse>(req, "PreviewTDEMFunnelReport");
        }

        /// <summary>
        /// 根据步骤配置直接生成漏斗预览报告（不保存漏斗，不需要FunnelId）
        /// </summary>
        /// <param name="req"><see cref="PreviewTDEMFunnelReportRequest"/></param>
        /// <returns><see cref="PreviewTDEMFunnelReportResponse"/></returns>
        public PreviewTDEMFunnelReportResponse PreviewTDEMFunnelReportSync(PreviewTDEMFunnelReportRequest req)
        {
            return InternalRequestAsync<PreviewTDEMFunnelReportResponse>(req, "PreviewTDEMFunnelReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复 RUM 业务系统，恢复后，用户可以正常使用和上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public Task<ResumeInstanceResponse> ResumeInstance(ResumeInstanceRequest req)
        {
            return InternalRequestAsync<ResumeInstanceResponse>(req, "ResumeInstance");
        }

        /// <summary>
        /// 恢复 RUM 业务系统，恢复后，用户可以正常使用和上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public ResumeInstanceResponse ResumeInstanceSync(ResumeInstanceRequest req)
        {
            return InternalRequestAsync<ResumeInstanceResponse>(req, "ResumeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复应用使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeProjectRequest"/></param>
        /// <returns><see cref="ResumeProjectResponse"/></returns>
        public Task<ResumeProjectResponse> ResumeProject(ResumeProjectRequest req)
        {
            return InternalRequestAsync<ResumeProjectResponse>(req, "ResumeProject");
        }

        /// <summary>
        /// 恢复应用使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeProjectRequest"/></param>
        /// <returns><see cref="ResumeProjectResponse"/></returns>
        public ResumeProjectResponse ResumeProjectSync(ResumeProjectRequest req)
        {
            return InternalRequestAsync<ResumeProjectResponse>(req, "ResumeProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复已停止的应用，Status 变为 2。
        /// </summary>
        /// <param name="req"><see cref="ResumeTDEMApplicationRequest"/></param>
        /// <returns><see cref="ResumeTDEMApplicationResponse"/></returns>
        public Task<ResumeTDEMApplicationResponse> ResumeTDEMApplication(ResumeTDEMApplicationRequest req)
        {
            return InternalRequestAsync<ResumeTDEMApplicationResponse>(req, "ResumeTDEMApplication");
        }

        /// <summary>
        /// 恢复已停止的应用，Status 变为 2。
        /// </summary>
        /// <param name="req"><see cref="ResumeTDEMApplicationRequest"/></param>
        /// <returns><see cref="ResumeTDEMApplicationResponse"/></returns>
        public ResumeTDEMApplicationResponse ResumeTDEMApplicationSync(ResumeTDEMApplicationRequest req)
        {
            return InternalRequestAsync<ResumeTDEMApplicationResponse>(req, "ResumeTDEMApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止实例
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public Task<StopInstanceResponse> StopInstance(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance");
        }

        /// <summary>
        /// 停止实例
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public StopInstanceResponse StopInstanceSync(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止项目使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="StopProjectRequest"/></param>
        /// <returns><see cref="StopProjectResponse"/></returns>
        public Task<StopProjectResponse> StopProject(StopProjectRequest req)
        {
            return InternalRequestAsync<StopProjectResponse>(req, "StopProject");
        }

        /// <summary>
        /// 停止项目使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="StopProjectRequest"/></param>
        /// <returns><see cref="StopProjectResponse"/></returns>
        public StopProjectResponse StopProjectSync(StopProjectRequest req)
        {
            return InternalRequestAsync<StopProjectResponse>(req, "StopProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止应用采集，Status 变为 6。
        /// </summary>
        /// <param name="req"><see cref="StopTDEMApplicationRequest"/></param>
        /// <returns><see cref="StopTDEMApplicationResponse"/></returns>
        public Task<StopTDEMApplicationResponse> StopTDEMApplication(StopTDEMApplicationRequest req)
        {
            return InternalRequestAsync<StopTDEMApplicationResponse>(req, "StopTDEMApplication");
        }

        /// <summary>
        /// 停止应用采集，Status 变为 6。
        /// </summary>
        /// <param name="req"><see cref="StopTDEMApplicationRequest"/></param>
        /// <returns><see cref="StopTDEMApplicationResponse"/></returns>
        public StopTDEMApplicationResponse StopTDEMApplicationSync(StopTDEMApplicationRequest req)
        {
            return InternalRequestAsync<StopTDEMApplicationResponse>(req, "StopTDEMApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传微信小程序源码zip并同步编译回放包。控制台传FileBase64；zip需含app.json，跳过node_modules。同AppId+BundleHash且已ready则幂等。
        /// </summary>
        /// <param name="req"><see cref="UploadMiniProgramSourceRequest"/></param>
        /// <returns><see cref="UploadMiniProgramSourceResponse"/></returns>
        public Task<UploadMiniProgramSourceResponse> UploadMiniProgramSource(UploadMiniProgramSourceRequest req)
        {
            return InternalRequestAsync<UploadMiniProgramSourceResponse>(req, "UploadMiniProgramSource");
        }

        /// <summary>
        /// 上传微信小程序源码zip并同步编译回放包。控制台传FileBase64；zip需含app.json，跳过node_modules。同AppId+BundleHash且已ready则幂等。
        /// </summary>
        /// <param name="req"><see cref="UploadMiniProgramSourceRequest"/></param>
        /// <returns><see cref="UploadMiniProgramSourceResponse"/></returns>
        public UploadMiniProgramSourceResponse UploadMiniProgramSourceSync(UploadMiniProgramSourceRequest req)
        {
            return InternalRequestAsync<UploadMiniProgramSourceResponse>(req, "UploadMiniProgramSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 登记已上传的符号制品。请先获取上传凭证并将文件上传到 COS。
        /// </summary>
        /// <param name="req"><see cref="UploadSymbolArtifactRequest"/></param>
        /// <returns><see cref="UploadSymbolArtifactResponse"/></returns>
        public Task<UploadSymbolArtifactResponse> UploadSymbolArtifact(UploadSymbolArtifactRequest req)
        {
            return InternalRequestAsync<UploadSymbolArtifactResponse>(req, "UploadSymbolArtifact");
        }

        /// <summary>
        /// 登记已上传的符号制品。请先获取上传凭证并将文件上传到 COS。
        /// </summary>
        /// <param name="req"><see cref="UploadSymbolArtifactRequest"/></param>
        /// <returns><see cref="UploadSymbolArtifactResponse"/></returns>
        public UploadSymbolArtifactResponse UploadSymbolArtifactSync(UploadSymbolArtifactRequest req)
        {
            return InternalRequestAsync<UploadSymbolArtifactResponse>(req, "UploadSymbolArtifact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
