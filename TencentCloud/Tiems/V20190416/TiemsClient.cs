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

namespace TencentCloud.Tiems.V20190416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tiems.V20190416.Models;

   public class TiemsClient : AbstractClient{

       private const string endpoint = "tiems.tencentcloudapi.com";
       private const string version = "2019-04-16";
       private const string sdkVersion = "SDK_NET_3.0.1001";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiemsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TiemsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public Task<CreateJobResponse> CreateJob(CreateJobRequest req)
        {
            return InternalRequestAsync<CreateJobResponse>(req, "CreateJob");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public CreateJobResponse CreateJobSync(CreateJobRequest req)
        {
            return InternalRequestAsync<CreateJobResponse>(req, "CreateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建资源组的伸缩组。当前一个资源组仅允许创建一个伸缩组。
        /// </summary>
        /// <param name="req"><see cref="CreateRsgAsGroupRequest"/></param>
        /// <returns><see cref="CreateRsgAsGroupResponse"/></returns>
        public Task<CreateRsgAsGroupResponse> CreateRsgAsGroup(CreateRsgAsGroupRequest req)
        {
            return InternalRequestAsync<CreateRsgAsGroupResponse>(req, "CreateRsgAsGroup");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建资源组的伸缩组。当前一个资源组仅允许创建一个伸缩组。
        /// </summary>
        /// <param name="req"><see cref="CreateRsgAsGroupRequest"/></param>
        /// <returns><see cref="CreateRsgAsGroupResponse"/></returns>
        public CreateRsgAsGroupResponse CreateRsgAsGroupSync(CreateRsgAsGroupRequest req)
        {
            return InternalRequestAsync<CreateRsgAsGroupResponse>(req, "CreateRsgAsGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建运行环境
        /// </summary>
        /// <param name="req"><see cref="CreateRuntimeRequest"/></param>
        /// <returns><see cref="CreateRuntimeResponse"/></returns>
        public Task<CreateRuntimeResponse> CreateRuntime(CreateRuntimeRequest req)
        {
            return InternalRequestAsync<CreateRuntimeResponse>(req, "CreateRuntime");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建运行环境
        /// </summary>
        /// <param name="req"><see cref="CreateRuntimeRequest"/></param>
        /// <returns><see cref="CreateRuntimeResponse"/></returns>
        public CreateRuntimeResponse CreateRuntimeSync(CreateRuntimeRequest req)
        {
            return InternalRequestAsync<CreateRuntimeResponse>(req, "CreateRuntime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建服务
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public Task<CreateServiceResponse> CreateService(CreateServiceRequest req)
        {
            return InternalRequestAsync<CreateServiceResponse>(req, "CreateService");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建服务
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public CreateServiceResponse CreateServiceSync(CreateServiceRequest req)
        {
            return InternalRequestAsync<CreateServiceResponse>(req, "CreateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建服务配置
        /// </summary>
        /// <param name="req"><see cref="CreateServiceConfigRequest"/></param>
        /// <returns><see cref="CreateServiceConfigResponse"/></returns>
        public Task<CreateServiceConfigResponse> CreateServiceConfig(CreateServiceConfigRequest req)
        {
            return InternalRequestAsync<CreateServiceConfigResponse>(req, "CreateServiceConfig");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 创建服务配置
        /// </summary>
        /// <param name="req"><see cref="CreateServiceConfigRequest"/></param>
        /// <returns><see cref="CreateServiceConfigResponse"/></returns>
        public CreateServiceConfigResponse CreateServiceConfigSync(CreateServiceConfigRequest req)
        {
            return InternalRequestAsync<CreateServiceConfigResponse>(req, "CreateServiceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除资源组中的节点。目前仅支持删除已经到期的预付费节点，和按量付费节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除资源组中的节点。目前仅支持删除已经到期的预付费节点，和按量付费节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public DeleteJobResponse DeleteJobSync(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除资源组
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public Task<DeleteResourceGroupResponse> DeleteResourceGroup(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除资源组
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public DeleteResourceGroupResponse DeleteResourceGroupSync(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 伸缩
        /// </summary>
        /// <param name="req"><see cref="DeleteRsgAsGroupRequest"/></param>
        /// <returns><see cref="DeleteRsgAsGroupResponse"/></returns>
        public Task<DeleteRsgAsGroupResponse> DeleteRsgAsGroup(DeleteRsgAsGroupRequest req)
        {
            return InternalRequestAsync<DeleteRsgAsGroupResponse>(req, "DeleteRsgAsGroup");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 伸缩
        /// </summary>
        /// <param name="req"><see cref="DeleteRsgAsGroupRequest"/></param>
        /// <returns><see cref="DeleteRsgAsGroupResponse"/></returns>
        public DeleteRsgAsGroupResponse DeleteRsgAsGroupSync(DeleteRsgAsGroupRequest req)
        {
            return InternalRequestAsync<DeleteRsgAsGroupResponse>(req, "DeleteRsgAsGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除运行环境
        /// </summary>
        /// <param name="req"><see cref="DeleteRuntimeRequest"/></param>
        /// <returns><see cref="DeleteRuntimeResponse"/></returns>
        public Task<DeleteRuntimeResponse> DeleteRuntime(DeleteRuntimeRequest req)
        {
            return InternalRequestAsync<DeleteRuntimeResponse>(req, "DeleteRuntime");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除运行环境
        /// </summary>
        /// <param name="req"><see cref="DeleteRuntimeRequest"/></param>
        /// <returns><see cref="DeleteRuntimeResponse"/></returns>
        public DeleteRuntimeResponse DeleteRuntimeSync(DeleteRuntimeRequest req)
        {
            return InternalRequestAsync<DeleteRuntimeResponse>(req, "DeleteRuntime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除服务
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public Task<DeleteServiceResponse> DeleteService(DeleteServiceRequest req)
        {
            return InternalRequestAsync<DeleteServiceResponse>(req, "DeleteService");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除服务
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public DeleteServiceResponse DeleteServiceSync(DeleteServiceRequest req)
        {
            return InternalRequestAsync<DeleteServiceResponse>(req, "DeleteService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除服务配置
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceConfigRequest"/></param>
        /// <returns><see cref="DeleteServiceConfigResponse"/></returns>
        public Task<DeleteServiceConfigResponse> DeleteServiceConfig(DeleteServiceConfigRequest req)
        {
            return InternalRequestAsync<DeleteServiceConfigResponse>(req, "DeleteServiceConfig");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 删除服务配置
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceConfigRequest"/></param>
        /// <returns><see cref="DeleteServiceConfigResponse"/></returns>
        public DeleteServiceConfigResponse DeleteServiceConfigSync(DeleteServiceConfigRequest req)
        {
            return InternalRequestAsync<DeleteServiceConfigResponse>(req, "DeleteServiceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 获取资源组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupsResponse"/></returns>
        public Task<DescribeResourceGroupsResponse> DescribeResourceGroups(DescribeResourceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupsResponse>(req, "DescribeResourceGroups");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 获取资源组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupsResponse"/></returns>
        public DescribeResourceGroupsResponse DescribeResourceGroupsSync(DescribeResourceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupsResponse>(req, "DescribeResourceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 查询伸缩组活动
        /// </summary>
        /// <param name="req"><see cref="DescribeRsgAsGroupActivitiesRequest"/></param>
        /// <returns><see cref="DescribeRsgAsGroupActivitiesResponse"/></returns>
        public Task<DescribeRsgAsGroupActivitiesResponse> DescribeRsgAsGroupActivities(DescribeRsgAsGroupActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeRsgAsGroupActivitiesResponse>(req, "DescribeRsgAsGroupActivities");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 查询伸缩组活动
        /// </summary>
        /// <param name="req"><see cref="DescribeRsgAsGroupActivitiesRequest"/></param>
        /// <returns><see cref="DescribeRsgAsGroupActivitiesResponse"/></returns>
        public DescribeRsgAsGroupActivitiesResponse DescribeRsgAsGroupActivitiesSync(DescribeRsgAsGroupActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeRsgAsGroupActivitiesResponse>(req, "DescribeRsgAsGroupActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 查询资源组的伸缩组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRsgAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeRsgAsGroupsResponse"/></returns>
        public Task<DescribeRsgAsGroupsResponse> DescribeRsgAsGroups(DescribeRsgAsGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRsgAsGroupsResponse>(req, "DescribeRsgAsGroups");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 查询资源组的伸缩组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRsgAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeRsgAsGroupsResponse"/></returns>
        public DescribeRsgAsGroupsResponse DescribeRsgAsGroupsSync(DescribeRsgAsGroupsRequest req)
        {
            return InternalRequestAsync<DescribeRsgAsGroupsResponse>(req, "DescribeRsgAsGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 描述服务运行环境
        /// </summary>
        /// <param name="req"><see cref="DescribeRuntimesRequest"/></param>
        /// <returns><see cref="DescribeRuntimesResponse"/></returns>
        public Task<DescribeRuntimesResponse> DescribeRuntimes(DescribeRuntimesRequest req)
        {
            return InternalRequestAsync<DescribeRuntimesResponse>(req, "DescribeRuntimes");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 描述服务运行环境
        /// </summary>
        /// <param name="req"><see cref="DescribeRuntimesRequest"/></param>
        /// <returns><see cref="DescribeRuntimesResponse"/></returns>
        public DescribeRuntimesResponse DescribeRuntimesSync(DescribeRuntimesRequest req)
        {
            return InternalRequestAsync<DescribeRuntimesResponse>(req, "DescribeRuntimes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 描述服务配置
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceConfigsRequest"/></param>
        /// <returns><see cref="DescribeServiceConfigsResponse"/></returns>
        public Task<DescribeServiceConfigsResponse> DescribeServiceConfigs(DescribeServiceConfigsRequest req)
        {
            return InternalRequestAsync<DescribeServiceConfigsResponse>(req, "DescribeServiceConfigs");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 描述服务配置
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceConfigsRequest"/></param>
        /// <returns><see cref="DescribeServiceConfigsResponse"/></returns>
        public DescribeServiceConfigsResponse DescribeServiceConfigsSync(DescribeServiceConfigsRequest req)
        {
            return InternalRequestAsync<DescribeServiceConfigsResponse>(req, "DescribeServiceConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 描述服务
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesRequest"/></param>
        /// <returns><see cref="DescribeServicesResponse"/></returns>
        public Task<DescribeServicesResponse> DescribeServices(DescribeServicesRequest req)
        {
            return InternalRequestAsync<DescribeServicesResponse>(req, "DescribeServices");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 描述服务
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesRequest"/></param>
        /// <returns><see cref="DescribeServicesResponse"/></returns>
        public DescribeServicesResponse DescribeServicesSync(DescribeServicesRequest req)
        {
            return InternalRequestAsync<DescribeServicesResponse>(req, "DescribeServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 停用资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="DisableRsgAsGroupRequest"/></param>
        /// <returns><see cref="DisableRsgAsGroupResponse"/></returns>
        public Task<DisableRsgAsGroupResponse> DisableRsgAsGroup(DisableRsgAsGroupRequest req)
        {
            return InternalRequestAsync<DisableRsgAsGroupResponse>(req, "DisableRsgAsGroup");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 停用资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="DisableRsgAsGroupRequest"/></param>
        /// <returns><see cref="DisableRsgAsGroupResponse"/></returns>
        public DisableRsgAsGroupResponse DisableRsgAsGroupSync(DisableRsgAsGroupRequest req)
        {
            return InternalRequestAsync<DisableRsgAsGroupResponse>(req, "DisableRsgAsGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 启用资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="EnableRsgAsGroupRequest"/></param>
        /// <returns><see cref="EnableRsgAsGroupResponse"/></returns>
        public Task<EnableRsgAsGroupResponse> EnableRsgAsGroup(EnableRsgAsGroupRequest req)
        {
            return InternalRequestAsync<EnableRsgAsGroupResponse>(req, "EnableRsgAsGroup");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 启用资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="EnableRsgAsGroupRequest"/></param>
        /// <returns><see cref="EnableRsgAsGroupResponse"/></returns>
        public EnableRsgAsGroupResponse EnableRsgAsGroupSync(EnableRsgAsGroupRequest req)
        {
            return InternalRequestAsync<EnableRsgAsGroupResponse>(req, "EnableRsgAsGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 暴露服务
        /// </summary>
        /// <param name="req"><see cref="ExposeServiceRequest"/></param>
        /// <returns><see cref="ExposeServiceResponse"/></returns>
        public Task<ExposeServiceResponse> ExposeService(ExposeServiceRequest req)
        {
            return InternalRequestAsync<ExposeServiceResponse>(req, "ExposeService");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 暴露服务
        /// </summary>
        /// <param name="req"><see cref="ExposeServiceRequest"/></param>
        /// <returns><see cref="ExposeServiceResponse"/></returns>
        public ExposeServiceResponse ExposeServiceSync(ExposeServiceRequest req)
        {
            return InternalRequestAsync<ExposeServiceResponse>(req, "ExposeService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateJobRequest"/></param>
        /// <returns><see cref="UpdateJobResponse"/></returns>
        public Task<UpdateJobResponse> UpdateJob(UpdateJobRequest req)
        {
            return InternalRequestAsync<UpdateJobResponse>(req, "UpdateJob");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateJobRequest"/></param>
        /// <returns><see cref="UpdateJobResponse"/></returns>
        public UpdateJobResponse UpdateJobSync(UpdateJobRequest req)
        {
            return InternalRequestAsync<UpdateJobResponse>(req, "UpdateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 更新资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="UpdateRsgAsGroupRequest"/></param>
        /// <returns><see cref="UpdateRsgAsGroupResponse"/></returns>
        public Task<UpdateRsgAsGroupResponse> UpdateRsgAsGroup(UpdateRsgAsGroupRequest req)
        {
            return InternalRequestAsync<UpdateRsgAsGroupResponse>(req, "UpdateRsgAsGroup");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 更新资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="UpdateRsgAsGroupRequest"/></param>
        /// <returns><see cref="UpdateRsgAsGroupResponse"/></returns>
        public UpdateRsgAsGroupResponse UpdateRsgAsGroupSync(UpdateRsgAsGroupRequest req)
        {
            return InternalRequestAsync<UpdateRsgAsGroupResponse>(req, "UpdateRsgAsGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 更新服务
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public Task<UpdateServiceResponse> UpdateService(UpdateServiceRequest req)
        {
            return InternalRequestAsync<UpdateServiceResponse>(req, "UpdateService");
        }

        /// <summary>
        /// 因业务策略调整，腾讯云TI平台TI-EMS已经于2022年6月30日下线并停止提供服务。若您有新增的业务需求，可前往TI-ONE(https://cloud.tencent.com/document/product/851)使用。
        /// 
        /// 更新服务
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public UpdateServiceResponse UpdateServiceSync(UpdateServiceRequest req)
        {
            return InternalRequestAsync<UpdateServiceResponse>(req, "UpdateService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
