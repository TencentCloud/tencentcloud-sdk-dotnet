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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public MongodbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public MongodbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(AssignProject)用于指定云数据库实例的所属项目。
        /// </summary>
        /// <param name="req">参考<see cref="AssignProjectRequest"/></param>
        /// <returns>参考<see cref="AssignProjectResponse"/>实例</returns>
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
        /// 本接口(CreateDBInstance)用于创建包年包月的MongoDB云数据库实例。接口支持的售卖规格，可从查询云数据库的售卖规格（DescribeSpecInfo）获取。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBInstanceRequest"/></param>
        /// <returns>参考<see cref="CreateDBInstanceResponse"/>实例</returns>
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
        /// 本接口(CreateDBInstanceHour)用于创建按量计费的MongoDB云数据库实例。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns>参考<see cref="CreateDBInstanceHourResponse"/>实例</returns>
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
        /// 本接口（DescribeBackupAccess）用于获取备份文件的下载授权，具体的备份文件信息可通过查询实例备份列表（DescribeDBBackups）接口获取
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupAccessRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupAccessResponse"/>实例</returns>
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
        /// 本接口(DescribeClientConnections)用于查询实例客户端连接信息，包括连接IP和连接数量。目前只支持3.2版本的MongoDB实例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClientConnectionsRequest"/></param>
        /// <returns>参考<see cref="DescribeClientConnectionsResponse"/>实例</returns>
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
        /// 本接口（DescribeDBBackups）用于查询实例备份列表，目前只支持7天内的备份查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBBackupsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBBackupsResponse"/>实例</returns>
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
        /// 本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目ID、实例ID、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstancesResponse"/>实例</returns>
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
        /// 本接口(DescribeSpecInfo)用于查询实例的售卖规格。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSpecInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeSpecInfoResponse"/>实例</returns>
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
        /// 本接口(IsolateDBInstance)用于隔离MongoDB云数据库按量计费实例。隔离后实例保留在回收站中，不能再写入数据。隔离一定时间后，实例会彻底删除，回收站保存时间请参考按量计费的服务条款。在隔离中的按量计费实例无法恢复，请谨慎操作。
        /// </summary>
        /// <param name="req">参考<see cref="IsolateDBInstanceRequest"/></param>
        /// <returns>参考<see cref="IsolateDBInstanceResponse"/>实例</returns>
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
        /// 本接口(ModifyDBInstanceSpec)用于调整MongoDB云数据库实例配置。接口支持的售卖规格，可从查询云数据库的售卖规格（DescribeSpecInfo）获取。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceSpecResponse"/>实例</returns>
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
        /// 本接口(OfflineIsolatedInstances)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态。
        /// </summary>
        /// <param name="req">参考<see cref="OfflineIsolatedDBInstanceRequest"/></param>
        /// <returns>参考<see cref="OfflineIsolatedDBInstanceResponse"/>实例</returns>
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
        /// 本接口(RenameInstance)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req">参考<see cref="RenameInstanceRequest"/></param>
        /// <returns>参考<see cref="RenameInstanceResponse"/>实例</returns>
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

    }
}
