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
       private const string sdkVersion = "SDK_NET_3.0.1111";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotvideoindustryClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(BindGroupDevices) 用于绑定设备到分组。
        /// </summary>
        /// <param name="req"><see cref="BindGroupDevicesRequest"/></param>
        /// <returns><see cref="BindGroupDevicesResponse"/></returns>
        public Task<BindGroupDevicesResponse> BindGroupDevices(BindGroupDevicesRequest req)
        {
            return InternalRequestAsync<BindGroupDevicesResponse>(req, "BindGroupDevices");
        }

        /// <summary>
        /// 本接口(BindGroupDevices) 用于绑定设备到分组。
        /// </summary>
        /// <param name="req"><see cref="BindGroupDevicesRequest"/></param>
        /// <returns><see cref="BindGroupDevicesResponse"/></returns>
        public BindGroupDevicesResponse BindGroupDevicesSync(BindGroupDevicesRequest req)
        {
            return InternalRequestAsync<BindGroupDevicesResponse>(req, "BindGroupDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ControlChannelLocalRecord）用于对通道本地回放流进行控制，包括暂停、播放、拉动、结束等
        /// </summary>
        /// <param name="req"><see cref="ControlChannelLocalRecordRequest"/></param>
        /// <returns><see cref="ControlChannelLocalRecordResponse"/></returns>
        public Task<ControlChannelLocalRecordResponse> ControlChannelLocalRecord(ControlChannelLocalRecordRequest req)
        {
            return InternalRequestAsync<ControlChannelLocalRecordResponse>(req, "ControlChannelLocalRecord");
        }

        /// <summary>
        /// 本接口（ControlChannelLocalRecord）用于对通道本地回放流进行控制，包括暂停、播放、拉动、结束等
        /// </summary>
        /// <param name="req"><see cref="ControlChannelLocalRecordRequest"/></param>
        /// <returns><see cref="ControlChannelLocalRecordResponse"/></returns>
        public ControlChannelLocalRecordResponse ControlChannelLocalRecordSync(ControlChannelLocalRecordRequest req)
        {
            return InternalRequestAsync<ControlChannelLocalRecordResponse>(req, "ControlChannelLocalRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ControlChannelPTZ) 用于对支持GB28181 PTZ信令的设备进行指定通道的远程控制。
        /// </summary>
        /// <param name="req"><see cref="ControlChannelPTZRequest"/></param>
        /// <returns><see cref="ControlChannelPTZResponse"/></returns>
        public Task<ControlChannelPTZResponse> ControlChannelPTZ(ControlChannelPTZRequest req)
        {
            return InternalRequestAsync<ControlChannelPTZResponse>(req, "ControlChannelPTZ");
        }

        /// <summary>
        /// 本接口(ControlChannelPTZ) 用于对支持GB28181 PTZ信令的设备进行指定通道的远程控制。
        /// </summary>
        /// <param name="req"><see cref="ControlChannelPTZRequest"/></param>
        /// <returns><see cref="ControlChannelPTZResponse"/></returns>
        public ControlChannelPTZResponse ControlChannelPTZSync(ControlChannelPTZRequest req)
        {
            return InternalRequestAsync<ControlChannelPTZResponse>(req, "ControlChannelPTZ")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ControlDevicePTZ) 用于对支持GB28181 PTZ信令的设备进行远程控制。
        /// 请使用ControlChannelPTZ接口
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public Task<ControlDevicePTZResponse> ControlDevicePTZ(ControlDevicePTZRequest req)
        {
            return InternalRequestAsync<ControlDevicePTZResponse>(req, "ControlDevicePTZ");
        }

        /// <summary>
        /// 本接口(ControlDevicePTZ) 用于对支持GB28181 PTZ信令的设备进行远程控制。
        /// 请使用ControlChannelPTZ接口
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public ControlDevicePTZResponse ControlDevicePTZSync(ControlDevicePTZRequest req)
        {
            return InternalRequestAsync<ControlDevicePTZResponse>(req, "ControlDevicePTZ")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 看守位控制
        /// </summary>
        /// <param name="req"><see cref="ControlHomePositionRequest"/></param>
        /// <returns><see cref="ControlHomePositionResponse"/></returns>
        public Task<ControlHomePositionResponse> ControlHomePosition(ControlHomePositionRequest req)
        {
            return InternalRequestAsync<ControlHomePositionResponse>(req, "ControlHomePosition");
        }

        /// <summary>
        /// 看守位控制
        /// </summary>
        /// <param name="req"><see cref="ControlHomePositionRequest"/></param>
        /// <returns><see cref="ControlHomePositionResponse"/></returns>
        public ControlHomePositionResponse ControlHomePositionSync(ControlHomePositionRequest req)
        {
            return InternalRequestAsync<ControlHomePositionResponse>(req, "ControlHomePosition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 预置位控制
        /// </summary>
        /// <param name="req"><see cref="ControlPresetRequest"/></param>
        /// <returns><see cref="ControlPresetResponse"/></returns>
        public Task<ControlPresetResponse> ControlPreset(ControlPresetRequest req)
        {
            return InternalRequestAsync<ControlPresetResponse>(req, "ControlPreset");
        }

        /// <summary>
        /// 预置位控制
        /// </summary>
        /// <param name="req"><see cref="ControlPresetRequest"/></param>
        /// <returns><see cref="ControlPresetResponse"/></returns>
        public ControlPresetResponse ControlPresetSync(ControlPresetRequest req)
        {
            return InternalRequestAsync<ControlPresetResponse>(req, "ControlPreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对回放流进行控制，包括暂停、播放、拉动、结束等
        /// 请使用ControlChannelLocalRecord接口
        /// </summary>
        /// <param name="req"><see cref="ControlRecordStreamRequest"/></param>
        /// <returns><see cref="ControlRecordStreamResponse"/></returns>
        public Task<ControlRecordStreamResponse> ControlRecordStream(ControlRecordStreamRequest req)
        {
            return InternalRequestAsync<ControlRecordStreamResponse>(req, "ControlRecordStream");
        }

        /// <summary>
        /// 对回放流进行控制，包括暂停、播放、拉动、结束等
        /// 请使用ControlChannelLocalRecord接口
        /// </summary>
        /// <param name="req"><see cref="ControlRecordStreamRequest"/></param>
        /// <returns><see cref="ControlRecordStreamResponse"/></returns>
        public ControlRecordStreamResponse ControlRecordStreamSync(ControlRecordStreamRequest req)
        {
            return InternalRequestAsync<ControlRecordStreamResponse>(req, "ControlRecordStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDevice) 用于创建设备。
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice");
        }

        /// <summary>
        /// 本接口(CreateDevice) 用于创建设备。
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateDeviceGroup) 用于创建设备管理分组。
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public Task<CreateDeviceGroupResponse> CreateDeviceGroup(CreateDeviceGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceGroupResponse>(req, "CreateDeviceGroup");
        }

        /// <summary>
        /// 本接口(CreateDeviceGroup) 用于创建设备管理分组。
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public CreateDeviceGroupResponse CreateDeviceGroupSync(CreateDeviceGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceGroupResponse>(req, "CreateDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播频道
        /// </summary>
        /// <param name="req"><see cref="CreateLiveChannelRequest"/></param>
        /// <returns><see cref="CreateLiveChannelResponse"/></returns>
        public Task<CreateLiveChannelResponse> CreateLiveChannel(CreateLiveChannelRequest req)
        {
            return InternalRequestAsync<CreateLiveChannelResponse>(req, "CreateLiveChannel");
        }

        /// <summary>
        /// 创建直播频道
        /// </summary>
        /// <param name="req"><see cref="CreateLiveChannelRequest"/></param>
        /// <returns><see cref="CreateLiveChannelResponse"/></returns>
        public CreateLiveChannelResponse CreateLiveChannelSync(CreateLiveChannelRequest req)
        {
            return InternalRequestAsync<CreateLiveChannelResponse>(req, "CreateLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建直播录制计划
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordPlanRequest"/></param>
        /// <returns><see cref="CreateLiveRecordPlanResponse"/></returns>
        public Task<CreateLiveRecordPlanResponse> CreateLiveRecordPlan(CreateLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordPlanResponse>(req, "CreateLiveRecordPlan");
        }

        /// <summary>
        /// 创建直播录制计划
        /// </summary>
        /// <param name="req"><see cref="CreateLiveRecordPlanRequest"/></param>
        /// <returns><see cref="CreateLiveRecordPlanResponse"/></returns>
        public CreateLiveRecordPlanResponse CreateLiveRecordPlanSync(CreateLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<CreateLiveRecordPlanResponse>(req, "CreateLiveRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建消息转发配置
        /// </summary>
        /// <param name="req"><see cref="CreateMessageForwardRequest"/></param>
        /// <returns><see cref="CreateMessageForwardResponse"/></returns>
        public Task<CreateMessageForwardResponse> CreateMessageForward(CreateMessageForwardRequest req)
        {
            return InternalRequestAsync<CreateMessageForwardResponse>(req, "CreateMessageForward");
        }

        /// <summary>
        /// 创建消息转发配置
        /// </summary>
        /// <param name="req"><see cref="CreateMessageForwardRequest"/></param>
        /// <returns><see cref="CreateMessageForwardResponse"/></returns>
        public CreateMessageForwardResponse CreateMessageForwardSync(CreateMessageForwardRequest req)
        {
            return InternalRequestAsync<CreateMessageForwardResponse>(req, "CreateMessageForward")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateRecordPlan) 用于创建录制计划，使设备与时间模板绑定，以便及时启动录制
        /// 请使用CreateRecordingPlan代替
        /// </summary>
        /// <param name="req"><see cref="CreateRecordPlanRequest"/></param>
        /// <returns><see cref="CreateRecordPlanResponse"/></returns>
        public Task<CreateRecordPlanResponse> CreateRecordPlan(CreateRecordPlanRequest req)
        {
            return InternalRequestAsync<CreateRecordPlanResponse>(req, "CreateRecordPlan");
        }

        /// <summary>
        /// 本接口(CreateRecordPlan) 用于创建录制计划，使设备与时间模板绑定，以便及时启动录制
        /// 请使用CreateRecordingPlan代替
        /// </summary>
        /// <param name="req"><see cref="CreateRecordPlanRequest"/></param>
        /// <returns><see cref="CreateRecordPlanResponse"/></returns>
        public CreateRecordPlanResponse CreateRecordPlanSync(CreateRecordPlanRequest req)
        {
            return InternalRequestAsync<CreateRecordPlanResponse>(req, "CreateRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateRecordingPlan) 用于创建录制计划，使通道与时间模板绑定，以便及时启动录制
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingPlanRequest"/></param>
        /// <returns><see cref="CreateRecordingPlanResponse"/></returns>
        public Task<CreateRecordingPlanResponse> CreateRecordingPlan(CreateRecordingPlanRequest req)
        {
            return InternalRequestAsync<CreateRecordingPlanResponse>(req, "CreateRecordingPlan");
        }

        /// <summary>
        /// 本接口(CreateRecordingPlan) 用于创建录制计划，使通道与时间模板绑定，以便及时启动录制
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingPlanRequest"/></param>
        /// <returns><see cref="CreateRecordingPlanResponse"/></returns>
        public CreateRecordingPlanResponse CreateRecordingPlanSync(CreateRecordingPlanRequest req)
        {
            return InternalRequestAsync<CreateRecordingPlanResponse>(req, "CreateRecordingPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateSceneRequest"/></param>
        /// <returns><see cref="CreateSceneResponse"/></returns>
        public Task<CreateSceneResponse> CreateScene(CreateSceneRequest req)
        {
            return InternalRequestAsync<CreateSceneResponse>(req, "CreateScene");
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateSceneRequest"/></param>
        /// <returns><see cref="CreateSceneResponse"/></returns>
        public CreateSceneResponse CreateSceneSync(CreateSceneRequest req)
        {
            return InternalRequestAsync<CreateSceneResponse>(req, "CreateScene")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateTimeTemplate) 用于根据模板描述的具体录制时间片段，创建定制化的时间模板。
        /// </summary>
        /// <param name="req"><see cref="CreateTimeTemplateRequest"/></param>
        /// <returns><see cref="CreateTimeTemplateResponse"/></returns>
        public Task<CreateTimeTemplateResponse> CreateTimeTemplate(CreateTimeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTimeTemplateResponse>(req, "CreateTimeTemplate");
        }

        /// <summary>
        /// 本接口(CreateTimeTemplate) 用于根据模板描述的具体录制时间片段，创建定制化的时间模板。
        /// </summary>
        /// <param name="req"><see cref="CreateTimeTemplateRequest"/></param>
        /// <returns><see cref="CreateTimeTemplateResponse"/></returns>
        public CreateTimeTemplateResponse CreateTimeTemplateSync(CreateTimeTemplateRequest req)
        {
            return InternalRequestAsync<CreateTimeTemplateResponse>(req, "CreateTimeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除设备下的通道
        /// 注意： 在线状态的设备不允许删除
        /// </summary>
        /// <param name="req"><see cref="DeleteChannelRequest"/></param>
        /// <returns><see cref="DeleteChannelResponse"/></returns>
        public Task<DeleteChannelResponse> DeleteChannel(DeleteChannelRequest req)
        {
            return InternalRequestAsync<DeleteChannelResponse>(req, "DeleteChannel");
        }

        /// <summary>
        /// 本接口用于删除设备下的通道
        /// 注意： 在线状态的设备不允许删除
        /// </summary>
        /// <param name="req"><see cref="DeleteChannelRequest"/></param>
        /// <returns><see cref="DeleteChannelResponse"/></returns>
        public DeleteChannelResponse DeleteChannelSync(DeleteChannelRequest req)
        {
            return InternalRequestAsync<DeleteChannelResponse>(req, "DeleteChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteDevice)用于删除设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// 本接口(DeleteDevice)用于删除设备。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteDeviceGroup)用于删除分组。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupResponse"/></returns>
        public Task<DeleteDeviceGroupResponse> DeleteDeviceGroup(DeleteDeviceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupResponse>(req, "DeleteDeviceGroup");
        }

        /// <summary>
        /// 本接口(DeleteDeviceGroup)用于删除分组。
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupResponse"/></returns>
        public DeleteDeviceGroupResponse DeleteDeviceGroupSync(DeleteDeviceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupResponse>(req, "DeleteDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteLiveChannelResponse"/></returns>
        public Task<DeleteLiveChannelResponse> DeleteLiveChannel(DeleteLiveChannelRequest req)
        {
            return InternalRequestAsync<DeleteLiveChannelResponse>(req, "DeleteLiveChannel");
        }

        /// <summary>
        /// 删除直播接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveChannelRequest"/></param>
        /// <returns><see cref="DeleteLiveChannelResponse"/></returns>
        public DeleteLiveChannelResponse DeleteLiveChannelSync(DeleteLiveChannelRequest req)
        {
            return InternalRequestAsync<DeleteLiveChannelResponse>(req, "DeleteLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除直播录制计划
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordPlanResponse"/></returns>
        public Task<DeleteLiveRecordPlanResponse> DeleteLiveRecordPlan(DeleteLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordPlanResponse>(req, "DeleteLiveRecordPlan");
        }

        /// <summary>
        /// 删除直播录制计划
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteLiveRecordPlanResponse"/></returns>
        public DeleteLiveRecordPlanResponse DeleteLiveRecordPlanSync(DeleteLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<DeleteLiveRecordPlanResponse>(req, "DeleteLiveRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播录像删除
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveVideoListRequest"/></param>
        /// <returns><see cref="DeleteLiveVideoListResponse"/></returns>
        public Task<DeleteLiveVideoListResponse> DeleteLiveVideoList(DeleteLiveVideoListRequest req)
        {
            return InternalRequestAsync<DeleteLiveVideoListResponse>(req, "DeleteLiveVideoList");
        }

        /// <summary>
        /// 直播录像删除
        /// </summary>
        /// <param name="req"><see cref="DeleteLiveVideoListRequest"/></param>
        /// <returns><see cref="DeleteLiveVideoListResponse"/></returns>
        public DeleteLiveVideoListResponse DeleteLiveVideoListSync(DeleteLiveVideoListRequest req)
        {
            return InternalRequestAsync<DeleteLiveVideoListResponse>(req, "DeleteLiveVideoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除消息转发配置
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageForwardRequest"/></param>
        /// <returns><see cref="DeleteMessageForwardResponse"/></returns>
        public Task<DeleteMessageForwardResponse> DeleteMessageForward(DeleteMessageForwardRequest req)
        {
            return InternalRequestAsync<DeleteMessageForwardResponse>(req, "DeleteMessageForward");
        }

        /// <summary>
        /// 删除消息转发配置
        /// </summary>
        /// <param name="req"><see cref="DeleteMessageForwardRequest"/></param>
        /// <returns><see cref="DeleteMessageForwardResponse"/></returns>
        public DeleteMessageForwardResponse DeleteMessageForwardSync(DeleteMessageForwardRequest req)
        {
            return InternalRequestAsync<DeleteMessageForwardResponse>(req, "DeleteMessageForward")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteRecordPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
        /// 请使用DeleteRecordingPlan接口
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordPlanResponse"/></returns>
        public Task<DeleteRecordPlanResponse> DeleteRecordPlan(DeleteRecordPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordPlanResponse>(req, "DeleteRecordPlan");
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
            return InternalRequestAsync<DeleteRecordPlanResponse>(req, "DeleteRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteRecordingPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordingPlanResponse"/></returns>
        public Task<DeleteRecordingPlanResponse> DeleteRecordingPlan(DeleteRecordingPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordingPlanResponse>(req, "DeleteRecordingPlan");
        }

        /// <summary>
        /// 本接口(DeleteRecordingPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordingPlanResponse"/></returns>
        public DeleteRecordingPlanResponse DeleteRecordingPlanSync(DeleteRecordingPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordingPlanResponse>(req, "DeleteRecordingPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteSceneRequest"/></param>
        /// <returns><see cref="DeleteSceneResponse"/></returns>
        public Task<DeleteSceneResponse> DeleteScene(DeleteSceneRequest req)
        {
            return InternalRequestAsync<DeleteSceneResponse>(req, "DeleteScene");
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteSceneRequest"/></param>
        /// <returns><see cref="DeleteSceneResponse"/></returns>
        public DeleteSceneResponse DeleteSceneSync(DeleteSceneRequest req)
        {
            return InternalRequestAsync<DeleteSceneResponse>(req, "DeleteScene")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DeleteTimeTemplate) 用于删除时间模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTimeTemplateResponse"/></returns>
        public Task<DeleteTimeTemplateResponse> DeleteTimeTemplate(DeleteTimeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTimeTemplateResponse>(req, "DeleteTimeTemplate");
        }

        /// <summary>
        /// 本接口(DeleteTimeTemplate) 用于删除时间模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTimeTemplateResponse"/></returns>
        public DeleteTimeTemplateResponse DeleteTimeTemplateSync(DeleteTimeTemplateRequest req)
        {
            return InternalRequestAsync<DeleteTimeTemplateResponse>(req, "DeleteTimeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除录像存储列表
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoListRequest"/></param>
        /// <returns><see cref="DeleteVideoListResponse"/></returns>
        public Task<DeleteVideoListResponse> DeleteVideoList(DeleteVideoListRequest req)
        {
            return InternalRequestAsync<DeleteVideoListResponse>(req, "DeleteVideoList");
        }

        /// <summary>
        /// 删除录像存储列表
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoListRequest"/></param>
        /// <returns><see cref="DeleteVideoListResponse"/></returns>
        public DeleteVideoListResponse DeleteVideoListSync(DeleteVideoListRequest req)
        {
            return InternalRequestAsync<DeleteVideoListResponse>(req, "DeleteVideoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备告警-删除告警
        /// </summary>
        /// <param name="req"><see cref="DeleteWarningRequest"/></param>
        /// <returns><see cref="DeleteWarningResponse"/></returns>
        public Task<DeleteWarningResponse> DeleteWarning(DeleteWarningRequest req)
        {
            return InternalRequestAsync<DeleteWarningResponse>(req, "DeleteWarning");
        }

        /// <summary>
        /// 设备告警-删除告警
        /// </summary>
        /// <param name="req"><see cref="DeleteWarningRequest"/></param>
        /// <returns><see cref="DeleteWarningResponse"/></returns>
        public DeleteWarningResponse DeleteWarningSync(DeleteWarningRequest req)
        {
            return InternalRequestAsync<DeleteWarningResponse>(req, "DeleteWarning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取异常事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalEventsResponse"/></returns>
        public Task<DescribeAbnormalEventsResponse> DescribeAbnormalEvents(DescribeAbnormalEventsRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalEventsResponse>(req, "DescribeAbnormalEvents");
        }

        /// <summary>
        /// 获取异常事件统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalEventsResponse"/></returns>
        public DescribeAbnormalEventsResponse DescribeAbnormalEventsSync(DescribeAbnormalEventsRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalEventsResponse>(req, "DescribeAbnormalEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeAllDeviceList) 用于获取设备列表。
        /// 请使用DescribeDevicesList接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAllDeviceListRequest"/></param>
        /// <returns><see cref="DescribeAllDeviceListResponse"/></returns>
        public Task<DescribeAllDeviceListResponse> DescribeAllDeviceList(DescribeAllDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeAllDeviceListResponse>(req, "DescribeAllDeviceList");
        }

        /// <summary>
        /// 本接口(DescribeAllDeviceList) 用于获取设备列表。
        /// 请使用DescribeDevicesList接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAllDeviceListRequest"/></param>
        /// <returns><see cref="DescribeAllDeviceListResponse"/></returns>
        public DescribeAllDeviceListResponse DescribeAllDeviceListSync(DescribeAllDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeAllDeviceListResponse>(req, "DescribeAllDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取场景绑定通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneChannelsRequest"/></param>
        /// <returns><see cref="DescribeBindSceneChannelsResponse"/></returns>
        public Task<DescribeBindSceneChannelsResponse> DescribeBindSceneChannels(DescribeBindSceneChannelsRequest req)
        {
            return InternalRequestAsync<DescribeBindSceneChannelsResponse>(req, "DescribeBindSceneChannels");
        }

        /// <summary>
        /// 获取场景绑定通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneChannelsRequest"/></param>
        /// <returns><see cref="DescribeBindSceneChannelsResponse"/></returns>
        public DescribeBindSceneChannelsResponse DescribeBindSceneChannelsSync(DescribeBindSceneChannelsRequest req)
        {
            return InternalRequestAsync<DescribeBindSceneChannelsResponse>(req, "DescribeBindSceneChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取场景绑定设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneDevicesRequest"/></param>
        /// <returns><see cref="DescribeBindSceneDevicesResponse"/></returns>
        public Task<DescribeBindSceneDevicesResponse> DescribeBindSceneDevices(DescribeBindSceneDevicesRequest req)
        {
            return InternalRequestAsync<DescribeBindSceneDevicesResponse>(req, "DescribeBindSceneDevices");
        }

        /// <summary>
        /// 获取场景绑定设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindSceneDevicesRequest"/></param>
        /// <returns><see cref="DescribeBindSceneDevicesResponse"/></returns>
        public DescribeBindSceneDevicesResponse DescribeBindSceneDevicesSync(DescribeBindSceneDevicesRequest req)
        {
            return InternalRequestAsync<DescribeBindSceneDevicesResponse>(req, "DescribeBindSceneDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeChannelLiveStreamURL)用于获取设备指定通道实时流地址，地址是动态生成，如重新播放需要调用此接口重新获取最新播放地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelLiveStreamURLRequest"/></param>
        /// <returns><see cref="DescribeChannelLiveStreamURLResponse"/></returns>
        public Task<DescribeChannelLiveStreamURLResponse> DescribeChannelLiveStreamURL(DescribeChannelLiveStreamURLRequest req)
        {
            return InternalRequestAsync<DescribeChannelLiveStreamURLResponse>(req, "DescribeChannelLiveStreamURL");
        }

        /// <summary>
        /// 本接口(DescribeChannelLiveStreamURL)用于获取设备指定通道实时流地址，地址是动态生成，如重新播放需要调用此接口重新获取最新播放地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelLiveStreamURLRequest"/></param>
        /// <returns><see cref="DescribeChannelLiveStreamURLResponse"/></returns>
        public DescribeChannelLiveStreamURLResponse DescribeChannelLiveStreamURLSync(DescribeChannelLiveStreamURLRequest req)
        {
            return InternalRequestAsync<DescribeChannelLiveStreamURLResponse>(req, "DescribeChannelLiveStreamURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeChannelLocalRecordURL）用于将NVR等设备对应通道本地回放文件，通过GB28181信令推送至云端，并生成对应的实时视频流URL，流地址URL是动态生成，如需重新播放请重新调用此接口获取最新地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelLocalRecordURLRequest"/></param>
        /// <returns><see cref="DescribeChannelLocalRecordURLResponse"/></returns>
        public Task<DescribeChannelLocalRecordURLResponse> DescribeChannelLocalRecordURL(DescribeChannelLocalRecordURLRequest req)
        {
            return InternalRequestAsync<DescribeChannelLocalRecordURLResponse>(req, "DescribeChannelLocalRecordURL");
        }

        /// <summary>
        /// 本接口（DescribeChannelLocalRecordURL）用于将NVR等设备对应通道本地回放文件，通过GB28181信令推送至云端，并生成对应的实时视频流URL，流地址URL是动态生成，如需重新播放请重新调用此接口获取最新地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelLocalRecordURLRequest"/></param>
        /// <returns><see cref="DescribeChannelLocalRecordURLResponse"/></returns>
        public DescribeChannelLocalRecordURLResponse DescribeChannelLocalRecordURLSync(DescribeChannelLocalRecordURLRequest req)
        {
            return InternalRequestAsync<DescribeChannelLocalRecordURLResponse>(req, "DescribeChannelLocalRecordURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeChannelStreamURL)用于获取设备指定通道实时流地址，地址是动态生成，如重新播放需要调用此接口重新获取最新播放地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelStreamURLRequest"/></param>
        /// <returns><see cref="DescribeChannelStreamURLResponse"/></returns>
        public Task<DescribeChannelStreamURLResponse> DescribeChannelStreamURL(DescribeChannelStreamURLRequest req)
        {
            return InternalRequestAsync<DescribeChannelStreamURLResponse>(req, "DescribeChannelStreamURL");
        }

        /// <summary>
        /// 本接口(DescribeChannelStreamURL)用于获取设备指定通道实时流地址，地址是动态生成，如重新播放需要调用此接口重新获取最新播放地址。
        /// 正常推流，如未设置对应录制计划，且180s无人观看此流，将会被自动掐断。
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelStreamURLRequest"/></param>
        /// <returns><see cref="DescribeChannelStreamURLResponse"/></returns>
        public DescribeChannelStreamURLResponse DescribeChannelStreamURLSync(DescribeChannelStreamURLRequest req)
        {
            return InternalRequestAsync<DescribeChannelStreamURLResponse>(req, "DescribeChannelStreamURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeChannels）用于获取设备下属通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsRequest"/></param>
        /// <returns><see cref="DescribeChannelsResponse"/></returns>
        public Task<DescribeChannelsResponse> DescribeChannels(DescribeChannelsRequest req)
        {
            return InternalRequestAsync<DescribeChannelsResponse>(req, "DescribeChannels");
        }

        /// <summary>
        /// 本接口（DescribeChannels）用于获取设备下属通道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsRequest"/></param>
        /// <returns><see cref="DescribeChannelsResponse"/></returns>
        public DescribeChannelsResponse DescribeChannelsSync(DescribeChannelsRequest req)
        {
            return InternalRequestAsync<DescribeChannelsResponse>(req, "DescribeChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据直播录制计划获取频道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsByLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeChannelsByLiveRecordPlanResponse"/></returns>
        public Task<DescribeChannelsByLiveRecordPlanResponse> DescribeChannelsByLiveRecordPlan(DescribeChannelsByLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<DescribeChannelsByLiveRecordPlanResponse>(req, "DescribeChannelsByLiveRecordPlan");
        }

        /// <summary>
        /// 根据直播录制计划获取频道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeChannelsByLiveRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeChannelsByLiveRecordPlanResponse"/></returns>
        public DescribeChannelsByLiveRecordPlanResponse DescribeChannelsByLiveRecordPlanSync(DescribeChannelsByLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<DescribeChannelsByLiveRecordPlanResponse>(req, "DescribeChannelsByLiveRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备统计当前信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeCurrentDeviceDataResponse"/></returns>
        public Task<DescribeCurrentDeviceDataResponse> DescribeCurrentDeviceData(DescribeCurrentDeviceDataRequest req)
        {
            return InternalRequestAsync<DescribeCurrentDeviceDataResponse>(req, "DescribeCurrentDeviceData");
        }

        /// <summary>
        /// 查询设备统计当前信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeCurrentDeviceDataResponse"/></returns>
        public DescribeCurrentDeviceDataResponse DescribeCurrentDeviceDataSync(DescribeCurrentDeviceDataRequest req)
        {
            return InternalRequestAsync<DescribeCurrentDeviceDataResponse>(req, "DescribeCurrentDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定设备详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice");
        }

        /// <summary>
        /// 获取指定设备详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceEventRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventResponse"/></returns>
        public Task<DescribeDeviceEventResponse> DescribeDeviceEvent(DescribeDeviceEventRequest req)
        {
            return InternalRequestAsync<DescribeDeviceEventResponse>(req, "DescribeDeviceEvent");
        }

        /// <summary>
        /// 获取设备事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceEventRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventResponse"/></returns>
        public DescribeDeviceEventResponse DescribeDeviceEventSync(DescribeDeviceEventRequest req)
        {
            return InternalRequestAsync<DescribeDeviceEventResponse>(req, "DescribeDeviceEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDeviceGroup)用于根据设备ID查询设备所在分组信息，可批量查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupResponse"/></returns>
        public Task<DescribeDeviceGroupResponse> DescribeDeviceGroup(DescribeDeviceGroupRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupResponse>(req, "DescribeDeviceGroup");
        }

        /// <summary>
        /// 本接口(DescribeDeviceGroup)用于根据设备ID查询设备所在分组信息，可批量查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupResponse"/></returns>
        public DescribeDeviceGroupResponse DescribeDeviceGroupSync(DescribeDeviceGroupRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupResponse>(req, "DescribeDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDeviceList) 用于获取设备列表，支持模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public Task<DescribeDeviceListResponse> DescribeDeviceList(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList");
        }

        /// <summary>
        /// 本接口(DescribeDeviceList) 用于获取设备列表，支持模糊搜索
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public DescribeDeviceListResponse DescribeDeviceListSync(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备统计monitor信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorDataResponse"/></returns>
        public Task<DescribeDeviceMonitorDataResponse> DescribeDeviceMonitorData(DescribeDeviceMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeDeviceMonitorDataResponse>(req, "DescribeDeviceMonitorData");
        }

        /// <summary>
        /// 查询设备统计monitor信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorDataResponse"/></returns>
        public DescribeDeviceMonitorDataResponse DescribeDeviceMonitorDataSync(DescribeDeviceMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeDeviceMonitorDataResponse>(req, "DescribeDeviceMonitorData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDevicePassWord)用于查询设备密码。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePassWordRequest"/></param>
        /// <returns><see cref="DescribeDevicePassWordResponse"/></returns>
        public Task<DescribeDevicePassWordResponse> DescribeDevicePassWord(DescribeDevicePassWordRequest req)
        {
            return InternalRequestAsync<DescribeDevicePassWordResponse>(req, "DescribeDevicePassWord");
        }

        /// <summary>
        /// 本接口(DescribeDevicePassWord)用于查询设备密码。
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePassWordRequest"/></param>
        /// <returns><see cref="DescribeDevicePassWordResponse"/></returns>
        public DescribeDevicePassWordResponse DescribeDevicePassWordSync(DescribeDevicePassWordRequest req)
        {
            return InternalRequestAsync<DescribeDevicePassWordResponse>(req, "DescribeDevicePassWord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDeviceStreams)用于获取设备实时流地址。
        /// 请使用DescribeChannelStreamURL接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStreamsRequest"/></param>
        /// <returns><see cref="DescribeDeviceStreamsResponse"/></returns>
        public Task<DescribeDeviceStreamsResponse> DescribeDeviceStreams(DescribeDeviceStreamsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStreamsResponse>(req, "DescribeDeviceStreams");
        }

        /// <summary>
        /// 本接口(DescribeDeviceStreams)用于获取设备实时流地址。
        /// 请使用DescribeChannelStreamURL接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStreamsRequest"/></param>
        /// <returns><see cref="DescribeDeviceStreamsResponse"/></returns>
        public DescribeDeviceStreamsResponse DescribeDeviceStreamsSync(DescribeDeviceStreamsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStreamsResponse>(req, "DescribeDeviceStreams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeGroupById)用于根据分组ID查询分组。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByIdRequest"/></param>
        /// <returns><see cref="DescribeGroupByIdResponse"/></returns>
        public Task<DescribeGroupByIdResponse> DescribeGroupById(DescribeGroupByIdRequest req)
        {
            return InternalRequestAsync<DescribeGroupByIdResponse>(req, "DescribeGroupById");
        }

        /// <summary>
        /// 本接口(DescribeGroupById)用于根据分组ID查询分组。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByIdRequest"/></param>
        /// <returns><see cref="DescribeGroupByIdResponse"/></returns>
        public DescribeGroupByIdResponse DescribeGroupByIdSync(DescribeGroupByIdRequest req)
        {
            return InternalRequestAsync<DescribeGroupByIdResponse>(req, "DescribeGroupById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据分组路径查询分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByPathRequest"/></param>
        /// <returns><see cref="DescribeGroupByPathResponse"/></returns>
        public Task<DescribeGroupByPathResponse> DescribeGroupByPath(DescribeGroupByPathRequest req)
        {
            return InternalRequestAsync<DescribeGroupByPathResponse>(req, "DescribeGroupByPath");
        }

        /// <summary>
        /// 根据分组路径查询分组
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupByPathRequest"/></param>
        /// <returns><see cref="DescribeGroupByPathResponse"/></returns>
        public DescribeGroupByPathResponse DescribeGroupByPathSync(DescribeGroupByPathRequest req)
        {
            return InternalRequestAsync<DescribeGroupByPathResponse>(req, "DescribeGroupByPath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeGroupDevices)用于查询分组下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDevicesRequest"/></param>
        /// <returns><see cref="DescribeGroupDevicesResponse"/></returns>
        public Task<DescribeGroupDevicesResponse> DescribeGroupDevices(DescribeGroupDevicesRequest req)
        {
            return InternalRequestAsync<DescribeGroupDevicesResponse>(req, "DescribeGroupDevices");
        }

        /// <summary>
        /// 本接口(DescribeGroupDevices)用于查询分组下的设备列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupDevicesRequest"/></param>
        /// <returns><see cref="DescribeGroupDevicesResponse"/></returns>
        public DescribeGroupDevicesResponse DescribeGroupDevicesSync(DescribeGroupDevicesRequest req)
        {
            return InternalRequestAsync<DescribeGroupDevicesResponse>(req, "DescribeGroupDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeGroups)用于批量查询分组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public Task<DescribeGroupsResponse> DescribeGroups(DescribeGroupsRequest req)
        {
            return InternalRequestAsync<DescribeGroupsResponse>(req, "DescribeGroups");
        }

        /// <summary>
        /// 本接口(DescribeGroups)用于批量查询分组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupsRequest"/></param>
        /// <returns><see cref="DescribeGroupsResponse"/></returns>
        public DescribeGroupsResponse DescribeGroupsSync(DescribeGroupsRequest req)
        {
            return InternalRequestAsync<DescribeGroupsResponse>(req, "DescribeGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IPC设备下属通道
        /// 请使用DescribeChannels接口
        /// </summary>
        /// <param name="req"><see cref="DescribeIPCChannelsRequest"/></param>
        /// <returns><see cref="DescribeIPCChannelsResponse"/></returns>
        public Task<DescribeIPCChannelsResponse> DescribeIPCChannels(DescribeIPCChannelsRequest req)
        {
            return InternalRequestAsync<DescribeIPCChannelsResponse>(req, "DescribeIPCChannels");
        }

        /// <summary>
        /// 获取IPC设备下属通道
        /// 请使用DescribeChannels接口
        /// </summary>
        /// <param name="req"><see cref="DescribeIPCChannelsRequest"/></param>
        /// <returns><see cref="DescribeIPCChannelsResponse"/></returns>
        public DescribeIPCChannelsResponse DescribeIPCChannelsSync(DescribeIPCChannelsRequest req)
        {
            return InternalRequestAsync<DescribeIPCChannelsResponse>(req, "DescribeIPCChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelResponse"/></returns>
        public Task<DescribeLiveChannelResponse> DescribeLiveChannel(DescribeLiveChannelRequest req)
        {
            return InternalRequestAsync<DescribeLiveChannelResponse>(req, "DescribeLiveChannel");
        }

        /// <summary>
        /// 直播详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelResponse"/></returns>
        public DescribeLiveChannelResponse DescribeLiveChannelSync(DescribeLiveChannelRequest req)
        {
            return InternalRequestAsync<DescribeLiveChannelResponse>(req, "DescribeLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelListRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelListResponse"/></returns>
        public Task<DescribeLiveChannelListResponse> DescribeLiveChannelList(DescribeLiveChannelListRequest req)
        {
            return InternalRequestAsync<DescribeLiveChannelListResponse>(req, "DescribeLiveChannelList");
        }

        /// <summary>
        /// 直播列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveChannelListRequest"/></param>
        /// <returns><see cref="DescribeLiveChannelListResponse"/></returns>
        public DescribeLiveChannelListResponse DescribeLiveChannelListSync(DescribeLiveChannelListRequest req)
        {
            return InternalRequestAsync<DescribeLiveChannelListResponse>(req, "DescribeLiveChannelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播录制计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanByIdResponse"/></returns>
        public Task<DescribeLiveRecordPlanByIdResponse> DescribeLiveRecordPlanById(DescribeLiveRecordPlanByIdRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordPlanByIdResponse>(req, "DescribeLiveRecordPlanById");
        }

        /// <summary>
        /// 获取直播录制计划详情
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanByIdResponse"/></returns>
        public DescribeLiveRecordPlanByIdResponse DescribeLiveRecordPlanByIdSync(DescribeLiveRecordPlanByIdRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordPlanByIdResponse>(req, "DescribeLiveRecordPlanById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取直播录制计划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanIdsRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanIdsResponse"/></returns>
        public Task<DescribeLiveRecordPlanIdsResponse> DescribeLiveRecordPlanIds(DescribeLiveRecordPlanIdsRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordPlanIdsResponse>(req, "DescribeLiveRecordPlanIds");
        }

        /// <summary>
        /// 获取直播录制计划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveRecordPlanIdsRequest"/></param>
        /// <returns><see cref="DescribeLiveRecordPlanIdsResponse"/></returns>
        public DescribeLiveRecordPlanIdsResponse DescribeLiveRecordPlanIdsSync(DescribeLiveRecordPlanIdsRequest req)
        {
            return InternalRequestAsync<DescribeLiveRecordPlanIdsResponse>(req, "DescribeLiveRecordPlanIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播拉流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamResponse"/></returns>
        public Task<DescribeLiveStreamResponse> DescribeLiveStream(DescribeLiveStreamRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamResponse>(req, "DescribeLiveStream");
        }

        /// <summary>
        /// 直播拉流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeLiveStreamResponse"/></returns>
        public DescribeLiveStreamResponse DescribeLiveStreamSync(DescribeLiveStreamRequest req)
        {
            return InternalRequestAsync<DescribeLiveStreamResponse>(req, "DescribeLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播录像回放列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVideoListRequest"/></param>
        /// <returns><see cref="DescribeLiveVideoListResponse"/></returns>
        public Task<DescribeLiveVideoListResponse> DescribeLiveVideoList(DescribeLiveVideoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveVideoListResponse>(req, "DescribeLiveVideoList");
        }

        /// <summary>
        /// 直播录像回放列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLiveVideoListRequest"/></param>
        /// <returns><see cref="DescribeLiveVideoListResponse"/></returns>
        public DescribeLiveVideoListResponse DescribeLiveVideoListSync(DescribeLiveVideoListRequest req)
        {
            return InternalRequestAsync<DescribeLiveVideoListResponse>(req, "DescribeLiveVideoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看消息转发配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardResponse"/></returns>
        public Task<DescribeMessageForwardResponse> DescribeMessageForward(DescribeMessageForwardRequest req)
        {
            return InternalRequestAsync<DescribeMessageForwardResponse>(req, "DescribeMessageForward");
        }

        /// <summary>
        /// 查看消息转发配置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardResponse"/></returns>
        public DescribeMessageForwardResponse DescribeMessageForwardSync(DescribeMessageForwardRequest req)
        {
            return InternalRequestAsync<DescribeMessageForwardResponse>(req, "DescribeMessageForward")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看消息转发配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardsRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardsResponse"/></returns>
        public Task<DescribeMessageForwardsResponse> DescribeMessageForwards(DescribeMessageForwardsRequest req)
        {
            return InternalRequestAsync<DescribeMessageForwardsResponse>(req, "DescribeMessageForwards");
        }

        /// <summary>
        /// 查看消息转发配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMessageForwardsRequest"/></param>
        /// <returns><see cref="DescribeMessageForwardsResponse"/></returns>
        public DescribeMessageForwardsResponse DescribeMessageForwardsSync(DescribeMessageForwardsRequest req)
        {
            return InternalRequestAsync<DescribeMessageForwardsResponse>(req, "DescribeMessageForwards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运营中心-设备录像存储统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorDataByDateRequest"/></param>
        /// <returns><see cref="DescribeMonitorDataByDateResponse"/></returns>
        public Task<DescribeMonitorDataByDateResponse> DescribeMonitorDataByDate(DescribeMonitorDataByDateRequest req)
        {
            return InternalRequestAsync<DescribeMonitorDataByDateResponse>(req, "DescribeMonitorDataByDate");
        }

        /// <summary>
        /// 运营中心-设备录像存储统计
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorDataByDateRequest"/></param>
        /// <returns><see cref="DescribeMonitorDataByDateResponse"/></returns>
        public DescribeMonitorDataByDateResponse DescribeMonitorDataByDateSync(DescribeMonitorDataByDateRequest req)
        {
            return InternalRequestAsync<DescribeMonitorDataByDateResponse>(req, "DescribeMonitorDataByDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取预置位列表
        /// </summary>
        /// <param name="req"><see cref="DescribePresetListRequest"/></param>
        /// <returns><see cref="DescribePresetListResponse"/></returns>
        public Task<DescribePresetListResponse> DescribePresetList(DescribePresetListRequest req)
        {
            return InternalRequestAsync<DescribePresetListResponse>(req, "DescribePresetList");
        }

        /// <summary>
        /// 获取预置位列表
        /// </summary>
        /// <param name="req"><see cref="DescribePresetListRequest"/></param>
        /// <returns><see cref="DescribePresetListResponse"/></returns>
        public DescribePresetListResponse DescribePresetListSync(DescribePresetListRequest req)
        {
            return InternalRequestAsync<DescribePresetListResponse>(req, "DescribePresetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRecordDatesByChannel)用于查询设备含有录像文件的日期列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByChannelRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByChannelResponse"/></returns>
        public Task<DescribeRecordDatesByChannelResponse> DescribeRecordDatesByChannel(DescribeRecordDatesByChannelRequest req)
        {
            return InternalRequestAsync<DescribeRecordDatesByChannelResponse>(req, "DescribeRecordDatesByChannel");
        }

        /// <summary>
        /// 本接口(DescribeRecordDatesByChannel)用于查询设备含有录像文件的日期列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByChannelRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByChannelResponse"/></returns>
        public DescribeRecordDatesByChannelResponse DescribeRecordDatesByChannelSync(DescribeRecordDatesByChannelRequest req)
        {
            return InternalRequestAsync<DescribeRecordDatesByChannelResponse>(req, "DescribeRecordDatesByChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播录像存储日期列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByLiveRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByLiveResponse"/></returns>
        public Task<DescribeRecordDatesByLiveResponse> DescribeRecordDatesByLive(DescribeRecordDatesByLiveRequest req)
        {
            return InternalRequestAsync<DescribeRecordDatesByLiveResponse>(req, "DescribeRecordDatesByLive");
        }

        /// <summary>
        /// 直播录像存储日期列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordDatesByLiveRequest"/></param>
        /// <returns><see cref="DescribeRecordDatesByLiveResponse"/></returns>
        public DescribeRecordDatesByLiveResponse DescribeRecordDatesByLiveSync(DescribeRecordDatesByLiveRequest req)
        {
            return InternalRequestAsync<DescribeRecordDatesByLiveResponse>(req, "DescribeRecordDatesByLive")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeRecordStreamResponse> DescribeRecordStream(DescribeRecordStreamRequest req)
        {
            return InternalRequestAsync<DescribeRecordStreamResponse>(req, "DescribeRecordStream");
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
            return InternalRequestAsync<DescribeRecordStreamResponse>(req, "DescribeRecordStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlanById)用于根据录制计划ID获取录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlanByIdResponse"/></returns>
        public Task<DescribeRecordingPlanByIdResponse> DescribeRecordingPlanById(DescribeRecordingPlanByIdRequest req)
        {
            return InternalRequestAsync<DescribeRecordingPlanByIdResponse>(req, "DescribeRecordingPlanById");
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlanById)用于根据录制计划ID获取录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlanByIdRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlanByIdResponse"/></returns>
        public DescribeRecordingPlanByIdResponse DescribeRecordingPlanByIdSync(DescribeRecordingPlanByIdRequest req)
        {
            return InternalRequestAsync<DescribeRecordingPlanByIdResponse>(req, "DescribeRecordingPlanById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlans)用于获取用户的全部录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlansRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlansResponse"/></returns>
        public Task<DescribeRecordingPlansResponse> DescribeRecordingPlans(DescribeRecordingPlansRequest req)
        {
            return InternalRequestAsync<DescribeRecordingPlansResponse>(req, "DescribeRecordingPlans");
        }

        /// <summary>
        /// 本接口(DescribeRecordingPlans)用于获取用户的全部录制计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingPlansRequest"/></param>
        /// <returns><see cref="DescribeRecordingPlansResponse"/></returns>
        public DescribeRecordingPlansResponse DescribeRecordingPlansSync(DescribeRecordingPlansRequest req)
        {
            return InternalRequestAsync<DescribeRecordingPlansResponse>(req, "DescribeRecordingPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取SIP服务器相关配置，用户可以通过这些配置项，将设备通过GB28181协议注册到本服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeSIPServerRequest"/></param>
        /// <returns><see cref="DescribeSIPServerResponse"/></returns>
        public Task<DescribeSIPServerResponse> DescribeSIPServer(DescribeSIPServerRequest req)
        {
            return InternalRequestAsync<DescribeSIPServerResponse>(req, "DescribeSIPServer");
        }

        /// <summary>
        /// 本接口用于获取SIP服务器相关配置，用户可以通过这些配置项，将设备通过GB28181协议注册到本服务。
        /// </summary>
        /// <param name="req"><see cref="DescribeSIPServerRequest"/></param>
        /// <returns><see cref="DescribeSIPServerResponse"/></returns>
        public DescribeSIPServerResponse DescribeSIPServerSync(DescribeSIPServerRequest req)
        {
            return InternalRequestAsync<DescribeSIPServerResponse>(req, "DescribeSIPServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 场景详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneRequest"/></param>
        /// <returns><see cref="DescribeSceneResponse"/></returns>
        public Task<DescribeSceneResponse> DescribeScene(DescribeSceneRequest req)
        {
            return InternalRequestAsync<DescribeSceneResponse>(req, "DescribeScene");
        }

        /// <summary>
        /// 场景详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneRequest"/></param>
        /// <returns><see cref="DescribeSceneResponse"/></returns>
        public DescribeSceneResponse DescribeSceneSync(DescribeSceneRequest req)
        {
            return InternalRequestAsync<DescribeSceneResponse>(req, "DescribeScene")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public Task<DescribeScenesResponse> DescribeScenes(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes");
        }

        /// <summary>
        /// 获取场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public DescribeScenesResponse DescribeScenesSync(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeStatisticDetails)用于查询指定统计项详情，返回结果按天为单位聚合，支持的最大时间查询范围为31天。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeStatisticDetailsResponse"/></returns>
        public Task<DescribeStatisticDetailsResponse> DescribeStatisticDetails(DescribeStatisticDetailsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticDetailsResponse>(req, "DescribeStatisticDetails");
        }

        /// <summary>
        /// 本接口(DescribeStatisticDetails)用于查询指定统计项详情，返回结果按天为单位聚合，支持的最大时间查询范围为31天。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeStatisticDetailsResponse"/></returns>
        public DescribeStatisticDetailsResponse DescribeStatisticDetailsSync(DescribeStatisticDetailsRequest req)
        {
            return InternalRequestAsync<DescribeStatisticDetailsResponse>(req, "DescribeStatisticDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeStatisticSummary)用于查询用户昨日的概览数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeStatisticSummaryResponse"/></returns>
        public Task<DescribeStatisticSummaryResponse> DescribeStatisticSummary(DescribeStatisticSummaryRequest req)
        {
            return InternalRequestAsync<DescribeStatisticSummaryResponse>(req, "DescribeStatisticSummary");
        }

        /// <summary>
        /// 本接口(DescribeStatisticSummary)用于查询用户昨日的概览数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeStatisticSummaryResponse"/></returns>
        public DescribeStatisticSummaryResponse DescribeStatisticSummarySync(DescribeStatisticSummaryRequest req)
        {
            return InternalRequestAsync<DescribeStatisticSummaryResponse>(req, "DescribeStatisticSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSubGroups)用于查询分组下的子分组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubGroupsRequest"/></param>
        /// <returns><see cref="DescribeSubGroupsResponse"/></returns>
        public Task<DescribeSubGroupsResponse> DescribeSubGroups(DescribeSubGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSubGroupsResponse>(req, "DescribeSubGroups");
        }

        /// <summary>
        /// 本接口(DescribeSubGroups)用于查询分组下的子分组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubGroupsRequest"/></param>
        /// <returns><see cref="DescribeSubGroupsResponse"/></returns>
        public DescribeSubGroupsResponse DescribeSubGroupsSync(DescribeSubGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSubGroupsResponse>(req, "DescribeSubGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询主设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionStatusRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionStatusResponse"/></returns>
        public Task<DescribeSubscriptionStatusResponse> DescribeSubscriptionStatus(DescribeSubscriptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionStatusResponse>(req, "DescribeSubscriptionStatus");
        }

        /// <summary>
        /// 查询主设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscriptionStatusRequest"/></param>
        /// <returns><see cref="DescribeSubscriptionStatusResponse"/></returns>
        public DescribeSubscriptionStatusResponse DescribeSubscriptionStatusSync(DescribeSubscriptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeSubscriptionStatusResponse>(req, "DescribeSubscriptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据时间获取云端录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListRequest"/></param>
        /// <returns><see cref="DescribeVideoListResponse"/></returns>
        public Task<DescribeVideoListResponse> DescribeVideoList(DescribeVideoListRequest req)
        {
            return InternalRequestAsync<DescribeVideoListResponse>(req, "DescribeVideoList");
        }

        /// <summary>
        /// 根据时间获取云端录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListRequest"/></param>
        /// <returns><see cref="DescribeVideoListResponse"/></returns>
        public DescribeVideoListResponse DescribeVideoListSync(DescribeVideoListRequest req)
        {
            return InternalRequestAsync<DescribeVideoListResponse>(req, "DescribeVideoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeVideoListByChannel)用于查询指定通道的录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListByChannelRequest"/></param>
        /// <returns><see cref="DescribeVideoListByChannelResponse"/></returns>
        public Task<DescribeVideoListByChannelResponse> DescribeVideoListByChannel(DescribeVideoListByChannelRequest req)
        {
            return InternalRequestAsync<DescribeVideoListByChannelResponse>(req, "DescribeVideoListByChannel");
        }

        /// <summary>
        /// 本接口(DescribeVideoListByChannel)用于查询指定通道的录制文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoListByChannelRequest"/></param>
        /// <returns><see cref="DescribeVideoListByChannelResponse"/></returns>
        public DescribeVideoListByChannelResponse DescribeVideoListByChannelSync(DescribeVideoListByChannelRequest req)
        {
            return InternalRequestAsync<DescribeVideoListByChannelResponse>(req, "DescribeVideoListByChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarnModRequest"/></param>
        /// <returns><see cref="DescribeWarnModResponse"/></returns>
        public Task<DescribeWarnModResponse> DescribeWarnMod(DescribeWarnModRequest req)
        {
            return InternalRequestAsync<DescribeWarnModResponse>(req, "DescribeWarnMod");
        }

        /// <summary>
        /// 告警等级列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarnModRequest"/></param>
        /// <returns><see cref="DescribeWarnModResponse"/></returns>
        public DescribeWarnModResponse DescribeWarnModSync(DescribeWarnModRequest req)
        {
            return InternalRequestAsync<DescribeWarnModResponse>(req, "DescribeWarnMod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningsRequest"/></param>
        /// <returns><see cref="DescribeWarningsResponse"/></returns>
        public Task<DescribeWarningsResponse> DescribeWarnings(DescribeWarningsRequest req)
        {
            return InternalRequestAsync<DescribeWarningsResponse>(req, "DescribeWarnings");
        }

        /// <summary>
        /// 获取告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningsRequest"/></param>
        /// <returns><see cref="DescribeWarningsResponse"/></returns>
        public DescribeWarningsResponse DescribeWarningsSync(DescribeWarningsRequest req)
        {
            return InternalRequestAsync<DescribeWarningsResponse>(req, "DescribeWarnings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取X-P2P的统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeXP2PDataRequest"/></param>
        /// <returns><see cref="DescribeXP2PDataResponse"/></returns>
        public Task<DescribeXP2PDataResponse> DescribeXP2PData(DescribeXP2PDataRequest req)
        {
            return InternalRequestAsync<DescribeXP2PDataResponse>(req, "DescribeXP2PData");
        }

        /// <summary>
        /// 获取X-P2P的统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeXP2PDataRequest"/></param>
        /// <returns><see cref="DescribeXP2PDataResponse"/></returns>
        public DescribeXP2PDataResponse DescribeXP2PDataSync(DescribeXP2PDataRequest req)
        {
            return InternalRequestAsync<DescribeXP2PDataResponse>(req, "DescribeXP2PData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GetRecordDatesByDev)用于查询设备含有录像文件的日期列表。
        /// 请使用DescribeRecordDatesByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordDatesByDevRequest"/></param>
        /// <returns><see cref="GetRecordDatesByDevResponse"/></returns>
        public Task<GetRecordDatesByDevResponse> GetRecordDatesByDev(GetRecordDatesByDevRequest req)
        {
            return InternalRequestAsync<GetRecordDatesByDevResponse>(req, "GetRecordDatesByDev");
        }

        /// <summary>
        /// 本接口(GetRecordDatesByDev)用于查询设备含有录像文件的日期列表。
        /// 请使用DescribeRecordDatesByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordDatesByDevRequest"/></param>
        /// <returns><see cref="GetRecordDatesByDevResponse"/></returns>
        public GetRecordDatesByDevResponse GetRecordDatesByDevSync(GetRecordDatesByDevRequest req)
        {
            return InternalRequestAsync<GetRecordDatesByDevResponse>(req, "GetRecordDatesByDev")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GetRecordPlanByDev)用于根据设备ID查询其绑定的录制计划.
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByDevRequest"/></param>
        /// <returns><see cref="GetRecordPlanByDevResponse"/></returns>
        public Task<GetRecordPlanByDevResponse> GetRecordPlanByDev(GetRecordPlanByDevRequest req)
        {
            return InternalRequestAsync<GetRecordPlanByDevResponse>(req, "GetRecordPlanByDev");
        }

        /// <summary>
        /// 本接口(GetRecordPlanByDev)用于根据设备ID查询其绑定的录制计划.
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByDevRequest"/></param>
        /// <returns><see cref="GetRecordPlanByDevResponse"/></returns>
        public GetRecordPlanByDevResponse GetRecordPlanByDevSync(GetRecordPlanByDevRequest req)
        {
            return InternalRequestAsync<GetRecordPlanByDevResponse>(req, "GetRecordPlanByDev")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GetRecordPlanById)用于根据录制计划ID获取录制计划。
        /// 请使用DescribeRecordingPlanById接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByIdRequest"/></param>
        /// <returns><see cref="GetRecordPlanByIdResponse"/></returns>
        public Task<GetRecordPlanByIdResponse> GetRecordPlanById(GetRecordPlanByIdRequest req)
        {
            return InternalRequestAsync<GetRecordPlanByIdResponse>(req, "GetRecordPlanById");
        }

        /// <summary>
        /// 本接口(GetRecordPlanById)用于根据录制计划ID获取录制计划。
        /// 请使用DescribeRecordingPlanById接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlanByIdRequest"/></param>
        /// <returns><see cref="GetRecordPlanByIdResponse"/></returns>
        public GetRecordPlanByIdResponse GetRecordPlanByIdSync(GetRecordPlanByIdRequest req)
        {
            return InternalRequestAsync<GetRecordPlanByIdResponse>(req, "GetRecordPlanById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GetRecordPlans)用于获取用户的全部录制计划。
        /// 请使用DescribeRecordingPlans接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlansRequest"/></param>
        /// <returns><see cref="GetRecordPlansResponse"/></returns>
        public Task<GetRecordPlansResponse> GetRecordPlans(GetRecordPlansRequest req)
        {
            return InternalRequestAsync<GetRecordPlansResponse>(req, "GetRecordPlans");
        }

        /// <summary>
        /// 本接口(GetRecordPlans)用于获取用户的全部录制计划。
        /// 请使用DescribeRecordingPlans接口
        /// </summary>
        /// <param name="req"><see cref="GetRecordPlansRequest"/></param>
        /// <returns><see cref="GetRecordPlansResponse"/></returns>
        public GetRecordPlansResponse GetRecordPlansSync(GetRecordPlansRequest req)
        {
            return InternalRequestAsync<GetRecordPlansResponse>(req, "GetRecordPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GetTimeTemplateById)用于根据模板ID获取时间模板详情。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplateByIdRequest"/></param>
        /// <returns><see cref="GetTimeTemplateByIdResponse"/></returns>
        public Task<GetTimeTemplateByIdResponse> GetTimeTemplateById(GetTimeTemplateByIdRequest req)
        {
            return InternalRequestAsync<GetTimeTemplateByIdResponse>(req, "GetTimeTemplateById");
        }

        /// <summary>
        /// 本接口(GetTimeTemplateById)用于根据模板ID获取时间模板详情。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplateByIdRequest"/></param>
        /// <returns><see cref="GetTimeTemplateByIdResponse"/></returns>
        public GetTimeTemplateByIdResponse GetTimeTemplateByIdSync(GetTimeTemplateByIdRequest req)
        {
            return InternalRequestAsync<GetTimeTemplateByIdResponse>(req, "GetTimeTemplateById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GetTimeTemplates)用于获取时间模板列表。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplatesRequest"/></param>
        /// <returns><see cref="GetTimeTemplatesResponse"/></returns>
        public Task<GetTimeTemplatesResponse> GetTimeTemplates(GetTimeTemplatesRequest req)
        {
            return InternalRequestAsync<GetTimeTemplatesResponse>(req, "GetTimeTemplates");
        }

        /// <summary>
        /// 本接口(GetTimeTemplates)用于获取时间模板列表。
        /// </summary>
        /// <param name="req"><see cref="GetTimeTemplatesRequest"/></param>
        /// <returns><see cref="GetTimeTemplatesResponse"/></returns>
        public GetTimeTemplatesResponse GetTimeTemplatesSync(GetTimeTemplatesRequest req)
        {
            return InternalRequestAsync<GetTimeTemplatesResponse>(req, "GetTimeTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(GetVideoListByCon)用于查询设备的录制文件列表
        /// 请使用DescribeVideoListByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetVideoListByConRequest"/></param>
        /// <returns><see cref="GetVideoListByConResponse"/></returns>
        public Task<GetVideoListByConResponse> GetVideoListByCon(GetVideoListByConRequest req)
        {
            return InternalRequestAsync<GetVideoListByConResponse>(req, "GetVideoListByCon");
        }

        /// <summary>
        /// 本接口(GetVideoListByCon)用于查询设备的录制文件列表
        /// 请使用DescribeVideoListByChannel接口
        /// </summary>
        /// <param name="req"><see cref="GetVideoListByConRequest"/></param>
        /// <returns><see cref="GetVideoListByConResponse"/></returns>
        public GetVideoListByConResponse GetVideoListByConSync(GetVideoListByConRequest req)
        {
            return InternalRequestAsync<GetVideoListByConResponse>(req, "GetVideoListByCon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播录制计划绑定解绑直播频道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindPlanLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyBindPlanLiveChannelResponse"/></returns>
        public Task<ModifyBindPlanLiveChannelResponse> ModifyBindPlanLiveChannel(ModifyBindPlanLiveChannelRequest req)
        {
            return InternalRequestAsync<ModifyBindPlanLiveChannelResponse>(req, "ModifyBindPlanLiveChannel");
        }

        /// <summary>
        /// 直播录制计划绑定解绑直播频道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindPlanLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyBindPlanLiveChannelResponse"/></returns>
        public ModifyBindPlanLiveChannelResponse ModifyBindPlanLiveChannelSync(ModifyBindPlanLiveChannelRequest req)
        {
            return InternalRequestAsync<ModifyBindPlanLiveChannelResponse>(req, "ModifyBindPlanLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyBindRecordingPlan)用于更新录制计划绑定的通道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyBindRecordingPlanResponse"/></returns>
        public Task<ModifyBindRecordingPlanResponse> ModifyBindRecordingPlan(ModifyBindRecordingPlanRequest req)
        {
            return InternalRequestAsync<ModifyBindRecordingPlanResponse>(req, "ModifyBindRecordingPlan");
        }

        /// <summary>
        /// 本接口(ModifyBindRecordingPlan)用于更新录制计划绑定的通道
        /// </summary>
        /// <param name="req"><see cref="ModifyBindRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyBindRecordingPlanResponse"/></returns>
        public ModifyBindRecordingPlanResponse ModifyBindRecordingPlanSync(ModifyBindRecordingPlanRequest req)
        {
            return InternalRequestAsync<ModifyBindRecordingPlanResponse>(req, "ModifyBindRecordingPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 场景绑定解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneChannelsRequest"/></param>
        /// <returns><see cref="ModifyBindSceneChannelsResponse"/></returns>
        public Task<ModifyBindSceneChannelsResponse> ModifyBindSceneChannels(ModifyBindSceneChannelsRequest req)
        {
            return InternalRequestAsync<ModifyBindSceneChannelsResponse>(req, "ModifyBindSceneChannels");
        }

        /// <summary>
        /// 场景绑定解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneChannelsRequest"/></param>
        /// <returns><see cref="ModifyBindSceneChannelsResponse"/></returns>
        public ModifyBindSceneChannelsResponse ModifyBindSceneChannelsSync(ModifyBindSceneChannelsRequest req)
        {
            return InternalRequestAsync<ModifyBindSceneChannelsResponse>(req, "ModifyBindSceneChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 场景绑定/解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneDeviceRequest"/></param>
        /// <returns><see cref="ModifyBindSceneDeviceResponse"/></returns>
        public Task<ModifyBindSceneDeviceResponse> ModifyBindSceneDevice(ModifyBindSceneDeviceRequest req)
        {
            return InternalRequestAsync<ModifyBindSceneDeviceResponse>(req, "ModifyBindSceneDevice");
        }

        /// <summary>
        /// 场景绑定/解绑通道接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBindSceneDeviceRequest"/></param>
        /// <returns><see cref="ModifyBindSceneDeviceResponse"/></returns>
        public ModifyBindSceneDeviceResponse ModifyBindSceneDeviceSync(ModifyBindSceneDeviceRequest req)
        {
            return InternalRequestAsync<ModifyBindSceneDeviceResponse>(req, "ModifyBindSceneDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDeviceData)用于编辑设备信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceDataRequest"/></param>
        /// <returns><see cref="ModifyDeviceDataResponse"/></returns>
        public Task<ModifyDeviceDataResponse> ModifyDeviceData(ModifyDeviceDataRequest req)
        {
            return InternalRequestAsync<ModifyDeviceDataResponse>(req, "ModifyDeviceData");
        }

        /// <summary>
        /// 本接口(ModifyDeviceData)用于编辑设备信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceDataRequest"/></param>
        /// <returns><see cref="ModifyDeviceDataResponse"/></returns>
        public ModifyDeviceDataResponse ModifyDeviceDataSync(ModifyDeviceDataRequest req)
        {
            return InternalRequestAsync<ModifyDeviceDataResponse>(req, "ModifyDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑直播接口
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyLiveChannelResponse"/></returns>
        public Task<ModifyLiveChannelResponse> ModifyLiveChannel(ModifyLiveChannelRequest req)
        {
            return InternalRequestAsync<ModifyLiveChannelResponse>(req, "ModifyLiveChannel");
        }

        /// <summary>
        /// 编辑直播接口
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveChannelRequest"/></param>
        /// <returns><see cref="ModifyLiveChannelResponse"/></returns>
        public ModifyLiveChannelResponse ModifyLiveChannelSync(ModifyLiveChannelRequest req)
        {
            return InternalRequestAsync<ModifyLiveChannelResponse>(req, "ModifyLiveChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑直播录制计划
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordPlanRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordPlanResponse"/></returns>
        public Task<ModifyLiveRecordPlanResponse> ModifyLiveRecordPlan(ModifyLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordPlanResponse>(req, "ModifyLiveRecordPlan");
        }

        /// <summary>
        /// 编辑直播录制计划
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveRecordPlanRequest"/></param>
        /// <returns><see cref="ModifyLiveRecordPlanResponse"/></returns>
        public ModifyLiveRecordPlanResponse ModifyLiveRecordPlanSync(ModifyLiveRecordPlanRequest req)
        {
            return InternalRequestAsync<ModifyLiveRecordPlanResponse>(req, "ModifyLiveRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播录像编辑
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveVideoRequest"/></param>
        /// <returns><see cref="ModifyLiveVideoResponse"/></returns>
        public Task<ModifyLiveVideoResponse> ModifyLiveVideo(ModifyLiveVideoRequest req)
        {
            return InternalRequestAsync<ModifyLiveVideoResponse>(req, "ModifyLiveVideo");
        }

        /// <summary>
        /// 直播录像编辑
        /// </summary>
        /// <param name="req"><see cref="ModifyLiveVideoRequest"/></param>
        /// <returns><see cref="ModifyLiveVideoResponse"/></returns>
        public ModifyLiveVideoResponse ModifyLiveVideoSync(ModifyLiveVideoRequest req)
        {
            return InternalRequestAsync<ModifyLiveVideoResponse>(req, "ModifyLiveVideo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改消息转发配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMessageForwardRequest"/></param>
        /// <returns><see cref="ModifyMessageForwardResponse"/></returns>
        public Task<ModifyMessageForwardResponse> ModifyMessageForward(ModifyMessageForwardRequest req)
        {
            return InternalRequestAsync<ModifyMessageForwardResponse>(req, "ModifyMessageForward");
        }

        /// <summary>
        /// 修改消息转发配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMessageForwardRequest"/></param>
        /// <returns><see cref="ModifyMessageForwardResponse"/></returns>
        public ModifyMessageForwardResponse ModifyMessageForwardSync(ModifyMessageForwardRequest req)
        {
            return InternalRequestAsync<ModifyMessageForwardResponse>(req, "ModifyMessageForward")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑预置位信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPresetRequest"/></param>
        /// <returns><see cref="ModifyPresetResponse"/></returns>
        public Task<ModifyPresetResponse> ModifyPreset(ModifyPresetRequest req)
        {
            return InternalRequestAsync<ModifyPresetResponse>(req, "ModifyPreset");
        }

        /// <summary>
        /// 编辑预置位信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPresetRequest"/></param>
        /// <returns><see cref="ModifyPresetResponse"/></returns>
        public ModifyPresetResponse ModifyPresetSync(ModifyPresetRequest req)
        {
            return InternalRequestAsync<ModifyPresetResponse>(req, "ModifyPreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyRecordingPlan)用于更新录制计划。
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyRecordingPlanResponse"/></returns>
        public Task<ModifyRecordingPlanResponse> ModifyRecordingPlan(ModifyRecordingPlanRequest req)
        {
            return InternalRequestAsync<ModifyRecordingPlanResponse>(req, "ModifyRecordingPlan");
        }

        /// <summary>
        /// 本接口(ModifyRecordingPlan)用于更新录制计划。
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordingPlanRequest"/></param>
        /// <returns><see cref="ModifyRecordingPlanResponse"/></returns>
        public ModifyRecordingPlanResponse ModifyRecordingPlanSync(ModifyRecordingPlanRequest req)
        {
            return InternalRequestAsync<ModifyRecordingPlanResponse>(req, "ModifyRecordingPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改场景
        /// </summary>
        /// <param name="req"><see cref="ModifySceneRequest"/></param>
        /// <returns><see cref="ModifySceneResponse"/></returns>
        public Task<ModifySceneResponse> ModifyScene(ModifySceneRequest req)
        {
            return InternalRequestAsync<ModifySceneResponse>(req, "ModifyScene");
        }

        /// <summary>
        /// 修改场景
        /// </summary>
        /// <param name="req"><see cref="ModifySceneRequest"/></param>
        /// <returns><see cref="ModifySceneResponse"/></returns>
        public ModifySceneResponse ModifySceneSync(ModifySceneRequest req)
        {
            return InternalRequestAsync<ModifySceneResponse>(req, "ModifyScene")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionStatusRequest"/></param>
        /// <returns><see cref="ModifySubscriptionStatusResponse"/></returns>
        public Task<ModifySubscriptionStatusResponse> ModifySubscriptionStatus(ModifySubscriptionStatusRequest req)
        {
            return InternalRequestAsync<ModifySubscriptionStatusResponse>(req, "ModifySubscriptionStatus");
        }

        /// <summary>
        /// 编辑设备订阅状态
        /// </summary>
        /// <param name="req"><see cref="ModifySubscriptionStatusRequest"/></param>
        /// <returns><see cref="ModifySubscriptionStatusResponse"/></returns>
        public ModifySubscriptionStatusResponse ModifySubscriptionStatusSync(ModifySubscriptionStatusRequest req)
        {
            return InternalRequestAsync<ModifySubscriptionStatusResponse>(req, "ModifySubscriptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改录像存储列表
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoInfoRequest"/></param>
        /// <returns><see cref="ModifyVideoInfoResponse"/></returns>
        public Task<ModifyVideoInfoResponse> ModifyVideoInfo(ModifyVideoInfoRequest req)
        {
            return InternalRequestAsync<ModifyVideoInfoResponse>(req, "ModifyVideoInfo");
        }

        /// <summary>
        /// 修改录像存储列表
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoInfoRequest"/></param>
        /// <returns><see cref="ModifyVideoInfoResponse"/></returns>
        public ModifyVideoInfoResponse ModifyVideoInfoSync(ModifyVideoInfoRequest req)
        {
            return InternalRequestAsync<ModifyVideoInfoResponse>(req, "ModifyVideoInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置设备告警
        /// </summary>
        /// <param name="req"><see cref="ResetWarningRequest"/></param>
        /// <returns><see cref="ResetWarningResponse"/></returns>
        public Task<ResetWarningResponse> ResetWarning(ResetWarningRequest req)
        {
            return InternalRequestAsync<ResetWarningResponse>(req, "ResetWarning");
        }

        /// <summary>
        /// 重置设备告警
        /// </summary>
        /// <param name="req"><see cref="ResetWarningRequest"/></param>
        /// <returns><see cref="ResetWarningResponse"/></returns>
        public ResetWarningResponse ResetWarningSync(ResetWarningRequest req)
        {
            return InternalRequestAsync<ResetWarningResponse>(req, "ResetWarning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpdateDeviceGroup)用于修改分组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceGroupRequest"/></param>
        /// <returns><see cref="UpdateDeviceGroupResponse"/></returns>
        public Task<UpdateDeviceGroupResponse> UpdateDeviceGroup(UpdateDeviceGroupRequest req)
        {
            return InternalRequestAsync<UpdateDeviceGroupResponse>(req, "UpdateDeviceGroup");
        }

        /// <summary>
        /// 本接口(UpdateDeviceGroup)用于修改分组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceGroupRequest"/></param>
        /// <returns><see cref="UpdateDeviceGroupResponse"/></returns>
        public UpdateDeviceGroupResponse UpdateDeviceGroupSync(UpdateDeviceGroupRequest req)
        {
            return InternalRequestAsync<UpdateDeviceGroupResponse>(req, "UpdateDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpdateDevicePassWord)用于修改设备密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePassWordRequest"/></param>
        /// <returns><see cref="UpdateDevicePassWordResponse"/></returns>
        public Task<UpdateDevicePassWordResponse> UpdateDevicePassWord(UpdateDevicePassWordRequest req)
        {
            return InternalRequestAsync<UpdateDevicePassWordResponse>(req, "UpdateDevicePassWord");
        }

        /// <summary>
        /// 本接口(UpdateDevicePassWord)用于修改设备密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePassWordRequest"/></param>
        /// <returns><see cref="UpdateDevicePassWordResponse"/></returns>
        public UpdateDevicePassWordResponse UpdateDevicePassWordSync(UpdateDevicePassWordRequest req)
        {
            return InternalRequestAsync<UpdateDevicePassWordResponse>(req, "UpdateDevicePassWord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpdateRecordPlan)用于更新录制计划。
        /// 请使用 ModifyRecordingPlan接口和ModifyBindRecordingPlan接口
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public Task<UpdateRecordPlanResponse> UpdateRecordPlan(UpdateRecordPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordPlanResponse>(req, "UpdateRecordPlan");
        }

        /// <summary>
        /// 本接口(UpdateRecordPlan)用于更新录制计划。
        /// 请使用 ModifyRecordingPlan接口和ModifyBindRecordingPlan接口
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public UpdateRecordPlanResponse UpdateRecordPlanSync(UpdateRecordPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordPlanResponse>(req, "UpdateRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(UpdateTimeTemplate)用于更新时间模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateTimeTemplateRequest"/></param>
        /// <returns><see cref="UpdateTimeTemplateResponse"/></returns>
        public Task<UpdateTimeTemplateResponse> UpdateTimeTemplate(UpdateTimeTemplateRequest req)
        {
            return InternalRequestAsync<UpdateTimeTemplateResponse>(req, "UpdateTimeTemplate");
        }

        /// <summary>
        /// 本接口(UpdateTimeTemplate)用于更新时间模板。
        /// </summary>
        /// <param name="req"><see cref="UpdateTimeTemplateRequest"/></param>
        /// <returns><see cref="UpdateTimeTemplateResponse"/></returns>
        public UpdateTimeTemplateResponse UpdateTimeTemplateSync(UpdateTimeTemplateRequest req)
        {
            return InternalRequestAsync<UpdateTimeTemplateResponse>(req, "UpdateTimeTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
