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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MnaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 新建设备记录
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public async Task<AddDeviceResponse> AddDevice(AddDeviceRequest req)
        {
             JsonResponseModel<AddDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建设备记录
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public AddDeviceResponse AddDeviceSync(AddDeviceRequest req)
        {
             JsonResponseModel<AddDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口设置和更新预置密钥
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptedKeyRequest"/></param>
        /// <returns><see cref="CreateEncryptedKeyResponse"/></returns>
        public async Task<CreateEncryptedKeyResponse> CreateEncryptedKey(CreateEncryptedKeyRequest req)
        {
             JsonResponseModel<CreateEncryptedKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEncryptedKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEncryptedKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口设置和更新预置密钥
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptedKeyRequest"/></param>
        /// <returns><see cref="CreateEncryptedKeyResponse"/></returns>
        public CreateEncryptedKeyResponse CreateEncryptedKeySync(CreateEncryptedKeyRequest req)
        {
             JsonResponseModel<CreateEncryptedKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEncryptedKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEncryptedKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动网络发起Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="CreateQosRequest"/></param>
        /// <returns><see cref="CreateQosResponse"/></returns>
        public async Task<CreateQosResponse> CreateQos(CreateQosRequest req)
        {
             JsonResponseModel<CreateQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动网络发起Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="CreateQosRequest"/></param>
        /// <returns><see cref="CreateQosResponse"/></returns>
        public CreateQosResponse CreateQosSync(CreateQosRequest req)
        {
             JsonResponseModel<CreateQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除设备信息
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
        /// 删除设备信息
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
        /// 移动网络停止Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="DeleteQosRequest"/></param>
        /// <returns><see cref="DeleteQosResponse"/></returns>
        public async Task<DeleteQosResponse> DeleteQos(DeleteQosRequest req)
        {
             JsonResponseModel<DeleteQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动网络停止Qos加速过程
        /// </summary>
        /// <param name="req"><see cref="DeleteQosRequest"/></param>
        /// <returns><see cref="DeleteQosResponse"/></returns>
        public DeleteQosResponse DeleteQosSync(DeleteQosRequest req)
        {
             JsonResponseModel<DeleteQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Qos加速状态
        /// </summary>
        /// <param name="req"><see cref="DescribeQosRequest"/></param>
        /// <returns><see cref="DescribeQosResponse"/></returns>
        public async Task<DescribeQosResponse> DescribeQos(DescribeQosRequest req)
        {
             JsonResponseModel<DescribeQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Qos加速状态
        /// </summary>
        /// <param name="req"><see cref="DescribeQosRequest"/></param>
        /// <returns><see cref="DescribeQosResponse"/></returns>
        public DescribeQosResponse DescribeQosSync(DescribeQosRequest req)
        {
             JsonResponseModel<DescribeQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过指定设备的ID查找设备详细信息
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public async Task<GetDeviceResponse> GetDevice(GetDeviceRequest req)
        {
             JsonResponseModel<GetDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过指定设备的ID查找设备详细信息
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public GetDeviceResponse GetDeviceSync(GetDeviceRequest req)
        {
             JsonResponseModel<GetDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public async Task<GetDevicesResponse> GetDevices(GetDevicesRequest req)
        {
             JsonResponseModel<GetDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备信息列表
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public GetDevicesResponse GetDevicesSync(GetDevicesRequest req)
        {
             JsonResponseModel<GetDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定设备Id，指定时间点数据流量使用情况
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticRequest"/></param>
        /// <returns><see cref="GetFlowStatisticResponse"/></returns>
        public async Task<GetFlowStatisticResponse> GetFlowStatistic(GetFlowStatisticRequest req)
        {
             JsonResponseModel<GetFlowStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFlowStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFlowStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定设备Id，指定时间点数据流量使用情况
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticRequest"/></param>
        /// <returns><see cref="GetFlowStatisticResponse"/></returns>
        public GetFlowStatisticResponse GetFlowStatisticSync(GetFlowStatisticRequest req)
        {
             JsonResponseModel<GetFlowStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFlowStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFlowStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取公钥用于验签
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public async Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取公钥用于验签
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
             JsonResponseModel<GetPublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在用量统计页面下载流量数据
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataRequest"/></param>
        /// <returns><see cref="GetStatisticDataResponse"/></returns>
        public async Task<GetStatisticDataResponse> GetStatisticData(GetStatisticDataRequest req)
        {
             JsonResponseModel<GetStatisticDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetStatisticData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStatisticDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在用量统计页面下载流量数据
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataRequest"/></param>
        /// <returns><see cref="GetStatisticDataResponse"/></returns>
        public GetStatisticDataResponse GetStatisticDataSync(GetStatisticDataRequest req)
        {
             JsonResponseModel<GetStatisticDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetStatisticData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStatisticDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新设备信息
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceRequest"/></param>
        /// <returns><see cref="UpdateDeviceResponse"/></returns>
        public async Task<UpdateDeviceResponse> UpdateDevice(UpdateDeviceRequest req)
        {
             JsonResponseModel<UpdateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新设备信息
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceRequest"/></param>
        /// <returns><see cref="UpdateDeviceResponse"/></returns>
        public UpdateDeviceResponse UpdateDeviceSync(UpdateDeviceRequest req)
        {
             JsonResponseModel<UpdateDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
