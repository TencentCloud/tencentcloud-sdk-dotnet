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

namespace TencentCloud.Mongodb.V20190725
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mongodb.V20190725.Models;

   public class MongodbClient : AbstractClient{

       private const string endpoint = "mongodb.tencentcloudapi.com";
       private const string version = "2019-07-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MongodbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MongodbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(AssignProject)用于指定云数据库实例的所属项目。
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public async Task<AssignProjectResponse> AssignProject(AssignProjectRequest req)
        {
             JsonResponseModel<AssignProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AssignProject)用于指定云数据库实例的所属项目。
        /// </summary>
        /// <param name="req"><see cref="AssignProjectRequest"/></param>
        /// <returns><see cref="AssignProjectResponse"/></returns>
        public AssignProjectResponse AssignProjectSync(AssignProjectRequest req)
        {
             JsonResponseModel<AssignProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 备份实例接口
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDBInstanceRequest"/></param>
        /// <returns><see cref="CreateBackupDBInstanceResponse"/></returns>
        public async Task<CreateBackupDBInstanceResponse> CreateBackupDBInstance(CreateBackupDBInstanceRequest req)
        {
             JsonResponseModel<CreateBackupDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackupDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 备份实例接口
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDBInstanceRequest"/></param>
        /// <returns><see cref="CreateBackupDBInstanceResponse"/></returns>
        public CreateBackupDBInstanceResponse CreateBackupDBInstanceSync(CreateBackupDBInstanceRequest req)
        {
             JsonResponseModel<CreateBackupDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackupDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来创建某个备份文件的下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateBackupDownloadTaskResponse"/></returns>
        public async Task<CreateBackupDownloadTaskResponse> CreateBackupDownloadTask(CreateBackupDownloadTaskRequest req)
        {
             JsonResponseModel<CreateBackupDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackupDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来创建某个备份文件的下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateBackupDownloadTaskResponse"/></returns>
        public CreateBackupDownloadTaskResponse CreateBackupDownloadTaskSync(CreateBackupDownloadTaskRequest req)
        {
             JsonResponseModel<CreateBackupDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackupDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDBInstance)用于创建包年包月的MongoDB云数据库实例。接口支持的售卖规格，可从查询云数据库的售卖规格（DescribeSpecInfo）获取。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public async Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
             JsonResponseModel<CreateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDBInstance)用于创建包年包月的MongoDB云数据库实例。接口支持的售卖规格，可从查询云数据库的售卖规格（DescribeSpecInfo）获取。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
             JsonResponseModel<CreateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDBInstanceHour)用于创建按量计费的MongoDB云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public async Task<CreateDBInstanceHourResponse> CreateDBInstanceHour(CreateDBInstanceHourRequest req)
        {
             JsonResponseModel<CreateDBInstanceHourResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstanceHour");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceHourResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDBInstanceHour)用于创建按量计费的MongoDB云数据库实例。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public CreateDBInstanceHourResponse CreateDBInstanceHourSync(CreateDBInstanceHourRequest req)
        {
             JsonResponseModel<CreateDBInstanceHourResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstanceHour");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceHourResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询异步任务状态接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public async Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询异步任务状态接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 备份下载功能已调整，此接口即将下线
        /// 
        /// 本接口（DescribeBackupAccess）用于获取备份文件的下载授权，具体的备份文件信息可通过查询实例备份列表（DescribeDBBackups）接口获取
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupAccessRequest"/></param>
        /// <returns><see cref="DescribeBackupAccessResponse"/></returns>
        public async Task<DescribeBackupAccessResponse> DescribeBackupAccess(DescribeBackupAccessRequest req)
        {
             JsonResponseModel<DescribeBackupAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 备份下载功能已调整，此接口即将下线
        /// 
        /// 本接口（DescribeBackupAccess）用于获取备份文件的下载授权，具体的备份文件信息可通过查询实例备份列表（DescribeDBBackups）接口获取
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupAccessRequest"/></param>
        /// <returns><see cref="DescribeBackupAccessResponse"/></returns>
        public DescribeBackupAccessResponse DescribeBackupAccessSync(DescribeBackupAccessRequest req)
        {
             JsonResponseModel<DescribeBackupAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份下载任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public async Task<DescribeBackupDownloadTaskResponse> DescribeBackupDownloadTask(DescribeBackupDownloadTaskRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询备份下载任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadTaskRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadTaskResponse"/></returns>
        public DescribeBackupDownloadTaskResponse DescribeBackupDownloadTaskSync(DescribeBackupDownloadTaskRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeClientConnections)用于查询实例客户端连接信息，包括连接IP和连接数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public async Task<DescribeClientConnectionsResponse> DescribeClientConnections(DescribeClientConnectionsRequest req)
        {
             JsonResponseModel<DescribeClientConnectionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClientConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeClientConnections)用于查询实例客户端连接信息，包括连接IP和连接数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns><see cref="DescribeClientConnectionsResponse"/></returns>
        public DescribeClientConnectionsResponse DescribeClientConnectionsSync(DescribeClientConnectionsRequest req)
        {
             JsonResponseModel<DescribeClientConnectionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClientConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeCurrentOp)用于查询MongoDB云数据库实例的当前正在执行的操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentOpRequest"/></param>
        /// <returns><see cref="DescribeCurrentOpResponse"/></returns>
        public async Task<DescribeCurrentOpResponse> DescribeCurrentOp(DescribeCurrentOpRequest req)
        {
             JsonResponseModel<DescribeCurrentOpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCurrentOp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCurrentOpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeCurrentOp)用于查询MongoDB云数据库实例的当前正在执行的操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentOpRequest"/></param>
        /// <returns><see cref="DescribeCurrentOpResponse"/></returns>
        public DescribeCurrentOpResponse DescribeCurrentOpSync(DescribeCurrentOpRequest req)
        {
             JsonResponseModel<DescribeCurrentOpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCurrentOp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCurrentOpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBBackups）用于查询实例备份列表，目前只支持查询7天内的备份记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public async Task<DescribeDBBackupsResponse> DescribeDBBackups(DescribeDBBackupsRequest req)
        {
             JsonResponseModel<DescribeDBBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBBackups）用于查询实例备份列表，目前只支持查询7天内的备份记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public DescribeDBBackupsResponse DescribeDBBackupsSync(DescribeDBBackupsRequest req)
        {
             JsonResponseModel<DescribeDBBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceDeal）用于获取MongoDB购买、续费及变配订单详细。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public async Task<DescribeDBInstanceDealResponse> DescribeDBInstanceDeal(DescribeDBInstanceDealRequest req)
        {
             JsonResponseModel<DescribeDBInstanceDealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceDeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceDealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceDeal）用于获取MongoDB购买、续费及变配订单详细。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDealRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDealResponse"/></returns>
        public DescribeDBInstanceDealResponse DescribeDBInstanceDealSync(DescribeDBInstanceDealRequest req)
        {
             JsonResponseModel<DescribeDBInstanceDealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceDeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceDealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目ID、实例ID、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目ID、实例ID、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeInstanceParams)用于查询当前实例可修改的参数列表。
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
        /// 本接口(DescribeInstanceParams)用于查询当前实例可修改的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
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
        /// 查询实例绑定的安全组
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupResponse"/></returns>
        public async Task<DescribeSecurityGroupResponse> DescribeSecurityGroup(DescribeSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例绑定的安全组
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupResponse"/></returns>
        public DescribeSecurityGroupResponse DescribeSecurityGroupSync(DescribeSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowLogPatterns）用于获取数据库实例慢日志的统计信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogPatternsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogPatternsResponse"/></returns>
        public async Task<DescribeSlowLogPatternsResponse> DescribeSlowLogPatterns(DescribeSlowLogPatternsRequest req)
        {
             JsonResponseModel<DescribeSlowLogPatternsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogPatterns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogPatternsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowLogPatterns）用于获取数据库实例慢日志的统计信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogPatternsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogPatternsResponse"/></returns>
        public DescribeSlowLogPatternsResponse DescribeSlowLogPatternsSync(DescribeSlowLogPatternsRequest req)
        {
             JsonResponseModel<DescribeSlowLogPatternsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogPatterns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogPatternsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowLogs）用于获取云数据库慢日志信息。接口只支持查询最近7天内慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public async Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
             JsonResponseModel<DescribeSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSlowLogs）用于获取云数据库慢日志信息。接口只支持查询最近7天内慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
             JsonResponseModel<DescribeSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeSpecInfo)用于查询实例的售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public async Task<DescribeSpecInfoResponse> DescribeSpecInfo(DescribeSpecInfoRequest req)
        {
             JsonResponseModel<DescribeSpecInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpecInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpecInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeSpecInfo)用于查询实例的售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecInfoRequest"/></param>
        /// <returns><see cref="DescribeSpecInfoResponse"/></returns>
        public DescribeSpecInfoResponse DescribeSpecInfoSync(DescribeSpecInfoRequest req)
        {
             JsonResponseModel<DescribeSpecInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpecInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpecInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在所有mongos上执行FlushRouterConfig命令
        /// </summary>
        /// <param name="req"><see cref="FlushInstanceRouterConfigRequest"/></param>
        /// <returns><see cref="FlushInstanceRouterConfigResponse"/></returns>
        public async Task<FlushInstanceRouterConfigResponse> FlushInstanceRouterConfig(FlushInstanceRouterConfigRequest req)
        {
             JsonResponseModel<FlushInstanceRouterConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FlushInstanceRouterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlushInstanceRouterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在所有mongos上执行FlushRouterConfig命令
        /// </summary>
        /// <param name="req"><see cref="FlushInstanceRouterConfigRequest"/></param>
        /// <returns><see cref="FlushInstanceRouterConfigResponse"/></returns>
        public FlushInstanceRouterConfigResponse FlushInstanceRouterConfigSync(FlushInstanceRouterConfigRequest req)
        {
             JsonResponseModel<FlushInstanceRouterConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FlushInstanceRouterConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FlushInstanceRouterConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建数据库实例询价。本接口参数中必须传入region参数，否则无法通过校验。本接口仅允许针对购买限制范围内的实例配置进行询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDBInstancesResponse"/></returns>
        public async Task<InquirePriceCreateDBInstancesResponse> InquirePriceCreateDBInstances(InquirePriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquirePriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建数据库实例询价。本接口参数中必须传入region参数，否则无法通过校验。本接口仅允许针对购买限制范围内的实例配置进行询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDBInstancesResponse"/></returns>
        public InquirePriceCreateDBInstancesResponse InquirePriceCreateDBInstancesSync(InquirePriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquirePriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquirePriceModifyDBInstanceSpec) 用于调整实例的配置询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDBInstanceSpecResponse"/></returns>
        public async Task<InquirePriceModifyDBInstanceSpecResponse> InquirePriceModifyDBInstanceSpec(InquirePriceModifyDBInstanceSpecRequest req)
        {
             JsonResponseModel<InquirePriceModifyDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceModifyDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceModifyDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquirePriceModifyDBInstanceSpec) 用于调整实例的配置询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="InquirePriceModifyDBInstanceSpecResponse"/></returns>
        public InquirePriceModifyDBInstanceSpecResponse InquirePriceModifyDBInstanceSpecSync(InquirePriceModifyDBInstanceSpecRequest req)
        {
             JsonResponseModel<InquirePriceModifyDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceModifyDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceModifyDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceRenewDBInstances) 用于续费包年包月实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDBInstancesResponse"/></returns>
        public async Task<InquirePriceRenewDBInstancesResponse> InquirePriceRenewDBInstances(InquirePriceRenewDBInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRenewDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceRenewDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceRenewDBInstances) 用于续费包年包月实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewDBInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRenewDBInstancesResponse"/></returns>
        public InquirePriceRenewDBInstancesResponse InquirePriceRenewDBInstancesSync(InquirePriceRenewDBInstancesRequest req)
        {
             JsonResponseModel<InquirePriceRenewDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceRenewDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceRenewDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(IsolateDBInstance)用于隔离MongoDB云数据库按量计费实例。隔离后实例保留在回收站中，不能再写入数据。隔离一定时间后，实例会彻底删除，回收站保存时间请参考按量计费的服务条款。在隔离中的按量计费实例无法恢复，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public async Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(IsolateDBInstance)用于隔离MongoDB云数据库按量计费实例。隔离后实例保留在回收站中，不能再写入数据。隔离一定时间后，实例会彻底删除，回收站保存时间请参考按量计费的服务条款。在隔离中的按量计费实例无法恢复，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(KillOps)用于终止MongoDB云数据库实例上执行的特定操作。
        /// </summary>
        /// <param name="req"><see cref="KillOpsRequest"/></param>
        /// <returns><see cref="KillOpsResponse"/></returns>
        public async Task<KillOpsResponse> KillOps(KillOpsRequest req)
        {
             JsonResponseModel<KillOpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KillOps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillOpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(KillOps)用于终止MongoDB云数据库实例上执行的特定操作。
        /// </summary>
        /// <param name="req"><see cref="KillOpsRequest"/></param>
        /// <returns><see cref="KillOpsResponse"/></returns>
        public KillOpsResponse KillOpsSync(KillOpsRequest req)
        {
             JsonResponseModel<KillOpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KillOps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillOpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceNetworkAddress)用于修改云数据库实例的网络信息，可进行基础网络转VPC网络和VPC网络之间的变换。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public async Task<ModifyDBInstanceNetworkAddressResponse> ModifyDBInstanceNetworkAddress(ModifyDBInstanceNetworkAddressRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNetworkAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceNetworkAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNetworkAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceNetworkAddress)用于修改云数据库实例的网络信息，可进行基础网络转VPC网络和VPC网络之间的变换。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNetworkAddressRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNetworkAddressResponse"/></returns>
        public ModifyDBInstanceNetworkAddressResponse ModifyDBInstanceNetworkAddressSync(ModifyDBInstanceNetworkAddressRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNetworkAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceNetworkAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNetworkAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例绑定的安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public async Task<ModifyDBInstanceSecurityGroupResponse> ModifyDBInstanceSecurityGroup(ModifyDBInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例绑定的安全组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupResponse"/></returns>
        public ModifyDBInstanceSecurityGroupResponse ModifyDBInstanceSecurityGroupSync(ModifyDBInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSpec)用于调整MongoDB云数据库实例配置。接口支持的售卖规格，可从查询云数据库的售卖规格（DescribeSpecInfo）获取。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSpec)用于调整MongoDB云数据库实例配置。接口支持的售卖规格，可从查询云数据库的售卖规格（DescribeSpecInfo）获取。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecSync(ModifyDBInstanceSpecRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(OfflineIsolatedDBInstance)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态。
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineIsolatedDBInstanceResponse"/></returns>
        public async Task<OfflineIsolatedDBInstanceResponse> OfflineIsolatedDBInstance(OfflineIsolatedDBInstanceRequest req)
        {
             JsonResponseModel<OfflineIsolatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OfflineIsolatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(OfflineIsolatedDBInstance)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态。
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedDBInstanceRequest"/></param>
        /// <returns><see cref="OfflineIsolatedDBInstanceResponse"/></returns>
        public OfflineIsolatedDBInstanceResponse OfflineIsolatedDBInstanceSync(OfflineIsolatedDBInstanceRequest req)
        {
             JsonResponseModel<OfflineIsolatedDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OfflineIsolatedDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(RenameInstance)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req"><see cref="RenameInstanceRequest"/></param>
        /// <returns><see cref="RenameInstanceResponse"/></returns>
        public async Task<RenameInstanceResponse> RenameInstance(RenameInstanceRequest req)
        {
             JsonResponseModel<RenameInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenameInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenameInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(RenameInstance)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req"><see cref="RenameInstanceRequest"/></param>
        /// <returns><see cref="RenameInstanceResponse"/></returns>
        public RenameInstanceResponse RenameInstanceSync(RenameInstanceRequest req)
        {
             JsonResponseModel<RenameInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenameInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenameInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(RenewDBInstance)用于续费云数据库实例，仅支持付费模式为包年包月的实例。按量计费实例不需要续费。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstancesRequest"/></param>
        /// <returns><see cref="RenewDBInstancesResponse"/></returns>
        public async Task<RenewDBInstancesResponse> RenewDBInstances(RenewDBInstancesRequest req)
        {
             JsonResponseModel<RenewDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(RenewDBInstance)用于续费云数据库实例，仅支持付费模式为包年包月的实例。按量计费实例不需要续费。
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstancesRequest"/></param>
        /// <returns><see cref="RenewDBInstancesResponse"/></returns>
        public RenewDBInstancesResponse RenewDBInstancesSync(RenewDBInstancesRequest req)
        {
             JsonResponseModel<RenewDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例用户的密码
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public async Task<ResetDBInstancePasswordResponse> ResetDBInstancePassword(ResetDBInstancePasswordRequest req)
        {
             JsonResponseModel<ResetDBInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDBInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDBInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例用户的密码
        /// </summary>
        /// <param name="req"><see cref="ResetDBInstancePasswordRequest"/></param>
        /// <returns><see cref="ResetDBInstancePasswordResponse"/></returns>
        public ResetDBInstancePasswordResponse ResetDBInstancePasswordSync(ResetDBInstancePasswordRequest req)
        {
             JsonResponseModel<ResetDBInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetDBInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDBInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 账户权限设置。
        /// </summary>
        /// <param name="req"><see cref="SetAccountUserPrivilegeRequest"/></param>
        /// <returns><see cref="SetAccountUserPrivilegeResponse"/></returns>
        public async Task<SetAccountUserPrivilegeResponse> SetAccountUserPrivilege(SetAccountUserPrivilegeRequest req)
        {
             JsonResponseModel<SetAccountUserPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAccountUserPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAccountUserPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 账户权限设置。
        /// </summary>
        /// <param name="req"><see cref="SetAccountUserPrivilegeRequest"/></param>
        /// <returns><see cref="SetAccountUserPrivilegeResponse"/></returns>
        public SetAccountUserPrivilegeResponse SetAccountUserPrivilegeSync(SetAccountUserPrivilegeRequest req)
        {
             JsonResponseModel<SetAccountUserPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAccountUserPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAccountUserPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
