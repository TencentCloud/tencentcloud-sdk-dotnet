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

namespace TencentCloud.Redis.V20180412
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Redis.V20180412.Models;

   public class RedisClient : AbstractClient{

       private const string endpoint = "redis.tencentcloudapi.com";
       private const string version = "2018-04-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RedisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RedisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 回收站实例立即下线
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public async Task<CleanUpInstanceResponse> CleanUpInstance(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CleanUpInstance接口的同步版本，回收站实例立即下线
        /// </summary>
        /// <param name="req">参考<see cref="CleanUpInstanceRequest"/></param>
        /// <returns>参考<see cref="CleanUpInstanceResponse"/>实例</returns>
        public CleanUpInstanceResponse CleanUpInstanceSync(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 清空Redis实例的实例数据。
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public async Task<ClearInstanceResponse> ClearInstance(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ClearInstance接口的同步版本，清空Redis实例的实例数据。
        /// </summary>
        /// <param name="req">参考<see cref="ClearInstanceRequest"/></param>
        /// <returns>参考<see cref="ClearInstanceResponse"/>实例</returns>
        public ClearInstanceResponse ClearInstanceSync(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建实例子账号
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public async Task<CreateInstanceAccountResponse> CreateInstanceAccount(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateInstanceAccount接口的同步版本，创建实例子账号
        /// </summary>
        /// <param name="req">参考<see cref="CreateInstanceAccountRequest"/></param>
        /// <returns>参考<see cref="CreateInstanceAccountResponse"/>实例</returns>
        public CreateInstanceAccountResponse CreateInstanceAccountSync(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建redis实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateInstances接口的同步版本，创建redis实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateInstancesRequest"/></param>
        /// <returns>参考<see cref="CreateInstancesResponse"/>实例</returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例子账号
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public async Task<DeleteInstanceAccountResponse> DeleteInstanceAccount(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteInstanceAccount接口的同步版本，删除实例子账号
        /// </summary>
        /// <param name="req">参考<see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns>参考<see cref="DeleteInstanceAccountResponse"/>实例</returns>
        public DeleteInstanceAccountResponse DeleteInstanceAccountSync(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取备份配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public async Task<DescribeAutoBackupConfigResponse> DescribeAutoBackupConfig(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAutoBackupConfig接口的同步版本，获取备份配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeAutoBackupConfigResponse"/>实例</returns>
        public DescribeAutoBackupConfigResponse DescribeAutoBackupConfigSync(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份Rdb下载地址(接口灰度中，需要加白名单使用)
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public async Task<DescribeBackupUrlResponse> DescribeBackupUrl(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBackupUrl接口的同步版本，查询备份Rdb下载地址(接口灰度中，需要加白名单使用)
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupUrlRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupUrlResponse"/>实例</returns>
        public DescribeBackupUrlResponse DescribeBackupUrlSync(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看实例子账号信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public async Task<DescribeInstanceAccountResponse> DescribeInstanceAccount(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceAccount接口的同步版本，查看实例子账号信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceAccountResponse"/>实例</returns>
        public DescribeInstanceAccountResponse DescribeInstanceAccountSync(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 CRS 实例备份列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public async Task<DescribeInstanceBackupsResponse> DescribeInstanceBackups(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceBackups接口的同步版本，查询 CRS 实例备份列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceBackupsResponse"/>实例</returns>
        public DescribeInstanceBackupsResponse DescribeInstanceBackupsSync(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例DTS信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceDTSInfoResponse"/></returns>
        public async Task<DescribeInstanceDTSInfoResponse> DescribeInstanceDTSInfo(DescribeInstanceDTSInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceDTSInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDTSInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDTSInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceDTSInfo接口的同步版本，查询实例DTS信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceDTSInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceDTSInfoResponse"/>实例</returns>
        public DescribeInstanceDTSInfoResponse DescribeInstanceDTSInfoSync(DescribeInstanceDTSInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceDTSInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDTSInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDTSInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public async Task<DescribeInstanceDealDetailResponse> DescribeInstanceDealDetail(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceDealDetail接口的同步版本，查询订单信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceDealDetailResponse"/>实例</returns>
        public DescribeInstanceDealDetailResponse DescribeInstanceDealDetailSync(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例大Key
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyResponse> DescribeInstanceMonitorBigKey(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorBigKey接口的同步版本，查询实例大Key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorBigKeyResponse"/>实例</returns>
        public DescribeInstanceMonitorBigKeyResponse DescribeInstanceMonitorBigKeySync(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例大Key大小分布
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeySizeDistResponse> DescribeInstanceMonitorBigKeySizeDist(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorBigKeySizeDist接口的同步版本，查询实例大Key大小分布
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/>实例</returns>
        public DescribeInstanceMonitorBigKeySizeDistResponse DescribeInstanceMonitorBigKeySizeDistSync(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例大Key类型分布
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyTypeDistResponse> DescribeInstanceMonitorBigKeyTypeDist(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorBigKeyTypeDist接口的同步版本，查询实例大Key类型分布
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/>实例</returns>
        public DescribeInstanceMonitorBigKeyTypeDistResponse DescribeInstanceMonitorBigKeyTypeDistSync(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例热Key
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorHotKeyResponse> DescribeInstanceMonitorHotKey(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorHotKey接口的同步版本，查询实例热Key
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorHotKeyResponse"/>实例</returns>
        public DescribeInstanceMonitorHotKeyResponse DescribeInstanceMonitorHotKeySync(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问来源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public async Task<DescribeInstanceMonitorSIPResponse> DescribeInstanceMonitorSIP(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorSIP接口的同步版本，查询实例访问来源信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorSIPResponse"/>实例</returns>
        public DescribeInstanceMonitorSIPResponse DescribeInstanceMonitorSIPSync(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例大Key大小分布
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorTookDistResponse> DescribeInstanceMonitorTookDist(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorTookDist接口的同步版本，查询实例大Key大小分布
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorTookDistResponse"/>实例</returns>
        public DescribeInstanceMonitorTookDistResponse DescribeInstanceMonitorTookDistSync(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例访问命令
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdResponse> DescribeInstanceMonitorTopNCmd(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorTopNCmd接口的同步版本，查询实例访问命令
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorTopNCmdResponse"/>实例</returns>
        public DescribeInstanceMonitorTopNCmdResponse DescribeInstanceMonitorTopNCmdSync(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例CPU耗时
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdTookResponse> DescribeInstanceMonitorTopNCmdTook(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceMonitorTopNCmdTook接口的同步版本，查询实例CPU耗时
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceMonitorTopNCmdTookResponse"/>实例</returns>
        public DescribeInstanceMonitorTopNCmdTookResponse DescribeInstanceMonitorTopNCmdTookSync(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询参数修改历史列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public async Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceParamRecords接口的同步版本，查询参数修改历史列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceParamRecordsResponse"/>实例</returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public async Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceParams接口的同步版本，查询实例参数列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceParamsResponse"/>实例</returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public async Task<DescribeInstanceSecurityGroupResponse> DescribeInstanceSecurityGroup(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceSecurityGroup接口的同步版本，查询实例安全组信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceSecurityGroupResponse"/>实例</returns>
        public DescribeInstanceSecurityGroupResponse DescribeInstanceSecurityGroupSync(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群版实例分片信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public async Task<DescribeInstanceShardsResponse> DescribeInstanceShards(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstanceShards接口的同步版本，获取集群版实例分片信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceShardsResponse"/>实例</returns>
        public DescribeInstanceShardsResponse DescribeInstanceShardsSync(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Redis实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInstances接口的同步版本，查询Redis实例列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesResponse"/>实例</returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口查询指定可用区和实例类型下 Redis 的售卖规格， 如果用户不在购买白名单中，将不能查询该可用区或该类型的售卖规格详情。申请购买某地域白名单可以提交工单
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public async Task<DescribeProductInfoResponse> DescribeProductInfo(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProductInfo接口的同步版本，本接口查询指定可用区和实例类型下 Redis 的售卖规格， 如果用户不在购买白名单中，将不能查询该可用区或该类型的售卖规格详情。申请购买某地域白名单可以提交工单
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProductInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeProductInfoResponse"/>实例</returns>
        public DescribeProductInfoResponse DescribeProductInfoSync(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupResponse> DescribeProjectSecurityGroup(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProjectSecurityGroup接口的同步版本，查询项目安全组信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns>参考<see cref="DescribeProjectSecurityGroupResponse"/>实例</returns>
        public DescribeProjectSecurityGroupResponse DescribeProjectSecurityGroupSync(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例慢查询记录
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public async Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSlowLog接口的同步版本，查询实例慢查询记录
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSlowLogRequest"/></param>
        /// <returns>参考<see cref="DescribeSlowLogResponse"/>实例</returns>
        public DescribeSlowLogResponse DescribeSlowLogSync(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询任务结果
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
        /// DescribeTaskInfo接口的同步版本，用于查询任务结果
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
        /// 查询任务列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public async Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTaskList接口的同步版本，查询任务列表信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskListRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskListResponse"/>实例</returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按量计费实例销毁
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public async Task<DestroyPostpaidInstanceResponse> DestroyPostpaidInstance(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DestroyPostpaidInstance接口的同步版本，按量计费实例销毁
        /// </summary>
        /// <param name="req">参考<see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns>参考<see cref="DestroyPostpaidInstanceResponse"/>实例</returns>
        public DestroyPostpaidInstanceResponse DestroyPostpaidInstanceSync(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 包年包月实例退还
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public async Task<DestroyPrepaidInstanceResponse> DestroyPrepaidInstance(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DestroyPrepaidInstance接口的同步版本，包年包月实例退还
        /// </summary>
        /// <param name="req">参考<see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns>参考<see cref="DestroyPrepaidInstanceResponse"/>实例</returns>
        public DestroyPrepaidInstanceResponse DestroyPrepaidInstanceSync(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用读写分离
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public async Task<DisableReplicaReadonlyResponse> DisableReplicaReadonly(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableReplicaReadonly接口的同步版本，禁用读写分离
        /// </summary>
        /// <param name="req">参考<see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns>参考<see cref="DisableReplicaReadonlyResponse"/>实例</returns>
        public DisableReplicaReadonlyResponse DisableReplicaReadonlySync(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用读写分离
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public async Task<EnableReplicaReadonlyResponse> EnableReplicaReadonly(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableReplicaReadonly接口的同步版本，启用读写分离
        /// </summary>
        /// <param name="req">参考<see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns>参考<see cref="EnableReplicaReadonlyResponse"/>实例</returns>
        public EnableReplicaReadonlyResponse EnableReplicaReadonlySync(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手动备份Redis实例
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public async Task<ManualBackupInstanceResponse> ManualBackupInstance(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ManualBackupInstance接口的同步版本，手动备份Redis实例
        /// </summary>
        /// <param name="req">参考<see cref="ManualBackupInstanceRequest"/></param>
        /// <returns>参考<see cref="ManualBackupInstanceResponse"/>实例</returns>
        public ManualBackupInstanceResponse ManualBackupInstanceSync(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改redis密码
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public async Task<ModfiyInstancePasswordResponse> ModfiyInstancePassword(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModfiyInstancePassword接口的同步版本，修改redis密码
        /// </summary>
        /// <param name="req">参考<see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns>参考<see cref="ModfiyInstancePasswordResponse"/>实例</returns>
        public ModfiyInstancePasswordResponse ModfiyInstancePasswordSync(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置自动备份时间
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public async Task<ModifyAutoBackupConfigResponse> ModifyAutoBackupConfig(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAutoBackupConfig接口的同步版本，设置自动备份时间
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyAutoBackupConfigResponse"/>实例</returns>
        public ModifyAutoBackupConfigResponse ModifyAutoBackupConfigSync(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例相关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstance接口的同步版本，修改实例相关信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstanceRequest"/></param>
        /// <returns>参考<see cref="ModifyInstanceResponse"/>实例</returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例子账号
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public async Task<ModifyInstanceAccountResponse> ModifyInstanceAccount(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstanceAccount接口的同步版本，修改实例子账号
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns>参考<see cref="ModifyInstanceAccountResponse"/>实例</returns>
        public ModifyInstanceAccountResponse ModifyInstanceAccountSync(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例参数
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public async Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstanceParams接口的同步版本，修改实例参数
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns>参考<see cref="ModifyInstanceParamsResponse"/>实例</returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例网络配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public async Task<ModifyNetworkConfigResponse> ModifyNetworkConfig(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyNetworkConfig接口的同步版本，修改实例网络配置
        /// </summary>
        /// <param name="req">参考<see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyNetworkConfigResponse"/>实例</returns>
        public ModifyNetworkConfigResponse ModifyNetworkConfigSync(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费实例
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public async Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RenewInstance接口的同步版本，续费实例
        /// </summary>
        /// <param name="req">参考<see cref="RenewInstanceRequest"/></param>
        /// <returns>参考<see cref="RenewInstanceResponse"/>实例</returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ResetPassword接口的同步版本，重置密码
        /// </summary>
        /// <param name="req">参考<see cref="ResetPasswordRequest"/></param>
        /// <returns>参考<see cref="ResetPasswordResponse"/>实例</returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复 CRS 实例
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public async Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RestoreInstance接口的同步版本，恢复 CRS 实例
        /// </summary>
        /// <param name="req">参考<see cref="RestoreInstanceRequest"/></param>
        /// <returns>参考<see cref="RestoreInstanceResponse"/>实例</returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public async Task<StartupInstanceResponse> StartupInstance(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartupInstance接口的同步版本，实例解隔离
        /// </summary>
        /// <param name="req">参考<see cref="StartupInstanceRequest"/></param>
        /// <returns>参考<see cref="StartupInstanceResponse"/>实例</returns>
        public StartupInstanceResponse StartupInstanceSync(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在通过DTS支持跨可用区灾备的场景中，通过该接口交换实例VIP完成实例灾备切换。交换VIP后目标实例可写，源和目标实例VIP互换，同时源与目标实例间DTS同步任务断开
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public async Task<SwitchInstanceVipResponse> SwitchInstanceVip(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SwitchInstanceVip接口的同步版本，在通过DTS支持跨可用区灾备的场景中，通过该接口交换实例VIP完成实例灾备切换。交换VIP后目标实例可写，源和目标实例VIP互换，同时源与目标实例间DTS同步任务断开
        /// </summary>
        /// <param name="req">参考<see cref="SwitchInstanceVipRequest"/></param>
        /// <returns>参考<see cref="SwitchInstanceVipResponse"/>实例</returns>
        public SwitchInstanceVipResponse SwitchInstanceVipSync(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpgradeInstance接口的同步版本，升级实例
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeInstanceRequest"/></param>
        /// <returns>参考<see cref="UpgradeInstanceResponse"/>实例</returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
