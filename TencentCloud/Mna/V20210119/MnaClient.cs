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

namespace TencentCloud.Mna.V20210119
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mna.V20210119.Models;

   public class MnaClient : AbstractClient{

       private const string endpoint = "mna.tencentcloudapi.com";
       private const string version = "2021-01-19";
       private const string sdkVersion = "SDK_NET_3.0.991";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MnaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MnaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 激活硬件设备
        /// </summary>
        /// <param name="req"><see cref="ActivateHardwareRequest"/></param>
        /// <returns><see cref="ActivateHardwareResponse"/></returns>
        public Task<ActivateHardwareResponse> ActivateHardware(ActivateHardwareRequest req)
        {
            return InternalRequestAsync<ActivateHardwareResponse>(req, "ActivateHardware");
        }

        /// <summary>
        /// 激活硬件设备
        /// </summary>
        /// <param name="req"><see cref="ActivateHardwareRequest"/></param>
        /// <returns><see cref="ActivateHardwareResponse"/></returns>
        public ActivateHardwareResponse ActivateHardwareSync(ActivateHardwareRequest req)
        {
            return InternalRequestAsync<ActivateHardwareResponse>(req, "ActivateHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建设备记录
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public Task<AddDeviceResponse> AddDevice(AddDeviceRequest req)
        {
            return InternalRequestAsync<AddDeviceResponse>(req, "AddDevice");
        }

        /// <summary>
        /// 新建设备记录
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public AddDeviceResponse AddDeviceSync(AddDeviceRequest req)
        {
            return InternalRequestAsync<AddDeviceResponse>(req, "AddDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加硬件设备，生成未激活的硬件设备，可支持批量添加
        /// </summary>
        /// <param name="req"><see cref="AddHardwareRequest"/></param>
        /// <returns><see cref="AddHardwareResponse"/></returns>
        public Task<AddHardwareResponse> AddHardware(AddHardwareRequest req)
        {
            return InternalRequestAsync<AddHardwareResponse>(req, "AddHardware");
        }

        /// <summary>
        /// 添加硬件设备，生成未激活的硬件设备，可支持批量添加
        /// </summary>
        /// <param name="req"><see cref="AddHardwareRequest"/></param>
        /// <returns><see cref="AddHardwareResponse"/></returns>
        public AddHardwareResponse AddHardwareSync(AddHardwareRequest req)
        {
            return InternalRequestAsync<AddHardwareResponse>(req, "AddHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口设置和更新预置密钥
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptedKeyRequest"/></param>
        /// <returns><see cref="CreateEncryptedKeyResponse"/></returns>
        public Task<CreateEncryptedKeyResponse> CreateEncryptedKey(CreateEncryptedKeyRequest req)
        {
            return InternalRequestAsync<CreateEncryptedKeyResponse>(req, "CreateEncryptedKey");
        }

        /// <summary>
        /// 通过此接口设置和更新预置密钥
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptedKeyRequest"/></param>
        /// <returns><see cref="CreateEncryptedKeyResponse"/></returns>
        public CreateEncryptedKeyResponse CreateEncryptedKeySync(CreateEncryptedKeyRequest req)
        {
            return InternalRequestAsync<CreateEncryptedKeyResponse>(req, "CreateEncryptedKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移动网络发起Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="CreateQosRequest"/></param>
        /// <returns><see cref="CreateQosResponse"/></returns>
        public Task<CreateQosResponse> CreateQos(CreateQosRequest req)
        {
            return InternalRequestAsync<CreateQosResponse>(req, "CreateQos");
        }

        /// <summary>
        /// 移动网络发起Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="CreateQosRequest"/></param>
        /// <returns><see cref="CreateQosResponse"/></returns>
        public CreateQosResponse CreateQosSync(CreateQosRequest req)
        {
            return InternalRequestAsync<CreateQosResponse>(req, "CreateQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除设备信息
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// 删除设备信息
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 移动网络停止Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="DeleteQosRequest"/></param>
        /// <returns><see cref="DeleteQosResponse"/></returns>
        public Task<DeleteQosResponse> DeleteQos(DeleteQosRequest req)
        {
            return InternalRequestAsync<DeleteQosResponse>(req, "DeleteQos");
        }

        /// <summary>
        /// 移动网络停止Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="DeleteQosRequest"/></param>
        /// <returns><see cref="DeleteQosResponse"/></returns>
        public DeleteQosResponse DeleteQosSync(DeleteQosRequest req)
        {
            return InternalRequestAsync<DeleteQosResponse>(req, "DeleteQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Qos加速状态
        /// </summary>
        /// <param name="req"><see cref="DescribeQosRequest"/></param>
        /// <returns><see cref="DescribeQosResponse"/></returns>
        public Task<DescribeQosResponse> DescribeQos(DescribeQosRequest req)
        {
            return InternalRequestAsync<DescribeQosResponse>(req, "DescribeQos");
        }

        /// <summary>
        /// 获取Qos加速状态
        /// </summary>
        /// <param name="req"><see cref="DescribeQosRequest"/></param>
        /// <returns><see cref="DescribeQosResponse"/></returns>
        public DescribeQosResponse DescribeQosSync(DescribeQosRequest req)
        {
            return InternalRequestAsync<DescribeQosResponse>(req, "DescribeQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过指定设备的ID查找设备详细信息
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public Task<GetDeviceResponse> GetDevice(GetDeviceRequest req)
        {
            return InternalRequestAsync<GetDeviceResponse>(req, "GetDevice");
        }

        /// <summary>
        /// 通过指定设备的ID查找设备详细信息
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public GetDeviceResponse GetDeviceSync(GetDeviceRequest req)
        {
            return InternalRequestAsync<GetDeviceResponse>(req, "GetDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备付费模式
        /// </summary>
        /// <param name="req"><see cref="GetDevicePayModeRequest"/></param>
        /// <returns><see cref="GetDevicePayModeResponse"/></returns>
        public Task<GetDevicePayModeResponse> GetDevicePayMode(GetDevicePayModeRequest req)
        {
            return InternalRequestAsync<GetDevicePayModeResponse>(req, "GetDevicePayMode");
        }

        /// <summary>
        /// 获取设备付费模式
        /// </summary>
        /// <param name="req"><see cref="GetDevicePayModeRequest"/></param>
        /// <returns><see cref="GetDevicePayModeResponse"/></returns>
        public GetDevicePayModeResponse GetDevicePayModeSync(GetDevicePayModeRequest req)
        {
            return InternalRequestAsync<GetDevicePayModeResponse>(req, "GetDevicePayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public Task<GetDevicesResponse> GetDevices(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices");
        }

        /// <summary>
        /// 获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public GetDevicesResponse GetDevicesSync(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取流量包列表
        /// </summary>
        /// <param name="req"><see cref="GetFlowPackagesRequest"/></param>
        /// <returns><see cref="GetFlowPackagesResponse"/></returns>
        public Task<GetFlowPackagesResponse> GetFlowPackages(GetFlowPackagesRequest req)
        {
            return InternalRequestAsync<GetFlowPackagesResponse>(req, "GetFlowPackages");
        }

        /// <summary>
        /// 获取流量包列表
        /// </summary>
        /// <param name="req"><see cref="GetFlowPackagesRequest"/></param>
        /// <returns><see cref="GetFlowPackagesResponse"/></returns>
        public GetFlowPackagesResponse GetFlowPackagesSync(GetFlowPackagesRequest req)
        {
            return InternalRequestAsync<GetFlowPackagesResponse>(req, "GetFlowPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定设备Id，指定时间点数据流量使用情况
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticRequest"/></param>
        /// <returns><see cref="GetFlowStatisticResponse"/></returns>
        public Task<GetFlowStatisticResponse> GetFlowStatistic(GetFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticResponse>(req, "GetFlowStatistic");
        }

        /// <summary>
        /// 获取指定设备Id，指定时间点数据流量使用情况
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticRequest"/></param>
        /// <returns><see cref="GetFlowStatisticResponse"/></returns>
        public GetFlowStatisticResponse GetFlowStatisticSync(GetFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticResponse>(req, "GetFlowStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取厂商硬件列表
        /// </summary>
        /// <param name="req"><see cref="GetHardwareListRequest"/></param>
        /// <returns><see cref="GetHardwareListResponse"/></returns>
        public Task<GetHardwareListResponse> GetHardwareList(GetHardwareListRequest req)
        {
            return InternalRequestAsync<GetHardwareListResponse>(req, "GetHardwareList");
        }

        /// <summary>
        /// 获取厂商硬件列表
        /// </summary>
        /// <param name="req"><see cref="GetHardwareListRequest"/></param>
        /// <returns><see cref="GetHardwareListResponse"/></returns>
        public GetHardwareListResponse GetHardwareListSync(GetHardwareListRequest req)
        {
            return InternalRequestAsync<GetHardwareListResponse>(req, "GetHardwareList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取设备流量统计曲线
        /// </summary>
        /// <param name="req"><see cref="GetMultiFlowStatisticRequest"/></param>
        /// <returns><see cref="GetMultiFlowStatisticResponse"/></returns>
        public Task<GetMultiFlowStatisticResponse> GetMultiFlowStatistic(GetMultiFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetMultiFlowStatisticResponse>(req, "GetMultiFlowStatistic");
        }

        /// <summary>
        /// 批量获取设备流量统计曲线
        /// </summary>
        /// <param name="req"><see cref="GetMultiFlowStatisticRequest"/></param>
        /// <returns><see cref="GetMultiFlowStatisticResponse"/></returns>
        public GetMultiFlowStatisticResponse GetMultiFlowStatisticSync(GetMultiFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetMultiFlowStatisticResponse>(req, "GetMultiFlowStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单设备的实时流量统计指标
        /// </summary>
        /// <param name="req"><see cref="GetNetMonitorRequest"/></param>
        /// <returns><see cref="GetNetMonitorResponse"/></returns>
        public Task<GetNetMonitorResponse> GetNetMonitor(GetNetMonitorRequest req)
        {
            return InternalRequestAsync<GetNetMonitorResponse>(req, "GetNetMonitor");
        }

        /// <summary>
        /// 获取单设备的实时流量统计指标
        /// </summary>
        /// <param name="req"><see cref="GetNetMonitorRequest"/></param>
        /// <returns><see cref="GetNetMonitorResponse"/></returns>
        public GetNetMonitorResponse GetNetMonitorSync(GetNetMonitorRequest req)
        {
            return InternalRequestAsync<GetNetMonitorResponse>(req, "GetNetMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取公钥用于验签
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey");
        }

        /// <summary>
        /// 获取公钥用于验签
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在用量统计页面下载流量数据
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataRequest"/></param>
        /// <returns><see cref="GetStatisticDataResponse"/></returns>
        public Task<GetStatisticDataResponse> GetStatisticData(GetStatisticDataRequest req)
        {
            return InternalRequestAsync<GetStatisticDataResponse>(req, "GetStatisticData");
        }

        /// <summary>
        /// 在用量统计页面下载流量数据
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataRequest"/></param>
        /// <returns><see cref="GetStatisticDataResponse"/></returns>
        public GetStatisticDataResponse GetStatisticDataSync(GetStatisticDataRequest req)
        {
            return InternalRequestAsync<GetStatisticDataResponse>(req, "GetStatisticData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取厂商硬件设备列表
        /// </summary>
        /// <param name="req"><see cref="GetVendorHardwareRequest"/></param>
        /// <returns><see cref="GetVendorHardwareResponse"/></returns>
        public Task<GetVendorHardwareResponse> GetVendorHardware(GetVendorHardwareRequest req)
        {
            return InternalRequestAsync<GetVendorHardwareResponse>(req, "GetVendorHardware");
        }

        /// <summary>
        /// 获取厂商硬件设备列表
        /// </summary>
        /// <param name="req"><see cref="GetVendorHardwareRequest"/></param>
        /// <returns><see cref="GetVendorHardwareResponse"/></returns>
        public GetVendorHardwareResponse GetVendorHardwareSync(GetVendorHardwareRequest req)
        {
            return InternalRequestAsync<GetVendorHardwareResponse>(req, "GetVendorHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 可开启/关闭流量包自动续费，不影响当前周期正在生效的流量包。
        /// </summary>
        /// <param name="req"><see cref="ModifyPackageRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyPackageRenewFlagResponse"/></returns>
        public Task<ModifyPackageRenewFlagResponse> ModifyPackageRenewFlag(ModifyPackageRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyPackageRenewFlagResponse>(req, "ModifyPackageRenewFlag");
        }

        /// <summary>
        /// 可开启/关闭流量包自动续费，不影响当前周期正在生效的流量包。
        /// </summary>
        /// <param name="req"><see cref="ModifyPackageRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyPackageRenewFlagResponse"/></returns>
        public ModifyPackageRenewFlagResponse ModifyPackageRenewFlagSync(ModifyPackageRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyPackageRenewFlagResponse>(req, "ModifyPackageRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买预付费流量包
        /// </summary>
        /// <param name="req"><see cref="OrderFlowPackageRequest"/></param>
        /// <returns><see cref="OrderFlowPackageResponse"/></returns>
        public Task<OrderFlowPackageResponse> OrderFlowPackage(OrderFlowPackageRequest req)
        {
            return InternalRequestAsync<OrderFlowPackageResponse>(req, "OrderFlowPackage");
        }

        /// <summary>
        /// 购买预付费流量包
        /// </summary>
        /// <param name="req"><see cref="OrderFlowPackageRequest"/></param>
        /// <returns><see cref="OrderFlowPackageResponse"/></returns>
        public OrderFlowPackageResponse OrderFlowPackageSync(OrderFlowPackageRequest req)
        {
            return InternalRequestAsync<OrderFlowPackageResponse>(req, "OrderFlowPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新设备信息
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceRequest"/></param>
        /// <returns><see cref="UpdateDeviceResponse"/></returns>
        public Task<UpdateDeviceResponse> UpdateDevice(UpdateDeviceRequest req)
        {
            return InternalRequestAsync<UpdateDeviceResponse>(req, "UpdateDevice");
        }

        /// <summary>
        /// 更新设备信息
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceRequest"/></param>
        /// <returns><see cref="UpdateDeviceResponse"/></returns>
        public UpdateDeviceResponse UpdateDeviceSync(UpdateDeviceRequest req)
        {
            return InternalRequestAsync<UpdateDeviceResponse>(req, "UpdateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新硬件信息
        /// </summary>
        /// <param name="req"><see cref="UpdateHardwareRequest"/></param>
        /// <returns><see cref="UpdateHardwareResponse"/></returns>
        public Task<UpdateHardwareResponse> UpdateHardware(UpdateHardwareRequest req)
        {
            return InternalRequestAsync<UpdateHardwareResponse>(req, "UpdateHardware");
        }

        /// <summary>
        /// 更新硬件信息
        /// </summary>
        /// <param name="req"><see cref="UpdateHardwareRequest"/></param>
        /// <returns><see cref="UpdateHardwareResponse"/></returns>
        public UpdateHardwareResponse UpdateHardwareSync(UpdateHardwareRequest req)
        {
            return InternalRequestAsync<UpdateHardwareResponse>(req, "UpdateHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
