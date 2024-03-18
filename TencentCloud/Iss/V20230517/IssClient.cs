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

namespace TencentCloud.Iss.V20230517
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iss.V20230517.Models;

   public class IssClient : AbstractClient{

       private const string endpoint = "iss.tencentcloudapi.com";
       private const string version = "2023-05-17";
       private const string sdkVersion = "SDK_NET_3.0.967";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加AI任务
        /// </summary>
        /// <param name="req"><see cref="AddAITaskRequest"/></param>
        /// <returns><see cref="AddAITaskResponse"/></returns>
        public Task<AddAITaskResponse> AddAITask(AddAITaskRequest req)
        {
            return InternalRequestAsync<AddAITaskResponse>(req, "AddAITask");
        }

        /// <summary>
        /// 添加AI任务
        /// </summary>
        /// <param name="req"><see cref="AddAITaskRequest"/></param>
        /// <returns><see cref="AddAITaskResponse"/></returns>
        public AddAITaskResponse AddAITaskSync(AddAITaskRequest req)
        {
            return InternalRequestAsync<AddAITaskResponse>(req, "AddAITask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新增组织。
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationRequest"/></param>
        /// <returns><see cref="AddOrganizationResponse"/></returns>
        public Task<AddOrganizationResponse> AddOrganization(AddOrganizationRequest req)
        {
            return InternalRequestAsync<AddOrganizationResponse>(req, "AddOrganization");
        }

        /// <summary>
        /// 用于新增组织。
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationRequest"/></param>
        /// <returns><see cref="AddOrganizationResponse"/></returns>
        public AddOrganizationResponse AddOrganizationSync(AddOrganizationRequest req)
        {
            return InternalRequestAsync<AddOrganizationResponse>(req, "AddOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新增录像上云计划 （当前仅适用于通过GB28181协议和网关接入的设备/视频通道）
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupPlanRequest"/></param>
        /// <returns><see cref="AddRecordBackupPlanResponse"/></returns>
        public Task<AddRecordBackupPlanResponse> AddRecordBackupPlan(AddRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<AddRecordBackupPlanResponse>(req, "AddRecordBackupPlan");
        }

        /// <summary>
        /// 用于新增录像上云计划 （当前仅适用于通过GB28181协议和网关接入的设备/视频通道）
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupPlanRequest"/></param>
        /// <returns><see cref="AddRecordBackupPlanResponse"/></returns>
        public AddRecordBackupPlanResponse AddRecordBackupPlanSync(AddRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<AddRecordBackupPlanResponse>(req, "AddRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新增录像上云模板。
        /// > 该功能本质是拉取设备本地录像数据上云（即存在 IPC 摄像头存储卡或 NVR 硬盘中的录像），操作时需先设定录像时间段（即想要上云的设备本地录像），再设定上云时间段和上云倍速，平台将于上云时间段倍速拉取设备对应前一天的录像时间段数据。
        /// 
        /// > 设定需至少满足（上云时间段=前一天的录像时间段/上云倍速），建议上云时间段可多设定10%左右的时间，避免因网络波动导致数据拉取不完整。
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="AddRecordBackupTemplateResponse"/></returns>
        public Task<AddRecordBackupTemplateResponse> AddRecordBackupTemplate(AddRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordBackupTemplateResponse>(req, "AddRecordBackupTemplate");
        }

        /// <summary>
        /// 用于新增录像上云模板。
        /// > 该功能本质是拉取设备本地录像数据上云（即存在 IPC 摄像头存储卡或 NVR 硬盘中的录像），操作时需先设定录像时间段（即想要上云的设备本地录像），再设定上云时间段和上云倍速，平台将于上云时间段倍速拉取设备对应前一天的录像时间段数据。
        /// 
        /// > 设定需至少满足（上云时间段=前一天的录像时间段/上云倍速），建议上云时间段可多设定10%左右的时间，避免因网络波动导致数据拉取不完整。
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="AddRecordBackupTemplateResponse"/></returns>
        public AddRecordBackupTemplateResponse AddRecordBackupTemplateSync(AddRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordBackupTemplateResponse>(req, "AddRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新增实时上云计划
        /// </summary>
        /// <param name="req"><see cref="AddRecordPlanRequest"/></param>
        /// <returns><see cref="AddRecordPlanResponse"/></returns>
        public Task<AddRecordPlanResponse> AddRecordPlan(AddRecordPlanRequest req)
        {
            return InternalRequestAsync<AddRecordPlanResponse>(req, "AddRecordPlan");
        }

        /// <summary>
        /// 用于新增实时上云计划
        /// </summary>
        /// <param name="req"><see cref="AddRecordPlanRequest"/></param>
        /// <returns><see cref="AddRecordPlanResponse"/></returns>
        public AddRecordPlanResponse AddRecordPlanSync(AddRecordPlanRequest req)
        {
            return InternalRequestAsync<AddRecordPlanResponse>(req, "AddRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新建取回任务
        /// </summary>
        /// <param name="req"><see cref="AddRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="AddRecordRetrieveTaskResponse"/></returns>
        public Task<AddRecordRetrieveTaskResponse> AddRecordRetrieveTask(AddRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<AddRecordRetrieveTaskResponse>(req, "AddRecordRetrieveTask");
        }

        /// <summary>
        /// 用于新建取回任务
        /// </summary>
        /// <param name="req"><see cref="AddRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="AddRecordRetrieveTaskResponse"/></returns>
        public AddRecordRetrieveTaskResponse AddRecordRetrieveTaskSync(AddRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<AddRecordRetrieveTaskResponse>(req, "AddRecordRetrieveTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新增实时上云模板
        /// </summary>
        /// <param name="req"><see cref="AddRecordTemplateRequest"/></param>
        /// <returns><see cref="AddRecordTemplateResponse"/></returns>
        public Task<AddRecordTemplateResponse> AddRecordTemplate(AddRecordTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordTemplateResponse>(req, "AddRecordTemplate");
        }

        /// <summary>
        /// 用于新增实时上云模板
        /// </summary>
        /// <param name="req"><see cref="AddRecordTemplateRequest"/></param>
        /// <returns><see cref="AddRecordTemplateResponse"/></returns>
        public AddRecordTemplateResponse AddRecordTemplateSync(AddRecordTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordTemplateResponse>(req, "AddRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于设置推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="AddStreamAuthRequest"/></param>
        /// <returns><see cref="AddStreamAuthResponse"/></returns>
        public Task<AddStreamAuthResponse> AddStreamAuth(AddStreamAuthRequest req)
        {
            return InternalRequestAsync<AddStreamAuthResponse>(req, "AddStreamAuth");
        }

        /// <summary>
        /// 用于设置推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="AddStreamAuthRequest"/></param>
        /// <returns><see cref="AddStreamAuthResponse"/></returns>
        public AddStreamAuthResponse AddStreamAuthSync(AddStreamAuthRequest req)
        {
            return InternalRequestAsync<AddStreamAuthResponse>(req, "AddStreamAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于新增单个设备。添加设备之后，可根据返回结果到设备上进行配置，配置后等待设备注册/推流。
        /// </summary>
        /// <param name="req"><see cref="AddUserDeviceRequest"/></param>
        /// <returns><see cref="AddUserDeviceResponse"/></returns>
        public Task<AddUserDeviceResponse> AddUserDevice(AddUserDeviceRequest req)
        {
            return InternalRequestAsync<AddUserDeviceResponse>(req, "AddUserDevice");
        }

        /// <summary>
        /// 用于新增单个设备。添加设备之后，可根据返回结果到设备上进行配置，配置后等待设备注册/推流。
        /// </summary>
        /// <param name="req"><see cref="AddUserDeviceRequest"/></param>
        /// <returns><see cref="AddUserDeviceResponse"/></returns>
        public AddUserDeviceResponse AddUserDeviceSync(AddUserDeviceRequest req)
        {
            return InternalRequestAsync<AddUserDeviceResponse>(req, "AddUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量操作（启用，禁用，删除）设备
        /// </summary>
        /// <param name="req"><see cref="BatchOperateDeviceRequest"/></param>
        /// <returns><see cref="BatchOperateDeviceResponse"/></returns>
        public Task<BatchOperateDeviceResponse> BatchOperateDevice(BatchOperateDeviceRequest req)
        {
            return InternalRequestAsync<BatchOperateDeviceResponse>(req, "BatchOperateDevice");
        }

        /// <summary>
        /// 用于批量操作（启用，禁用，删除）设备
        /// </summary>
        /// <param name="req"><see cref="BatchOperateDeviceRequest"/></param>
        /// <returns><see cref="BatchOperateDeviceResponse"/></returns>
        public BatchOperateDeviceResponse BatchOperateDeviceSync(BatchOperateDeviceRequest req)
        {
            return InternalRequestAsync<BatchOperateDeviceResponse>(req, "BatchOperateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于检测域名是否备案。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public Task<CheckDomainResponse> CheckDomain(CheckDomainRequest req)
        {
            return InternalRequestAsync<CheckDomainResponse>(req, "CheckDomain");
        }

        /// <summary>
        /// 用于检测域名是否备案。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public CheckDomainResponse CheckDomainSync(CheckDomainRequest req)
        {
            return InternalRequestAsync<CheckDomainResponse>(req, "CheckDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于设备通道云台控制，包括转动、变倍、变焦、光圈等。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public Task<ControlDevicePTZResponse> ControlDevicePTZ(ControlDevicePTZRequest req)
        {
            return InternalRequestAsync<ControlDevicePTZResponse>(req, "ControlDevicePTZ");
        }

        /// <summary>
        /// 用于设备通道云台控制，包括转动、变倍、变焦、光圈等。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public ControlDevicePTZResponse ControlDevicePTZSync(ControlDevicePTZRequest req)
        {
            return InternalRequestAsync<ControlDevicePTZResponse>(req, "ControlDevicePTZ")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于操作设备预置位，包括设置、删除、调用。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePresetRequest"/></param>
        /// <returns><see cref="ControlDevicePresetResponse"/></returns>
        public Task<ControlDevicePresetResponse> ControlDevicePreset(ControlDevicePresetRequest req)
        {
            return InternalRequestAsync<ControlDevicePresetResponse>(req, "ControlDevicePreset");
        }

        /// <summary>
        /// 用于操作设备预置位，包括设置、删除、调用。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePresetRequest"/></param>
        /// <returns><see cref="ControlDevicePresetResponse"/></returns>
        public ControlDevicePresetResponse ControlDevicePresetSync(ControlDevicePresetRequest req)
        {
            return InternalRequestAsync<ControlDevicePresetResponse>(req, "ControlDevicePreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取设备的实时开流地址。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceStreamRequest"/></param>
        /// <returns><see cref="ControlDeviceStreamResponse"/></returns>
        public Task<ControlDeviceStreamResponse> ControlDeviceStream(ControlDeviceStreamRequest req)
        {
            return InternalRequestAsync<ControlDeviceStreamResponse>(req, "ControlDeviceStream");
        }

        /// <summary>
        /// 用于获取设备的实时开流地址。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceStreamRequest"/></param>
        /// <returns><see cref="ControlDeviceStreamResponse"/></returns>
        public ControlDeviceStreamResponse ControlDeviceStreamSync(ControlDeviceStreamRequest req)
        {
            return InternalRequestAsync<ControlDeviceStreamResponse>(req, "ControlDeviceStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于录像回放过程中的倍速、跳转、播放/暂停/停止等控制。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordRequest"/></param>
        /// <returns><see cref="ControlRecordResponse"/></returns>
        public Task<ControlRecordResponse> ControlRecord(ControlRecordRequest req)
        {
            return InternalRequestAsync<ControlRecordResponse>(req, "ControlRecord");
        }

        /// <summary>
        /// 用于录像回放过程中的倍速、跳转、播放/暂停/停止等控制。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordRequest"/></param>
        /// <returns><see cref="ControlRecordResponse"/></returns>
        public ControlRecordResponse ControlRecordSync(ControlRecordRequest req)
        {
            return InternalRequestAsync<ControlRecordResponse>(req, "ControlRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询设备本地录像时间轴信息，为NVR/IPC本地存储的录像。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordTimelineRequest"/></param>
        /// <returns><see cref="ControlRecordTimelineResponse"/></returns>
        public Task<ControlRecordTimelineResponse> ControlRecordTimeline(ControlRecordTimelineRequest req)
        {
            return InternalRequestAsync<ControlRecordTimelineResponse>(req, "ControlRecordTimeline");
        }

        /// <summary>
        /// 用于查询设备本地录像时间轴信息，为NVR/IPC本地存储的录像。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordTimelineRequest"/></param>
        /// <returns><see cref="ControlRecordTimelineResponse"/></returns>
        public ControlRecordTimelineResponse ControlRecordTimelineSync(ControlRecordTimelineRequest req)
        {
            return InternalRequestAsync<ControlRecordTimelineResponse>(req, "ControlRecordTimeline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除AI任务
        /// </summary>
        /// <param name="req"><see cref="DeleteAITaskRequest"/></param>
        /// <returns><see cref="DeleteAITaskResponse"/></returns>
        public Task<DeleteAITaskResponse> DeleteAITask(DeleteAITaskRequest req)
        {
            return InternalRequestAsync<DeleteAITaskResponse>(req, "DeleteAITask");
        }

        /// <summary>
        /// 删除AI任务
        /// </summary>
        /// <param name="req"><see cref="DeleteAITaskRequest"/></param>
        /// <returns><see cref="DeleteAITaskResponse"/></returns>
        public DeleteAITaskResponse DeleteAITaskSync(DeleteAITaskRequest req)
        {
            return InternalRequestAsync<DeleteAITaskResponse>(req, "DeleteAITask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain");
        }

        /// <summary>
        /// 用于删除域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayRequest"/></param>
        /// <returns><see cref="DeleteGatewayResponse"/></returns>
        public Task<DeleteGatewayResponse> DeleteGateway(DeleteGatewayRequest req)
        {
            return InternalRequestAsync<DeleteGatewayResponse>(req, "DeleteGateway");
        }

        /// <summary>
        /// 用于删除网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayRequest"/></param>
        /// <returns><see cref="DeleteGatewayResponse"/></returns>
        public DeleteGatewayResponse DeleteGatewaySync(DeleteGatewayRequest req)
        {
            return InternalRequestAsync<DeleteGatewayResponse>(req, "DeleteGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除组织。
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public Task<DeleteOrganizationResponse> DeleteOrganization(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization");
        }

        /// <summary>
        /// 用于删除组织。
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public DeleteOrganizationResponse DeleteOrganizationSync(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupPlanResponse"/></returns>
        public Task<DeleteRecordBackupPlanResponse> DeleteRecordBackupPlan(DeleteRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupPlanResponse>(req, "DeleteRecordBackupPlan");
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupPlanResponse"/></returns>
        public DeleteRecordBackupPlanResponse DeleteRecordBackupPlanSync(DeleteRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupPlanResponse>(req, "DeleteRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupTemplateResponse"/></returns>
        public Task<DeleteRecordBackupTemplateResponse> DeleteRecordBackupTemplate(DeleteRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupTemplateResponse>(req, "DeleteRecordBackupTemplate");
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupTemplateResponse"/></returns>
        public DeleteRecordBackupTemplateResponse DeleteRecordBackupTemplateSync(DeleteRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupTemplateResponse>(req, "DeleteRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除实时上云计划
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordPlanResponse"/></returns>
        public Task<DeleteRecordPlanResponse> DeleteRecordPlan(DeleteRecordPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordPlanResponse>(req, "DeleteRecordPlan");
        }

        /// <summary>
        /// 用于删除实时上云计划
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordPlanResponse"/></returns>
        public DeleteRecordPlanResponse DeleteRecordPlanSync(DeleteRecordPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordPlanResponse>(req, "DeleteRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除取回任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordRetrieveTaskResponse"/></returns>
        public Task<DeleteRecordRetrieveTaskResponse> DeleteRecordRetrieveTask(DeleteRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordRetrieveTaskResponse>(req, "DeleteRecordRetrieveTask");
        }

        /// <summary>
        /// 用于删除取回任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordRetrieveTaskResponse"/></returns>
        public DeleteRecordRetrieveTaskResponse DeleteRecordRetrieveTaskSync(DeleteRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordRetrieveTaskResponse>(req, "DeleteRecordRetrieveTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除实时上云模板
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordTemplateResponse"/></returns>
        public Task<DeleteRecordTemplateResponse> DeleteRecordTemplate(DeleteRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordTemplateResponse>(req, "DeleteRecordTemplate");
        }

        /// <summary>
        /// 用于删除实时上云模板
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordTemplateResponse"/></returns>
        public DeleteRecordTemplateResponse DeleteRecordTemplateSync(DeleteRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordTemplateResponse>(req, "DeleteRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除已添加的设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteUserDeviceRequest"/></param>
        /// <returns><see cref="DeleteUserDeviceResponse"/></returns>
        public Task<DeleteUserDeviceResponse> DeleteUserDevice(DeleteUserDeviceRequest req)
        {
            return InternalRequestAsync<DeleteUserDeviceResponse>(req, "DeleteUserDevice");
        }

        /// <summary>
        /// 用于删除已添加的设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteUserDeviceRequest"/></param>
        /// <returns><see cref="DeleteUserDeviceResponse"/></returns>
        public DeleteUserDeviceResponse DeleteUserDeviceSync(DeleteUserDeviceRequest req)
        {
            return InternalRequestAsync<DeleteUserDeviceResponse>(req, "DeleteUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取AI任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskRequest"/></param>
        /// <returns><see cref="DescribeAITaskResponse"/></returns>
        public Task<DescribeAITaskResponse> DescribeAITask(DescribeAITaskRequest req)
        {
            return InternalRequestAsync<DescribeAITaskResponse>(req, "DescribeAITask");
        }

        /// <summary>
        /// 获取AI任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskRequest"/></param>
        /// <returns><see cref="DescribeAITaskResponse"/></returns>
        public DescribeAITaskResponse DescribeAITaskSync(DescribeAITaskRequest req)
        {
            return InternalRequestAsync<DescribeAITaskResponse>(req, "DescribeAITask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取AI任务识别结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskResultRequest"/></param>
        /// <returns><see cref="DescribeAITaskResultResponse"/></returns>
        public Task<DescribeAITaskResultResponse> DescribeAITaskResult(DescribeAITaskResultRequest req)
        {
            return InternalRequestAsync<DescribeAITaskResultResponse>(req, "DescribeAITaskResult");
        }

        /// <summary>
        /// 获取AI任务识别结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskResultRequest"/></param>
        /// <returns><see cref="DescribeAITaskResultResponse"/></returns>
        public DescribeAITaskResultResponse DescribeAITaskResultSync(DescribeAITaskResultRequest req)
        {
            return InternalRequestAsync<DescribeAITaskResultResponse>(req, "DescribeAITaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于根据服务节点获取 CNAME 值。
        /// </summary>
        /// <param name="req"><see cref="DescribeCNAMERequest"/></param>
        /// <returns><see cref="DescribeCNAMEResponse"/></returns>
        public Task<DescribeCNAMEResponse> DescribeCNAME(DescribeCNAMERequest req)
        {
            return InternalRequestAsync<DescribeCNAMEResponse>(req, "DescribeCNAME");
        }

        /// <summary>
        /// 用于根据服务节点获取 CNAME 值。
        /// </summary>
        /// <param name="req"><see cref="DescribeCNAMERequest"/></param>
        /// <returns><see cref="DescribeCNAMEResponse"/></returns>
        public DescribeCNAMEResponse DescribeCNAMESync(DescribeCNAMERequest req)
        {
            return InternalRequestAsync<DescribeCNAMEResponse>(req, "DescribeCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询设备的通道。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChannelRequest"/></param>
        /// <returns><see cref="DescribeDeviceChannelResponse"/></returns>
        public Task<DescribeDeviceChannelResponse> DescribeDeviceChannel(DescribeDeviceChannelRequest req)
        {
            return InternalRequestAsync<DescribeDeviceChannelResponse>(req, "DescribeDeviceChannel");
        }

        /// <summary>
        /// 用于查询设备的通道。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChannelRequest"/></param>
        /// <returns><see cref="DescribeDeviceChannelResponse"/></returns>
        public DescribeDeviceChannelResponse DescribeDeviceChannelSync(DescribeDeviceChannelRequest req)
        {
            return InternalRequestAsync<DescribeDeviceChannelResponse>(req, "DescribeDeviceChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询设备通道预置位信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePresetRequest"/></param>
        /// <returns><see cref="DescribeDevicePresetResponse"/></returns>
        public Task<DescribeDevicePresetResponse> DescribeDevicePreset(DescribeDevicePresetRequest req)
        {
            return InternalRequestAsync<DescribeDevicePresetResponse>(req, "DescribeDevicePreset");
        }

        /// <summary>
        /// 用于查询设备通道预置位信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePresetRequest"/></param>
        /// <returns><see cref="DescribeDevicePresetResponse"/></returns>
        public DescribeDevicePresetResponse DescribeDevicePresetSync(DescribeDevicePresetRequest req)
        {
            return InternalRequestAsync<DescribeDevicePresetResponse>(req, "DescribeDevicePreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于添加设备时，查询设备可以使用的服务节点，查询结果为已经绑定了域名的服务节点。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRegionRequest"/></param>
        /// <returns><see cref="DescribeDeviceRegionResponse"/></returns>
        public Task<DescribeDeviceRegionResponse> DescribeDeviceRegion(DescribeDeviceRegionRequest req)
        {
            return InternalRequestAsync<DescribeDeviceRegionResponse>(req, "DescribeDeviceRegion");
        }

        /// <summary>
        /// 用于添加设备时，查询设备可以使用的服务节点，查询结果为已经绑定了域名的服务节点。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRegionRequest"/></param>
        /// <returns><see cref="DescribeDeviceRegionResponse"/></returns>
        public DescribeDeviceRegionResponse DescribeDeviceRegionSync(DescribeDeviceRegionRequest req)
        {
            return InternalRequestAsync<DescribeDeviceRegionResponse>(req, "DescribeDeviceRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询添加的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public Task<DescribeDomainResponse> DescribeDomain(DescribeDomainRequest req)
        {
            return InternalRequestAsync<DescribeDomainResponse>(req, "DescribeDomain");
        }

        /// <summary>
        /// 用于查询添加的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public DescribeDomainResponse DescribeDomainSync(DescribeDomainRequest req)
        {
            return InternalRequestAsync<DescribeDomainResponse>(req, "DescribeDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于用户添加域名时，查询可以绑定的服务节点，结果为平台支持的所有服务节点。（注意：每个服务节点只能绑定一个域名）
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRegionRequest"/></param>
        /// <returns><see cref="DescribeDomainRegionResponse"/></returns>
        public Task<DescribeDomainRegionResponse> DescribeDomainRegion(DescribeDomainRegionRequest req)
        {
            return InternalRequestAsync<DescribeDomainRegionResponse>(req, "DescribeDomainRegion");
        }

        /// <summary>
        /// 用于用户添加域名时，查询可以绑定的服务节点，结果为平台支持的所有服务节点。（注意：每个服务节点只能绑定一个域名）
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRegionRequest"/></param>
        /// <returns><see cref="DescribeDomainRegionResponse"/></returns>
        public DescribeDomainRegionResponse DescribeDomainRegionSync(DescribeDomainRegionRequest req)
        {
            return InternalRequestAsync<DescribeDomainRegionResponse>(req, "DescribeDomainRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取网关详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayRequest"/></param>
        /// <returns><see cref="DescribeGatewayResponse"/></returns>
        public Task<DescribeGatewayResponse> DescribeGateway(DescribeGatewayRequest req)
        {
            return InternalRequestAsync<DescribeGatewayResponse>(req, "DescribeGateway");
        }

        /// <summary>
        /// 用于获取网关详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayRequest"/></param>
        /// <returns><see cref="DescribeGatewayResponse"/></returns>
        public DescribeGatewayResponse DescribeGatewaySync(DescribeGatewayRequest req)
        {
            return InternalRequestAsync<DescribeGatewayResponse>(req, "DescribeGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取网关的数据及流量监控信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorResponse"/></returns>
        public Task<DescribeGatewayMonitorResponse> DescribeGatewayMonitor(DescribeGatewayMonitorRequest req)
        {
            return InternalRequestAsync<DescribeGatewayMonitorResponse>(req, "DescribeGatewayMonitor");
        }

        /// <summary>
        /// 用于获取网关的数据及流量监控信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorResponse"/></returns>
        public DescribeGatewayMonitorResponse DescribeGatewayMonitorSync(DescribeGatewayMonitorRequest req)
        {
            return InternalRequestAsync<DescribeGatewayMonitorResponse>(req, "DescribeGatewayMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询网关接入协议。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayProtocolRequest"/></param>
        /// <returns><see cref="DescribeGatewayProtocolResponse"/></returns>
        public Task<DescribeGatewayProtocolResponse> DescribeGatewayProtocol(DescribeGatewayProtocolRequest req)
        {
            return InternalRequestAsync<DescribeGatewayProtocolResponse>(req, "DescribeGatewayProtocol");
        }

        /// <summary>
        /// 用于查询网关接入协议。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayProtocolRequest"/></param>
        /// <returns><see cref="DescribeGatewayProtocolResponse"/></returns>
        public DescribeGatewayProtocolResponse DescribeGatewayProtocolSync(DescribeGatewayProtocolRequest req)
        {
            return InternalRequestAsync<DescribeGatewayProtocolResponse>(req, "DescribeGatewayProtocol")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网关服务版本
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayVersionRequest"/></param>
        /// <returns><see cref="DescribeGatewayVersionResponse"/></returns>
        public Task<DescribeGatewayVersionResponse> DescribeGatewayVersion(DescribeGatewayVersionRequest req)
        {
            return InternalRequestAsync<DescribeGatewayVersionResponse>(req, "DescribeGatewayVersion");
        }

        /// <summary>
        /// 查询网关服务版本
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayVersionRequest"/></param>
        /// <returns><see cref="DescribeGatewayVersionResponse"/></returns>
        public DescribeGatewayVersionResponse DescribeGatewayVersionSync(DescribeGatewayVersionRequest req)
        {
            return InternalRequestAsync<DescribeGatewayVersionResponse>(req, "DescribeGatewayVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询组织。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public Task<DescribeOrganizationResponse> DescribeOrganization(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization");
        }

        /// <summary>
        /// 用于查询组织。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public DescribeOrganizationResponse DescribeOrganizationSync(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询录像上云计划详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupPlanResponse"/></returns>
        public Task<DescribeRecordBackupPlanResponse> DescribeRecordBackupPlan(DescribeRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupPlanResponse>(req, "DescribeRecordBackupPlan");
        }

        /// <summary>
        /// 用于查询录像上云计划详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupPlanResponse"/></returns>
        public DescribeRecordBackupPlanResponse DescribeRecordBackupPlanSync(DescribeRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupPlanResponse>(req, "DescribeRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询录像上云模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupTemplateResponse"/></returns>
        public Task<DescribeRecordBackupTemplateResponse> DescribeRecordBackupTemplate(DescribeRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupTemplateResponse>(req, "DescribeRecordBackupTemplate");
        }

        /// <summary>
        /// 用于查询录像上云模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupTemplateResponse"/></returns>
        public DescribeRecordBackupTemplateResponse DescribeRecordBackupTemplateSync(DescribeRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupTemplateResponse>(req, "DescribeRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询设备云端录像时间轴信息（即为视频上云后设置录像计划后云存储的录像）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeRecordFileResponse"/></returns>
        public Task<DescribeRecordFileResponse> DescribeRecordFile(DescribeRecordFileRequest req)
        {
            return InternalRequestAsync<DescribeRecordFileResponse>(req, "DescribeRecordFile");
        }

        /// <summary>
        /// 用于查询设备云端录像时间轴信息（即为视频上云后设置录像计划后云存储的录像）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeRecordFileResponse"/></returns>
        public DescribeRecordFileResponse DescribeRecordFileSync(DescribeRecordFileRequest req)
        {
            return InternalRequestAsync<DescribeRecordFileResponse>(req, "DescribeRecordFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询实时上云计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordPlanResponse"/></returns>
        public Task<DescribeRecordPlanResponse> DescribeRecordPlan(DescribeRecordPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlanResponse>(req, "DescribeRecordPlan");
        }

        /// <summary>
        /// 用于查询实时上云计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordPlanResponse"/></returns>
        public DescribeRecordPlanResponse DescribeRecordPlanSync(DescribeRecordPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlanResponse>(req, "DescribeRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取云端录像回放url地址
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlaybackUrlRequest"/></param>
        /// <returns><see cref="DescribeRecordPlaybackUrlResponse"/></returns>
        public Task<DescribeRecordPlaybackUrlResponse> DescribeRecordPlaybackUrl(DescribeRecordPlaybackUrlRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlaybackUrlResponse>(req, "DescribeRecordPlaybackUrl");
        }

        /// <summary>
        /// 用于获取云端录像回放url地址
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlaybackUrlRequest"/></param>
        /// <returns><see cref="DescribeRecordPlaybackUrlResponse"/></returns>
        public DescribeRecordPlaybackUrlResponse DescribeRecordPlaybackUrlSync(DescribeRecordPlaybackUrlRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlaybackUrlResponse>(req, "DescribeRecordPlaybackUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询云录像取回任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordRetrieveTaskResponse"/></returns>
        public Task<DescribeRecordRetrieveTaskResponse> DescribeRecordRetrieveTask(DescribeRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordRetrieveTaskResponse>(req, "DescribeRecordRetrieveTask");
        }

        /// <summary>
        /// 用于查询云录像取回任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordRetrieveTaskResponse"/></returns>
        public DescribeRecordRetrieveTaskResponse DescribeRecordRetrieveTaskSync(DescribeRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordRetrieveTaskResponse>(req, "DescribeRecordRetrieveTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 平台支持将数据以TS切片的形式存入客户自有COS桶，该接口用于支持客户快捷查询切片信息列表
        /// （注意：只支持标准存储类型的查询）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSliceRequest"/></param>
        /// <returns><see cref="DescribeRecordSliceResponse"/></returns>
        public Task<DescribeRecordSliceResponse> DescribeRecordSlice(DescribeRecordSliceRequest req)
        {
            return InternalRequestAsync<DescribeRecordSliceResponse>(req, "DescribeRecordSlice");
        }

        /// <summary>
        /// 平台支持将数据以TS切片的形式存入客户自有COS桶，该接口用于支持客户快捷查询切片信息列表
        /// （注意：只支持标准存储类型的查询）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSliceRequest"/></param>
        /// <returns><see cref="DescribeRecordSliceResponse"/></returns>
        public DescribeRecordSliceResponse DescribeRecordSliceSync(DescribeRecordSliceRequest req)
        {
            return InternalRequestAsync<DescribeRecordSliceResponse>(req, "DescribeRecordSlice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询实时上云模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordTemplateResponse"/></returns>
        public Task<DescribeRecordTemplateResponse> DescribeRecordTemplate(DescribeRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordTemplateResponse>(req, "DescribeRecordTemplate");
        }

        /// <summary>
        /// 用于查询实时上云模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordTemplateResponse"/></returns>
        public DescribeRecordTemplateResponse DescribeRecordTemplateSync(DescribeRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordTemplateResponse>(req, "DescribeRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamAuthRequest"/></param>
        /// <returns><see cref="DescribeStreamAuthResponse"/></returns>
        public Task<DescribeStreamAuthResponse> DescribeStreamAuth(DescribeStreamAuthRequest req)
        {
            return InternalRequestAsync<DescribeStreamAuthResponse>(req, "DescribeStreamAuth");
        }

        /// <summary>
        /// 用于查询推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamAuthRequest"/></param>
        /// <returns><see cref="DescribeStreamAuthResponse"/></returns>
        public DescribeStreamAuthResponse DescribeStreamAuthSync(DescribeStreamAuthRequest req)
        {
            return InternalRequestAsync<DescribeStreamAuthResponse>(req, "DescribeStreamAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask");
        }

        /// <summary>
        /// 用于查询任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询设备的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceResponse"/></returns>
        public Task<DescribeUserDeviceResponse> DescribeUserDevice(DescribeUserDeviceRequest req)
        {
            return InternalRequestAsync<DescribeUserDeviceResponse>(req, "DescribeUserDevice");
        }

        /// <summary>
        /// 用于查询设备的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceResponse"/></returns>
        public DescribeUserDeviceResponse DescribeUserDeviceSync(DescribeUserDeviceRequest req)
        {
            return InternalRequestAsync<DescribeUserDeviceResponse>(req, "DescribeUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取视频通道的码率信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoBitRateRequest"/></param>
        /// <returns><see cref="DescribeVideoBitRateResponse"/></returns>
        public Task<DescribeVideoBitRateResponse> DescribeVideoBitRate(DescribeVideoBitRateRequest req)
        {
            return InternalRequestAsync<DescribeVideoBitRateResponse>(req, "DescribeVideoBitRate");
        }

        /// <summary>
        /// 用于获取视频通道的码率信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoBitRateRequest"/></param>
        /// <returns><see cref="DescribeVideoBitRateResponse"/></returns>
        public DescribeVideoBitRateResponse DescribeVideoBitRateSync(DescribeVideoBitRateRequest req)
        {
            return InternalRequestAsync<DescribeVideoBitRateResponse>(req, "DescribeVideoBitRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取云录像下载 url
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVideoDownloadUrlResponse"/></returns>
        public Task<DescribeVideoDownloadUrlResponse> DescribeVideoDownloadUrl(DescribeVideoDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeVideoDownloadUrlResponse>(req, "DescribeVideoDownloadUrl");
        }

        /// <summary>
        /// 用于获取云录像下载 url
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVideoDownloadUrlResponse"/></returns>
        public DescribeVideoDownloadUrlResponse DescribeVideoDownloadUrlSync(DescribeVideoDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeVideoDownloadUrlResponse>(req, "DescribeVideoDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取AI任务列表
        /// </summary>
        /// <param name="req"><see cref="ListAITasksRequest"/></param>
        /// <returns><see cref="ListAITasksResponse"/></returns>
        public Task<ListAITasksResponse> ListAITasks(ListAITasksRequest req)
        {
            return InternalRequestAsync<ListAITasksResponse>(req, "ListAITasks");
        }

        /// <summary>
        /// 获取AI任务列表
        /// </summary>
        /// <param name="req"><see cref="ListAITasksRequest"/></param>
        /// <returns><see cref="ListAITasksResponse"/></returns>
        public ListAITasksResponse ListAITasksSync(ListAITasksRequest req)
        {
            return InternalRequestAsync<ListAITasksResponse>(req, "ListAITasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取对应组织下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListDevicesRequest"/></param>
        /// <returns><see cref="ListDevicesResponse"/></returns>
        public Task<ListDevicesResponse> ListDevices(ListDevicesRequest req)
        {
            return InternalRequestAsync<ListDevicesResponse>(req, "ListDevices");
        }

        /// <summary>
        /// 用于获取对应组织下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListDevicesRequest"/></param>
        /// <returns><see cref="ListDevicesResponse"/></returns>
        public ListDevicesResponse ListDevicesSync(ListDevicesRequest req)
        {
            return InternalRequestAsync<ListDevicesResponse>(req, "ListDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询网关下挂载的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewayDevicesRequest"/></param>
        /// <returns><see cref="ListGatewayDevicesResponse"/></returns>
        public Task<ListGatewayDevicesResponse> ListGatewayDevices(ListGatewayDevicesRequest req)
        {
            return InternalRequestAsync<ListGatewayDevicesResponse>(req, "ListGatewayDevices");
        }

        /// <summary>
        /// 用于查询网关下挂载的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewayDevicesRequest"/></param>
        /// <returns><see cref="ListGatewayDevicesResponse"/></returns>
        public ListGatewayDevicesResponse ListGatewayDevicesSync(ListGatewayDevicesRequest req)
        {
            return InternalRequestAsync<ListGatewayDevicesResponse>(req, "ListGatewayDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取网关列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewaysRequest"/></param>
        /// <returns><see cref="ListGatewaysResponse"/></returns>
        public Task<ListGatewaysResponse> ListGateways(ListGatewaysRequest req)
        {
            return InternalRequestAsync<ListGatewaysResponse>(req, "ListGateways");
        }

        /// <summary>
        /// 用于获取网关列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewaysRequest"/></param>
        /// <returns><see cref="ListGatewaysResponse"/></returns>
        public ListGatewaysResponse ListGatewaysSync(ListGatewaysRequest req)
        {
            return InternalRequestAsync<ListGatewaysResponse>(req, "ListGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询组织目录下的未添加到实时上云计划中的通道数量
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelNumbersRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelNumbersResponse"/></returns>
        public Task<ListOrganizationChannelNumbersResponse> ListOrganizationChannelNumbers(ListOrganizationChannelNumbersRequest req)
        {
            return InternalRequestAsync<ListOrganizationChannelNumbersResponse>(req, "ListOrganizationChannelNumbers");
        }

        /// <summary>
        /// 用于查询组织目录下的未添加到实时上云计划中的通道数量
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelNumbersRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelNumbersResponse"/></returns>
        public ListOrganizationChannelNumbersResponse ListOrganizationChannelNumbersSync(ListOrganizationChannelNumbersRequest req)
        {
            return InternalRequestAsync<ListOrganizationChannelNumbersResponse>(req, "ListOrganizationChannelNumbers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询组织目录下的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelsRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelsResponse"/></returns>
        public Task<ListOrganizationChannelsResponse> ListOrganizationChannels(ListOrganizationChannelsRequest req)
        {
            return InternalRequestAsync<ListOrganizationChannelsResponse>(req, "ListOrganizationChannels");
        }

        /// <summary>
        /// 用于查询组织目录下的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelsRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelsResponse"/></returns>
        public ListOrganizationChannelsResponse ListOrganizationChannelsSync(ListOrganizationChannelsRequest req)
        {
            return InternalRequestAsync<ListOrganizationChannelsResponse>(req, "ListOrganizationChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询录像上云计划下的设备通道列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlanDevicesResponse"/></returns>
        public Task<ListRecordBackupPlanDevicesResponse> ListRecordBackupPlanDevices(ListRecordBackupPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlanDevicesResponse>(req, "ListRecordBackupPlanDevices");
        }

        /// <summary>
        /// 用于查询录像上云计划下的设备通道列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlanDevicesResponse"/></returns>
        public ListRecordBackupPlanDevicesResponse ListRecordBackupPlanDevicesSync(ListRecordBackupPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlanDevicesResponse>(req, "ListRecordBackupPlanDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询录像上云计划列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlansRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlansResponse"/></returns>
        public Task<ListRecordBackupPlansResponse> ListRecordBackupPlans(ListRecordBackupPlansRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlansResponse>(req, "ListRecordBackupPlans");
        }

        /// <summary>
        /// 用于查询录像上云计划列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlansRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlansResponse"/></returns>
        public ListRecordBackupPlansResponse ListRecordBackupPlansSync(ListRecordBackupPlansRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlansResponse>(req, "ListRecordBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询录像上云模板列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordBackupTemplatesResponse"/></returns>
        public Task<ListRecordBackupTemplatesResponse> ListRecordBackupTemplates(ListRecordBackupTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupTemplatesResponse>(req, "ListRecordBackupTemplates");
        }

        /// <summary>
        /// 用于查询录像上云模板列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordBackupTemplatesResponse"/></returns>
        public ListRecordBackupTemplatesResponse ListRecordBackupTemplatesSync(ListRecordBackupTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupTemplatesResponse>(req, "ListRecordBackupTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询用户下所有实时上云计划中的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanChannelsRequest"/></param>
        /// <returns><see cref="ListRecordPlanChannelsResponse"/></returns>
        public Task<ListRecordPlanChannelsResponse> ListRecordPlanChannels(ListRecordPlanChannelsRequest req)
        {
            return InternalRequestAsync<ListRecordPlanChannelsResponse>(req, "ListRecordPlanChannels");
        }

        /// <summary>
        /// 用于查询用户下所有实时上云计划中的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanChannelsRequest"/></param>
        /// <returns><see cref="ListRecordPlanChannelsResponse"/></returns>
        public ListRecordPlanChannelsResponse ListRecordPlanChannelsSync(ListRecordPlanChannelsRequest req)
        {
            return InternalRequestAsync<ListRecordPlanChannelsResponse>(req, "ListRecordPlanChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询实时上云计划下的设备通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordPlanDevicesResponse"/></returns>
        public Task<ListRecordPlanDevicesResponse> ListRecordPlanDevices(ListRecordPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordPlanDevicesResponse>(req, "ListRecordPlanDevices");
        }

        /// <summary>
        /// 用于查询实时上云计划下的设备通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordPlanDevicesResponse"/></returns>
        public ListRecordPlanDevicesResponse ListRecordPlanDevicesSync(ListRecordPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordPlanDevicesResponse>(req, "ListRecordPlanDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询实时上云计划列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlansRequest"/></param>
        /// <returns><see cref="ListRecordPlansResponse"/></returns>
        public Task<ListRecordPlansResponse> ListRecordPlans(ListRecordPlansRequest req)
        {
            return InternalRequestAsync<ListRecordPlansResponse>(req, "ListRecordPlans");
        }

        /// <summary>
        /// 用于查询实时上云计划列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlansRequest"/></param>
        /// <returns><see cref="ListRecordPlansResponse"/></returns>
        public ListRecordPlansResponse ListRecordPlansSync(ListRecordPlansRequest req)
        {
            return InternalRequestAsync<ListRecordPlansResponse>(req, "ListRecordPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询取回任务列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordRetrieveTasksRequest"/></param>
        /// <returns><see cref="ListRecordRetrieveTasksResponse"/></returns>
        public Task<ListRecordRetrieveTasksResponse> ListRecordRetrieveTasks(ListRecordRetrieveTasksRequest req)
        {
            return InternalRequestAsync<ListRecordRetrieveTasksResponse>(req, "ListRecordRetrieveTasks");
        }

        /// <summary>
        /// 用于查询取回任务列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordRetrieveTasksRequest"/></param>
        /// <returns><see cref="ListRecordRetrieveTasksResponse"/></returns>
        public ListRecordRetrieveTasksResponse ListRecordRetrieveTasksSync(ListRecordRetrieveTasksRequest req)
        {
            return InternalRequestAsync<ListRecordRetrieveTasksResponse>(req, "ListRecordRetrieveTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询实时上云模板列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordTemplatesResponse"/></returns>
        public Task<ListRecordTemplatesResponse> ListRecordTemplates(ListRecordTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordTemplatesResponse>(req, "ListRecordTemplates");
        }

        /// <summary>
        /// 用于查询实时上云模板列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordTemplatesResponse"/></returns>
        public ListRecordTemplatesResponse ListRecordTemplatesSync(ListRecordTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordTemplatesResponse>(req, "ListRecordTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询任务的子任务列表
        /// </summary>
        /// <param name="req"><see cref="ListSubTasksRequest"/></param>
        /// <returns><see cref="ListSubTasksResponse"/></returns>
        public Task<ListSubTasksResponse> ListSubTasks(ListSubTasksRequest req)
        {
            return InternalRequestAsync<ListSubTasksResponse>(req, "ListSubTasks");
        }

        /// <summary>
        /// 用于查询任务的子任务列表
        /// </summary>
        /// <param name="req"><see cref="ListSubTasksRequest"/></param>
        /// <returns><see cref="ListSubTasksResponse"/></returns>
        public ListSubTasksResponse ListSubTasksSync(ListSubTasksRequest req)
        {
            return InternalRequestAsync<ListSubTasksResponse>(req, "ListSubTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询批量任务和简单任务列表
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public Task<ListTasksResponse> ListTasks(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks");
        }

        /// <summary>
        /// 用于查询批量任务和简单任务列表
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public ListTasksResponse ListTasksSync(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取设备本地录像 URL 地址。
        /// </summary>
        /// <param name="req"><see cref="PlayRecordRequest"/></param>
        /// <returns><see cref="PlayRecordResponse"/></returns>
        public Task<PlayRecordResponse> PlayRecord(PlayRecordRequest req)
        {
            return InternalRequestAsync<PlayRecordResponse>(req, "PlayRecord");
        }

        /// <summary>
        /// 用于获取设备本地录像 URL 地址。
        /// </summary>
        /// <param name="req"><see cref="PlayRecordRequest"/></param>
        /// <returns><see cref="PlayRecordResponse"/></returns>
        public PlayRecordResponse PlayRecordSync(PlayRecordRequest req)
        {
            return InternalRequestAsync<PlayRecordResponse>(req, "PlayRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于刷新国标设备的通道（接口调用后，触发向设备请求通道列表，新增的通道入库，设备上已删除的通道需自行删除、后台不自动删除）。
        /// </summary>
        /// <param name="req"><see cref="RefreshDeviceChannelRequest"/></param>
        /// <returns><see cref="RefreshDeviceChannelResponse"/></returns>
        public Task<RefreshDeviceChannelResponse> RefreshDeviceChannel(RefreshDeviceChannelRequest req)
        {
            return InternalRequestAsync<RefreshDeviceChannelResponse>(req, "RefreshDeviceChannel");
        }

        /// <summary>
        /// 用于刷新国标设备的通道（接口调用后，触发向设备请求通道列表，新增的通道入库，设备上已删除的通道需自行删除、后台不自动删除）。
        /// </summary>
        /// <param name="req"><see cref="RefreshDeviceChannelRequest"/></param>
        /// <returns><see cref="RefreshDeviceChannelResponse"/></returns>
        public RefreshDeviceChannelResponse RefreshDeviceChannelSync(RefreshDeviceChannelRequest req)
        {
            return InternalRequestAsync<RefreshDeviceChannelResponse>(req, "RefreshDeviceChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新AI任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskRequest"/></param>
        /// <returns><see cref="UpdateAITaskResponse"/></returns>
        public Task<UpdateAITaskResponse> UpdateAITask(UpdateAITaskRequest req)
        {
            return InternalRequestAsync<UpdateAITaskResponse>(req, "UpdateAITask");
        }

        /// <summary>
        /// 更新AI任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskRequest"/></param>
        /// <returns><see cref="UpdateAITaskResponse"/></returns>
        public UpdateAITaskResponse UpdateAITaskSync(UpdateAITaskRequest req)
        {
            return InternalRequestAsync<UpdateAITaskResponse>(req, "UpdateAITask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 AI 任务状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskStatusRequest"/></param>
        /// <returns><see cref="UpdateAITaskStatusResponse"/></returns>
        public Task<UpdateAITaskStatusResponse> UpdateAITaskStatus(UpdateAITaskStatusRequest req)
        {
            return InternalRequestAsync<UpdateAITaskStatusResponse>(req, "UpdateAITaskStatus");
        }

        /// <summary>
        /// 更新 AI 任务状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskStatusRequest"/></param>
        /// <returns><see cref="UpdateAITaskStatusResponse"/></returns>
        public UpdateAITaskStatusResponse UpdateAITaskStatusSync(UpdateAITaskStatusRequest req)
        {
            return InternalRequestAsync<UpdateAITaskStatusResponse>(req, "UpdateAITaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量更改设备的组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceOrganizationRequest"/></param>
        /// <returns><see cref="UpdateDeviceOrganizationResponse"/></returns>
        public Task<UpdateDeviceOrganizationResponse> UpdateDeviceOrganization(UpdateDeviceOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateDeviceOrganizationResponse>(req, "UpdateDeviceOrganization");
        }

        /// <summary>
        /// 用于批量更改设备的组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceOrganizationRequest"/></param>
        /// <returns><see cref="UpdateDeviceOrganizationResponse"/></returns>
        public UpdateDeviceOrganizationResponse UpdateDeviceOrganizationSync(UpdateDeviceOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateDeviceOrganizationResponse>(req, "UpdateDeviceOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于启用/禁用设备，禁用后拒绝设备注册。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceStatusResponse"/></returns>
        public Task<UpdateDeviceStatusResponse> UpdateDeviceStatus(UpdateDeviceStatusRequest req)
        {
            return InternalRequestAsync<UpdateDeviceStatusResponse>(req, "UpdateDeviceStatus");
        }

        /// <summary>
        /// 用于启用/禁用设备，禁用后拒绝设备注册。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceStatusResponse"/></returns>
        public UpdateDeviceStatusResponse UpdateDeviceStatusSync(UpdateDeviceStatusRequest req)
        {
            return InternalRequestAsync<UpdateDeviceStatusResponse>(req, "UpdateDeviceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改网关信息（支持对网关名称和描述的修改）。
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayRequest"/></param>
        /// <returns><see cref="UpdateGatewayResponse"/></returns>
        public Task<UpdateGatewayResponse> UpdateGateway(UpdateGatewayRequest req)
        {
            return InternalRequestAsync<UpdateGatewayResponse>(req, "UpdateGateway");
        }

        /// <summary>
        /// 用于修改网关信息（支持对网关名称和描述的修改）。
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayRequest"/></param>
        /// <returns><see cref="UpdateGatewayResponse"/></returns>
        public UpdateGatewayResponse UpdateGatewaySync(UpdateGatewayRequest req)
        {
            return InternalRequestAsync<UpdateGatewayResponse>(req, "UpdateGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationRequest"/></param>
        /// <returns><see cref="UpdateOrganizationResponse"/></returns>
        public Task<UpdateOrganizationResponse> UpdateOrganization(UpdateOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationResponse>(req, "UpdateOrganization");
        }

        /// <summary>
        /// 用于修改组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationRequest"/></param>
        /// <returns><see cref="UpdateOrganizationResponse"/></returns>
        public UpdateOrganizationResponse UpdateOrganizationSync(UpdateOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationResponse>(req, "UpdateOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改录像上云计划。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupPlanResponse"/></returns>
        public Task<UpdateRecordBackupPlanResponse> UpdateRecordBackupPlan(UpdateRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupPlanResponse>(req, "UpdateRecordBackupPlan");
        }

        /// <summary>
        /// 用于修改录像上云计划。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupPlanResponse"/></returns>
        public UpdateRecordBackupPlanResponse UpdateRecordBackupPlanSync(UpdateRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupPlanResponse>(req, "UpdateRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupTemplateResponse"/></returns>
        public Task<UpdateRecordBackupTemplateResponse> UpdateRecordBackupTemplate(UpdateRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupTemplateResponse>(req, "UpdateRecordBackupTemplate");
        }

        /// <summary>
        /// 用于修改录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupTemplateResponse"/></returns>
        public UpdateRecordBackupTemplateResponse UpdateRecordBackupTemplateSync(UpdateRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupTemplateResponse>(req, "UpdateRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改实时上云计划
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public Task<UpdateRecordPlanResponse> UpdateRecordPlan(UpdateRecordPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordPlanResponse>(req, "UpdateRecordPlan");
        }

        /// <summary>
        /// 用于修改实时上云计划
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public UpdateRecordPlanResponse UpdateRecordPlanSync(UpdateRecordPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordPlanResponse>(req, "UpdateRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改实时上云模板
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordTemplateResponse"/></returns>
        public Task<UpdateRecordTemplateResponse> UpdateRecordTemplate(UpdateRecordTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordTemplateResponse>(req, "UpdateRecordTemplate");
        }

        /// <summary>
        /// 用于修改实时上云模板
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordTemplateResponse"/></returns>
        public UpdateRecordTemplateResponse UpdateRecordTemplateSync(UpdateRecordTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordTemplateResponse>(req, "UpdateRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改设备的配置信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDeviceRequest"/></param>
        /// <returns><see cref="UpdateUserDeviceResponse"/></returns>
        public Task<UpdateUserDeviceResponse> UpdateUserDevice(UpdateUserDeviceRequest req)
        {
            return InternalRequestAsync<UpdateUserDeviceResponse>(req, "UpdateUserDevice");
        }

        /// <summary>
        /// 用于修改设备的配置信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDeviceRequest"/></param>
        /// <returns><see cref="UpdateUserDeviceResponse"/></returns>
        public UpdateUserDeviceResponse UpdateUserDeviceSync(UpdateUserDeviceRequest req)
        {
            return InternalRequestAsync<UpdateUserDeviceResponse>(req, "UpdateUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于网关升级（支持对所有待更新的服务一键升级）。
        /// </summary>
        /// <param name="req"><see cref="UpgradeGatewayRequest"/></param>
        /// <returns><see cref="UpgradeGatewayResponse"/></returns>
        public Task<UpgradeGatewayResponse> UpgradeGateway(UpgradeGatewayRequest req)
        {
            return InternalRequestAsync<UpgradeGatewayResponse>(req, "UpgradeGateway");
        }

        /// <summary>
        /// 用于网关升级（支持对所有待更新的服务一键升级）。
        /// </summary>
        /// <param name="req"><see cref="UpgradeGatewayRequest"/></param>
        /// <returns><see cref="UpgradeGatewayResponse"/></returns>
        public UpgradeGatewayResponse UpgradeGatewaySync(UpgradeGatewayRequest req)
        {
            return InternalRequestAsync<UpgradeGatewayResponse>(req, "UpgradeGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
