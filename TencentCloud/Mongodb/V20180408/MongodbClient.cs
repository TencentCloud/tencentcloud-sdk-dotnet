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

namespace TencentCloud.Mongodb.V20180408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mongodb.V20180408.Models;

   public class MongodbClient : AbstractClient{

       private const string endpoint = "mongodb.tencentcloudapi.com";
       private const string version = "2018-04-08";

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
        /// 
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
        /// AssignProject接口的同步版本，本接口(AssignProject)用于指定云数据库实例的所属项目。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="AssignProjectRequest"/></param>
        /// <returns>参考<see cref="AssignProjectResponse"/>实例</returns>
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
        /// 本接口(CreateDBInstance)用于创建包年包月的MongoDB云数据库实例。
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
        /// CreateDBInstance接口的同步版本，本接口(CreateDBInstance)用于创建包年包月的MongoDB云数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateDBInstanceResponse"/>实例</returns>
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
        /// 本接口(CreateDBInstanceHour)用于创建按量计费的MongoDB云数据库实例（包括主实例、灾备实例和只读实例），可通过传入实例规格、实例类型、MongoDB版本、购买时长和数量等信息创建云数据库实例。
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
        /// CreateDBInstanceHour接口的同步版本，本接口(CreateDBInstanceHour)用于创建按量计费的MongoDB云数据库实例（包括主实例、灾备实例和只读实例），可通过传入实例规格、实例类型、MongoDB版本、购买时长和数量等信息创建云数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns>参考<see cref="CreateDBInstanceHourResponse"/>实例</returns>
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
        /// 本接口(DescribeClientConnections)用于查询实例客户端连接信息，包括连接IP和连接数量。目前只支持3.2版本的MongoDB实例。
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
        /// DescribeClientConnections接口的同步版本，本接口(DescribeClientConnections)用于查询实例客户端连接信息，包括连接IP和连接数量。目前只支持3.2版本的MongoDB实例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns>参考<see cref="DescribeClientConnectionsResponse"/>实例</returns>
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
        /// DescribeDBInstances接口的同步版本，本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目ID、实例ID、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstancesResponse"/>实例</returns>
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
        /// 本接口(DescribeSlowLogs)用于获取云数据库实例的慢查询日志。
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
        /// DescribeSlowLog接口的同步版本，本接口(DescribeSlowLogs)用于获取云数据库实例的慢查询日志。
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
        /// DescribeSpecInfo接口的同步版本，本接口(DescribeSpecInfo)用于查询实例的售卖规格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSpecInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeSpecInfoResponse"/>实例</returns>
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
        /// RenameInstance接口的同步版本，本接口(RenameInstance)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req">参考<see cref="RenameInstanceRequest"/></param>
        /// <returns>参考<see cref="RenameInstanceResponse"/>实例</returns>
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
        /// 本接口(SetAutoRenew)用于设置包年包月云数据库实例的续费选项。
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewRequest"/></param>
        /// <returns><see cref="SetAutoRenewResponse"/></returns>
        public async Task<SetAutoRenewResponse> SetAutoRenew(SetAutoRenewRequest req)
        {
             JsonResponseModel<SetAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetAutoRenew接口的同步版本，本接口(SetAutoRenew)用于设置包年包月云数据库实例的续费选项。
        /// </summary>
        /// <param name="req">参考<see cref="SetAutoRenewRequest"/></param>
        /// <returns>参考<see cref="SetAutoRenewResponse"/>实例</returns>
        public SetAutoRenewResponse SetAutoRenewSync(SetAutoRenewRequest req)
        {
             JsonResponseModel<SetAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(SetPassword)用于设置云数据库账户的密码。
        /// 
        /// </summary>
        /// <param name="req"><see cref="SetPasswordRequest"/></param>
        /// <returns><see cref="SetPasswordResponse"/></returns>
        public async Task<SetPasswordResponse> SetPassword(SetPasswordRequest req)
        {
             JsonResponseModel<SetPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SetPassword接口的同步版本，本接口(SetPassword)用于设置云数据库账户的密码。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="SetPasswordRequest"/></param>
        /// <returns>参考<see cref="SetPasswordResponse"/>实例</returns>
        public SetPasswordResponse SetPasswordSync(SetPasswordRequest req)
        {
             JsonResponseModel<SetPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(TerminateDBInstance)用于销毁按量计费的MongoDB云数据库实例
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public async Task<TerminateDBInstanceResponse> TerminateDBInstance(TerminateDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TerminateDBInstance接口的同步版本，本接口(TerminateDBInstance)用于销毁按量计费的MongoDB云数据库实例
        /// </summary>
        /// <param name="req">参考<see cref="TerminateDBInstanceRequest"/></param>
        /// <returns>参考<see cref="TerminateDBInstanceResponse"/>实例</returns>
        public TerminateDBInstanceResponse TerminateDBInstanceSync(TerminateDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpgradeDBInstance)用于升级包年包月的MongoDB云数据库实例，可以扩容内存、存储以及Oplog
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public async Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpgradeDBInstance接口的同步版本，本接口(UpgradeDBInstance)用于升级包年包月的MongoDB云数据库实例，可以扩容内存、存储以及Oplog
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns>参考<see cref="UpgradeDBInstanceResponse"/>实例</returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpgradeDBInstanceHour)用于升级按量计费的MongoDB云数据库实例，可以扩容内存、存储以及oplog
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceHourRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceHourResponse"/></returns>
        public async Task<UpgradeDBInstanceHourResponse> UpgradeDBInstanceHour(UpgradeDBInstanceHourRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceHourResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstanceHour");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceHourResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpgradeDBInstanceHour接口的同步版本，本接口(UpgradeDBInstanceHour)用于升级按量计费的MongoDB云数据库实例，可以扩容内存、存储以及oplog
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeDBInstanceHourRequest"/></param>
        /// <returns>参考<see cref="UpgradeDBInstanceHourResponse"/>实例</returns>
        public UpgradeDBInstanceHourResponse UpgradeDBInstanceHourSync(UpgradeDBInstanceHourRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceHourResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstanceHour");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceHourResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
