/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ioa.V20220601
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ioa.V20220601.Models;

   public class IoaClient : AbstractClient{

       private const string endpoint = "ioa.tencentcloudapi.com";
       private const string version = "2022-06-01";
       private const string sdkVersion = "SDK_NET_3.0.1309";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IoaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IoaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提交送检任务
        /// </summary>
        /// <param name="req"><see cref="CreateDLPFileDetectionTaskRequest"/></param>
        /// <returns><see cref="CreateDLPFileDetectionTaskResponse"/></returns>
        public Task<CreateDLPFileDetectionTaskResponse> CreateDLPFileDetectionTask(CreateDLPFileDetectionTaskRequest req)
        {
            return InternalRequestAsync<CreateDLPFileDetectionTaskResponse>(req, "CreateDLPFileDetectionTask");
        }

        /// <summary>
        /// 提交送检任务
        /// </summary>
        /// <param name="req"><see cref="CreateDLPFileDetectionTaskRequest"/></param>
        /// <returns><see cref="CreateDLPFileDetectionTaskResponse"/></returns>
        public CreateDLPFileDetectionTaskResponse CreateDLPFileDetectionTaskSync(CreateDLPFileDetectionTaskRequest req)
        {
            return InternalRequestAsync<CreateDLPFileDetectionTaskResponse>(req, "CreateDLPFileDetectionTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建获取终端进程网络服务信息任务，私有化调用path为：capi/Assets/Device/DescribeDeviceInfo
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceTaskRequest"/></param>
        /// <returns><see cref="CreateDeviceTaskResponse"/></returns>
        public Task<CreateDeviceTaskResponse> CreateDeviceTask(CreateDeviceTaskRequest req)
        {
            return InternalRequestAsync<CreateDeviceTaskResponse>(req, "CreateDeviceTask");
        }

        /// <summary>
        /// 创建获取终端进程网络服务信息任务，私有化调用path为：capi/Assets/Device/DescribeDeviceInfo
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceTaskRequest"/></param>
        /// <returns><see cref="CreateDeviceTaskResponse"/></returns>
        public CreateDeviceTaskResponse CreateDeviceTaskSync(CreateDeviceTaskRequest req)
        {
            return InternalRequestAsync<CreateDeviceTaskResponse>(req, "CreateDeviceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建终端自定义分组，私有化调用path为：/capi/Assets/Device/CreateDeviceVirtualGroup
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceVirtualGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceVirtualGroupResponse"/></returns>
        public Task<CreateDeviceVirtualGroupResponse> CreateDeviceVirtualGroup(CreateDeviceVirtualGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceVirtualGroupResponse>(req, "CreateDeviceVirtualGroup");
        }

        /// <summary>
        /// 创建终端自定义分组，私有化调用path为：/capi/Assets/Device/CreateDeviceVirtualGroup
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceVirtualGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceVirtualGroupResponse"/></returns>
        public CreateDeviceVirtualGroupResponse CreateDeviceVirtualGroupSync(CreateDeviceVirtualGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceVirtualGroupResponse>(req, "CreateDeviceVirtualGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成特权码，私有化调用path为：capi/Assets/Device/CreatePrivilegeCode，生成的特权码、卸载码，仅对该设备当天有效
        /// </summary>
        /// <param name="req"><see cref="CreatePrivilegeCodeRequest"/></param>
        /// <returns><see cref="CreatePrivilegeCodeResponse"/></returns>
        public Task<CreatePrivilegeCodeResponse> CreatePrivilegeCode(CreatePrivilegeCodeRequest req)
        {
            return InternalRequestAsync<CreatePrivilegeCodeResponse>(req, "CreatePrivilegeCode");
        }

        /// <summary>
        /// 生成特权码，私有化调用path为：capi/Assets/Device/CreatePrivilegeCode，生成的特权码、卸载码，仅对该设备当天有效
        /// </summary>
        /// <param name="req"><see cref="CreatePrivilegeCodeRequest"/></param>
        /// <returns><see cref="CreatePrivilegeCodeResponse"/></returns>
        public CreatePrivilegeCodeResponse CreatePrivilegeCodeSync(CreatePrivilegeCodeRequest req)
        {
            return InternalRequestAsync<CreatePrivilegeCodeResponse>(req, "CreatePrivilegeCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以分页的方式查询账号分组列表，私有化调用path为：/capi/Assets/DescribeAccountGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupsResponse"/></returns>
        public Task<DescribeAccountGroupsResponse> DescribeAccountGroups(DescribeAccountGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccountGroupsResponse>(req, "DescribeAccountGroups");
        }

        /// <summary>
        /// 以分页的方式查询账号分组列表，私有化调用path为：/capi/Assets/DescribeAccountGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupsResponse"/></returns>
        public DescribeAccountGroupsResponse DescribeAccountGroupsSync(DescribeAccountGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccountGroupsResponse>(req, "DescribeAccountGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚合的分类软件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAggrSoftCategorySoftListRequest"/></param>
        /// <returns><see cref="DescribeAggrSoftCategorySoftListResponse"/></returns>
        public Task<DescribeAggrSoftCategorySoftListResponse> DescribeAggrSoftCategorySoftList(DescribeAggrSoftCategorySoftListRequest req)
        {
            return InternalRequestAsync<DescribeAggrSoftCategorySoftListResponse>(req, "DescribeAggrSoftCategorySoftList");
        }

        /// <summary>
        /// 聚合的分类软件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAggrSoftCategorySoftListRequest"/></param>
        /// <returns><see cref="DescribeAggrSoftCategorySoftListResponse"/></returns>
        public DescribeAggrSoftCategorySoftListResponse DescribeAggrSoftCategorySoftListSync(DescribeAggrSoftCategorySoftListRequest req)
        {
            return InternalRequestAsync<DescribeAggrSoftCategorySoftListResponse>(req, "DescribeAggrSoftCategorySoftList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// webservice查询文件检测结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDLPFileDetectResultRequest"/></param>
        /// <returns><see cref="DescribeDLPFileDetectResultResponse"/></returns>
        public Task<DescribeDLPFileDetectResultResponse> DescribeDLPFileDetectResult(DescribeDLPFileDetectResultRequest req)
        {
            return InternalRequestAsync<DescribeDLPFileDetectResultResponse>(req, "DescribeDLPFileDetectResult");
        }

        /// <summary>
        /// webservice查询文件检测结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDLPFileDetectResultRequest"/></param>
        /// <returns><see cref="DescribeDLPFileDetectResultResponse"/></returns>
        public DescribeDLPFileDetectResultResponse DescribeDLPFileDetectResultSync(DescribeDLPFileDetectResultRequest req)
        {
            return InternalRequestAsync<DescribeDLPFileDetectResultResponse>(req, "DescribeDLPFileDetectResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备组子分组详情，私有化调用path为：capi/Assets/Device/DescribeDeviceChildGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChildGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceChildGroupsResponse"/></returns>
        public Task<DescribeDeviceChildGroupsResponse> DescribeDeviceChildGroups(DescribeDeviceChildGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceChildGroupsResponse>(req, "DescribeDeviceChildGroups");
        }

        /// <summary>
        /// 查询设备组子分组详情，私有化调用path为：capi/Assets/Device/DescribeDeviceChildGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChildGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceChildGroupsResponse"/></returns>
        public DescribeDeviceChildGroupsResponse DescribeDeviceChildGroupsSync(DescribeDeviceChildGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceChildGroupsResponse>(req, "DescribeDeviceChildGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询满足条件的查询终端硬件信息列表，私有化调用path为：/capi/Assets/Device/DescribeDeviceHardwareInfoList
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceHardwareInfoListRequest"/></param>
        /// <returns><see cref="DescribeDeviceHardwareInfoListResponse"/></returns>
        public Task<DescribeDeviceHardwareInfoListResponse> DescribeDeviceHardwareInfoList(DescribeDeviceHardwareInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceHardwareInfoListResponse>(req, "DescribeDeviceHardwareInfoList");
        }

        /// <summary>
        /// 查询满足条件的查询终端硬件信息列表，私有化调用path为：/capi/Assets/Device/DescribeDeviceHardwareInfoList
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceHardwareInfoListRequest"/></param>
        /// <returns><see cref="DescribeDeviceHardwareInfoListResponse"/></returns>
        public DescribeDeviceHardwareInfoListResponse DescribeDeviceHardwareInfoListSync(DescribeDeviceHardwareInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceHardwareInfoListResponse>(req, "DescribeDeviceHardwareInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取终端进程网络服务信息，私有化调用path为：capi/Assets/Device/DescribeDeviceInfo
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public Task<DescribeDeviceInfoResponse> DescribeDeviceInfo(DescribeDeviceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInfoResponse>(req, "DescribeDeviceInfo");
        }

        /// <summary>
        /// 获取终端进程网络服务信息，私有化调用path为：capi/Assets/Device/DescribeDeviceInfo
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfoSync(DescribeDeviceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInfoResponse>(req, "DescribeDeviceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询终端自定义分组列表，私有化调用path为：/capi/Assets/Device/DescribeDeviceVirtualGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceVirtualGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceVirtualGroupsResponse"/></returns>
        public Task<DescribeDeviceVirtualGroupsResponse> DescribeDeviceVirtualGroups(DescribeDeviceVirtualGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceVirtualGroupsResponse>(req, "DescribeDeviceVirtualGroups");
        }

        /// <summary>
        /// 查询终端自定义分组列表，私有化调用path为：/capi/Assets/Device/DescribeDeviceVirtualGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceVirtualGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceVirtualGroupsResponse"/></returns>
        public DescribeDeviceVirtualGroupsResponse DescribeDeviceVirtualGroupsSync(DescribeDeviceVirtualGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceVirtualGroupsResponse>(req, "DescribeDeviceVirtualGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询满足条件的终端数据详情，私有化调用path为：/capi/Assets/Device/DescribeDevices
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// 查询满足条件的终端数据详情，私有化调用path为：/capi/Assets/Device/DescribeDevices
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账号列表，支持分页，模糊搜索，私有化调用path为：/capi/Assets/Account/DescribeLocalAccounts
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalAccountsRequest"/></param>
        /// <returns><see cref="DescribeLocalAccountsResponse"/></returns>
        public Task<DescribeLocalAccountsResponse> DescribeLocalAccounts(DescribeLocalAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLocalAccountsResponse>(req, "DescribeLocalAccounts");
        }

        /// <summary>
        /// 获取账号列表，支持分页，模糊搜索，私有化调用path为：/capi/Assets/Account/DescribeLocalAccounts
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalAccountsRequest"/></param>
        /// <returns><see cref="DescribeLocalAccountsResponse"/></returns>
        public DescribeLocalAccountsResponse DescribeLocalAccountsSync(DescribeLocalAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLocalAccountsResponse>(req, "DescribeLocalAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账号根分组详情。对应“用户与授权管理”里内置不可见的全网根账号组，所有新建的目录，都挂在该全网根账号组下。
        /// </summary>
        /// <param name="req"><see cref="DescribeRootAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeRootAccountGroupResponse"/></returns>
        public Task<DescribeRootAccountGroupResponse> DescribeRootAccountGroup(DescribeRootAccountGroupRequest req)
        {
            return InternalRequestAsync<DescribeRootAccountGroupResponse>(req, "DescribeRootAccountGroup");
        }

        /// <summary>
        /// 查询账号根分组详情。对应“用户与授权管理”里内置不可见的全网根账号组，所有新建的目录，都挂在该全网根账号组下。
        /// </summary>
        /// <param name="req"><see cref="DescribeRootAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeRootAccountGroupResponse"/></returns>
        public DescribeRootAccountGroupResponse DescribeRootAccountGroupSync(DescribeRootAccountGroupRequest req)
        {
            return InternalRequestAsync<DescribeRootAccountGroupResponse>(req, "DescribeRootAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看终端树下的软件列表,私有化调用path为：capi/Software/DescribeSoftCensusListByDevice
        /// </summary>
        /// <param name="req"><see cref="DescribeSoftCensusListByDeviceRequest"/></param>
        /// <returns><see cref="DescribeSoftCensusListByDeviceResponse"/></returns>
        public Task<DescribeSoftCensusListByDeviceResponse> DescribeSoftCensusListByDevice(DescribeSoftCensusListByDeviceRequest req)
        {
            return InternalRequestAsync<DescribeSoftCensusListByDeviceResponse>(req, "DescribeSoftCensusListByDevice");
        }

        /// <summary>
        /// 查看终端树下的软件列表,私有化调用path为：capi/Software/DescribeSoftCensusListByDevice
        /// </summary>
        /// <param name="req"><see cref="DescribeSoftCensusListByDeviceRequest"/></param>
        /// <returns><see cref="DescribeSoftCensusListByDeviceResponse"/></returns>
        public DescribeSoftCensusListByDeviceResponse DescribeSoftCensusListByDeviceSync(DescribeSoftCensusListByDeviceRequest req)
        {
            return InternalRequestAsync<DescribeSoftCensusListByDeviceResponse>(req, "DescribeSoftCensusListByDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看指定终端的软件详情列表,私有化调用path为：capi/Software/DescribeSoftwareInformation
        /// </summary>
        /// <param name="req"><see cref="DescribeSoftwareInformationRequest"/></param>
        /// <returns><see cref="DescribeSoftwareInformationResponse"/></returns>
        public Task<DescribeSoftwareInformationResponse> DescribeSoftwareInformation(DescribeSoftwareInformationRequest req)
        {
            return InternalRequestAsync<DescribeSoftwareInformationResponse>(req, "DescribeSoftwareInformation");
        }

        /// <summary>
        /// 查看指定终端的软件详情列表,私有化调用path为：capi/Software/DescribeSoftwareInformation
        /// </summary>
        /// <param name="req"><see cref="DescribeSoftwareInformationRequest"/></param>
        /// <returns><see cref="DescribeSoftwareInformationResponse"/></returns>
        public DescribeSoftwareInformationResponse DescribeSoftwareInformationSync(DescribeSoftwareInformationRequest req)
        {
            return InternalRequestAsync<DescribeSoftwareInformationResponse>(req, "DescribeSoftwareInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示自定义分组终端列表，私有化调用path为：/capi/Assets/DescribeVirtualDevices
        /// </summary>
        /// <param name="req"><see cref="DescribeVirtualDevicesRequest"/></param>
        /// <returns><see cref="DescribeVirtualDevicesResponse"/></returns>
        public Task<DescribeVirtualDevicesResponse> DescribeVirtualDevices(DescribeVirtualDevicesRequest req)
        {
            return InternalRequestAsync<DescribeVirtualDevicesResponse>(req, "DescribeVirtualDevices");
        }

        /// <summary>
        /// 展示自定义分组终端列表，私有化调用path为：/capi/Assets/DescribeVirtualDevices
        /// </summary>
        /// <param name="req"><see cref="DescribeVirtualDevicesRequest"/></param>
        /// <returns><see cref="DescribeVirtualDevicesResponse"/></returns>
        public DescribeVirtualDevicesResponse DescribeVirtualDevicesSync(DescribeVirtualDevicesRequest req)
        {
            return InternalRequestAsync<DescribeVirtualDevicesResponse>(req, "DescribeVirtualDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终端自定义分组增减终端，私有化调用path为：/capi/Assets/Device/ModifyVirtualDeviceGroups
        /// </summary>
        /// <param name="req"><see cref="ModifyVirtualDeviceGroupsRequest"/></param>
        /// <returns><see cref="ModifyVirtualDeviceGroupsResponse"/></returns>
        public Task<ModifyVirtualDeviceGroupsResponse> ModifyVirtualDeviceGroups(ModifyVirtualDeviceGroupsRequest req)
        {
            return InternalRequestAsync<ModifyVirtualDeviceGroupsResponse>(req, "ModifyVirtualDeviceGroups");
        }

        /// <summary>
        /// 终端自定义分组增减终端，私有化调用path为：/capi/Assets/Device/ModifyVirtualDeviceGroups
        /// </summary>
        /// <param name="req"><see cref="ModifyVirtualDeviceGroupsRequest"/></param>
        /// <returns><see cref="ModifyVirtualDeviceGroupsResponse"/></returns>
        public ModifyVirtualDeviceGroupsResponse ModifyVirtualDeviceGroupsSync(ModifyVirtualDeviceGroupsRequest req)
        {
            return InternalRequestAsync<ModifyVirtualDeviceGroupsResponse>(req, "ModifyVirtualDeviceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
