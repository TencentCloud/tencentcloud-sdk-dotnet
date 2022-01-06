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

namespace TencentCloud.Iotvideoindustry.V20201201
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotvideoindustry.V20201201.Models;

   public class IotvideoindustryClient : AbstractClient{

       private const string endpoint = "iotvideoindustry.tencentcloudapi.com";
       private const string version = "2020-12-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotvideoindustryClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotvideoindustryClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(BindGroupDevices) 用于绑定设备到分组。
        /// </summary>
        /// <param name="req"><see cref="BindGroupDevicesRequest"/></param>
        /// <returns><see cref="BindGroupDevicesResponse"/></returns>
        public async Task<BindGroupDevicesResponse> BindGroupDevices(BindGroupDevicesRequest req)
        {
             JsonResponseModel<BindGroupDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindGroupDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindGroupDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(BindGroupDevices) 用于绑定设备到分组。
        /// </summary>
        /// <param name="req"><see cref="BindGroupDevicesRequest"/></param>
        /// <returns><see cref="BindGroupDevicesResponse"/></returns>
        public BindGroupDevicesResponse BindGroupDevicesSync(BindGroupDevicesRequest req)
        {
             JsonResponseModel<BindGroupDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindGroupDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindGroupDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ControlChannelLocalRecord）用于对通道本地回放流进行控制，包括暂停、播放、拉动、结束等
        /// </summary>
        /// <param name="req"><see cref="ControlChannelLocalRecordRequest"/></param>
        /// <returns><see cref="ControlChannelLocalRecordResponse"/></returns>
        public async Task<ControlChannelLocalRecordResponse> ControlChannelLocalRecord(ControlChannelLocalRecordRequest req)
        {
             JsonResponseModel<ControlChannelLocalRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlChannelLocalRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlChannelLocalRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ControlChannelLocalRecord）用于对通道本地回放流进行控制，包括暂停、播放、拉动、结束等
        /// </summary>
        /// <param name="req"><see cref="ControlChannelLocalRecordRequest"/></param>
        /// <returns><see cref="ControlChannelLocalRecordResponse"/></returns>
        public ControlChannelLocalRecordResponse ControlChannelLocalRecordSync(ControlChannelLocalRecordRequest req)
        {
             JsonResponseModel<ControlChannelLocalRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlChannelLocalRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlChannelLocalRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ControlChannelPTZ) 用于对支持GB28181 PTZ信令的设备进行指定通道的远程控制。
        /// </summary>
        /// <param name="req"><see cref="ControlChannelPTZRequest"/></param>
        /// <returns><see cref="ControlChannelPTZResponse"/></returns>
        public async Task<ControlChannelPTZResponse> ControlChannelPTZ(ControlChannelPTZRequest req)
        {
             JsonResponseModel<ControlChannelPTZResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlChannelPTZ");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlChannelPTZResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ControlChannelPTZ) 用于对支持GB28181 PTZ信令的设备进行指定通道的远程控制。
        /// </summary>
        /// <param name="req"><see cref="ControlChannelPTZRequest"/></param>
        /// <returns><see cref="ControlChannelPTZResponse"/></returns>
        public ControlChannelPTZResponse ControlChannelPTZSync(ControlChannelPTZRequest req)
        {
             JsonResponseModel<ControlChannelPTZResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlChannelPTZ");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlChannelPTZResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ControlDevicePTZ) 用于对支持GB28181 PTZ信令的设备进行远程控制。
        /// 请使用ControlChannelPTZ接口
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
        /// 本接口(ControlDevicePTZ) 用于对支持GB28181 PTZ信令的设备进行远程控制。
        /// 请使用ControlChannelPTZ接口
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
        /// 看守位控制
        /// </summary>
        /// <param name="req"><see cref="ControlHomePositionRequest"/></param>
        /// <returns><see cref="ControlHomePositionResponse"/></returns>
        public async Task<ControlHomePositionResponse> ControlHomePosition(ControlHomePositionRequest req)
        {
             JsonResponseModel<ControlHomePositionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlHomePosition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlHomePositionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 看守位控制
        /// </summary>
        /// <param name="req"><see cref="ControlHomePositionRequest"/></param>
        /// <returns><see cref="ControlHomePositionResponse"/></returns>
        public ControlHomePositionResponse ControlHomePositionSync(ControlHomePositionRequest req)
        {
             JsonResponseModel<ControlHomePositionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlHomePosition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlHomePositionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预置位控制
        /// </summary>
        /// <param name="req"><see cref="ControlPresetRequest"/></param>
        /// <returns><see cref="ControlPresetResponse"/></returns>
        public async Task<ControlPresetResponse> ControlPreset(ControlPresetRequest req)
        {
             JsonResponseModel<ControlPresetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 预置位控制
        /// </summary>
        /// <param name="req"><see cref="ControlPresetRequest"/></param>
        /// <returns><see cref="ControlPresetResponse"/></returns>
        public ControlPresetResponse ControlPresetSync(ControlPresetRequest req)
        {
             JsonResponseModel<ControlPresetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对回放流进行控制，包括暂停、播放、拉动、结束等
        /// 请使用ControlChannelLocalRecord接口
        /// </summary>
        /// <param name="req"><see cref="ControlRecordStreamRequest"/></param>
        /// <returns><see cref="ControlRecordStreamResponse"/></returns>
        public async Task<ControlRecordStreamResponse> ControlRecordStream(ControlRecordStreamRequest req)
        {
             JsonResponseModel<ControlRecordStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlRecordStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlRecordStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对回放流进行控制，包括暂停、播放、拉动、结束等
        /// 请使用ControlChannelLocalRecord接口
        /// </summary>
        /// <param name="req"><see cref="ControlRecordStreamRequest"/></param>
        /// <returns><see cref="ControlRecordStreamResponse"/></returns>
        public ControlRecordStreamResponse ControlRecordStreamSync(ControlRecordStreamRequest req)
        {
             JsonResponseModel<ControlRecordStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlRecordStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlRecordStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDevice) 用于创建设备。
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
        /// 本接口(CreateDevice) 用于创建设备。
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
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
        /// 本接口(CreateDeviceGroup) 用于创建设备管理分组。
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public async Task<CreateDeviceGroupResponse> CreateDeviceGroup(CreateDeviceGroupRequest req)
        {
             JsonResponseModel<CreateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDeviceGroup) 用于创建设备管理分组。
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public CreateDeviceGroupResponse CreateDeviceGroupSync(CreateDeviceGroupRequest req)
        {
             JsonResponseModel<CreateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建直播频道
        /// </summary>
        /// <param name="req"><see cref="CreateLiveChannelRequest"/></param>
        /// <returns><see cref="CreateLiveChannelResponse"/></returns>
        public async Task<CreateLiveChannelResponse> CreateLiveChannel(CreateLiveChannelRequest req)
        {
             JsonResponseModel<CreateLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建直播频道
        /// </summary>
        /// <param name="req"><see cref="CreateLiveChannelRequest"/></param>
        /// <returns><see cref="CreateLiveChannelResponse"/></returns>
        public CreateLiveChannelResponse CreateLiveChannelSync(CreateLiveChannelRequest req)
        {
             JsonResponseModel<CreateLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建直播录制计划
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordPlanRequest"/></param>
        /// <returns><see cref="CreateLiveRecordPlanResponse"/></returns>
        public async Task<CreateLiveRecordPlanResponse> CreateLiveRecordPlan(CreateLiveRecordPlanRequest req)
        {
             JsonResponseModel<CreateLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建直播录制计划
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordPlanRequest"/></param>
        /// <returns><see cref="CreateLiveRecordPlanResponse"/></returns>
        public CreateLiveRecordPlanResponse CreateLiveRecordPlanSync(CreateLiveRecordPlanRequest req)
        {
             JsonResponseModel<CreateLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建消息转发配置
        /// </summary>
        /// <param name="req"><see cref="CreateMessageForwardRequest"/></param>
        /// <returns><see cref="CreateMessageForwardResponse"/></returns>
        public async Task<CreateMessageForwardResponse> CreateMessageForward(CreateMessageForwardRequest req)
        {
             JsonResponseModel<CreateMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建消息转发配置
        /// </summary>
        /// <param name="req"><see cref="CreateMessageForwardRequest"/></param>
        /// <returns><see cref="CreateMessageForwardResponse"/></returns>
        public CreateMessageForwardResponse CreateMessageForwardSync(CreateMessageForwardRequest req)
        {
             JsonResponseModel<CreateMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateRecordPlan) 用于创建录制计划，使设备与时间模板绑定，以便及时启动录制
        /// 请使用CreateRecordingPlan代替
        /// </summary>
        /// <param name="req"><see cref="CreateRecordPlanRequest"/></param>
        /// <returns><see cref="CreateRecordPlanResponse"/></returns>
        public async Task<CreateRecordPlanResponse> CreateRecordPlan(CreateRecordPlanRequest req)
        {
             JsonResponseModel<CreateRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateRecordPlan) 用于创建录制计划，使设备与时间模板绑定，以便及时启动录制
        /// 请使用CreateRecordingPlan代替
        /// </summary>
        /// <param name="req"><see cref="CreateRecordPlanRequest"/></param>
        /// <returns><see cref="CreateRecordPlanResponse"/></returns>
        public CreateRecordPlanResponse CreateRecordPlanSync(CreateRecordPlanRequest req)
        {
             JsonResponseModel<CreateRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateRecordingPlan) 用于创建录制计划，使通道与时间模板绑定，以便及时启动录制
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingPlanRequest"/></param>
        /// <returns><see cref="CreateRecordingPlanResponse"/></returns>
        public async Task<CreateRecordingPlanResponse> CreateRecordingPlan(CreateRecordingPlanRequest req)
        {
             JsonResponseModel<CreateRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateRecordingPlan) 用于创建录制计划，使通道与时间模板绑定，以便及时启动录制
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingPlanRequest"/></param>
        /// <returns><see cref="CreateRecordingPlanResponse"/></returns>
        public CreateRecordingPlanResponse CreateRecordingPlanSync(CreateRecordingPlanRequest req)
        {
             JsonResponseModel<CreateRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateSceneRequest"/></param>
        /// <returns><see cref="CreateSceneResponse"/></returns>
        public async Task<CreateSceneResponse> CreateScene(CreateSceneRequest req)
        {
             JsonResponseModel<CreateSceneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateSceneRequest"/></param>
        /// <returns><see cref="CreateSceneResponse"/></returns>
        public CreateSceneResponse CreateSceneSync(CreateSceneRequest req)
        {
             JsonResponseModel<CreateSceneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateTimeTemplate) 用于根据模板描述的具体录制时间片段，创建定制化的时间模板。
        /// </summary>
        /// <param name="req"><see cref="CreateTimeTemplateRequest"/></param>
        /// <returns><see cref="CreateTimeTemplateResponse"/></returns>
        public async Task<CreateTimeTemplateResponse> CreateTimeTemplate(CreateTimeTemplateRequest req)
        {
             JsonResponseModel<CreateTimeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTimeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTimeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateTimeTemplate) 用于根据模板描述的具体录制时间片段，创建定制化的时间模板。
        /// </summary>
        /// <param name="req"><see cref="CreateTimeTemplateRequest"/></param>
        /// <returns><see cref="CreateTimeTemplateResponse"/></returns>
        public CreateTimeTemplateResponse CreateTimeTemplateSync(CreateTimeTemplateRequest req)
        {
             JsonResponseModel<CreateTimeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTimeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTimeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除设备下的通道
        /// 注意： 在线状态的设备不允许删除
        /// </summary>
        /// <param name="req"><see cref="DeleteChannelRequest"/></param>
        /// <returns><see cref="DeleteChannelResponse"/></returns>
        public async Task<DeleteChannelResponse> DeleteChannel(DeleteChannelRequest req)
        {
             JsonResponseModel<DeleteChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除设备下的通道
        /// 注意： 在线状态的设备不允许删除
        /// </summary>
        /// <param name="req"><see cref="DeleteChannelRequest"/></param>
        /// <returns><see cref="DeleteChannelResponse"/></returns>
        public DeleteChannelResponse DeleteChannelSync(DeleteChannelRequest req)
        {
             JsonResponseModel<DeleteChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteDevice)用于删除设备。
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
        /// 本接口(DeleteDevice)用于删除设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
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
        /// 本接口(DeleteDeviceGroup)用于删除分组。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupResponse"/></returns>
        public async Task<DeleteDeviceGroupResponse> DeleteDeviceGroup(DeleteDeviceGroupRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteDeviceGroup)用于删除分组。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupResponse"/></returns>
        public DeleteDeviceGroupResponse DeleteDeviceGroupSync(DeleteDeviceGroupRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除直播接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteLiveChannelResponse"/></returns>
        public async Task<DeleteLiveChannelResponse> DeleteLiveChannel(DeleteLiveChannelRequest req)
        {
             JsonResponseModel<DeleteLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除直播接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteLiveChannelResponse"/></returns>
        public DeleteLiveChannelResponse DeleteLiveChannelSync(DeleteLiveChannelRequest req)
        {
             JsonResponseModel<DeleteLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除直播录制计划
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordPlanResponse"/></returns>
        public async Task<DeleteLiveRecordPlanResponse> DeleteLiveRecordPlan(DeleteLiveRecordPlanRequest req)
        {
             JsonResponseModel<DeleteLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除直播录制计划
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordPlanResponse"/></returns>
        public DeleteLiveRecordPlanResponse DeleteLiveRecordPlanSync(DeleteLiveRecordPlanRequest req)
        {
             JsonResponseModel<DeleteLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像删除
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveVideoListRequest"/></param>
        /// <returns><see cref="DeleteLiveVideoListResponse"/></returns>
        public async Task<DeleteLiveVideoListResponse> DeleteLiveVideoList(DeleteLiveVideoListRequest req)
        {
             JsonResponseModel<DeleteLiveVideoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLiveVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像删除
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveVideoListRequest"/></param>
        /// <returns><see cref="DeleteLiveVideoListResponse"/></returns>
        public DeleteLiveVideoListResponse DeleteLiveVideoListSync(DeleteLiveVideoListRequest req)
        {
             JsonResponseModel<DeleteLiveVideoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLiveVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLiveVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除消息转发配置
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageForwardRequest"/></param>
        /// <returns><see cref="DeleteMessageForwardResponse"/></returns>
        public async Task<DeleteMessageForwardResponse> DeleteMessageForward(DeleteMessageForwardRequest req)
        {
             JsonResponseModel<DeleteMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除消息转发配置
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageForwardRequest"/></param>
        /// <returns><see cref="DeleteMessageForwardResponse"/></returns>
        public DeleteMessageForwardResponse DeleteMessageForwardSync(DeleteMessageForwardRequest req)
        {
             JsonResponseModel<DeleteMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteRecordPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
        /// 请使用DeleteRecordingPlan接口
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
        /// 本接口(DeleteRecordPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
        /// 请使用DeleteRecordingPlan接口
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
        /// 本接口(DeleteRecordingPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordingPlanResponse"/></returns>
        public async Task<DeleteRecordingPlanResponse> DeleteRecordingPlan(DeleteRecordingPlanRequest req)
        {
             JsonResponseModel<DeleteRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteRecordingPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordingPlanResponse"/></returns>
        public DeleteRecordingPlanResponse DeleteRecordingPlanSync(DeleteRecordingPlanRequest req)
        {
             JsonResponseModel<DeleteRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteSceneRequest"/></param>
        /// <returns><see cref="DeleteSceneResponse"/></returns>
        public async Task<DeleteSceneResponse> DeleteScene(DeleteSceneRequest req)
        {
             JsonResponseModel<DeleteSceneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteSceneRequest"/></param>
        /// <returns><see cref="DeleteSceneResponse"/></returns>
        public DeleteSceneResponse DeleteSceneSync(DeleteSceneRequest req)
        {
             JsonResponseModel<DeleteSceneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteTimeTemplate) 用于删除时间模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTimeTemplateResponse"/></returns>
        public async Task<DeleteTimeTemplateResponse> DeleteTimeTemplate(DeleteTimeTemplateRequest req)
        {
             JsonResponseModel<DeleteTimeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTimeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTimeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteTimeTemplate) 用于删除时间模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTimeTemplateResponse"/></returns>
        public DeleteTimeTemplateResponse DeleteTimeTemplateSync(DeleteTimeTemplateRequest req)
        {
             JsonResponseModel<DeleteTimeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTimeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTimeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除录像存储列表
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoListRequest"/></param>
        /// <returns><see cref="DeleteVideoListResponse"/></returns>
        public async Task<DeleteVideoListResponse> DeleteVideoList(DeleteVideoListRequest req)
        {
             JsonResponseModel<DeleteVideoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除录像存储列表
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoListRequest"/></param>
        /// <returns><see cref="DeleteVideoListResponse"/></returns>
        public DeleteVideoListResponse DeleteVideoListSync(DeleteVideoListRequest req)
        {
             JsonResponseModel<DeleteVideoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备告警-删除告警
        /// </summary>
        /// <param name="req"><see cref="DeleteWarningRequest"/></param>
        /// <returns><see cref="DeleteWarningResponse"/></returns>
        public async Task<DeleteWarningResponse> DeleteWarning(DeleteWarningRequest req)
        {
             JsonResponseModel<DeleteWarningResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWarning");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWarningResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备告警-删除告警
        /// </summary>
        /// <param name="req"><see cref="DeleteWarningRequest"/></param>
        /// <returns><see cref="DeleteWarningResponse"/></returns>
        public DeleteWarningResponse DeleteWarningSync(DeleteWarningRequest req)
        {
             JsonResponseModel<DeleteWarningResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWarning");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWarningResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异常事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalEventsResponse"/></returns>
        public async Task<DescribeAbnormalEventsResponse> DescribeAbnormalEvents(DescribeAbnormalEventsRequest req)
        {
             JsonResponseModel<DescribeAbnormalEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异常事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalEventsResponse"/></returns>
        public DescribeAbnormalEventsResponse DescribeAbnormalEventsSync(DescribeAbnormalEventsRequest req)
        {
             JsonResponseModel<DescribeAbnormalEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAllDeviceList) 用于获取设备列表。
        /// 请使用DescribeDevicesList接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAllDeviceListRequest"/></param>
        /// <returns><see cref="DescribeAllDeviceListResponse"/></returns>
        public async Task<DescribeAllDeviceListResponse> DescribeAllDeviceList(DescribeAllDeviceListRequest req)
        {
             JsonResponseModel<DescribeAllDeviceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAllDeviceList) 用于获取设备列表。
        /// 请使用DescribeDevicesList接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAllDeviceListRequest"/></param>
        /// <returns><see cref="DescribeAllDeviceListResponse"/></returns>
        public DescribeAllDeviceListResponse DescribeAllDeviceListSync(DescribeAllDeviceListRequest req)
        {
             JsonResponseModel<DescribeAllDeviceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取场景绑定通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneChannelsRequest"/></param>
        /// <returns><see cref="DescribeBindSceneChannelsResponse"/></returns>
        public async Task<DescribeBindSceneChannelsResponse> DescribeBindSceneChannels(DescribeBindSceneChannelsRequest req)
        {
             JsonResponseModel<DescribeBindSceneChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindSceneChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindSceneChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取场景绑定通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneChannelsRequest"/></param>
        /// <returns><see cref="DescribeBindSceneChannelsResponse"/></returns>
        public DescribeBindSceneChannelsResponse DescribeBindSceneChannelsSync(DescribeBindSceneChannelsRequest req)
        {
             JsonResponseModel<DescribeBindSceneChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindSceneChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindSceneChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取场景绑定设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneDevicesRequest"/></param>
        /// <returns><see cref="DescribeBindSceneDevicesResponse"/></returns>
        public async Task<DescribeBindSceneDevicesResponse> DescribeBindSceneDevices(DescribeBindSceneDevicesRequest req)
        {
             JsonResponseModel<DescribeBindSceneDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindSceneDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindSceneDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取场景绑定设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneDevicesRequest"/></param>
        /// <returns><see cref="DescribeBindSceneDevicesResponse"/></returns>
        public DescribeBindSceneDevicesResponse DescribeBindSceneDevicesSync(DescribeBindSceneDevicesRequest req)
        {
             JsonResponseModel<DescribeBindSceneDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindSceneDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindSceneDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeChannelLocalRecordURL）用于将NVR等设备对应通道本地回放文件，通过GB28181信令推送至云端，并生成对应的实时视频流URL，流地址URL是动态生成，如需重新播放请重新调用此接口获取最新地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelLocalRecordURLRequest"/></param>
        /// <returns><see cref="DescribeChannelLocalRecordURLResponse"/></returns>
        public async Task<DescribeChannelLocalRecordURLResponse> DescribeChannelLocalRecordURL(DescribeChannelLocalRecordURLRequest req)
        {
             JsonResponseModel<DescribeChannelLocalRecordURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChannelLocalRecordURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelLocalRecordURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeChannelLocalRecordURL）用于将NVR等设备对应通道本地回放文件，通过GB28181信令推送至云端，并生成对应的实时视频流URL，流地址URL是动态生成，如需重新播放请重新调用此接口获取最新地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelLocalRecordURLRequest"/></param>
        /// <returns><see cref="DescribeChannelLocalRecordURLResponse"/></returns>
        public DescribeChannelLocalRecordURLResponse DescribeChannelLocalRecordURLSync(DescribeChannelLocalRecordURLRequest req)
        {
             JsonResponseModel<DescribeChannelLocalRecordURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChannelLocalRecordURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelLocalRecordURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeChannelStreamURL)用于获取设备指定通道实时流地址，地址是动态生成，如重新播放需要调用此接口重新获取最新播放地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelStreamURLRequest"/></param>
        /// <returns><see cref="DescribeChannelStreamURLResponse"/></returns>
        public async Task<DescribeChannelStreamURLResponse> DescribeChannelStreamURL(DescribeChannelStreamURLRequest req)
        {
             JsonResponseModel<DescribeChannelStreamURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChannelStreamURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelStreamURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeChannelStreamURL)用于获取设备指定通道实时流地址，地址是动态生成，如重新播放需要调用此接口重新获取最新播放地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelStreamURLRequest"/></param>
        /// <returns><see cref="DescribeChannelStreamURLResponse"/></returns>
        public DescribeChannelStreamURLResponse DescribeChannelStreamURLSync(DescribeChannelStreamURLRequest req)
        {
             JsonResponseModel<DescribeChannelStreamURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChannelStreamURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelStreamURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeChannels）用于获取设备下属通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsRequest"/></param>
        /// <returns><see cref="DescribeChannelsResponse"/></returns>
        public async Task<DescribeChannelsResponse> DescribeChannels(DescribeChannelsRequest req)
        {
             JsonResponseModel<DescribeChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeChannels）用于获取设备下属通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsRequest"/></param>
        /// <returns><see cref="DescribeChannelsResponse"/></returns>
        public DescribeChannelsResponse DescribeChannelsSync(DescribeChannelsRequest req)
        {
             JsonResponseModel<DescribeChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据直播录制计划获取频道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsByLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeChannelsByLiveRecordPlanResponse"/></returns>
        public async Task<DescribeChannelsByLiveRecordPlanResponse> DescribeChannelsByLiveRecordPlan(DescribeChannelsByLiveRecordPlanRequest req)
        {
             JsonResponseModel<DescribeChannelsByLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChannelsByLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelsByLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据直播录制计划获取频道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsByLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeChannelsByLiveRecordPlanResponse"/></returns>
        public DescribeChannelsByLiveRecordPlanResponse DescribeChannelsByLiveRecordPlanSync(DescribeChannelsByLiveRecordPlanRequest req)
        {
             JsonResponseModel<DescribeChannelsByLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChannelsByLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChannelsByLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备统计当前信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeCurrentDeviceDataResponse"/></returns>
        public async Task<DescribeCurrentDeviceDataResponse> DescribeCurrentDeviceData(DescribeCurrentDeviceDataRequest req)
        {
             JsonResponseModel<DescribeCurrentDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCurrentDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCurrentDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备统计当前信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeCurrentDeviceDataResponse"/></returns>
        public DescribeCurrentDeviceDataResponse DescribeCurrentDeviceDataSync(DescribeCurrentDeviceDataRequest req)
        {
             JsonResponseModel<DescribeCurrentDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCurrentDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCurrentDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定设备详细信息
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
        /// 获取指定设备详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
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
        /// 获取设备事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceEventRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventResponse"/></returns>
        public async Task<DescribeDeviceEventResponse> DescribeDeviceEvent(DescribeDeviceEventRequest req)
        {
             JsonResponseModel<DescribeDeviceEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceEventRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventResponse"/></returns>
        public DescribeDeviceEventResponse DescribeDeviceEventSync(DescribeDeviceEventRequest req)
        {
             JsonResponseModel<DescribeDeviceEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDeviceGroup)用于根据设备ID查询设备所在分组信息，可批量查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupResponse"/></returns>
        public async Task<DescribeDeviceGroupResponse> DescribeDeviceGroup(DescribeDeviceGroupRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDeviceGroup)用于根据设备ID查询设备所在分组信息，可批量查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupResponse"/></returns>
        public DescribeDeviceGroupResponse DescribeDeviceGroupSync(DescribeDeviceGroupRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDevicesList) 用于获取设备列表，支持模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public async Task<DescribeDeviceListResponse> DescribeDeviceList(DescribeDeviceListRequest req)
        {
             JsonResponseModel<DescribeDeviceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDevicesList) 用于获取设备列表，支持模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public DescribeDeviceListResponse DescribeDeviceListSync(DescribeDeviceListRequest req)
        {
             JsonResponseModel<DescribeDeviceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备统计monitor信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorDataResponse"/></returns>
        public async Task<DescribeDeviceMonitorDataResponse> DescribeDeviceMonitorData(DescribeDeviceMonitorDataRequest req)
        {
             JsonResponseModel<DescribeDeviceMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备统计monitor信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorDataResponse"/></returns>
        public DescribeDeviceMonitorDataResponse DescribeDeviceMonitorDataSync(DescribeDeviceMonitorDataRequest req)
        {
             JsonResponseModel<DescribeDeviceMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDevicePassWord)用于查询设备密码。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePassWordRequest"/></param>
        /// <returns><see cref="DescribeDevicePassWordResponse"/></returns>
        public async Task<DescribeDevicePassWordResponse> DescribeDevicePassWord(DescribeDevicePassWordRequest req)
        {
             JsonResponseModel<DescribeDevicePassWordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicePassWord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePassWordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDevicePassWord)用于查询设备密码。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePassWordRequest"/></param>
        /// <returns><see cref="DescribeDevicePassWordResponse"/></returns>
        public DescribeDevicePassWordResponse DescribeDevicePassWordSync(DescribeDevicePassWordRequest req)
        {
             JsonResponseModel<DescribeDevicePassWordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevicePassWord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePassWordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDeviceStreams)用于获取设备实时流地址。
        /// 请使用DescribeChannelStreamURL接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStreamsRequest"/></param>
        /// <returns><see cref="DescribeDeviceStreamsResponse"/></returns>
        public async Task<DescribeDeviceStreamsResponse> DescribeDeviceStreams(DescribeDeviceStreamsRequest req)
        {
             JsonResponseModel<DescribeDeviceStreamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceStreams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceStreamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDeviceStreams)用于获取设备实时流地址。
        /// 请使用DescribeChannelStreamURL接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStreamsRequest"/></param>
        /// <returns><see cref="DescribeDeviceStreamsResponse"/></returns>
        public DescribeDeviceStreamsResponse DescribeDeviceStreamsSync(DescribeDeviceStreamsRequest req)
        {
             JsonResponseModel<DescribeDeviceStreamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceStreams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceStreamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeGroupById)用于根据分组ID查询分组。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByIdRequest"/></param>
        /// <returns><see cref="DescribeGroupByIdResponse"/></returns>
        public async Task<DescribeGroupByIdResponse> DescribeGroupById(DescribeGroupByIdRequest req)
        {
             JsonResponseModel<DescribeGroupByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeGroupById)用于根据分组ID查询分组。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByIdRequest"/></param>
        /// <returns><see cref="DescribeGroupByIdResponse"/></returns>
        public DescribeGroupByIdResponse DescribeGroupByIdSync(DescribeGroupByIdRequest req)
        {
             JsonResponseModel<DescribeGroupByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据分组路径查询分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByPathRequest"/></param>
        /// <returns><see cref="DescribeGroupByPathResponse"/></returns>
        public async Task<DescribeGroupByPathResponse> DescribeGroupByPath(DescribeGroupByPathRequest req)
        {
             JsonResponseModel<DescribeGroupByPathResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupByPath");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupByPathResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据分组路径查询分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByPathRequest"/></param>
        /// <returns><see cref="DescribeGroupByPathResponse"/></returns>
        public DescribeGroupByPathResponse DescribeGroupByPathSync(DescribeGroupByPathRequest req)
        {
             JsonResponseModel<DescribeGroupByPathResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupByPath");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupByPathResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeGroupDevices)用于查询分组下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDevicesRequest"/></param>
        /// <returns><see cref="DescribeGroupDevicesResponse"/></returns>
        public async Task<DescribeGroupDevicesResponse> DescribeGroupDevices(DescribeGroupDevicesRequest req)
        {
             JsonResponseModel<DescribeGroupDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeGroupDevices)用于查询分组下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDevicesRequest"/></param>
        /// <returns><see cref="DescribeGroupDevicesResponse"/></returns>
        public DescribeGroupDevicesResponse DescribeGroupDevicesSync(DescribeGroupDevicesRequest req)
        {
             JsonResponseModel<DescribeGroupDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeGroups)用于批量查询分组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public async Task<DescribeGroupsResponse> DescribeGroups(DescribeGroupsRequest req)
        {
             JsonResponseModel<DescribeGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeGroups)用于批量查询分组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public DescribeGroupsResponse DescribeGroupsSync(DescribeGroupsRequest req)
        {
             JsonResponseModel<DescribeGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取IPC设备下属通道
        /// 请使用DescribeChannels接口
        /// </summary>
        /// <param name="req"><see cref="DescribeIPCChannelsRequest"/></param>
        /// <returns><see cref="DescribeIPCChannelsResponse"/></returns>
        public async Task<DescribeIPCChannelsResponse> DescribeIPCChannels(DescribeIPCChannelsRequest req)
        {
             JsonResponseModel<DescribeIPCChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPCChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPCChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取IPC设备下属通道
        /// 请使用DescribeChannels接口
        /// </summary>
        /// <param name="req"><see cref="DescribeIPCChannelsRequest"/></param>
        /// <returns><see cref="DescribeIPCChannelsResponse"/></returns>
        public DescribeIPCChannelsResponse DescribeIPCChannelsSync(DescribeIPCChannelsRequest req)
        {
             JsonResponseModel<DescribeIPCChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPCChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPCChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelResponse"/></returns>
        public async Task<DescribeLiveChannelResponse> DescribeLiveChannel(DescribeLiveChannelRequest req)
        {
             JsonResponseModel<DescribeLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelResponse"/></returns>
        public DescribeLiveChannelResponse DescribeLiveChannelSync(DescribeLiveChannelRequest req)
        {
             JsonResponseModel<DescribeLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelListRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelListResponse"/></returns>
        public async Task<DescribeLiveChannelListResponse> DescribeLiveChannelList(DescribeLiveChannelListRequest req)
        {
             JsonResponseModel<DescribeLiveChannelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveChannelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveChannelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelListRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelListResponse"/></returns>
        public DescribeLiveChannelListResponse DescribeLiveChannelListSync(DescribeLiveChannelListRequest req)
        {
             JsonResponseModel<DescribeLiveChannelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveChannelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveChannelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取直播录制计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanByIdResponse"/></returns>
        public async Task<DescribeLiveRecordPlanByIdResponse> DescribeLiveRecordPlanById(DescribeLiveRecordPlanByIdRequest req)
        {
             JsonResponseModel<DescribeLiveRecordPlanByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordPlanById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordPlanByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取直播录制计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanByIdResponse"/></returns>
        public DescribeLiveRecordPlanByIdResponse DescribeLiveRecordPlanByIdSync(DescribeLiveRecordPlanByIdRequest req)
        {
             JsonResponseModel<DescribeLiveRecordPlanByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordPlanById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordPlanByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取直播录制计划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanIdsRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanIdsResponse"/></returns>
        public async Task<DescribeLiveRecordPlanIdsResponse> DescribeLiveRecordPlanIds(DescribeLiveRecordPlanIdsRequest req)
        {
             JsonResponseModel<DescribeLiveRecordPlanIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveRecordPlanIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordPlanIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取直播录制计划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanIdsRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanIdsResponse"/></returns>
        public DescribeLiveRecordPlanIdsResponse DescribeLiveRecordPlanIdsSync(DescribeLiveRecordPlanIdsRequest req)
        {
             JsonResponseModel<DescribeLiveRecordPlanIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveRecordPlanIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveRecordPlanIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播拉流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamResponse"/></returns>
        public async Task<DescribeLiveStreamResponse> DescribeLiveStream(DescribeLiveStreamRequest req)
        {
             JsonResponseModel<DescribeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播拉流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamResponse"/></returns>
        public DescribeLiveStreamResponse DescribeLiveStreamSync(DescribeLiveStreamRequest req)
        {
             JsonResponseModel<DescribeLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像回放列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVideoListRequest"/></param>
        /// <returns><see cref="DescribeLiveVideoListResponse"/></returns>
        public async Task<DescribeLiveVideoListResponse> DescribeLiveVideoList(DescribeLiveVideoListRequest req)
        {
             JsonResponseModel<DescribeLiveVideoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLiveVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像回放列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVideoListRequest"/></param>
        /// <returns><see cref="DescribeLiveVideoListResponse"/></returns>
        public DescribeLiveVideoListResponse DescribeLiveVideoListSync(DescribeLiveVideoListRequest req)
        {
             JsonResponseModel<DescribeLiveVideoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLiveVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLiveVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看消息转发配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardResponse"/></returns>
        public async Task<DescribeMessageForwardResponse> DescribeMessageForward(DescribeMessageForwardRequest req)
        {
             JsonResponseModel<DescribeMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看消息转发配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardResponse"/></returns>
        public DescribeMessageForwardResponse DescribeMessageForwardSync(DescribeMessageForwardRequest req)
        {
             JsonResponseModel<DescribeMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看消息转发配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardsRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardsResponse"/></returns>
        public async Task<DescribeMessageForwardsResponse> DescribeMessageForwards(DescribeMessageForwardsRequest req)
        {
             JsonResponseModel<DescribeMessageForwardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMessageForwards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageForwardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看消息转发配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardsRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardsResponse"/></returns>
        public DescribeMessageForwardsResponse DescribeMessageForwardsSync(DescribeMessageForwardsRequest req)
        {
             JsonResponseModel<DescribeMessageForwardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMessageForwards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMessageForwardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营中心-设备录像存储统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorDataByDateRequest"/></param>
        /// <returns><see cref="DescribeMonitorDataByDateResponse"/></returns>
        public async Task<DescribeMonitorDataByDateResponse> DescribeMonitorDataByDate(DescribeMonitorDataByDateRequest req)
        {
             JsonResponseModel<DescribeMonitorDataByDateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonitorDataByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorDataByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运营中心-设备录像存储统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorDataByDateRequest"/></param>
        /// <returns><see cref="DescribeMonitorDataByDateResponse"/></returns>
        public DescribeMonitorDataByDateResponse DescribeMonitorDataByDateSync(DescribeMonitorDataByDateRequest req)
        {
             JsonResponseModel<DescribeMonitorDataByDateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonitorDataByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorDataByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取预置位列表
        /// </summary>
        /// <param name="req"><see cref="DescribePresetListRequest"/></param>
        /// <returns><see cref="DescribePresetListResponse"/></returns>
        public async Task<DescribePresetListResponse> DescribePresetList(DescribePresetListRequest req)
        {
             JsonResponseModel<DescribePresetListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePresetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePresetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取预置位列表
        /// </summary>
        /// <param name="req"><see cref="DescribePresetListRequest"/></param>
        /// <returns><see cref="DescribePresetListResponse"/></returns>
        public DescribePresetListResponse DescribePresetListSync(DescribePresetListRequest req)
        {
             JsonResponseModel<DescribePresetListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePresetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePresetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRecordDatesByChannel)用于查询设备含有录像文件的日期列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByChannelRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByChannelResponse"/></returns>
        public async Task<DescribeRecordDatesByChannelResponse> DescribeRecordDatesByChannel(DescribeRecordDatesByChannelRequest req)
        {
             JsonResponseModel<DescribeRecordDatesByChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordDatesByChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordDatesByChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRecordDatesByChannel)用于查询设备含有录像文件的日期列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByChannelRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByChannelResponse"/></returns>
        public DescribeRecordDatesByChannelResponse DescribeRecordDatesByChannelSync(DescribeRecordDatesByChannelRequest req)
        {
             JsonResponseModel<DescribeRecordDatesByChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordDatesByChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordDatesByChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像存储日期列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByLiveRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByLiveResponse"/></returns>
        public async Task<DescribeRecordDatesByLiveResponse> DescribeRecordDatesByLive(DescribeRecordDatesByLiveRequest req)
        {
             JsonResponseModel<DescribeRecordDatesByLiveResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordDatesByLive");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordDatesByLiveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像存储日期列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByLiveRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByLiveResponse"/></returns>
        public DescribeRecordDatesByLiveResponse DescribeRecordDatesByLiveSync(DescribeRecordDatesByLiveRequest req)
        {
             JsonResponseModel<DescribeRecordDatesByLiveResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordDatesByLive");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordDatesByLiveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取回放视频流地址
        /// 请使用DescribeChannelLocalRecordURL接口
        /// 
        /// RecordId和StartTime/EndTime互斥
        /// 当存在RecordId时，StartTime和EndTime无效
        /// 当RecordId为空，StartTime和EndTime生效
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeRecordStreamResponse"/></returns>
        public async Task<DescribeRecordStreamResponse> DescribeRecordStream(DescribeRecordStreamRequest req)
        {
             JsonResponseModel<DescribeRecordStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取回放视频流地址
        /// 请使用DescribeChannelLocalRecordURL接口
        /// 
        /// RecordId和StartTime/EndTime互斥
        /// 当存在RecordId时，StartTime和EndTime无效
        /// 当RecordId为空，StartTime和EndTime生效
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeRecordStreamResponse"/></returns>
        public DescribeRecordStreamResponse DescribeRecordStreamSync(DescribeRecordStreamRequest req)
        {
             JsonResponseModel<DescribeRecordStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlanById)用于根据录制计划ID获取录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlanByIdResponse"/></returns>
        public async Task<DescribeRecordingPlanByIdResponse> DescribeRecordingPlanById(DescribeRecordingPlanByIdRequest req)
        {
             JsonResponseModel<DescribeRecordingPlanByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordingPlanById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingPlanByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlanById)用于根据录制计划ID获取录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlanByIdResponse"/></returns>
        public DescribeRecordingPlanByIdResponse DescribeRecordingPlanByIdSync(DescribeRecordingPlanByIdRequest req)
        {
             JsonResponseModel<DescribeRecordingPlanByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordingPlanById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingPlanByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlans)用于获取用户的全部录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlansRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlansResponse"/></returns>
        public async Task<DescribeRecordingPlansResponse> DescribeRecordingPlans(DescribeRecordingPlansRequest req)
        {
             JsonResponseModel<DescribeRecordingPlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordingPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlans)用于获取用户的全部录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlansRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlansResponse"/></returns>
        public DescribeRecordingPlansResponse DescribeRecordingPlansSync(DescribeRecordingPlansRequest req)
        {
             JsonResponseModel<DescribeRecordingPlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordingPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取SIP服务器相关配置，用户可以通过这些配置项，将设备通过GB28181协议注册到本服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeSIPServerRequest"/></param>
        /// <returns><see cref="DescribeSIPServerResponse"/></returns>
        public async Task<DescribeSIPServerResponse> DescribeSIPServer(DescribeSIPServerRequest req)
        {
             JsonResponseModel<DescribeSIPServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSIPServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSIPServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取SIP服务器相关配置，用户可以通过这些配置项，将设备通过GB28181协议注册到本服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeSIPServerRequest"/></param>
        /// <returns><see cref="DescribeSIPServerResponse"/></returns>
        public DescribeSIPServerResponse DescribeSIPServerSync(DescribeSIPServerRequest req)
        {
             JsonResponseModel<DescribeSIPServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSIPServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSIPServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场景详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneRequest"/></param>
        /// <returns><see cref="DescribeSceneResponse"/></returns>
        public async Task<DescribeSceneResponse> DescribeScene(DescribeSceneRequest req)
        {
             JsonResponseModel<DescribeSceneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场景详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneRequest"/></param>
        /// <returns><see cref="DescribeSceneResponse"/></returns>
        public DescribeSceneResponse DescribeSceneSync(DescribeSceneRequest req)
        {
             JsonResponseModel<DescribeSceneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public async Task<DescribeScenesResponse> DescribeScenes(DescribeScenesRequest req)
        {
             JsonResponseModel<DescribeScenesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScenes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public DescribeScenesResponse DescribeScenesSync(DescribeScenesRequest req)
        {
             JsonResponseModel<DescribeScenesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScenes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeStatisticDetails)用于查询指定统计项详情，返回结果按天为单位聚合，支持的最大时间查询范围为31天。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeStatisticDetailsResponse"/></returns>
        public async Task<DescribeStatisticDetailsResponse> DescribeStatisticDetails(DescribeStatisticDetailsRequest req)
        {
             JsonResponseModel<DescribeStatisticDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStatisticDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeStatisticDetails)用于查询指定统计项详情，返回结果按天为单位聚合，支持的最大时间查询范围为31天。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeStatisticDetailsResponse"/></returns>
        public DescribeStatisticDetailsResponse DescribeStatisticDetailsSync(DescribeStatisticDetailsRequest req)
        {
             JsonResponseModel<DescribeStatisticDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStatisticDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeStatisticSummary)用于查询用户昨日的概览数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeStatisticSummaryResponse"/></returns>
        public async Task<DescribeStatisticSummaryResponse> DescribeStatisticSummary(DescribeStatisticSummaryRequest req)
        {
             JsonResponseModel<DescribeStatisticSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStatisticSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeStatisticSummary)用于查询用户昨日的概览数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeStatisticSummaryResponse"/></returns>
        public DescribeStatisticSummaryResponse DescribeStatisticSummarySync(DescribeStatisticSummaryRequest req)
        {
             JsonResponseModel<DescribeStatisticSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStatisticSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeSubGroups)用于查询分组下的子分组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubGroupsRequest"/></param>
        /// <returns><see cref="DescribeSubGroupsResponse"/></returns>
        public async Task<DescribeSubGroupsResponse> DescribeSubGroups(DescribeSubGroupsRequest req)
        {
             JsonResponseModel<DescribeSubGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeSubGroups)用于查询分组下的子分组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubGroupsRequest"/></param>
        /// <returns><see cref="DescribeSubGroupsResponse"/></returns>
        public DescribeSubGroupsResponse DescribeSubGroupsSync(DescribeSubGroupsRequest req)
        {
             JsonResponseModel<DescribeSubGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionStatusRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionStatusResponse"/></returns>
        public async Task<DescribeSubscriptionStatusResponse> DescribeSubscriptionStatus(DescribeSubscriptionStatusRequest req)
        {
             JsonResponseModel<DescribeSubscriptionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubscriptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscriptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionStatusRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionStatusResponse"/></returns>
        public DescribeSubscriptionStatusResponse DescribeSubscriptionStatusSync(DescribeSubscriptionStatusRequest req)
        {
             JsonResponseModel<DescribeSubscriptionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubscriptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubscriptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间获取云端录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListRequest"/></param>
        /// <returns><see cref="DescribeVideoListResponse"/></returns>
        public async Task<DescribeVideoListResponse> DescribeVideoList(DescribeVideoListRequest req)
        {
             JsonResponseModel<DescribeVideoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据时间获取云端录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListRequest"/></param>
        /// <returns><see cref="DescribeVideoListResponse"/></returns>
        public DescribeVideoListResponse DescribeVideoListSync(DescribeVideoListRequest req)
        {
             JsonResponseModel<DescribeVideoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeVideoListByChannel)用于查询指定通道的录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListByChannelRequest"/></param>
        /// <returns><see cref="DescribeVideoListByChannelResponse"/></returns>
        public async Task<DescribeVideoListByChannelResponse> DescribeVideoListByChannel(DescribeVideoListByChannelRequest req)
        {
             JsonResponseModel<DescribeVideoListByChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoListByChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoListByChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeVideoListByChannel)用于查询指定通道的录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListByChannelRequest"/></param>
        /// <returns><see cref="DescribeVideoListByChannelResponse"/></returns>
        public DescribeVideoListByChannelResponse DescribeVideoListByChannelSync(DescribeVideoListByChannelRequest req)
        {
             JsonResponseModel<DescribeVideoListByChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoListByChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoListByChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarnModRequest"/></param>
        /// <returns><see cref="DescribeWarnModResponse"/></returns>
        public async Task<DescribeWarnModResponse> DescribeWarnMod(DescribeWarnModRequest req)
        {
             JsonResponseModel<DescribeWarnModResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWarnMod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarnModResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarnModRequest"/></param>
        /// <returns><see cref="DescribeWarnModResponse"/></returns>
        public DescribeWarnModResponse DescribeWarnModSync(DescribeWarnModRequest req)
        {
             JsonResponseModel<DescribeWarnModResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWarnMod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarnModResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningsRequest"/></param>
        /// <returns><see cref="DescribeWarningsResponse"/></returns>
        public async Task<DescribeWarningsResponse> DescribeWarnings(DescribeWarningsRequest req)
        {
             JsonResponseModel<DescribeWarningsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWarnings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningsRequest"/></param>
        /// <returns><see cref="DescribeWarningsResponse"/></returns>
        public DescribeWarningsResponse DescribeWarningsSync(DescribeWarningsRequest req)
        {
             JsonResponseModel<DescribeWarningsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWarnings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取X-P2P的统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeXP2PDataRequest"/></param>
        /// <returns><see cref="DescribeXP2PDataResponse"/></returns>
        public async Task<DescribeXP2PDataResponse> DescribeXP2PData(DescribeXP2PDataRequest req)
        {
             JsonResponseModel<DescribeXP2PDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeXP2PData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeXP2PDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取X-P2P的统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeXP2PDataRequest"/></param>
        /// <returns><see cref="DescribeXP2PDataResponse"/></returns>
        public DescribeXP2PDataResponse DescribeXP2PDataSync(DescribeXP2PDataRequest req)
        {
             JsonResponseModel<DescribeXP2PDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeXP2PData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeXP2PDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordDatesByDev)用于查询设备含有录像文件的日期列表。
        /// 请使用DescribeRecordDatesByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordDatesByDevRequest"/></param>
        /// <returns><see cref="GetRecordDatesByDevResponse"/></returns>
        public async Task<GetRecordDatesByDevResponse> GetRecordDatesByDev(GetRecordDatesByDevRequest req)
        {
             JsonResponseModel<GetRecordDatesByDevResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRecordDatesByDev");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordDatesByDevResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordDatesByDev)用于查询设备含有录像文件的日期列表。
        /// 请使用DescribeRecordDatesByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordDatesByDevRequest"/></param>
        /// <returns><see cref="GetRecordDatesByDevResponse"/></returns>
        public GetRecordDatesByDevResponse GetRecordDatesByDevSync(GetRecordDatesByDevRequest req)
        {
             JsonResponseModel<GetRecordDatesByDevResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRecordDatesByDev");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordDatesByDevResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordPlanByDev)用于根据设备ID查询其绑定的录制计划.
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByDevRequest"/></param>
        /// <returns><see cref="GetRecordPlanByDevResponse"/></returns>
        public async Task<GetRecordPlanByDevResponse> GetRecordPlanByDev(GetRecordPlanByDevRequest req)
        {
             JsonResponseModel<GetRecordPlanByDevResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRecordPlanByDev");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordPlanByDevResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordPlanByDev)用于根据设备ID查询其绑定的录制计划.
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByDevRequest"/></param>
        /// <returns><see cref="GetRecordPlanByDevResponse"/></returns>
        public GetRecordPlanByDevResponse GetRecordPlanByDevSync(GetRecordPlanByDevRequest req)
        {
             JsonResponseModel<GetRecordPlanByDevResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRecordPlanByDev");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordPlanByDevResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordPlanById)用于根据录制计划ID获取录制计划。
        /// 请使用DescribeRecordingPlanById接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByIdRequest"/></param>
        /// <returns><see cref="GetRecordPlanByIdResponse"/></returns>
        public async Task<GetRecordPlanByIdResponse> GetRecordPlanById(GetRecordPlanByIdRequest req)
        {
             JsonResponseModel<GetRecordPlanByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRecordPlanById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordPlanByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordPlanById)用于根据录制计划ID获取录制计划。
        /// 请使用DescribeRecordingPlanById接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByIdRequest"/></param>
        /// <returns><see cref="GetRecordPlanByIdResponse"/></returns>
        public GetRecordPlanByIdResponse GetRecordPlanByIdSync(GetRecordPlanByIdRequest req)
        {
             JsonResponseModel<GetRecordPlanByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRecordPlanById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordPlanByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordPlans)用于获取用户的全部录制计划。
        /// 请使用DescribeRecordingPlans接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlansRequest"/></param>
        /// <returns><see cref="GetRecordPlansResponse"/></returns>
        public async Task<GetRecordPlansResponse> GetRecordPlans(GetRecordPlansRequest req)
        {
             JsonResponseModel<GetRecordPlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRecordPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetRecordPlans)用于获取用户的全部录制计划。
        /// 请使用DescribeRecordingPlans接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlansRequest"/></param>
        /// <returns><see cref="GetRecordPlansResponse"/></returns>
        public GetRecordPlansResponse GetRecordPlansSync(GetRecordPlansRequest req)
        {
             JsonResponseModel<GetRecordPlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRecordPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRecordPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetTimeTemplateById)用于根据模板ID获取时间模板详情。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplateByIdRequest"/></param>
        /// <returns><see cref="GetTimeTemplateByIdResponse"/></returns>
        public async Task<GetTimeTemplateByIdResponse> GetTimeTemplateById(GetTimeTemplateByIdRequest req)
        {
             JsonResponseModel<GetTimeTemplateByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTimeTemplateById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTimeTemplateByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetTimeTemplateById)用于根据模板ID获取时间模板详情。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplateByIdRequest"/></param>
        /// <returns><see cref="GetTimeTemplateByIdResponse"/></returns>
        public GetTimeTemplateByIdResponse GetTimeTemplateByIdSync(GetTimeTemplateByIdRequest req)
        {
             JsonResponseModel<GetTimeTemplateByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTimeTemplateById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTimeTemplateByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetTimeTemplates)用于获取时间模板列表。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplatesRequest"/></param>
        /// <returns><see cref="GetTimeTemplatesResponse"/></returns>
        public async Task<GetTimeTemplatesResponse> GetTimeTemplates(GetTimeTemplatesRequest req)
        {
             JsonResponseModel<GetTimeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTimeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTimeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetTimeTemplates)用于获取时间模板列表。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplatesRequest"/></param>
        /// <returns><see cref="GetTimeTemplatesResponse"/></returns>
        public GetTimeTemplatesResponse GetTimeTemplatesSync(GetTimeTemplatesRequest req)
        {
             JsonResponseModel<GetTimeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTimeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTimeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetVideoListByCon)用于查询设备的录制文件列表
        /// 请使用DescribeVideoListByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetVideoListByConRequest"/></param>
        /// <returns><see cref="GetVideoListByConResponse"/></returns>
        public async Task<GetVideoListByConResponse> GetVideoListByCon(GetVideoListByConRequest req)
        {
             JsonResponseModel<GetVideoListByConResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetVideoListByCon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetVideoListByConResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(GetVideoListByCon)用于查询设备的录制文件列表
        /// 请使用DescribeVideoListByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetVideoListByConRequest"/></param>
        /// <returns><see cref="GetVideoListByConResponse"/></returns>
        public GetVideoListByConResponse GetVideoListByConSync(GetVideoListByConRequest req)
        {
             JsonResponseModel<GetVideoListByConResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetVideoListByCon");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetVideoListByConResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录制计划绑定解绑直播频道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindPlanLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyBindPlanLiveChannelResponse"/></returns>
        public async Task<ModifyBindPlanLiveChannelResponse> ModifyBindPlanLiveChannel(ModifyBindPlanLiveChannelRequest req)
        {
             JsonResponseModel<ModifyBindPlanLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBindPlanLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindPlanLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录制计划绑定解绑直播频道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindPlanLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyBindPlanLiveChannelResponse"/></returns>
        public ModifyBindPlanLiveChannelResponse ModifyBindPlanLiveChannelSync(ModifyBindPlanLiveChannelRequest req)
        {
             JsonResponseModel<ModifyBindPlanLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBindPlanLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindPlanLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyBindRecordingPlan)用于更新录制计划绑定的通道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyBindRecordingPlanResponse"/></returns>
        public async Task<ModifyBindRecordingPlanResponse> ModifyBindRecordingPlan(ModifyBindRecordingPlanRequest req)
        {
             JsonResponseModel<ModifyBindRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBindRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyBindRecordingPlan)用于更新录制计划绑定的通道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyBindRecordingPlanResponse"/></returns>
        public ModifyBindRecordingPlanResponse ModifyBindRecordingPlanSync(ModifyBindRecordingPlanRequest req)
        {
             JsonResponseModel<ModifyBindRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBindRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场景绑定解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneChannelsRequest"/></param>
        /// <returns><see cref="ModifyBindSceneChannelsResponse"/></returns>
        public async Task<ModifyBindSceneChannelsResponse> ModifyBindSceneChannels(ModifyBindSceneChannelsRequest req)
        {
             JsonResponseModel<ModifyBindSceneChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBindSceneChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindSceneChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场景绑定解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneChannelsRequest"/></param>
        /// <returns><see cref="ModifyBindSceneChannelsResponse"/></returns>
        public ModifyBindSceneChannelsResponse ModifyBindSceneChannelsSync(ModifyBindSceneChannelsRequest req)
        {
             JsonResponseModel<ModifyBindSceneChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBindSceneChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindSceneChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场景绑定/解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneDeviceRequest"/></param>
        /// <returns><see cref="ModifyBindSceneDeviceResponse"/></returns>
        public async Task<ModifyBindSceneDeviceResponse> ModifyBindSceneDevice(ModifyBindSceneDeviceRequest req)
        {
             JsonResponseModel<ModifyBindSceneDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBindSceneDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindSceneDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 场景绑定/解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneDeviceRequest"/></param>
        /// <returns><see cref="ModifyBindSceneDeviceResponse"/></returns>
        public ModifyBindSceneDeviceResponse ModifyBindSceneDeviceSync(ModifyBindSceneDeviceRequest req)
        {
             JsonResponseModel<ModifyBindSceneDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBindSceneDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindSceneDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDeviceData)用于编辑设备信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceDataRequest"/></param>
        /// <returns><see cref="ModifyDeviceDataResponse"/></returns>
        public async Task<ModifyDeviceDataResponse> ModifyDeviceData(ModifyDeviceDataRequest req)
        {
             JsonResponseModel<ModifyDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDeviceData)用于编辑设备信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceDataRequest"/></param>
        /// <returns><see cref="ModifyDeviceDataResponse"/></returns>
        public ModifyDeviceDataResponse ModifyDeviceDataSync(ModifyDeviceDataRequest req)
        {
             JsonResponseModel<ModifyDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑直播接口
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyLiveChannelResponse"/></returns>
        public async Task<ModifyLiveChannelResponse> ModifyLiveChannel(ModifyLiveChannelRequest req)
        {
             JsonResponseModel<ModifyLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑直播接口
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyLiveChannelResponse"/></returns>
        public ModifyLiveChannelResponse ModifyLiveChannelSync(ModifyLiveChannelRequest req)
        {
             JsonResponseModel<ModifyLiveChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑直播录制计划
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordPlanRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordPlanResponse"/></returns>
        public async Task<ModifyLiveRecordPlanResponse> ModifyLiveRecordPlan(ModifyLiveRecordPlanRequest req)
        {
             JsonResponseModel<ModifyLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑直播录制计划
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordPlanRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordPlanResponse"/></returns>
        public ModifyLiveRecordPlanResponse ModifyLiveRecordPlanSync(ModifyLiveRecordPlanRequest req)
        {
             JsonResponseModel<ModifyLiveRecordPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveRecordPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveRecordPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像编辑
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveVideoRequest"/></param>
        /// <returns><see cref="ModifyLiveVideoResponse"/></returns>
        public async Task<ModifyLiveVideoResponse> ModifyLiveVideo(ModifyLiveVideoRequest req)
        {
             JsonResponseModel<ModifyLiveVideoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLiveVideo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveVideoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播录像编辑
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveVideoRequest"/></param>
        /// <returns><see cref="ModifyLiveVideoResponse"/></returns>
        public ModifyLiveVideoResponse ModifyLiveVideoSync(ModifyLiveVideoRequest req)
        {
             JsonResponseModel<ModifyLiveVideoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLiveVideo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLiveVideoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改消息转发配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMessageForwardRequest"/></param>
        /// <returns><see cref="ModifyMessageForwardResponse"/></returns>
        public async Task<ModifyMessageForwardResponse> ModifyMessageForward(ModifyMessageForwardRequest req)
        {
             JsonResponseModel<ModifyMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改消息转发配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMessageForwardRequest"/></param>
        /// <returns><see cref="ModifyMessageForwardResponse"/></returns>
        public ModifyMessageForwardResponse ModifyMessageForwardSync(ModifyMessageForwardRequest req)
        {
             JsonResponseModel<ModifyMessageForwardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMessageForward");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMessageForwardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑预置位信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPresetRequest"/></param>
        /// <returns><see cref="ModifyPresetResponse"/></returns>
        public async Task<ModifyPresetResponse> ModifyPreset(ModifyPresetRequest req)
        {
             JsonResponseModel<ModifyPresetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑预置位信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPresetRequest"/></param>
        /// <returns><see cref="ModifyPresetResponse"/></returns>
        public ModifyPresetResponse ModifyPresetSync(ModifyPresetRequest req)
        {
             JsonResponseModel<ModifyPresetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPreset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPresetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyRecordingPlan)用于更新录制计划。
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyRecordingPlanResponse"/></returns>
        public async Task<ModifyRecordingPlanResponse> ModifyRecordingPlan(ModifyRecordingPlanRequest req)
        {
             JsonResponseModel<ModifyRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyRecordingPlan)用于更新录制计划。
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyRecordingPlanResponse"/></returns>
        public ModifyRecordingPlanResponse ModifyRecordingPlanSync(ModifyRecordingPlanRequest req)
        {
             JsonResponseModel<ModifyRecordingPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecordingPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordingPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改场景
        /// </summary>
        /// <param name="req"><see cref="ModifySceneRequest"/></param>
        /// <returns><see cref="ModifySceneResponse"/></returns>
        public async Task<ModifySceneResponse> ModifyScene(ModifySceneRequest req)
        {
             JsonResponseModel<ModifySceneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改场景
        /// </summary>
        /// <param name="req"><see cref="ModifySceneRequest"/></param>
        /// <returns><see cref="ModifySceneResponse"/></returns>
        public ModifySceneResponse ModifySceneSync(ModifySceneRequest req)
        {
             JsonResponseModel<ModifySceneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyScene");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySceneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionStatusRequest"/></param>
        /// <returns><see cref="ModifySubscriptionStatusResponse"/></returns>
        public async Task<ModifySubscriptionStatusResponse> ModifySubscriptionStatus(ModifySubscriptionStatusRequest req)
        {
             JsonResponseModel<ModifySubscriptionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubscriptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscriptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionStatusRequest"/></param>
        /// <returns><see cref="ModifySubscriptionStatusResponse"/></returns>
        public ModifySubscriptionStatusResponse ModifySubscriptionStatusSync(ModifySubscriptionStatusRequest req)
        {
             JsonResponseModel<ModifySubscriptionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubscriptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubscriptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改录像存储列表
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoInfoRequest"/></param>
        /// <returns><see cref="ModifyVideoInfoResponse"/></returns>
        public async Task<ModifyVideoInfoResponse> ModifyVideoInfo(ModifyVideoInfoRequest req)
        {
             JsonResponseModel<ModifyVideoInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVideoInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVideoInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改录像存储列表
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoInfoRequest"/></param>
        /// <returns><see cref="ModifyVideoInfoResponse"/></returns>
        public ModifyVideoInfoResponse ModifyVideoInfoSync(ModifyVideoInfoRequest req)
        {
             JsonResponseModel<ModifyVideoInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVideoInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVideoInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置设备告警
        /// </summary>
        /// <param name="req"><see cref="ResetWarningRequest"/></param>
        /// <returns><see cref="ResetWarningResponse"/></returns>
        public async Task<ResetWarningResponse> ResetWarning(ResetWarningRequest req)
        {
             JsonResponseModel<ResetWarningResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetWarning");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetWarningResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置设备告警
        /// </summary>
        /// <param name="req"><see cref="ResetWarningRequest"/></param>
        /// <returns><see cref="ResetWarningResponse"/></returns>
        public ResetWarningResponse ResetWarningSync(ResetWarningRequest req)
        {
             JsonResponseModel<ResetWarningResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetWarning");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetWarningResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdateDeviceGroup)用于修改分组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceGroupRequest"/></param>
        /// <returns><see cref="UpdateDeviceGroupResponse"/></returns>
        public async Task<UpdateDeviceGroupResponse> UpdateDeviceGroup(UpdateDeviceGroupRequest req)
        {
             JsonResponseModel<UpdateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdateDeviceGroup)用于修改分组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceGroupRequest"/></param>
        /// <returns><see cref="UpdateDeviceGroupResponse"/></returns>
        public UpdateDeviceGroupResponse UpdateDeviceGroupSync(UpdateDeviceGroupRequest req)
        {
             JsonResponseModel<UpdateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdateDevicePassWord)用于修改设备密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePassWordRequest"/></param>
        /// <returns><see cref="UpdateDevicePassWordResponse"/></returns>
        public async Task<UpdateDevicePassWordResponse> UpdateDevicePassWord(UpdateDevicePassWordRequest req)
        {
             JsonResponseModel<UpdateDevicePassWordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDevicePassWord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicePassWordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdateDevicePassWord)用于修改设备密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePassWordRequest"/></param>
        /// <returns><see cref="UpdateDevicePassWordResponse"/></returns>
        public UpdateDevicePassWordResponse UpdateDevicePassWordSync(UpdateDevicePassWordRequest req)
        {
             JsonResponseModel<UpdateDevicePassWordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDevicePassWord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicePassWordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdateRecordPlan)用于更新录制计划。
        /// 请使用 ModifyRecordingPlan接口和ModifyBindRecordingPlan接口
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
        /// 本接口(UpdateRecordPlan)用于更新录制计划。
        /// 请使用 ModifyRecordingPlan接口和ModifyBindRecordingPlan接口
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
        /// 本接口(UpdateTimeTemplate)用于更新时间模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateTimeTemplateRequest"/></param>
        /// <returns><see cref="UpdateTimeTemplateResponse"/></returns>
        public async Task<UpdateTimeTemplateResponse> UpdateTimeTemplate(UpdateTimeTemplateRequest req)
        {
             JsonResponseModel<UpdateTimeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateTimeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTimeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpdateTimeTemplate)用于更新时间模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateTimeTemplateRequest"/></param>
        /// <returns><see cref="UpdateTimeTemplateResponse"/></returns>
        public UpdateTimeTemplateResponse UpdateTimeTemplateSync(UpdateTimeTemplateRequest req)
        {
             JsonResponseModel<UpdateTimeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateTimeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTimeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
