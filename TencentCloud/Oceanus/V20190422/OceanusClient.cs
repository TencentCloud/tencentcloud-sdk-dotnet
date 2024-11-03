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

namespace TencentCloud.Oceanus.V20190422
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Oceanus.V20190422.Models;

   public class OceanusClient : AbstractClient{

       private const string endpoint = "oceanus.tencentcloudapi.com";
       private const string version = "2019-04-22";
       private const string sdkVersion = "SDK_NET_3.0.1116";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OceanusClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OceanusClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 检查快照是否可用
        /// </summary>
        /// <param name="req"><see cref="CheckSavepointRequest"/></param>
        /// <returns><see cref="CheckSavepointResponse"/></returns>
        public Task<CheckSavepointResponse> CheckSavepoint(CheckSavepointRequest req)
        {
            return InternalRequestAsync<CheckSavepointResponse>(req, "CheckSavepoint");
        }

        /// <summary>
        /// 检查快照是否可用
        /// </summary>
        /// <param name="req"><see cref="CheckSavepointRequest"/></param>
        /// <returns><see cref="CheckSavepointResponse"/></returns>
        public CheckSavepointResponse CheckSavepointSync(CheckSavepointRequest req)
        {
            return InternalRequestAsync<CheckSavepointResponse>(req, "CheckSavepoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 单条和批量复制作业
        /// </summary>
        /// <param name="req"><see cref="CopyJobsRequest"/></param>
        /// <returns><see cref="CopyJobsResponse"/></returns>
        public Task<CopyJobsResponse> CopyJobs(CopyJobsRequest req)
        {
            return InternalRequestAsync<CopyJobsResponse>(req, "CopyJobs");
        }

        /// <summary>
        /// 单条和批量复制作业
        /// </summary>
        /// <param name="req"><see cref="CopyJobsRequest"/></param>
        /// <returns><see cref="CopyJobsResponse"/></returns>
        public CopyJobsResponse CopyJobsSync(CopyJobsRequest req)
        {
            return InternalRequestAsync<CopyJobsResponse>(req, "CopyJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 作业列表页面新建文件夹请求
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public Task<CreateFolderResponse> CreateFolder(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder");
        }

        /// <summary>
        /// 作业列表页面新建文件夹请求
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public CreateFolderResponse CreateFolderSync(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建作业接口，一个 AppId 最多允许创建1000个作业
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public Task<CreateJobResponse> CreateJob(CreateJobRequest req)
        {
            return InternalRequestAsync<CreateJobResponse>(req, "CreateJob");
        }

        /// <summary>
        /// 新建作业接口，一个 AppId 最多允许创建1000个作业
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public CreateJobResponse CreateJobSync(CreateJobRequest req)
        {
            return InternalRequestAsync<CreateJobResponse>(req, "CreateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建作业配置，一个作业最多有100个配置版本
        /// </summary>
        /// <param name="req"><see cref="CreateJobConfigRequest"/></param>
        /// <returns><see cref="CreateJobConfigResponse"/></returns>
        public Task<CreateJobConfigResponse> CreateJobConfig(CreateJobConfigRequest req)
        {
            return InternalRequestAsync<CreateJobConfigResponse>(req, "CreateJobConfig");
        }

        /// <summary>
        /// 创建作业配置，一个作业最多有100个配置版本
        /// </summary>
        /// <param name="req"><see cref="CreateJobConfigRequest"/></param>
        /// <returns><see cref="CreateJobConfigResponse"/></returns>
        public CreateJobConfigResponse CreateJobConfigSync(CreateJobConfigRequest req)
        {
            return InternalRequestAsync<CreateJobConfigResponse>(req, "CreateJobConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资源接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource");
        }

        /// <summary>
        /// 创建资源接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资源配置接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceConfigRequest"/></param>
        /// <returns><see cref="CreateResourceConfigResponse"/></returns>
        public Task<CreateResourceConfigResponse> CreateResourceConfig(CreateResourceConfigRequest req)
        {
            return InternalRequestAsync<CreateResourceConfigResponse>(req, "CreateResourceConfig");
        }

        /// <summary>
        /// 创建资源配置接口
        /// </summary>
        /// <param name="req"><see cref="CreateResourceConfigRequest"/></param>
        /// <returns><see cref="CreateResourceConfigResponse"/></returns>
        public CreateResourceConfigResponse CreateResourceConfigSync(CreateResourceConfigRequest req)
        {
            return InternalRequestAsync<CreateResourceConfigResponse>(req, "CreateResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkSpaceRequest"/></param>
        /// <returns><see cref="CreateWorkSpaceResponse"/></returns>
        public Task<CreateWorkSpaceResponse> CreateWorkSpace(CreateWorkSpaceRequest req)
        {
            return InternalRequestAsync<CreateWorkSpaceResponse>(req, "CreateWorkSpace");
        }

        /// <summary>
        /// 创建工作空间
        /// </summary>
        /// <param name="req"><see cref="CreateWorkSpaceRequest"/></param>
        /// <returns><see cref="CreateWorkSpaceResponse"/></returns>
        public CreateWorkSpaceResponse CreateWorkSpaceSync(CreateWorkSpaceRequest req)
        {
            return InternalRequestAsync<CreateWorkSpaceResponse>(req, "CreateWorkSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 作业列表删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFoldersRequest"/></param>
        /// <returns><see cref="DeleteFoldersResponse"/></returns>
        public Task<DeleteFoldersResponse> DeleteFolders(DeleteFoldersRequest req)
        {
            return InternalRequestAsync<DeleteFoldersResponse>(req, "DeleteFolders");
        }

        /// <summary>
        /// 作业列表删除文件夹
        /// </summary>
        /// <param name="req"><see cref="DeleteFoldersRequest"/></param>
        /// <returns><see cref="DeleteFoldersResponse"/></returns>
        public DeleteFoldersResponse DeleteFoldersSync(DeleteFoldersRequest req)
        {
            return InternalRequestAsync<DeleteFoldersResponse>(req, "DeleteFolders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除作业配置
        /// </summary>
        /// <param name="req"><see cref="DeleteJobConfigsRequest"/></param>
        /// <returns><see cref="DeleteJobConfigsResponse"/></returns>
        public Task<DeleteJobConfigsResponse> DeleteJobConfigs(DeleteJobConfigsRequest req)
        {
            return InternalRequestAsync<DeleteJobConfigsResponse>(req, "DeleteJobConfigs");
        }

        /// <summary>
        /// 删除作业配置
        /// </summary>
        /// <param name="req"><see cref="DeleteJobConfigsRequest"/></param>
        /// <returns><see cref="DeleteJobConfigsResponse"/></returns>
        public DeleteJobConfigsResponse DeleteJobConfigsSync(DeleteJobConfigsRequest req)
        {
            return InternalRequestAsync<DeleteJobConfigsResponse>(req, "DeleteJobConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除作业接口，批量操作数量上限20
        /// </summary>
        /// <param name="req"><see cref="DeleteJobsRequest"/></param>
        /// <returns><see cref="DeleteJobsResponse"/></returns>
        public Task<DeleteJobsResponse> DeleteJobs(DeleteJobsRequest req)
        {
            return InternalRequestAsync<DeleteJobsResponse>(req, "DeleteJobs");
        }

        /// <summary>
        /// 批量删除作业接口，批量操作数量上限20
        /// </summary>
        /// <param name="req"><see cref="DeleteJobsRequest"/></param>
        /// <returns><see cref="DeleteJobsResponse"/></returns>
        public DeleteJobsResponse DeleteJobsSync(DeleteJobsRequest req)
        {
            return InternalRequestAsync<DeleteJobsResponse>(req, "DeleteJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资源版本
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceConfigsRequest"/></param>
        /// <returns><see cref="DeleteResourceConfigsResponse"/></returns>
        public Task<DeleteResourceConfigsResponse> DeleteResourceConfigs(DeleteResourceConfigsRequest req)
        {
            return InternalRequestAsync<DeleteResourceConfigsResponse>(req, "DeleteResourceConfigs");
        }

        /// <summary>
        /// 删除资源版本
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceConfigsRequest"/></param>
        /// <returns><see cref="DeleteResourceConfigsResponse"/></returns>
        public DeleteResourceConfigsResponse DeleteResourceConfigsSync(DeleteResourceConfigsRequest req)
        {
            return InternalRequestAsync<DeleteResourceConfigsResponse>(req, "DeleteResourceConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资源接口
        /// </summary>
        /// <param name="req"><see cref="DeleteResourcesRequest"/></param>
        /// <returns><see cref="DeleteResourcesResponse"/></returns>
        public Task<DeleteResourcesResponse> DeleteResources(DeleteResourcesRequest req)
        {
            return InternalRequestAsync<DeleteResourcesResponse>(req, "DeleteResources");
        }

        /// <summary>
        /// 删除资源接口
        /// </summary>
        /// <param name="req"><see cref="DeleteResourcesRequest"/></param>
        /// <returns><see cref="DeleteResourcesResponse"/></returns>
        public DeleteResourcesResponse DeleteResourcesSync(DeleteResourcesRequest req)
        {
            return InternalRequestAsync<DeleteResourcesResponse>(req, "DeleteResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除作业表配置
        /// </summary>
        /// <param name="req"><see cref="DeleteTableConfigRequest"/></param>
        /// <returns><see cref="DeleteTableConfigResponse"/></returns>
        public Task<DeleteTableConfigResponse> DeleteTableConfig(DeleteTableConfigRequest req)
        {
            return InternalRequestAsync<DeleteTableConfigResponse>(req, "DeleteTableConfig");
        }

        /// <summary>
        /// 删除作业表配置
        /// </summary>
        /// <param name="req"><see cref="DeleteTableConfigRequest"/></param>
        /// <returns><see cref="DeleteTableConfigResponse"/></returns>
        public DeleteTableConfigResponse DeleteTableConfigSync(DeleteTableConfigRequest req)
        {
            return InternalRequestAsync<DeleteTableConfigResponse>(req, "DeleteTableConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkSpaceRequest"/></param>
        /// <returns><see cref="DeleteWorkSpaceResponse"/></returns>
        public Task<DeleteWorkSpaceResponse> DeleteWorkSpace(DeleteWorkSpaceRequest req)
        {
            return InternalRequestAsync<DeleteWorkSpaceResponse>(req, "DeleteWorkSpace");
        }

        /// <summary>
        /// 删除工作空间
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkSpaceRequest"/></param>
        /// <returns><see cref="DeleteWorkSpaceResponse"/></returns>
        public DeleteWorkSpaceResponse DeleteWorkSpaceSync(DeleteWorkSpaceRequest req)
        {
            return InternalRequestAsync<DeleteWorkSpaceResponse>(req, "DeleteWorkSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 查询集群
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定文件夹及其相应的子文件夹信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderRequest"/></param>
        /// <returns><see cref="DescribeFolderResponse"/></returns>
        public Task<DescribeFolderResponse> DescribeFolder(DescribeFolderRequest req)
        {
            return InternalRequestAsync<DescribeFolderResponse>(req, "DescribeFolder");
        }

        /// <summary>
        /// 查询指定文件夹及其相应的子文件夹信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFolderRequest"/></param>
        /// <returns><see cref="DescribeFolderResponse"/></returns>
        public DescribeFolderResponse DescribeFolderSync(DescribeFolderRequest req)
        {
            return InternalRequestAsync<DescribeFolderResponse>(req, "DescribeFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询作业配置列表，一次最多查询100个
        /// </summary>
        /// <param name="req"><see cref="DescribeJobConfigsRequest"/></param>
        /// <returns><see cref="DescribeJobConfigsResponse"/></returns>
        public Task<DescribeJobConfigsResponse> DescribeJobConfigs(DescribeJobConfigsRequest req)
        {
            return InternalRequestAsync<DescribeJobConfigsResponse>(req, "DescribeJobConfigs");
        }

        /// <summary>
        /// 查询作业配置列表，一次最多查询100个
        /// </summary>
        /// <param name="req"><see cref="DescribeJobConfigsRequest"/></param>
        /// <returns><see cref="DescribeJobConfigsResponse"/></returns>
        public DescribeJobConfigsResponse DescribeJobConfigsSync(DescribeJobConfigsRequest req)
        {
            return InternalRequestAsync<DescribeJobConfigsResponse>(req, "DescribeJobConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定作业的事件，包括作业启动停止、运行失败、快照失败、作业异常等各种事件类型
        /// </summary>
        /// <param name="req"><see cref="DescribeJobEventsRequest"/></param>
        /// <returns><see cref="DescribeJobEventsResponse"/></returns>
        public Task<DescribeJobEventsResponse> DescribeJobEvents(DescribeJobEventsRequest req)
        {
            return InternalRequestAsync<DescribeJobEventsResponse>(req, "DescribeJobEvents");
        }

        /// <summary>
        /// 获取指定作业的事件，包括作业启动停止、运行失败、快照失败、作业异常等各种事件类型
        /// </summary>
        /// <param name="req"><see cref="DescribeJobEventsRequest"/></param>
        /// <returns><see cref="DescribeJobEventsResponse"/></returns>
        public DescribeJobEventsResponse DescribeJobEventsSync(DescribeJobEventsRequest req)
        {
            return InternalRequestAsync<DescribeJobEventsResponse>(req, "DescribeJobEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取作业运行时的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRuntimeInfoRequest"/></param>
        /// <returns><see cref="DescribeJobRuntimeInfoResponse"/></returns>
        public Task<DescribeJobRuntimeInfoResponse> DescribeJobRuntimeInfo(DescribeJobRuntimeInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobRuntimeInfoResponse>(req, "DescribeJobRuntimeInfo");
        }

        /// <summary>
        /// 获取作业运行时的信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRuntimeInfoRequest"/></param>
        /// <returns><see cref="DescribeJobRuntimeInfoResponse"/></returns>
        public DescribeJobRuntimeInfoResponse DescribeJobRuntimeInfoSync(DescribeJobRuntimeInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobRuntimeInfoResponse>(req, "DescribeJobRuntimeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查找Savepoint列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSavepointRequest"/></param>
        /// <returns><see cref="DescribeJobSavepointResponse"/></returns>
        public Task<DescribeJobSavepointResponse> DescribeJobSavepoint(DescribeJobSavepointRequest req)
        {
            return InternalRequestAsync<DescribeJobSavepointResponse>(req, "DescribeJobSavepoint");
        }

        /// <summary>
        /// 查找Savepoint列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSavepointRequest"/></param>
        /// <returns><see cref="DescribeJobSavepointResponse"/></returns>
        public DescribeJobSavepointResponse DescribeJobSavepointSync(DescribeJobSavepointRequest req)
        {
            return InternalRequestAsync<DescribeJobSavepointResponse>(req, "DescribeJobSavepoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询作业实例启动日志
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmissionLogRequest"/></param>
        /// <returns><see cref="DescribeJobSubmissionLogResponse"/></returns>
        public Task<DescribeJobSubmissionLogResponse> DescribeJobSubmissionLog(DescribeJobSubmissionLogRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmissionLogResponse>(req, "DescribeJobSubmissionLog");
        }

        /// <summary>
        /// 查询作业实例启动日志
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmissionLogRequest"/></param>
        /// <returns><see cref="DescribeJobSubmissionLogResponse"/></returns>
        public DescribeJobSubmissionLogResponse DescribeJobSubmissionLogSync(DescribeJobSubmissionLogRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmissionLogResponse>(req, "DescribeJobSubmissionLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询作业
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs");
        }

        /// <summary>
        /// 查询作业
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 描述资源配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceConfigsRequest"/></param>
        /// <returns><see cref="DescribeResourceConfigsResponse"/></returns>
        public Task<DescribeResourceConfigsResponse> DescribeResourceConfigs(DescribeResourceConfigsRequest req)
        {
            return InternalRequestAsync<DescribeResourceConfigsResponse>(req, "DescribeResourceConfigs");
        }

        /// <summary>
        /// 描述资源配置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceConfigsRequest"/></param>
        /// <returns><see cref="DescribeResourceConfigsResponse"/></returns>
        public DescribeResourceConfigsResponse DescribeResourceConfigsSync(DescribeResourceConfigsRequest req)
        {
            return InternalRequestAsync<DescribeResourceConfigsResponse>(req, "DescribeResourceConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源关联作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceRelatedJobsRequest"/></param>
        /// <returns><see cref="DescribeResourceRelatedJobsResponse"/></returns>
        public Task<DescribeResourceRelatedJobsResponse> DescribeResourceRelatedJobs(DescribeResourceRelatedJobsRequest req)
        {
            return InternalRequestAsync<DescribeResourceRelatedJobsResponse>(req, "DescribeResourceRelatedJobs");
        }

        /// <summary>
        /// 获取资源关联作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceRelatedJobsRequest"/></param>
        /// <returns><see cref="DescribeResourceRelatedJobsResponse"/></returns>
        public DescribeResourceRelatedJobsResponse DescribeResourceRelatedJobsSync(DescribeResourceRelatedJobsRequest req)
        {
            return InternalRequestAsync<DescribeResourceRelatedJobsResponse>(req, "DescribeResourceRelatedJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 描述资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources");
        }

        /// <summary>
        /// 描述资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 描述系统资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemResourcesRequest"/></param>
        /// <returns><see cref="DescribeSystemResourcesResponse"/></returns>
        public Task<DescribeSystemResourcesResponse> DescribeSystemResources(DescribeSystemResourcesRequest req)
        {
            return InternalRequestAsync<DescribeSystemResourcesResponse>(req, "DescribeSystemResources");
        }

        /// <summary>
        /// 描述系统资源接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemResourcesRequest"/></param>
        /// <returns><see cref="DescribeSystemResourcesResponse"/></returns>
        public DescribeSystemResourcesResponse DescribeSystemResourcesSync(DescribeSystemResourcesRequest req)
        {
            return InternalRequestAsync<DescribeSystemResourcesResponse>(req, "DescribeSystemResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成树状作业显示结构
        /// </summary>
        /// <param name="req"><see cref="DescribeTreeJobsRequest"/></param>
        /// <returns><see cref="DescribeTreeJobsResponse"/></returns>
        public Task<DescribeTreeJobsResponse> DescribeTreeJobs(DescribeTreeJobsRequest req)
        {
            return InternalRequestAsync<DescribeTreeJobsResponse>(req, "DescribeTreeJobs");
        }

        /// <summary>
        /// 生成树状作业显示结构
        /// </summary>
        /// <param name="req"><see cref="DescribeTreeJobsRequest"/></param>
        /// <returns><see cref="DescribeTreeJobsResponse"/></returns>
        public DescribeTreeJobsResponse DescribeTreeJobsSync(DescribeTreeJobsRequest req)
        {
            return InternalRequestAsync<DescribeTreeJobsResponse>(req, "DescribeTreeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询树状结构资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTreeResourcesRequest"/></param>
        /// <returns><see cref="DescribeTreeResourcesResponse"/></returns>
        public Task<DescribeTreeResourcesResponse> DescribeTreeResources(DescribeTreeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeTreeResourcesResponse>(req, "DescribeTreeResources");
        }

        /// <summary>
        /// 查询树状结构资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTreeResourcesRequest"/></param>
        /// <returns><see cref="DescribeTreeResourcesResponse"/></returns>
        public DescribeTreeResourcesResponse DescribeTreeResourcesSync(DescribeTreeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeTreeResourcesResponse>(req, "DescribeTreeResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 授权工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkSpacesRequest"/></param>
        /// <returns><see cref="DescribeWorkSpacesResponse"/></returns>
        public Task<DescribeWorkSpacesResponse> DescribeWorkSpaces(DescribeWorkSpacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkSpacesResponse>(req, "DescribeWorkSpaces");
        }

        /// <summary>
        /// 授权工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkSpacesRequest"/></param>
        /// <returns><see cref="DescribeWorkSpacesResponse"/></returns>
        public DescribeWorkSpacesResponse DescribeWorkSpacesSync(DescribeWorkSpacesRequest req)
        {
            return InternalRequestAsync<DescribeWorkSpacesResponse>(req, "DescribeWorkSpaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Sql Gateway的Statement执行结果
        /// </summary>
        /// <param name="req"><see cref="FetchSqlGatewayStatementResultRequest"/></param>
        /// <returns><see cref="FetchSqlGatewayStatementResultResponse"/></returns>
        public Task<FetchSqlGatewayStatementResultResponse> FetchSqlGatewayStatementResult(FetchSqlGatewayStatementResultRequest req)
        {
            return InternalRequestAsync<FetchSqlGatewayStatementResultResponse>(req, "FetchSqlGatewayStatementResult");
        }

        /// <summary>
        /// 查询Sql Gateway的Statement执行结果
        /// </summary>
        /// <param name="req"><see cref="FetchSqlGatewayStatementResultRequest"/></param>
        /// <returns><see cref="FetchSqlGatewayStatementResultResponse"/></returns>
        public FetchSqlGatewayStatementResultResponse FetchSqlGatewayStatementResultSync(FetchSqlGatewayStatementResultRequest req)
        {
            return InternalRequestAsync<FetchSqlGatewayStatementResultResponse>(req, "FetchSqlGatewayStatementResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询元数据表
        /// </summary>
        /// <param name="req"><see cref="GetMetaTableRequest"/></param>
        /// <returns><see cref="GetMetaTableResponse"/></returns>
        public Task<GetMetaTableResponse> GetMetaTable(GetMetaTableRequest req)
        {
            return InternalRequestAsync<GetMetaTableResponse>(req, "GetMetaTable");
        }

        /// <summary>
        /// 查询元数据表
        /// </summary>
        /// <param name="req"><see cref="GetMetaTableRequest"/></param>
        /// <returns><see cref="GetMetaTableResponse"/></returns>
        public GetMetaTableResponse GetMetaTableSync(GetMetaTableRequest req)
        {
            return InternalRequestAsync<GetMetaTableResponse>(req, "GetMetaTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自定义树状结构页面拖拽文件夹
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public Task<ModifyFolderResponse> ModifyFolder(ModifyFolderRequest req)
        {
            return InternalRequestAsync<ModifyFolderResponse>(req, "ModifyFolder");
        }

        /// <summary>
        /// 自定义树状结构页面拖拽文件夹
        /// </summary>
        /// <param name="req"><see cref="ModifyFolderRequest"/></param>
        /// <returns><see cref="ModifyFolderResponse"/></returns>
        public ModifyFolderResponse ModifyFolderSync(ModifyFolderRequest req)
        {
            return InternalRequestAsync<ModifyFolderResponse>(req, "ModifyFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新作业属性，仅允许以下3种操作，不支持组合操作：
        /// (1)	更新作业名称
        /// (2)	更新作业备注 
        /// (3)	更新作业最大并行度
        /// 变更前提：WorkerCuNum<=MaxParallelism
        /// 如果MaxParallelism变小，不重启作业，待下一次重启生效
        /// 如果MaxParallelism变大，则要求入参RestartAllowed必须为True
        /// 假设作业运行状态，则先停止作业，再启动作业，中间状态丢失
        /// 假设作业暂停状态，则将作业更改为停止状态，中间状态丢失
        /// </summary>
        /// <param name="req"><see cref="ModifyJobRequest"/></param>
        /// <returns><see cref="ModifyJobResponse"/></returns>
        public Task<ModifyJobResponse> ModifyJob(ModifyJobRequest req)
        {
            return InternalRequestAsync<ModifyJobResponse>(req, "ModifyJob");
        }

        /// <summary>
        /// 更新作业属性，仅允许以下3种操作，不支持组合操作：
        /// (1)	更新作业名称
        /// (2)	更新作业备注 
        /// (3)	更新作业最大并行度
        /// 变更前提：WorkerCuNum<=MaxParallelism
        /// 如果MaxParallelism变小，不重启作业，待下一次重启生效
        /// 如果MaxParallelism变大，则要求入参RestartAllowed必须为True
        /// 假设作业运行状态，则先停止作业，再启动作业，中间状态丢失
        /// 假设作业暂停状态，则将作业更改为停止状态，中间状态丢失
        /// </summary>
        /// <param name="req"><see cref="ModifyJobRequest"/></param>
        /// <returns><see cref="ModifyJobResponse"/></returns>
        public ModifyJobResponse ModifyJobSync(ModifyJobRequest req)
        {
            return InternalRequestAsync<ModifyJobResponse>(req, "ModifyJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改工作空间
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkSpaceRequest"/></param>
        /// <returns><see cref="ModifyWorkSpaceResponse"/></returns>
        public Task<ModifyWorkSpaceResponse> ModifyWorkSpace(ModifyWorkSpaceRequest req)
        {
            return InternalRequestAsync<ModifyWorkSpaceResponse>(req, "ModifyWorkSpace");
        }

        /// <summary>
        /// 修改工作空间
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkSpaceRequest"/></param>
        /// <returns><see cref="ModifyWorkSpaceResponse"/></returns>
        public ModifyWorkSpaceResponse ModifyWorkSpaceSync(ModifyWorkSpaceRequest req)
        {
            return InternalRequestAsync<ModifyWorkSpaceResponse>(req, "ModifyWorkSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量启动或者恢复作业，批量操作数量上限20
        /// </summary>
        /// <param name="req"><see cref="RunJobsRequest"/></param>
        /// <returns><see cref="RunJobsResponse"/></returns>
        public Task<RunJobsResponse> RunJobs(RunJobsRequest req)
        {
            return InternalRequestAsync<RunJobsResponse>(req, "RunJobs");
        }

        /// <summary>
        /// 批量启动或者恢复作业，批量操作数量上限20
        /// </summary>
        /// <param name="req"><see cref="RunJobsRequest"/></param>
        /// <returns><see cref="RunJobsResponse"/></returns>
        public RunJobsResponse RunJobsSync(RunJobsRequest req)
        {
            return InternalRequestAsync<RunJobsResponse>(req, "RunJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过Sql gateway执行satement
        /// </summary>
        /// <param name="req"><see cref="RunSqlGatewayStatementRequest"/></param>
        /// <returns><see cref="RunSqlGatewayStatementResponse"/></returns>
        public Task<RunSqlGatewayStatementResponse> RunSqlGatewayStatement(RunSqlGatewayStatementRequest req)
        {
            return InternalRequestAsync<RunSqlGatewayStatementResponse>(req, "RunSqlGatewayStatement");
        }

        /// <summary>
        /// 通过Sql gateway执行satement
        /// </summary>
        /// <param name="req"><see cref="RunSqlGatewayStatementRequest"/></param>
        /// <returns><see cref="RunSqlGatewayStatementResponse"/></returns>
        public RunSqlGatewayStatementResponse RunSqlGatewayStatementSync(RunSqlGatewayStatementRequest req)
        {
            return InternalRequestAsync<RunSqlGatewayStatementResponse>(req, "RunSqlGatewayStatement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量停止作业，批量操作数量上限为20
        /// </summary>
        /// <param name="req"><see cref="StopJobsRequest"/></param>
        /// <returns><see cref="StopJobsResponse"/></returns>
        public Task<StopJobsResponse> StopJobs(StopJobsRequest req)
        {
            return InternalRequestAsync<StopJobsResponse>(req, "StopJobs");
        }

        /// <summary>
        /// 批量停止作业，批量操作数量上限为20
        /// </summary>
        /// <param name="req"><see cref="StopJobsRequest"/></param>
        /// <returns><see cref="StopJobsResponse"/></returns>
        public StopJobsResponse StopJobsSync(StopJobsRequest req)
        {
            return InternalRequestAsync<StopJobsResponse>(req, "StopJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 触发Savepoint
        /// </summary>
        /// <param name="req"><see cref="TriggerJobSavepointRequest"/></param>
        /// <returns><see cref="TriggerJobSavepointResponse"/></returns>
        public Task<TriggerJobSavepointResponse> TriggerJobSavepoint(TriggerJobSavepointRequest req)
        {
            return InternalRequestAsync<TriggerJobSavepointResponse>(req, "TriggerJobSavepoint");
        }

        /// <summary>
        /// 触发Savepoint
        /// </summary>
        /// <param name="req"><see cref="TriggerJobSavepointRequest"/></param>
        /// <returns><see cref="TriggerJobSavepointResponse"/></returns>
        public TriggerJobSavepointResponse TriggerJobSavepointSync(TriggerJobSavepointRequest req)
        {
            return InternalRequestAsync<TriggerJobSavepointResponse>(req, "TriggerJobSavepoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
