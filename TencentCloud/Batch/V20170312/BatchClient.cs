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

namespace TencentCloud.Batch.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Batch.V20170312.Models;

   public class BatchClient : AbstractClient{

       private const string endpoint = "batch.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1079";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BatchClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BatchClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口可将已存在实例添加到计算环境中。
        /// 实例需要满足如下条件：<br/>
        /// 1.实例不在批量计算系统中。<br/>
        /// 2.实例状态要求处于运行中。<br/>
        /// 3.支持预付费实例，按小时后付费实例，专享子机实例。不支持竞价实例。<br/>
        /// 
        /// 此接口会将加入到计算环境中的实例重设UserData和重装操作系统。
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public Task<AttachInstancesResponse> AttachInstances(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances");
        }

        /// <summary>
        /// 此接口可将已存在实例添加到计算环境中。
        /// 实例需要满足如下条件：<br/>
        /// 1.实例不在批量计算系统中。<br/>
        /// 2.实例状态要求处于运行中。<br/>
        /// 3.支持预付费实例，按小时后付费实例，专享子机实例。不支持竞价实例。<br/>
        /// 
        /// 此接口会将加入到计算环境中的实例重设UserData和重装操作系统。
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public AttachInstancesResponse AttachInstancesSync(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建计算环境
        /// </summary>
        /// <param name="req"><see cref="CreateComputeEnvRequest"/></param>
        /// <returns><see cref="CreateComputeEnvResponse"/></returns>
        public Task<CreateComputeEnvResponse> CreateComputeEnv(CreateComputeEnvRequest req)
        {
            return InternalRequestAsync<CreateComputeEnvResponse>(req, "CreateComputeEnv");
        }

        /// <summary>
        /// 用于创建计算环境
        /// </summary>
        /// <param name="req"><see cref="CreateComputeEnvRequest"/></param>
        /// <returns><see cref="CreateComputeEnvResponse"/></returns>
        public CreateComputeEnvResponse CreateComputeEnvSync(CreateComputeEnvRequest req)
        {
            return InternalRequestAsync<CreateComputeEnvResponse>(req, "CreateComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石计算环境
        /// </summary>
        /// <param name="req"><see cref="CreateCpmComputeEnvRequest"/></param>
        /// <returns><see cref="CreateCpmComputeEnvResponse"/></returns>
        public Task<CreateCpmComputeEnvResponse> CreateCpmComputeEnv(CreateCpmComputeEnvRequest req)
        {
            return InternalRequestAsync<CreateCpmComputeEnvResponse>(req, "CreateCpmComputeEnv");
        }

        /// <summary>
        /// 创建黑石计算环境
        /// </summary>
        /// <param name="req"><see cref="CreateCpmComputeEnvRequest"/></param>
        /// <returns><see cref="CreateCpmComputeEnvResponse"/></returns>
        public CreateCpmComputeEnvResponse CreateCpmComputeEnvSync(CreateCpmComputeEnvRequest req)
        {
            return InternalRequestAsync<CreateCpmComputeEnvResponse>(req, "CreateCpmComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建任务模板
        /// </summary>
        /// <param name="req"><see cref="CreateTaskTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskTemplateResponse"/></returns>
        public Task<CreateTaskTemplateResponse> CreateTaskTemplate(CreateTaskTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskTemplateResponse>(req, "CreateTaskTemplate");
        }

        /// <summary>
        /// 用于创建任务模板
        /// </summary>
        /// <param name="req"><see cref="CreateTaskTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskTemplateResponse"/></returns>
        public CreateTaskTemplateResponse CreateTaskTemplateSync(CreateTaskTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskTemplateResponse>(req, "CreateTaskTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除计算环境
        /// </summary>
        /// <param name="req"><see cref="DeleteComputeEnvRequest"/></param>
        /// <returns><see cref="DeleteComputeEnvResponse"/></returns>
        public Task<DeleteComputeEnvResponse> DeleteComputeEnv(DeleteComputeEnvRequest req)
        {
            return InternalRequestAsync<DeleteComputeEnvResponse>(req, "DeleteComputeEnv");
        }

        /// <summary>
        /// 用于删除计算环境
        /// </summary>
        /// <param name="req"><see cref="DeleteComputeEnvRequest"/></param>
        /// <returns><see cref="DeleteComputeEnvResponse"/></returns>
        public DeleteComputeEnvResponse DeleteComputeEnvSync(DeleteComputeEnvRequest req)
        {
            return InternalRequestAsync<DeleteComputeEnvResponse>(req, "DeleteComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除作业记录。
        /// 删除作业的效果相当于删除作业相关的所有信息。删除成功后，作业相关的所有信息都无法查询。
        /// 待删除的作业必须处于完结状态，且其内部包含的所有任务实例也必须处于完结状态，否则会禁止操作。完结状态，是指处于 SUCCEED 或 FAILED 状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob");
        }

        /// <summary>
        /// 用于删除作业记录。
        /// 删除作业的效果相当于删除作业相关的所有信息。删除成功后，作业相关的所有信息都无法查询。
        /// 待删除的作业必须处于完结状态，且其内部包含的所有任务实例也必须处于完结状态，否则会禁止操作。完结状态，是指处于 SUCCEED 或 FAILED 状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public DeleteJobResponse DeleteJobSync(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除任务模板信息
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskTemplatesRequest"/></param>
        /// <returns><see cref="DeleteTaskTemplatesResponse"/></returns>
        public Task<DeleteTaskTemplatesResponse> DeleteTaskTemplates(DeleteTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteTaskTemplatesResponse>(req, "DeleteTaskTemplates");
        }

        /// <summary>
        /// 用于删除任务模板信息
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskTemplatesRequest"/></param>
        /// <returns><see cref="DeleteTaskTemplatesResponse"/></returns>
        public DeleteTaskTemplatesResponse DeleteTaskTemplatesSync(DeleteTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteTaskTemplatesResponse>(req, "DeleteTaskTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看可用的CVM机型配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public Task<DescribeAvailableCvmInstanceTypesResponse> DescribeAvailableCvmInstanceTypes(DescribeAvailableCvmInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeAvailableCvmInstanceTypesResponse>(req, "DescribeAvailableCvmInstanceTypes");
        }

        /// <summary>
        /// 查看可用的CVM机型配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public DescribeAvailableCvmInstanceTypesResponse DescribeAvailableCvmInstanceTypesSync(DescribeAvailableCvmInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeAvailableCvmInstanceTypesResponse>(req, "DescribeAvailableCvmInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询计算环境的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvResponse"/></returns>
        public Task<DescribeComputeEnvResponse> DescribeComputeEnv(DescribeComputeEnvRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvResponse>(req, "DescribeComputeEnv");
        }

        /// <summary>
        /// 用于查询计算环境的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvResponse"/></returns>
        public DescribeComputeEnvResponse DescribeComputeEnvSync(DescribeComputeEnvRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvResponse>(req, "DescribeComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询计算环境的活动信息
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvActivitiesRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvActivitiesResponse"/></returns>
        public Task<DescribeComputeEnvActivitiesResponse> DescribeComputeEnvActivities(DescribeComputeEnvActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvActivitiesResponse>(req, "DescribeComputeEnvActivities");
        }

        /// <summary>
        /// 用于查询计算环境的活动信息
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvActivitiesRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvActivitiesResponse"/></returns>
        public DescribeComputeEnvActivitiesResponse DescribeComputeEnvActivitiesSync(DescribeComputeEnvActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvActivitiesResponse>(req, "DescribeComputeEnvActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看计算环境的创建信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfoRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfoResponse"/></returns>
        public Task<DescribeComputeEnvCreateInfoResponse> DescribeComputeEnvCreateInfo(DescribeComputeEnvCreateInfoRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfoResponse>(req, "DescribeComputeEnvCreateInfo");
        }

        /// <summary>
        /// 查看计算环境的创建信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfoRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfoResponse"/></returns>
        public DescribeComputeEnvCreateInfoResponse DescribeComputeEnvCreateInfoSync(DescribeComputeEnvCreateInfoRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfoResponse>(req, "DescribeComputeEnvCreateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查看计算环境创建信息列表，包括名称、描述、类型、环境参数、通知及期望节点数等。
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfosRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfosResponse"/></returns>
        public Task<DescribeComputeEnvCreateInfosResponse> DescribeComputeEnvCreateInfos(DescribeComputeEnvCreateInfosRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfosResponse>(req, "DescribeComputeEnvCreateInfos");
        }

        /// <summary>
        /// 用于查看计算环境创建信息列表，包括名称、描述、类型、环境参数、通知及期望节点数等。
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfosRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfosResponse"/></returns>
        public DescribeComputeEnvCreateInfosResponse DescribeComputeEnvCreateInfosSync(DescribeComputeEnvCreateInfosRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfosResponse>(req, "DescribeComputeEnvCreateInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查看计算环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvsRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvsResponse"/></returns>
        public Task<DescribeComputeEnvsResponse> DescribeComputeEnvs(DescribeComputeEnvsRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvsResponse>(req, "DescribeComputeEnvs");
        }

        /// <summary>
        /// 用于查看计算环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvsRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvsResponse"/></returns>
        public DescribeComputeEnvsResponse DescribeComputeEnvsSync(DescribeComputeEnvsRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvsResponse>(req, "DescribeComputeEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石计算环境时，查询批量计算环境支持的黑石操作系统信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCpmOsInfoRequest"/></param>
        /// <returns><see cref="DescribeCpmOsInfoResponse"/></returns>
        public Task<DescribeCpmOsInfoResponse> DescribeCpmOsInfo(DescribeCpmOsInfoRequest req)
        {
            return InternalRequestAsync<DescribeCpmOsInfoResponse>(req, "DescribeCpmOsInfo");
        }

        /// <summary>
        /// 创建黑石计算环境时，查询批量计算环境支持的黑石操作系统信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCpmOsInfoRequest"/></param>
        /// <returns><see cref="DescribeCpmOsInfoResponse"/></returns>
        public DescribeCpmOsInfoResponse DescribeCpmOsInfoSync(DescribeCpmOsInfoRequest req)
        {
            return InternalRequestAsync<DescribeCpmOsInfoResponse>(req, "DescribeCpmOsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取批量计算可用区机型配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public Task<DescribeCvmZoneInstanceConfigInfosResponse> DescribeCvmZoneInstanceConfigInfos(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeCvmZoneInstanceConfigInfosResponse>(req, "DescribeCvmZoneInstanceConfigInfos");
        }

        /// <summary>
        /// 获取批量计算可用区机型配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public DescribeCvmZoneInstanceConfigInfosResponse DescribeCvmZoneInstanceConfigInfosSync(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeCvmZoneInstanceConfigInfosResponse>(req, "DescribeCvmZoneInstanceConfigInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 目前对CVM现有实例族分类，每一类包含若干实例族。该接口用于查询实例分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public Task<DescribeInstanceCategoriesResponse> DescribeInstanceCategories(DescribeInstanceCategoriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCategoriesResponse>(req, "DescribeInstanceCategories");
        }

        /// <summary>
        /// 目前对CVM现有实例族分类，每一类包含若干实例族。该接口用于查询实例分类信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public DescribeInstanceCategoriesResponse DescribeInstanceCategoriesSync(DescribeInstanceCategoriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCategoriesResponse>(req, "DescribeInstanceCategories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查看一个作业的详细信息，包括内部任务（Task）和依赖（Dependence）信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public Task<DescribeJobResponse> DescribeJob(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob");
        }

        /// <summary>
        /// 用于查看一个作业的详细信息，包括内部任务（Task）和依赖（Dependence）信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public DescribeJobResponse DescribeJobSync(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询指定作业的提交信息，其返回内容包括 JobId 和 SubmitJob 接口中作为输入参数的作业提交信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public Task<DescribeJobSubmitInfoResponse> DescribeJobSubmitInfo(DescribeJobSubmitInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmitInfoResponse>(req, "DescribeJobSubmitInfo");
        }

        /// <summary>
        /// 用于查询指定作业的提交信息，其返回内容包括 JobId 和 SubmitJob 接口中作为输入参数的作业提交信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public DescribeJobSubmitInfoResponse DescribeJobSubmitInfoSync(DescribeJobSubmitInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmitInfoResponse>(req, "DescribeJobSubmitInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询若干个作业的概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs");
        }

        /// <summary>
        /// 用于查询若干个作业的概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询指定任务的详细信息，包括任务内部的任务实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask");
        }

        /// <summary>
        /// 用于查询指定任务的详细信息，包括任务内部的任务实例信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取任务多个实例标准输出和标准错误日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskLogsResponse"/></returns>
        public Task<DescribeTaskLogsResponse> DescribeTaskLogs(DescribeTaskLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogsResponse>(req, "DescribeTaskLogs");
        }

        /// <summary>
        /// 用于获取任务多个实例标准输出和标准错误日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskLogsResponse"/></returns>
        public DescribeTaskLogsResponse DescribeTaskLogsSync(DescribeTaskLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogsResponse>(req, "DescribeTaskLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询任务模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTaskTemplatesResponse"/></returns>
        public Task<DescribeTaskTemplatesResponse> DescribeTaskTemplates(DescribeTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTaskTemplatesResponse>(req, "DescribeTaskTemplates");
        }

        /// <summary>
        /// 用于查询任务模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTaskTemplatesResponse"/></returns>
        public DescribeTaskTemplatesResponse DescribeTaskTemplatesSync(DescribeTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTaskTemplatesResponse>(req, "DescribeTaskTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将添加到计算环境中的实例从计算环境中移出。若是由批量计算自动创建的计算节点实例则不允许移出。
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public Task<DetachInstancesResponse> DetachInstances(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances");
        }

        /// <summary>
        /// 将添加到计算环境中的实例从计算环境中移出。若是由批量计算自动创建的计算节点实例则不允许移出。
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public DetachInstancesResponse DetachInstancesSync(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改计算环境属性
        /// </summary>
        /// <param name="req"><see cref="ModifyComputeEnvRequest"/></param>
        /// <returns><see cref="ModifyComputeEnvResponse"/></returns>
        public Task<ModifyComputeEnvResponse> ModifyComputeEnv(ModifyComputeEnvRequest req)
        {
            return InternalRequestAsync<ModifyComputeEnvResponse>(req, "ModifyComputeEnv");
        }

        /// <summary>
        /// 用于修改计算环境属性
        /// </summary>
        /// <param name="req"><see cref="ModifyComputeEnvRequest"/></param>
        /// <returns><see cref="ModifyComputeEnvResponse"/></returns>
        public ModifyComputeEnvResponse ModifyComputeEnvSync(ModifyComputeEnvRequest req)
        {
            return InternalRequestAsync<ModifyComputeEnvResponse>(req, "ModifyComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改任务模板
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskTemplateRequest"/></param>
        /// <returns><see cref="ModifyTaskTemplateResponse"/></returns>
        public Task<ModifyTaskTemplateResponse> ModifyTaskTemplate(ModifyTaskTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTaskTemplateResponse>(req, "ModifyTaskTemplate");
        }

        /// <summary>
        /// 用于修改任务模板
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskTemplateRequest"/></param>
        /// <returns><see cref="ModifyTaskTemplateResponse"/></returns>
        public ModifyTaskTemplateResponse ModifyTaskTemplateSync(ModifyTaskTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTaskTemplateResponse>(req, "ModifyTaskTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于重试作业中失败的任务实例。
        /// 当且仅当作业处于“FAILED”状态，支持重试操作。重试操作成功后，作业会按照“DAG”中指定的任务依赖关系，依次重试各个任务中失败的任务实例。任务实例的历史信息将被重置，如同首次运行一样，参与后续的调度和执行。
        /// </summary>
        /// <param name="req"><see cref="RetryJobsRequest"/></param>
        /// <returns><see cref="RetryJobsResponse"/></returns>
        public Task<RetryJobsResponse> RetryJobs(RetryJobsRequest req)
        {
            return InternalRequestAsync<RetryJobsResponse>(req, "RetryJobs");
        }

        /// <summary>
        /// 用于重试作业中失败的任务实例。
        /// 当且仅当作业处于“FAILED”状态，支持重试操作。重试操作成功后，作业会按照“DAG”中指定的任务依赖关系，依次重试各个任务中失败的任务实例。任务实例的历史信息将被重置，如同首次运行一样，参与后续的调度和执行。
        /// </summary>
        /// <param name="req"><see cref="RetryJobsRequest"/></param>
        /// <returns><see cref="RetryJobsResponse"/></returns>
        public RetryJobsResponse RetryJobsSync(RetryJobsRequest req)
        {
            return InternalRequestAsync<RetryJobsResponse>(req, "RetryJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于提交一个作业
        /// </summary>
        /// <param name="req"><see cref="SubmitJobRequest"/></param>
        /// <returns><see cref="SubmitJobResponse"/></returns>
        public Task<SubmitJobResponse> SubmitJob(SubmitJobRequest req)
        {
            return InternalRequestAsync<SubmitJobResponse>(req, "SubmitJob");
        }

        /// <summary>
        /// 用于提交一个作业
        /// </summary>
        /// <param name="req"><see cref="SubmitJobRequest"/></param>
        /// <returns><see cref="SubmitJobResponse"/></returns>
        public SubmitJobResponse SubmitJobSync(SubmitJobRequest req)
        {
            return InternalRequestAsync<SubmitJobResponse>(req, "SubmitJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于销毁计算节点。
        /// 对于状态为CREATED、CREATION_FAILED、RUNNING和ABNORMAL的节点，允许销毁处理。
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodeRequest"/></param>
        /// <returns><see cref="TerminateComputeNodeResponse"/></returns>
        public Task<TerminateComputeNodeResponse> TerminateComputeNode(TerminateComputeNodeRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodeResponse>(req, "TerminateComputeNode");
        }

        /// <summary>
        /// 用于销毁计算节点。
        /// 对于状态为CREATED、CREATION_FAILED、RUNNING和ABNORMAL的节点，允许销毁处理。
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodeRequest"/></param>
        /// <returns><see cref="TerminateComputeNodeResponse"/></returns>
        public TerminateComputeNodeResponse TerminateComputeNodeSync(TerminateComputeNodeRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodeResponse>(req, "TerminateComputeNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量销毁计算节点，不允许重复销毁同一个节点。
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodesRequest"/></param>
        /// <returns><see cref="TerminateComputeNodesResponse"/></returns>
        public Task<TerminateComputeNodesResponse> TerminateComputeNodes(TerminateComputeNodesRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodesResponse>(req, "TerminateComputeNodes");
        }

        /// <summary>
        /// 用于批量销毁计算节点，不允许重复销毁同一个节点。
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodesRequest"/></param>
        /// <returns><see cref="TerminateComputeNodesResponse"/></returns>
        public TerminateComputeNodesResponse TerminateComputeNodesSync(TerminateComputeNodesRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodesResponse>(req, "TerminateComputeNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于终止作业。
        /// 当作业处于“SUBMITTED”状态时，禁止终止操作；当作业处于“SUCCEED”状态时，终止操作不会生效。
        /// 终止作业是一个异步过程。整个终止过程的耗时和任务总数成正比。终止的效果相当于所含的所有任务实例进行TerminateTaskInstance操作。具体效果和用法可参考TerminateTaskInstance。
        /// </summary>
        /// <param name="req"><see cref="TerminateJobRequest"/></param>
        /// <returns><see cref="TerminateJobResponse"/></returns>
        public Task<TerminateJobResponse> TerminateJob(TerminateJobRequest req)
        {
            return InternalRequestAsync<TerminateJobResponse>(req, "TerminateJob");
        }

        /// <summary>
        /// 用于终止作业。
        /// 当作业处于“SUBMITTED”状态时，禁止终止操作；当作业处于“SUCCEED”状态时，终止操作不会生效。
        /// 终止作业是一个异步过程。整个终止过程的耗时和任务总数成正比。终止的效果相当于所含的所有任务实例进行TerminateTaskInstance操作。具体效果和用法可参考TerminateTaskInstance。
        /// </summary>
        /// <param name="req"><see cref="TerminateJobRequest"/></param>
        /// <returns><see cref="TerminateJobResponse"/></returns>
        public TerminateJobResponse TerminateJobSync(TerminateJobRequest req)
        {
            return InternalRequestAsync<TerminateJobResponse>(req, "TerminateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于终止任务实例。
        /// 对于状态已经为“SUCCEED”和“FAILED”的任务实例，不做处理。
        /// 对于状态为“SUBMITTED”、“PENDING”、“RUNNABLE”的任务实例，状态将置为“FAILED”状态。
        /// 对于状态为“STARTING”、“RUNNING”、“FAILED_INTERRUPTED”的任务实例，分区两种情况：如果未显示指定计算环境，会先销毁CVM服务器，然后将状态置为“FAILED”，具有一定耗时；如果指定了计算环境EnvId，任务实例状态置为“FAILED”，并重启执行该任务的CVM服务器，具有一定的耗时。
        /// 对于状态为“FAILED_INTERRUPTED”的任务实例，终止操作实际成功之后，相关资源和配额才会释放。
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskInstanceRequest"/></param>
        /// <returns><see cref="TerminateTaskInstanceResponse"/></returns>
        public Task<TerminateTaskInstanceResponse> TerminateTaskInstance(TerminateTaskInstanceRequest req)
        {
            return InternalRequestAsync<TerminateTaskInstanceResponse>(req, "TerminateTaskInstance");
        }

        /// <summary>
        /// 用于终止任务实例。
        /// 对于状态已经为“SUCCEED”和“FAILED”的任务实例，不做处理。
        /// 对于状态为“SUBMITTED”、“PENDING”、“RUNNABLE”的任务实例，状态将置为“FAILED”状态。
        /// 对于状态为“STARTING”、“RUNNING”、“FAILED_INTERRUPTED”的任务实例，分区两种情况：如果未显示指定计算环境，会先销毁CVM服务器，然后将状态置为“FAILED”，具有一定耗时；如果指定了计算环境EnvId，任务实例状态置为“FAILED”，并重启执行该任务的CVM服务器，具有一定的耗时。
        /// 对于状态为“FAILED_INTERRUPTED”的任务实例，终止操作实际成功之后，相关资源和配额才会释放。
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskInstanceRequest"/></param>
        /// <returns><see cref="TerminateTaskInstanceResponse"/></returns>
        public TerminateTaskInstanceResponse TerminateTaskInstanceSync(TerminateTaskInstanceRequest req)
        {
            return InternalRequestAsync<TerminateTaskInstanceResponse>(req, "TerminateTaskInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
