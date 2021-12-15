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
        /// 本接口(ControlDevicePTZ) 用于对支持GB28181 PTZ信令的设备进行远程控制。
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
        /// 对回放流进行控制，包括暂停、播放、拉动、结束等
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
        /// 本接口(CreateRecordPlan) 用于创建录制计划，使设备与时间模板绑定，以便及时启动录制
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
        /// 删除通道接口
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
        /// 删除通道接口
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
        /// 本接口(DeleteRecordPlan)用于删除录制计划
        /// 录制计划删除的同时，会停止该录制计划下的全部录制任务。
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
        /// 本接口(DescribeAllDeviceList) 用于获取设备列表。
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
        /// 获取回放视频流(NVR录制用)
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
        /// 获取回放视频流(NVR录制用)
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
        /// 根据时间获取回放文件列表(云端录制用)
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
        /// 根据时间获取回放文件列表(云端录制用)
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
        /// 本接口(GetRecordDatesByDev)用于查询设备含有录像文件的日期列表。
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
