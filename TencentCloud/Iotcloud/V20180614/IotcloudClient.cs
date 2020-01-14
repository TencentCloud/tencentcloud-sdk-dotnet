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

namespace TencentCloud.Iotcloud.V20180614
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotcloud.V20180614.Models;

   public class IotcloudClient : AbstractClient{

       private const string endpoint = "iotcloud.tencentcloudapi.com";
       private const string version = "2018-06-14";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotcloudClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotcloudClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（BindDevices）用于网关设备批量绑定子设备
        /// </summary>
        /// <param name="req"><see cref="BindDevicesRequest"/></param>
        /// <returns><see cref="BindDevicesResponse"/></returns>
        public async Task<BindDevicesResponse> BindDevices(BindDevicesRequest req)
        {
             JsonResponseModel<BindDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindDevices接口的同步版本，本接口（BindDevices）用于网关设备批量绑定子设备
        /// </summary>
        /// <param name="req">参考<see cref="BindDevicesRequest"/></param>
        /// <returns>参考<see cref="BindDevicesResponse"/>实例</returns>
        public BindDevicesResponse BindDevicesSync(BindDevicesRequest req)
        {
             JsonResponseModel<BindDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelTask）用于取消一个未被调度的任务。 
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CancelTask接口的同步版本，本接口（CancelTask）用于取消一个未被调度的任务。 
        /// </summary>
        /// <param name="req">参考<see cref="CancelTaskRequest"/></param>
        /// <returns>参考<see cref="CancelTaskResponse"/>实例</returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public async Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDevice接口的同步版本，本接口（CreateDevice）用于新建一个物联网通信设备。 
        /// </summary>
        /// <param name="req">参考<see cref="CreateDeviceRequest"/></param>
        /// <returns>参考<see cref="CreateDeviceResponse"/>实例</returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建lora类型的设备
        /// </summary>
        /// <param name="req"><see cref="CreateLoraDeviceRequest"/></param>
        /// <returns><see cref="CreateLoraDeviceResponse"/></returns>
        public async Task<CreateLoraDeviceResponse> CreateLoraDevice(CreateLoraDeviceRequest req)
        {
             JsonResponseModel<CreateLoraDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoraDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoraDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateLoraDevice接口的同步版本，创建lora类型的设备
        /// </summary>
        /// <param name="req">参考<see cref="CreateLoraDeviceRequest"/></param>
        /// <returns>参考<see cref="CreateLoraDeviceResponse"/>实例</returns>
        public CreateLoraDeviceResponse CreateLoraDeviceSync(CreateLoraDeviceRequest req)
        {
             JsonResponseModel<CreateLoraDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoraDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoraDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateMultiDevice）用于批量创建物联云设备。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiDeviceRequest"/></param>
        /// <returns><see cref="CreateMultiDeviceResponse"/></returns>
        public async Task<CreateMultiDeviceResponse> CreateMultiDevice(CreateMultiDeviceRequest req)
        {
             JsonResponseModel<CreateMultiDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultiDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateMultiDevice接口的同步版本，本接口（CreateMultiDevice）用于批量创建物联云设备。
        /// </summary>
        /// <param name="req">参考<see cref="CreateMultiDeviceRequest"/></param>
        /// <returns>参考<see cref="CreateMultiDeviceResponse"/>实例</returns>
        public CreateMultiDeviceResponse CreateMultiDeviceSync(CreateMultiDeviceRequest req)
        {
             JsonResponseModel<CreateMultiDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultiDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网通信产品 
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public async Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateProduct接口的同步版本，本接口（CreateProduct）用于创建一个新的物联网通信产品 
        /// </summary>
        /// <param name="req">参考<see cref="CreateProductRequest"/></param>
        /// <returns>参考<see cref="CreateProductResponse"/>实例</returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTask）用于创建一个批量任务。目前此接口可以创建批量更新影子以及批量下发消息的任务 
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateTask接口的同步版本，本接口（CreateTask）用于创建一个批量任务。目前此接口可以创建批量更新影子以及批量下发消息的任务 
        /// </summary>
        /// <param name="req">参考<see cref="CreateTaskRequest"/></param>
        /// <returns>参考<see cref="CreateTaskResponse"/>实例</returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTopicPolicy）用于创建一个Topic 
        /// </summary>
        /// <param name="req"><see cref="CreateTopicPolicyRequest"/></param>
        /// <returns><see cref="CreateTopicPolicyResponse"/></returns>
        public async Task<CreateTopicPolicyResponse> CreateTopicPolicy(CreateTopicPolicyRequest req)
        {
             JsonResponseModel<CreateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateTopicPolicy接口的同步版本，本接口（CreateTopicPolicy）用于创建一个Topic 
        /// </summary>
        /// <param name="req">参考<see cref="CreateTopicPolicyRequest"/></param>
        /// <returns>参考<see cref="CreateTopicPolicyResponse"/>实例</returns>
        public CreateTopicPolicyResponse CreateTopicPolicySync(CreateTopicPolicyRequest req)
        {
             JsonResponseModel<CreateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTopicRule）用于创建一个规则
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRuleRequest"/></param>
        /// <returns><see cref="CreateTopicRuleResponse"/></returns>
        public async Task<CreateTopicRuleResponse> CreateTopicRule(CreateTopicRuleRequest req)
        {
             JsonResponseModel<CreateTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateTopicRule接口的同步版本，本接口（CreateTopicRule）用于创建一个规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateTopicRuleRequest"/></param>
        /// <returns>参考<see cref="CreateTopicRuleResponse"/>实例</returns>
        public CreateTopicRuleResponse CreateTopicRuleSync(CreateTopicRuleRequest req)
        {
             JsonResponseModel<CreateTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public async Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteDevice接口的同步版本，本接口（DeleteDevice）用于删除物联网通信设备。 
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDeviceRequest"/></param>
        /// <returns>参考<see cref="DeleteDeviceResponse"/>实例</returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除lora类型的设备
        /// </summary>
        /// <param name="req"><see cref="DeleteLoraDeviceRequest"/></param>
        /// <returns><see cref="DeleteLoraDeviceResponse"/></returns>
        public async Task<DeleteLoraDeviceResponse> DeleteLoraDevice(DeleteLoraDeviceRequest req)
        {
             JsonResponseModel<DeleteLoraDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoraDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoraDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteLoraDevice接口的同步版本，删除lora类型的设备
        /// </summary>
        /// <param name="req">参考<see cref="DeleteLoraDeviceRequest"/></param>
        /// <returns>参考<see cref="DeleteLoraDeviceResponse"/>实例</returns>
        public DeleteLoraDeviceResponse DeleteLoraDeviceSync(DeleteLoraDeviceRequest req)
        {
             JsonResponseModel<DeleteLoraDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoraDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoraDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteProduct接口的同步版本，本接口（DeleteProduct）用于删除一个物联网通信产品
        /// </summary>
        /// <param name="req">参考<see cref="DeleteProductRequest"/></param>
        /// <returns>参考<see cref="DeleteProductResponse"/>实例</returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteTopicRule）用于删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRuleRequest"/></param>
        /// <returns><see cref="DeleteTopicRuleResponse"/></returns>
        public async Task<DeleteTopicRuleResponse> DeleteTopicRule(DeleteTopicRuleRequest req)
        {
             JsonResponseModel<DeleteTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteTopicRule接口的同步版本，本接口（DeleteTopicRule）用于删除规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTopicRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteTopicRuleResponse"/>实例</returns>
        public DeleteTopicRuleResponse DeleteTopicRuleSync(DeleteTopicRuleRequest req)
        {
             JsonResponseModel<DeleteTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevice）用于查看设备信息 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public async Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDevice接口的同步版本，本接口（DescribeDevice）用于查看设备信息 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceResponse"/>实例</returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书认证类型设备的私钥，刚生成或者重置设备后仅可调用一次
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClientKeyRequest"/></param>
        /// <returns><see cref="DescribeDeviceClientKeyResponse"/></returns>
        public async Task<DescribeDeviceClientKeyResponse> DescribeDeviceClientKey(DescribeDeviceClientKeyRequest req)
        {
             JsonResponseModel<DescribeDeviceClientKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceClientKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClientKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceClientKey接口的同步版本，获取证书认证类型设备的私钥，刚生成或者重置设备后仅可调用一次
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceClientKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceClientKeyResponse"/>实例</returns>
        public DescribeDeviceClientKeyResponse DescribeDeviceClientKeySync(DescribeDeviceClientKeyRequest req)
        {
             JsonResponseModel<DescribeDeviceClientKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceClientKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClientKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceShadow）用于查询虚拟设备信息。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowResponse"/></returns>
        public async Task<DescribeDeviceShadowResponse> DescribeDeviceShadow(DescribeDeviceShadowRequest req)
        {
             JsonResponseModel<DescribeDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceShadow接口的同步版本，本接口（DescribeDeviceShadow）用于查询虚拟设备信息。 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceShadowRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceShadowResponse"/>实例</returns>
        public DescribeDeviceShadowResponse DescribeDeviceShadowSync(DescribeDeviceShadowRequest req)
        {
             JsonResponseModel<DescribeDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDevices接口的同步版本，本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicesRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicesResponse"/>实例</returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取lora类型设备的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLoraDeviceRequest"/></param>
        /// <returns><see cref="DescribeLoraDeviceResponse"/></returns>
        public async Task<DescribeLoraDeviceResponse> DescribeLoraDevice(DescribeLoraDeviceRequest req)
        {
             JsonResponseModel<DescribeLoraDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoraDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoraDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeLoraDevice接口的同步版本，获取lora类型设备的详细信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeLoraDeviceRequest"/></param>
        /// <returns>参考<see cref="DescribeLoraDeviceResponse"/>实例</returns>
        public DescribeLoraDeviceResponse DescribeLoraDeviceSync(DescribeLoraDeviceRequest req)
        {
             JsonResponseModel<DescribeLoraDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoraDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoraDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMultiDevTask）用于查询批量创建设备任务的执行状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiDevTaskRequest"/></param>
        /// <returns><see cref="DescribeMultiDevTaskResponse"/></returns>
        public async Task<DescribeMultiDevTaskResponse> DescribeMultiDevTask(DescribeMultiDevTaskRequest req)
        {
             JsonResponseModel<DescribeMultiDevTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMultiDevTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMultiDevTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMultiDevTask接口的同步版本，本接口（DescribeMultiDevTask）用于查询批量创建设备任务的执行状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMultiDevTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeMultiDevTaskResponse"/>实例</returns>
        public DescribeMultiDevTaskResponse DescribeMultiDevTaskSync(DescribeMultiDevTaskRequest req)
        {
             JsonResponseModel<DescribeMultiDevTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMultiDevTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMultiDevTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMultiDevices）用于查询批量创建设备的执行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiDevicesRequest"/></param>
        /// <returns><see cref="DescribeMultiDevicesResponse"/></returns>
        public async Task<DescribeMultiDevicesResponse> DescribeMultiDevices(DescribeMultiDevicesRequest req)
        {
             JsonResponseModel<DescribeMultiDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMultiDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMultiDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMultiDevices接口的同步版本，本接口（DescribeMultiDevices）用于查询批量创建设备的执行结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMultiDevicesRequest"/></param>
        /// <returns>参考<see cref="DescribeMultiDevicesResponse"/>实例</returns>
        public DescribeMultiDevicesResponse DescribeMultiDevicesSync(DescribeMultiDevicesRequest req)
        {
             JsonResponseModel<DescribeMultiDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMultiDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMultiDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出产品列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public async Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProducts接口的同步版本，本接口（DescribeProducts）用于列出产品列表。 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProductsRequest"/></param>
        /// <returns>参考<see cref="DescribeProductsResponse"/>实例</returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTask）用于查询一个已创建任务的详情，任务保留一个月 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public async Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTask接口的同步版本，本接口（DescribeTask）用于查询一个已创建任务的详情，任务保留一个月 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskResponse"/>实例</returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTasks）用于查询已创建的任务列表，任务保留一个月 
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTasks接口的同步版本，本接口（DescribeTasks）用于查询已创建的任务列表，任务保留一个月 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeTasksResponse"/>实例</returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableTopicRule）用于禁用规则
        /// </summary>
        /// <param name="req"><see cref="DisableTopicRuleRequest"/></param>
        /// <returns><see cref="DisableTopicRuleResponse"/></returns>
        public async Task<DisableTopicRuleResponse> DisableTopicRule(DisableTopicRuleRequest req)
        {
             JsonResponseModel<DisableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableTopicRule接口的同步版本，本接口（DisableTopicRule）用于禁用规则
        /// </summary>
        /// <param name="req">参考<see cref="DisableTopicRuleRequest"/></param>
        /// <returns>参考<see cref="DisableTopicRuleResponse"/>实例</returns>
        public DisableTopicRuleResponse DisableTopicRuleSync(DisableTopicRuleRequest req)
        {
             JsonResponseModel<DisableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableTopicRule）用于启用规则
        /// </summary>
        /// <param name="req"><see cref="EnableTopicRuleRequest"/></param>
        /// <returns><see cref="EnableTopicRuleResponse"/></returns>
        public async Task<EnableTopicRuleResponse> EnableTopicRule(EnableTopicRuleRequest req)
        {
             JsonResponseModel<EnableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableTopicRule接口的同步版本，本接口（EnableTopicRule）用于启用规则
        /// </summary>
        /// <param name="req">参考<see cref="EnableTopicRuleRequest"/></param>
        /// <returns>参考<see cref="EnableTopicRuleResponse"/>实例</returns>
        public EnableTopicRuleResponse EnableTopicRuleSync(EnableTopicRuleRequest req)
        {
             JsonResponseModel<EnableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模拟lora类型的设备端向服务器端发送消息
        /// </summary>
        /// <param name="req"><see cref="PublishAsDeviceRequest"/></param>
        /// <returns><see cref="PublishAsDeviceResponse"/></returns>
        public async Task<PublishAsDeviceResponse> PublishAsDevice(PublishAsDeviceRequest req)
        {
             JsonResponseModel<PublishAsDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishAsDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishAsDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PublishAsDevice接口的同步版本，模拟lora类型的设备端向服务器端发送消息
        /// </summary>
        /// <param name="req">参考<see cref="PublishAsDeviceRequest"/></param>
        /// <returns>参考<see cref="PublishAsDeviceResponse"/>实例</returns>
        public PublishAsDeviceResponse PublishAsDeviceSync(PublishAsDeviceRequest req)
        {
             JsonResponseModel<PublishAsDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishAsDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishAsDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（PublishMessage）用于向某个主题发消息。 
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public async Task<PublishMessageResponse> PublishMessage(PublishMessageRequest req)
        {
             JsonResponseModel<PublishMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PublishMessage接口的同步版本，本接口（PublishMessage）用于向某个主题发消息。 
        /// </summary>
        /// <param name="req">参考<see cref="PublishMessageRequest"/></param>
        /// <returns>参考<see cref="PublishMessageResponse"/>实例</returns>
        public PublishMessageResponse PublishMessageSync(PublishMessageRequest req)
        {
             JsonResponseModel<PublishMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 服务器端下发消息给lora类型的设备
        /// </summary>
        /// <param name="req"><see cref="PublishToDeviceRequest"/></param>
        /// <returns><see cref="PublishToDeviceResponse"/></returns>
        public async Task<PublishToDeviceResponse> PublishToDevice(PublishToDeviceRequest req)
        {
             JsonResponseModel<PublishToDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishToDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishToDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PublishToDevice接口的同步版本，服务器端下发消息给lora类型的设备
        /// </summary>
        /// <param name="req">参考<see cref="PublishToDeviceRequest"/></param>
        /// <returns>参考<see cref="PublishToDeviceResponse"/>实例</returns>
        public PublishToDeviceResponse PublishToDeviceSync(PublishToDeviceRequest req)
        {
             JsonResponseModel<PublishToDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishToDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishToDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceTopicRule）用于修改替换规则
        /// </summary>
        /// <param name="req"><see cref="ReplaceTopicRuleRequest"/></param>
        /// <returns><see cref="ReplaceTopicRuleResponse"/></returns>
        public async Task<ReplaceTopicRuleResponse> ReplaceTopicRule(ReplaceTopicRuleRequest req)
        {
             JsonResponseModel<ReplaceTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ReplaceTopicRule接口的同步版本，本接口（ReplaceTopicRule）用于修改替换规则
        /// </summary>
        /// <param name="req">参考<see cref="ReplaceTopicRuleRequest"/></param>
        /// <returns>参考<see cref="ReplaceTopicRuleResponse"/>实例</returns>
        public ReplaceTopicRuleResponse ReplaceTopicRuleSync(ReplaceTopicRuleRequest req)
        {
             JsonResponseModel<ReplaceTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置设备的连接状态 
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceStateRequest"/></param>
        /// <returns><see cref="ResetDeviceStateResponse"/></returns>
        public async Task<ResetDeviceStateResponse> ResetDeviceState(ResetDeviceStateRequest req)
        {
             JsonResponseModel<ResetDeviceStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDeviceState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResetDeviceState接口的同步版本，重置设备的连接状态 
        /// </summary>
        /// <param name="req">参考<see cref="ResetDeviceStateRequest"/></param>
        /// <returns>参考<see cref="ResetDeviceStateResponse"/>实例</returns>
        public ResetDeviceStateResponse ResetDeviceStateSync(ResetDeviceStateRequest req)
        {
             JsonResponseModel<ResetDeviceStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetDeviceState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnbindDevices）用于网关设备批量解绑子设备
        /// </summary>
        /// <param name="req"><see cref="UnbindDevicesRequest"/></param>
        /// <returns><see cref="UnbindDevicesResponse"/></returns>
        public async Task<UnbindDevicesResponse> UnbindDevices(UnbindDevicesRequest req)
        {
             JsonResponseModel<UnbindDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindDevices接口的同步版本，本接口（UnbindDevices）用于网关设备批量解绑子设备
        /// </summary>
        /// <param name="req">参考<see cref="UnbindDevicesRequest"/></param>
        /// <returns>参考<see cref="UnbindDevicesResponse"/>实例</returns>
        public UnbindDevicesResponse UnbindDevicesSync(UnbindDevicesRequest req)
        {
             JsonResponseModel<UnbindDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用或者禁用设备
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceAvailableStateRequest"/></param>
        /// <returns><see cref="UpdateDeviceAvailableStateResponse"/></returns>
        public async Task<UpdateDeviceAvailableStateResponse> UpdateDeviceAvailableState(UpdateDeviceAvailableStateRequest req)
        {
             JsonResponseModel<UpdateDeviceAvailableStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceAvailableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceAvailableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateDeviceAvailableState接口的同步版本，启用或者禁用设备
        /// </summary>
        /// <param name="req">参考<see cref="UpdateDeviceAvailableStateRequest"/></param>
        /// <returns>参考<see cref="UpdateDeviceAvailableStateResponse"/>实例</returns>
        public UpdateDeviceAvailableStateResponse UpdateDeviceAvailableStateSync(UpdateDeviceAvailableStateRequest req)
        {
             JsonResponseModel<UpdateDeviceAvailableStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceAvailableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceAvailableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateDeviceShadow）用于更新虚拟设备信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceShadowRequest"/></param>
        /// <returns><see cref="UpdateDeviceShadowResponse"/></returns>
        public async Task<UpdateDeviceShadowResponse> UpdateDeviceShadow(UpdateDeviceShadowRequest req)
        {
             JsonResponseModel<UpdateDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateDeviceShadow接口的同步版本，本接口（UpdateDeviceShadow）用于更新虚拟设备信息。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateDeviceShadowRequest"/></param>
        /// <returns>参考<see cref="UpdateDeviceShadowResponse"/>实例</returns>
        public UpdateDeviceShadowResponse UpdateDeviceShadowSync(UpdateDeviceShadowRequest req)
        {
             JsonResponseModel<UpdateDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息
        /// </summary>
        /// <param name="req"><see cref="UpdateTopicPolicyRequest"/></param>
        /// <returns><see cref="UpdateTopicPolicyResponse"/></returns>
        public async Task<UpdateTopicPolicyResponse> UpdateTopicPolicy(UpdateTopicPolicyRequest req)
        {
             JsonResponseModel<UpdateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpdateTopicPolicy接口的同步版本，本接口（UpdateTopicPolicy）用于更新Topic信息
        /// </summary>
        /// <param name="req">参考<see cref="UpdateTopicPolicyRequest"/></param>
        /// <returns>参考<see cref="UpdateTopicPolicyResponse"/>实例</returns>
        public UpdateTopicPolicyResponse UpdateTopicPolicySync(UpdateTopicPolicyRequest req)
        {
             JsonResponseModel<UpdateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
