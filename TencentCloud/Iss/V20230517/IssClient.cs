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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 添加AI任务
        /// </summary>
        /// <param name="req"><see cref="AddAITaskRequest"/></param>
        /// <returns><see cref="AddAITaskResponse"/></returns>
        public async Task<AddAITaskResponse> AddAITask(AddAITaskRequest req)
        {
             JsonResponseModel<AddAITaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加AI任务
        /// </summary>
        /// <param name="req"><see cref="AddAITaskRequest"/></param>
        /// <returns><see cref="AddAITaskResponse"/></returns>
        public AddAITaskResponse AddAITaskSync(AddAITaskRequest req)
        {
             JsonResponseModel<AddAITaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增组织。
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationRequest"/></param>
        /// <returns><see cref="AddOrganizationResponse"/></returns>
        public async Task<AddOrganizationResponse> AddOrganization(AddOrganizationRequest req)
        {
             JsonResponseModel<AddOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增组织。
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationRequest"/></param>
        /// <returns><see cref="AddOrganizationResponse"/></returns>
        public AddOrganizationResponse AddOrganizationSync(AddOrganizationRequest req)
        {
             JsonResponseModel<AddOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增录像上云计划 （当前仅适用于通过GB28181协议和网关接入的设备/视频通道）
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupPlanRequest"/></param>
        /// <returns><see cref="AddRecordBackupPlanResponse"/></returns>
        public async Task<AddRecordBackupPlanResponse> AddRecordBackupPlan(AddRecordBackupPlanRequest req)
        {
             JsonResponseModel<AddRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增录像上云计划 （当前仅适用于通过GB28181协议和网关接入的设备/视频通道）
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupPlanRequest"/></param>
        /// <returns><see cref="AddRecordBackupPlanResponse"/></returns>
        public AddRecordBackupPlanResponse AddRecordBackupPlanSync(AddRecordBackupPlanRequest req)
        {
             JsonResponseModel<AddRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增录像上云模板。
        /// > 该功能本质是拉取设备本地录像数据上云（即存在 IPC 摄像头存储卡或 NVR 硬盘中的录像），操作时需先设定录像时间段（即想要上云的设备本地录像），再设定上云时间段和上云倍速，平台将于上云时间段倍速拉取设备对应前一天的录像时间段数据。
        /// 
        /// > 设定需至少满足（上云时间段=前一天的录像时间段/上云倍速），建议上云时间段可多设定10%左右的时间，避免因网络波动导致数据拉取不完整。
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="AddRecordBackupTemplateResponse"/></returns>
        public async Task<AddRecordBackupTemplateResponse> AddRecordBackupTemplate(AddRecordBackupTemplateRequest req)
        {
             JsonResponseModel<AddRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AddRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增实时上云计划
        /// </summary>
        /// <param name="req"><see cref="AddRecordPlanRequest"/></param>
        /// <returns><see cref="AddRecordPlanResponse"/></returns>
        public async Task<AddRecordPlanResponse> AddRecordPlan(AddRecordPlanRequest req)
        {
             JsonResponseModel<AddRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增实时上云计划
        /// </summary>
        /// <param name="req"><see cref="AddRecordPlanRequest"/></param>
        /// <returns><see cref="AddRecordPlanResponse"/></returns>
        public AddRecordPlanResponse AddRecordPlanSync(AddRecordPlanRequest req)
        {
             JsonResponseModel<AddRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新建取回任务
        /// </summary>
        /// <param name="req"><see cref="AddRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="AddRecordRetrieveTaskResponse"/></returns>
        public async Task<AddRecordRetrieveTaskResponse> AddRecordRetrieveTask(AddRecordRetrieveTaskRequest req)
        {
             JsonResponseModel<AddRecordRetrieveTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRecordRetrieveTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordRetrieveTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新建取回任务
        /// </summary>
        /// <param name="req"><see cref="AddRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="AddRecordRetrieveTaskResponse"/></returns>
        public AddRecordRetrieveTaskResponse AddRecordRetrieveTaskSync(AddRecordRetrieveTaskRequest req)
        {
             JsonResponseModel<AddRecordRetrieveTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddRecordRetrieveTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordRetrieveTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增实时上云模板
        /// </summary>
        /// <param name="req"><see cref="AddRecordTemplateRequest"/></param>
        /// <returns><see cref="AddRecordTemplateResponse"/></returns>
        public async Task<AddRecordTemplateResponse> AddRecordTemplate(AddRecordTemplateRequest req)
        {
             JsonResponseModel<AddRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增实时上云模板
        /// </summary>
        /// <param name="req"><see cref="AddRecordTemplateRequest"/></param>
        /// <returns><see cref="AddRecordTemplateResponse"/></returns>
        public AddRecordTemplateResponse AddRecordTemplateSync(AddRecordTemplateRequest req)
        {
             JsonResponseModel<AddRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于设置推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="AddStreamAuthRequest"/></param>
        /// <returns><see cref="AddStreamAuthResponse"/></returns>
        public async Task<AddStreamAuthResponse> AddStreamAuth(AddStreamAuthRequest req)
        {
             JsonResponseModel<AddStreamAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddStreamAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddStreamAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于设置推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="AddStreamAuthRequest"/></param>
        /// <returns><see cref="AddStreamAuthResponse"/></returns>
        public AddStreamAuthResponse AddStreamAuthSync(AddStreamAuthRequest req)
        {
             JsonResponseModel<AddStreamAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddStreamAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddStreamAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增单个设备。添加设备之后，可根据返回结果到设备上进行配置，配置后等待设备注册/推流。
        /// </summary>
        /// <param name="req"><see cref="AddUserDeviceRequest"/></param>
        /// <returns><see cref="AddUserDeviceResponse"/></returns>
        public async Task<AddUserDeviceResponse> AddUserDevice(AddUserDeviceRequest req)
        {
             JsonResponseModel<AddUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新增单个设备。添加设备之后，可根据返回结果到设备上进行配置，配置后等待设备注册/推流。
        /// </summary>
        /// <param name="req"><see cref="AddUserDeviceRequest"/></param>
        /// <returns><see cref="AddUserDeviceResponse"/></returns>
        public AddUserDeviceResponse AddUserDeviceSync(AddUserDeviceRequest req)
        {
             JsonResponseModel<AddUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量操作（启用，禁用，删除）设备
        /// </summary>
        /// <param name="req"><see cref="BatchOperateDeviceRequest"/></param>
        /// <returns><see cref="BatchOperateDeviceResponse"/></returns>
        public async Task<BatchOperateDeviceResponse> BatchOperateDevice(BatchOperateDeviceRequest req)
        {
             JsonResponseModel<BatchOperateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchOperateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchOperateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量操作（启用，禁用，删除）设备
        /// </summary>
        /// <param name="req"><see cref="BatchOperateDeviceRequest"/></param>
        /// <returns><see cref="BatchOperateDeviceResponse"/></returns>
        public BatchOperateDeviceResponse BatchOperateDeviceSync(BatchOperateDeviceRequest req)
        {
             JsonResponseModel<BatchOperateDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchOperateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchOperateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于检测域名是否备案。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public async Task<CheckDomainResponse> CheckDomain(CheckDomainRequest req)
        {
             JsonResponseModel<CheckDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于检测域名是否备案。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public CheckDomainResponse CheckDomainSync(CheckDomainRequest req)
        {
             JsonResponseModel<CheckDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于设备通道云台控制，包括转动、变倍、变焦、光圈等。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public async Task<ControlDevicePTZResponse> ControlDevicePTZ(ControlDevicePTZRequest req)
        {
             JsonResponseModel<ControlDevicePTZResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlDevicePTZ");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDevicePTZResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于设备通道云台控制，包括转动、变倍、变焦、光圈等。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public ControlDevicePTZResponse ControlDevicePTZSync(ControlDevicePTZRequest req)
        {
             JsonResponseModel<ControlDevicePTZResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlDevicePTZ");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDevicePTZResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于操作设备预置位，包括设置、删除、调用。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePresetRequest"/></param>
        /// <returns><see cref="ControlDevicePresetResponse"/></returns>
        public async Task<ControlDevicePresetResponse> ControlDevicePreset(ControlDevicePresetRequest req)
        {
             JsonResponseModel<ControlDevicePresetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlDevicePreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDevicePresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于操作设备预置位，包括设置、删除、调用。
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePresetRequest"/></param>
        /// <returns><see cref="ControlDevicePresetResponse"/></returns>
        public ControlDevicePresetResponse ControlDevicePresetSync(ControlDevicePresetRequest req)
        {
             JsonResponseModel<ControlDevicePresetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlDevicePreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDevicePresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备的实时开流地址。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceStreamRequest"/></param>
        /// <returns><see cref="ControlDeviceStreamResponse"/></returns>
        public async Task<ControlDeviceStreamResponse> ControlDeviceStream(ControlDeviceStreamRequest req)
        {
             JsonResponseModel<ControlDeviceStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlDeviceStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDeviceStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备的实时开流地址。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceStreamRequest"/></param>
        /// <returns><see cref="ControlDeviceStreamResponse"/></returns>
        public ControlDeviceStreamResponse ControlDeviceStreamSync(ControlDeviceStreamRequest req)
        {
             JsonResponseModel<ControlDeviceStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlDeviceStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDeviceStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于录像回放过程中的倍速、跳转、播放/暂停/停止等控制。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordRequest"/></param>
        /// <returns><see cref="ControlRecordResponse"/></returns>
        public async Task<ControlRecordResponse> ControlRecord(ControlRecordRequest req)
        {
             JsonResponseModel<ControlRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于录像回放过程中的倍速、跳转、播放/暂停/停止等控制。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordRequest"/></param>
        /// <returns><see cref="ControlRecordResponse"/></returns>
        public ControlRecordResponse ControlRecordSync(ControlRecordRequest req)
        {
             JsonResponseModel<ControlRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备本地录像时间轴信息，为NVR/IPC本地存储的录像。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordTimelineRequest"/></param>
        /// <returns><see cref="ControlRecordTimelineResponse"/></returns>
        public async Task<ControlRecordTimelineResponse> ControlRecordTimeline(ControlRecordTimelineRequest req)
        {
             JsonResponseModel<ControlRecordTimelineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlRecordTimeline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlRecordTimelineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备本地录像时间轴信息，为NVR/IPC本地存储的录像。
        /// </summary>
        /// <param name="req"><see cref="ControlRecordTimelineRequest"/></param>
        /// <returns><see cref="ControlRecordTimelineResponse"/></returns>
        public ControlRecordTimelineResponse ControlRecordTimelineSync(ControlRecordTimelineRequest req)
        {
             JsonResponseModel<ControlRecordTimelineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlRecordTimeline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlRecordTimelineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除AI任务
        /// </summary>
        /// <param name="req"><see cref="DeleteAITaskRequest"/></param>
        /// <returns><see cref="DeleteAITaskResponse"/></returns>
        public async Task<DeleteAITaskResponse> DeleteAITask(DeleteAITaskRequest req)
        {
             JsonResponseModel<DeleteAITaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除AI任务
        /// </summary>
        /// <param name="req"><see cref="DeleteAITaskRequest"/></param>
        /// <returns><see cref="DeleteAITaskResponse"/></returns>
        public DeleteAITaskResponse DeleteAITaskSync(DeleteAITaskRequest req)
        {
             JsonResponseModel<DeleteAITaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public async Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除域名。
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayRequest"/></param>
        /// <returns><see cref="DeleteGatewayResponse"/></returns>
        public async Task<DeleteGatewayResponse> DeleteGateway(DeleteGatewayRequest req)
        {
             JsonResponseModel<DeleteGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除网关。
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayRequest"/></param>
        /// <returns><see cref="DeleteGatewayResponse"/></returns>
        public DeleteGatewayResponse DeleteGatewaySync(DeleteGatewayRequest req)
        {
             JsonResponseModel<DeleteGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除组织。
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public async Task<DeleteOrganizationResponse> DeleteOrganization(DeleteOrganizationRequest req)
        {
             JsonResponseModel<DeleteOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除组织。
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public DeleteOrganizationResponse DeleteOrganizationSync(DeleteOrganizationRequest req)
        {
             JsonResponseModel<DeleteOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupPlanResponse"/></returns>
        public async Task<DeleteRecordBackupPlanResponse> DeleteRecordBackupPlan(DeleteRecordBackupPlanRequest req)
        {
             JsonResponseModel<DeleteRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupPlanResponse"/></returns>
        public DeleteRecordBackupPlanResponse DeleteRecordBackupPlanSync(DeleteRecordBackupPlanRequest req)
        {
             JsonResponseModel<DeleteRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupTemplateResponse"/></returns>
        public async Task<DeleteRecordBackupTemplateResponse> DeleteRecordBackupTemplate(DeleteRecordBackupTemplateRequest req)
        {
             JsonResponseModel<DeleteRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupTemplateResponse"/></returns>
        public DeleteRecordBackupTemplateResponse DeleteRecordBackupTemplateSync(DeleteRecordBackupTemplateRequest req)
        {
             JsonResponseModel<DeleteRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除实时上云计划
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordPlanResponse"/></returns>
        public async Task<DeleteRecordPlanResponse> DeleteRecordPlan(DeleteRecordPlanRequest req)
        {
             JsonResponseModel<DeleteRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除实时上云计划
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordPlanResponse"/></returns>
        public DeleteRecordPlanResponse DeleteRecordPlanSync(DeleteRecordPlanRequest req)
        {
             JsonResponseModel<DeleteRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除取回任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordRetrieveTaskResponse"/></returns>
        public async Task<DeleteRecordRetrieveTaskResponse> DeleteRecordRetrieveTask(DeleteRecordRetrieveTaskRequest req)
        {
             JsonResponseModel<DeleteRecordRetrieveTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordRetrieveTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordRetrieveTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除取回任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordRetrieveTaskResponse"/></returns>
        public DeleteRecordRetrieveTaskResponse DeleteRecordRetrieveTaskSync(DeleteRecordRetrieveTaskRequest req)
        {
             JsonResponseModel<DeleteRecordRetrieveTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordRetrieveTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordRetrieveTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除实时上云模板
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordTemplateResponse"/></returns>
        public async Task<DeleteRecordTemplateResponse> DeleteRecordTemplate(DeleteRecordTemplateRequest req)
        {
             JsonResponseModel<DeleteRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除实时上云模板
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordTemplateResponse"/></returns>
        public DeleteRecordTemplateResponse DeleteRecordTemplateSync(DeleteRecordTemplateRequest req)
        {
             JsonResponseModel<DeleteRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除已添加的设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteUserDeviceRequest"/></param>
        /// <returns><see cref="DeleteUserDeviceResponse"/></returns>
        public async Task<DeleteUserDeviceResponse> DeleteUserDevice(DeleteUserDeviceRequest req)
        {
             JsonResponseModel<DeleteUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除已添加的设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteUserDeviceRequest"/></param>
        /// <returns><see cref="DeleteUserDeviceResponse"/></returns>
        public DeleteUserDeviceResponse DeleteUserDeviceSync(DeleteUserDeviceRequest req)
        {
             JsonResponseModel<DeleteUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AI任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskRequest"/></param>
        /// <returns><see cref="DescribeAITaskResponse"/></returns>
        public async Task<DescribeAITaskResponse> DescribeAITask(DescribeAITaskRequest req)
        {
             JsonResponseModel<DescribeAITaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AI任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskRequest"/></param>
        /// <returns><see cref="DescribeAITaskResponse"/></returns>
        public DescribeAITaskResponse DescribeAITaskSync(DescribeAITaskRequest req)
        {
             JsonResponseModel<DescribeAITaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AI任务识别结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskResultRequest"/></param>
        /// <returns><see cref="DescribeAITaskResultResponse"/></returns>
        public async Task<DescribeAITaskResultResponse> DescribeAITaskResult(DescribeAITaskResultRequest req)
        {
             JsonResponseModel<DescribeAITaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAITaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAITaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AI任务识别结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAITaskResultRequest"/></param>
        /// <returns><see cref="DescribeAITaskResultResponse"/></returns>
        public DescribeAITaskResultResponse DescribeAITaskResultSync(DescribeAITaskResultRequest req)
        {
             JsonResponseModel<DescribeAITaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAITaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAITaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于根据服务节点获取 CNAME 值。
        /// </summary>
        /// <param name="req"><see cref="DescribeCNAMERequest"/></param>
        /// <returns><see cref="DescribeCNAMEResponse"/></returns>
        public async Task<DescribeCNAMEResponse> DescribeCNAME(DescribeCNAMERequest req)
        {
             JsonResponseModel<DescribeCNAMEResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCNAME");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCNAMEResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于根据服务节点获取 CNAME 值。
        /// </summary>
        /// <param name="req"><see cref="DescribeCNAMERequest"/></param>
        /// <returns><see cref="DescribeCNAMEResponse"/></returns>
        public DescribeCNAMEResponse DescribeCNAMESync(DescribeCNAMERequest req)
        {
             JsonResponseModel<DescribeCNAMEResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCNAME");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCNAMEResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备的通道。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChannelRequest"/></param>
        /// <returns><see cref="DescribeDeviceChannelResponse"/></returns>
        public async Task<DescribeDeviceChannelResponse> DescribeDeviceChannel(DescribeDeviceChannelRequest req)
        {
             JsonResponseModel<DescribeDeviceChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备的通道。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChannelRequest"/></param>
        /// <returns><see cref="DescribeDeviceChannelResponse"/></returns>
        public DescribeDeviceChannelResponse DescribeDeviceChannelSync(DescribeDeviceChannelRequest req)
        {
             JsonResponseModel<DescribeDeviceChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备通道预置位信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePresetRequest"/></param>
        /// <returns><see cref="DescribeDevicePresetResponse"/></returns>
        public async Task<DescribeDevicePresetResponse> DescribeDevicePreset(DescribeDevicePresetRequest req)
        {
             JsonResponseModel<DescribeDevicePresetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicePreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备通道预置位信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePresetRequest"/></param>
        /// <returns><see cref="DescribeDevicePresetResponse"/></returns>
        public DescribeDevicePresetResponse DescribeDevicePresetSync(DescribeDevicePresetRequest req)
        {
             JsonResponseModel<DescribeDevicePresetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevicePreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于添加设备时，查询设备可以使用的服务节点，查询结果为已经绑定了域名的服务节点。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRegionRequest"/></param>
        /// <returns><see cref="DescribeDeviceRegionResponse"/></returns>
        public async Task<DescribeDeviceRegionResponse> DescribeDeviceRegion(DescribeDeviceRegionRequest req)
        {
             JsonResponseModel<DescribeDeviceRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于添加设备时，查询设备可以使用的服务节点，查询结果为已经绑定了域名的服务节点。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRegionRequest"/></param>
        /// <returns><see cref="DescribeDeviceRegionResponse"/></returns>
        public DescribeDeviceRegionResponse DescribeDeviceRegionSync(DescribeDeviceRegionRequest req)
        {
             JsonResponseModel<DescribeDeviceRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询添加的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public async Task<DescribeDomainResponse> DescribeDomain(DescribeDomainRequest req)
        {
             JsonResponseModel<DescribeDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询添加的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public DescribeDomainResponse DescribeDomainSync(DescribeDomainRequest req)
        {
             JsonResponseModel<DescribeDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于用户添加域名时，查询可以绑定的服务节点，结果为平台支持的所有服务节点。（注意：每个服务节点只能绑定一个域名）
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRegionRequest"/></param>
        /// <returns><see cref="DescribeDomainRegionResponse"/></returns>
        public async Task<DescribeDomainRegionResponse> DescribeDomainRegion(DescribeDomainRegionRequest req)
        {
             JsonResponseModel<DescribeDomainRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于用户添加域名时，查询可以绑定的服务节点，结果为平台支持的所有服务节点。（注意：每个服务节点只能绑定一个域名）
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRegionRequest"/></param>
        /// <returns><see cref="DescribeDomainRegionResponse"/></returns>
        public DescribeDomainRegionResponse DescribeDomainRegionSync(DescribeDomainRegionRequest req)
        {
             JsonResponseModel<DescribeDomainRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayRequest"/></param>
        /// <returns><see cref="DescribeGatewayResponse"/></returns>
        public async Task<DescribeGatewayResponse> DescribeGateway(DescribeGatewayRequest req)
        {
             JsonResponseModel<DescribeGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayRequest"/></param>
        /// <returns><see cref="DescribeGatewayResponse"/></returns>
        public DescribeGatewayResponse DescribeGatewaySync(DescribeGatewayRequest req)
        {
             JsonResponseModel<DescribeGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关的数据及流量监控信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorResponse"/></returns>
        public async Task<DescribeGatewayMonitorResponse> DescribeGatewayMonitor(DescribeGatewayMonitorRequest req)
        {
             JsonResponseModel<DescribeGatewayMonitorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关的数据及流量监控信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayMonitorRequest"/></param>
        /// <returns><see cref="DescribeGatewayMonitorResponse"/></returns>
        public DescribeGatewayMonitorResponse DescribeGatewayMonitorSync(DescribeGatewayMonitorRequest req)
        {
             JsonResponseModel<DescribeGatewayMonitorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询网关接入协议。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayProtocolRequest"/></param>
        /// <returns><see cref="DescribeGatewayProtocolResponse"/></returns>
        public async Task<DescribeGatewayProtocolResponse> DescribeGatewayProtocol(DescribeGatewayProtocolRequest req)
        {
             JsonResponseModel<DescribeGatewayProtocolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayProtocol");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayProtocolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询网关接入协议。
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayProtocolRequest"/></param>
        /// <returns><see cref="DescribeGatewayProtocolResponse"/></returns>
        public DescribeGatewayProtocolResponse DescribeGatewayProtocolSync(DescribeGatewayProtocolRequest req)
        {
             JsonResponseModel<DescribeGatewayProtocolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayProtocol");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayProtocolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关服务版本
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayVersionRequest"/></param>
        /// <returns><see cref="DescribeGatewayVersionResponse"/></returns>
        public async Task<DescribeGatewayVersionResponse> DescribeGatewayVersion(DescribeGatewayVersionRequest req)
        {
             JsonResponseModel<DescribeGatewayVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网关服务版本
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayVersionRequest"/></param>
        /// <returns><see cref="DescribeGatewayVersionResponse"/></returns>
        public DescribeGatewayVersionResponse DescribeGatewayVersionSync(DescribeGatewayVersionRequest req)
        {
             JsonResponseModel<DescribeGatewayVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询组织。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public async Task<DescribeOrganizationResponse> DescribeOrganization(DescribeOrganizationRequest req)
        {
             JsonResponseModel<DescribeOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询组织。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public DescribeOrganizationResponse DescribeOrganizationSync(DescribeOrganizationRequest req)
        {
             JsonResponseModel<DescribeOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云计划详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupPlanResponse"/></returns>
        public async Task<DescribeRecordBackupPlanResponse> DescribeRecordBackupPlan(DescribeRecordBackupPlanRequest req)
        {
             JsonResponseModel<DescribeRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云计划详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupPlanResponse"/></returns>
        public DescribeRecordBackupPlanResponse DescribeRecordBackupPlanSync(DescribeRecordBackupPlanRequest req)
        {
             JsonResponseModel<DescribeRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupTemplateResponse"/></returns>
        public async Task<DescribeRecordBackupTemplateResponse> DescribeRecordBackupTemplate(DescribeRecordBackupTemplateRequest req)
        {
             JsonResponseModel<DescribeRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupTemplateResponse"/></returns>
        public DescribeRecordBackupTemplateResponse DescribeRecordBackupTemplateSync(DescribeRecordBackupTemplateRequest req)
        {
             JsonResponseModel<DescribeRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备云端录像时间轴信息（即为视频上云后设置录像计划后云存储的录像）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeRecordFileResponse"/></returns>
        public async Task<DescribeRecordFileResponse> DescribeRecordFile(DescribeRecordFileRequest req)
        {
             JsonResponseModel<DescribeRecordFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备云端录像时间轴信息（即为视频上云后设置录像计划后云存储的录像）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeRecordFileResponse"/></returns>
        public DescribeRecordFileResponse DescribeRecordFileSync(DescribeRecordFileRequest req)
        {
             JsonResponseModel<DescribeRecordFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordPlanResponse"/></returns>
        public async Task<DescribeRecordPlanResponse> DescribeRecordPlan(DescribeRecordPlanRequest req)
        {
             JsonResponseModel<DescribeRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordPlanResponse"/></returns>
        public DescribeRecordPlanResponse DescribeRecordPlanSync(DescribeRecordPlanRequest req)
        {
             JsonResponseModel<DescribeRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取云端录像回放url地址
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlaybackUrlRequest"/></param>
        /// <returns><see cref="DescribeRecordPlaybackUrlResponse"/></returns>
        public async Task<DescribeRecordPlaybackUrlResponse> DescribeRecordPlaybackUrl(DescribeRecordPlaybackUrlRequest req)
        {
             JsonResponseModel<DescribeRecordPlaybackUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordPlaybackUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordPlaybackUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取云端录像回放url地址
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlaybackUrlRequest"/></param>
        /// <returns><see cref="DescribeRecordPlaybackUrlResponse"/></returns>
        public DescribeRecordPlaybackUrlResponse DescribeRecordPlaybackUrlSync(DescribeRecordPlaybackUrlRequest req)
        {
             JsonResponseModel<DescribeRecordPlaybackUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordPlaybackUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordPlaybackUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询云录像取回任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordRetrieveTaskResponse"/></returns>
        public async Task<DescribeRecordRetrieveTaskResponse> DescribeRecordRetrieveTask(DescribeRecordRetrieveTaskRequest req)
        {
             JsonResponseModel<DescribeRecordRetrieveTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordRetrieveTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordRetrieveTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询云录像取回任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordRetrieveTaskResponse"/></returns>
        public DescribeRecordRetrieveTaskResponse DescribeRecordRetrieveTaskSync(DescribeRecordRetrieveTaskRequest req)
        {
             JsonResponseModel<DescribeRecordRetrieveTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordRetrieveTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordRetrieveTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 平台支持将数据以TS切片的形式存入客户自有COS桶，该接口用于支持客户快捷查询切片信息列表
        /// （注意：只支持标准存储类型的查询）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSliceRequest"/></param>
        /// <returns><see cref="DescribeRecordSliceResponse"/></returns>
        public async Task<DescribeRecordSliceResponse> DescribeRecordSlice(DescribeRecordSliceRequest req)
        {
             JsonResponseModel<DescribeRecordSliceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordSlice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSliceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 平台支持将数据以TS切片的形式存入客户自有COS桶，该接口用于支持客户快捷查询切片信息列表
        /// （注意：只支持标准存储类型的查询）
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordSliceRequest"/></param>
        /// <returns><see cref="DescribeRecordSliceResponse"/></returns>
        public DescribeRecordSliceResponse DescribeRecordSliceSync(DescribeRecordSliceRequest req)
        {
             JsonResponseModel<DescribeRecordSliceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordSlice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordSliceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordTemplateResponse"/></returns>
        public async Task<DescribeRecordTemplateResponse> DescribeRecordTemplate(DescribeRecordTemplateRequest req)
        {
             JsonResponseModel<DescribeRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordTemplateResponse"/></returns>
        public DescribeRecordTemplateResponse DescribeRecordTemplateSync(DescribeRecordTemplateRequest req)
        {
             JsonResponseModel<DescribeRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamAuthRequest"/></param>
        /// <returns><see cref="DescribeStreamAuthResponse"/></returns>
        public async Task<DescribeStreamAuthResponse> DescribeStreamAuth(DescribeStreamAuthRequest req)
        {
             JsonResponseModel<DescribeStreamAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询推拉流鉴权配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamAuthRequest"/></param>
        /// <returns><see cref="DescribeStreamAuthResponse"/></returns>
        public DescribeStreamAuthResponse DescribeStreamAuthSync(DescribeStreamAuthRequest req)
        {
             JsonResponseModel<DescribeStreamAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询任务详情
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
        /// 用于查询任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
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
        /// 用于查询设备的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceResponse"/></returns>
        public async Task<DescribeUserDeviceResponse> DescribeUserDevice(DescribeUserDeviceRequest req)
        {
             JsonResponseModel<DescribeUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询设备的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceResponse"/></returns>
        public DescribeUserDeviceResponse DescribeUserDeviceSync(DescribeUserDeviceRequest req)
        {
             JsonResponseModel<DescribeUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取视频通道的码率信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoBitRateRequest"/></param>
        /// <returns><see cref="DescribeVideoBitRateResponse"/></returns>
        public async Task<DescribeVideoBitRateResponse> DescribeVideoBitRate(DescribeVideoBitRateRequest req)
        {
             JsonResponseModel<DescribeVideoBitRateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoBitRate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoBitRateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取视频通道的码率信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoBitRateRequest"/></param>
        /// <returns><see cref="DescribeVideoBitRateResponse"/></returns>
        public DescribeVideoBitRateResponse DescribeVideoBitRateSync(DescribeVideoBitRateRequest req)
        {
             JsonResponseModel<DescribeVideoBitRateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoBitRate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoBitRateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取云录像下载 url
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVideoDownloadUrlResponse"/></returns>
        public async Task<DescribeVideoDownloadUrlResponse> DescribeVideoDownloadUrl(DescribeVideoDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeVideoDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取云录像下载 url
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVideoDownloadUrlResponse"/></returns>
        public DescribeVideoDownloadUrlResponse DescribeVideoDownloadUrlSync(DescribeVideoDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeVideoDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AI任务列表
        /// </summary>
        /// <param name="req"><see cref="ListAITasksRequest"/></param>
        /// <returns><see cref="ListAITasksResponse"/></returns>
        public async Task<ListAITasksResponse> ListAITasks(ListAITasksRequest req)
        {
             JsonResponseModel<ListAITasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAITasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAITasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取AI任务列表
        /// </summary>
        /// <param name="req"><see cref="ListAITasksRequest"/></param>
        /// <returns><see cref="ListAITasksResponse"/></returns>
        public ListAITasksResponse ListAITasksSync(ListAITasksRequest req)
        {
             JsonResponseModel<ListAITasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAITasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAITasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取对应组织下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListDevicesRequest"/></param>
        /// <returns><see cref="ListDevicesResponse"/></returns>
        public async Task<ListDevicesResponse> ListDevices(ListDevicesRequest req)
        {
             JsonResponseModel<ListDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取对应组织下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListDevicesRequest"/></param>
        /// <returns><see cref="ListDevicesResponse"/></returns>
        public ListDevicesResponse ListDevicesSync(ListDevicesRequest req)
        {
             JsonResponseModel<ListDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询网关下挂载的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewayDevicesRequest"/></param>
        /// <returns><see cref="ListGatewayDevicesResponse"/></returns>
        public async Task<ListGatewayDevicesResponse> ListGatewayDevices(ListGatewayDevicesRequest req)
        {
             JsonResponseModel<ListGatewayDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListGatewayDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGatewayDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询网关下挂载的设备列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewayDevicesRequest"/></param>
        /// <returns><see cref="ListGatewayDevicesResponse"/></returns>
        public ListGatewayDevicesResponse ListGatewayDevicesSync(ListGatewayDevicesRequest req)
        {
             JsonResponseModel<ListGatewayDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListGatewayDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGatewayDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewaysRequest"/></param>
        /// <returns><see cref="ListGatewaysResponse"/></returns>
        public async Task<ListGatewaysResponse> ListGateways(ListGatewaysRequest req)
        {
             JsonResponseModel<ListGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关列表。
        /// </summary>
        /// <param name="req"><see cref="ListGatewaysRequest"/></param>
        /// <returns><see cref="ListGatewaysResponse"/></returns>
        public ListGatewaysResponse ListGatewaysSync(ListGatewaysRequest req)
        {
             JsonResponseModel<ListGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询组织目录下的未添加到实时上云计划中的通道数量
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelNumbersRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelNumbersResponse"/></returns>
        public async Task<ListOrganizationChannelNumbersResponse> ListOrganizationChannelNumbers(ListOrganizationChannelNumbersRequest req)
        {
             JsonResponseModel<ListOrganizationChannelNumbersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationChannelNumbers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationChannelNumbersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询组织目录下的未添加到实时上云计划中的通道数量
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelNumbersRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelNumbersResponse"/></returns>
        public ListOrganizationChannelNumbersResponse ListOrganizationChannelNumbersSync(ListOrganizationChannelNumbersRequest req)
        {
             JsonResponseModel<ListOrganizationChannelNumbersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListOrganizationChannelNumbers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationChannelNumbersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询组织目录下的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelsRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelsResponse"/></returns>
        public async Task<ListOrganizationChannelsResponse> ListOrganizationChannels(ListOrganizationChannelsRequest req)
        {
             JsonResponseModel<ListOrganizationChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListOrganizationChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询组织目录下的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelsRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelsResponse"/></returns>
        public ListOrganizationChannelsResponse ListOrganizationChannelsSync(ListOrganizationChannelsRequest req)
        {
             JsonResponseModel<ListOrganizationChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListOrganizationChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListOrganizationChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云计划下的设备通道列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlanDevicesResponse"/></returns>
        public async Task<ListRecordBackupPlanDevicesResponse> ListRecordBackupPlanDevices(ListRecordBackupPlanDevicesRequest req)
        {
             JsonResponseModel<ListRecordBackupPlanDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordBackupPlanDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordBackupPlanDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云计划下的设备通道列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlanDevicesResponse"/></returns>
        public ListRecordBackupPlanDevicesResponse ListRecordBackupPlanDevicesSync(ListRecordBackupPlanDevicesRequest req)
        {
             JsonResponseModel<ListRecordBackupPlanDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordBackupPlanDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordBackupPlanDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云计划列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlansRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlansResponse"/></returns>
        public async Task<ListRecordBackupPlansResponse> ListRecordBackupPlans(ListRecordBackupPlansRequest req)
        {
             JsonResponseModel<ListRecordBackupPlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordBackupPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordBackupPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云计划列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlansRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlansResponse"/></returns>
        public ListRecordBackupPlansResponse ListRecordBackupPlansSync(ListRecordBackupPlansRequest req)
        {
             JsonResponseModel<ListRecordBackupPlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordBackupPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordBackupPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云模板列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordBackupTemplatesResponse"/></returns>
        public async Task<ListRecordBackupTemplatesResponse> ListRecordBackupTemplates(ListRecordBackupTemplatesRequest req)
        {
             JsonResponseModel<ListRecordBackupTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordBackupTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordBackupTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询录像上云模板列表。
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordBackupTemplatesResponse"/></returns>
        public ListRecordBackupTemplatesResponse ListRecordBackupTemplatesSync(ListRecordBackupTemplatesRequest req)
        {
             JsonResponseModel<ListRecordBackupTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordBackupTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordBackupTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询用户下所有实时上云计划中的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanChannelsRequest"/></param>
        /// <returns><see cref="ListRecordPlanChannelsResponse"/></returns>
        public async Task<ListRecordPlanChannelsResponse> ListRecordPlanChannels(ListRecordPlanChannelsRequest req)
        {
             JsonResponseModel<ListRecordPlanChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordPlanChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordPlanChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询用户下所有实时上云计划中的通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanChannelsRequest"/></param>
        /// <returns><see cref="ListRecordPlanChannelsResponse"/></returns>
        public ListRecordPlanChannelsResponse ListRecordPlanChannelsSync(ListRecordPlanChannelsRequest req)
        {
             JsonResponseModel<ListRecordPlanChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordPlanChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordPlanChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云计划下的设备通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordPlanDevicesResponse"/></returns>
        public async Task<ListRecordPlanDevicesResponse> ListRecordPlanDevices(ListRecordPlanDevicesRequest req)
        {
             JsonResponseModel<ListRecordPlanDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordPlanDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordPlanDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云计划下的设备通道列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordPlanDevicesResponse"/></returns>
        public ListRecordPlanDevicesResponse ListRecordPlanDevicesSync(ListRecordPlanDevicesRequest req)
        {
             JsonResponseModel<ListRecordPlanDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordPlanDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordPlanDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云计划列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlansRequest"/></param>
        /// <returns><see cref="ListRecordPlansResponse"/></returns>
        public async Task<ListRecordPlansResponse> ListRecordPlans(ListRecordPlansRequest req)
        {
             JsonResponseModel<ListRecordPlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云计划列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlansRequest"/></param>
        /// <returns><see cref="ListRecordPlansResponse"/></returns>
        public ListRecordPlansResponse ListRecordPlansSync(ListRecordPlansRequest req)
        {
             JsonResponseModel<ListRecordPlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询取回任务列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordRetrieveTasksRequest"/></param>
        /// <returns><see cref="ListRecordRetrieveTasksResponse"/></returns>
        public async Task<ListRecordRetrieveTasksResponse> ListRecordRetrieveTasks(ListRecordRetrieveTasksRequest req)
        {
             JsonResponseModel<ListRecordRetrieveTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordRetrieveTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordRetrieveTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询取回任务列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordRetrieveTasksRequest"/></param>
        /// <returns><see cref="ListRecordRetrieveTasksResponse"/></returns>
        public ListRecordRetrieveTasksResponse ListRecordRetrieveTasksSync(ListRecordRetrieveTasksRequest req)
        {
             JsonResponseModel<ListRecordRetrieveTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordRetrieveTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordRetrieveTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云模板列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordTemplatesResponse"/></returns>
        public async Task<ListRecordTemplatesResponse> ListRecordTemplates(ListRecordTemplatesRequest req)
        {
             JsonResponseModel<ListRecordTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListRecordTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询实时上云模板列表
        /// </summary>
        /// <param name="req"><see cref="ListRecordTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordTemplatesResponse"/></returns>
        public ListRecordTemplatesResponse ListRecordTemplatesSync(ListRecordTemplatesRequest req)
        {
             JsonResponseModel<ListRecordTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListRecordTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListRecordTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询任务的子任务列表
        /// </summary>
        /// <param name="req"><see cref="ListSubTasksRequest"/></param>
        /// <returns><see cref="ListSubTasksResponse"/></returns>
        public async Task<ListSubTasksResponse> ListSubTasks(ListSubTasksRequest req)
        {
             JsonResponseModel<ListSubTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSubTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSubTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询任务的子任务列表
        /// </summary>
        /// <param name="req"><see cref="ListSubTasksRequest"/></param>
        /// <returns><see cref="ListSubTasksResponse"/></returns>
        public ListSubTasksResponse ListSubTasksSync(ListSubTasksRequest req)
        {
             JsonResponseModel<ListSubTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSubTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSubTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询批量任务和简单任务列表
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public async Task<ListTasksResponse> ListTasks(ListTasksRequest req)
        {
             JsonResponseModel<ListTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询批量任务和简单任务列表
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public ListTasksResponse ListTasksSync(ListTasksRequest req)
        {
             JsonResponseModel<ListTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备本地录像 URL 地址。
        /// </summary>
        /// <param name="req"><see cref="PlayRecordRequest"/></param>
        /// <returns><see cref="PlayRecordResponse"/></returns>
        public async Task<PlayRecordResponse> PlayRecord(PlayRecordRequest req)
        {
             JsonResponseModel<PlayRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PlayRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PlayRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备本地录像 URL 地址。
        /// </summary>
        /// <param name="req"><see cref="PlayRecordRequest"/></param>
        /// <returns><see cref="PlayRecordResponse"/></returns>
        public PlayRecordResponse PlayRecordSync(PlayRecordRequest req)
        {
             JsonResponseModel<PlayRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PlayRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PlayRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于刷新国标设备的通道（接口调用后，触发向设备请求通道列表，新增的通道入库，设备上已删除的通道需自行删除、后台不自动删除）。
        /// </summary>
        /// <param name="req"><see cref="RefreshDeviceChannelRequest"/></param>
        /// <returns><see cref="RefreshDeviceChannelResponse"/></returns>
        public async Task<RefreshDeviceChannelResponse> RefreshDeviceChannel(RefreshDeviceChannelRequest req)
        {
             JsonResponseModel<RefreshDeviceChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefreshDeviceChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDeviceChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于刷新国标设备的通道（接口调用后，触发向设备请求通道列表，新增的通道入库，设备上已删除的通道需自行删除、后台不自动删除）。
        /// </summary>
        /// <param name="req"><see cref="RefreshDeviceChannelRequest"/></param>
        /// <returns><see cref="RefreshDeviceChannelResponse"/></returns>
        public RefreshDeviceChannelResponse RefreshDeviceChannelSync(RefreshDeviceChannelRequest req)
        {
             JsonResponseModel<RefreshDeviceChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefreshDeviceChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDeviceChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新AI任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskRequest"/></param>
        /// <returns><see cref="UpdateAITaskResponse"/></returns>
        public async Task<UpdateAITaskResponse> UpdateAITask(UpdateAITaskRequest req)
        {
             JsonResponseModel<UpdateAITaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新AI任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskRequest"/></param>
        /// <returns><see cref="UpdateAITaskResponse"/></returns>
        public UpdateAITaskResponse UpdateAITaskSync(UpdateAITaskRequest req)
        {
             JsonResponseModel<UpdateAITaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAITask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAITaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新 AI 任务状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskStatusRequest"/></param>
        /// <returns><see cref="UpdateAITaskStatusResponse"/></returns>
        public async Task<UpdateAITaskStatusResponse> UpdateAITaskStatus(UpdateAITaskStatusRequest req)
        {
             JsonResponseModel<UpdateAITaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAITaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAITaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新 AI 任务状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAITaskStatusRequest"/></param>
        /// <returns><see cref="UpdateAITaskStatusResponse"/></returns>
        public UpdateAITaskStatusResponse UpdateAITaskStatusSync(UpdateAITaskStatusRequest req)
        {
             JsonResponseModel<UpdateAITaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAITaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAITaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量更改设备的组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceOrganizationRequest"/></param>
        /// <returns><see cref="UpdateDeviceOrganizationResponse"/></returns>
        public async Task<UpdateDeviceOrganizationResponse> UpdateDeviceOrganization(UpdateDeviceOrganizationRequest req)
        {
             JsonResponseModel<UpdateDeviceOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于批量更改设备的组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceOrganizationRequest"/></param>
        /// <returns><see cref="UpdateDeviceOrganizationResponse"/></returns>
        public UpdateDeviceOrganizationResponse UpdateDeviceOrganizationSync(UpdateDeviceOrganizationRequest req)
        {
             JsonResponseModel<UpdateDeviceOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于启用/禁用设备，禁用后拒绝设备注册。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceStatusResponse"/></returns>
        public async Task<UpdateDeviceStatusResponse> UpdateDeviceStatus(UpdateDeviceStatusRequest req)
        {
             JsonResponseModel<UpdateDeviceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于启用/禁用设备，禁用后拒绝设备注册。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceStatusResponse"/></returns>
        public UpdateDeviceStatusResponse UpdateDeviceStatusSync(UpdateDeviceStatusRequest req)
        {
             JsonResponseModel<UpdateDeviceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改网关信息（支持对网关名称和描述的修改）。
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayRequest"/></param>
        /// <returns><see cref="UpdateGatewayResponse"/></returns>
        public async Task<UpdateGatewayResponse> UpdateGateway(UpdateGatewayRequest req)
        {
             JsonResponseModel<UpdateGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改网关信息（支持对网关名称和描述的修改）。
        /// </summary>
        /// <param name="req"><see cref="UpdateGatewayRequest"/></param>
        /// <returns><see cref="UpdateGatewayResponse"/></returns>
        public UpdateGatewayResponse UpdateGatewaySync(UpdateGatewayRequest req)
        {
             JsonResponseModel<UpdateGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationRequest"/></param>
        /// <returns><see cref="UpdateOrganizationResponse"/></returns>
        public async Task<UpdateOrganizationResponse> UpdateOrganization(UpdateOrganizationRequest req)
        {
             JsonResponseModel<UpdateOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改组织。
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationRequest"/></param>
        /// <returns><see cref="UpdateOrganizationResponse"/></returns>
        public UpdateOrganizationResponse UpdateOrganizationSync(UpdateOrganizationRequest req)
        {
             JsonResponseModel<UpdateOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改录像上云计划。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupPlanResponse"/></returns>
        public async Task<UpdateRecordBackupPlanResponse> UpdateRecordBackupPlan(UpdateRecordBackupPlanRequest req)
        {
             JsonResponseModel<UpdateRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改录像上云计划。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupPlanResponse"/></returns>
        public UpdateRecordBackupPlanResponse UpdateRecordBackupPlanSync(UpdateRecordBackupPlanRequest req)
        {
             JsonResponseModel<UpdateRecordBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRecordBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupTemplateResponse"/></returns>
        public async Task<UpdateRecordBackupTemplateResponse> UpdateRecordBackupTemplate(UpdateRecordBackupTemplateRequest req)
        {
             JsonResponseModel<UpdateRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改录像上云模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupTemplateResponse"/></returns>
        public UpdateRecordBackupTemplateResponse UpdateRecordBackupTemplateSync(UpdateRecordBackupTemplateRequest req)
        {
             JsonResponseModel<UpdateRecordBackupTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRecordBackupTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordBackupTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改实时上云计划
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public async Task<UpdateRecordPlanResponse> UpdateRecordPlan(UpdateRecordPlanRequest req)
        {
             JsonResponseModel<UpdateRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改实时上云计划
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public UpdateRecordPlanResponse UpdateRecordPlanSync(UpdateRecordPlanRequest req)
        {
             JsonResponseModel<UpdateRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改实时上云模板
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordTemplateResponse"/></returns>
        public async Task<UpdateRecordTemplateResponse> UpdateRecordTemplate(UpdateRecordTemplateRequest req)
        {
             JsonResponseModel<UpdateRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改实时上云模板
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordTemplateResponse"/></returns>
        public UpdateRecordTemplateResponse UpdateRecordTemplateSync(UpdateRecordTemplateRequest req)
        {
             JsonResponseModel<UpdateRecordTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRecordTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改设备的配置信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDeviceRequest"/></param>
        /// <returns><see cref="UpdateUserDeviceResponse"/></returns>
        public async Task<UpdateUserDeviceResponse> UpdateUserDevice(UpdateUserDeviceRequest req)
        {
             JsonResponseModel<UpdateUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改设备的配置信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDeviceRequest"/></param>
        /// <returns><see cref="UpdateUserDeviceResponse"/></returns>
        public UpdateUserDeviceResponse UpdateUserDeviceSync(UpdateUserDeviceRequest req)
        {
             JsonResponseModel<UpdateUserDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateUserDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于网关升级（支持对所有待更新的服务一键升级）。
        /// </summary>
        /// <param name="req"><see cref="UpgradeGatewayRequest"/></param>
        /// <returns><see cref="UpgradeGatewayResponse"/></returns>
        public async Task<UpgradeGatewayResponse> UpgradeGateway(UpgradeGatewayRequest req)
        {
             JsonResponseModel<UpgradeGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于网关升级（支持对所有待更新的服务一键升级）。
        /// </summary>
        /// <param name="req"><see cref="UpgradeGatewayRequest"/></param>
        /// <returns><see cref="UpgradeGatewayResponse"/></returns>
        public UpgradeGatewayResponse UpgradeGatewaySync(UpgradeGatewayRequest req)
        {
             JsonResponseModel<UpgradeGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
