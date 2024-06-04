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

namespace TencentCloud.Bm.V20180423
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bm.V20180423.Models;

   public class BmClient : AbstractClient{

       private const string endpoint = "bm.tencentcloudapi.com";
       private const string version = "2018-04-23";
       private const string sdkVersion = "SDK_NET_3.0.1020";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 服务器绑定CAM角色，该角色授权访问黑石物理服务器服务，为黑石物理服务器提供了访问资源的权限，如请求服务器的临时证书
        /// </summary>
        /// <param name="req"><see cref="AttachCamRoleRequest"/></param>
        /// <returns><see cref="AttachCamRoleResponse"/></returns>
        public Task<AttachCamRoleResponse> AttachCamRole(AttachCamRoleRequest req)
        {
            return InternalRequestAsync<AttachCamRoleResponse>(req, "AttachCamRole");
        }

        /// <summary>
        /// 服务器绑定CAM角色，该角色授权访问黑石物理服务器服务，为黑石物理服务器提供了访问资源的权限，如请求服务器的临时证书
        /// </summary>
        /// <param name="req"><see cref="AttachCamRoleRequest"/></param>
        /// <returns><see cref="AttachCamRoleResponse"/></returns>
        public AttachCamRoleResponse AttachCamRoleSync(AttachCamRoleRequest req)
        {
            return InternalRequestAsync<AttachCamRoleResponse>(req, "AttachCamRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为预授权规则绑定标签
        /// </summary>
        /// <param name="req"><see cref="BindPsaTagRequest"/></param>
        /// <returns><see cref="BindPsaTagResponse"/></returns>
        public Task<BindPsaTagResponse> BindPsaTag(BindPsaTagRequest req)
        {
            return InternalRequestAsync<BindPsaTagResponse>(req, "BindPsaTag");
        }

        /// <summary>
        /// 为预授权规则绑定标签
        /// </summary>
        /// <param name="req"><see cref="BindPsaTagRequest"/></param>
        /// <returns><see cref="BindPsaTagResponse"/></returns>
        public BindPsaTagResponse BindPsaTagSync(BindPsaTagRequest req)
        {
            return InternalRequestAsync<BindPsaTagResponse>(req, "BindPsaTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买黑石物理机
        /// </summary>
        /// <param name="req"><see cref="BuyDevicesRequest"/></param>
        /// <returns><see cref="BuyDevicesResponse"/></returns>
        public Task<BuyDevicesResponse> BuyDevices(BuyDevicesRequest req)
        {
            return InternalRequestAsync<BuyDevicesResponse>(req, "BuyDevices");
        }

        /// <summary>
        /// 购买黑石物理机
        /// </summary>
        /// <param name="req"><see cref="BuyDevicesRequest"/></param>
        /// <returns><see cref="BuyDevicesResponse"/></returns>
        public BuyDevicesResponse BuyDevicesSync(BuyDevicesRequest req)
        {
            return InternalRequestAsync<BuyDevicesResponse>(req, "BuyDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义镜像<br>
        /// 每个AppId在每个可用区最多保留20个自定义镜像
        /// </summary>
        /// <param name="req"><see cref="CreateCustomImageRequest"/></param>
        /// <returns><see cref="CreateCustomImageResponse"/></returns>
        public Task<CreateCustomImageResponse> CreateCustomImage(CreateCustomImageRequest req)
        {
            return InternalRequestAsync<CreateCustomImageResponse>(req, "CreateCustomImage");
        }

        /// <summary>
        /// 创建自定义镜像<br>
        /// 每个AppId在每个可用区最多保留20个自定义镜像
        /// </summary>
        /// <param name="req"><see cref="CreateCustomImageRequest"/></param>
        /// <returns><see cref="CreateCustomImageResponse"/></returns>
        public CreateCustomImageResponse CreateCustomImageSync(CreateCustomImageRequest req)
        {
            return InternalRequestAsync<CreateCustomImageResponse>(req, "CreateCustomImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建预授权规则
        /// </summary>
        /// <param name="req"><see cref="CreatePsaRegulationRequest"/></param>
        /// <returns><see cref="CreatePsaRegulationResponse"/></returns>
        public Task<CreatePsaRegulationResponse> CreatePsaRegulation(CreatePsaRegulationRequest req)
        {
            return InternalRequestAsync<CreatePsaRegulationResponse>(req, "CreatePsaRegulation");
        }

        /// <summary>
        /// 创建预授权规则
        /// </summary>
        /// <param name="req"><see cref="CreatePsaRegulationRequest"/></param>
        /// <returns><see cref="CreatePsaRegulationResponse"/></returns>
        public CreatePsaRegulationResponse CreatePsaRegulationSync(CreatePsaRegulationRequest req)
        {
            return InternalRequestAsync<CreatePsaRegulationResponse>(req, "CreatePsaRegulation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建黑石竞价实例
        /// </summary>
        /// <param name="req"><see cref="CreateSpotDeviceRequest"/></param>
        /// <returns><see cref="CreateSpotDeviceResponse"/></returns>
        public Task<CreateSpotDeviceResponse> CreateSpotDevice(CreateSpotDeviceRequest req)
        {
            return InternalRequestAsync<CreateSpotDeviceResponse>(req, "CreateSpotDevice");
        }

        /// <summary>
        /// 创建黑石竞价实例
        /// </summary>
        /// <param name="req"><see cref="CreateSpotDeviceRequest"/></param>
        /// <returns><see cref="CreateSpotDeviceResponse"/></returns>
        public CreateSpotDeviceResponse CreateSpotDeviceSync(CreateSpotDeviceRequest req)
        {
            return InternalRequestAsync<CreateSpotDeviceResponse>(req, "CreateSpotDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义脚本
        /// </summary>
        /// <param name="req"><see cref="CreateUserCmdRequest"/></param>
        /// <returns><see cref="CreateUserCmdResponse"/></returns>
        public Task<CreateUserCmdResponse> CreateUserCmd(CreateUserCmdRequest req)
        {
            return InternalRequestAsync<CreateUserCmdResponse>(req, "CreateUserCmd");
        }

        /// <summary>
        /// 创建自定义脚本
        /// </summary>
        /// <param name="req"><see cref="CreateUserCmdRequest"/></param>
        /// <returns><see cref="CreateUserCmdResponse"/></returns>
        public CreateUserCmdResponse CreateUserCmdSync(CreateUserCmdRequest req)
        {
            return InternalRequestAsync<CreateUserCmdResponse>(req, "CreateUserCmd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义镜像<br>
        /// 正用于部署或重装中的镜像被删除后，镜像文件将保留一段时间，直到部署或重装结束
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomImagesRequest"/></param>
        /// <returns><see cref="DeleteCustomImagesResponse"/></returns>
        public Task<DeleteCustomImagesResponse> DeleteCustomImages(DeleteCustomImagesRequest req)
        {
            return InternalRequestAsync<DeleteCustomImagesResponse>(req, "DeleteCustomImages");
        }

        /// <summary>
        /// 删除自定义镜像<br>
        /// 正用于部署或重装中的镜像被删除后，镜像文件将保留一段时间，直到部署或重装结束
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomImagesRequest"/></param>
        /// <returns><see cref="DeleteCustomImagesResponse"/></returns>
        public DeleteCustomImagesResponse DeleteCustomImagesSync(DeleteCustomImagesRequest req)
        {
            return InternalRequestAsync<DeleteCustomImagesResponse>(req, "DeleteCustomImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除预授权规则
        /// </summary>
        /// <param name="req"><see cref="DeletePsaRegulationRequest"/></param>
        /// <returns><see cref="DeletePsaRegulationResponse"/></returns>
        public Task<DeletePsaRegulationResponse> DeletePsaRegulation(DeletePsaRegulationRequest req)
        {
            return InternalRequestAsync<DeletePsaRegulationResponse>(req, "DeletePsaRegulation");
        }

        /// <summary>
        /// 删除预授权规则
        /// </summary>
        /// <param name="req"><see cref="DeletePsaRegulationRequest"/></param>
        /// <returns><see cref="DeletePsaRegulationResponse"/></returns>
        public DeletePsaRegulationResponse DeletePsaRegulationSync(DeletePsaRegulationRequest req)
        {
            return InternalRequestAsync<DeletePsaRegulationResponse>(req, "DeletePsaRegulation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义脚本
        /// </summary>
        /// <param name="req"><see cref="DeleteUserCmdsRequest"/></param>
        /// <returns><see cref="DeleteUserCmdsResponse"/></returns>
        public Task<DeleteUserCmdsResponse> DeleteUserCmds(DeleteUserCmdsRequest req)
        {
            return InternalRequestAsync<DeleteUserCmdsResponse>(req, "DeleteUserCmds");
        }

        /// <summary>
        /// 删除自定义脚本
        /// </summary>
        /// <param name="req"><see cref="DeleteUserCmdsRequest"/></param>
        /// <returns><see cref="DeleteUserCmdsResponse"/></returns>
        public DeleteUserCmdsResponse DeleteUserCmdsSync(DeleteUserCmdsRequest req)
        {
            return InternalRequestAsync<DeleteUserCmdsResponse>(req, "DeleteUserCmds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自定义镜像制作进度
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageProcessRequest"/></param>
        /// <returns><see cref="DescribeCustomImageProcessResponse"/></returns>
        public Task<DescribeCustomImageProcessResponse> DescribeCustomImageProcess(DescribeCustomImageProcessRequest req)
        {
            return InternalRequestAsync<DescribeCustomImageProcessResponse>(req, "DescribeCustomImageProcess");
        }

        /// <summary>
        /// 查询自定义镜像制作进度
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageProcessRequest"/></param>
        /// <returns><see cref="DescribeCustomImageProcessResponse"/></returns>
        public DescribeCustomImageProcessResponse DescribeCustomImageProcessSync(DescribeCustomImageProcessRequest req)
        {
            return InternalRequestAsync<DescribeCustomImageProcessResponse>(req, "DescribeCustomImageProcess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看自定义镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImagesRequest"/></param>
        /// <returns><see cref="DescribeCustomImagesResponse"/></returns>
        public Task<DescribeCustomImagesResponse> DescribeCustomImages(DescribeCustomImagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomImagesResponse>(req, "DescribeCustomImages");
        }

        /// <summary>
        /// 查看自定义镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImagesRequest"/></param>
        /// <returns><see cref="DescribeCustomImagesResponse"/></returns>
        public DescribeCustomImagesResponse DescribeCustomImagesSync(DescribeCustomImagesRequest req)
        {
            return InternalRequestAsync<DescribeCustomImagesResponse>(req, "DescribeCustomImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备类型
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClassRequest"/></param>
        /// <returns><see cref="DescribeDeviceClassResponse"/></returns>
        public Task<DescribeDeviceClassResponse> DescribeDeviceClass(DescribeDeviceClassRequest req)
        {
            return InternalRequestAsync<DescribeDeviceClassResponse>(req, "DescribeDeviceClass");
        }

        /// <summary>
        /// 获取设备类型
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClassRequest"/></param>
        /// <returns><see cref="DescribeDeviceClassResponse"/></returns>
        public DescribeDeviceClassResponse DescribeDeviceClassSync(DescribeDeviceClassRequest req)
        {
            return InternalRequestAsync<DescribeDeviceClassResponse>(req, "DescribeDeviceClass")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询机型支持的RAID方式， 并返回系统盘的分区和逻辑盘的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClassPartitionRequest"/></param>
        /// <returns><see cref="DescribeDeviceClassPartitionResponse"/></returns>
        public Task<DescribeDeviceClassPartitionResponse> DescribeDeviceClassPartition(DescribeDeviceClassPartitionRequest req)
        {
            return InternalRequestAsync<DescribeDeviceClassPartitionResponse>(req, "DescribeDeviceClassPartition");
        }

        /// <summary>
        /// 查询机型支持的RAID方式， 并返回系统盘的分区和逻辑盘的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClassPartitionRequest"/></param>
        /// <returns><see cref="DescribeDeviceClassPartitionResponse"/></returns>
        public DescribeDeviceClassPartitionResponse DescribeDeviceClassPartitionSync(DescribeDeviceClassPartitionRequest req)
        {
            return InternalRequestAsync<DescribeDeviceClassPartitionResponse>(req, "DescribeDeviceClassPartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备硬件配置信息，如 CPU 型号，内存大小，磁盘大小和数量
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceHardwareInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceHardwareInfoResponse"/></returns>
        public Task<DescribeDeviceHardwareInfoResponse> DescribeDeviceHardwareInfo(DescribeDeviceHardwareInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceHardwareInfoResponse>(req, "DescribeDeviceHardwareInfo");
        }

        /// <summary>
        /// 查询设备硬件配置信息，如 CPU 型号，内存大小，磁盘大小和数量
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceHardwareInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceHardwareInfoResponse"/></returns>
        public DescribeDeviceHardwareInfoResponse DescribeDeviceHardwareInfoSync(DescribeDeviceHardwareInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceHardwareInfoResponse>(req, "DescribeDeviceHardwareInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备库存
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInventoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceInventoryResponse"/></returns>
        public Task<DescribeDeviceInventoryResponse> DescribeDeviceInventory(DescribeDeviceInventoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInventoryResponse>(req, "DescribeDeviceInventory");
        }

        /// <summary>
        /// 查询设备库存
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInventoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceInventoryResponse"/></returns>
        public DescribeDeviceInventoryResponse DescribeDeviceInventorySync(DescribeDeviceInventoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInventoryResponse>(req, "DescribeDeviceInventory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备操作日志， 如设备重启，重装，设置密码等操作
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceOperationLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceOperationLogResponse"/></returns>
        public Task<DescribeDeviceOperationLogResponse> DescribeDeviceOperationLog(DescribeDeviceOperationLogRequest req)
        {
            return InternalRequestAsync<DescribeDeviceOperationLogResponse>(req, "DescribeDeviceOperationLog");
        }

        /// <summary>
        /// 查询设备操作日志， 如设备重启，重装，设置密码等操作
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceOperationLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceOperationLogResponse"/></returns>
        public DescribeDeviceOperationLogResponse DescribeDeviceOperationLogSync(DescribeDeviceOperationLogRequest req)
        {
            return InternalRequestAsync<DescribeDeviceOperationLogResponse>(req, "DescribeDeviceOperationLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取物理机的分区格式
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePartitionRequest"/></param>
        /// <returns><see cref="DescribeDevicePartitionResponse"/></returns>
        public Task<DescribeDevicePartitionResponse> DescribeDevicePartition(DescribeDevicePartitionRequest req)
        {
            return InternalRequestAsync<DescribeDevicePartitionResponse>(req, "DescribeDevicePartition");
        }

        /// <summary>
        /// 获取物理机的分区格式
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePartitionRequest"/></param>
        /// <returns><see cref="DescribeDevicePartitionResponse"/></returns>
        public DescribeDevicePartitionResponse DescribeDevicePartitionSync(DescribeDevicePartitionRequest req)
        {
            return InternalRequestAsync<DescribeDevicePartitionResponse>(req, "DescribeDevicePartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务器所在的位置，如机架，上联交换机等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePositionRequest"/></param>
        /// <returns><see cref="DescribeDevicePositionResponse"/></returns>
        public Task<DescribeDevicePositionResponse> DescribeDevicePosition(DescribeDevicePositionRequest req)
        {
            return InternalRequestAsync<DescribeDevicePositionResponse>(req, "DescribeDevicePosition");
        }

        /// <summary>
        /// 查询服务器所在的位置，如机架，上联交换机等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePositionRequest"/></param>
        /// <returns><see cref="DescribeDevicePositionResponse"/></returns>
        public DescribeDevicePositionResponse DescribeDevicePositionSync(DescribeDevicePositionRequest req)
        {
            return InternalRequestAsync<DescribeDevicePositionResponse>(req, "DescribeDevicePosition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务器价格信息，支持设备的批量查找，支持标准机型和弹性机型的混合查找
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePriceInfoRequest"/></param>
        /// <returns><see cref="DescribeDevicePriceInfoResponse"/></returns>
        public Task<DescribeDevicePriceInfoResponse> DescribeDevicePriceInfo(DescribeDevicePriceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDevicePriceInfoResponse>(req, "DescribeDevicePriceInfo");
        }

        /// <summary>
        /// 查询服务器价格信息，支持设备的批量查找，支持标准机型和弹性机型的混合查找
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePriceInfoRequest"/></param>
        /// <returns><see cref="DescribeDevicePriceInfoResponse"/></returns>
        public DescribeDevicePriceInfoResponse DescribeDevicePriceInfoSync(DescribeDevicePriceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDevicePriceInfoResponse>(req, "DescribeDevicePriceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询物理服务器，可以按照实例，业务IP等过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// 查询物理服务器，可以按照实例，业务IP等过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自定义机型部件信息，包括CpuId对应的型号，DiskTypeId对应的磁盘类型
        /// </summary>
        /// <param name="req"><see cref="DescribeHardwareSpecificationRequest"/></param>
        /// <returns><see cref="DescribeHardwareSpecificationResponse"/></returns>
        public Task<DescribeHardwareSpecificationResponse> DescribeHardwareSpecification(DescribeHardwareSpecificationRequest req)
        {
            return InternalRequestAsync<DescribeHardwareSpecificationResponse>(req, "DescribeHardwareSpecification");
        }

        /// <summary>
        /// 查询自定义机型部件信息，包括CpuId对应的型号，DiskTypeId对应的磁盘类型
        /// </summary>
        /// <param name="req"><see cref="DescribeHardwareSpecificationRequest"/></param>
        /// <returns><see cref="DescribeHardwareSpecificationResponse"/></returns>
        public DescribeHardwareSpecificationResponse DescribeHardwareSpecificationSync(DescribeHardwareSpecificationRequest req)
        {
            return InternalRequestAsync<DescribeHardwareSpecificationResponse>(req, "DescribeHardwareSpecification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询托管设备带外信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostedDeviceOutBandInfoRequest"/></param>
        /// <returns><see cref="DescribeHostedDeviceOutBandInfoResponse"/></returns>
        public Task<DescribeHostedDeviceOutBandInfoResponse> DescribeHostedDeviceOutBandInfo(DescribeHostedDeviceOutBandInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostedDeviceOutBandInfoResponse>(req, "DescribeHostedDeviceOutBandInfo");
        }

        /// <summary>
        /// 查询托管设备带外信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostedDeviceOutBandInfoRequest"/></param>
        /// <returns><see cref="DescribeHostedDeviceOutBandInfoResponse"/></returns>
        public DescribeHostedDeviceOutBandInfoResponse DescribeHostedDeviceOutBandInfoSync(DescribeHostedDeviceOutBandInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostedDeviceOutBandInfoResponse>(req, "DescribeHostedDeviceOutBandInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取异步操作状态的完成状态
        /// </summary>
        /// <param name="req"><see cref="DescribeOperationResultRequest"/></param>
        /// <returns><see cref="DescribeOperationResultResponse"/></returns>
        public Task<DescribeOperationResultResponse> DescribeOperationResult(DescribeOperationResultRequest req)
        {
            return InternalRequestAsync<DescribeOperationResultResponse>(req, "DescribeOperationResult");
        }

        /// <summary>
        /// 获取异步操作状态的完成状态
        /// </summary>
        /// <param name="req"><see cref="DescribeOperationResultRequest"/></param>
        /// <returns><see cref="DescribeOperationResultResponse"/></returns>
        public DescribeOperationResultResponse DescribeOperationResultSync(DescribeOperationResultRequest req)
        {
            return InternalRequestAsync<DescribeOperationResultResponse>(req, "DescribeOperationResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定机型所支持的操作系统
        /// </summary>
        /// <param name="req"><see cref="DescribeOsInfoRequest"/></param>
        /// <returns><see cref="DescribeOsInfoResponse"/></returns>
        public Task<DescribeOsInfoResponse> DescribeOsInfo(DescribeOsInfoRequest req)
        {
            return InternalRequestAsync<DescribeOsInfoResponse>(req, "DescribeOsInfo");
        }

        /// <summary>
        /// 查询指定机型所支持的操作系统
        /// </summary>
        /// <param name="req"><see cref="DescribeOsInfoRequest"/></param>
        /// <returns><see cref="DescribeOsInfoResponse"/></returns>
        public DescribeOsInfoResponse DescribeOsInfoSync(DescribeOsInfoRequest req)
        {
            return InternalRequestAsync<DescribeOsInfoResponse>(req, "DescribeOsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取预授权规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePsaRegulationsRequest"/></param>
        /// <returns><see cref="DescribePsaRegulationsResponse"/></returns>
        public Task<DescribePsaRegulationsResponse> DescribePsaRegulations(DescribePsaRegulationsRequest req)
        {
            return InternalRequestAsync<DescribePsaRegulationsResponse>(req, "DescribePsaRegulations");
        }

        /// <summary>
        /// 获取预授权规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePsaRegulationsRequest"/></param>
        /// <returns><see cref="DescribePsaRegulationsResponse"/></returns>
        public DescribePsaRegulationsResponse DescribePsaRegulationsSync(DescribePsaRegulationsRequest req)
        {
            return InternalRequestAsync<DescribePsaRegulationsResponse>(req, "DescribePsaRegulations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询地域以及可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 查询地域以及可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 维修任务配置获取
        /// </summary>
        /// <param name="req"><see cref="DescribeRepairTaskConstantRequest"/></param>
        /// <returns><see cref="DescribeRepairTaskConstantResponse"/></returns>
        public Task<DescribeRepairTaskConstantResponse> DescribeRepairTaskConstant(DescribeRepairTaskConstantRequest req)
        {
            return InternalRequestAsync<DescribeRepairTaskConstantResponse>(req, "DescribeRepairTaskConstant");
        }

        /// <summary>
        /// 维修任务配置获取
        /// </summary>
        /// <param name="req"><see cref="DescribeRepairTaskConstantRequest"/></param>
        /// <returns><see cref="DescribeRepairTaskConstantResponse"/></returns>
        public DescribeRepairTaskConstantResponse DescribeRepairTaskConstantSync(DescribeRepairTaskConstantRequest req)
        {
            return InternalRequestAsync<DescribeRepairTaskConstantResponse>(req, "DescribeRepairTaskConstant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户维修任务列表及详细信息<br>
        /// <br>
        /// TaskStatus（任务状态ID）与状态中文名的对应关系如下：<br>
        /// 1：未授权<br>
        /// 2：处理中<br>
        /// 3：待确认<br>
        /// 4：未授权-暂不处理<br>
        /// 5：已恢复<br>
        /// 6：待确认-未恢复<br>
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo");
        }

        /// <summary>
        /// 获取用户维修任务列表及详细信息<br>
        /// <br>
        /// TaskStatus（任务状态ID）与状态中文名的对应关系如下：<br>
        /// 1：未授权<br>
        /// 2：处理中<br>
        /// 3：待确认<br>
        /// 4：未授权-暂不处理<br>
        /// 5：已恢复<br>
        /// 6：待确认-未恢复<br>
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取维修任务操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskOperationLogRequest"/></param>
        /// <returns><see cref="DescribeTaskOperationLogResponse"/></returns>
        public Task<DescribeTaskOperationLogResponse> DescribeTaskOperationLog(DescribeTaskOperationLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskOperationLogResponse>(req, "DescribeTaskOperationLog");
        }

        /// <summary>
        /// 获取维修任务操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskOperationLogRequest"/></param>
        /// <returns><see cref="DescribeTaskOperationLogResponse"/></returns>
        public DescribeTaskOperationLogResponse DescribeTaskOperationLogSync(DescribeTaskOperationLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskOperationLogResponse>(req, "DescribeTaskOperationLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取自定义脚本任务详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeUserCmdTaskInfoResponse"/></returns>
        public Task<DescribeUserCmdTaskInfoResponse> DescribeUserCmdTaskInfo(DescribeUserCmdTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserCmdTaskInfoResponse>(req, "DescribeUserCmdTaskInfo");
        }

        /// <summary>
        /// 获取自定义脚本任务详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeUserCmdTaskInfoResponse"/></returns>
        public DescribeUserCmdTaskInfoResponse DescribeUserCmdTaskInfoSync(DescribeUserCmdTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserCmdTaskInfoResponse>(req, "DescribeUserCmdTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取自定义脚本任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdTasksRequest"/></param>
        /// <returns><see cref="DescribeUserCmdTasksResponse"/></returns>
        public Task<DescribeUserCmdTasksResponse> DescribeUserCmdTasks(DescribeUserCmdTasksRequest req)
        {
            return InternalRequestAsync<DescribeUserCmdTasksResponse>(req, "DescribeUserCmdTasks");
        }

        /// <summary>
        /// 获取自定义脚本任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdTasksRequest"/></param>
        /// <returns><see cref="DescribeUserCmdTasksResponse"/></returns>
        public DescribeUserCmdTasksResponse DescribeUserCmdTasksSync(DescribeUserCmdTasksRequest req)
        {
            return InternalRequestAsync<DescribeUserCmdTasksResponse>(req, "DescribeUserCmdTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取自定义脚本信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdsRequest"/></param>
        /// <returns><see cref="DescribeUserCmdsResponse"/></returns>
        public Task<DescribeUserCmdsResponse> DescribeUserCmds(DescribeUserCmdsRequest req)
        {
            return InternalRequestAsync<DescribeUserCmdsResponse>(req, "DescribeUserCmds");
        }

        /// <summary>
        /// 获取自定义脚本信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdsRequest"/></param>
        /// <returns><see cref="DescribeUserCmdsResponse"/></returns>
        public DescribeUserCmdsResponse DescribeUserCmdsSync(DescribeUserCmdsRequest req)
        {
            return InternalRequestAsync<DescribeUserCmdsResponse>(req, "DescribeUserCmds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 服务器绑定CAM角色
        /// </summary>
        /// <param name="req"><see cref="DetachCamRoleRequest"/></param>
        /// <returns><see cref="DetachCamRoleResponse"/></returns>
        public Task<DetachCamRoleResponse> DetachCamRole(DetachCamRoleRequest req)
        {
            return InternalRequestAsync<DetachCamRoleResponse>(req, "DetachCamRole");
        }

        /// <summary>
        /// 服务器绑定CAM角色
        /// </summary>
        /// <param name="req"><see cref="DetachCamRoleRequest"/></param>
        /// <returns><see cref="DetachCamRoleResponse"/></returns>
        public DetachCamRoleResponse DetachCamRoleSync(DetachCamRoleRequest req)
        {
            return InternalRequestAsync<DetachCamRoleResponse>(req, "DetachCamRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改自定义镜像名或描述
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomImageAttributeResponse"/></returns>
        public Task<ModifyCustomImageAttributeResponse> ModifyCustomImageAttribute(ModifyCustomImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCustomImageAttributeResponse>(req, "ModifyCustomImageAttribute");
        }

        /// <summary>
        /// 用于修改自定义镜像名或描述
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomImageAttributeResponse"/></returns>
        public ModifyCustomImageAttributeResponse ModifyCustomImageAttributeSync(ModifyCustomImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCustomImageAttributeResponse>(req, "ModifyCustomImageAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改服务器名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceAliasesRequest"/></param>
        /// <returns><see cref="ModifyDeviceAliasesResponse"/></returns>
        public Task<ModifyDeviceAliasesResponse> ModifyDeviceAliases(ModifyDeviceAliasesRequest req)
        {
            return InternalRequestAsync<ModifyDeviceAliasesResponse>(req, "ModifyDeviceAliases");
        }

        /// <summary>
        /// 修改服务器名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceAliasesRequest"/></param>
        /// <returns><see cref="ModifyDeviceAliasesResponse"/></returns>
        public ModifyDeviceAliasesResponse ModifyDeviceAliasesSync(ModifyDeviceAliasesRequest req)
        {
            return InternalRequestAsync<ModifyDeviceAliasesResponse>(req, "ModifyDeviceAliases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改物理机服务器自动续费标志
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDeviceAutoRenewFlagResponse"/></returns>
        public Task<ModifyDeviceAutoRenewFlagResponse> ModifyDeviceAutoRenewFlag(ModifyDeviceAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDeviceAutoRenewFlagResponse>(req, "ModifyDeviceAutoRenewFlag");
        }

        /// <summary>
        /// 修改物理机服务器自动续费标志
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDeviceAutoRenewFlagResponse"/></returns>
        public ModifyDeviceAutoRenewFlagResponse ModifyDeviceAutoRenewFlagSync(ModifyDeviceAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDeviceAutoRenewFlagResponse>(req, "ModifyDeviceAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改物理机内网IP（不重装系统）
        /// </summary>
        /// <param name="req"><see cref="ModifyLanIpRequest"/></param>
        /// <returns><see cref="ModifyLanIpResponse"/></returns>
        public Task<ModifyLanIpResponse> ModifyLanIp(ModifyLanIpRequest req)
        {
            return InternalRequestAsync<ModifyLanIpResponse>(req, "ModifyLanIp");
        }

        /// <summary>
        /// 修改物理机内网IP（不重装系统）
        /// </summary>
        /// <param name="req"><see cref="ModifyLanIpRequest"/></param>
        /// <returns><see cref="ModifyLanIpResponse"/></returns>
        public ModifyLanIpResponse ModifyLanIpSync(ModifyLanIpRequest req)
        {
            return InternalRequestAsync<ModifyLanIpResponse>(req, "ModifyLanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将设备的预付费模式修改为后付费计费模式，支持批量转换。（前提是客户要加入黑石物理机后付费计费的白名单，申请黑石物理机后付费可以联系腾讯云客服）
        /// </summary>
        /// <param name="req"><see cref="ModifyPayModePre2PostRequest"/></param>
        /// <returns><see cref="ModifyPayModePre2PostResponse"/></returns>
        public Task<ModifyPayModePre2PostResponse> ModifyPayModePre2Post(ModifyPayModePre2PostRequest req)
        {
            return InternalRequestAsync<ModifyPayModePre2PostResponse>(req, "ModifyPayModePre2Post");
        }

        /// <summary>
        /// 将设备的预付费模式修改为后付费计费模式，支持批量转换。（前提是客户要加入黑石物理机后付费计费的白名单，申请黑石物理机后付费可以联系腾讯云客服）
        /// </summary>
        /// <param name="req"><see cref="ModifyPayModePre2PostRequest"/></param>
        /// <returns><see cref="ModifyPayModePre2PostResponse"/></returns>
        public ModifyPayModePre2PostResponse ModifyPayModePre2PostSync(ModifyPayModePre2PostRequest req)
        {
            return InternalRequestAsync<ModifyPayModePre2PostResponse>(req, "ModifyPayModePre2Post")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 允许修改规则信息及关联故障类型
        /// </summary>
        /// <param name="req"><see cref="ModifyPsaRegulationRequest"/></param>
        /// <returns><see cref="ModifyPsaRegulationResponse"/></returns>
        public Task<ModifyPsaRegulationResponse> ModifyPsaRegulation(ModifyPsaRegulationRequest req)
        {
            return InternalRequestAsync<ModifyPsaRegulationResponse>(req, "ModifyPsaRegulation");
        }

        /// <summary>
        /// 允许修改规则信息及关联故障类型
        /// </summary>
        /// <param name="req"><see cref="ModifyPsaRegulationRequest"/></param>
        /// <returns><see cref="ModifyPsaRegulationResponse"/></returns>
        public ModifyPsaRegulationResponse ModifyPsaRegulationSync(ModifyPsaRegulationRequest req)
        {
            return InternalRequestAsync<ModifyPsaRegulationResponse>(req, "ModifyPsaRegulation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自定义脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyUserCmdRequest"/></param>
        /// <returns><see cref="ModifyUserCmdResponse"/></returns>
        public Task<ModifyUserCmdResponse> ModifyUserCmd(ModifyUserCmdRequest req)
        {
            return InternalRequestAsync<ModifyUserCmdResponse>(req, "ModifyUserCmd");
        }

        /// <summary>
        /// 修改自定义脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyUserCmdRequest"/></param>
        /// <returns><see cref="ModifyUserCmdResponse"/></returns>
        public ModifyUserCmdResponse ModifyUserCmdSync(ModifyUserCmdRequest req)
        {
            return InternalRequestAsync<ModifyUserCmdResponse>(req, "ModifyUserCmd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁黑石物理机实例：可以销毁物理机列表中的竞价实例，或回收站列表中所有计费模式的实例
        /// </summary>
        /// <param name="req"><see cref="OfflineDevicesRequest"/></param>
        /// <returns><see cref="OfflineDevicesResponse"/></returns>
        public Task<OfflineDevicesResponse> OfflineDevices(OfflineDevicesRequest req)
        {
            return InternalRequestAsync<OfflineDevicesResponse>(req, "OfflineDevices");
        }

        /// <summary>
        /// 销毁黑石物理机实例：可以销毁物理机列表中的竞价实例，或回收站列表中所有计费模式的实例
        /// </summary>
        /// <param name="req"><see cref="OfflineDevicesRequest"/></param>
        /// <returns><see cref="OfflineDevicesResponse"/></returns>
        public OfflineDevicesResponse OfflineDevicesSync(OfflineDevicesRequest req)
        {
            return InternalRequestAsync<OfflineDevicesResponse>(req, "OfflineDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启机器
        /// </summary>
        /// <param name="req"><see cref="RebootDevicesRequest"/></param>
        /// <returns><see cref="RebootDevicesResponse"/></returns>
        public Task<RebootDevicesResponse> RebootDevices(RebootDevicesRequest req)
        {
            return InternalRequestAsync<RebootDevicesResponse>(req, "RebootDevices");
        }

        /// <summary>
        /// 重启机器
        /// </summary>
        /// <param name="req"><see cref="RebootDevicesRequest"/></param>
        /// <returns><see cref="RebootDevicesResponse"/></returns>
        public RebootDevicesResponse RebootDevicesSync(RebootDevicesRequest req)
        {
            return InternalRequestAsync<RebootDevicesResponse>(req, "RebootDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复回收站中的物理机（仅限后付费的物理机）
        /// </summary>
        /// <param name="req"><see cref="RecoverDevicesRequest"/></param>
        /// <returns><see cref="RecoverDevicesResponse"/></returns>
        public Task<RecoverDevicesResponse> RecoverDevices(RecoverDevicesRequest req)
        {
            return InternalRequestAsync<RecoverDevicesResponse>(req, "RecoverDevices");
        }

        /// <summary>
        /// 恢复回收站中的物理机（仅限后付费的物理机）
        /// </summary>
        /// <param name="req"><see cref="RecoverDevicesRequest"/></param>
        /// <returns><see cref="RecoverDevicesResponse"/></returns>
        public RecoverDevicesResponse RecoverDevicesSync(RecoverDevicesRequest req)
        {
            return InternalRequestAsync<RecoverDevicesResponse>(req, "RecoverDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重装操作系统
        /// </summary>
        /// <param name="req"><see cref="ReloadDeviceOsRequest"/></param>
        /// <returns><see cref="ReloadDeviceOsResponse"/></returns>
        public Task<ReloadDeviceOsResponse> ReloadDeviceOs(ReloadDeviceOsRequest req)
        {
            return InternalRequestAsync<ReloadDeviceOsResponse>(req, "ReloadDeviceOs");
        }

        /// <summary>
        /// 重装操作系统
        /// </summary>
        /// <param name="req"><see cref="ReloadDeviceOsRequest"/></param>
        /// <returns><see cref="ReloadDeviceOsResponse"/></returns>
        public ReloadDeviceOsResponse ReloadDeviceOsSync(ReloadDeviceOsRequest req)
        {
            return InternalRequestAsync<ReloadDeviceOsResponse>(req, "ReloadDeviceOs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于操作维修任务<br>
        /// 入参TaskId为维修任务ID<br>
        /// 入参Operate表示对维修任务的操作，支持如下取值：<br>
        /// AuthorizeRepair（授权维修）<br>
        /// Ignore（暂不提醒）<br>
        /// ConfirmRecovered（维修完成后，确认故障恢复）<br>
        /// ConfirmUnRecovered（维修完成后，确认故障未恢复，该操作已不推荐用）<br>
        /// NeedRepairAgain（维修完成后，故障未恢复，需要重新维修，推荐用此操作打回）<br>
        /// 入参OperateRemark仅在Operate为NeedRepairAgain时有效，表示打回重修原因，建议给出打回的具体原因。<br>
        /// <br>
        /// 操作约束（当前任务状态(TaskStatus)->对应可执行的操作）：<br>
        /// 未授权(1)->授权维修；暂不处理<br>
        /// 暂不处理(4)->授权维修<br>
        /// 待确认(3)->确认故障恢复；确认故障未恢复；需要重新维修<br>
        /// 未恢复(6)->确认故障恢复<br>
        /// <br>
        /// 对于Ping不可达故障的任务，还允许：<br>
        /// 未授权->确认故障恢复<br>
        /// 暂不处理->确认故障恢复<br>
        /// <br>
        /// 处理中与已恢复状态的任务不允许进行操作。<br>
        /// <br>
        /// 详细信息请访问：https://cloud.tencent.com/document/product/386/18190
        /// </summary>
        /// <param name="req"><see cref="RepairTaskControlRequest"/></param>
        /// <returns><see cref="RepairTaskControlResponse"/></returns>
        public Task<RepairTaskControlResponse> RepairTaskControl(RepairTaskControlRequest req)
        {
            return InternalRequestAsync<RepairTaskControlResponse>(req, "RepairTaskControl");
        }

        /// <summary>
        /// 此接口用于操作维修任务<br>
        /// 入参TaskId为维修任务ID<br>
        /// 入参Operate表示对维修任务的操作，支持如下取值：<br>
        /// AuthorizeRepair（授权维修）<br>
        /// Ignore（暂不提醒）<br>
        /// ConfirmRecovered（维修完成后，确认故障恢复）<br>
        /// ConfirmUnRecovered（维修完成后，确认故障未恢复，该操作已不推荐用）<br>
        /// NeedRepairAgain（维修完成后，故障未恢复，需要重新维修，推荐用此操作打回）<br>
        /// 入参OperateRemark仅在Operate为NeedRepairAgain时有效，表示打回重修原因，建议给出打回的具体原因。<br>
        /// <br>
        /// 操作约束（当前任务状态(TaskStatus)->对应可执行的操作）：<br>
        /// 未授权(1)->授权维修；暂不处理<br>
        /// 暂不处理(4)->授权维修<br>
        /// 待确认(3)->确认故障恢复；确认故障未恢复；需要重新维修<br>
        /// 未恢复(6)->确认故障恢复<br>
        /// <br>
        /// 对于Ping不可达故障的任务，还允许：<br>
        /// 未授权->确认故障恢复<br>
        /// 暂不处理->确认故障恢复<br>
        /// <br>
        /// 处理中与已恢复状态的任务不允许进行操作。<br>
        /// <br>
        /// 详细信息请访问：https://cloud.tencent.com/document/product/386/18190
        /// </summary>
        /// <param name="req"><see cref="RepairTaskControlRequest"/></param>
        /// <returns><see cref="RepairTaskControlResponse"/></returns>
        public RepairTaskControlResponse RepairTaskControlSync(RepairTaskControlRequest req)
        {
            return InternalRequestAsync<RepairTaskControlResponse>(req, "RepairTaskControl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置服务器密码
        /// </summary>
        /// <param name="req"><see cref="ResetDevicePasswordRequest"/></param>
        /// <returns><see cref="ResetDevicePasswordResponse"/></returns>
        public Task<ResetDevicePasswordResponse> ResetDevicePassword(ResetDevicePasswordRequest req)
        {
            return InternalRequestAsync<ResetDevicePasswordResponse>(req, "ResetDevicePassword");
        }

        /// <summary>
        /// 重置服务器密码
        /// </summary>
        /// <param name="req"><see cref="ResetDevicePasswordRequest"/></param>
        /// <returns><see cref="ResetDevicePasswordResponse"/></returns>
        public ResetDevicePasswordResponse ResetDevicePasswordSync(ResetDevicePasswordRequest req)
        {
            return InternalRequestAsync<ResetDevicePasswordResponse>(req, "ResetDevicePassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 退回物理机至回收站，支持批量退还不同计费模式的物理机（包括预付费、后付费、预付费转后付费）
        /// </summary>
        /// <param name="req"><see cref="ReturnDevicesRequest"/></param>
        /// <returns><see cref="ReturnDevicesResponse"/></returns>
        public Task<ReturnDevicesResponse> ReturnDevices(ReturnDevicesRequest req)
        {
            return InternalRequestAsync<ReturnDevicesResponse>(req, "ReturnDevices");
        }

        /// <summary>
        /// 退回物理机至回收站，支持批量退还不同计费模式的物理机（包括预付费、后付费、预付费转后付费）
        /// </summary>
        /// <param name="req"><see cref="ReturnDevicesRequest"/></param>
        /// <returns><see cref="ReturnDevicesResponse"/></returns>
        public ReturnDevicesResponse ReturnDevicesSync(ReturnDevicesRequest req)
        {
            return InternalRequestAsync<ReturnDevicesResponse>(req, "ReturnDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 运行自定义脚本
        /// </summary>
        /// <param name="req"><see cref="RunUserCmdRequest"/></param>
        /// <returns><see cref="RunUserCmdResponse"/></returns>
        public Task<RunUserCmdResponse> RunUserCmd(RunUserCmdRequest req)
        {
            return InternalRequestAsync<RunUserCmdResponse>(req, "RunUserCmd");
        }

        /// <summary>
        /// 运行自定义脚本
        /// </summary>
        /// <param name="req"><see cref="RunUserCmdRequest"/></param>
        /// <returns><see cref="RunUserCmdResponse"/></returns>
        public RunUserCmdResponse RunUserCmdSync(RunUserCmdRequest req)
        {
            return InternalRequestAsync<RunUserCmdResponse>(req, "RunUserCmd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置带外VPN认证用户密码
        /// </summary>
        /// <param name="req"><see cref="SetOutBandVpnAuthPasswordRequest"/></param>
        /// <returns><see cref="SetOutBandVpnAuthPasswordResponse"/></returns>
        public Task<SetOutBandVpnAuthPasswordResponse> SetOutBandVpnAuthPassword(SetOutBandVpnAuthPasswordRequest req)
        {
            return InternalRequestAsync<SetOutBandVpnAuthPasswordResponse>(req, "SetOutBandVpnAuthPassword");
        }

        /// <summary>
        /// 设置带外VPN认证用户密码
        /// </summary>
        /// <param name="req"><see cref="SetOutBandVpnAuthPasswordRequest"/></param>
        /// <returns><see cref="SetOutBandVpnAuthPasswordResponse"/></returns>
        public SetOutBandVpnAuthPasswordResponse SetOutBandVpnAuthPasswordSync(SetOutBandVpnAuthPasswordRequest req)
        {
            return InternalRequestAsync<SetOutBandVpnAuthPasswordResponse>(req, "SetOutBandVpnAuthPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭服务器
        /// </summary>
        /// <param name="req"><see cref="ShutdownDevicesRequest"/></param>
        /// <returns><see cref="ShutdownDevicesResponse"/></returns>
        public Task<ShutdownDevicesResponse> ShutdownDevices(ShutdownDevicesRequest req)
        {
            return InternalRequestAsync<ShutdownDevicesResponse>(req, "ShutdownDevices");
        }

        /// <summary>
        /// 关闭服务器
        /// </summary>
        /// <param name="req"><see cref="ShutdownDevicesRequest"/></param>
        /// <returns><see cref="ShutdownDevicesResponse"/></returns>
        public ShutdownDevicesResponse ShutdownDevicesSync(ShutdownDevicesRequest req)
        {
            return InternalRequestAsync<ShutdownDevicesResponse>(req, "ShutdownDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启服务器
        /// </summary>
        /// <param name="req"><see cref="StartDevicesRequest"/></param>
        /// <returns><see cref="StartDevicesResponse"/></returns>
        public Task<StartDevicesResponse> StartDevices(StartDevicesRequest req)
        {
            return InternalRequestAsync<StartDevicesResponse>(req, "StartDevices");
        }

        /// <summary>
        /// 开启服务器
        /// </summary>
        /// <param name="req"><see cref="StartDevicesRequest"/></param>
        /// <returns><see cref="StartDevicesResponse"/></returns>
        public StartDevicesResponse StartDevicesSync(StartDevicesRequest req)
        {
            return InternalRequestAsync<StartDevicesResponse>(req, "StartDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除标签与预授权规则的绑定
        /// </summary>
        /// <param name="req"><see cref="UnbindPsaTagRequest"/></param>
        /// <returns><see cref="UnbindPsaTagResponse"/></returns>
        public Task<UnbindPsaTagResponse> UnbindPsaTag(UnbindPsaTagRequest req)
        {
            return InternalRequestAsync<UnbindPsaTagResponse>(req, "UnbindPsaTag");
        }

        /// <summary>
        /// 解除标签与预授权规则的绑定
        /// </summary>
        /// <param name="req"><see cref="UnbindPsaTagRequest"/></param>
        /// <returns><see cref="UnbindPsaTagResponse"/></returns>
        public UnbindPsaTagResponse UnbindPsaTagSync(UnbindPsaTagRequest req)
        {
            return InternalRequestAsync<UnbindPsaTagResponse>(req, "UnbindPsaTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
