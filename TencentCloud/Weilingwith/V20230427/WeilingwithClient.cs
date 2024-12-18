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
       private const string sdkVersion = "SDK_NET_3.0.1144";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WeilingwithClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加告警处理记录
        /// </summary>
        /// <param name="req"><see cref="AddAlarmProcessRecordRequest"/></param>
        /// <returns><see cref="AddAlarmProcessRecordResponse"/></returns>
        public Task<AddAlarmProcessRecordResponse> AddAlarmProcessRecord(AddAlarmProcessRecordRequest req)
        {
            return InternalRequestAsync<AddAlarmProcessRecordResponse>(req, "AddAlarmProcessRecord");
        }

        /// <summary>
        /// 添加告警处理记录
        /// </summary>
        /// <param name="req"><see cref="AddAlarmProcessRecordRequest"/></param>
        /// <returns><see cref="AddAlarmProcessRecordResponse"/></returns>
        public AddAlarmProcessRecordResponse AddAlarmProcessRecordSync(AddAlarmProcessRecordRequest req)
        {
            return InternalRequestAsync<AddAlarmProcessRecordResponse>(req, "AddAlarmProcessRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 单个/批量新增设备
        /// </summary>
        /// <param name="req"><see cref="BatchCreateDeviceRequest"/></param>
        /// <returns><see cref="BatchCreateDeviceResponse"/></returns>
        public Task<BatchCreateDeviceResponse> BatchCreateDevice(BatchCreateDeviceRequest req)
        {
            return InternalRequestAsync<BatchCreateDeviceResponse>(req, "BatchCreateDevice");
        }

        /// <summary>
        /// 单个/批量新增设备
        /// </summary>
        /// <param name="req"><see cref="BatchCreateDeviceRequest"/></param>
        /// <returns><see cref="BatchCreateDeviceResponse"/></returns>
        public BatchCreateDeviceResponse BatchCreateDeviceSync(BatchCreateDeviceRequest req)
        {
            return InternalRequestAsync<BatchCreateDeviceResponse>(req, "BatchCreateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDeviceRequest"/></param>
        /// <returns><see cref="BatchDeleteDeviceResponse"/></returns>
        public Task<BatchDeleteDeviceResponse> BatchDeleteDevice(BatchDeleteDeviceRequest req)
        {
            return InternalRequestAsync<BatchDeleteDeviceResponse>(req, "BatchDeleteDevice");
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDeviceRequest"/></param>
        /// <returns><see cref="BatchDeleteDeviceResponse"/></returns>
        public BatchDeleteDeviceResponse BatchDeleteDeviceSync(BatchDeleteDeviceRequest req)
        {
            return InternalRequestAsync<BatchDeleteDeviceResponse>(req, "BatchDeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量消警
        /// </summary>
        /// <param name="req"><see cref="BatchKillAlarmRequest"/></param>
        /// <returns><see cref="BatchKillAlarmResponse"/></returns>
        public Task<BatchKillAlarmResponse> BatchKillAlarm(BatchKillAlarmRequest req)
        {
            return InternalRequestAsync<BatchKillAlarmResponse>(req, "BatchKillAlarm");
        }

        /// <summary>
        /// 批量消警
        /// </summary>
        /// <param name="req"><see cref="BatchKillAlarmRequest"/></param>
        /// <returns><see cref="BatchKillAlarmResponse"/></returns>
        public BatchKillAlarmResponse BatchKillAlarmSync(BatchKillAlarmRequest req)
        {
            return InternalRequestAsync<BatchKillAlarmResponse>(req, "BatchKillAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量上报应用消息
        /// </summary>
        /// <param name="req"><see cref="BatchReportAppMessageRequest"/></param>
        /// <returns><see cref="BatchReportAppMessageResponse"/></returns>
        public Task<BatchReportAppMessageResponse> BatchReportAppMessage(BatchReportAppMessageRequest req)
        {
            return InternalRequestAsync<BatchReportAppMessageResponse>(req, "BatchReportAppMessage");
        }

        /// <summary>
        /// 批量上报应用消息
        /// </summary>
        /// <param name="req"><see cref="BatchReportAppMessageRequest"/></param>
        /// <returns><see cref="BatchReportAppMessageResponse"/></returns>
        public BatchReportAppMessageResponse BatchReportAppMessageSync(BatchReportAppMessageRequest req)
        {
            return InternalRequestAsync<BatchReportAppMessageResponse>(req, "BatchReportAppMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 变更告警状态
        /// </summary>
        /// <param name="req"><see cref="ChangeAlarmStatusRequest"/></param>
        /// <returns><see cref="ChangeAlarmStatusResponse"/></returns>
        public Task<ChangeAlarmStatusResponse> ChangeAlarmStatus(ChangeAlarmStatusRequest req)
        {
            return InternalRequestAsync<ChangeAlarmStatusResponse>(req, "ChangeAlarmStatus");
        }

        /// <summary>
        /// 变更告警状态
        /// </summary>
        /// <param name="req"><see cref="ChangeAlarmStatusRequest"/></param>
        /// <returns><see cref="ChangeAlarmStatusResponse"/></returns>
        public ChangeAlarmStatusResponse ChangeAlarmStatusSync(ChangeAlarmStatusRequest req)
        {
            return InternalRequestAsync<ChangeAlarmStatusResponse>(req, "ChangeAlarmStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="req"><see cref="ControlCameraPTZRequest"/></param>
        /// <returns><see cref="ControlCameraPTZResponse"/></returns>
        public Task<ControlCameraPTZResponse> ControlCameraPTZ(ControlCameraPTZRequest req)
        {
            return InternalRequestAsync<ControlCameraPTZResponse>(req, "ControlCameraPTZ");
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="req"><see cref="ControlCameraPTZRequest"/></param>
        /// <returns><see cref="ControlCameraPTZResponse"/></returns>
        public ControlCameraPTZResponse ControlCameraPTZSync(ControlCameraPTZRequest req)
        {
            return InternalRequestAsync<ControlCameraPTZResponse>(req, "ControlCameraPTZ")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备控制（单个、批量控制）
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceRequest"/></param>
        /// <returns><see cref="ControlDeviceResponse"/></returns>
        public Task<ControlDeviceResponse> ControlDevice(ControlDeviceRequest req)
        {
            return InternalRequestAsync<ControlDeviceResponse>(req, "ControlDevice");
        }

        /// <summary>
        /// 设备控制（单个、批量控制）
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceRequest"/></param>
        /// <returns><see cref="ControlDeviceResponse"/></returns>
        public ControlDeviceResponse ControlDeviceSync(ControlDeviceRequest req)
        {
            return InternalRequestAsync<ControlDeviceResponse>(req, "ControlDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用方应用，创建调用租户API的授权令牌。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTokenRequest"/></param>
        /// <returns><see cref="CreateApplicationTokenResponse"/></returns>
        public Task<CreateApplicationTokenResponse> CreateApplicationToken(CreateApplicationTokenRequest req)
        {
            return InternalRequestAsync<CreateApplicationTokenResponse>(req, "CreateApplicationToken");
        }

        /// <summary>
        /// 调用方应用，创建调用租户API的授权令牌。
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationTokenRequest"/></param>
        /// <returns><see cref="CreateApplicationTokenResponse"/></returns>
        public CreateApplicationTokenResponse CreateApplicationTokenSync(CreateApplicationTokenRequest req)
        {
            return InternalRequestAsync<CreateApplicationTokenResponse>(req, "CreateApplicationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除设备分组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupResponse"/></returns>
        public Task<DeleteDeviceGroupResponse> DeleteDeviceGroup(DeleteDeviceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupResponse>(req, "DeleteDeviceGroup");
        }

        /// <summary>
        /// 删除设备分组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupResponse"/></returns>
        public DeleteDeviceGroupResponse DeleteDeviceGroupSync(DeleteDeviceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupResponse>(req, "DeleteDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 动作列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeActionListRequest"/></param>
        /// <returns><see cref="DescribeActionListResponse"/></returns>
        public Task<DescribeActionListResponse> DescribeActionList(DescribeActionListRequest req)
        {
            return InternalRequestAsync<DescribeActionListResponse>(req, "DescribeActionList");
        }

        /// <summary>
        /// 动作列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeActionListRequest"/></param>
        /// <returns><see cref="DescribeActionListResponse"/></returns>
        public DescribeActionListResponse DescribeActionListSync(DescribeActionListRequest req)
        {
            return InternalRequestAsync<DescribeActionListResponse>(req, "DescribeActionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据标签获取行政区划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAdministrationByTagRequest"/></param>
        /// <returns><see cref="DescribeAdministrationByTagResponse"/></returns>
        public Task<DescribeAdministrationByTagResponse> DescribeAdministrationByTag(DescribeAdministrationByTagRequest req)
        {
            return InternalRequestAsync<DescribeAdministrationByTagResponse>(req, "DescribeAdministrationByTag");
        }

        /// <summary>
        /// 根据标签获取行政区划列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAdministrationByTagRequest"/></param>
        /// <returns><see cref="DescribeAdministrationByTagResponse"/></returns>
        public DescribeAdministrationByTagResponse DescribeAdministrationByTagSync(DescribeAdministrationByTagRequest req)
        {
            return InternalRequestAsync<DescribeAdministrationByTagResponse>(req, "DescribeAdministrationByTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警级别枚举获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmLevelListRequest"/></param>
        /// <returns><see cref="DescribeAlarmLevelListResponse"/></returns>
        public Task<DescribeAlarmLevelListResponse> DescribeAlarmLevelList(DescribeAlarmLevelListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmLevelListResponse>(req, "DescribeAlarmLevelList");
        }

        /// <summary>
        /// 告警级别枚举获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmLevelListRequest"/></param>
        /// <returns><see cref="DescribeAlarmLevelListResponse"/></returns>
        public DescribeAlarmLevelListResponse DescribeAlarmLevelListSync(DescribeAlarmLevelListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmLevelListResponse>(req, "DescribeAlarmLevelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmListRequest"/></param>
        /// <returns><see cref="DescribeAlarmListResponse"/></returns>
        public Task<DescribeAlarmListResponse> DescribeAlarmList(DescribeAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmListResponse>(req, "DescribeAlarmList");
        }

        /// <summary>
        /// 告警列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmListRequest"/></param>
        /// <returns><see cref="DescribeAlarmListResponse"/></returns>
        public DescribeAlarmListResponse DescribeAlarmListSync(DescribeAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmListResponse>(req, "DescribeAlarmList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用来查询系统中的告警状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmStatusListRequest"/></param>
        /// <returns><see cref="DescribeAlarmStatusListResponse"/></returns>
        public Task<DescribeAlarmStatusListResponse> DescribeAlarmStatusList(DescribeAlarmStatusListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmStatusListResponse>(req, "DescribeAlarmStatusList");
        }

        /// <summary>
        /// 用来查询系统中的告警状态列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmStatusListRequest"/></param>
        /// <returns><see cref="DescribeAlarmStatusListResponse"/></returns>
        public DescribeAlarmStatusListResponse DescribeAlarmStatusListSync(DescribeAlarmStatusListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmStatusListResponse>(req, "DescribeAlarmStatusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警类型获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTypeListRequest"/></param>
        /// <returns><see cref="DescribeAlarmTypeListResponse"/></returns>
        public Task<DescribeAlarmTypeListResponse> DescribeAlarmTypeList(DescribeAlarmTypeListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmTypeListResponse>(req, "DescribeAlarmTypeList");
        }

        /// <summary>
        /// 告警类型获取
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTypeListRequest"/></param>
        /// <returns><see cref="DescribeAlarmTypeListResponse"/></returns>
        public DescribeAlarmTypeListResponse DescribeAlarmTypeListSync(DescribeAlarmTypeListRequest req)
        {
            return InternalRequestAsync<DescribeAlarmTypeListResponse>(req, "DescribeAlarmTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定空间关联的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public Task<DescribeApplicationListResponse> DescribeApplicationList(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList");
        }

        /// <summary>
        /// 查询指定空间关联的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public DescribeApplicationListResponse DescribeApplicationListSync(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询建筑列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingListRequest"/></param>
        /// <returns><see cref="DescribeBuildingListResponse"/></returns>
        public Task<DescribeBuildingListResponse> DescribeBuildingList(DescribeBuildingListRequest req)
        {
            return InternalRequestAsync<DescribeBuildingListResponse>(req, "DescribeBuildingList");
        }

        /// <summary>
        /// 查询建筑列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingListRequest"/></param>
        /// <returns><see cref="DescribeBuildingListResponse"/></returns>
        public DescribeBuildingListResponse DescribeBuildingListSync(DescribeBuildingListRequest req)
        {
            return InternalRequestAsync<DescribeBuildingListResponse>(req, "DescribeBuildingList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询建筑三维模型
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingModelRequest"/></param>
        /// <returns><see cref="DescribeBuildingModelResponse"/></returns>
        public Task<DescribeBuildingModelResponse> DescribeBuildingModel(DescribeBuildingModelRequest req)
        {
            return InternalRequestAsync<DescribeBuildingModelResponse>(req, "DescribeBuildingModel");
        }

        /// <summary>
        /// 查询建筑三维模型
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingModelRequest"/></param>
        /// <returns><see cref="DescribeBuildingModelResponse"/></returns>
        public DescribeBuildingModelResponse DescribeBuildingModelSync(DescribeBuildingModelRequest req)
        {
            return InternalRequestAsync<DescribeBuildingModelResponse>(req, "DescribeBuildingModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询建筑信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingProfileRequest"/></param>
        /// <returns><see cref="DescribeBuildingProfileResponse"/></returns>
        public Task<DescribeBuildingProfileResponse> DescribeBuildingProfile(DescribeBuildingProfileRequest req)
        {
            return InternalRequestAsync<DescribeBuildingProfileResponse>(req, "DescribeBuildingProfile");
        }

        /// <summary>
        /// 查询建筑信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBuildingProfileRequest"/></param>
        /// <returns><see cref="DescribeBuildingProfileResponse"/></returns>
        public DescribeBuildingProfileResponse DescribeBuildingProfileSync(DescribeBuildingProfileRequest req)
        {
            return InternalRequestAsync<DescribeBuildingProfileResponse>(req, "DescribeBuildingProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取视频扩展信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCameraExtendInfoRequest"/></param>
        /// <returns><see cref="DescribeCameraExtendInfoResponse"/></returns>
        public Task<DescribeCameraExtendInfoResponse> DescribeCameraExtendInfo(DescribeCameraExtendInfoRequest req)
        {
            return InternalRequestAsync<DescribeCameraExtendInfoResponse>(req, "DescribeCameraExtendInfo");
        }

        /// <summary>
        /// 获取视频扩展信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCameraExtendInfoRequest"/></param>
        /// <returns><see cref="DescribeCameraExtendInfoResponse"/></returns>
        public DescribeCameraExtendInfoResponse DescribeCameraExtendInfoSync(DescribeCameraExtendInfoRequest req)
        {
            return InternalRequestAsync<DescribeCameraExtendInfoResponse>(req, "DescribeCameraExtendInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过城市id查询工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCityWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeCityWorkspaceListResponse"/></returns>
        public Task<DescribeCityWorkspaceListResponse> DescribeCityWorkspaceList(DescribeCityWorkspaceListRequest req)
        {
            return InternalRequestAsync<DescribeCityWorkspaceListResponse>(req, "DescribeCityWorkspaceList");
        }

        /// <summary>
        /// 通过城市id查询工作空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCityWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeCityWorkspaceListResponse"/></returns>
        public DescribeCityWorkspaceListResponse DescribeCityWorkspaceListSync(DescribeCityWorkspaceListRequest req)
        {
            return InternalRequestAsync<DescribeCityWorkspaceListResponse>(req, "DescribeCityWorkspaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupListRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupListResponse"/></returns>
        public Task<DescribeDeviceGroupListResponse> DescribeDeviceGroupList(DescribeDeviceGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupListResponse>(req, "DescribeDeviceGroupList");
        }

        /// <summary>
        /// 设备分组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupListRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupListResponse"/></returns>
        public DescribeDeviceGroupListResponse DescribeDeviceGroupListSync(DescribeDeviceGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupListResponse>(req, "DescribeDeviceGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备列表查询/单个查询（支持通过筛选条件查询，设备类型、标签、PID、空间）
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public Task<DescribeDeviceListResponse> DescribeDeviceList(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList");
        }

        /// <summary>
        /// 设备列表查询/单个查询（支持通过筛选条件查询，设备类型、标签、PID、空间）
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public DescribeDeviceListResponse DescribeDeviceListSync(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备影子数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowListRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowListResponse"/></returns>
        public Task<DescribeDeviceShadowListResponse> DescribeDeviceShadowList(DescribeDeviceShadowListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceShadowListResponse>(req, "DescribeDeviceShadowList");
        }

        /// <summary>
        /// 获取设备影子数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowListRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowListResponse"/></returns>
        public DescribeDeviceShadowListResponse DescribeDeviceShadowListSync(DescribeDeviceShadowListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceShadowListResponse>(req, "DescribeDeviceShadowList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusListRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusListResponse"/></returns>
        public Task<DescribeDeviceStatusListResponse> DescribeDeviceStatusList(DescribeDeviceStatusListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStatusListResponse>(req, "DescribeDeviceStatusList");
        }

        /// <summary>
        /// 设备状态获取
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusListRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusListResponse"/></returns>
        public DescribeDeviceStatusListResponse DescribeDeviceStatusListSync(DescribeDeviceStatusListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStatusListResponse>(req, "DescribeDeviceStatusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备状态统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusStatRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusStatResponse"/></returns>
        public Task<DescribeDeviceStatusStatResponse> DescribeDeviceStatusStat(DescribeDeviceStatusStatRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStatusStatResponse>(req, "DescribeDeviceStatusStat");
        }

        /// <summary>
        /// 设备状态统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusStatRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusStatResponse"/></returns>
        public DescribeDeviceStatusStatResponse DescribeDeviceStatusStatSync(DescribeDeviceStatusStatRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStatusStatResponse>(req, "DescribeDeviceStatusStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 标签列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTagListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTagListResponse"/></returns>
        public Task<DescribeDeviceTagListResponse> DescribeDeviceTagList(DescribeDeviceTagListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceTagListResponse>(req, "DescribeDeviceTagList");
        }

        /// <summary>
        /// 标签列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTagListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTagListResponse"/></returns>
        public DescribeDeviceTagListResponse DescribeDeviceTagListSync(DescribeDeviceTagListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceTagListResponse>(req, "DescribeDeviceTagList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取设备的设备类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTypeListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTypeListResponse"/></returns>
        public Task<DescribeDeviceTypeListResponse> DescribeDeviceTypeList(DescribeDeviceTypeListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceTypeListResponse>(req, "DescribeDeviceTypeList");
        }

        /// <summary>
        /// 拉取设备的设备类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceTypeListRequest"/></param>
        /// <returns><see cref="DescribeDeviceTypeListResponse"/></returns>
        public DescribeDeviceTypeListResponse DescribeDeviceTypeListSync(DescribeDeviceTypeListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceTypeListResponse>(req, "DescribeDeviceTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询边缘应用凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeApplicationTokenRequest"/></param>
        /// <returns><see cref="DescribeEdgeApplicationTokenResponse"/></returns>
        public Task<DescribeEdgeApplicationTokenResponse> DescribeEdgeApplicationToken(DescribeEdgeApplicationTokenRequest req)
        {
            return InternalRequestAsync<DescribeEdgeApplicationTokenResponse>(req, "DescribeEdgeApplicationToken");
        }

        /// <summary>
        /// 查询边缘应用凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeApplicationTokenRequest"/></param>
        /// <returns><see cref="DescribeEdgeApplicationTokenResponse"/></returns>
        public DescribeEdgeApplicationTokenResponse DescribeEdgeApplicationTokenSync(DescribeEdgeApplicationTokenRequest req)
        {
            return InternalRequestAsync<DescribeEdgeApplicationTokenResponse>(req, "DescribeEdgeApplicationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分页构件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfilePageRequest"/></param>
        /// <returns><see cref="DescribeElementProfilePageResponse"/></returns>
        public Task<DescribeElementProfilePageResponse> DescribeElementProfilePage(DescribeElementProfilePageRequest req)
        {
            return InternalRequestAsync<DescribeElementProfilePageResponse>(req, "DescribeElementProfilePage");
        }

        /// <summary>
        /// 查询分页构件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfilePageRequest"/></param>
        /// <returns><see cref="DescribeElementProfilePageResponse"/></returns>
        public DescribeElementProfilePageResponse DescribeElementProfilePageSync(DescribeElementProfilePageRequest req)
        {
            return InternalRequestAsync<DescribeElementProfilePageResponse>(req, "DescribeElementProfilePage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询构件树
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfileTreeRequest"/></param>
        /// <returns><see cref="DescribeElementProfileTreeResponse"/></returns>
        public Task<DescribeElementProfileTreeResponse> DescribeElementProfileTree(DescribeElementProfileTreeRequest req)
        {
            return InternalRequestAsync<DescribeElementProfileTreeResponse>(req, "DescribeElementProfileTree");
        }

        /// <summary>
        /// 查询构件树
        /// </summary>
        /// <param name="req"><see cref="DescribeElementProfileTreeRequest"/></param>
        /// <returns><see cref="DescribeElementProfileTreeResponse"/></returns>
        public DescribeElementProfileTreeResponse DescribeElementProfileTreeSync(DescribeElementProfileTreeRequest req)
        {
            return InternalRequestAsync<DescribeElementProfileTreeResponse>(req, "DescribeElementProfileTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListRequest"/></param>
        /// <returns><see cref="DescribeEventListResponse"/></returns>
        public Task<DescribeEventListResponse> DescribeEventList(DescribeEventListRequest req)
        {
            return InternalRequestAsync<DescribeEventListResponse>(req, "DescribeEventList");
        }

        /// <summary>
        /// 事件列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEventListRequest"/></param>
        /// <returns><see cref="DescribeEventListResponse"/></returns>
        public DescribeEventListResponse DescribeEventListSync(DescribeEventListRequest req)
        {
            return InternalRequestAsync<DescribeEventListResponse>(req, "DescribeEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取文件下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadURLResponse"/></returns>
        public Task<DescribeFileDownloadURLResponse> DescribeFileDownloadURL(DescribeFileDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeFileDownloadURLResponse>(req, "DescribeFileDownloadURL");
        }

        /// <summary>
        /// 获取文件下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadURLResponse"/></returns>
        public DescribeFileDownloadURLResponse DescribeFileDownloadURLSync(DescribeFileDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeFileDownloadURLResponse>(req, "DescribeFileDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文件上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUploadURLRequest"/></param>
        /// <returns><see cref="DescribeFileUploadURLResponse"/></returns>
        public Task<DescribeFileUploadURLResponse> DescribeFileUploadURL(DescribeFileUploadURLRequest req)
        {
            return InternalRequestAsync<DescribeFileUploadURLResponse>(req, "DescribeFileUploadURL");
        }

        /// <summary>
        /// 文件上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUploadURLRequest"/></param>
        /// <returns><see cref="DescribeFileUploadURLResponse"/></returns>
        public DescribeFileUploadURLResponse DescribeFileUploadURLSync(DescribeFileUploadURLRequest req)
        {
            return InternalRequestAsync<DescribeFileUploadURLResponse>(req, "DescribeFileUploadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInterfaceListRequest"/></param>
        /// <returns><see cref="DescribeInterfaceListResponse"/></returns>
        public Task<DescribeInterfaceListResponse> DescribeInterfaceList(DescribeInterfaceListRequest req)
        {
            return InternalRequestAsync<DescribeInterfaceListResponse>(req, "DescribeInterfaceList");
        }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInterfaceListRequest"/></param>
        /// <returns><see cref="DescribeInterfaceListResponse"/></returns>
        public DescribeInterfaceListResponse DescribeInterfaceListSync(DescribeInterfaceListRequest req)
        {
            return InternalRequestAsync<DescribeInterfaceListResponse>(req, "DescribeInterfaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 联动规则列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRuleListRequest"/></param>
        /// <returns><see cref="DescribeLinkRuleListResponse"/></returns>
        public Task<DescribeLinkRuleListResponse> DescribeLinkRuleList(DescribeLinkRuleListRequest req)
        {
            return InternalRequestAsync<DescribeLinkRuleListResponse>(req, "DescribeLinkRuleList");
        }

        /// <summary>
        /// 联动规则列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRuleListRequest"/></param>
        /// <returns><see cref="DescribeLinkRuleListResponse"/></returns>
        public DescribeLinkRuleListResponse DescribeLinkRuleListSync(DescribeLinkRuleListRequest req)
        {
            return InternalRequestAsync<DescribeLinkRuleListResponse>(req, "DescribeLinkRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 模型列表查询/单个查询（产品模型/标准模型）
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public Task<DescribeModelListResponse> DescribeModelList(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList");
        }

        /// <summary>
        /// 模型列表查询/单个查询（产品模型/标准模型）
        /// </summary>
        /// <param name="req"><see cref="DescribeModelListRequest"/></param>
        /// <returns><see cref="DescribeModelListResponse"/></returns>
        public DescribeModelListResponse DescribeModelListSync(DescribeModelListRequest req)
        {
            return InternalRequestAsync<DescribeModelListResponse>(req, "DescribeModelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public Task<DescribeProductListResponse> DescribeProductList(DescribeProductListRequest req)
        {
            return InternalRequestAsync<DescribeProductListResponse>(req, "DescribeProductList");
        }

        /// <summary>
        /// 产品列表查询
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public DescribeProductListResponse DescribeProductListSync(DescribeProductListRequest req)
        {
            return InternalRequestAsync<DescribeProductListResponse>(req, "DescribeProductList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询构件属性（详情）
        /// </summary>
        /// <param name="req"><see cref="DescribePropertyListRequest"/></param>
        /// <returns><see cref="DescribePropertyListResponse"/></returns>
        public Task<DescribePropertyListResponse> DescribePropertyList(DescribePropertyListRequest req)
        {
            return InternalRequestAsync<DescribePropertyListResponse>(req, "DescribePropertyList");
        }

        /// <summary>
        /// 查询构件属性（详情）
        /// </summary>
        /// <param name="req"><see cref="DescribePropertyListRequest"/></param>
        /// <returns><see cref="DescribePropertyListResponse"/></returns>
        public DescribePropertyListResponse DescribePropertyListSync(DescribePropertyListRequest req)
        {
            return InternalRequestAsync<DescribePropertyListResponse>(req, "DescribePropertyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 联动规则详情查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public Task<DescribeRuleDetailResponse> DescribeRuleDetail(DescribeRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleDetailResponse>(req, "DescribeRuleDetail");
        }

        /// <summary>
        /// 联动规则详情查询
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public DescribeRuleDetailResponse DescribeRuleDetailSync(DescribeRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleDetailResponse>(req, "DescribeRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneListRequest"/></param>
        /// <returns><see cref="DescribeSceneListResponse"/></returns>
        public Task<DescribeSceneListResponse> DescribeSceneList(DescribeSceneListRequest req)
        {
            return InternalRequestAsync<DescribeSceneListResponse>(req, "DescribeSceneList");
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSceneListRequest"/></param>
        /// <returns><see cref="DescribeSceneListResponse"/></returns>
        public DescribeSceneListResponse DescribeSceneListSync(DescribeSceneListRequest req)
        {
            return InternalRequestAsync<DescribeSceneListResponse>(req, "DescribeSceneList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定空间设备编号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceIdListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceIdListResponse"/></returns>
        public Task<DescribeSpaceDeviceIdListResponse> DescribeSpaceDeviceIdList(DescribeSpaceDeviceIdListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceDeviceIdListResponse>(req, "DescribeSpaceDeviceIdList");
        }

        /// <summary>
        /// 查询指定空间设备编号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceIdListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceIdListResponse"/></returns>
        public DescribeSpaceDeviceIdListResponse DescribeSpaceDeviceIdListSync(DescribeSpaceDeviceIdListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceDeviceIdListResponse>(req, "DescribeSpaceDeviceIdList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定空间下设备与构件绑定关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceRelationListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceRelationListResponse"/></returns>
        public Task<DescribeSpaceDeviceRelationListResponse> DescribeSpaceDeviceRelationList(DescribeSpaceDeviceRelationListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceDeviceRelationListResponse>(req, "DescribeSpaceDeviceRelationList");
        }

        /// <summary>
        /// 查询指定空间下设备与构件绑定关系列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceDeviceRelationListRequest"/></param>
        /// <returns><see cref="DescribeSpaceDeviceRelationListResponse"/></returns>
        public DescribeSpaceDeviceRelationListResponse DescribeSpaceDeviceRelationListSync(DescribeSpaceDeviceRelationListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceDeviceRelationListResponse>(req, "DescribeSpaceDeviceRelationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备绑定的空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceInfoByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceInfoByDeviceIdResponse"/></returns>
        public Task<DescribeSpaceInfoByDeviceIdResponse> DescribeSpaceInfoByDeviceId(DescribeSpaceInfoByDeviceIdRequest req)
        {
            return InternalRequestAsync<DescribeSpaceInfoByDeviceIdResponse>(req, "DescribeSpaceInfoByDeviceId");
        }

        /// <summary>
        /// 查询设备绑定的空间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceInfoByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceInfoByDeviceIdResponse"/></returns>
        public DescribeSpaceInfoByDeviceIdResponse DescribeSpaceInfoByDeviceIdSync(DescribeSpaceInfoByDeviceIdRequest req)
        {
            return InternalRequestAsync<DescribeSpaceInfoByDeviceIdResponse>(req, "DescribeSpaceInfoByDeviceId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备绑定的空间层级关系
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceRelationByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceRelationByDeviceIdResponse"/></returns>
        public Task<DescribeSpaceRelationByDeviceIdResponse> DescribeSpaceRelationByDeviceId(DescribeSpaceRelationByDeviceIdRequest req)
        {
            return InternalRequestAsync<DescribeSpaceRelationByDeviceIdResponse>(req, "DescribeSpaceRelationByDeviceId");
        }

        /// <summary>
        /// 查询设备绑定的空间层级关系
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceRelationByDeviceIdRequest"/></param>
        /// <returns><see cref="DescribeSpaceRelationByDeviceIdResponse"/></returns>
        public DescribeSpaceRelationByDeviceIdResponse DescribeSpaceRelationByDeviceIdSync(DescribeSpaceRelationByDeviceIdRequest req)
        {
            return InternalRequestAsync<DescribeSpaceRelationByDeviceIdResponse>(req, "DescribeSpaceRelationByDeviceId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询空间分类
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceTypeListRequest"/></param>
        /// <returns><see cref="DescribeSpaceTypeListResponse"/></returns>
        public Task<DescribeSpaceTypeListResponse> DescribeSpaceTypeList(DescribeSpaceTypeListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceTypeListResponse>(req, "DescribeSpaceTypeList");
        }

        /// <summary>
        /// 查询空间分类
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceTypeListRequest"/></param>
        /// <returns><see cref="DescribeSpaceTypeListResponse"/></returns>
        public DescribeSpaceTypeListResponse DescribeSpaceTypeListSync(DescribeSpaceTypeListRequest req)
        {
            return InternalRequestAsync<DescribeSpaceTypeListResponse>(req, "DescribeSpaceTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询租户楼栋数量和楼栋建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeTenantBuildingCountAndAreaResponse"/></returns>
        public Task<DescribeTenantBuildingCountAndAreaResponse> DescribeTenantBuildingCountAndArea(DescribeTenantBuildingCountAndAreaRequest req)
        {
            return InternalRequestAsync<DescribeTenantBuildingCountAndAreaResponse>(req, "DescribeTenantBuildingCountAndArea");
        }

        /// <summary>
        /// 查询租户楼栋数量和楼栋建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeTenantBuildingCountAndAreaResponse"/></returns>
        public DescribeTenantBuildingCountAndAreaResponse DescribeTenantBuildingCountAndAreaSync(DescribeTenantBuildingCountAndAreaRequest req)
        {
            return InternalRequestAsync<DescribeTenantBuildingCountAndAreaResponse>(req, "DescribeTenantBuildingCountAndArea")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询租户组织部门列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantDepartmentListRequest"/></param>
        /// <returns><see cref="DescribeTenantDepartmentListResponse"/></returns>
        public Task<DescribeTenantDepartmentListResponse> DescribeTenantDepartmentList(DescribeTenantDepartmentListRequest req)
        {
            return InternalRequestAsync<DescribeTenantDepartmentListResponse>(req, "DescribeTenantDepartmentList");
        }

        /// <summary>
        /// 查询租户组织部门列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantDepartmentListRequest"/></param>
        /// <returns><see cref="DescribeTenantDepartmentListResponse"/></returns>
        public DescribeTenantDepartmentListResponse DescribeTenantDepartmentListSync(DescribeTenantDepartmentListRequest req)
        {
            return InternalRequestAsync<DescribeTenantDepartmentListResponse>(req, "DescribeTenantDepartmentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询租户人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantUserListRequest"/></param>
        /// <returns><see cref="DescribeTenantUserListResponse"/></returns>
        public Task<DescribeTenantUserListResponse> DescribeTenantUserList(DescribeTenantUserListRequest req)
        {
            return InternalRequestAsync<DescribeTenantUserListResponse>(req, "DescribeTenantUserList");
        }

        /// <summary>
        /// 查询租户人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTenantUserListRequest"/></param>
        /// <returns><see cref="DescribeTenantUserListResponse"/></returns>
        public DescribeTenantUserListResponse DescribeTenantUserListSync(DescribeTenantUserListRequest req)
        {
            return InternalRequestAsync<DescribeTenantUserListResponse>(req, "DescribeTenantUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云录像接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoCloudRecordRequest"/></param>
        /// <returns><see cref="DescribeVideoCloudRecordResponse"/></returns>
        public Task<DescribeVideoCloudRecordResponse> DescribeVideoCloudRecord(DescribeVideoCloudRecordRequest req)
        {
            return InternalRequestAsync<DescribeVideoCloudRecordResponse>(req, "DescribeVideoCloudRecord");
        }

        /// <summary>
        /// 云录像接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoCloudRecordRequest"/></param>
        /// <returns><see cref="DescribeVideoCloudRecordResponse"/></returns>
        public DescribeVideoCloudRecordResponse DescribeVideoCloudRecordSync(DescribeVideoCloudRecordRequest req)
        {
            return InternalRequestAsync<DescribeVideoCloudRecordResponse>(req, "DescribeVideoCloudRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实时流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoLiveStreamResponse"/></returns>
        public Task<DescribeVideoLiveStreamResponse> DescribeVideoLiveStream(DescribeVideoLiveStreamRequest req)
        {
            return InternalRequestAsync<DescribeVideoLiveStreamResponse>(req, "DescribeVideoLiveStream");
        }

        /// <summary>
        /// 实时流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoLiveStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoLiveStreamResponse"/></returns>
        public DescribeVideoLiveStreamResponse DescribeVideoLiveStreamSync(DescribeVideoLiveStreamRequest req)
        {
            return InternalRequestAsync<DescribeVideoLiveStreamResponse>(req, "DescribeVideoLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 历史流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoRecordStreamResponse"/></returns>
        public Task<DescribeVideoRecordStreamResponse> DescribeVideoRecordStream(DescribeVideoRecordStreamRequest req)
        {
            return InternalRequestAsync<DescribeVideoRecordStreamResponse>(req, "DescribeVideoRecordStream");
        }

        /// <summary>
        /// 历史流接口
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoRecordStreamRequest"/></param>
        /// <returns><see cref="DescribeVideoRecordStreamResponse"/></returns>
        public DescribeVideoRecordStreamResponse DescribeVideoRecordStreamSync(DescribeVideoRecordStreamRequest req)
        {
            return InternalRequestAsync<DescribeVideoRecordStreamResponse>(req, "DescribeVideoRecordStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目空间楼栋数量与建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkSpaceBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeWorkSpaceBuildingCountAndAreaResponse"/></returns>
        public Task<DescribeWorkSpaceBuildingCountAndAreaResponse> DescribeWorkSpaceBuildingCountAndArea(DescribeWorkSpaceBuildingCountAndAreaRequest req)
        {
            return InternalRequestAsync<DescribeWorkSpaceBuildingCountAndAreaResponse>(req, "DescribeWorkSpaceBuildingCountAndArea");
        }

        /// <summary>
        /// 查询项目空间楼栋数量与建筑面积
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkSpaceBuildingCountAndAreaRequest"/></param>
        /// <returns><see cref="DescribeWorkSpaceBuildingCountAndAreaResponse"/></returns>
        public DescribeWorkSpaceBuildingCountAndAreaResponse DescribeWorkSpaceBuildingCountAndAreaSync(DescribeWorkSpaceBuildingCountAndAreaRequest req)
        {
            return InternalRequestAsync<DescribeWorkSpaceBuildingCountAndAreaResponse>(req, "DescribeWorkSpaceBuildingCountAndArea")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取租户下的空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceListResponse"/></returns>
        public Task<DescribeWorkspaceListResponse> DescribeWorkspaceList(DescribeWorkspaceListRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceListResponse>(req, "DescribeWorkspaceList");
        }

        /// <summary>
        /// 获取租户下的空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceListResponse"/></returns>
        public DescribeWorkspaceListResponse DescribeWorkspaceListSync(DescribeWorkspaceListRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceListResponse>(req, "DescribeWorkspaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目空间人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceUserListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceUserListResponse"/></returns>
        public Task<DescribeWorkspaceUserListResponse> DescribeWorkspaceUserList(DescribeWorkspaceUserListRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceUserListResponse>(req, "DescribeWorkspaceUserList");
        }

        /// <summary>
        /// 查询项目空间人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceUserListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceUserListResponse"/></returns>
        public DescribeWorkspaceUserListResponse DescribeWorkspaceUserListSync(DescribeWorkspaceUserListRequest req)
        {
            return InternalRequestAsync<DescribeWorkspaceUserListResponse>(req, "DescribeWorkspaceUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改设备自定义字段值
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceFieldRequest"/></param>
        /// <returns><see cref="ModifyDeviceFieldResponse"/></returns>
        public Task<ModifyDeviceFieldResponse> ModifyDeviceField(ModifyDeviceFieldRequest req)
        {
            return InternalRequestAsync<ModifyDeviceFieldResponse>(req, "ModifyDeviceField");
        }

        /// <summary>
        /// 批量修改设备自定义字段值
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceFieldRequest"/></param>
        /// <returns><see cref="ModifyDeviceFieldResponse"/></returns>
        public ModifyDeviceFieldResponse ModifyDeviceFieldSync(ModifyDeviceFieldRequest req)
        {
            return InternalRequestAsync<ModifyDeviceFieldResponse>(req, "ModifyDeviceField")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改设备组
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceGroupRequest"/></param>
        /// <returns><see cref="ModifyDeviceGroupResponse"/></returns>
        public Task<ModifyDeviceGroupResponse> ModifyDeviceGroup(ModifyDeviceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDeviceGroupResponse>(req, "ModifyDeviceGroup");
        }

        /// <summary>
        /// 批量修改设备组
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceGroupRequest"/></param>
        /// <returns><see cref="ModifyDeviceGroupResponse"/></returns>
        public ModifyDeviceGroupResponse ModifyDeviceGroupSync(ModifyDeviceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDeviceGroupResponse>(req, "ModifyDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改设备名字
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceNameRequest"/></param>
        /// <returns><see cref="ModifyDeviceNameResponse"/></returns>
        public Task<ModifyDeviceNameResponse> ModifyDeviceName(ModifyDeviceNameRequest req)
        {
            return InternalRequestAsync<ModifyDeviceNameResponse>(req, "ModifyDeviceName");
        }

        /// <summary>
        /// 批量修改设备名字
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceNameRequest"/></param>
        /// <returns><see cref="ModifyDeviceNameResponse"/></returns>
        public ModifyDeviceNameResponse ModifyDeviceNameSync(ModifyDeviceNameRequest req)
        {
            return InternalRequestAsync<ModifyDeviceNameResponse>(req, "ModifyDeviceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改设备标签
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceTagRequest"/></param>
        /// <returns><see cref="ModifyDeviceTagResponse"/></returns>
        public Task<ModifyDeviceTagResponse> ModifyDeviceTag(ModifyDeviceTagRequest req)
        {
            return InternalRequestAsync<ModifyDeviceTagResponse>(req, "ModifyDeviceTag");
        }

        /// <summary>
        /// 批量修改设备标签
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceTagRequest"/></param>
        /// <returns><see cref="ModifyDeviceTagResponse"/></returns>
        public ModifyDeviceTagResponse ModifyDeviceTagSync(ModifyDeviceTagRequest req)
        {
            return InternalRequestAsync<ModifyDeviceTagResponse>(req, "ModifyDeviceTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报应用消息
        /// </summary>
        /// <param name="req"><see cref="ReportAppMessageRequest"/></param>
        /// <returns><see cref="ReportAppMessageResponse"/></returns>
        public Task<ReportAppMessageResponse> ReportAppMessage(ReportAppMessageRequest req)
        {
            return InternalRequestAsync<ReportAppMessageResponse>(req, "ReportAppMessage");
        }

        /// <summary>
        /// 上报应用消息
        /// </summary>
        /// <param name="req"><see cref="ReportAppMessageRequest"/></param>
        /// <returns><see cref="ReportAppMessageResponse"/></returns>
        public ReportAppMessageResponse ReportAppMessageSync(ReportAppMessageRequest req)
        {
            return InternalRequestAsync<ReportAppMessageResponse>(req, "ReportAppMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设备分组新增/修改
        /// </summary>
        /// <param name="req"><see cref="SaveDeviceGroupRequest"/></param>
        /// <returns><see cref="SaveDeviceGroupResponse"/></returns>
        public Task<SaveDeviceGroupResponse> SaveDeviceGroup(SaveDeviceGroupRequest req)
        {
            return InternalRequestAsync<SaveDeviceGroupResponse>(req, "SaveDeviceGroup");
        }

        /// <summary>
        /// 设备分组新增/修改
        /// </summary>
        /// <param name="req"><see cref="SaveDeviceGroupRequest"/></param>
        /// <returns><see cref="SaveDeviceGroupResponse"/></returns>
        public SaveDeviceGroupResponse SaveDeviceGroupSync(SaveDeviceGroupRequest req)
        {
            return InternalRequestAsync<SaveDeviceGroupResponse>(req, "SaveDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 断流接口
        /// </summary>
        /// <param name="req"><see cref="StopVideoStreamingRequest"/></param>
        /// <returns><see cref="StopVideoStreamingResponse"/></returns>
        public Task<StopVideoStreamingResponse> StopVideoStreaming(StopVideoStreamingRequest req)
        {
            return InternalRequestAsync<StopVideoStreamingResponse>(req, "StopVideoStreaming");
        }

        /// <summary>
        /// 断流接口
        /// </summary>
        /// <param name="req"><see cref="StopVideoStreamingRequest"/></param>
        /// <returns><see cref="StopVideoStreamingResponse"/></returns>
        public StopVideoStreamingResponse StopVideoStreamingSync(StopVideoStreamingRequest req)
        {
            return InternalRequestAsync<StopVideoStreamingResponse>(req, "StopVideoStreaming")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改工作空间园区属性
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceParkAttributesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceParkAttributesResponse"/></returns>
        public Task<UpdateWorkspaceParkAttributesResponse> UpdateWorkspaceParkAttributes(UpdateWorkspaceParkAttributesRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceParkAttributesResponse>(req, "UpdateWorkspaceParkAttributes");
        }

        /// <summary>
        /// 修改工作空间园区属性
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceParkAttributesRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceParkAttributesResponse"/></returns>
        public UpdateWorkspaceParkAttributesResponse UpdateWorkspaceParkAttributesSync(UpdateWorkspaceParkAttributesRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceParkAttributesResponse>(req, "UpdateWorkspaceParkAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
