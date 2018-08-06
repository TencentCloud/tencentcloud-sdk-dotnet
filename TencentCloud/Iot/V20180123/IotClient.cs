/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Iot.V20180123
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iot.V20180123.Models;

   public class IotClient : AbstractClient{

       private const string endpoint = "iot.tencentcloudapi.com";
       private const string version = "2018-01-23";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public IotClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public IotClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 启用规则
        /// </summary>
        /// <param name="req">参考<see cref="ActivateRuleRequest"/></param>
        /// <returns>参考<see cref="ActivateRuleResponse"/>实例</returns>
        public async Task<ActivateRuleResponse> ActivateRule(ActivateRuleRequest req)
        {
             JsonResponseModel<ActivateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ActivateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActivateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供在指定的产品Id下创建一个设备的能力，生成设备名称与设备秘钥。
        /// </summary>
        /// <param name="req">参考<see cref="AddDeviceRequest"/></param>
        /// <returns>参考<see cref="AddDeviceResponse"/>实例</returns>
        public async Task<AddDeviceResponse> AddDevice(AddDeviceRequest req)
        {
             JsonResponseModel<AddDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AddProduct)用于创建、定义某款硬件产品。
        /// </summary>
        /// <param name="req">参考<see cref="AddProductRequest"/></param>
        /// <returns>参考<see cref="AddProductResponse"/>实例</returns>
        public async Task<AddProductResponse> AddProduct(AddProductRequest req)
        {
             JsonResponseModel<AddProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增规则
        /// </summary>
        /// <param name="req">参考<see cref="AddRuleRequest"/></param>
        /// <returns>参考<see cref="AddRuleResponse"/>实例</returns>
        public async Task<AddRuleResponse> AddRule(AddRuleRequest req)
        {
             JsonResponseModel<AddRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增Topic，用于设备或应用发布消息至该Topic或订阅该Topic的消息。
        /// </summary>
        /// <param name="req">参考<see cref="AddTopicRequest"/></param>
        /// <returns>参考<see cref="AddTopicResponse"/>实例</returns>
        public async Task<AddTopicResponse> AddTopic(AddTopicRequest req)
        {
             JsonResponseModel<AddTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="req">参考<see cref="AddUserRequest"/></param>
        /// <returns>参考<see cref="AddUserResponse"/>实例</returns>
        public async Task<AddUserResponse> AddUser(AddUserRequest req)
        {
             JsonResponseModel<AddUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册应用用户
        /// </summary>
        /// <param name="req">参考<see cref="AppAddUserRequest"/></param>
        /// <returns>参考<see cref="AppAddUserResponse"/>实例</returns>
        public async Task<AppAddUserResponse> AppAddUser(AppAddUserRequest req)
        {
             JsonResponseModel<AppAddUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppAddUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppAddUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用规则
        /// </summary>
        /// <param name="req">参考<see cref="DeactivateRuleRequest"/></param>
        /// <returns>参考<see cref="DeactivateRuleResponse"/>实例</returns>
        public async Task<DeactivateRuleResponse> DeactivateRule(DeactivateRuleRequest req)
        {
             JsonResponseModel<DeactivateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeactivateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeactivateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供在指定的产品Id下删除一个设备的能力。
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
        /// 删除用户指定的产品Id对应的信息。
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
        /// 删除规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteRuleResponse"/>实例</returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Topic
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTopicRequest"/></param>
        /// <returns>参考<see cref="DeleteTopicResponse"/>实例</returns>
        public async Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取设备某一段时间范围的设备上报数据。该接口只允许使用数据模板类型的产品通过REST API方式同步设备上报数据至用户的应用系统。
        /// </summary>
        /// <param name="req">参考<see cref="GetDataHistoryRequest"/></param>
        /// <returns>参考<see cref="GetDataHistoryResponse"/>实例</returns>
        public async Task<GetDataHistoryResponse> GetDataHistory(GetDataHistoryRequest req)
        {
             JsonResponseModel<GetDataHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDataHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDataHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询某个设备详细信息的能力。
        /// </summary>
        /// <param name="req">参考<see cref="GetDeviceRequest"/></param>
        /// <returns>参考<see cref="GetDeviceResponse"/>实例</returns>
        public async Task<GetDeviceResponse> GetDevice(GetDeviceRequest req)
        {
             JsonResponseModel<GetDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个设备当前上报到云端的数据，该接口适用于使用数据模板协议的产品。
        /// </summary>
        /// <param name="req">参考<see cref="GetDeviceDataRequest"/></param>
        /// <returns>参考<see cref="GetDeviceDataResponse"/>实例</returns>
        public async Task<GetDeviceDataResponse> GetDeviceData(GetDeviceDataRequest req)
        {
             JsonResponseModel<GetDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取设备与云端的详细通信日志，该接口适用于使用数据模板类型的产品。
        /// </summary>
        /// <param name="req">参考<see cref="GetDeviceLogRequest"/></param>
        /// <returns>参考<see cref="GetDeviceLogResponse"/>实例</returns>
        public async Task<GetDeviceLogResponse> GetDeviceLog(GetDeviceLogRequest req)
        {
             JsonResponseModel<GetDeviceLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取设备的当前状态，状态包括在线、离线或未激活状态。
        /// </summary>
        /// <param name="req">参考<see cref="GetDeviceStatusesRequest"/></param>
        /// <returns>参考<see cref="GetDeviceStatusesResponse"/>实例</returns>
        public async Task<GetDeviceStatusesResponse> GetDeviceStatuses(GetDeviceStatusesRequest req)
        {
             JsonResponseModel<GetDeviceStatusesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceStatuses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceStatusesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供分页查询某个产品Id下设备信息的能力。
        /// </summary>
        /// <param name="req">参考<see cref="GetDevicesRequest"/></param>
        /// <returns>参考<see cref="GetDevicesResponse"/>实例</returns>
        public async Task<GetDevicesResponse> GetDevices(GetDevicesRequest req)
        {
             JsonResponseModel<GetDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品定义的详细信息，包括产品名称、产品描述，鉴权模式等信息。
        /// </summary>
        /// <param name="req">参考<see cref="GetProductRequest"/></param>
        /// <returns>参考<see cref="GetProductResponse"/>实例</returns>
        public async Task<GetProductResponse> GetProduct(GetProductRequest req)
        {
             JsonResponseModel<GetProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户在物联网套件所创建的所有产品信息。
        /// </summary>
        /// <param name="req">参考<see cref="GetProductsRequest"/></param>
        /// <returns>参考<see cref="GetProductsResponse"/>实例</returns>
        public async Task<GetProductsResponse> GetProducts(GetProductsRequest req)
        {
             JsonResponseModel<GetProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转发规则信息
        /// </summary>
        /// <param name="req">参考<see cref="GetRuleRequest"/></param>
        /// <returns>参考<see cref="GetRuleResponse"/>实例</returns>
        public async Task<GetRuleResponse> GetRule(GetRuleRequest req)
        {
             JsonResponseModel<GetRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取转发规则列表
        /// </summary>
        /// <param name="req">参考<see cref="GetRulesRequest"/></param>
        /// <returns>参考<see cref="GetRulesResponse"/>实例</returns>
        public async Task<GetRulesResponse> GetRules(GetRulesRequest req)
        {
             JsonResponseModel<GetRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Topic信息
        /// </summary>
        /// <param name="req">参考<see cref="GetTopicRequest"/></param>
        /// <returns>参考<see cref="GetTopicResponse"/>实例</returns>
        public async Task<GetTopicResponse> GetTopic(GetTopicRequest req)
        {
             JsonResponseModel<GetTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Topic列表
        /// </summary>
        /// <param name="req">参考<see cref="GetTopicsRequest"/></param>
        /// <returns>参考<see cref="GetTopicsResponse"/>实例</returns>
        public async Task<GetTopicsResponse> GetTopics(GetTopicsRequest req)
        {
             JsonResponseModel<GetTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req">参考<see cref="GetUserRequest"/></param>
        /// <returns>参考<see cref="GetUserResponse"/>实例</returns>
        public async Task<GetUserResponse> GetUser(GetUserRequest req)
        {
             JsonResponseModel<GetUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供下发控制指令到指定设备的能力，该接口适用于使用数据模板类型的产品。
        /// </summary>
        /// <param name="req">参考<see cref="IssueDeviceControlRequest"/></param>
        /// <returns>参考<see cref="IssueDeviceControlResponse"/>实例</returns>
        public async Task<IssueDeviceControlResponse> IssueDeviceControl(IssueDeviceControlRequest req)
        {
             JsonResponseModel<IssueDeviceControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IssueDeviceControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IssueDeviceControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供向指定的Topic发布消息的能力，常用于向设备下发控制指令；该接口只适用于数据协议为“自定义”类型的产品，使用数据模板类型的产品需使用IssueDeviceControl接口
        /// </summary>
        /// <param name="req">参考<see cref="PublishMsgRequest"/></param>
        /// <returns>参考<see cref="PublishMsgResponse"/>实例</returns>
        public async Task<PublishMsgResponse> PublishMsg(PublishMsgRequest req)
        {
             JsonResponseModel<PublishMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置设备操作，将会为设备生成新的证书及清空最新数据，需谨慎操作。
        /// </summary>
        /// <param name="req">参考<see cref="ResetDeviceRequest"/></param>
        /// <returns>参考<see cref="ResetDeviceResponse"/>实例</returns>
        public async Task<ResetDeviceResponse> ResetDevice(ResetDeviceRequest req)
        {
             JsonResponseModel<ResetDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供修改产品信息及数据模板的能力。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateProductRequest"/></param>
        /// <returns>参考<see cref="UpdateProductResponse"/>实例</returns>
        public async Task<UpdateProductResponse> UpdateProduct(UpdateProductRequest req)
        {
             JsonResponseModel<UpdateProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新规则
        /// </summary>
        /// <param name="req">参考<see cref="UpdateRuleRequest"/></param>
        /// <returns>参考<see cref="UpdateRuleResponse"/>实例</returns>
        public async Task<UpdateRuleResponse> UpdateRule(UpdateRuleRequest req)
        {
             JsonResponseModel<UpdateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
