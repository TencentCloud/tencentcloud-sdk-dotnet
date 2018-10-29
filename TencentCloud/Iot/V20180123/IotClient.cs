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
        /// 为APP提供用户注册功能
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
        /// 用户解除与设备的关联关系，解除后APP用户无法控制设备，获取设备数据
        /// </summary>
        /// <param name="req">参考<see cref="AppDeleteDeviceRequest"/></param>
        /// <returns>参考<see cref="AppDeleteDeviceResponse"/>实例</returns>
        public async Task<AppDeleteDeviceResponse> AppDeleteDevice(AppDeleteDeviceRequest req)
        {
             JsonResponseModel<AppDeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppDeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppDeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取绑定设备的基本信息与数据模板定义
        /// </summary>
        /// <param name="req">参考<see cref="AppGetDeviceRequest"/></param>
        /// <returns>参考<see cref="AppGetDeviceResponse"/>实例</returns>
        public async Task<AppGetDeviceResponse> AppGetDevice(AppGetDeviceRequest req)
        {
             JsonResponseModel<AppGetDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppGetDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppGetDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取绑定设备数据，用于实时展示设备的最新数据
        /// </summary>
        /// <param name="req">参考<see cref="AppGetDeviceDataRequest"/></param>
        /// <returns>参考<see cref="AppGetDeviceDataResponse"/>实例</returns>
        public async Task<AppGetDeviceDataResponse> AppGetDeviceData(AppGetDeviceDataRequest req)
        {
             JsonResponseModel<AppGetDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppGetDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppGetDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取绑定设备的上下线状态
        /// </summary>
        /// <param name="req">参考<see cref="AppGetDeviceStatusesRequest"/></param>
        /// <returns>参考<see cref="AppGetDeviceStatusesResponse"/>实例</returns>
        public async Task<AppGetDeviceStatusesResponse> AppGetDeviceStatuses(AppGetDeviceStatusesRequest req)
        {
             JsonResponseModel<AppGetDeviceStatusesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppGetDeviceStatuses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppGetDeviceStatusesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户的绑定设备列表
        /// </summary>
        /// <param name="req">参考<see cref="AppGetDevicesRequest"/></param>
        /// <returns>参考<see cref="AppGetDevicesResponse"/>实例</returns>
        public async Task<AppGetDevicesResponse> AppGetDevices(AppGetDevicesRequest req)
        {
             JsonResponseModel<AppGetDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppGetDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppGetDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户token
        /// </summary>
        /// <param name="req">参考<see cref="AppGetTokenRequest"/></param>
        /// <returns>参考<see cref="AppGetTokenResponse"/>实例</returns>
        public async Task<AppGetTokenResponse> AppGetToken(AppGetTokenRequest req)
        {
             JsonResponseModel<AppGetTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppGetToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppGetTokenResponse>>(strResp);
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
        /// <param name="req">参考<see cref="AppGetUserRequest"/></param>
        /// <returns>参考<see cref="AppGetUserResponse"/>实例</returns>
        public async Task<AppGetUserResponse> AppGetUser(AppGetUserRequest req)
        {
             JsonResponseModel<AppGetUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppGetUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppGetUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过APP控制设备
        /// </summary>
        /// <param name="req">参考<see cref="AppIssueDeviceControlRequest"/></param>
        /// <returns>参考<see cref="AppIssueDeviceControlResponse"/>实例</returns>
        public async Task<AppIssueDeviceControlResponse> AppIssueDeviceControl(AppIssueDeviceControlRequest req)
        {
             JsonResponseModel<AppIssueDeviceControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppIssueDeviceControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppIssueDeviceControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置APP用户密码
        /// </summary>
        /// <param name="req">参考<see cref="AppResetPasswordRequest"/></param>
        /// <returns>参考<see cref="AppResetPasswordResponse"/>实例</returns>
        public async Task<AppResetPasswordResponse> AppResetPassword(AppResetPasswordRequest req)
        {
             JsonResponseModel<AppResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户绑定设备，绑定后可以在APP端进行控制。绑定设备前需调用“获取设备绑定签名”接口
        /// </summary>
        /// <param name="req">参考<see cref="AppSecureAddDeviceRequest"/></param>
        /// <returns>参考<see cref="AppSecureAddDeviceResponse"/>实例</returns>
        public async Task<AppSecureAddDeviceResponse> AppSecureAddDevice(AppSecureAddDeviceRequest req)
        {
             JsonResponseModel<AppSecureAddDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppSecureAddDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppSecureAddDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改设备别名，便于用户个性化定义设备的名称
        /// </summary>
        /// <param name="req">参考<see cref="AppUpdateDeviceRequest"/></param>
        /// <returns>参考<see cref="AppUpdateDeviceResponse"/>实例</returns>
        public async Task<AppUpdateDeviceResponse> AppUpdateDevice(AppUpdateDeviceRequest req)
        {
             JsonResponseModel<AppUpdateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppUpdateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppUpdateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req">参考<see cref="AppUpdateUserRequest"/></param>
        /// <returns>参考<see cref="AppUpdateUserResponse"/>实例</returns>
        public async Task<AppUpdateUserResponse> AppUpdateUser(AppUpdateUserRequest req)
        {
             JsonResponseModel<AppUpdateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AppUpdateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AppUpdateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联子设备产品和网关产品
        /// </summary>
        /// <param name="req">参考<see cref="AssociateSubDeviceToGatewayProductRequest"/></param>
        /// <returns>参考<see cref="AssociateSubDeviceToGatewayProductResponse"/>实例</returns>
        public async Task<AssociateSubDeviceToGatewayProductResponse> AssociateSubDeviceToGatewayProduct(AssociateSubDeviceToGatewayProductRequest req)
        {
             JsonResponseModel<AssociateSubDeviceToGatewayProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSubDeviceToGatewayProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSubDeviceToGatewayProductResponse>>(strResp);
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
        /// 批量获取设备某一段时间范围的设备上报数据。该接口适用于使用高级版类型的产品
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
        /// 获取设备的调试日志，用于定位问题
        /// </summary>
        /// <param name="req">参考<see cref="GetDebugLogRequest"/></param>
        /// <returns>参考<see cref="GetDebugLogResponse"/>实例</returns>
        public async Task<GetDebugLogResponse> GetDebugLog(GetDebugLogRequest req)
        {
             JsonResponseModel<GetDebugLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDebugLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDebugLogResponse>>(strResp);
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
        /// 批量获取设备与云端的详细通信日志，该接口适用于使用高级版类型的产品。
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
        /// 获取设备绑定签名，用于用户绑定某个设备的应用场景
        /// </summary>
        /// <param name="req">参考<see cref="GetDeviceSignaturesRequest"/></param>
        /// <returns>参考<see cref="GetDeviceSignaturesResponse"/>实例</returns>
        public async Task<GetDeviceSignaturesResponse> GetDeviceSignatures(GetDeviceSignaturesRequest req)
        {
             JsonResponseModel<GetDeviceSignaturesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceSignatures");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceSignaturesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某段时间范围内产品的在线、激活设备数
        /// </summary>
        /// <param name="req">参考<see cref="GetDeviceStatisticsRequest"/></param>
        /// <returns>参考<see cref="GetDeviceStatisticsResponse"/>实例</returns>
        public async Task<GetDeviceStatisticsResponse> GetDeviceStatistics(GetDeviceStatisticsRequest req)
        {
             JsonResponseModel<GetDeviceStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceStatisticsResponse>>(strResp);
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
        /// 提供下发控制指令到指定设备的能力，该接口适用于使用高级版类型的产品。
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
        /// 提供向指定的Topic发布消息的能力，常用于向设备下发控制指令。该接口只适用于产品版本为“基础版”类型的产品，使用高级版的产品需使用“下发设备控制指令”接口
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
        /// 取消子设备产品与网关设备产品的关联
        /// </summary>
        /// <param name="req">参考<see cref="UnassociateSubDeviceFromGatewayProductRequest"/></param>
        /// <returns>参考<see cref="UnassociateSubDeviceFromGatewayProductResponse"/>实例</returns>
        public async Task<UnassociateSubDeviceFromGatewayProductResponse> UnassociateSubDeviceFromGatewayProduct(UnassociateSubDeviceFromGatewayProductRequest req)
        {
             JsonResponseModel<UnassociateSubDeviceFromGatewayProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassociateSubDeviceFromGatewayProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassociateSubDeviceFromGatewayProductResponse>>(strResp);
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
