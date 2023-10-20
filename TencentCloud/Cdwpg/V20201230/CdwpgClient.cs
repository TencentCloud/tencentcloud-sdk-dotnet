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

namespace TencentCloud.Cdwpg.V20201230
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwpg.V20201230.Models;

   public class CdwpgClient : AbstractClient{

       private const string endpoint = "cdwpg.tencentcloudapi.com";
       private const string version = "2020-12-30";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwpgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwpgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceByApiRequest"/></param>
        /// <returns><see cref="CreateInstanceByApiResponse"/></returns>
        public async Task<CreateInstanceByApiResponse> CreateInstanceByApi(CreateInstanceByApiRequest req)
        {
             JsonResponseModel<CreateInstanceByApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceByApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceByApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceByApiRequest"/></param>
        /// <returns><see cref="CreateInstanceByApiResponse"/></returns>
        public CreateInstanceByApiResponse CreateInstanceByApiSync(CreateInstanceByApiRequest req)
        {
             JsonResponseModel<CreateInstanceByApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceByApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceByApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据实例ID查询某个实例的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public async Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据实例ID查询某个实例的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群详情页中显示集群状态、流程进度等
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public async Task<DescribeInstanceStateResponse> DescribeInstanceState(DescribeInstanceStateRequest req)
        {
             JsonResponseModel<DescribeInstanceStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群详情页中显示集群状态、流程进度等
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public DescribeInstanceStateResponse DescribeInstanceStateSync(DescribeInstanceStateRequest req)
        {
             JsonResponseModel<DescribeInstanceStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生实例列表
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
        /// 获取云原生实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
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
        /// 获取集群实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleInstancesRequest"/></param>
        /// <returns><see cref="DescribeSimpleInstancesResponse"/></returns>
        public async Task<DescribeSimpleInstancesResponse> DescribeSimpleInstances(DescribeSimpleInstancesRequest req)
        {
             JsonResponseModel<DescribeSimpleInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSimpleInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleInstancesRequest"/></param>
        /// <returns><see cref="DescribeSimpleInstancesResponse"/></returns>
        public DescribeSimpleInstancesResponse DescribeSimpleInstancesSync(DescribeSimpleInstancesRequest req)
        {
             JsonResponseModel<DescribeSimpleInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSimpleInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSimpleInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceByApiRequest"/></param>
        /// <returns><see cref="DestroyInstanceByApiResponse"/></returns>
        public async Task<DestroyInstanceByApiResponse> DestroyInstanceByApi(DestroyInstanceByApiRequest req)
        {
             JsonResponseModel<DestroyInstanceByApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyInstanceByApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyInstanceByApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceByApiRequest"/></param>
        /// <returns><see cref="DestroyInstanceByApiResponse"/></returns>
        public DestroyInstanceByApiResponse DestroyInstanceByApiSync(DestroyInstanceByApiRequest req)
        {
             JsonResponseModel<DestroyInstanceByApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyInstanceByApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyInstanceByApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例信息，目前为实例名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例信息，目前为实例名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
