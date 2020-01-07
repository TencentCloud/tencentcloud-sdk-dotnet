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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TiemsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req"><see cref="CreateJobRequest"/></param>
        /// <returns><see cref="CreateJobResponse"/></returns>
        public async Task<CreateJobResponse> CreateJob(CreateJobRequest req)
        {
             JsonResponseModel<CreateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateJob接口的同步版本，创建任务
        /// </summary>
        /// <param name="req">参考<see cref="CreateJobRequest"/></param>
        /// <returns>参考<see cref="CreateJobResponse"/>实例</returns>
        public CreateJobResponse CreateJobSync(CreateJobRequest req)
        {
             JsonResponseModel<CreateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资源组的伸缩组。当前一个资源组仅允许创建一个伸缩组。
        /// </summary>
        /// <param name="req"><see cref="CreateRsgAsGroupRequest"/></param>
        /// <returns><see cref="CreateRsgAsGroupResponse"/></returns>
        public async Task<CreateRsgAsGroupResponse> CreateRsgAsGroup(CreateRsgAsGroupRequest req)
        {
             JsonResponseModel<CreateRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateRsgAsGroup接口的同步版本，创建资源组的伸缩组。当前一个资源组仅允许创建一个伸缩组。
        /// </summary>
        /// <param name="req">参考<see cref="CreateRsgAsGroupRequest"/></param>
        /// <returns>参考<see cref="CreateRsgAsGroupResponse"/>实例</returns>
        public CreateRsgAsGroupResponse CreateRsgAsGroupSync(CreateRsgAsGroupRequest req)
        {
             JsonResponseModel<CreateRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建运行环境
        /// </summary>
        /// <param name="req"><see cref="CreateRuntimeRequest"/></param>
        /// <returns><see cref="CreateRuntimeResponse"/></returns>
        public async Task<CreateRuntimeResponse> CreateRuntime(CreateRuntimeRequest req)
        {
             JsonResponseModel<CreateRuntimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRuntime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuntimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateRuntime接口的同步版本，创建运行环境
        /// </summary>
        /// <param name="req">参考<see cref="CreateRuntimeRequest"/></param>
        /// <returns>参考<see cref="CreateRuntimeResponse"/>实例</returns>
        public CreateRuntimeResponse CreateRuntimeSync(CreateRuntimeRequest req)
        {
             JsonResponseModel<CreateRuntimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRuntime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuntimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务
        /// </summary>
        /// <param name="req"><see cref="CreateServiceRequest"/></param>
        /// <returns><see cref="CreateServiceResponse"/></returns>
        public async Task<CreateServiceResponse> CreateService(CreateServiceRequest req)
        {
             JsonResponseModel<CreateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateService接口的同步版本，创建服务
        /// </summary>
        /// <param name="req">参考<see cref="CreateServiceRequest"/></param>
        /// <returns>参考<see cref="CreateServiceResponse"/>实例</returns>
        public CreateServiceResponse CreateServiceSync(CreateServiceRequest req)
        {
             JsonResponseModel<CreateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务配置
        /// </summary>
        /// <param name="req"><see cref="CreateServiceConfigRequest"/></param>
        /// <returns><see cref="CreateServiceConfigResponse"/></returns>
        public async Task<CreateServiceConfigResponse> CreateServiceConfig(CreateServiceConfigRequest req)
        {
             JsonResponseModel<CreateServiceConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateServiceConfig接口的同步版本，创建服务配置
        /// </summary>
        /// <param name="req">参考<see cref="CreateServiceConfigRequest"/></param>
        /// <returns>参考<see cref="CreateServiceConfigResponse"/>实例</returns>
        public CreateServiceConfigResponse CreateServiceConfigSync(CreateServiceConfigRequest req)
        {
             JsonResponseModel<CreateServiceConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资源组中的节点。目前仅支持删除已经到期的预付费节点，和按量付费节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteInstance接口的同步版本，删除资源组中的节点。目前仅支持删除已经到期的预付费节点，和按量付费节点。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteInstanceRequest"/></param>
        /// <returns>参考<see cref="DeleteInstanceResponse"/>实例</returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public async Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
             JsonResponseModel<DeleteJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteJob接口的同步版本，删除任务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteJobRequest"/></param>
        /// <returns>参考<see cref="DeleteJobResponse"/>实例</returns>
        public DeleteJobResponse DeleteJobSync(DeleteJobRequest req)
        {
             JsonResponseModel<DeleteJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资源组
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroup(DeleteResourceGroupRequest req)
        {
             JsonResponseModel<DeleteResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteResourceGroup接口的同步版本，删除资源组
        /// </summary>
        /// <param name="req">参考<see cref="DeleteResourceGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteResourceGroupResponse"/>实例</returns>
        public DeleteResourceGroupResponse DeleteResourceGroupSync(DeleteResourceGroupRequest req)
        {
             JsonResponseModel<DeleteResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 伸缩
        /// </summary>
        /// <param name="req"><see cref="DeleteRsgAsGroupRequest"/></param>
        /// <returns><see cref="DeleteRsgAsGroupResponse"/></returns>
        public async Task<DeleteRsgAsGroupResponse> DeleteRsgAsGroup(DeleteRsgAsGroupRequest req)
        {
             JsonResponseModel<DeleteRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteRsgAsGroup接口的同步版本，伸缩
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRsgAsGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteRsgAsGroupResponse"/>实例</returns>
        public DeleteRsgAsGroupResponse DeleteRsgAsGroupSync(DeleteRsgAsGroupRequest req)
        {
             JsonResponseModel<DeleteRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行环境
        /// </summary>
        /// <param name="req"><see cref="DeleteRuntimeRequest"/></param>
        /// <returns><see cref="DeleteRuntimeResponse"/></returns>
        public async Task<DeleteRuntimeResponse> DeleteRuntime(DeleteRuntimeRequest req)
        {
             JsonResponseModel<DeleteRuntimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRuntime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuntimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteRuntime接口的同步版本，删除运行环境
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRuntimeRequest"/></param>
        /// <returns>参考<see cref="DeleteRuntimeResponse"/>实例</returns>
        public DeleteRuntimeResponse DeleteRuntimeSync(DeleteRuntimeRequest req)
        {
             JsonResponseModel<DeleteRuntimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRuntime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuntimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceRequest"/></param>
        /// <returns><see cref="DeleteServiceResponse"/></returns>
        public async Task<DeleteServiceResponse> DeleteService(DeleteServiceRequest req)
        {
             JsonResponseModel<DeleteServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteService接口的同步版本，删除服务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteServiceRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceResponse"/>实例</returns>
        public DeleteServiceResponse DeleteServiceSync(DeleteServiceRequest req)
        {
             JsonResponseModel<DeleteServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务配置
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceConfigRequest"/></param>
        /// <returns><see cref="DeleteServiceConfigResponse"/></returns>
        public async Task<DeleteServiceConfigResponse> DeleteServiceConfig(DeleteServiceConfigRequest req)
        {
             JsonResponseModel<DeleteServiceConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteServiceConfig接口的同步版本，删除服务配置
        /// </summary>
        /// <param name="req">参考<see cref="DeleteServiceConfigRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceConfigResponse"/>实例</returns>
        public DeleteServiceConfigResponse DeleteServiceConfigSync(DeleteServiceConfigRequest req)
        {
             JsonResponseModel<DeleteServiceConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstances接口的同步版本，获取节点列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesResponse"/>实例</returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupsResponse"/></returns>
        public async Task<DescribeResourceGroupsResponse> DescribeResourceGroups(DescribeResourceGroupsRequest req)
        {
             JsonResponseModel<DescribeResourceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeResourceGroups接口的同步版本，获取资源组列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeResourceGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeResourceGroupsResponse"/>实例</returns>
        public DescribeResourceGroupsResponse DescribeResourceGroupsSync(DescribeResourceGroupsRequest req)
        {
             JsonResponseModel<DescribeResourceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询伸缩组活动
        /// </summary>
        /// <param name="req"><see cref="DescribeRsgAsGroupActivitiesRequest"/></param>
        /// <returns><see cref="DescribeRsgAsGroupActivitiesResponse"/></returns>
        public async Task<DescribeRsgAsGroupActivitiesResponse> DescribeRsgAsGroupActivities(DescribeRsgAsGroupActivitiesRequest req)
        {
             JsonResponseModel<DescribeRsgAsGroupActivitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRsgAsGroupActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRsgAsGroupActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRsgAsGroupActivities接口的同步版本，查询伸缩组活动
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRsgAsGroupActivitiesRequest"/></param>
        /// <returns>参考<see cref="DescribeRsgAsGroupActivitiesResponse"/>实例</returns>
        public DescribeRsgAsGroupActivitiesResponse DescribeRsgAsGroupActivitiesSync(DescribeRsgAsGroupActivitiesRequest req)
        {
             JsonResponseModel<DescribeRsgAsGroupActivitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRsgAsGroupActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRsgAsGroupActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源组的伸缩组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRsgAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeRsgAsGroupsResponse"/></returns>
        public async Task<DescribeRsgAsGroupsResponse> DescribeRsgAsGroups(DescribeRsgAsGroupsRequest req)
        {
             JsonResponseModel<DescribeRsgAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRsgAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRsgAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRsgAsGroups接口的同步版本，查询资源组的伸缩组信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRsgAsGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeRsgAsGroupsResponse"/>实例</returns>
        public DescribeRsgAsGroupsResponse DescribeRsgAsGroupsSync(DescribeRsgAsGroupsRequest req)
        {
             JsonResponseModel<DescribeRsgAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRsgAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRsgAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述服务运行环境
        /// </summary>
        /// <param name="req"><see cref="DescribeRuntimesRequest"/></param>
        /// <returns><see cref="DescribeRuntimesResponse"/></returns>
        public async Task<DescribeRuntimesResponse> DescribeRuntimes(DescribeRuntimesRequest req)
        {
             JsonResponseModel<DescribeRuntimesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuntimes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuntimesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRuntimes接口的同步版本，描述服务运行环境
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRuntimesRequest"/></param>
        /// <returns>参考<see cref="DescribeRuntimesResponse"/>实例</returns>
        public DescribeRuntimesResponse DescribeRuntimesSync(DescribeRuntimesRequest req)
        {
             JsonResponseModel<DescribeRuntimesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuntimes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuntimesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述服务配置
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceConfigsRequest"/></param>
        /// <returns><see cref="DescribeServiceConfigsResponse"/></returns>
        public async Task<DescribeServiceConfigsResponse> DescribeServiceConfigs(DescribeServiceConfigsRequest req)
        {
             JsonResponseModel<DescribeServiceConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeServiceConfigs接口的同步版本，描述服务配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServiceConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeServiceConfigsResponse"/>实例</returns>
        public DescribeServiceConfigsResponse DescribeServiceConfigsSync(DescribeServiceConfigsRequest req)
        {
             JsonResponseModel<DescribeServiceConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述服务
        /// </summary>
        /// <param name="req"><see cref="DescribeServicesRequest"/></param>
        /// <returns><see cref="DescribeServicesResponse"/></returns>
        public async Task<DescribeServicesResponse> DescribeServices(DescribeServicesRequest req)
        {
             JsonResponseModel<DescribeServicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeServices接口的同步版本，描述服务
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServicesRequest"/></param>
        /// <returns>参考<see cref="DescribeServicesResponse"/>实例</returns>
        public DescribeServicesResponse DescribeServicesSync(DescribeServicesRequest req)
        {
             JsonResponseModel<DescribeServicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="DisableRsgAsGroupRequest"/></param>
        /// <returns><see cref="DisableRsgAsGroupResponse"/></returns>
        public async Task<DisableRsgAsGroupResponse> DisableRsgAsGroup(DisableRsgAsGroupRequest req)
        {
             JsonResponseModel<DisableRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableRsgAsGroup接口的同步版本，停用资源组的伸缩组
        /// </summary>
        /// <param name="req">参考<see cref="DisableRsgAsGroupRequest"/></param>
        /// <returns>参考<see cref="DisableRsgAsGroupResponse"/>实例</returns>
        public DisableRsgAsGroupResponse DisableRsgAsGroupSync(DisableRsgAsGroupRequest req)
        {
             JsonResponseModel<DisableRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="EnableRsgAsGroupRequest"/></param>
        /// <returns><see cref="EnableRsgAsGroupResponse"/></returns>
        public async Task<EnableRsgAsGroupResponse> EnableRsgAsGroup(EnableRsgAsGroupRequest req)
        {
             JsonResponseModel<EnableRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableRsgAsGroup接口的同步版本，启用资源组的伸缩组
        /// </summary>
        /// <param name="req">参考<see cref="EnableRsgAsGroupRequest"/></param>
        /// <returns>参考<see cref="EnableRsgAsGroupResponse"/>实例</returns>
        public EnableRsgAsGroupResponse EnableRsgAsGroupSync(EnableRsgAsGroupRequest req)
        {
             JsonResponseModel<EnableRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 暴露服务
        /// </summary>
        /// <param name="req"><see cref="ExposeServiceRequest"/></param>
        /// <returns><see cref="ExposeServiceResponse"/></returns>
        public async Task<ExposeServiceResponse> ExposeService(ExposeServiceRequest req)
        {
             JsonResponseModel<ExposeServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExposeService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExposeServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ExposeService接口的同步版本，暴露服务
        /// </summary>
        /// <param name="req">参考<see cref="ExposeServiceRequest"/></param>
        /// <returns>参考<see cref="ExposeServiceResponse"/>实例</returns>
        public ExposeServiceResponse ExposeServiceSync(ExposeServiceRequest req)
        {
             JsonResponseModel<ExposeServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExposeService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExposeServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateJobRequest"/></param>
        /// <returns><see cref="UpdateJobResponse"/></returns>
        public async Task<UpdateJobResponse> UpdateJob(UpdateJobRequest req)
        {
             JsonResponseModel<UpdateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateJob接口的同步版本，更新任务
        /// </summary>
        /// <param name="req">参考<see cref="UpdateJobRequest"/></param>
        /// <returns>参考<see cref="UpdateJobResponse"/>实例</returns>
        public UpdateJobResponse UpdateJobSync(UpdateJobRequest req)
        {
             JsonResponseModel<UpdateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新资源组的伸缩组
        /// </summary>
        /// <param name="req"><see cref="UpdateRsgAsGroupRequest"/></param>
        /// <returns><see cref="UpdateRsgAsGroupResponse"/></returns>
        public async Task<UpdateRsgAsGroupResponse> UpdateRsgAsGroup(UpdateRsgAsGroupRequest req)
        {
             JsonResponseModel<UpdateRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateRsgAsGroup接口的同步版本，更新资源组的伸缩组
        /// </summary>
        /// <param name="req">参考<see cref="UpdateRsgAsGroupRequest"/></param>
        /// <returns>参考<see cref="UpdateRsgAsGroupResponse"/>实例</returns>
        public UpdateRsgAsGroupResponse UpdateRsgAsGroupSync(UpdateRsgAsGroupRequest req)
        {
             JsonResponseModel<UpdateRsgAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRsgAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRsgAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新服务
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceRequest"/></param>
        /// <returns><see cref="UpdateServiceResponse"/></returns>
        public async Task<UpdateServiceResponse> UpdateService(UpdateServiceRequest req)
        {
             JsonResponseModel<UpdateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateService接口的同步版本，更新服务
        /// </summary>
        /// <param name="req">参考<see cref="UpdateServiceRequest"/></param>
        /// <returns>参考<see cref="UpdateServiceResponse"/>实例</returns>
        public UpdateServiceResponse UpdateServiceSync(UpdateServiceRequest req)
        {
             JsonResponseModel<UpdateServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
