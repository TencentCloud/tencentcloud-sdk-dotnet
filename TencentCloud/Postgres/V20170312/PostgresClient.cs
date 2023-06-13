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

namespace TencentCloud.Postgres.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Postgres.V20170312.Models;

   public class PostgresClient : AbstractClient{

       private const string endpoint = "postgres.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PostgresClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PostgresClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（AddDBInstanceToReadOnlyGroup）用于添加只读实例到只读组
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public async Task<AddDBInstanceToReadOnlyGroupResponse> AddDBInstanceToReadOnlyGroup(AddDBInstanceToReadOnlyGroupRequest req)
        {
             JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDBInstanceToReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AddDBInstanceToReadOnlyGroup）用于添加只读实例到只读组
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public AddDBInstanceToReadOnlyGroupResponse AddDBInstanceToReadOnlyGroupSync(AddDBInstanceToReadOnlyGroupRequest req)
        {
             JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDBInstanceToReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于克隆实例，支持指定备份集、指定时间点进行克隆。
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public async Task<CloneDBInstanceResponse> CloneDBInstance(CloneDBInstanceRequest req)
        {
             JsonResponseModel<CloneDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于克隆实例，支持指定备份集、指定时间点进行克隆。
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public CloneDBInstanceResponse CloneDBInstanceSync(CloneDBInstanceRequest req)
        {
             JsonResponseModel<CloneDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloseDBExtranetAccess）用于关闭实例外网链接。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public async Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CloseDBExtranetAccess）用于关闭实例外网链接。
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭serverlessDB实例外网
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public async Task<CloseServerlessDBExtranetAccessResponse> CloseServerlessDBExtranetAccess(CloseServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭serverlessDB实例外网
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public CloseServerlessDBExtranetAccessResponse CloseServerlessDBExtranetAccessSync(CloseServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateBaseBackup）用于创建实例的全量备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public async Task<CreateBaseBackupResponse> CreateBaseBackup(CreateBaseBackupRequest req)
        {
             JsonResponseModel<CreateBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateBaseBackup）用于创建实例的全量备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public CreateBaseBackupResponse CreateBaseBackupSync(CreateBaseBackupRequest req)
        {
             JsonResponseModel<CreateBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstanceNetworkAccess）用于创建实例网络。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public async Task<CreateDBInstanceNetworkAccessResponse> CreateDBInstanceNetworkAccess(CreateDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<CreateDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstanceNetworkAccess）用于创建实例网络。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public CreateDBInstanceNetworkAccessResponse CreateDBInstanceNetworkAccessSync(CreateDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<CreateDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建一个或者多个PostgreSQL实例,仅发货实例不会进行初始化。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public async Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDBInstances）用于创建一个或者多个PostgreSQL实例,仅发货实例不会进行初始化。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateInstances) 用于创建一个或者多个PostgreSQL实例，通过此接口创建的实例无需进行初始化，可直接使用。
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
        /// 本接口 (CreateInstances) 用于创建一个或者多个PostgreSQL实例，通过此接口创建的实例无需进行初始化，可直接使用。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
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
        /// 本接口 (CreateParameterTemplate) 用于创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public async Task<CreateParameterTemplateResponse> CreateParameterTemplate(CreateParameterTemplateRequest req)
        {
             JsonResponseModel<CreateParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateParameterTemplate) 用于创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public CreateParameterTemplateResponse CreateParameterTemplateSync(CreateParameterTemplateRequest req)
        {
             JsonResponseModel<CreateParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateReadOnlyDBInstance)用于创建只读实例
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public async Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstance(CreateReadOnlyDBInstanceRequest req)
        {
             JsonResponseModel<CreateReadOnlyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReadOnlyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateReadOnlyDBInstance)用于创建只读实例
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstanceSync(CreateReadOnlyDBInstanceRequest req)
        {
             JsonResponseModel<CreateReadOnlyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReadOnlyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroup）用于创建只读组
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public async Task<CreateReadOnlyGroupResponse> CreateReadOnlyGroup(CreateReadOnlyGroupRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroup）用于创建只读组
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public CreateReadOnlyGroupResponse CreateReadOnlyGroupSync(CreateReadOnlyGroupRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroupNetworkAccess）用于创建RO组的网络。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public async Task<CreateReadOnlyGroupNetworkAccessResponse> CreateReadOnlyGroupNetworkAccess(CreateReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateReadOnlyGroupNetworkAccess）用于创建RO组的网络。
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public CreateReadOnlyGroupNetworkAccessResponse CreateReadOnlyGroupNetworkAccessSync(CreateReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateServerlessDBInstance) 用于创建一个ServerlessDB实例，创建成功返回实例ID。
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public async Task<CreateServerlessDBInstanceResponse> CreateServerlessDBInstance(CreateServerlessDBInstanceRequest req)
        {
             JsonResponseModel<CreateServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateServerlessDBInstance) 用于创建一个ServerlessDB实例，创建成功返回实例ID。
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public CreateServerlessDBInstanceResponse CreateServerlessDBInstanceSync(CreateServerlessDBInstanceRequest req)
        {
             JsonResponseModel<CreateServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteBaseBackup）用于删除实例指定全量备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public async Task<DeleteBaseBackupResponse> DeleteBaseBackup(DeleteBaseBackupRequest req)
        {
             JsonResponseModel<DeleteBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteBaseBackup）用于删除实例指定全量备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public DeleteBaseBackupResponse DeleteBaseBackupSync(DeleteBaseBackupRequest req)
        {
             JsonResponseModel<DeleteBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可对实例进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public async Task<DeleteDBInstanceNetworkAccessResponse> DeleteDBInstanceNetworkAccess(DeleteDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可对实例进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public DeleteDBInstanceNetworkAccessResponse DeleteDBInstanceNetworkAccessSync(DeleteDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteLogBackup）用于删除实例指定日志备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public async Task<DeleteLogBackupResponse> DeleteLogBackup(DeleteLogBackupRequest req)
        {
             JsonResponseModel<DeleteLogBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteLogBackup）用于删除实例指定日志备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public DeleteLogBackupResponse DeleteLogBackupSync(DeleteLogBackupRequest req)
        {
             JsonResponseModel<DeleteLogBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteParameterTemplate）主要用于删除某个参数模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public async Task<DeleteParameterTemplateResponse> DeleteParameterTemplate(DeleteParameterTemplateRequest req)
        {
             JsonResponseModel<DeleteParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteParameterTemplate）主要用于删除某个参数模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public DeleteParameterTemplateResponse DeleteParameterTemplateSync(DeleteParameterTemplateRequest req)
        {
             JsonResponseModel<DeleteParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteReadOnlyGroup)用于删除指定的只读组
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public async Task<DeleteReadOnlyGroupResponse> DeleteReadOnlyGroup(DeleteReadOnlyGroupRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteReadOnlyGroup)用于删除指定的只读组
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public DeleteReadOnlyGroupResponse DeleteReadOnlyGroupSync(DeleteReadOnlyGroupRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可对RO组进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public async Task<DeleteReadOnlyGroupNetworkAccessResponse> DeleteReadOnlyGroupNetworkAccess(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可对RO组进行网络的删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public DeleteReadOnlyGroupNetworkAccessResponse DeleteReadOnlyGroupNetworkAccessSync(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteServerlessDBInstance) 用于删除一个ServerlessDB实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public async Task<DeleteServerlessDBInstanceResponse> DeleteServerlessDBInstance(DeleteServerlessDBInstanceRequest req)
        {
             JsonResponseModel<DeleteServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DeleteServerlessDBInstance) 用于删除一个ServerlessDB实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public DeleteServerlessDBInstanceResponse DeleteServerlessDBInstanceSync(DeleteServerlessDBInstanceRequest req)
        {
             JsonResponseModel<DeleteServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于获取实例用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAccounts）用于获取实例用户列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAvailableRecoveryTime）用于查询实例可恢复的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public async Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTime(DescribeAvailableRecoveryTimeRequest req)
        {
             JsonResponseModel<DescribeAvailableRecoveryTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableRecoveryTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableRecoveryTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAvailableRecoveryTime）用于查询实例可恢复的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTimeSync(DescribeAvailableRecoveryTimeRequest req)
        {
             JsonResponseModel<DescribeAvailableRecoveryTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableRecoveryTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableRecoveryTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadRestriction）用于查询备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public async Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupDownloadRestriction）用于查询备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBackupDownloadURL) 用于获取备份下载链接。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public async Task<DescribeBackupDownloadURLResponse> DescribeBackupDownloadURL(DescribeBackupDownloadURLRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBackupDownloadURL) 用于获取备份下载链接。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public DescribeBackupDownloadURLResponse DescribeBackupDownloadURLSync(DescribeBackupDownloadURLRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupOverview）用于查询用户的备份概览信息。返回用户当前备份个数、备份占用容量、免费容量、收费容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public async Task<DescribeBackupOverviewResponse> DescribeBackupOverview(DescribeBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBackupOverview）用于查询用户的备份概览信息。返回用户当前备份个数、备份占用容量、免费容量、收费容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public DescribeBackupOverviewResponse DescribeBackupOverviewSync(DescribeBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBackupPlans) 用于实例所有的备份计划查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public async Task<DescribeBackupPlansResponse> DescribeBackupPlans(DescribeBackupPlansRequest req)
        {
             JsonResponseModel<DescribeBackupPlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeBackupPlans) 用于实例所有的备份计划查询
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public DescribeBackupPlansResponse DescribeBackupPlansSync(DescribeBackupPlansRequest req)
        {
             JsonResponseModel<DescribeBackupPlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackupSummaries)用于查询实例备份的统计信息，返回以实例为维度的备份个数、占用容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public async Task<DescribeBackupSummariesResponse> DescribeBackupSummaries(DescribeBackupSummariesRequest req)
        {
             JsonResponseModel<DescribeBackupSummariesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupSummaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupSummariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackupSummaries)用于查询实例备份的统计信息，返回以实例为维度的备份个数、占用容量等信息（容量单位为字节）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public DescribeBackupSummariesResponse DescribeBackupSummariesSync(DescribeBackupSummariesRequest req)
        {
             JsonResponseModel<DescribeBackupSummariesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupSummaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupSummariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBaseBackups）用于查询基础备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public async Task<DescribeBaseBackupsResponse> DescribeBaseBackups(DescribeBaseBackupsRequest req)
        {
             JsonResponseModel<DescribeBaseBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeBaseBackups）用于查询基础备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public DescribeBaseBackupsResponse DescribeBaseBackupsSync(DescribeBaseBackupsRequest req)
        {
             JsonResponseModel<DescribeBaseBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClasses）用于查询实例售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public async Task<DescribeClassesResponse> DescribeClasses(DescribeClassesRequest req)
        {
             JsonResponseModel<DescribeClassesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClasses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClasses）用于查询实例售卖规格。
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public DescribeClassesResponse DescribeClassesSync(DescribeClassesRequest req)
        {
             JsonResponseModel<DescribeClassesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClasses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCloneDBInstanceSpec）用于查询克隆实例可选择的最小规格，包括SpecCode和磁盘。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public async Task<DescribeCloneDBInstanceSpecResponse> DescribeCloneDBInstanceSpec(DescribeCloneDBInstanceSpecRequest req)
        {
             JsonResponseModel<DescribeCloneDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloneDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloneDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCloneDBInstanceSpec）用于查询克隆实例可选择的最小规格，包括SpecCode和磁盘。
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public DescribeCloneDBInstanceSpecResponse DescribeCloneDBInstanceSpecSync(DescribeCloneDBInstanceSpecRequest req)
        {
             JsonResponseModel<DescribeCloneDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloneDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloneDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBBackups）用于查询实例备份列表。本接口已废弃，推荐使用接口[DescribeBaseBackups](https://cloud.tencent.com/document/api/409/89022)替代。
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
        /// 本接口（DescribeDBBackups）用于查询实例备份列表。本接口已废弃，推荐使用接口[DescribeBaseBackups](https://cloud.tencent.com/document/api/409/89022)替代。
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
        /// 本接口（DescribeDBErrlogs）用于查询错误日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public async Task<DescribeDBErrlogsResponse> DescribeDBErrlogs(DescribeDBErrlogsRequest req)
        {
             JsonResponseModel<DescribeDBErrlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBErrlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBErrlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBErrlogs）用于查询错误日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public DescribeDBErrlogsResponse DescribeDBErrlogsSync(DescribeDBErrlogsRequest req)
        {
             JsonResponseModel<DescribeDBErrlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBErrlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBErrlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDBInstanceAttribute) 用于查询某个实例的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDBInstanceAttribute) 用于查询某个实例的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeSync(DescribeDBInstanceAttributeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例可修改参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public async Task<DescribeDBInstanceParametersResponse> DescribeDBInstanceParameters(DescribeDBInstanceParametersRequest req)
        {
             JsonResponseModel<DescribeDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例可修改参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public DescribeDBInstanceParametersResponse DescribeDBInstanceParametersSync(DescribeDBInstanceParametersRequest req)
        {
             JsonResponseModel<DescribeDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceSecurityGroups）用于查询实例安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<DescribeDBInstanceSecurityGroupsResponse> DescribeDBInstanceSecurityGroups(DescribeDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBInstanceSecurityGroups）用于查询实例安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public DescribeDBInstanceSecurityGroupsResponse DescribeDBInstanceSecurityGroupsSync(DescribeDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDBInstances) 用于查询一个或多个实例的详细信息。
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
        /// 本接口 (DescribeDBInstances) 用于查询一个或多个实例的详细信息。
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
        /// 本接口（DescribeDBSlowlogs）用于获取慢查询日志。本接口已于2021.09.01日废弃，后续此接口将不再返回任何数据，推荐使用接口[DescribeSlowQueryList](https://cloud.tencent.com/document/api/409/60540)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public async Task<DescribeDBSlowlogsResponse> DescribeDBSlowlogs(DescribeDBSlowlogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBSlowlogs）用于获取慢查询日志。本接口已于2021.09.01日废弃，后续此接口将不再返回任何数据，推荐使用接口[DescribeSlowQueryList](https://cloud.tencent.com/document/api/409/60540)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public DescribeDBSlowlogsResponse DescribeDBSlowlogsSync(DescribeDBSlowlogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBVersions）用于查询支持的数据库版本号列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public async Task<DescribeDBVersionsResponse> DescribeDBVersions(DescribeDBVersionsRequest req)
        {
             JsonResponseModel<DescribeDBVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBVersions）用于查询支持的数据库版本号列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public DescribeDBVersionsResponse DescribeDBVersionsSync(DescribeDBVersionsRequest req)
        {
             JsonResponseModel<DescribeDBVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBXlogs）用于获取实例Xlog列表。本接口已废弃，推荐使用接口[DescribeLogBackups](https://cloud.tencent.com/document/api/409/89021)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public async Task<DescribeDBXlogsResponse> DescribeDBXlogs(DescribeDBXlogsRequest req)
        {
             JsonResponseModel<DescribeDBXlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBXlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBXlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDBXlogs）用于获取实例Xlog列表。本接口已废弃，推荐使用接口[DescribeLogBackups](https://cloud.tencent.com/document/api/409/89021)替代。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public DescribeDBXlogsResponse DescribeDBXlogsSync(DescribeDBXlogsRequest req)
        {
             JsonResponseModel<DescribeDBXlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBXlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBXlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（DescribeDatabases）用来拉取数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public async Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（DescribeDatabases）用来拉取数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDefaultParameters）主要用于查询某个数据库版本和引擎支持的所有参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public async Task<DescribeDefaultParametersResponse> DescribeDefaultParameters(DescribeDefaultParametersRequest req)
        {
             JsonResponseModel<DescribeDefaultParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDefaultParameters）主要用于查询某个数据库版本和引擎支持的所有参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public DescribeDefaultParametersResponse DescribeDefaultParametersSync(DescribeDefaultParametersRequest req)
        {
             JsonResponseModel<DescribeDefaultParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例的密钥信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public async Task<DescribeEncryptionKeysResponse> DescribeEncryptionKeys(DescribeEncryptionKeysRequest req)
        {
             JsonResponseModel<DescribeEncryptionKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEncryptionKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptionKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例的密钥信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public DescribeEncryptionKeysResponse DescribeEncryptionKeysSync(DescribeEncryptionKeysRequest req)
        {
             JsonResponseModel<DescribeEncryptionKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEncryptionKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptionKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogBackups）用于查询日志备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public async Task<DescribeLogBackupsResponse> DescribeLogBackups(DescribeLogBackupsRequest req)
        {
             JsonResponseModel<DescribeLogBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeLogBackups）用于查询日志备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public DescribeLogBackupsResponse DescribeLogBackupsSync(DescribeLogBackupsRequest req)
        {
             JsonResponseModel<DescribeLogBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public async Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeOrders）用于查询订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeParameterTemplateAttributes）用于查询某个参数模板的具体内容，包括基本信息和参数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public async Task<DescribeParameterTemplateAttributesResponse> DescribeParameterTemplateAttributes(DescribeParameterTemplateAttributesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplateAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParameterTemplateAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplateAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeParameterTemplateAttributes）用于查询某个参数模板的具体内容，包括基本信息和参数信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public DescribeParameterTemplateAttributesResponse DescribeParameterTemplateAttributesSync(DescribeParameterTemplateAttributesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplateAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParameterTemplateAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplateAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeParameterTemplates) 用于查询参数模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplates(DescribeParameterTemplatesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParameterTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeParameterTemplates) 用于查询参数模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public DescribeParameterTemplatesResponse DescribeParameterTemplatesSync(DescribeParameterTemplatesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParameterTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeParamsEvent) 用于查询参数修改事件详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public async Task<DescribeParamsEventResponse> DescribeParamsEvent(DescribeParamsEventRequest req)
        {
             JsonResponseModel<DescribeParamsEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamsEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamsEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeParamsEvent) 用于查询参数修改事件详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public DescribeParamsEventResponse DescribeParamsEventSync(DescribeParamsEventRequest req)
        {
             JsonResponseModel<DescribeParamsEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamsEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamsEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductConfig）用于查询售卖规格配置。本接口已废弃，推荐使用新接口[DescribeClasses](https://cloud.tencent.com/document/api/409/89019)。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public async Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductConfig）用于查询售卖规格配置。本接口已废弃，推荐使用新接口[DescribeClasses](https://cloud.tencent.com/document/api/409/89019)。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeReadOnlyGroups)用于查询用户输入指定实例的只读组
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public async Task<DescribeReadOnlyGroupsResponse> DescribeReadOnlyGroups(DescribeReadOnlyGroupsRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReadOnlyGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeReadOnlyGroups)用于查询用户输入指定实例的只读组
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public DescribeReadOnlyGroupsResponse DescribeReadOnlyGroupsSync(DescribeReadOnlyGroupsRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReadOnlyGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeRegions) 用于查询售卖地域信息。
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
        /// 本接口 (DescribeRegions) 用于查询售卖地域信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
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
        /// 用于查询一个或多个serverlessDB实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public async Task<DescribeServerlessDBInstancesResponse> DescribeServerlessDBInstances(DescribeServerlessDBInstancesRequest req)
        {
             JsonResponseModel<DescribeServerlessDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServerlessDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询一个或多个serverlessDB实例的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public DescribeServerlessDBInstancesResponse DescribeServerlessDBInstancesSync(DescribeServerlessDBInstancesRequest req)
        {
             JsonResponseModel<DescribeServerlessDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServerlessDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryAnalysis）用于统计指定时间范围内的所有慢查询，根据SQL语句抽象参数后，进行聚合分析，并返回同类SQL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public async Task<DescribeSlowQueryAnalysisResponse> DescribeSlowQueryAnalysis(DescribeSlowQueryAnalysisRequest req)
        {
             JsonResponseModel<DescribeSlowQueryAnalysisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowQueryAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryAnalysis）用于统计指定时间范围内的所有慢查询，根据SQL语句抽象参数后，进行聚合分析，并返回同类SQL列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public DescribeSlowQueryAnalysisResponse DescribeSlowQueryAnalysisSync(DescribeSlowQueryAnalysisRequest req)
        {
             JsonResponseModel<DescribeSlowQueryAnalysisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowQueryAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryList）用于查询指定时间范围内的所有慢查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public async Task<DescribeSlowQueryListResponse> DescribeSlowQueryList(DescribeSlowQueryListRequest req)
        {
             JsonResponseModel<DescribeSlowQueryListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowQueryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSlowQueryList）用于查询指定时间范围内的所有慢查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public DescribeSlowQueryListResponse DescribeSlowQueryListSync(DescribeSlowQueryListRequest req)
        {
             JsonResponseModel<DescribeSlowQueryListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowQueryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询支持的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeZones) 用于查询支持的可用区信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DestroyDBInstance) 用于彻底销毁指定DBInstanceId对应的实例，销毁后实例数据将彻底删除，无法找回，只能销毁隔离中的实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public async Task<DestroyDBInstanceResponse> DestroyDBInstance(DestroyDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DestroyDBInstance) 用于彻底销毁指定DBInstanceId对应的实例，销毁后实例数据将彻底删除，无法找回，只能销毁隔离中的实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public DestroyDBInstanceResponse DestroyDBInstanceSync(DestroyDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisIsolateDBInstances）用于解隔离实例
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public async Task<DisIsolateDBInstancesResponse> DisIsolateDBInstances(DisIsolateDBInstancesRequest req)
        {
             JsonResponseModel<DisIsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisIsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisIsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisIsolateDBInstances）用于解隔离实例
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public DisIsolateDBInstancesResponse DisIsolateDBInstancesSync(DisIsolateDBInstancesRequest req)
        {
             JsonResponseModel<DisIsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisIsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisIsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InitDBInstances）用于初始化云数据库PostgreSQL实例。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public async Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InitDBInstances）用于初始化云数据库PostgreSQL实例。本接口已废弃，推荐使用接口[CreateInstances](https://cloud.tencent.com/document/api/409/56107)替代。
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public InitDBInstancesResponse InitDBInstancesSync(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceCreateDBInstances) 用于查询购买一个或多个实例的价格信息。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public async Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (InquiryPriceCreateDBInstances) 用于查询购买一个或多个实例的价格信息。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询续费实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public async Task<InquiryPriceRenewDBInstanceResponse> InquiryPriceRenewDBInstance(InquiryPriceRenewDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceRenewDBInstance）用于查询续费实例的价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public InquiryPriceRenewDBInstanceResponse InquiryPriceRenewDBInstanceSync(InquiryPriceRenewDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询升级实例的价格。只支持按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public async Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（InquiryPriceUpgradeDBInstance）用于查询升级实例的价格。只支持按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（IsolateDBInstances）用于隔离实例
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public async Task<IsolateDBInstancesResponse> IsolateDBInstances(IsolateDBInstancesRequest req)
        {
             JsonResponseModel<IsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（IsolateDBInstances）用于隔离实例
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public IsolateDBInstancesResponse IsolateDBInstancesSync(IsolateDBInstancesRequest req)
        {
             JsonResponseModel<IsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改帐号备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public async Task<ModifyAccountRemarkResponse> ModifyAccountRemark(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyAccountRemark）用于修改帐号备注。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public ModifyAccountRemarkResponse ModifyAccountRemarkSync(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public async Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBackupDownloadRestriction）用于修改备份文件下载限制。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyBackupPlan) 用于实例备份计划的修改，默认是在每天的凌晨开始全量备份，备份保留时长是7天。可以根据此接口指定时间进行实例的备份。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public async Task<ModifyBackupPlanResponse> ModifyBackupPlan(ModifyBackupPlanRequest req)
        {
             JsonResponseModel<ModifyBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyBackupPlan) 用于实例备份计划的修改，默认是在每天的凌晨开始全量备份，备份保留时长是7天。可以根据此接口指定时间进行实例的备份。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public ModifyBackupPlanResponse ModifyBackupPlanSync(ModifyBackupPlanRequest req)
        {
             JsonResponseModel<ModifyBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBaseBackupExpireTime）用于修改实例指定全量备份的过期时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public async Task<ModifyBaseBackupExpireTimeResponse> ModifyBaseBackupExpireTime(ModifyBaseBackupExpireTimeRequest req)
        {
             JsonResponseModel<ModifyBaseBackupExpireTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBaseBackupExpireTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaseBackupExpireTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyBaseBackupExpireTime）用于修改实例指定全量备份的过期时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public ModifyBaseBackupExpireTimeResponse ModifyBaseBackupExpireTimeSync(ModifyBaseBackupExpireTimeRequest req)
        {
             JsonResponseModel<ModifyBaseBackupExpireTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBaseBackupExpireTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaseBackupExpireTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持实例的计费类型转换（目前仅支持按量计费转包年包月）
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public async Task<ModifyDBInstanceChargeTypeResponse> ModifyDBInstanceChargeType(ModifyDBInstanceChargeTypeRequest req)
        {
             JsonResponseModel<ModifyDBInstanceChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持实例的计费类型转换（目前仅支持按量计费转包年包月）
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public ModifyDBInstanceChargeTypeResponse ModifyDBInstanceChargeTypeSync(ModifyDBInstanceChargeTypeRequest req)
        {
             JsonResponseModel<ModifyDBInstanceChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceDeployment）用于修改节点可用区部署方式，仅支持主实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public async Task<ModifyDBInstanceDeploymentResponse> ModifyDBInstanceDeployment(ModifyDBInstanceDeploymentRequest req)
        {
             JsonResponseModel<ModifyDBInstanceDeploymentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceDeployment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceDeploymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceDeployment）用于修改节点可用区部署方式，仅支持主实例。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public ModifyDBInstanceDeploymentResponse ModifyDBInstanceDeploymentSync(ModifyDBInstanceDeploymentRequest req)
        {
             JsonResponseModel<ModifyDBInstanceDeploymentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceDeployment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceDeploymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改postgresql实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public async Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceName）用于修改postgresql实例名字。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改参数
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public async Task<ModifyDBInstanceParametersResponse> ModifyDBInstanceParameters(ModifyDBInstanceParametersRequest req)
        {
             JsonResponseModel<ModifyDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量修改参数
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public ModifyDBInstanceParametersResponse ModifyDBInstanceParametersSync(ModifyDBInstanceParametersRequest req)
        {
             JsonResponseModel<ModifyDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceReadOnlyGroup）用于修改实例所属的只读组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public async Task<ModifyDBInstanceReadOnlyGroupResponse> ModifyDBInstanceReadOnlyGroup(ModifyDBInstanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceReadOnlyGroup）用于修改实例所属的只读组
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public ModifyDBInstanceReadOnlyGroupResponse ModifyDBInstanceReadOnlyGroupSync(ModifyDBInstanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改实例安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSecurityGroups）用于修改实例安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstanceSpec）用于调整实例规格，包括内存、磁盘。
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
        /// 本接口（ModifyDBInstanceSpec）用于调整实例规格，包括内存、磁盘。
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
        /// 本接口（ModifyDBInstancesProject）用于将实例转至其他项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public async Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDBInstancesProject）用于将实例转至其他项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyParameterTemplate）主要用于修改参数模板名称，描述，修改，添加和删除参数模板参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public async Task<ModifyParameterTemplateResponse> ModifyParameterTemplate(ModifyParameterTemplateRequest req)
        {
             JsonResponseModel<ModifyParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyParameterTemplate）主要用于修改参数模板名称，描述，修改，添加和删除参数模板参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public ModifyParameterTemplateResponse ModifyParameterTemplateSync(ModifyParameterTemplateRequest req)
        {
             JsonResponseModel<ModifyParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyReadOnlyGroupConfig)用于更新只读组配置信息
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public async Task<ModifyReadOnlyGroupConfigResponse> ModifyReadOnlyGroupConfig(ModifyReadOnlyGroupConfigRequest req)
        {
             JsonResponseModel<ModifyReadOnlyGroupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyReadOnlyGroupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReadOnlyGroupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyReadOnlyGroupConfig)用于更新只读组配置信息
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public ModifyReadOnlyGroupConfigResponse ModifyReadOnlyGroupConfigSync(ModifyReadOnlyGroupConfigRequest req)
        {
             JsonResponseModel<ModifyReadOnlyGroupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyReadOnlyGroupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReadOnlyGroupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当升级完成后，对处于等待切换状态下的实例，强制实例立即切换。
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public async Task<ModifySwitchTimePeriodResponse> ModifySwitchTimePeriod(ModifySwitchTimePeriodRequest req)
        {
             JsonResponseModel<ModifySwitchTimePeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySwitchTimePeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySwitchTimePeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当升级完成后，对处于等待切换状态下的实例，强制实例立即切换。
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public ModifySwitchTimePeriodResponse ModifySwitchTimePeriodSync(ModifySwitchTimePeriodRequest req)
        {
             JsonResponseModel<ModifySwitchTimePeriodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySwitchTimePeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySwitchTimePeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通外网。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public async Task<OpenDBExtranetAccessResponse> OpenDBExtranetAccess(OpenDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（OpenDBExtranetAccess）用于开通外网。
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public OpenDBExtranetAccessResponse OpenDBExtranetAccessSync(OpenDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通serverlessDB实例外网
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public async Task<OpenServerlessDBExtranetAccessResponse> OpenServerlessDBExtranetAccess(OpenServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通serverlessDB实例外网
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public OpenServerlessDBExtranetAccessResponse OpenServerlessDBExtranetAccessSync(OpenServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(RebalanceReadOnlyGroup)用于重新均衡 RO 组内实例的负载。注意，RO 组内 RO 实例会有一次数据库连接瞬断，请确保应用程序能重连数据库，谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public async Task<RebalanceReadOnlyGroupResponse> RebalanceReadOnlyGroup(RebalanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<RebalanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebalanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebalanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(RebalanceReadOnlyGroup)用于重新均衡 RO 组内实例的负载。注意，RO 组内 RO 实例会有一次数据库连接瞬断，请确保应用程序能重连数据库，谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public RebalanceReadOnlyGroupResponse RebalanceReadOnlyGroupSync(RebalanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<RebalanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebalanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebalanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RemoveDBInstanceFromReadOnlyGroup）用户将只读实例从只读组中移除
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public async Task<RemoveDBInstanceFromReadOnlyGroupResponse> RemoveDBInstanceFromReadOnlyGroup(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
             JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveDBInstanceFromReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RemoveDBInstanceFromReadOnlyGroup）用户将只读实例从只读组中移除
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public RemoveDBInstanceFromReadOnlyGroupResponse RemoveDBInstanceFromReadOnlyGroupSync(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
             JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveDBInstanceFromReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RenewInstance）用于续费实例。
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
        /// 本接口（RenewInstance）用于续费实例。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
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
        /// 本接口（ResetAccountPassword）用于重置实例的账户密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResetAccountPassword）用于重置实例的账户密码。
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public async Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（RestartDBInstance）用于重启实例。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetAutoRenewFlag）用于设置自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public async Task<SetAutoRenewFlagResponse> SetAutoRenewFlag(SetAutoRenewFlagRequest req)
        {
             JsonResponseModel<SetAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetAutoRenewFlag）用于设置自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public SetAutoRenewFlagResponse SetAutoRenewFlagSync(SetAutoRenewFlagRequest req)
        {
             JsonResponseModel<SetAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDBInstance）用于升级实例配置。本接口已废弃，推荐使用接口[ModifyDBInstanceSpec](https://cloud.tencent.com/document/api/409/63689)替代。
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
        /// 本接口（UpgradeDBInstance）用于升级实例配置。本接口已废弃，推荐使用接口[ModifyDBInstanceSpec](https://cloud.tencent.com/document/api/409/63689)替代。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
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
        /// 本接口（UpgradeDBInstanceKernelVersion）用于升级实例的内核版本号。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceKernelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstanceKernelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceKernelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpgradeDBInstanceKernelVersion）用于升级实例的内核版本号。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionSync(UpgradeDBInstanceKernelVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceKernelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstanceKernelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceKernelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
