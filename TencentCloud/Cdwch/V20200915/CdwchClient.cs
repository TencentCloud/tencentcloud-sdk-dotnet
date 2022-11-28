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

namespace TencentCloud.Cdwch.V20200915
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwch.V20200915.Models;

   public class CdwchClient : AbstractClient{

       private const string endpoint = "cdwch.tencentcloudapi.com";
       private const string version = "2020-09-15";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwchClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwchClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 新增和修改用户接口
        /// </summary>
        /// <param name="req"><see cref="ActionAlterCkUserRequest"/></param>
        /// <returns><see cref="ActionAlterCkUserResponse"/></returns>
        public async Task<ActionAlterCkUserResponse> ActionAlterCkUser(ActionAlterCkUserRequest req)
        {
             JsonResponseModel<ActionAlterCkUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ActionAlterCkUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActionAlterCkUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增和修改用户接口
        /// </summary>
        /// <param name="req"><see cref="ActionAlterCkUserRequest"/></param>
        /// <returns><see cref="ActionAlterCkUserResponse"/></returns>
        public ActionAlterCkUserResponse ActionAlterCkUserSync(ActionAlterCkUserRequest req)
        {
             JsonResponseModel<ActionAlterCkUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ActionAlterCkUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ActionAlterCkUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或者修改备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public async Task<CreateBackUpScheduleResponse> CreateBackUpSchedule(CreateBackUpScheduleRequest req)
        {
             JsonResponseModel<CreateBackUpScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackUpSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackUpScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或者修改备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public CreateBackUpScheduleResponse CreateBackUpScheduleSync(CreateBackUpScheduleRequest req)
        {
             JsonResponseModel<CreateBackUpScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackUpSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackUpScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对驱动sql命令查询ck集群接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCkSqlApisRequest"/></param>
        /// <returns><see cref="DescribeCkSqlApisResponse"/></returns>
        public async Task<DescribeCkSqlApisResponse> DescribeCkSqlApis(DescribeCkSqlApisRequest req)
        {
             JsonResponseModel<DescribeCkSqlApisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCkSqlApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCkSqlApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对驱动sql命令查询ck集群接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCkSqlApisRequest"/></param>
        /// <returns><see cref="DescribeCkSqlApisResponse"/></returns>
        public DescribeCkSqlApisResponse DescribeCkSqlApisSync(DescribeCkSqlApisRequest req)
        {
             JsonResponseModel<DescribeCkSqlApisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCkSqlApis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCkSqlApisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例shard信息列表
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
        /// 获取实例shard信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
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
        /// 在集群配置页面修改集群配置文件接口，xml模式
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterConfigsRequest"/></param>
        /// <returns><see cref="ModifyClusterConfigsResponse"/></returns>
        public async Task<ModifyClusterConfigsResponse> ModifyClusterConfigs(ModifyClusterConfigsRequest req)
        {
             JsonResponseModel<ModifyClusterConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在集群配置页面修改集群配置文件接口，xml模式
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterConfigsRequest"/></param>
        /// <returns><see cref="ModifyClusterConfigsResponse"/></returns>
        public ModifyClusterConfigsResponse ModifyClusterConfigsSync(ModifyClusterConfigsRequest req)
        {
             JsonResponseModel<ModifyClusterConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对ck账号的权限做管控（新版）
        /// </summary>
        /// <param name="req"><see cref="ModifyUserNewPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyUserNewPrivilegeResponse"/></returns>
        public async Task<ModifyUserNewPrivilegeResponse> ModifyUserNewPrivilege(ModifyUserNewPrivilegeRequest req)
        {
             JsonResponseModel<ModifyUserNewPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserNewPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserNewPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 针对ck账号的权限做管控（新版）
        /// </summary>
        /// <param name="req"><see cref="ModifyUserNewPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyUserNewPrivilegeResponse"/></returns>
        public ModifyUserNewPrivilegeResponse ModifyUserNewPrivilegeSync(ModifyUserNewPrivilegeRequest req)
        {
             JsonResponseModel<ModifyUserNewPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserNewPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserNewPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或者关闭策略
        /// </summary>
        /// <param name="req"><see cref="OpenBackUpRequest"/></param>
        /// <returns><see cref="OpenBackUpResponse"/></returns>
        public async Task<OpenBackUpResponse> OpenBackUp(OpenBackUpRequest req)
        {
             JsonResponseModel<OpenBackUpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenBackUp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenBackUpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或者关闭策略
        /// </summary>
        /// <param name="req"><see cref="OpenBackUpRequest"/></param>
        /// <returns><see cref="OpenBackUpResponse"/></returns>
        public OpenBackUpResponse OpenBackUpSync(OpenBackUpRequest req)
        {
             JsonResponseModel<OpenBackUpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenBackUp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenBackUpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
