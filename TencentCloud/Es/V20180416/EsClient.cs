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

namespace TencentCloud.Es.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Es.V20180416.Models;

   public class EsClient : AbstractClient{

       private const string endpoint = "es.tencentcloudapi.com";
       private const string version = "2018-04-16";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public EsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public EsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建指定规格的ES集群实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateInstanceResponse"/>实例</returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 销毁集群实例 
        /// </summary>
        /// <param name="req">参考<see cref="DeleteInstanceRequest"/></param>
        /// <returns>参考<see cref="DeleteInstanceResponse"/>实例</returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的ES集群的日志
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceLogsResponse"/>实例</returns>
        public async Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns>参考<see cref="DescribeInstanceOperationsResponse"/>实例</returns>
        public async Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
             JsonResponseModel<DescribeInstanceOperationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有实例
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
        /// 重启ES集群实例(用于系统版本更新等操作) 
        /// </summary>
        /// <param name="req">参考<see cref="RestartInstanceRequest"/></param>
        /// <returns>参考<see cref="RestartInstanceResponse"/>实例</returns>
        public async Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
             JsonResponseModel<RestartInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对集群进行扩缩容，修改实例名称，修改配置，重置密码， 添加Kibana黑白名单等操作。参数中InstanceId为必传参数，ForceRestart为选填参数，剩余参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeNum：集群数据节点横向扩缩容
        /// - NodeType, DiskSize：集群数据节点纵向扩缩容
        /// - MasterNodeNum: 集群专用主节点横向扩缩容
        /// - MasterNodeType, MasterNodeDiskSize: 集群专用主节点纵向扩缩容
        /// - EsConfig：修改集群配置
        /// - Password：修改默认用户elastic的密码
        /// - EsAcl：修改访问控制列表
        /// - CosBackUp: 设置集群COS自动备份信息
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req">参考<see cref="UpdateInstanceRequest"/></param>
        /// <returns>参考<see cref="UpdateInstanceResponse"/>实例</returns>
        public async Task<UpdateInstanceResponse> UpdateInstance(UpdateInstanceRequest req)
        {
             JsonResponseModel<UpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级ES集群版本
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

        /// <summary>
        /// 升级ES商业特性
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeLicenseRequest"/></param>
        /// <returns>参考<see cref="UpgradeLicenseResponse"/>实例</returns>
        public async Task<UpgradeLicenseResponse> UpgradeLicense(UpgradeLicenseRequest req)
        {
             JsonResponseModel<UpgradeLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
