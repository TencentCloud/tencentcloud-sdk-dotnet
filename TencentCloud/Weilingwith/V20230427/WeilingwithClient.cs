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

namespace TencentCloud.Weilingwith.V20230427
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Weilingwith.V20230427.Models;

   public class WeilingwithClient : AbstractClient{

       private const string endpoint = "weilingwith.tencentcloudapi.com";
       private const string version = "2023-04-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WeilingwithClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WeilingwithClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加告警处理记录
        /// </summary>
        /// <param name="req"><see cref="AddAlarmProcessRecordRequest"/></param>
        /// <returns><see cref="AddAlarmProcessRecordResponse"/></returns>
        public async Task<AddAlarmProcessRecordResponse> AddAlarmProcessRecord(AddAlarmProcessRecordRequest req)
        {
             JsonResponseModel<AddAlarmProcessRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAlarmProcessRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAlarmProcessRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加告警处理记录
        /// </summary>
        /// <param name="req"><see cref="AddAlarmProcessRecordRequest"/></param>
        /// <returns><see cref="AddAlarmProcessRecordResponse"/></returns>
        public AddAlarmProcessRecordResponse AddAlarmProcessRecordSync(AddAlarmProcessRecordRequest req)
        {
             JsonResponseModel<AddAlarmProcessRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAlarmProcessRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAlarmProcessRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单个/批量新增设备
        /// </summary>
        /// <param name="req"><see cref="BatchCreateDeviceRequest"/></param>
        /// <returns><see cref="BatchCreateDeviceResponse"/></returns>
        public async Task<BatchCreateDeviceResponse> BatchCreateDevice(BatchCreateDeviceRequest req)
        {
             JsonResponseModel<BatchCreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchCreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单个/批量新增设备
        /// </summary>
        /// <param name="req"><see cref="BatchCreateDeviceRequest"/></param>
        /// <returns><see cref="BatchCreateDeviceResponse"/></returns>
        public BatchCreateDeviceResponse BatchCreateDeviceSync(BatchCreateDeviceRequest req)
        {
             JsonResponseModel<BatchCreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchCreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量消警
        /// </summary>
        /// <param name="req"><see cref="BatchKillAlarmRequest"/></param>
        /// <returns><see cref="BatchKillAlarmResponse"/></returns>
        public async Task<BatchKillAlarmResponse> BatchKillAlarm(BatchKillAlarmRequest req)
        {
             JsonResponseModel<BatchKillAlarmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchKillAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchKillAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量消警
        /// </summary>
        /// <param name="req"><see cref="BatchKillAlarmRequest"/></param>
        /// <returns><see cref="BatchKillAlarmResponse"/></returns>
        public BatchKillAlarmResponse BatchKillAlarmSync(BatchKillAlarmRequest req)
        {
             JsonResponseModel<BatchKillAlarmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchKillAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchKillAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量消息上报
        /// </summary>
        /// <param name="req"><see cref="BatchReportAppMessageRequest"/></param>
        /// <returns><see cref="BatchReportAppMessageResponse"/></returns>
        public async Task<BatchReportAppMessageResponse> BatchReportAppMessage(BatchReportAppMessageRequest req)
        {
             JsonResponseModel<BatchReportAppMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchReportAppMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchReportAppMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量消息上报
        /// </summary>
        /// <param name="req"><see cref="BatchReportAppMessageRequest"/></param>
        /// <returns><see cref="BatchReportAppMessageResponse"/></returns>
        public BatchReportAppMessageResponse BatchReportAppMessageSync(BatchReportAppMessageRequest req)
        {
             JsonResponseModel<BatchReportAppMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchReportAppMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchReportAppMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变更告警状态
        /// </summary>
        /// <param name="req"><see cref="ChangeAlarmStatusRequest"/></param>
        /// <returns><see cref="ChangeAlarmStatusResponse"/></returns>
        public async Task<ChangeAlarmStatusResponse> ChangeAlarmStatus(ChangeAlarmStatusRequest req)
        {
             JsonResponseModel<ChangeAlarmStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChangeAlarmStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeAlarmStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 变更告警状态
        /// </summary>
        /// <param name="req"><see cref="ChangeAlarmStatusRequest"/></param>
        /// <returns><see cref="ChangeAlarmStatusResponse"/></returns>
        public ChangeAlarmStatusResponse ChangeAlarmStatusSync(ChangeAlarmStatusRequest req)
        {
             JsonResponseModel<ChangeAlarmStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChangeAlarmStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChangeAlarmStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="req"><see cref="ControlCameraPTZRequest"/></param>
        /// <returns><see cref="ControlCameraPTZResponse"/></returns>
        public async Task<ControlCameraPTZResponse> ControlCameraPTZ(ControlCameraPTZRequest req)
        {
             JsonResponseModel<ControlCameraPTZResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlCameraPTZ");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlCameraPTZResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="req"><see cref="ControlCameraPTZRequest"/></param>
        /// <returns><see cref="ControlCameraPTZResponse"/></returns>
        public ControlCameraPTZResponse ControlCameraPTZSync(ControlCameraPTZRequest req)
        {
             JsonResponseModel<ControlCameraPTZResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlCameraPTZ");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlCameraPTZResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备控制（单个、批量控制）
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceRequest"/></param>
        /// <returns><see cref="ControlDeviceResponse"/></returns>
        public async Task<ControlDeviceResponse> ControlDevice(ControlDeviceRequest req)
        {
             JsonResponseModel<ControlDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备控制（单个、批量控制）
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceRequest"/></param>
        /// <returns><see cref="ControlDeviceResponse"/></returns>
        public ControlDeviceResponse ControlDeviceSync(ControlDeviceRequest req)
        {
             JsonResponseModel<ControlDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用方应用，创建调用租户API的授权令牌。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTokenRequest"/></param>
        /// <returns><see cref="CreateApplicationTokenResponse"/></returns>
        public async Task<CreateApplicationTokenResponse> CreateApplicationToken(CreateApplicationTokenRequest req)
        {
             JsonResponseModel<CreateApplicationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用方应用，创建调用租户API的授权令牌。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTokenRequest"/></param>
        /// <returns><see cref="CreateApplicationTokenResponse"/></returns>
        public CreateApplicationTokenResponse CreateApplicationTokenSync(CreateApplicationTokenRequest req)
        {
             JsonResponseModel<CreateApplicationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动作列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeActionListRequest"/></param>
        /// <returns><see cref="DescribeActionListResponse"/></returns>
        public async Task<DescribeActionListResponse> DescribeActionList(DescribeActionListRequest req)
        {
             JsonResponseModel<DescribeActionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeActionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 动作列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeActionListRequest"/></param>
        /// <returns><see cref="DescribeActionListResponse"/></returns>
        public DescribeActionListResponse DescribeActionListSync(DescribeActionListRequest req)
        {
             JsonResponseModel<DescribeActionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeActionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据标签获取行政区划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAdministrationByTagRequest"/></param>
        /// <returns><see cref="DescribeAdministrationByTagResponse"/></returns>
        public async Task<DescribeAdministrationByTagResponse> DescribeAdministrationByTag(DescribeAdministrationByTagRequest req)
        {
             JsonResponseModel<DescribeAdministrationByTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAdministrationByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdministrationByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据标签获取行政区划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAdministrationByTagRequest"/></param>
        /// <returns><see cref="DescribeAdministrationByTagResponse"/></returns>
        public DescribeAdministrationByTagResponse DescribeAdministrationByTagSync(DescribeAdministrationByTagRequest req)
        {
             JsonResponseModel<DescribeAdministrationByTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAdministrationByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdministrationByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警级别枚举获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmLevelListRequest"/></param>
        /// <returns><see cref="DescribeAlarmLevelListResponse"/></returns>
        public async Task<DescribeAlarmLevelListResponse> DescribeAlarmLevelList(DescribeAlarmLevelListRequest req)
        {
             JsonResponseModel<DescribeAlarmLevelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警级别枚举获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmLevelListRequest"/></param>
        /// <returns><see cref="DescribeAlarmLevelListResponse"/></returns>
        public DescribeAlarmLevelListResponse DescribeAlarmLevelListSync(DescribeAlarmLevelListRequest req)
        {
             JsonResponseModel<DescribeAlarmLevelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmListRequest"/></param>
        /// <returns><see cref="DescribeAlarmListResponse"/></returns>
        public async Task<DescribeAlarmListResponse> DescribeAlarmList(DescribeAlarmListRequest req)
        {
             JsonResponseModel<DescribeAlarmListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmListRequest"/></param>
        /// <returns><see cref="DescribeAlarmListResponse"/></returns>
        public DescribeAlarmListResponse DescribeAlarmListSync(DescribeAlarmListRequest req)
        {
             JsonResponseModel<DescribeAlarmListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用来查询系统中的告警状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmStatusListRequest"/></param>
        /// <returns><see cref="DescribeAlarmStatusListResponse"/></returns>
        public async Task<DescribeAlarmStatusListResponse> DescribeAlarmStatusList(DescribeAlarmStatusListRequest req)
        {
             JsonResponseModel<DescribeAlarmStatusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用来查询系统中的告警状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmStatusListRequest"/></param>
        /// <returns><see cref="DescribeAlarmStatusListResponse"/></returns>
        public DescribeAlarmStatusListResponse DescribeAlarmStatusListSync(DescribeAlarmStatusListRequest req)
        {
             JsonResponseModel<DescribeAlarmStatusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警类型获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTypeListRequest"/></param>
        /// <returns><see cref="DescribeAlarmTypeListResponse"/></returns>
        public async Task<DescribeAlarmTypeListResponse> DescribeAlarmTypeList(DescribeAlarmTypeListRequest req)
        {
             JsonResponseModel<DescribeAlarmTypeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警类型获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTypeListRequest"/></param>
        /// <returns><see cref="DescribeAlarmTypeListResponse"/></returns>
        public DescribeAlarmTypeListResponse DescribeAlarmTypeListSync(DescribeAlarmTypeListRequest req)
        {
             JsonResponseModel<DescribeAlarmTypeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定空间关联的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public async Task<DescribeApplicationListResponse> DescribeApplicationList(DescribeApplicationListRequest req)
        {
             JsonResponseModel<DescribeApplicationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定空间关联的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public DescribeApplicationListResponse DescribeApplicationListSync(DescribeApplicationListRequest req)
        {
             JsonResponseModel<DescribeApplicationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询建筑列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingListRequest"/></param>
        /// <returns><see cref="DescribeBuildingListResponse"/></returns>
        public async Task<DescribeBuildingListResponse> DescribeBuildingList(DescribeBuildingListRequest req)
        {
             JsonResponseModel<DescribeBuildingListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBuildingList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBuildingListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询建筑列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingListRequest"/></param>
        /// <returns><see cref="DescribeBuildingListResponse"/></returns>
        public DescribeBuildingListResponse DescribeBuildingListSync(DescribeBuildingListRequest req)
        {
             JsonResponseModel<DescribeBuildingListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBuildingList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBuildingListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询建筑三维模型
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingModelRequest"/></param>
        /// <returns><see cref="DescribeBuildingModelResponse"/></returns>
        public async Task<DescribeBuildingModelResponse> DescribeBuildingModel(DescribeBuildingModelRequest req)
        {
             JsonResponseModel<DescribeBuildingModelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBuildingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBuildingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询建筑三维模型
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingModelRequest"/></param>
        /// <returns><see cref="DescribeBuildingModelResponse"/></returns>
        public DescribeBuildingModelResponse DescribeBuildingModelSync(DescribeBuildingModelRequest req)
        {
             JsonResponseModel<DescribeBuildingModelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBuildingModel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBuildingModelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询建筑信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingProfileRequest"/></param>
        /// <returns><see cref="DescribeBuildingProfileResponse"/></returns>
        public async Task<DescribeBuildingProfileResponse> DescribeBuildingProfile(DescribeBuildingProfileRequest req)
        {
             JsonResponseModel<DescribeBuildingProfileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBuildingProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBuildingProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询建筑信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingProfileRequest"/></param>
        /// <returns><see cref="DescribeBuildingProfileResponse"/></returns>
        public DescribeBuildingProfileResponse DescribeBuildingProfileSync(DescribeBuildingProfileRequest req)
        {
             JsonResponseModel<DescribeBuildingProfileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBuildingProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBuildingProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取视频扩展信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCameraExtendInfoRequest"/></param>
        /// <returns><see cref="DescribeCameraExtendInfoResponse"/></returns>
        public async Task<DescribeCameraExtendInfoResponse> DescribeCameraExtendInfo(DescribeCameraExtendInfoRequest req)
        {
             JsonResponseModel<DescribeCameraExtendInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCameraExtendInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCameraExtendInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取视频扩展信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCameraExtendInfoRequest"/></param>
        /// <returns><see cref="DescribeCameraExtendInfoResponse"/></returns>
        public DescribeCameraExtendInfoResponse DescribeCameraExtendInfoSync(DescribeCameraExtendInfoRequest req)
        {
             JsonResponseModel<DescribeCameraExtendInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCameraExtendInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCameraExtendInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过城市id查询工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCityWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeCityWorkspaceListResponse"/></returns>
        public async Task<DescribeCityWorkspaceListResponse> DescribeCityWorkspaceList(DescribeCityWorkspaceListRequest req)
        {
             JsonResponseModel<DescribeCityWorkspaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCityWorkspaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCityWorkspaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过城市id查询工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCityWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeCityWorkspaceListResponse"/></returns>
        public DescribeCityWorkspaceListResponse DescribeCityWorkspaceListSync(DescribeCityWorkspaceListRequest req)
        {
             JsonResponseModel<DescribeCityWorkspaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCityWorkspaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCityWorkspaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备列表查询/单个查询（支持通过筛选条件查询，设备类型、标签、PID、空间）
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
        /// 设备列表查询/单个查询（支持通过筛选条件查询，设备类型、标签、PID、空间）
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
        /// 获取设备影子数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowListRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowListResponse"/></returns>
        public async Task<DescribeDeviceShadowListResponse> DescribeDeviceShadowList(DescribeDeviceShadowListRequest req)
        {
             JsonResponseModel<DescribeDeviceShadowListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceShadowList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceShadowListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备影子数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowListRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowListResponse"/></returns>
        public DescribeDeviceShadowListResponse DescribeDeviceShadowListSync(DescribeDeviceShadowListRequest req)
        {
             JsonResponseModel<DescribeDeviceShadowListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceShadowList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceShadowListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusListRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusListResponse"/></returns>
        public async Task<DescribeDeviceStatusListResponse> DescribeDeviceStatusList(DescribeDeviceStatusListRequest req)
        {
             JsonResponseModel<DescribeDeviceStatusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusListRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusListResponse"/></returns>
        public DescribeDeviceStatusListResponse DescribeDeviceStatusListSync(DescribeDeviceStatusListRequest req)
        {
             JsonResponseModel<DescribeDeviceStatusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备状态统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusStatRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusStatResponse"/></returns>
        public async Task<DescribeDeviceStatusStatResponse> DescribeDeviceStatusStat(DescribeDeviceStatusStatRequest req)
        {
             JsonResponseModel<DescribeDeviceStatusStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceStatusStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceStatusStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设备状态统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusStatRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusStatResponse"/></returns>
        public DescribeDeviceStatusStatResponse DescribeDeviceStatusStatSync(DescribeDeviceStatusStatRequest req)
        {
             JsonResponseModel<DescribeDeviceStatusStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceStatusStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceStatusStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 标签列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTagListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTagListResponse"/></returns>
        public async Task<DescribeDeviceTagListResponse> DescribeDeviceTagList(DescribeDeviceTagListRequest req)
        {
             JsonResponseModel<DescribeDeviceTagListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceTagList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceTagListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 标签列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTagListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTagListResponse"/></returns>
        public DescribeDeviceTagListResponse DescribeDeviceTagListSync(DescribeDeviceTagListRequest req)
        {
             JsonResponseModel<DescribeDeviceTagListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceTagList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceTagListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取设备的设备类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTypeListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTypeListResponse"/></returns>
        public async Task<DescribeDeviceTypeListResponse> DescribeDeviceTypeList(DescribeDeviceTypeListRequest req)
        {
             JsonResponseModel<DescribeDeviceTypeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取设备的设备类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTypeListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTypeListResponse"/></returns>
        public DescribeDeviceTypeListResponse DescribeDeviceTypeListSync(DescribeDeviceTypeListRequest req)
        {
             JsonResponseModel<DescribeDeviceTypeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘应用凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeApplicationTokenRequest"/></param>
        /// <returns><see cref="DescribeEdgeApplicationTokenResponse"/></returns>
        public async Task<DescribeEdgeApplicationTokenResponse> DescribeEdgeApplicationToken(DescribeEdgeApplicationTokenRequest req)
        {
             JsonResponseModel<DescribeEdgeApplicationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeApplicationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeApplicationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘应用凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeApplicationTokenRequest"/></param>
        /// <returns><see cref="DescribeEdgeApplicationTokenResponse"/></returns>
        public DescribeEdgeApplicationTokenResponse DescribeEdgeApplicationTokenSync(DescribeEdgeApplicationTokenRequest req)
        {
             JsonResponseModel<DescribeEdgeApplicationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeApplicationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeApplicationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分页构件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfilePageRequest"/></param>
        /// <returns><see cref="DescribeElementProfilePageResponse"/></returns>
        public async Task<DescribeElementProfilePageResponse> DescribeElementProfilePage(DescribeElementProfilePageRequest req)
        {
             JsonResponseModel<DescribeElementProfilePageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeElementProfilePage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeElementProfilePageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分页构件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfilePageRequest"/></param>
        /// <returns><see cref="DescribeElementProfilePageResponse"/></returns>
        public DescribeElementProfilePageResponse DescribeElementProfilePageSync(DescribeElementProfilePageRequest req)
        {
             JsonResponseModel<DescribeElementProfilePageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeElementProfilePage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeElementProfilePageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询构件树
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfileTreeRequest"/></param>
        /// <returns><see cref="DescribeElementProfileTreeResponse"/></returns>
        public async Task<DescribeElementProfileTreeResponse> DescribeElementProfileTree(DescribeElementProfileTreeRequest req)
        {
             JsonResponseModel<DescribeElementProfileTreeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeElementProfileTree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeElementProfileTreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询构件树
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfileTreeRequest"/></param>
        /// <returns><see cref="DescribeElementProfileTreeResponse"/></returns>
        public DescribeElementProfileTreeResponse DescribeElementProfileTreeSync(DescribeElementProfileTreeRequest req)
        {
             JsonResponseModel<DescribeElementProfileTreeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeElementProfileTree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeElementProfileTreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 事件列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListRequest"/></param>
        /// <returns><see cref="DescribeEventListResponse"/></returns>
        public async Task<DescribeEventListResponse> DescribeEventList(DescribeEventListRequest req)
        {
             JsonResponseModel<DescribeEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 事件列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListRequest"/></param>
        /// <returns><see cref="DescribeEventListResponse"/></returns>
        public DescribeEventListResponse DescribeEventListSync(DescribeEventListRequest req)
        {
             JsonResponseModel<DescribeEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取文件下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadURLResponse"/></returns>
        public async Task<DescribeFileDownloadURLResponse> DescribeFileDownloadURL(DescribeFileDownloadURLRequest req)
        {
             JsonResponseModel<DescribeFileDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取文件下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadURLResponse"/></returns>
        public DescribeFileDownloadURLResponse DescribeFileDownloadURLSync(DescribeFileDownloadURLRequest req)
        {
             JsonResponseModel<DescribeFileDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUploadURLRequest"/></param>
        /// <returns><see cref="DescribeFileUploadURLResponse"/></returns>
        public async Task<DescribeFileUploadURLResponse> DescribeFileUploadURL(DescribeFileUploadURLRequest req)
        {
             JsonResponseModel<DescribeFileUploadURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileUploadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileUploadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUploadURLRequest"/></param>
        /// <returns><see cref="DescribeFileUploadURLResponse"/></returns>
        public DescribeFileUploadURLResponse DescribeFileUploadURLSync(DescribeFileUploadURLRequest req)
        {
             JsonResponseModel<DescribeFileUploadURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileUploadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileUploadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInterfaceListRequest"/></param>
        /// <returns><see cref="DescribeInterfaceListResponse"/></returns>
        public async Task<DescribeInterfaceListResponse> DescribeInterfaceList(DescribeInterfaceListRequest req)
        {
             JsonResponseModel<DescribeInterfaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInterfaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInterfaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInterfaceListRequest"/></param>
        /// <returns><see cref="DescribeInterfaceListResponse"/></returns>
        public DescribeInterfaceListResponse DescribeInterfaceListSync(DescribeInterfaceListRequest req)
        {
             JsonResponseModel<DescribeInterfaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInterfaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInterfaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 联动规则列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRuleListRequest"/></param>
        /// <returns><see cref="DescribeLinkRuleListResponse"/></returns>
        public async Task<DescribeLinkRuleListResponse> DescribeLinkRuleList(DescribeLinkRuleListRequest req)
        {
             JsonResponseModel<DescribeLinkRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLinkRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLinkRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 联动规则列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRuleListRequest"/></param>
        /// <returns><see cref="DescribeLinkRuleListResponse"/></returns>
        public DescribeLinkRuleListResponse DescribeLinkRuleListSync(DescribeLinkRuleListRequest req)
        {
             JsonResponseModel<DescribeLinkRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLinkRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLinkRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型列表查询/单个查询（产品模型/标准模型）
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public async Task<DescribeModelListResponse> DescribeModelList(DescribeModelListRequest req)
        {
             JsonResponseModel<DescribeModelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 模型列表查询/单个查询（产品模型/标准模型）
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public DescribeModelListResponse DescribeModelListSync(DescribeModelListRequest req)
        {
             JsonResponseModel<DescribeModelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public async Task<DescribeProductListResponse> DescribeProductList(DescribeProductListRequest req)
        {
             JsonResponseModel<DescribeProductListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public DescribeProductListResponse DescribeProductListSync(DescribeProductListRequest req)
        {
             JsonResponseModel<DescribeProductListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询构件属性（详情）
        /// </summary>
        /// <param name="req"><see cref="DescribePropertyListRequest"/></param>
        /// <returns><see cref="DescribePropertyListResponse"/></returns>
        public async Task<DescribePropertyListResponse> DescribePropertyList(DescribePropertyListRequest req)
        {
             JsonResponseModel<DescribePropertyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePropertyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePropertyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询构件属性（详情）
        /// </summary>
        /// <param name="req"><see cref="DescribePropertyListRequest"/></param>
        /// <returns><see cref="DescribePropertyListResponse"/></returns>
        public DescribePropertyListResponse DescribePropertyListSync(DescribePropertyListRequest req)
        {
             JsonResponseModel<DescribePropertyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePropertyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePropertyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 联动规则详情查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public async Task<DescribeRuleDetailResponse> DescribeRuleDetail(DescribeRuleDetailRequest req)
        {
             JsonResponseModel<DescribeRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 联动规则详情查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public DescribeRuleDetailResponse DescribeRuleDetailSync(DescribeRuleDetailRequest req)
        {
             JsonResponseModel<DescribeRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneListRequest"/></param>
        /// <returns><see cref="DescribeSceneListResponse"/></returns>
        public async Task<DescribeSceneListResponse> DescribeSceneList(DescribeSceneListRequest req)
        {
             JsonResponseModel<DescribeSceneListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSceneList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSceneListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneListRequest"/></param>
        /// <returns><see cref="DescribeSceneListResponse"/></returns>
        public DescribeSceneListResponse DescribeSceneListSync(DescribeSceneListRequest req)
        {
             JsonResponseModel<DescribeSceneListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSceneList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSceneListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定空间设备编号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceIdListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceIdListResponse"/></returns>
        public async Task<DescribeSpaceDeviceIdListResponse> DescribeSpaceDeviceIdList(DescribeSpaceDeviceIdListRequest req)
        {
             JsonResponseModel<DescribeSpaceDeviceIdListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpaceDeviceIdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceDeviceIdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定空间设备编号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceIdListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceIdListResponse"/></returns>
        public DescribeSpaceDeviceIdListResponse DescribeSpaceDeviceIdListSync(DescribeSpaceDeviceIdListRequest req)
        {
             JsonResponseModel<DescribeSpaceDeviceIdListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpaceDeviceIdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceDeviceIdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定空间下设备与构件绑定关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceRelationListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceRelationListResponse"/></returns>
        public async Task<DescribeSpaceDeviceRelationListResponse> DescribeSpaceDeviceRelationList(DescribeSpaceDeviceRelationListRequest req)
        {
             JsonResponseModel<DescribeSpaceDeviceRelationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpaceDeviceRelationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceDeviceRelationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定空间下设备与构件绑定关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceRelationListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceRelationListResponse"/></returns>
        public DescribeSpaceDeviceRelationListResponse DescribeSpaceDeviceRelationListSync(DescribeSpaceDeviceRelationListRequest req)
        {
             JsonResponseModel<DescribeSpaceDeviceRelationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpaceDeviceRelationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceDeviceRelationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备绑定的空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceInfoByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceInfoByDeviceIdResponse"/></returns>
        public async Task<DescribeSpaceInfoByDeviceIdResponse> DescribeSpaceInfoByDeviceId(DescribeSpaceInfoByDeviceIdRequest req)
        {
             JsonResponseModel<DescribeSpaceInfoByDeviceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpaceInfoByDeviceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceInfoByDeviceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备绑定的空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceInfoByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceInfoByDeviceIdResponse"/></returns>
        public DescribeSpaceInfoByDeviceIdResponse DescribeSpaceInfoByDeviceIdSync(DescribeSpaceInfoByDeviceIdRequest req)
        {
             JsonResponseModel<DescribeSpaceInfoByDeviceIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpaceInfoByDeviceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceInfoByDeviceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备绑定的空间层级关系
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceRelationByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceRelationByDeviceIdResponse"/></returns>
        public async Task<DescribeSpaceRelationByDeviceIdResponse> DescribeSpaceRelationByDeviceId(DescribeSpaceRelationByDeviceIdRequest req)
        {
             JsonResponseModel<DescribeSpaceRelationByDeviceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpaceRelationByDeviceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceRelationByDeviceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备绑定的空间层级关系
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceRelationByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceRelationByDeviceIdResponse"/></returns>
        public DescribeSpaceRelationByDeviceIdResponse DescribeSpaceRelationByDeviceIdSync(DescribeSpaceRelationByDeviceIdRequest req)
        {
             JsonResponseModel<DescribeSpaceRelationByDeviceIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpaceRelationByDeviceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceRelationByDeviceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询空间分类
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceTypeListRequest"/></param>
        /// <returns><see cref="DescribeSpaceTypeListResponse"/></returns>
        public async Task<DescribeSpaceTypeListResponse> DescribeSpaceTypeList(DescribeSpaceTypeListRequest req)
        {
             JsonResponseModel<DescribeSpaceTypeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpaceTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询空间分类
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceTypeListRequest"/></param>
        /// <returns><see cref="DescribeSpaceTypeListResponse"/></returns>
        public DescribeSpaceTypeListResponse DescribeSpaceTypeListSync(DescribeSpaceTypeListRequest req)
        {
             JsonResponseModel<DescribeSpaceTypeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpaceTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询租户楼栋数量和楼栋建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeTenantBuildingCountAndAreaResponse"/></returns>
        public async Task<DescribeTenantBuildingCountAndAreaResponse> DescribeTenantBuildingCountAndArea(DescribeTenantBuildingCountAndAreaRequest req)
        {
             JsonResponseModel<DescribeTenantBuildingCountAndAreaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTenantBuildingCountAndArea");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantBuildingCountAndAreaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询租户楼栋数量和楼栋建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeTenantBuildingCountAndAreaResponse"/></returns>
        public DescribeTenantBuildingCountAndAreaResponse DescribeTenantBuildingCountAndAreaSync(DescribeTenantBuildingCountAndAreaRequest req)
        {
             JsonResponseModel<DescribeTenantBuildingCountAndAreaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTenantBuildingCountAndArea");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantBuildingCountAndAreaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询租户组织部门列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantDepartmentListRequest"/></param>
        /// <returns><see cref="DescribeTenantDepartmentListResponse"/></returns>
        public async Task<DescribeTenantDepartmentListResponse> DescribeTenantDepartmentList(DescribeTenantDepartmentListRequest req)
        {
             JsonResponseModel<DescribeTenantDepartmentListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTenantDepartmentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantDepartmentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询租户组织部门列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantDepartmentListRequest"/></param>
        /// <returns><see cref="DescribeTenantDepartmentListResponse"/></returns>
        public DescribeTenantDepartmentListResponse DescribeTenantDepartmentListSync(DescribeTenantDepartmentListRequest req)
        {
             JsonResponseModel<DescribeTenantDepartmentListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTenantDepartmentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantDepartmentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询租户人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantUserListRequest"/></param>
        /// <returns><see cref="DescribeTenantUserListResponse"/></returns>
        public async Task<DescribeTenantUserListResponse> DescribeTenantUserList(DescribeTenantUserListRequest req)
        {
             JsonResponseModel<DescribeTenantUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTenantUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询租户人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantUserListRequest"/></param>
        /// <returns><see cref="DescribeTenantUserListResponse"/></returns>
        public DescribeTenantUserListResponse DescribeTenantUserListSync(DescribeTenantUserListRequest req)
        {
             JsonResponseModel<DescribeTenantUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTenantUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTenantUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云录像接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoCloudRecordRequest"/></param>
        /// <returns><see cref="DescribeVideoCloudRecordResponse"/></returns>
        public async Task<DescribeVideoCloudRecordResponse> DescribeVideoCloudRecord(DescribeVideoCloudRecordRequest req)
        {
             JsonResponseModel<DescribeVideoCloudRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoCloudRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoCloudRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云录像接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoCloudRecordRequest"/></param>
        /// <returns><see cref="DescribeVideoCloudRecordResponse"/></returns>
        public DescribeVideoCloudRecordResponse DescribeVideoCloudRecordSync(DescribeVideoCloudRecordRequest req)
        {
             JsonResponseModel<DescribeVideoCloudRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoCloudRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoCloudRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoLiveStreamResponse"/></returns>
        public async Task<DescribeVideoLiveStreamResponse> DescribeVideoLiveStream(DescribeVideoLiveStreamRequest req)
        {
             JsonResponseModel<DescribeVideoLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实时流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoLiveStreamResponse"/></returns>
        public DescribeVideoLiveStreamResponse DescribeVideoLiveStreamSync(DescribeVideoLiveStreamRequest req)
        {
             JsonResponseModel<DescribeVideoLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 历史流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoRecordStreamResponse"/></returns>
        public async Task<DescribeVideoRecordStreamResponse> DescribeVideoRecordStream(DescribeVideoRecordStreamRequest req)
        {
             JsonResponseModel<DescribeVideoRecordStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoRecordStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoRecordStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 历史流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoRecordStreamResponse"/></returns>
        public DescribeVideoRecordStreamResponse DescribeVideoRecordStreamSync(DescribeVideoRecordStreamRequest req)
        {
             JsonResponseModel<DescribeVideoRecordStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoRecordStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoRecordStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目空间楼栋数量与建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkSpaceBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeWorkSpaceBuildingCountAndAreaResponse"/></returns>
        public async Task<DescribeWorkSpaceBuildingCountAndAreaResponse> DescribeWorkSpaceBuildingCountAndArea(DescribeWorkSpaceBuildingCountAndAreaRequest req)
        {
             JsonResponseModel<DescribeWorkSpaceBuildingCountAndAreaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkSpaceBuildingCountAndArea");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkSpaceBuildingCountAndAreaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目空间楼栋数量与建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkSpaceBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeWorkSpaceBuildingCountAndAreaResponse"/></returns>
        public DescribeWorkSpaceBuildingCountAndAreaResponse DescribeWorkSpaceBuildingCountAndAreaSync(DescribeWorkSpaceBuildingCountAndAreaRequest req)
        {
             JsonResponseModel<DescribeWorkSpaceBuildingCountAndAreaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkSpaceBuildingCountAndArea");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkSpaceBuildingCountAndAreaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户下的空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceListResponse"/></returns>
        public async Task<DescribeWorkspaceListResponse> DescribeWorkspaceList(DescribeWorkspaceListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户下的空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceListResponse"/></returns>
        public DescribeWorkspaceListResponse DescribeWorkspaceListSync(DescribeWorkspaceListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目空间人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceUserListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceUserListResponse"/></returns>
        public async Task<DescribeWorkspaceUserListResponse> DescribeWorkspaceUserList(DescribeWorkspaceUserListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目空间人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceUserListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceUserListResponse"/></returns>
        public DescribeWorkspaceUserListResponse DescribeWorkspaceUserListSync(DescribeWorkspaceUserListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改设备名字
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceNameRequest"/></param>
        /// <returns><see cref="ModifyDeviceNameResponse"/></returns>
        public async Task<ModifyDeviceNameResponse> ModifyDeviceName(ModifyDeviceNameRequest req)
        {
             JsonResponseModel<ModifyDeviceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改设备名字
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceNameRequest"/></param>
        /// <returns><see cref="ModifyDeviceNameResponse"/></returns>
        public ModifyDeviceNameResponse ModifyDeviceNameSync(ModifyDeviceNameRequest req)
        {
             JsonResponseModel<ModifyDeviceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDeviceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单条消息上报
        /// </summary>
        /// <param name="req"><see cref="ReportAppMessageRequest"/></param>
        /// <returns><see cref="ReportAppMessageResponse"/></returns>
        public async Task<ReportAppMessageResponse> ReportAppMessage(ReportAppMessageRequest req)
        {
             JsonResponseModel<ReportAppMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportAppMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportAppMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单条消息上报
        /// </summary>
        /// <param name="req"><see cref="ReportAppMessageRequest"/></param>
        /// <returns><see cref="ReportAppMessageResponse"/></returns>
        public ReportAppMessageResponse ReportAppMessageSync(ReportAppMessageRequest req)
        {
             JsonResponseModel<ReportAppMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportAppMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportAppMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 断流接口
        /// </summary>
        /// <param name="req"><see cref="StopVideoStreamingRequest"/></param>
        /// <returns><see cref="StopVideoStreamingResponse"/></returns>
        public async Task<StopVideoStreamingResponse> StopVideoStreaming(StopVideoStreamingRequest req)
        {
             JsonResponseModel<StopVideoStreamingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopVideoStreaming");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopVideoStreamingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 断流接口
        /// </summary>
        /// <param name="req"><see cref="StopVideoStreamingRequest"/></param>
        /// <returns><see cref="StopVideoStreamingResponse"/></returns>
        public StopVideoStreamingResponse StopVideoStreamingSync(StopVideoStreamingRequest req)
        {
             JsonResponseModel<StopVideoStreamingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopVideoStreaming");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopVideoStreamingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作空间园区属性
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceParkAttributesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceParkAttributesResponse"/></returns>
        public async Task<UpdateWorkspaceParkAttributesResponse> UpdateWorkspaceParkAttributes(UpdateWorkspaceParkAttributesRequest req)
        {
             JsonResponseModel<UpdateWorkspaceParkAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateWorkspaceParkAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateWorkspaceParkAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作空间园区属性
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceParkAttributesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceParkAttributesResponse"/></returns>
        public UpdateWorkspaceParkAttributesResponse UpdateWorkspaceParkAttributesSync(UpdateWorkspaceParkAttributesRequest req)
        {
             JsonResponseModel<UpdateWorkspaceParkAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateWorkspaceParkAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateWorkspaceParkAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
