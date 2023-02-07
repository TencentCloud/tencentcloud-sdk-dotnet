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
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public async Task<CreateInstanceNewResponse> CreateInstanceNew(CreateInstanceNewRequest req)
        {
             JsonResponseModel<CreateInstanceNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public CreateInstanceNewResponse CreateInstanceNewSync(CreateInstanceNewRequest req)
        {
             JsonResponseModel<CreateInstanceNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpScheduleRequest"/></param>
        /// <returns><see cref="DescribeBackUpScheduleResponse"/></returns>
        public async Task<DescribeBackUpScheduleResponse> DescribeBackUpSchedule(DescribeBackUpScheduleRequest req)
        {
             JsonResponseModel<DescribeBackUpScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackUpSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackUpScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpScheduleRequest"/></param>
        /// <returns><see cref="DescribeBackUpScheduleResponse"/></returns>
        public DescribeBackUpScheduleResponse DescribeBackUpScheduleSync(DescribeBackUpScheduleRequest req)
        {
             JsonResponseModel<DescribeBackUpScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackUpSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackUpScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群用户、集群表，数据库等相关信息
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
        /// 查询集群用户、集群表，数据库等相关信息
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
        /// 获取集群的最新的几个配置文件（config.xml、metrika.xml、user.xml）的内容，显示给用户
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public async Task<DescribeClusterConfigsResponse> DescribeClusterConfigs(DescribeClusterConfigsRequest req)
        {
             JsonResponseModel<DescribeClusterConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群的最新的几个配置文件（config.xml、metrika.xml、user.xml）的内容，显示给用户
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public DescribeClusterConfigsResponse DescribeClusterConfigsSync(DescribeClusterConfigsRequest req)
        {
             JsonResponseModel<DescribeClusterConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据实例ID查询某个实例的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public async Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据实例ID查询某个实例的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在集群详情页面获取所有参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceKeyValConfigsResponse"/></returns>
        public async Task<DescribeInstanceKeyValConfigsResponse> DescribeInstanceKeyValConfigs(DescribeInstanceKeyValConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceKeyValConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceKeyValConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceKeyValConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在集群详情页面获取所有参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceKeyValConfigsResponse"/></returns>
        public DescribeInstanceKeyValConfigsResponse DescribeInstanceKeyValConfigsSync(DescribeInstanceKeyValConfigsRequest req)
        {
             JsonResponseModel<DescribeInstanceKeyValConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceKeyValConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceKeyValConfigsResponse>>(strResp);
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
        /// 购买页拉取集群的数据节点和zookeeper节点的规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public async Task<DescribeSpecResponse> DescribeSpec(DescribeSpecRequest req)
        {
             JsonResponseModel<DescribeSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买页拉取集群的数据节点和zookeeper节点的规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public DescribeSpecResponse DescribeSpecSync(DescribeSpecRequest req)
        {
             JsonResponseModel<DescribeSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpecResponse>>(strResp);
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
        /// KV模式修改配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public async Task<ModifyInstanceKeyValConfigsResponse> ModifyInstanceKeyValConfigs(ModifyInstanceKeyValConfigsRequest req)
        {
             JsonResponseModel<ModifyInstanceKeyValConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceKeyValConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceKeyValConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// KV模式修改配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public ModifyInstanceKeyValConfigsResponse ModifyInstanceKeyValConfigsSync(ModifyInstanceKeyValConfigsRequest req)
        {
             JsonResponseModel<ModifyInstanceKeyValConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceKeyValConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceKeyValConfigsResponse>>(strResp);
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

        /// <summary>
        /// 扩容磁盘，包含扩容数据节点，zk节点
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public async Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
             JsonResponseModel<ResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩容磁盘，包含扩容数据节点，zk节点
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
             JsonResponseModel<ResizeDiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResizeDisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResizeDiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整clickhouse节点数量
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public async Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
             JsonResponseModel<ScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整clickhouse节点数量
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
             JsonResponseModel<ScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 垂直扩缩容节点规格，修改节点cvm的规格cpu，内存。 规格变化阶段，服务不可用。
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public async Task<ScaleUpInstanceResponse> ScaleUpInstance(ScaleUpInstanceRequest req)
        {
             JsonResponseModel<ScaleUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 垂直扩缩容节点规格，修改节点cvm的规格cpu，内存。 规格变化阶段，服务不可用。
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public ScaleUpInstanceResponse ScaleUpInstanceSync(ScaleUpInstanceRequest req)
        {
             JsonResponseModel<ScaleUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
