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
       private const string sdkVersion = "SDK_NET_3.0.983";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 启用规则
        /// </summary>
        /// <param name="req"><see cref="ActivateRuleRequest"/></param>
        /// <returns><see cref="ActivateRuleResponse"/></returns>
        public Task<ActivateRuleResponse> ActivateRule(ActivateRuleRequest req)
        {
            return InternalRequestAsync<ActivateRuleResponse>(req, "ActivateRule");
        }

        /// <summary>
        /// 启用规则
        /// </summary>
        /// <param name="req"><see cref="ActivateRuleRequest"/></param>
        /// <returns><see cref="ActivateRuleResponse"/></returns>
        public ActivateRuleResponse ActivateRuleSync(ActivateRuleRequest req)
        {
            return InternalRequestAsync<ActivateRuleResponse>(req, "ActivateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供在指定的产品Id下创建一个设备的能力，生成设备名称与设备秘钥。
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public Task<AddDeviceResponse> AddDevice(AddDeviceRequest req)
        {
            return InternalRequestAsync<AddDeviceResponse>(req, "AddDevice");
        }

        /// <summary>
        /// 提供在指定的产品Id下创建一个设备的能力，生成设备名称与设备秘钥。
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public AddDeviceResponse AddDeviceSync(AddDeviceRequest req)
        {
            return InternalRequestAsync<AddDeviceResponse>(req, "AddDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(AddProduct)用于创建、定义某款硬件产品。
        /// </summary>
        /// <param name="req"><see cref="AddProductRequest"/></param>
        /// <returns><see cref="AddProductResponse"/></returns>
        public Task<AddProductResponse> AddProduct(AddProductRequest req)
        {
            return InternalRequestAsync<AddProductResponse>(req, "AddProduct");
        }

        /// <summary>
        /// 本接口(AddProduct)用于创建、定义某款硬件产品。
        /// </summary>
        /// <param name="req"><see cref="AddProductRequest"/></param>
        /// <returns><see cref="AddProductResponse"/></returns>
        public AddProductResponse AddProductSync(AddProductRequest req)
        {
            return InternalRequestAsync<AddProductResponse>(req, "AddProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增规则
        /// </summary>
        /// <param name="req"><see cref="AddRuleRequest"/></param>
        /// <returns><see cref="AddRuleResponse"/></returns>
        public Task<AddRuleResponse> AddRule(AddRuleRequest req)
        {
            return InternalRequestAsync<AddRuleResponse>(req, "AddRule");
        }

        /// <summary>
        /// 新增规则
        /// </summary>
        /// <param name="req"><see cref="AddRuleRequest"/></param>
        /// <returns><see cref="AddRuleResponse"/></returns>
        public AddRuleResponse AddRuleSync(AddRuleRequest req)
        {
            return InternalRequestAsync<AddRuleResponse>(req, "AddRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增Topic，用于设备或应用发布消息至该Topic或订阅该Topic的消息。
        /// </summary>
        /// <param name="req"><see cref="AddTopicRequest"/></param>
        /// <returns><see cref="AddTopicResponse"/></returns>
        public Task<AddTopicResponse> AddTopic(AddTopicRequest req)
        {
            return InternalRequestAsync<AddTopicResponse>(req, "AddTopic");
        }

        /// <summary>
        /// 新增Topic，用于设备或应用发布消息至该Topic或订阅该Topic的消息。
        /// </summary>
        /// <param name="req"><see cref="AddTopicRequest"/></param>
        /// <returns><see cref="AddTopicResponse"/></returns>
        public AddTopicResponse AddTopicSync(AddTopicRequest req)
        {
            return InternalRequestAsync<AddTopicResponse>(req, "AddTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为APP提供用户注册功能
        /// </summary>
        /// <param name="req"><see cref="AppAddUserRequest"/></param>
        /// <returns><see cref="AppAddUserResponse"/></returns>
        public Task<AppAddUserResponse> AppAddUser(AppAddUserRequest req)
        {
            return InternalRequestAsync<AppAddUserResponse>(req, "AppAddUser");
        }

        /// <summary>
        /// 为APP提供用户注册功能
        /// </summary>
        /// <param name="req"><see cref="AppAddUserRequest"/></param>
        /// <returns><see cref="AppAddUserResponse"/></returns>
        public AppAddUserResponse AppAddUserSync(AppAddUserRequest req)
        {
            return InternalRequestAsync<AppAddUserResponse>(req, "AppAddUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户解除与设备的关联关系，解除后APP用户无法控制设备，获取设备数据
        /// </summary>
        /// <param name="req"><see cref="AppDeleteDeviceRequest"/></param>
        /// <returns><see cref="AppDeleteDeviceResponse"/></returns>
        public Task<AppDeleteDeviceResponse> AppDeleteDevice(AppDeleteDeviceRequest req)
        {
            return InternalRequestAsync<AppDeleteDeviceResponse>(req, "AppDeleteDevice");
        }

        /// <summary>
        /// 用户解除与设备的关联关系，解除后APP用户无法控制设备，获取设备数据
        /// </summary>
        /// <param name="req"><see cref="AppDeleteDeviceRequest"/></param>
        /// <returns><see cref="AppDeleteDeviceResponse"/></returns>
        public AppDeleteDeviceResponse AppDeleteDeviceSync(AppDeleteDeviceRequest req)
        {
            return InternalRequestAsync<AppDeleteDeviceResponse>(req, "AppDeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取绑定设备的基本信息与数据模板定义
        /// </summary>
        /// <param name="req"><see cref="AppGetDeviceRequest"/></param>
        /// <returns><see cref="AppGetDeviceResponse"/></returns>
        public Task<AppGetDeviceResponse> AppGetDevice(AppGetDeviceRequest req)
        {
            return InternalRequestAsync<AppGetDeviceResponse>(req, "AppGetDevice");
        }

        /// <summary>
        /// 获取绑定设备的基本信息与数据模板定义
        /// </summary>
        /// <param name="req"><see cref="AppGetDeviceRequest"/></param>
        /// <returns><see cref="AppGetDeviceResponse"/></returns>
        public AppGetDeviceResponse AppGetDeviceSync(AppGetDeviceRequest req)
        {
            return InternalRequestAsync<AppGetDeviceResponse>(req, "AppGetDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取绑定设备数据，用于实时展示设备的最新数据
        /// </summary>
        /// <param name="req"><see cref="AppGetDeviceDataRequest"/></param>
        /// <returns><see cref="AppGetDeviceDataResponse"/></returns>
        public Task<AppGetDeviceDataResponse> AppGetDeviceData(AppGetDeviceDataRequest req)
        {
            return InternalRequestAsync<AppGetDeviceDataResponse>(req, "AppGetDeviceData");
        }

        /// <summary>
        /// 获取绑定设备数据，用于实时展示设备的最新数据
        /// </summary>
        /// <param name="req"><see cref="AppGetDeviceDataRequest"/></param>
        /// <returns><see cref="AppGetDeviceDataResponse"/></returns>
        public AppGetDeviceDataResponse AppGetDeviceDataSync(AppGetDeviceDataRequest req)
        {
            return InternalRequestAsync<AppGetDeviceDataResponse>(req, "AppGetDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取绑定设备的上下线状态
        /// </summary>
        /// <param name="req"><see cref="AppGetDeviceStatusesRequest"/></param>
        /// <returns><see cref="AppGetDeviceStatusesResponse"/></returns>
        public Task<AppGetDeviceStatusesResponse> AppGetDeviceStatuses(AppGetDeviceStatusesRequest req)
        {
            return InternalRequestAsync<AppGetDeviceStatusesResponse>(req, "AppGetDeviceStatuses");
        }

        /// <summary>
        /// 获取绑定设备的上下线状态
        /// </summary>
        /// <param name="req"><see cref="AppGetDeviceStatusesRequest"/></param>
        /// <returns><see cref="AppGetDeviceStatusesResponse"/></returns>
        public AppGetDeviceStatusesResponse AppGetDeviceStatusesSync(AppGetDeviceStatusesRequest req)
        {
            return InternalRequestAsync<AppGetDeviceStatusesResponse>(req, "AppGetDeviceStatuses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户的绑定设备列表
        /// </summary>
        /// <param name="req"><see cref="AppGetDevicesRequest"/></param>
        /// <returns><see cref="AppGetDevicesResponse"/></returns>
        public Task<AppGetDevicesResponse> AppGetDevices(AppGetDevicesRequest req)
        {
            return InternalRequestAsync<AppGetDevicesResponse>(req, "AppGetDevices");
        }

        /// <summary>
        /// 获取用户的绑定设备列表
        /// </summary>
        /// <param name="req"><see cref="AppGetDevicesRequest"/></param>
        /// <returns><see cref="AppGetDevicesResponse"/></returns>
        public AppGetDevicesResponse AppGetDevicesSync(AppGetDevicesRequest req)
        {
            return InternalRequestAsync<AppGetDevicesResponse>(req, "AppGetDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户token
        /// </summary>
        /// <param name="req"><see cref="AppGetTokenRequest"/></param>
        /// <returns><see cref="AppGetTokenResponse"/></returns>
        public Task<AppGetTokenResponse> AppGetToken(AppGetTokenRequest req)
        {
            return InternalRequestAsync<AppGetTokenResponse>(req, "AppGetToken");
        }

        /// <summary>
        /// 获取用户token
        /// </summary>
        /// <param name="req"><see cref="AppGetTokenRequest"/></param>
        /// <returns><see cref="AppGetTokenResponse"/></returns>
        public AppGetTokenResponse AppGetTokenSync(AppGetTokenRequest req)
        {
            return InternalRequestAsync<AppGetTokenResponse>(req, "AppGetToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="AppGetUserRequest"/></param>
        /// <returns><see cref="AppGetUserResponse"/></returns>
        public Task<AppGetUserResponse> AppGetUser(AppGetUserRequest req)
        {
            return InternalRequestAsync<AppGetUserResponse>(req, "AppGetUser");
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="AppGetUserRequest"/></param>
        /// <returns><see cref="AppGetUserResponse"/></returns>
        public AppGetUserResponse AppGetUserSync(AppGetUserRequest req)
        {
            return InternalRequestAsync<AppGetUserResponse>(req, "AppGetUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户通过APP控制设备
        /// </summary>
        /// <param name="req"><see cref="AppIssueDeviceControlRequest"/></param>
        /// <returns><see cref="AppIssueDeviceControlResponse"/></returns>
        public Task<AppIssueDeviceControlResponse> AppIssueDeviceControl(AppIssueDeviceControlRequest req)
        {
            return InternalRequestAsync<AppIssueDeviceControlResponse>(req, "AppIssueDeviceControl");
        }

        /// <summary>
        /// 用户通过APP控制设备
        /// </summary>
        /// <param name="req"><see cref="AppIssueDeviceControlRequest"/></param>
        /// <returns><see cref="AppIssueDeviceControlResponse"/></returns>
        public AppIssueDeviceControlResponse AppIssueDeviceControlSync(AppIssueDeviceControlRequest req)
        {
            return InternalRequestAsync<AppIssueDeviceControlResponse>(req, "AppIssueDeviceControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置APP用户密码
        /// </summary>
        /// <param name="req"><see cref="AppResetPasswordRequest"/></param>
        /// <returns><see cref="AppResetPasswordResponse"/></returns>
        public Task<AppResetPasswordResponse> AppResetPassword(AppResetPasswordRequest req)
        {
            return InternalRequestAsync<AppResetPasswordResponse>(req, "AppResetPassword");
        }

        /// <summary>
        /// 重置APP用户密码
        /// </summary>
        /// <param name="req"><see cref="AppResetPasswordRequest"/></param>
        /// <returns><see cref="AppResetPasswordResponse"/></returns>
        public AppResetPasswordResponse AppResetPasswordSync(AppResetPasswordRequest req)
        {
            return InternalRequestAsync<AppResetPasswordResponse>(req, "AppResetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户绑定设备，绑定后可以在APP端进行控制。绑定设备前需调用“获取设备绑定签名”接口
        /// </summary>
        /// <param name="req"><see cref="AppSecureAddDeviceRequest"/></param>
        /// <returns><see cref="AppSecureAddDeviceResponse"/></returns>
        public Task<AppSecureAddDeviceResponse> AppSecureAddDevice(AppSecureAddDeviceRequest req)
        {
            return InternalRequestAsync<AppSecureAddDeviceResponse>(req, "AppSecureAddDevice");
        }

        /// <summary>
        /// 用户绑定设备，绑定后可以在APP端进行控制。绑定设备前需调用“获取设备绑定签名”接口
        /// </summary>
        /// <param name="req"><see cref="AppSecureAddDeviceRequest"/></param>
        /// <returns><see cref="AppSecureAddDeviceResponse"/></returns>
        public AppSecureAddDeviceResponse AppSecureAddDeviceSync(AppSecureAddDeviceRequest req)
        {
            return InternalRequestAsync<AppSecureAddDeviceResponse>(req, "AppSecureAddDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改设备别名，便于用户个性化定义设备的名称
        /// </summary>
        /// <param name="req"><see cref="AppUpdateDeviceRequest"/></param>
        /// <returns><see cref="AppUpdateDeviceResponse"/></returns>
        public Task<AppUpdateDeviceResponse> AppUpdateDevice(AppUpdateDeviceRequest req)
        {
            return InternalRequestAsync<AppUpdateDeviceResponse>(req, "AppUpdateDevice");
        }

        /// <summary>
        /// 修改设备别名，便于用户个性化定义设备的名称
        /// </summary>
        /// <param name="req"><see cref="AppUpdateDeviceRequest"/></param>
        /// <returns><see cref="AppUpdateDeviceResponse"/></returns>
        public AppUpdateDeviceResponse AppUpdateDeviceSync(AppUpdateDeviceRequest req)
        {
            return InternalRequestAsync<AppUpdateDeviceResponse>(req, "AppUpdateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="AppUpdateUserRequest"/></param>
        /// <returns><see cref="AppUpdateUserResponse"/></returns>
        public Task<AppUpdateUserResponse> AppUpdateUser(AppUpdateUserRequest req)
        {
            return InternalRequestAsync<AppUpdateUserResponse>(req, "AppUpdateUser");
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="AppUpdateUserRequest"/></param>
        /// <returns><see cref="AppUpdateUserResponse"/></returns>
        public AppUpdateUserResponse AppUpdateUserSync(AppUpdateUserRequest req)
        {
            return InternalRequestAsync<AppUpdateUserResponse>(req, "AppUpdateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关联子设备产品和网关产品
        /// </summary>
        /// <param name="req"><see cref="AssociateSubDeviceToGatewayProductRequest"/></param>
        /// <returns><see cref="AssociateSubDeviceToGatewayProductResponse"/></returns>
        public Task<AssociateSubDeviceToGatewayProductResponse> AssociateSubDeviceToGatewayProduct(AssociateSubDeviceToGatewayProductRequest req)
        {
            return InternalRequestAsync<AssociateSubDeviceToGatewayProductResponse>(req, "AssociateSubDeviceToGatewayProduct");
        }

        /// <summary>
        /// 关联子设备产品和网关产品
        /// </summary>
        /// <param name="req"><see cref="AssociateSubDeviceToGatewayProductRequest"/></param>
        /// <returns><see cref="AssociateSubDeviceToGatewayProductResponse"/></returns>
        public AssociateSubDeviceToGatewayProductResponse AssociateSubDeviceToGatewayProductSync(AssociateSubDeviceToGatewayProductRequest req)
        {
            return InternalRequestAsync<AssociateSubDeviceToGatewayProductResponse>(req, "AssociateSubDeviceToGatewayProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 禁用规则
        /// </summary>
        /// <param name="req"><see cref="DeactivateRuleRequest"/></param>
        /// <returns><see cref="DeactivateRuleResponse"/></returns>
        public Task<DeactivateRuleResponse> DeactivateRule(DeactivateRuleRequest req)
        {
            return InternalRequestAsync<DeactivateRuleResponse>(req, "DeactivateRule");
        }

        /// <summary>
        /// 禁用规则
        /// </summary>
        /// <param name="req"><see cref="DeactivateRuleRequest"/></param>
        /// <returns><see cref="DeactivateRuleResponse"/></returns>
        public DeactivateRuleResponse DeactivateRuleSync(DeactivateRuleRequest req)
        {
            return InternalRequestAsync<DeactivateRuleResponse>(req, "DeactivateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供在指定的产品Id下删除一个设备的能力。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// 提供在指定的产品Id下删除一个设备的能力。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户指定的产品Id对应的信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct");
        }

        /// <summary>
        /// 删除用户指定的产品Id对应的信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Topic
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// 删除Topic
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取设备某一段时间范围的设备上报数据。该接口适用于使用高级版类型的产品
        /// </summary>
        /// <param name="req"><see cref="GetDataHistoryRequest"/></param>
        /// <returns><see cref="GetDataHistoryResponse"/></returns>
        public Task<GetDataHistoryResponse> GetDataHistory(GetDataHistoryRequest req)
        {
            return InternalRequestAsync<GetDataHistoryResponse>(req, "GetDataHistory");
        }

        /// <summary>
        /// 批量获取设备某一段时间范围的设备上报数据。该接口适用于使用高级版类型的产品
        /// </summary>
        /// <param name="req"><see cref="GetDataHistoryRequest"/></param>
        /// <returns><see cref="GetDataHistoryResponse"/></returns>
        public GetDataHistoryResponse GetDataHistorySync(GetDataHistoryRequest req)
        {
            return InternalRequestAsync<GetDataHistoryResponse>(req, "GetDataHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备的调试日志，用于定位问题
        /// </summary>
        /// <param name="req"><see cref="GetDebugLogRequest"/></param>
        /// <returns><see cref="GetDebugLogResponse"/></returns>
        public Task<GetDebugLogResponse> GetDebugLog(GetDebugLogRequest req)
        {
            return InternalRequestAsync<GetDebugLogResponse>(req, "GetDebugLog");
        }

        /// <summary>
        /// 获取设备的调试日志，用于定位问题
        /// </summary>
        /// <param name="req"><see cref="GetDebugLogRequest"/></param>
        /// <returns><see cref="GetDebugLogResponse"/></returns>
        public GetDebugLogResponse GetDebugLogSync(GetDebugLogRequest req)
        {
            return InternalRequestAsync<GetDebugLogResponse>(req, "GetDebugLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供查询某个设备详细信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public Task<GetDeviceResponse> GetDevice(GetDeviceRequest req)
        {
            return InternalRequestAsync<GetDeviceResponse>(req, "GetDevice");
        }

        /// <summary>
        /// 提供查询某个设备详细信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public GetDeviceResponse GetDeviceSync(GetDeviceRequest req)
        {
            return InternalRequestAsync<GetDeviceResponse>(req, "GetDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某个设备当前上报到云端的数据，该接口适用于使用数据模板协议的产品。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceDataRequest"/></param>
        /// <returns><see cref="GetDeviceDataResponse"/></returns>
        public Task<GetDeviceDataResponse> GetDeviceData(GetDeviceDataRequest req)
        {
            return InternalRequestAsync<GetDeviceDataResponse>(req, "GetDeviceData");
        }

        /// <summary>
        /// 获取某个设备当前上报到云端的数据，该接口适用于使用数据模板协议的产品。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceDataRequest"/></param>
        /// <returns><see cref="GetDeviceDataResponse"/></returns>
        public GetDeviceDataResponse GetDeviceDataSync(GetDeviceDataRequest req)
        {
            return InternalRequestAsync<GetDeviceDataResponse>(req, "GetDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取设备与云端的详细通信日志，该接口适用于使用高级版类型的产品。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLogRequest"/></param>
        /// <returns><see cref="GetDeviceLogResponse"/></returns>
        public Task<GetDeviceLogResponse> GetDeviceLog(GetDeviceLogRequest req)
        {
            return InternalRequestAsync<GetDeviceLogResponse>(req, "GetDeviceLog");
        }

        /// <summary>
        /// 批量获取设备与云端的详细通信日志，该接口适用于使用高级版类型的产品。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLogRequest"/></param>
        /// <returns><see cref="GetDeviceLogResponse"/></returns>
        public GetDeviceLogResponse GetDeviceLogSync(GetDeviceLogRequest req)
        {
            return InternalRequestAsync<GetDeviceLogResponse>(req, "GetDeviceLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备绑定签名，用于用户绑定某个设备的应用场景
        /// </summary>
        /// <param name="req"><see cref="GetDeviceSignaturesRequest"/></param>
        /// <returns><see cref="GetDeviceSignaturesResponse"/></returns>
        public Task<GetDeviceSignaturesResponse> GetDeviceSignatures(GetDeviceSignaturesRequest req)
        {
            return InternalRequestAsync<GetDeviceSignaturesResponse>(req, "GetDeviceSignatures");
        }

        /// <summary>
        /// 获取设备绑定签名，用于用户绑定某个设备的应用场景
        /// </summary>
        /// <param name="req"><see cref="GetDeviceSignaturesRequest"/></param>
        /// <returns><see cref="GetDeviceSignaturesResponse"/></returns>
        public GetDeviceSignaturesResponse GetDeviceSignaturesSync(GetDeviceSignaturesRequest req)
        {
            return InternalRequestAsync<GetDeviceSignaturesResponse>(req, "GetDeviceSignatures")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某段时间范围内产品的在线、激活设备数
        /// </summary>
        /// <param name="req"><see cref="GetDeviceStatisticsRequest"/></param>
        /// <returns><see cref="GetDeviceStatisticsResponse"/></returns>
        public Task<GetDeviceStatisticsResponse> GetDeviceStatistics(GetDeviceStatisticsRequest req)
        {
            return InternalRequestAsync<GetDeviceStatisticsResponse>(req, "GetDeviceStatistics");
        }

        /// <summary>
        /// 查询某段时间范围内产品的在线、激活设备数
        /// </summary>
        /// <param name="req"><see cref="GetDeviceStatisticsRequest"/></param>
        /// <returns><see cref="GetDeviceStatisticsResponse"/></returns>
        public GetDeviceStatisticsResponse GetDeviceStatisticsSync(GetDeviceStatisticsRequest req)
        {
            return InternalRequestAsync<GetDeviceStatisticsResponse>(req, "GetDeviceStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取设备的当前状态，状态包括在线、离线或未激活状态。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceStatusesRequest"/></param>
        /// <returns><see cref="GetDeviceStatusesResponse"/></returns>
        public Task<GetDeviceStatusesResponse> GetDeviceStatuses(GetDeviceStatusesRequest req)
        {
            return InternalRequestAsync<GetDeviceStatusesResponse>(req, "GetDeviceStatuses");
        }

        /// <summary>
        /// 批量获取设备的当前状态，状态包括在线、离线或未激活状态。
        /// </summary>
        /// <param name="req"><see cref="GetDeviceStatusesRequest"/></param>
        /// <returns><see cref="GetDeviceStatusesResponse"/></returns>
        public GetDeviceStatusesResponse GetDeviceStatusesSync(GetDeviceStatusesRequest req)
        {
            return InternalRequestAsync<GetDeviceStatusesResponse>(req, "GetDeviceStatuses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供分页查询某个产品Id下设备信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public Task<GetDevicesResponse> GetDevices(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices");
        }

        /// <summary>
        /// 提供分页查询某个产品Id下设备信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public GetDevicesResponse GetDevicesSync(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品定义的详细信息，包括产品名称、产品描述，鉴权模式等信息。
        /// </summary>
        /// <param name="req"><see cref="GetProductRequest"/></param>
        /// <returns><see cref="GetProductResponse"/></returns>
        public Task<GetProductResponse> GetProduct(GetProductRequest req)
        {
            return InternalRequestAsync<GetProductResponse>(req, "GetProduct");
        }

        /// <summary>
        /// 获取产品定义的详细信息，包括产品名称、产品描述，鉴权模式等信息。
        /// </summary>
        /// <param name="req"><see cref="GetProductRequest"/></param>
        /// <returns><see cref="GetProductResponse"/></returns>
        public GetProductResponse GetProductSync(GetProductRequest req)
        {
            return InternalRequestAsync<GetProductResponse>(req, "GetProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户在物联网套件所创建的所有产品信息。
        /// </summary>
        /// <param name="req"><see cref="GetProductsRequest"/></param>
        /// <returns><see cref="GetProductsResponse"/></returns>
        public Task<GetProductsResponse> GetProducts(GetProductsRequest req)
        {
            return InternalRequestAsync<GetProductsResponse>(req, "GetProducts");
        }

        /// <summary>
        /// 获取用户在物联网套件所创建的所有产品信息。
        /// </summary>
        /// <param name="req"><see cref="GetProductsRequest"/></param>
        /// <returns><see cref="GetProductsResponse"/></returns>
        public GetProductsResponse GetProductsSync(GetProductsRequest req)
        {
            return InternalRequestAsync<GetProductsResponse>(req, "GetProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取转发规则信息
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public Task<GetRuleResponse> GetRule(GetRuleRequest req)
        {
            return InternalRequestAsync<GetRuleResponse>(req, "GetRule");
        }

        /// <summary>
        /// 获取转发规则信息
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public GetRuleResponse GetRuleSync(GetRuleRequest req)
        {
            return InternalRequestAsync<GetRuleResponse>(req, "GetRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取转发规则列表
        /// </summary>
        /// <param name="req"><see cref="GetRulesRequest"/></param>
        /// <returns><see cref="GetRulesResponse"/></returns>
        public Task<GetRulesResponse> GetRules(GetRulesRequest req)
        {
            return InternalRequestAsync<GetRulesResponse>(req, "GetRules");
        }

        /// <summary>
        /// 获取转发规则列表
        /// </summary>
        /// <param name="req"><see cref="GetRulesRequest"/></param>
        /// <returns><see cref="GetRulesResponse"/></returns>
        public GetRulesResponse GetRulesSync(GetRulesRequest req)
        {
            return InternalRequestAsync<GetRulesResponse>(req, "GetRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Topic信息
        /// </summary>
        /// <param name="req"><see cref="GetTopicRequest"/></param>
        /// <returns><see cref="GetTopicResponse"/></returns>
        public Task<GetTopicResponse> GetTopic(GetTopicRequest req)
        {
            return InternalRequestAsync<GetTopicResponse>(req, "GetTopic");
        }

        /// <summary>
        /// 获取Topic信息
        /// </summary>
        /// <param name="req"><see cref="GetTopicRequest"/></param>
        /// <returns><see cref="GetTopicResponse"/></returns>
        public GetTopicResponse GetTopicSync(GetTopicRequest req)
        {
            return InternalRequestAsync<GetTopicResponse>(req, "GetTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Topic列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicsRequest"/></param>
        /// <returns><see cref="GetTopicsResponse"/></returns>
        public Task<GetTopicsResponse> GetTopics(GetTopicsRequest req)
        {
            return InternalRequestAsync<GetTopicsResponse>(req, "GetTopics");
        }

        /// <summary>
        /// 获取Topic列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicsRequest"/></param>
        /// <returns><see cref="GetTopicsResponse"/></returns>
        public GetTopicsResponse GetTopicsSync(GetTopicsRequest req)
        {
            return InternalRequestAsync<GetTopicsResponse>(req, "GetTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供下发控制指令到指定设备的能力，该接口适用于使用高级版类型的产品。
        /// </summary>
        /// <param name="req"><see cref="IssueDeviceControlRequest"/></param>
        /// <returns><see cref="IssueDeviceControlResponse"/></returns>
        public Task<IssueDeviceControlResponse> IssueDeviceControl(IssueDeviceControlRequest req)
        {
            return InternalRequestAsync<IssueDeviceControlResponse>(req, "IssueDeviceControl");
        }

        /// <summary>
        /// 提供下发控制指令到指定设备的能力，该接口适用于使用高级版类型的产品。
        /// </summary>
        /// <param name="req"><see cref="IssueDeviceControlRequest"/></param>
        /// <returns><see cref="IssueDeviceControlResponse"/></returns>
        public IssueDeviceControlResponse IssueDeviceControlSync(IssueDeviceControlRequest req)
        {
            return InternalRequestAsync<IssueDeviceControlResponse>(req, "IssueDeviceControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供向指定的Topic发布消息的能力，常用于向设备下发控制指令。该接口只适用于产品版本为“基础版”类型的产品，使用高级版的产品需使用“下发设备控制指令”接口
        /// </summary>
        /// <param name="req"><see cref="PublishMsgRequest"/></param>
        /// <returns><see cref="PublishMsgResponse"/></returns>
        public Task<PublishMsgResponse> PublishMsg(PublishMsgRequest req)
        {
            return InternalRequestAsync<PublishMsgResponse>(req, "PublishMsg");
        }

        /// <summary>
        /// 提供向指定的Topic发布消息的能力，常用于向设备下发控制指令。该接口只适用于产品版本为“基础版”类型的产品，使用高级版的产品需使用“下发设备控制指令”接口
        /// </summary>
        /// <param name="req"><see cref="PublishMsgRequest"/></param>
        /// <returns><see cref="PublishMsgResponse"/></returns>
        public PublishMsgResponse PublishMsgSync(PublishMsgRequest req)
        {
            return InternalRequestAsync<PublishMsgResponse>(req, "PublishMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置设备操作，将会为设备生成新的证书及清空最新数据，需谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceRequest"/></param>
        /// <returns><see cref="ResetDeviceResponse"/></returns>
        public Task<ResetDeviceResponse> ResetDevice(ResetDeviceRequest req)
        {
            return InternalRequestAsync<ResetDeviceResponse>(req, "ResetDevice");
        }

        /// <summary>
        /// 重置设备操作，将会为设备生成新的证书及清空最新数据，需谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceRequest"/></param>
        /// <returns><see cref="ResetDeviceResponse"/></returns>
        public ResetDeviceResponse ResetDeviceSync(ResetDeviceRequest req)
        {
            return InternalRequestAsync<ResetDeviceResponse>(req, "ResetDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 业务无客户使用，下线接口。
        /// 
        /// 取消子设备产品与网关设备产品的关联
        /// </summary>
        /// <param name="req"><see cref="UnassociateSubDeviceFromGatewayProductRequest"/></param>
        /// <returns><see cref="UnassociateSubDeviceFromGatewayProductResponse"/></returns>
        public Task<UnassociateSubDeviceFromGatewayProductResponse> UnassociateSubDeviceFromGatewayProduct(UnassociateSubDeviceFromGatewayProductRequest req)
        {
            return InternalRequestAsync<UnassociateSubDeviceFromGatewayProductResponse>(req, "UnassociateSubDeviceFromGatewayProduct");
        }

        /// <summary>
        /// 业务无客户使用，下线接口。
        /// 
        /// 取消子设备产品与网关设备产品的关联
        /// </summary>
        /// <param name="req"><see cref="UnassociateSubDeviceFromGatewayProductRequest"/></param>
        /// <returns><see cref="UnassociateSubDeviceFromGatewayProductResponse"/></returns>
        public UnassociateSubDeviceFromGatewayProductResponse UnassociateSubDeviceFromGatewayProductSync(UnassociateSubDeviceFromGatewayProductRequest req)
        {
            return InternalRequestAsync<UnassociateSubDeviceFromGatewayProductResponse>(req, "UnassociateSubDeviceFromGatewayProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供修改产品信息及数据模板的能力。
        /// </summary>
        /// <param name="req"><see cref="UpdateProductRequest"/></param>
        /// <returns><see cref="UpdateProductResponse"/></returns>
        public Task<UpdateProductResponse> UpdateProduct(UpdateProductRequest req)
        {
            return InternalRequestAsync<UpdateProductResponse>(req, "UpdateProduct");
        }

        /// <summary>
        /// 提供修改产品信息及数据模板的能力。
        /// </summary>
        /// <param name="req"><see cref="UpdateProductRequest"/></param>
        /// <returns><see cref="UpdateProductResponse"/></returns>
        public UpdateProductResponse UpdateProductSync(UpdateProductRequest req)
        {
            return InternalRequestAsync<UpdateProductResponse>(req, "UpdateProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public Task<UpdateRuleResponse> UpdateRule(UpdateRuleRequest req)
        {
            return InternalRequestAsync<UpdateRuleResponse>(req, "UpdateRule");
        }

        /// <summary>
        /// 更新规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public UpdateRuleResponse UpdateRuleSync(UpdateRuleRequest req)
        {
            return InternalRequestAsync<UpdateRuleResponse>(req, "UpdateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
