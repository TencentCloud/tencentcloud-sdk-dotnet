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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public IotcloudClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public IotcloudClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（CancelTask）用于取消一个未被调度的任务。
        /// </summary>
        /// <param name="req">参考<see cref="CancelTaskRequest"/></param>
        /// <returns>参考<see cref="CancelTaskResponse"/>实例</returns>
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
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDeviceRequest"/></param>
        /// <returns>参考<see cref="CreateDeviceResponse"/>实例</returns>
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
        /// 本接口（CreateMultiDevice）用于批量创建物联云设备。
        /// </summary>
        /// <param name="req">参考<see cref="CreateMultiDeviceRequest"/></param>
        /// <returns>参考<see cref="CreateMultiDeviceResponse"/>实例</returns>
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
        /// 本接口（CreateProduct）用于创建一个新的物联网通信产品
        /// </summary>
        /// <param name="req">参考<see cref="CreateProductRequest"/></param>
        /// <returns>参考<see cref="CreateProductResponse"/>实例</returns>
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
        /// 本接口（CreateTask）用于创建一个批量任务。目前此接口可以创建批量更新影子以及批量下发消息的任务
        /// </summary>
        /// <param name="req">参考<see cref="CreateTaskRequest"/></param>
        /// <returns>参考<see cref="CreateTaskResponse"/>实例</returns>
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
        /// 本接口（CreateTopicPolicy）用于创建一个Topic
        /// </summary>
        /// <param name="req">参考<see cref="CreateTopicPolicyRequest"/></param>
        /// <returns>参考<see cref="CreateTopicPolicyResponse"/>实例</returns>
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
        /// 本接口（CreateTopicRule）用于创建一个规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateTopicRuleRequest"/></param>
        /// <returns>参考<see cref="CreateTopicRuleResponse"/>实例</returns>
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
        /// 本接口（DeleteDevice）用于删除物联网通信设备。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDeviceRequest"/></param>
        /// <returns>参考<see cref="DeleteDeviceResponse"/>实例</returns>
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
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteProductRequest"/></param>
        /// <returns>参考<see cref="DeleteProductResponse"/>实例</returns>
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
        /// 本接口（DeleteTopicRule）用于删除规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTopicRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteTopicRuleResponse"/>实例</returns>
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
        /// 本接口（DescribeDevice）用于查看设备信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceResponse"/>实例</returns>
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
        /// 本接口（DescribeDeviceShadow）用于查询虚拟设备信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceShadowRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceShadowResponse"/>实例</returns>
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
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicesRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicesResponse"/>实例</returns>
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
        /// 本接口（DescribeMultiDevTask）用于查询批量创建设备任务的执行状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMultiDevTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeMultiDevTaskResponse"/>实例</returns>
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
        /// 本接口（DescribeMultiDevices）用于查询批量创建设备的执行结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMultiDevicesRequest"/></param>
        /// <returns>参考<see cref="DescribeMultiDevicesResponse"/>实例</returns>
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
        /// 本接口（DescribeProducts）用于列出产品列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProductsRequest"/></param>
        /// <returns>参考<see cref="DescribeProductsResponse"/>实例</returns>
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
        /// 本接口（DescribeTask）用于查询一个已创建任务的详情，任务保留一个月
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskResponse"/>实例</returns>
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
        /// 本接口（DescribeTasks）用于查询已创建的任务列表，任务保留一个月
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeTasksResponse"/>实例</returns>
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
        /// 本接口（DisableTopicRule）用于禁用规则
        /// </summary>
        /// <param name="req">参考<see cref="DisableTopicRuleRequest"/></param>
        /// <returns>参考<see cref="DisableTopicRuleResponse"/>实例</returns>
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
        /// 本接口（EnableTopicRule）用于启用规则
        /// </summary>
        /// <param name="req">参考<see cref="EnableTopicRuleRequest"/></param>
        /// <returns>参考<see cref="EnableTopicRuleResponse"/>实例</returns>
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
        /// 本接口（PublishMessage）用于向某个主题发消息。
        /// </summary>
        /// <param name="req">参考<see cref="PublishMessageRequest"/></param>
        /// <returns>参考<see cref="PublishMessageResponse"/>实例</returns>
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
        /// 本接口（ReplaceTopicRule）用于修改替换规则
        /// </summary>
        /// <param name="req">参考<see cref="ReplaceTopicRuleRequest"/></param>
        /// <returns>参考<see cref="ReplaceTopicRuleResponse"/>实例</returns>
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
        /// 本接口（UpdateDeviceShadow）用于更新虚拟设备信息。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateDeviceShadowRequest"/></param>
        /// <returns>参考<see cref="UpdateDeviceShadowResponse"/>实例</returns>
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
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息
        /// </summary>
        /// <param name="req">参考<see cref="UpdateTopicPolicyRequest"/></param>
        /// <returns>参考<see cref="UpdateTopicPolicyResponse"/>实例</returns>
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

    }
}
