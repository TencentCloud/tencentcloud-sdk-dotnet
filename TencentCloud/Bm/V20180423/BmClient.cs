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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 服务器绑定CAM角色，该角色授权访问黑石物理服务器服务，为黑石物理服务器提供了访问资源的权限，如请求服务器的临时证书
        /// </summary>
        /// <param name="req"><see cref="AttachCamRoleRequest"/></param>
        /// <returns><see cref="AttachCamRoleResponse"/></returns>
        public async Task<AttachCamRoleResponse> AttachCamRole(AttachCamRoleRequest req)
        {
             JsonResponseModel<AttachCamRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachCamRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCamRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AttachCamRole接口的同步版本，服务器绑定CAM角色，该角色授权访问黑石物理服务器服务，为黑石物理服务器提供了访问资源的权限，如请求服务器的临时证书
        /// </summary>
        /// <param name="req">参考<see cref="AttachCamRoleRequest"/></param>
        /// <returns>参考<see cref="AttachCamRoleResponse"/>实例</returns>
        public AttachCamRoleResponse AttachCamRoleSync(AttachCamRoleRequest req)
        {
             JsonResponseModel<AttachCamRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachCamRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCamRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为预授权规则绑定标签
        /// </summary>
        /// <param name="req"><see cref="BindPsaTagRequest"/></param>
        /// <returns><see cref="BindPsaTagResponse"/></returns>
        public async Task<BindPsaTagResponse> BindPsaTag(BindPsaTagRequest req)
        {
             JsonResponseModel<BindPsaTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindPsaTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindPsaTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BindPsaTag接口的同步版本，为预授权规则绑定标签
        /// </summary>
        /// <param name="req">参考<see cref="BindPsaTagRequest"/></param>
        /// <returns>参考<see cref="BindPsaTagResponse"/>实例</returns>
        public BindPsaTagResponse BindPsaTagSync(BindPsaTagRequest req)
        {
             JsonResponseModel<BindPsaTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindPsaTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindPsaTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买黑石物理机
        /// </summary>
        /// <param name="req"><see cref="BuyDevicesRequest"/></param>
        /// <returns><see cref="BuyDevicesResponse"/></returns>
        public async Task<BuyDevicesResponse> BuyDevices(BuyDevicesRequest req)
        {
             JsonResponseModel<BuyDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BuyDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BuyDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// BuyDevices接口的同步版本，购买黑石物理机
        /// </summary>
        /// <param name="req">参考<see cref="BuyDevicesRequest"/></param>
        /// <returns>参考<see cref="BuyDevicesResponse"/>实例</returns>
        public BuyDevicesResponse BuyDevicesSync(BuyDevicesRequest req)
        {
             JsonResponseModel<BuyDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BuyDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BuyDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义镜像<br>
        /// 每个AppId在每个可用区最多保留20个自定义镜像
        /// </summary>
        /// <param name="req"><see cref="CreateCustomImageRequest"/></param>
        /// <returns><see cref="CreateCustomImageResponse"/></returns>
        public async Task<CreateCustomImageResponse> CreateCustomImage(CreateCustomImageRequest req)
        {
             JsonResponseModel<CreateCustomImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateCustomImage接口的同步版本，创建自定义镜像<br>
        /// 每个AppId在每个可用区最多保留20个自定义镜像
        /// </summary>
        /// <param name="req">参考<see cref="CreateCustomImageRequest"/></param>
        /// <returns>参考<see cref="CreateCustomImageResponse"/>实例</returns>
        public CreateCustomImageResponse CreateCustomImageSync(CreateCustomImageRequest req)
        {
             JsonResponseModel<CreateCustomImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建预授权规则
        /// </summary>
        /// <param name="req"><see cref="CreatePsaRegulationRequest"/></param>
        /// <returns><see cref="CreatePsaRegulationResponse"/></returns>
        public async Task<CreatePsaRegulationResponse> CreatePsaRegulation(CreatePsaRegulationRequest req)
        {
             JsonResponseModel<CreatePsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreatePsaRegulation接口的同步版本，创建预授权规则
        /// </summary>
        /// <param name="req">参考<see cref="CreatePsaRegulationRequest"/></param>
        /// <returns>参考<see cref="CreatePsaRegulationResponse"/>实例</returns>
        public CreatePsaRegulationResponse CreatePsaRegulationSync(CreatePsaRegulationRequest req)
        {
             JsonResponseModel<CreatePsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石竞价实例
        /// </summary>
        /// <param name="req"><see cref="CreateSpotDeviceRequest"/></param>
        /// <returns><see cref="CreateSpotDeviceResponse"/></returns>
        public async Task<CreateSpotDeviceResponse> CreateSpotDevice(CreateSpotDeviceRequest req)
        {
             JsonResponseModel<CreateSpotDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSpotDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSpotDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateSpotDevice接口的同步版本，创建黑石竞价实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateSpotDeviceRequest"/></param>
        /// <returns>参考<see cref="CreateSpotDeviceResponse"/>实例</returns>
        public CreateSpotDeviceResponse CreateSpotDeviceSync(CreateSpotDeviceRequest req)
        {
             JsonResponseModel<CreateSpotDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSpotDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSpotDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义脚本
        /// </summary>
        /// <param name="req"><see cref="CreateUserCmdRequest"/></param>
        /// <returns><see cref="CreateUserCmdResponse"/></returns>
        public async Task<CreateUserCmdResponse> CreateUserCmd(CreateUserCmdRequest req)
        {
             JsonResponseModel<CreateUserCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateUserCmd接口的同步版本，创建自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="CreateUserCmdRequest"/></param>
        /// <returns>参考<see cref="CreateUserCmdResponse"/>实例</returns>
        public CreateUserCmdResponse CreateUserCmdSync(CreateUserCmdRequest req)
        {
             JsonResponseModel<CreateUserCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义镜像<br>
        /// 正用于部署或重装中的镜像被删除后，镜像文件将保留一段时间，直到部署或重装结束
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomImagesRequest"/></param>
        /// <returns><see cref="DeleteCustomImagesResponse"/></returns>
        public async Task<DeleteCustomImagesResponse> DeleteCustomImages(DeleteCustomImagesRequest req)
        {
             JsonResponseModel<DeleteCustomImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteCustomImages接口的同步版本，删除自定义镜像<br>
        /// 正用于部署或重装中的镜像被删除后，镜像文件将保留一段时间，直到部署或重装结束
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCustomImagesRequest"/></param>
        /// <returns>参考<see cref="DeleteCustomImagesResponse"/>实例</returns>
        public DeleteCustomImagesResponse DeleteCustomImagesSync(DeleteCustomImagesRequest req)
        {
             JsonResponseModel<DeleteCustomImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除预授权规则
        /// </summary>
        /// <param name="req"><see cref="DeletePsaRegulationRequest"/></param>
        /// <returns><see cref="DeletePsaRegulationResponse"/></returns>
        public async Task<DeletePsaRegulationResponse> DeletePsaRegulation(DeletePsaRegulationRequest req)
        {
             JsonResponseModel<DeletePsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeletePsaRegulation接口的同步版本，删除预授权规则
        /// </summary>
        /// <param name="req">参考<see cref="DeletePsaRegulationRequest"/></param>
        /// <returns>参考<see cref="DeletePsaRegulationResponse"/>实例</returns>
        public DeletePsaRegulationResponse DeletePsaRegulationSync(DeletePsaRegulationRequest req)
        {
             JsonResponseModel<DeletePsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义脚本
        /// </summary>
        /// <param name="req"><see cref="DeleteUserCmdsRequest"/></param>
        /// <returns><see cref="DeleteUserCmdsResponse"/></returns>
        public async Task<DeleteUserCmdsResponse> DeleteUserCmds(DeleteUserCmdsRequest req)
        {
             JsonResponseModel<DeleteUserCmdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserCmds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserCmdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteUserCmds接口的同步版本，删除自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="DeleteUserCmdsRequest"/></param>
        /// <returns>参考<see cref="DeleteUserCmdsResponse"/>实例</returns>
        public DeleteUserCmdsResponse DeleteUserCmdsSync(DeleteUserCmdsRequest req)
        {
             JsonResponseModel<DeleteUserCmdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserCmds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserCmdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自定义镜像制作进度
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageProcessRequest"/></param>
        /// <returns><see cref="DescribeCustomImageProcessResponse"/></returns>
        public async Task<DescribeCustomImageProcessResponse> DescribeCustomImageProcess(DescribeCustomImageProcessRequest req)
        {
             JsonResponseModel<DescribeCustomImageProcessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomImageProcess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImageProcessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCustomImageProcess接口的同步版本，查询自定义镜像制作进度
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCustomImageProcessRequest"/></param>
        /// <returns>参考<see cref="DescribeCustomImageProcessResponse"/>实例</returns>
        public DescribeCustomImageProcessResponse DescribeCustomImageProcessSync(DescribeCustomImageProcessRequest req)
        {
             JsonResponseModel<DescribeCustomImageProcessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomImageProcess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImageProcessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看自定义镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImagesRequest"/></param>
        /// <returns><see cref="DescribeCustomImagesResponse"/></returns>
        public async Task<DescribeCustomImagesResponse> DescribeCustomImages(DescribeCustomImagesRequest req)
        {
             JsonResponseModel<DescribeCustomImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCustomImages接口的同步版本，查看自定义镜像列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCustomImagesRequest"/></param>
        /// <returns>参考<see cref="DescribeCustomImagesResponse"/>实例</returns>
        public DescribeCustomImagesResponse DescribeCustomImagesSync(DescribeCustomImagesRequest req)
        {
             JsonResponseModel<DescribeCustomImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取获取设备类型
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClassRequest"/></param>
        /// <returns><see cref="DescribeDeviceClassResponse"/></returns>
        public async Task<DescribeDeviceClassResponse> DescribeDeviceClass(DescribeDeviceClassRequest req)
        {
             JsonResponseModel<DescribeDeviceClassResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceClass接口的同步版本，获取获取设备类型
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceClassRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceClassResponse"/>实例</returns>
        public DescribeDeviceClassResponse DescribeDeviceClassSync(DescribeDeviceClassRequest req)
        {
             JsonResponseModel<DescribeDeviceClassResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceClass");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClassResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询机型支持的RAID方式， 并返回系统盘的分区和逻辑盘的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClassPartitionRequest"/></param>
        /// <returns><see cref="DescribeDeviceClassPartitionResponse"/></returns>
        public async Task<DescribeDeviceClassPartitionResponse> DescribeDeviceClassPartition(DescribeDeviceClassPartitionRequest req)
        {
             JsonResponseModel<DescribeDeviceClassPartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceClassPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClassPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceClassPartition接口的同步版本，查询机型支持的RAID方式， 并返回系统盘的分区和逻辑盘的列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceClassPartitionRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceClassPartitionResponse"/>实例</returns>
        public DescribeDeviceClassPartitionResponse DescribeDeviceClassPartitionSync(DescribeDeviceClassPartitionRequest req)
        {
             JsonResponseModel<DescribeDeviceClassPartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceClassPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClassPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备硬件配置信息，如 CPU 型号，内存大小，磁盘大小和数量
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceHardwareInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceHardwareInfoResponse"/></returns>
        public async Task<DescribeDeviceHardwareInfoResponse> DescribeDeviceHardwareInfo(DescribeDeviceHardwareInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceHardwareInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceHardwareInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceHardwareInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceHardwareInfo接口的同步版本，查询设备硬件配置信息，如 CPU 型号，内存大小，磁盘大小和数量
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceHardwareInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceHardwareInfoResponse"/>实例</returns>
        public DescribeDeviceHardwareInfoResponse DescribeDeviceHardwareInfoSync(DescribeDeviceHardwareInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceHardwareInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceHardwareInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceHardwareInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备库存
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInventoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceInventoryResponse"/></returns>
        public async Task<DescribeDeviceInventoryResponse> DescribeDeviceInventory(DescribeDeviceInventoryRequest req)
        {
             JsonResponseModel<DescribeDeviceInventoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceInventory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceInventoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceInventory接口的同步版本，查询设备库存
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceInventoryRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceInventoryResponse"/>实例</returns>
        public DescribeDeviceInventoryResponse DescribeDeviceInventorySync(DescribeDeviceInventoryRequest req)
        {
             JsonResponseModel<DescribeDeviceInventoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceInventory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceInventoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备操作日志， 如设备重启，重装，设置密码等操作
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceOperationLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceOperationLogResponse"/></returns>
        public async Task<DescribeDeviceOperationLogResponse> DescribeDeviceOperationLog(DescribeDeviceOperationLogRequest req)
        {
             JsonResponseModel<DescribeDeviceOperationLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceOperationLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceOperationLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceOperationLog接口的同步版本，查询设备操作日志， 如设备重启，重装，设置密码等操作
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceOperationLogRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceOperationLogResponse"/>实例</returns>
        public DescribeDeviceOperationLogResponse DescribeDeviceOperationLogSync(DescribeDeviceOperationLogRequest req)
        {
             JsonResponseModel<DescribeDeviceOperationLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceOperationLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceOperationLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取物理机的分区格式
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePartitionRequest"/></param>
        /// <returns><see cref="DescribeDevicePartitionResponse"/></returns>
        public async Task<DescribeDevicePartitionResponse> DescribeDevicePartition(DescribeDevicePartitionRequest req)
        {
             JsonResponseModel<DescribeDevicePartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDevicePartition接口的同步版本，获取物理机的分区格式
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicePartitionRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicePartitionResponse"/>实例</returns>
        public DescribeDevicePartitionResponse DescribeDevicePartitionSync(DescribeDevicePartitionRequest req)
        {
             JsonResponseModel<DescribeDevicePartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevicePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务器所在的位置，如机架，上联交换机等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePositionRequest"/></param>
        /// <returns><see cref="DescribeDevicePositionResponse"/></returns>
        public async Task<DescribeDevicePositionResponse> DescribeDevicePosition(DescribeDevicePositionRequest req)
        {
             JsonResponseModel<DescribeDevicePositionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicePosition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePositionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDevicePosition接口的同步版本，查询服务器所在的位置，如机架，上联交换机等信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicePositionRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicePositionResponse"/>实例</returns>
        public DescribeDevicePositionResponse DescribeDevicePositionSync(DescribeDevicePositionRequest req)
        {
             JsonResponseModel<DescribeDevicePositionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevicePosition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePositionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务器价格信息，支持设备的批量查找，支持标准机型和弹性机型的混合查找
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePriceInfoRequest"/></param>
        /// <returns><see cref="DescribeDevicePriceInfoResponse"/></returns>
        public async Task<DescribeDevicePriceInfoResponse> DescribeDevicePriceInfo(DescribeDevicePriceInfoRequest req)
        {
             JsonResponseModel<DescribeDevicePriceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicePriceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePriceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDevicePriceInfo接口的同步版本，查询服务器价格信息，支持设备的批量查找，支持标准机型和弹性机型的混合查找
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicePriceInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicePriceInfoResponse"/>实例</returns>
        public DescribeDevicePriceInfoResponse DescribeDevicePriceInfoSync(DescribeDevicePriceInfoRequest req)
        {
             JsonResponseModel<DescribeDevicePriceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevicePriceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePriceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询物理服务器，可以按照实例，业务IP等过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDevices接口的同步版本，查询物理服务器，可以按照实例，业务IP等过滤
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicesRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicesResponse"/>实例</returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自定义机型部件信息，包括CpuId对应的型号，DiskTypeId对应的磁盘类型
        /// </summary>
        /// <param name="req"><see cref="DescribeHardwareSpecificationRequest"/></param>
        /// <returns><see cref="DescribeHardwareSpecificationResponse"/></returns>
        public async Task<DescribeHardwareSpecificationResponse> DescribeHardwareSpecification(DescribeHardwareSpecificationRequest req)
        {
             JsonResponseModel<DescribeHardwareSpecificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHardwareSpecification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHardwareSpecificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeHardwareSpecification接口的同步版本，查询自定义机型部件信息，包括CpuId对应的型号，DiskTypeId对应的磁盘类型
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHardwareSpecificationRequest"/></param>
        /// <returns>参考<see cref="DescribeHardwareSpecificationResponse"/>实例</returns>
        public DescribeHardwareSpecificationResponse DescribeHardwareSpecificationSync(DescribeHardwareSpecificationRequest req)
        {
             JsonResponseModel<DescribeHardwareSpecificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHardwareSpecification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHardwareSpecificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询托管设备带外信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostedDeviceOutBandInfoRequest"/></param>
        /// <returns><see cref="DescribeHostedDeviceOutBandInfoResponse"/></returns>
        public async Task<DescribeHostedDeviceOutBandInfoResponse> DescribeHostedDeviceOutBandInfo(DescribeHostedDeviceOutBandInfoRequest req)
        {
             JsonResponseModel<DescribeHostedDeviceOutBandInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostedDeviceOutBandInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostedDeviceOutBandInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeHostedDeviceOutBandInfo接口的同步版本，查询托管设备带外信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeHostedDeviceOutBandInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeHostedDeviceOutBandInfoResponse"/>实例</returns>
        public DescribeHostedDeviceOutBandInfoResponse DescribeHostedDeviceOutBandInfoSync(DescribeHostedDeviceOutBandInfoRequest req)
        {
             JsonResponseModel<DescribeHostedDeviceOutBandInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostedDeviceOutBandInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostedDeviceOutBandInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异步操作状态的完成状态
        /// </summary>
        /// <param name="req"><see cref="DescribeOperationResultRequest"/></param>
        /// <returns><see cref="DescribeOperationResultResponse"/></returns>
        public async Task<DescribeOperationResultResponse> DescribeOperationResult(DescribeOperationResultRequest req)
        {
             JsonResponseModel<DescribeOperationResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOperationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOperationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOperationResult接口的同步版本，获取异步操作状态的完成状态
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOperationResultRequest"/></param>
        /// <returns>参考<see cref="DescribeOperationResultResponse"/>实例</returns>
        public DescribeOperationResultResponse DescribeOperationResultSync(DescribeOperationResultRequest req)
        {
             JsonResponseModel<DescribeOperationResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOperationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOperationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定机型所支持的操作系统
        /// </summary>
        /// <param name="req"><see cref="DescribeOsInfoRequest"/></param>
        /// <returns><see cref="DescribeOsInfoResponse"/></returns>
        public async Task<DescribeOsInfoResponse> DescribeOsInfo(DescribeOsInfoRequest req)
        {
             JsonResponseModel<DescribeOsInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOsInfo接口的同步版本，查询指定机型所支持的操作系统
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOsInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeOsInfoResponse"/>实例</returns>
        public DescribeOsInfoResponse DescribeOsInfoSync(DescribeOsInfoRequest req)
        {
             JsonResponseModel<DescribeOsInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取预授权规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribePsaRegulationsRequest"/></param>
        /// <returns><see cref="DescribePsaRegulationsResponse"/></returns>
        public async Task<DescribePsaRegulationsResponse> DescribePsaRegulations(DescribePsaRegulationsRequest req)
        {
             JsonResponseModel<DescribePsaRegulationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePsaRegulations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePsaRegulationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePsaRegulations接口的同步版本，获取预授权规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribePsaRegulationsRequest"/></param>
        /// <returns>参考<see cref="DescribePsaRegulationsResponse"/>实例</returns>
        public DescribePsaRegulationsResponse DescribePsaRegulationsSync(DescribePsaRegulationsRequest req)
        {
             JsonResponseModel<DescribePsaRegulationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePsaRegulations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePsaRegulationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询地域以及可用区
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRegions接口的同步版本，查询地域以及可用区
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeRegionsResponse"/>实例</returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 维修任务配置获取
        /// </summary>
        /// <param name="req"><see cref="DescribeRepairTaskConstantRequest"/></param>
        /// <returns><see cref="DescribeRepairTaskConstantResponse"/></returns>
        public async Task<DescribeRepairTaskConstantResponse> DescribeRepairTaskConstant(DescribeRepairTaskConstantRequest req)
        {
             JsonResponseModel<DescribeRepairTaskConstantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepairTaskConstant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepairTaskConstantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRepairTaskConstant接口的同步版本，维修任务配置获取
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRepairTaskConstantRequest"/></param>
        /// <returns>参考<see cref="DescribeRepairTaskConstantResponse"/>实例</returns>
        public DescribeRepairTaskConstantResponse DescribeRepairTaskConstantSync(DescribeRepairTaskConstantRequest req)
        {
             JsonResponseModel<DescribeRepairTaskConstantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRepairTaskConstant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepairTaskConstantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTaskInfo接口的同步版本，获取用户维修任务列表及详细信息<br>
        /// <br>
        /// TaskStatus（任务状态ID）与状态中文名的对应关系如下：<br>
        /// 1：未授权<br>
        /// 2：处理中<br>
        /// 3：待确认<br>
        /// 4：未授权-暂不处理<br>
        /// 5：已恢复<br>
        /// 6：待确认-未恢复<br>
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskInfoResponse"/>实例</returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取维修任务操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskOperationLogRequest"/></param>
        /// <returns><see cref="DescribeTaskOperationLogResponse"/></returns>
        public async Task<DescribeTaskOperationLogResponse> DescribeTaskOperationLog(DescribeTaskOperationLogRequest req)
        {
             JsonResponseModel<DescribeTaskOperationLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskOperationLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskOperationLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTaskOperationLog接口的同步版本，获取维修任务操作日志
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskOperationLogRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskOperationLogResponse"/>实例</returns>
        public DescribeTaskOperationLogResponse DescribeTaskOperationLogSync(DescribeTaskOperationLogRequest req)
        {
             JsonResponseModel<DescribeTaskOperationLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskOperationLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskOperationLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义脚本任务详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeUserCmdTaskInfoResponse"/></returns>
        public async Task<DescribeUserCmdTaskInfoResponse> DescribeUserCmdTaskInfo(DescribeUserCmdTaskInfoRequest req)
        {
             JsonResponseModel<DescribeUserCmdTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCmdTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUserCmdTaskInfo接口的同步版本，获取自定义脚本任务详细信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUserCmdTaskInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeUserCmdTaskInfoResponse"/>实例</returns>
        public DescribeUserCmdTaskInfoResponse DescribeUserCmdTaskInfoSync(DescribeUserCmdTaskInfoRequest req)
        {
             JsonResponseModel<DescribeUserCmdTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserCmdTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义脚本任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdTasksRequest"/></param>
        /// <returns><see cref="DescribeUserCmdTasksResponse"/></returns>
        public async Task<DescribeUserCmdTasksResponse> DescribeUserCmdTasks(DescribeUserCmdTasksRequest req)
        {
             JsonResponseModel<DescribeUserCmdTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCmdTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUserCmdTasks接口的同步版本，获取自定义脚本任务列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUserCmdTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeUserCmdTasksResponse"/>实例</returns>
        public DescribeUserCmdTasksResponse DescribeUserCmdTasksSync(DescribeUserCmdTasksRequest req)
        {
             JsonResponseModel<DescribeUserCmdTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserCmdTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义脚本信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCmdsRequest"/></param>
        /// <returns><see cref="DescribeUserCmdsResponse"/></returns>
        public async Task<DescribeUserCmdsResponse> DescribeUserCmds(DescribeUserCmdsRequest req)
        {
             JsonResponseModel<DescribeUserCmdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCmds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUserCmds接口的同步版本，获取自定义脚本信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUserCmdsRequest"/></param>
        /// <returns>参考<see cref="DescribeUserCmdsResponse"/>实例</returns>
        public DescribeUserCmdsResponse DescribeUserCmdsSync(DescribeUserCmdsRequest req)
        {
             JsonResponseModel<DescribeUserCmdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserCmds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 服务器绑定CAM角色
        /// </summary>
        /// <param name="req"><see cref="DetachCamRoleRequest"/></param>
        /// <returns><see cref="DetachCamRoleResponse"/></returns>
        public async Task<DetachCamRoleResponse> DetachCamRole(DetachCamRoleRequest req)
        {
             JsonResponseModel<DetachCamRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachCamRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCamRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DetachCamRole接口的同步版本，服务器绑定CAM角色
        /// </summary>
        /// <param name="req">参考<see cref="DetachCamRoleRequest"/></param>
        /// <returns>参考<see cref="DetachCamRoleResponse"/>实例</returns>
        public DetachCamRoleResponse DetachCamRoleSync(DetachCamRoleRequest req)
        {
             JsonResponseModel<DetachCamRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachCamRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCamRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于修改自定义镜像名或描述
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomImageAttributeResponse"/></returns>
        public async Task<ModifyCustomImageAttributeResponse> ModifyCustomImageAttribute(ModifyCustomImageAttributeRequest req)
        {
             JsonResponseModel<ModifyCustomImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCustomImageAttribute接口的同步版本，用于修改自定义镜像名或描述
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCustomImageAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyCustomImageAttributeResponse"/>实例</returns>
        public ModifyCustomImageAttributeResponse ModifyCustomImageAttributeSync(ModifyCustomImageAttributeRequest req)
        {
             JsonResponseModel<ModifyCustomImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改服务器名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceAliasesRequest"/></param>
        /// <returns><see cref="ModifyDeviceAliasesResponse"/></returns>
        public async Task<ModifyDeviceAliasesResponse> ModifyDeviceAliases(ModifyDeviceAliasesRequest req)
        {
             JsonResponseModel<ModifyDeviceAliasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceAliases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceAliasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDeviceAliases接口的同步版本，修改服务器名称
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDeviceAliasesRequest"/></param>
        /// <returns>参考<see cref="ModifyDeviceAliasesResponse"/>实例</returns>
        public ModifyDeviceAliasesResponse ModifyDeviceAliasesSync(ModifyDeviceAliasesRequest req)
        {
             JsonResponseModel<ModifyDeviceAliasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDeviceAliases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceAliasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改物理机服务器自动续费标志
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDeviceAutoRenewFlagResponse"/></returns>
        public async Task<ModifyDeviceAutoRenewFlagResponse> ModifyDeviceAutoRenewFlag(ModifyDeviceAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDeviceAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDeviceAutoRenewFlag接口的同步版本，修改物理机服务器自动续费标志
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDeviceAutoRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyDeviceAutoRenewFlagResponse"/>实例</returns>
        public ModifyDeviceAutoRenewFlagResponse ModifyDeviceAutoRenewFlagSync(ModifyDeviceAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDeviceAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDeviceAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改物理机内网IP（不重装系统）
        /// </summary>
        /// <param name="req"><see cref="ModifyLanIpRequest"/></param>
        /// <returns><see cref="ModifyLanIpResponse"/></returns>
        public async Task<ModifyLanIpResponse> ModifyLanIp(ModifyLanIpRequest req)
        {
             JsonResponseModel<ModifyLanIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLanIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLanIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyLanIp接口的同步版本，修改物理机内网IP（不重装系统）
        /// </summary>
        /// <param name="req">参考<see cref="ModifyLanIpRequest"/></param>
        /// <returns>参考<see cref="ModifyLanIpResponse"/>实例</returns>
        public ModifyLanIpResponse ModifyLanIpSync(ModifyLanIpRequest req)
        {
             JsonResponseModel<ModifyLanIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLanIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLanIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将设备的预付费模式修改为后付费计费模式，支持批量转换。（前提是客户要加入黑石物理机后付费计费的白名单，申请黑石物理机后付费可以联系腾讯云客服）
        /// </summary>
        /// <param name="req"><see cref="ModifyPayModePre2PostRequest"/></param>
        /// <returns><see cref="ModifyPayModePre2PostResponse"/></returns>
        public async Task<ModifyPayModePre2PostResponse> ModifyPayModePre2Post(ModifyPayModePre2PostRequest req)
        {
             JsonResponseModel<ModifyPayModePre2PostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPayModePre2Post");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPayModePre2PostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPayModePre2Post接口的同步版本，将设备的预付费模式修改为后付费计费模式，支持批量转换。（前提是客户要加入黑石物理机后付费计费的白名单，申请黑石物理机后付费可以联系腾讯云客服）
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPayModePre2PostRequest"/></param>
        /// <returns>参考<see cref="ModifyPayModePre2PostResponse"/>实例</returns>
        public ModifyPayModePre2PostResponse ModifyPayModePre2PostSync(ModifyPayModePre2PostRequest req)
        {
             JsonResponseModel<ModifyPayModePre2PostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPayModePre2Post");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPayModePre2PostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 允许修改规则信息及关联故障类型
        /// </summary>
        /// <param name="req"><see cref="ModifyPsaRegulationRequest"/></param>
        /// <returns><see cref="ModifyPsaRegulationResponse"/></returns>
        public async Task<ModifyPsaRegulationResponse> ModifyPsaRegulation(ModifyPsaRegulationRequest req)
        {
             JsonResponseModel<ModifyPsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyPsaRegulation接口的同步版本，允许修改规则信息及关联故障类型
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPsaRegulationRequest"/></param>
        /// <returns>参考<see cref="ModifyPsaRegulationResponse"/>实例</returns>
        public ModifyPsaRegulationResponse ModifyPsaRegulationSync(ModifyPsaRegulationRequest req)
        {
             JsonResponseModel<ModifyPsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改自定义脚本
        /// </summary>
        /// <param name="req"><see cref="ModifyUserCmdRequest"/></param>
        /// <returns><see cref="ModifyUserCmdResponse"/></returns>
        public async Task<ModifyUserCmdResponse> ModifyUserCmd(ModifyUserCmdRequest req)
        {
             JsonResponseModel<ModifyUserCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyUserCmd接口的同步版本，修改自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="ModifyUserCmdRequest"/></param>
        /// <returns>参考<see cref="ModifyUserCmdResponse"/>实例</returns>
        public ModifyUserCmdResponse ModifyUserCmdSync(ModifyUserCmdRequest req)
        {
             JsonResponseModel<ModifyUserCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁黑石物理机实例：可以销毁物理机列表中的竞价实例，或回收站列表中所有计费模式的实例
        /// </summary>
        /// <param name="req"><see cref="OfflineDevicesRequest"/></param>
        /// <returns><see cref="OfflineDevicesResponse"/></returns>
        public async Task<OfflineDevicesResponse> OfflineDevices(OfflineDevicesRequest req)
        {
             JsonResponseModel<OfflineDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OfflineDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// OfflineDevices接口的同步版本，销毁黑石物理机实例：可以销毁物理机列表中的竞价实例，或回收站列表中所有计费模式的实例
        /// </summary>
        /// <param name="req">参考<see cref="OfflineDevicesRequest"/></param>
        /// <returns>参考<see cref="OfflineDevicesResponse"/>实例</returns>
        public OfflineDevicesResponse OfflineDevicesSync(OfflineDevicesRequest req)
        {
             JsonResponseModel<OfflineDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OfflineDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启机器
        /// </summary>
        /// <param name="req"><see cref="RebootDevicesRequest"/></param>
        /// <returns><see cref="RebootDevicesResponse"/></returns>
        public async Task<RebootDevicesResponse> RebootDevices(RebootDevicesRequest req)
        {
             JsonResponseModel<RebootDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RebootDevices接口的同步版本，重启机器
        /// </summary>
        /// <param name="req">参考<see cref="RebootDevicesRequest"/></param>
        /// <returns>参考<see cref="RebootDevicesResponse"/>实例</returns>
        public RebootDevicesResponse RebootDevicesSync(RebootDevicesRequest req)
        {
             JsonResponseModel<RebootDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebootDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复回收站中的物理机（仅限后付费的物理机）
        /// </summary>
        /// <param name="req"><see cref="RecoverDevicesRequest"/></param>
        /// <returns><see cref="RecoverDevicesResponse"/></returns>
        public async Task<RecoverDevicesResponse> RecoverDevices(RecoverDevicesRequest req)
        {
             JsonResponseModel<RecoverDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RecoverDevices接口的同步版本，恢复回收站中的物理机（仅限后付费的物理机）
        /// </summary>
        /// <param name="req">参考<see cref="RecoverDevicesRequest"/></param>
        /// <returns>参考<see cref="RecoverDevicesResponse"/>实例</returns>
        public RecoverDevicesResponse RecoverDevicesSync(RecoverDevicesRequest req)
        {
             JsonResponseModel<RecoverDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于操作维修任务<br>
        /// 入参TaskId为维修任务ID<br>
        /// 入参Operate表示对维修任务的操作，支持如下取值：<br>
        /// AuthorizeRepair（授权维修）<br>
        /// Ignore（暂不提醒）<br>
        /// ConfirmRecovered（维修完成后，确认故障恢复）<br>
        /// ConfirmUnRecovered（维修完成后，确认故障未恢复）<br>
        /// <br>
        /// 操作约束（当前任务状态(TaskStatus)->对应可执行的操作）：<br>
        /// 未授权(1)->授权维修；暂不处理<br>
        /// 暂不处理(4)->授权维修<br>
        /// 待确认(3)->确认故障恢复；确认故障未恢复<br>
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
        public async Task<RepairTaskControlResponse> RepairTaskControl(RepairTaskControlRequest req)
        {
             JsonResponseModel<RepairTaskControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RepairTaskControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RepairTaskControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RepairTaskControl接口的同步版本，此接口用于操作维修任务<br>
        /// 入参TaskId为维修任务ID<br>
        /// 入参Operate表示对维修任务的操作，支持如下取值：<br>
        /// AuthorizeRepair（授权维修）<br>
        /// Ignore（暂不提醒）<br>
        /// ConfirmRecovered（维修完成后，确认故障恢复）<br>
        /// ConfirmUnRecovered（维修完成后，确认故障未恢复）<br>
        /// <br>
        /// 操作约束（当前任务状态(TaskStatus)->对应可执行的操作）：<br>
        /// 未授权(1)->授权维修；暂不处理<br>
        /// 暂不处理(4)->授权维修<br>
        /// 待确认(3)->确认故障恢复；确认故障未恢复<br>
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
        /// <param name="req">参考<see cref="RepairTaskControlRequest"/></param>
        /// <returns>参考<see cref="RepairTaskControlResponse"/>实例</returns>
        public RepairTaskControlResponse RepairTaskControlSync(RepairTaskControlRequest req)
        {
             JsonResponseModel<RepairTaskControlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RepairTaskControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RepairTaskControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置服务器密码
        /// </summary>
        /// <param name="req"><see cref="ResetDevicePasswordRequest"/></param>
        /// <returns><see cref="ResetDevicePasswordResponse"/></returns>
        public async Task<ResetDevicePasswordResponse> ResetDevicePassword(ResetDevicePasswordRequest req)
        {
             JsonResponseModel<ResetDevicePasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDevicePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDevicePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResetDevicePassword接口的同步版本，重置服务器密码
        /// </summary>
        /// <param name="req">参考<see cref="ResetDevicePasswordRequest"/></param>
        /// <returns>参考<see cref="ResetDevicePasswordResponse"/>实例</returns>
        public ResetDevicePasswordResponse ResetDevicePasswordSync(ResetDevicePasswordRequest req)
        {
             JsonResponseModel<ResetDevicePasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetDevicePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDevicePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 退回物理机至回收站，支持批量退还不同计费模式的物理机（包括预付费、后付费、预付费转后付费）
        /// </summary>
        /// <param name="req"><see cref="ReturnDevicesRequest"/></param>
        /// <returns><see cref="ReturnDevicesResponse"/></returns>
        public async Task<ReturnDevicesResponse> ReturnDevices(ReturnDevicesRequest req)
        {
             JsonResponseModel<ReturnDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReturnDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReturnDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ReturnDevices接口的同步版本，退回物理机至回收站，支持批量退还不同计费模式的物理机（包括预付费、后付费、预付费转后付费）
        /// </summary>
        /// <param name="req">参考<see cref="ReturnDevicesRequest"/></param>
        /// <returns>参考<see cref="ReturnDevicesResponse"/>实例</returns>
        public ReturnDevicesResponse ReturnDevicesSync(ReturnDevicesRequest req)
        {
             JsonResponseModel<ReturnDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReturnDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReturnDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行自定义脚本
        /// </summary>
        /// <param name="req"><see cref="RunUserCmdRequest"/></param>
        /// <returns><see cref="RunUserCmdResponse"/></returns>
        public async Task<RunUserCmdResponse> RunUserCmd(RunUserCmdRequest req)
        {
             JsonResponseModel<RunUserCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RunUserCmd接口的同步版本，运行自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="RunUserCmdRequest"/></param>
        /// <returns>参考<see cref="RunUserCmdResponse"/>实例</returns>
        public RunUserCmdResponse RunUserCmdSync(RunUserCmdRequest req)
        {
             JsonResponseModel<RunUserCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置带外VPN认证用户密码
        /// </summary>
        /// <param name="req"><see cref="SetOutBandVpnAuthPasswordRequest"/></param>
        /// <returns><see cref="SetOutBandVpnAuthPasswordResponse"/></returns>
        public async Task<SetOutBandVpnAuthPasswordResponse> SetOutBandVpnAuthPassword(SetOutBandVpnAuthPasswordRequest req)
        {
             JsonResponseModel<SetOutBandVpnAuthPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetOutBandVpnAuthPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOutBandVpnAuthPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetOutBandVpnAuthPassword接口的同步版本，设置带外VPN认证用户密码
        /// </summary>
        /// <param name="req">参考<see cref="SetOutBandVpnAuthPasswordRequest"/></param>
        /// <returns>参考<see cref="SetOutBandVpnAuthPasswordResponse"/>实例</returns>
        public SetOutBandVpnAuthPasswordResponse SetOutBandVpnAuthPasswordSync(SetOutBandVpnAuthPasswordRequest req)
        {
             JsonResponseModel<SetOutBandVpnAuthPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetOutBandVpnAuthPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetOutBandVpnAuthPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭服务器
        /// </summary>
        /// <param name="req"><see cref="ShutdownDevicesRequest"/></param>
        /// <returns><see cref="ShutdownDevicesResponse"/></returns>
        public async Task<ShutdownDevicesResponse> ShutdownDevices(ShutdownDevicesRequest req)
        {
             JsonResponseModel<ShutdownDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ShutdownDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShutdownDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ShutdownDevices接口的同步版本，关闭服务器
        /// </summary>
        /// <param name="req">参考<see cref="ShutdownDevicesRequest"/></param>
        /// <returns>参考<see cref="ShutdownDevicesResponse"/>实例</returns>
        public ShutdownDevicesResponse ShutdownDevicesSync(ShutdownDevicesRequest req)
        {
             JsonResponseModel<ShutdownDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ShutdownDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ShutdownDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启服务器
        /// </summary>
        /// <param name="req"><see cref="StartDevicesRequest"/></param>
        /// <returns><see cref="StartDevicesResponse"/></returns>
        public async Task<StartDevicesResponse> StartDevices(StartDevicesRequest req)
        {
             JsonResponseModel<StartDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartDevices接口的同步版本，开启服务器
        /// </summary>
        /// <param name="req">参考<see cref="StartDevicesRequest"/></param>
        /// <returns>参考<see cref="StartDevicesResponse"/>实例</returns>
        public StartDevicesResponse StartDevicesSync(StartDevicesRequest req)
        {
             JsonResponseModel<StartDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除标签与预授权规则的绑定
        /// </summary>
        /// <param name="req"><see cref="UnbindPsaTagRequest"/></param>
        /// <returns><see cref="UnbindPsaTagResponse"/></returns>
        public async Task<UnbindPsaTagResponse> UnbindPsaTag(UnbindPsaTagRequest req)
        {
             JsonResponseModel<UnbindPsaTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindPsaTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindPsaTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UnbindPsaTag接口的同步版本，解除标签与预授权规则的绑定
        /// </summary>
        /// <param name="req">参考<see cref="UnbindPsaTagRequest"/></param>
        /// <returns>参考<see cref="UnbindPsaTagResponse"/>实例</returns>
        public UnbindPsaTagResponse UnbindPsaTagSync(UnbindPsaTagRequest req)
        {
             JsonResponseModel<UnbindPsaTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindPsaTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindPsaTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
