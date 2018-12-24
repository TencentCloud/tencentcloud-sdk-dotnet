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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public RedisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public RedisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 清空Redis实例的实例数据。
        /// </summary>
        /// <param name="req">参考<see cref="ClearInstanceRequest"/></param>
        /// <returns>参考<see cref="ClearInstanceResponse"/>实例</returns>
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
        /// 创建redis实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateInstancesRequest"/></param>
        /// <returns>参考<see cref="CreateInstancesResponse"/>实例</returns>
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
        /// 获取备份配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeAutoBackupConfigResponse"/>实例</returns>
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
        /// 查询 CRS 实例备份列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceBackupsResponse"/>实例</returns>
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
        /// 查询订单信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceDealDetailResponse"/>实例</returns>
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
        /// 查询Redis实例列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeInstancesResponse"/>实例</returns>
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
        /// 本接口查询指定可用区和实例类型下 Redis 的售卖规格， 如果用户不在购买白名单中，将不能查询该可用区或该类型的售卖规格详情。申请购买某地域白名单可以提交工单
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProductInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeProductInfoResponse"/>实例</returns>
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
        /// 用于查询任务结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskInfoResponse"/>实例</returns>
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
        /// 手动备份Redis实例
        /// </summary>
        /// <param name="req">参考<see cref="ManualBackupInstanceRequest"/></param>
        /// <returns>参考<see cref="ManualBackupInstanceResponse"/>实例</returns>
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
        /// 修改redis密码
        /// </summary>
        /// <param name="req">参考<see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns>参考<see cref="ModfiyInstancePasswordResponse"/>实例</returns>
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
        /// 设置自动备份时间
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyAutoBackupConfigResponse"/>实例</returns>
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
        /// 修改实例相关信息（目前支持：实例重命名）
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstanceRequest"/></param>
        /// <returns>参考<see cref="ModifyInstanceResponse"/>实例</returns>
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
        /// 续费实例
        /// </summary>
        /// <param name="req">参考<see cref="RenewInstanceRequest"/></param>
        /// <returns>参考<see cref="RenewInstanceResponse"/>实例</returns>
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
        /// 重置密码
        /// </summary>
        /// <param name="req">参考<see cref="ResetPasswordRequest"/></param>
        /// <returns>参考<see cref="ResetPasswordResponse"/>实例</returns>
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
        /// 升级实例
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeInstanceRequest"/></param>
        /// <returns>参考<see cref="UpgradeInstanceResponse"/>实例</returns>
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

    }
}
