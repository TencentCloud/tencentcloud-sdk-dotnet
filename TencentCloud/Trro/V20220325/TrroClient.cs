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

namespace TencentCloud.Trro.V20220325
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trro.V20220325.Models;

   public class TrroClient : AbstractClient{

       private const string endpoint = "trro.tencentcloudapi.com";
       private const string version = "2022-03-25";
       private const string sdkVersion = "SDK_NET_3.0.1227";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrroClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrroClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于批量删除设备
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDevicesRequest"/></param>
        /// <returns><see cref="BatchDeleteDevicesResponse"/></returns>
        public Task<BatchDeleteDevicesResponse> BatchDeleteDevices(BatchDeleteDevicesRequest req)
        {
            return InternalRequestAsync<BatchDeleteDevicesResponse>(req, "BatchDeleteDevices");
        }

        /// <summary>
        /// 用于批量删除设备
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDevicesRequest"/></param>
        /// <returns><see cref="BatchDeleteDevicesResponse"/></returns>
        public BatchDeleteDevicesResponse BatchDeleteDevicesSync(BatchDeleteDevicesRequest req)
        {
            return InternalRequestAsync<BatchDeleteDevicesResponse>(req, "BatchDeleteDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量删除修改权限配置
        /// </summary>
        /// <param name="req"><see cref="BatchDeletePolicyRequest"/></param>
        /// <returns><see cref="BatchDeletePolicyResponse"/></returns>
        public Task<BatchDeletePolicyResponse> BatchDeletePolicy(BatchDeletePolicyRequest req)
        {
            return InternalRequestAsync<BatchDeletePolicyResponse>(req, "BatchDeletePolicy");
        }

        /// <summary>
        /// 用于批量删除修改权限配置
        /// </summary>
        /// <param name="req"><see cref="BatchDeletePolicyRequest"/></param>
        /// <returns><see cref="BatchDeletePolicyResponse"/></returns>
        public BatchDeletePolicyResponse BatchDeletePolicySync(BatchDeletePolicyRequest req)
        {
            return InternalRequestAsync<BatchDeletePolicyResponse>(req, "BatchDeletePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为推流设备绑定license，优先绑定到期时间最近的，到期时间相同优先绑定月包
        /// </summary>
        /// <param name="req"><see cref="BoundLicensesRequest"/></param>
        /// <returns><see cref="BoundLicensesResponse"/></returns>
        public Task<BoundLicensesResponse> BoundLicenses(BoundLicensesRequest req)
        {
            return InternalRequestAsync<BoundLicensesResponse>(req, "BoundLicenses");
        }

        /// <summary>
        /// 为推流设备绑定license，优先绑定到期时间最近的，到期时间相同优先绑定月包
        /// </summary>
        /// <param name="req"><see cref="BoundLicensesRequest"/></param>
        /// <returns><see cref="BoundLicensesResponse"/></returns>
        public BoundLicensesResponse BoundLicensesSync(BoundLicensesRequest req)
        {
            return InternalRequestAsync<BoundLicensesResponse>(req, "BoundLicenses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动云端录制功能，完成房间内的音视频录制，并上传到指定的云存储。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public Task<CreateCloudRecordingResponse> CreateCloudRecording(CreateCloudRecordingRequest req)
        {
            return InternalRequestAsync<CreateCloudRecordingResponse>(req, "CreateCloudRecording");
        }

        /// <summary>
        /// 启动云端录制功能，完成房间内的音视频录制，并上传到指定的云存储。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRecordingRequest"/></param>
        /// <returns><see cref="CreateCloudRecordingResponse"/></returns>
        public CreateCloudRecordingResponse CreateCloudRecordingSync(CreateCloudRecordingRequest req)
        {
            return InternalRequestAsync<CreateCloudRecordingResponse>(req, "CreateCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice");
        }

        /// <summary>
        /// 用于创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 用于创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来停止录制任务。停止录制成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public Task<DeleteCloudRecordingResponse> DeleteCloudRecording(DeleteCloudRecordingRequest req)
        {
            return InternalRequestAsync<DeleteCloudRecordingResponse>(req, "DeleteCloudRecording");
        }

        /// <summary>
        /// 成功开启录制后，可以使用此接口来停止录制任务。停止录制成功后不代表文件全部传输完成，如果未完成后台将会继续上传文件，成功后通过事件回调通知客户文件全部传输完成状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteCloudRecordingRequest"/></param>
        /// <returns><see cref="DeleteCloudRecordingResponse"/></returns>
        public DeleteCloudRecordingResponse DeleteCloudRecordingSync(DeleteCloudRecordingRequest req)
        {
            return InternalRequestAsync<DeleteCloudRecordingResponse>(req, "DeleteCloudRecording")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 用于删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取指定设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public Task<DescribeDeviceInfoResponse> DescribeDeviceInfo(DescribeDeviceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInfoResponse>(req, "DescribeDeviceInfo");
        }

        /// <summary>
        /// 用于获取指定设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfoSync(DescribeDeviceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInfoResponse>(req, "DescribeDeviceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public Task<DescribeDeviceListResponse> DescribeDeviceList(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList");
        }

        /// <summary>
        /// 用于获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public DescribeDeviceListResponse DescribeDeviceListSync(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备会话数据详单
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionDetailsResponse"/></returns>
        public Task<DescribeDeviceSessionDetailsResponse> DescribeDeviceSessionDetails(DescribeDeviceSessionDetailsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceSessionDetailsResponse>(req, "DescribeDeviceSessionDetails");
        }

        /// <summary>
        /// 获取设备会话数据详单
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionDetailsResponse"/></returns>
        public DescribeDeviceSessionDetailsResponse DescribeDeviceSessionDetailsSync(DescribeDeviceSessionDetailsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceSessionDetailsResponse>(req, "DescribeDeviceSessionDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionListRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionListResponse"/></returns>
        public Task<DescribeDeviceSessionListResponse> DescribeDeviceSessionList(DescribeDeviceSessionListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceSessionListResponse>(req, "DescribeDeviceSessionList");
        }

        /// <summary>
        /// 获取设备会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionListRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionListResponse"/></returns>
        public DescribeDeviceSessionListResponse DescribeDeviceSessionListSync(DescribeDeviceSessionListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceSessionListResponse>(req, "DescribeDeviceSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查看权限配置
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRequest"/></param>
        /// <returns><see cref="DescribePolicyResponse"/></returns>
        public Task<DescribePolicyResponse> DescribePolicy(DescribePolicyRequest req)
        {
            return InternalRequestAsync<DescribePolicyResponse>(req, "DescribePolicy");
        }

        /// <summary>
        /// 用于查看权限配置
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRequest"/></param>
        /// <returns><see cref="DescribePolicyResponse"/></returns>
        public DescribePolicyResponse DescribePolicySync(DescribePolicyRequest req)
        {
            return InternalRequestAsync<DescribePolicyResponse>(req, "DescribePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public Task<DescribeProjectInfoResponse> DescribeProjectInfo(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo");
        }

        /// <summary>
        /// 用于获取项目信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public DescribeProjectInfoResponse DescribeProjectInfoSync(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public Task<DescribeProjectListResponse> DescribeProjectList(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList");
        }

        /// <summary>
        /// 用于获取项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public DescribeProjectListResponse DescribeProjectListSync(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取最新设备会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecentSessionListRequest"/></param>
        /// <returns><see cref="DescribeRecentSessionListResponse"/></returns>
        public Task<DescribeRecentSessionListResponse> DescribeRecentSessionList(DescribeRecentSessionListRequest req)
        {
            return InternalRequestAsync<DescribeRecentSessionListResponse>(req, "DescribeRecentSessionList");
        }

        /// <summary>
        /// 获取最新设备会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRecentSessionListRequest"/></param>
        /// <returns><see cref="DescribeRecentSessionListResponse"/></returns>
        public DescribeRecentSessionListResponse DescribeRecentSessionListSync(DescribeRecentSessionListRequest req)
        {
            return InternalRequestAsync<DescribeRecentSessionListResponse>(req, "DescribeRecentSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsResponse"/></returns>
        public Task<DescribeSessionStatisticsResponse> DescribeSessionStatistics(DescribeSessionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsResponse>(req, "DescribeSessionStatistics");
        }

        /// <summary>
        /// 获取会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsResponse"/></returns>
        public DescribeSessionStatisticsResponse DescribeSessionStatisticsSync(DescribeSessionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsResponse>(req, "DescribeSessionStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取各时间段的会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsByIntervalRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsByIntervalResponse"/></returns>
        public Task<DescribeSessionStatisticsByIntervalResponse> DescribeSessionStatisticsByInterval(DescribeSessionStatisticsByIntervalRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsByIntervalResponse>(req, "DescribeSessionStatisticsByInterval");
        }

        /// <summary>
        /// 获取各时间段的会话统计值
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsByIntervalRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsByIntervalResponse"/></returns>
        public DescribeSessionStatisticsByIntervalResponse DescribeSessionStatisticsByIntervalSync(DescribeSessionStatisticsByIntervalRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsByIntervalResponse>(req, "DescribeSessionStatisticsByInterval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备已经绑定的可用授权数量
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLicenseRequest"/></param>
        /// <returns><see cref="GetDeviceLicenseResponse"/></returns>
        public Task<GetDeviceLicenseResponse> GetDeviceLicense(GetDeviceLicenseRequest req)
        {
            return InternalRequestAsync<GetDeviceLicenseResponse>(req, "GetDeviceLicense");
        }

        /// <summary>
        /// 获取设备已经绑定的可用授权数量
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLicenseRequest"/></param>
        /// <returns><see cref="GetDeviceLicenseResponse"/></returns>
        public GetDeviceLicenseResponse GetDeviceLicenseSync(GetDeviceLicenseRequest req)
        {
            return InternalRequestAsync<GetDeviceLicenseResponse>(req, "GetDeviceLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户设备的授权绑定情况
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public Task<GetDevicesResponse> GetDevices(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices");
        }

        /// <summary>
        /// 查询用户设备的授权绑定情况
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public GetDevicesResponse GetDevicesSync(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 统计license类型数量
        /// </summary>
        /// <param name="req"><see cref="GetLicenseStatRequest"/></param>
        /// <returns><see cref="GetLicenseStatResponse"/></returns>
        public Task<GetLicenseStatResponse> GetLicenseStat(GetLicenseStatRequest req)
        {
            return InternalRequestAsync<GetLicenseStatResponse>(req, "GetLicenseStat");
        }

        /// <summary>
        /// 统计license类型数量
        /// </summary>
        /// <param name="req"><see cref="GetLicenseStatRequest"/></param>
        /// <returns><see cref="GetLicenseStatResponse"/></returns>
        public GetLicenseStatResponse GetLicenseStatSync(GetLicenseStatRequest req)
        {
            return InternalRequestAsync<GetLicenseStatResponse>(req, "GetLicenseStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按授权查看license列表
        /// </summary>
        /// <param name="req"><see cref="GetLicensesRequest"/></param>
        /// <returns><see cref="GetLicensesResponse"/></returns>
        public Task<GetLicensesResponse> GetLicenses(GetLicensesRequest req)
        {
            return InternalRequestAsync<GetLicensesResponse>(req, "GetLicenses");
        }

        /// <summary>
        /// 按授权查看license列表
        /// </summary>
        /// <param name="req"><see cref="GetLicensesRequest"/></param>
        /// <returns><see cref="GetLicensesResponse"/></returns>
        public GetLicensesResponse GetLicensesSync(GetLicensesRequest req)
        {
            return InternalRequestAsync<GetLicensesResponse>(req, "GetLicenses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置回调URL
        /// 录制回调事件内容参考：https://cloud.tencent.com/document/product/647/81113
        /// 转推回调事件内容参考：https://cloud.tencent.com/document/product/647/88552
        /// </summary>
        /// <param name="req"><see cref="ModifyCallbackUrlRequest"/></param>
        /// <returns><see cref="ModifyCallbackUrlResponse"/></returns>
        public Task<ModifyCallbackUrlResponse> ModifyCallbackUrl(ModifyCallbackUrlRequest req)
        {
            return InternalRequestAsync<ModifyCallbackUrlResponse>(req, "ModifyCallbackUrl");
        }

        /// <summary>
        /// 设置回调URL
        /// 录制回调事件内容参考：https://cloud.tencent.com/document/product/647/81113
        /// 转推回调事件内容参考：https://cloud.tencent.com/document/product/647/88552
        /// </summary>
        /// <param name="req"><see cref="ModifyCallbackUrlRequest"/></param>
        /// <returns><see cref="ModifyCallbackUrlResponse"/></returns>
        public ModifyCallbackUrlResponse ModifyCallbackUrlSync(ModifyCallbackUrlRequest req)
        {
            return InternalRequestAsync<ModifyCallbackUrlResponse>(req, "ModifyCallbackUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice");
        }

        /// <summary>
        /// 用于修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改权限配置
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyRequest"/></param>
        /// <returns><see cref="ModifyPolicyResponse"/></returns>
        public Task<ModifyPolicyResponse> ModifyPolicy(ModifyPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPolicyResponse>(req, "ModifyPolicy");
        }

        /// <summary>
        /// 用于修改权限配置
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyRequest"/></param>
        /// <returns><see cref="ModifyPolicyResponse"/></returns>
        public ModifyPolicyResponse ModifyPolicySync(ModifyPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPolicyResponse>(req, "ModifyPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 用于修改项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用项目共享密钥可动态生成设备登录密钥，登录前无需对设备进行提前注册，适合希望简化业务流程的客户。由于是公共密钥，请务必注意保护项目共享密钥，并及时更新。建议项目共享密钥保存在服务器侧。由服务器生成设备登录密码下发给设备，避免密钥保存在客户端侧产生的密钥泄露风险。
        /// 
        /// 开启项目共享密钥后，对于已注册的设备，仍可使用原设备密码登录。若希望仅能通过共享密钥生成密码登录，请通过云 API 将设备密码更新为"USEPROJECTKEYPWD"。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectSecModeRequest"/></param>
        /// <returns><see cref="ModifyProjectSecModeResponse"/></returns>
        public Task<ModifyProjectSecModeResponse> ModifyProjectSecMode(ModifyProjectSecModeRequest req)
        {
            return InternalRequestAsync<ModifyProjectSecModeResponse>(req, "ModifyProjectSecMode");
        }

        /// <summary>
        /// 使用项目共享密钥可动态生成设备登录密钥，登录前无需对设备进行提前注册，适合希望简化业务流程的客户。由于是公共密钥，请务必注意保护项目共享密钥，并及时更新。建议项目共享密钥保存在服务器侧。由服务器生成设备登录密码下发给设备，避免密钥保存在客户端侧产生的密钥泄露风险。
        /// 
        /// 开启项目共享密钥后，对于已注册的设备，仍可使用原设备密码登录。若希望仅能通过共享密钥生成密码登录，请通过云 API 将设备密码更新为"USEPROJECTKEYPWD"。
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectSecModeRequest"/></param>
        /// <returns><see cref="ModifyProjectSecModeResponse"/></returns>
        public ModifyProjectSecModeResponse ModifyProjectSecModeSync(ModifyProjectSecModeRequest req)
        {
            return InternalRequestAsync<ModifyProjectSecModeResponse>(req, "ModifyProjectSecMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动一个混流转推任务，将 TRTC 房间的多路音视频流混成一路音视频流，编码后推到直播 CDN 或者回推到 TRTC 房间。也支持不转码直接转推 TRTC 房间的单路流。启动成功后，会返回一个 SdkAppid 维度唯一的任务 Id（TaskId）。您需要保存该 TaskId，后续需要依赖此 TaskId 更新和结束任务。
        /// </summary>
        /// <param name="req"><see cref="StartPublishLiveStreamRequest"/></param>
        /// <returns><see cref="StartPublishLiveStreamResponse"/></returns>
        public Task<StartPublishLiveStreamResponse> StartPublishLiveStream(StartPublishLiveStreamRequest req)
        {
            return InternalRequestAsync<StartPublishLiveStreamResponse>(req, "StartPublishLiveStream");
        }

        /// <summary>
        /// 启动一个混流转推任务，将 TRTC 房间的多路音视频流混成一路音视频流，编码后推到直播 CDN 或者回推到 TRTC 房间。也支持不转码直接转推 TRTC 房间的单路流。启动成功后，会返回一个 SdkAppid 维度唯一的任务 Id（TaskId）。您需要保存该 TaskId，后续需要依赖此 TaskId 更新和结束任务。
        /// </summary>
        /// <param name="req"><see cref="StartPublishLiveStreamRequest"/></param>
        /// <returns><see cref="StartPublishLiveStreamResponse"/></returns>
        public StartPublishLiveStreamResponse StartPublishLiveStreamSync(StartPublishLiveStreamRequest req)
        {
            return InternalRequestAsync<StartPublishLiveStreamResponse>(req, "StartPublishLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止指定的混流转推任务。如果没有调用 Stop 接口停止任务，所有参与混流转推的主播离开房间超过MaxIdleTime 设置的时间后，任务也会自动停止。
        /// </summary>
        /// <param name="req"><see cref="StopPublishLiveStreamRequest"/></param>
        /// <returns><see cref="StopPublishLiveStreamResponse"/></returns>
        public Task<StopPublishLiveStreamResponse> StopPublishLiveStream(StopPublishLiveStreamRequest req)
        {
            return InternalRequestAsync<StopPublishLiveStreamResponse>(req, "StopPublishLiveStream");
        }

        /// <summary>
        /// 停止指定的混流转推任务。如果没有调用 Stop 接口停止任务，所有参与混流转推的主播离开房间超过MaxIdleTime 设置的时间后，任务也会自动停止。
        /// </summary>
        /// <param name="req"><see cref="StopPublishLiveStreamRequest"/></param>
        /// <returns><see cref="StopPublishLiveStreamResponse"/></returns>
        public StopPublishLiveStreamResponse StopPublishLiveStreamSync(StopPublishLiveStreamRequest req)
        {
            return InternalRequestAsync<StopPublishLiveStreamResponse>(req, "StopPublishLiveStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
