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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TiemsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TiemsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建任务
        /// </summary>
        /// <param name="req">参考<see cref="CreateJobRequest"/></param>
        /// <returns>参考<see cref="CreateJobResponse"/>实例</returns>
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
        /// 创建运行环境
        /// </summary>
        /// <param name="req">参考<see cref="CreateRuntimeRequest"/></param>
        /// <returns>参考<see cref="CreateRuntimeResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="CreateServiceRequest"/></param>
        /// <returns>参考<see cref="CreateServiceResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="CreateServiceConfigRequest"/></param>
        /// <returns>参考<see cref="CreateServiceConfigResponse"/>实例</returns>
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
        /// 删除任务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteJobRequest"/></param>
        /// <returns>参考<see cref="DeleteJobResponse"/>实例</returns>
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
        /// 删除运行环境
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRuntimeRequest"/></param>
        /// <returns>参考<see cref="DeleteRuntimeResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="DeleteServiceRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="DeleteServiceConfigRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceConfigResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="DescribeInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesResponse"/>实例</returns>
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
        /// 描述服务运行环境
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRuntimesRequest"/></param>
        /// <returns>参考<see cref="DescribeRuntimesResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="DescribeServiceConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeServiceConfigsResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="DescribeServicesRequest"/></param>
        /// <returns>参考<see cref="DescribeServicesResponse"/>实例</returns>
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
        /// 暴露服务
        /// </summary>
        /// <param name="req">参考<see cref="ExposeServiceRequest"/></param>
        /// <returns>参考<see cref="ExposeServiceResponse"/>实例</returns>
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
        /// <param name="req">参考<see cref="UpdateJobRequest"/></param>
        /// <returns>参考<see cref="UpdateJobResponse"/>实例</returns>
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
        /// 更新服务
        /// </summary>
        /// <param name="req">参考<see cref="UpdateServiceRequest"/></param>
        /// <returns>参考<see cref="UpdateServiceResponse"/>实例</returns>
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
