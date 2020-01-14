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

namespace TencentCloud.Cdb.V20170320
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdb.V20170320.Models;

   public class CdbClient : AbstractClient{

       private const string endpoint = "cdb.tencentcloudapi.com";
       private const string version = "2017-03-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(AddTimeWindow)用于添加云数据库实例的维护时间窗口，以指定实例在哪些时间段可以自动执行切换访问操作。
        /// </summary>
        /// <param name="req"><see cref="AddTimeWindowRequest"/></param>
        /// <returns><see cref="AddTimeWindowResponse"/></returns>
        public async Task<AddTimeWindowResponse> AddTimeWindow(AddTimeWindowRequest req)
        {
             JsonResponseModel<AddTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AddTimeWindow接口的同步版本，本接口(AddTimeWindow)用于添加云数据库实例的维护时间窗口，以指定实例在哪些时间段可以自动执行切换访问操作。
        /// </summary>
        /// <param name="req">参考<see cref="AddTimeWindowRequest"/></param>
        /// <returns>参考<see cref="AddTimeWindowResponse"/>实例</returns>
        public AddTimeWindowResponse AddTimeWindowSync(AddTimeWindowRequest req)
        {
             JsonResponseModel<AddTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// AssociateSecurityGroups接口的同步版本，本接口(AssociateSecurityGroups)用于安全组批量绑定实例。
        /// </summary>
        /// <param name="req">参考<see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="AssociateSecurityGroupsResponse"/>实例</returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CloseWanService)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问。
        /// </summary>
        /// <param name="req"><see cref="CloseWanServiceRequest"/></param>
        /// <returns><see cref="CloseWanServiceResponse"/></returns>
        public async Task<CloseWanServiceResponse> CloseWanService(CloseWanServiceRequest req)
        {
             JsonResponseModel<CloseWanServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseWanServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CloseWanService接口的同步版本，本接口(CloseWanService)用于关闭云数据库实例的外网访问。关闭外网访问后，外网地址将不可访问。
        /// </summary>
        /// <param name="req">参考<see cref="CloseWanServiceRequest"/></param>
        /// <returns>参考<see cref="CloseWanServiceResponse"/>实例</returns>
        public CloseWanServiceResponse CloseWanServiceSync(CloseWanServiceRequest req)
        {
             JsonResponseModel<CloseWanServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseWanServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateAccounts)用于创建云数据库的账户，需要指定新的账户名和域名，以及所对应的密码，同时可以设置账号的备注信息。
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public async Task<CreateAccountsResponse> CreateAccounts(CreateAccountsRequest req)
        {
             JsonResponseModel<CreateAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateAccounts接口的同步版本，本接口(CreateAccounts)用于创建云数据库的账户，需要指定新的账户名和域名，以及所对应的密码，同时可以设置账号的备注信息。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAccountsRequest"/></param>
        /// <returns>参考<see cref="CreateAccountsResponse"/>实例</returns>
        public CreateAccountsResponse CreateAccountsSync(CreateAccountsRequest req)
        {
             JsonResponseModel<CreateAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateBackup)用于创建数据库备份。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateBackup接口的同步版本，本接口(CreateBackup)用于创建数据库备份。
        /// </summary>
        /// <param name="req">参考<see cref="CreateBackupRequest"/></param>
        /// <returns>参考<see cref="CreateBackupResponse"/>实例</returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDBImportJob)用于创建云数据库数据导入任务。
        /// 
        /// 注意，用户进行数据导入任务的文件，必须提前上传到腾讯云。用户须在控制台进行文件导入。
        /// </summary>
        /// <param name="req"><see cref="CreateDBImportJobRequest"/></param>
        /// <returns><see cref="CreateDBImportJobResponse"/></returns>
        public async Task<CreateDBImportJobResponse> CreateDBImportJob(CreateDBImportJobRequest req)
        {
             JsonResponseModel<CreateDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDBImportJob接口的同步版本，本接口(CreateDBImportJob)用于创建云数据库数据导入任务。
        /// 
        /// 注意，用户进行数据导入任务的文件，必须提前上传到腾讯云。用户须在控制台进行文件导入。
        /// </summary>
        /// <param name="req">参考<see cref="CreateDBImportJobRequest"/></param>
        /// <returns>参考<see cref="CreateDBImportJobResponse"/>实例</returns>
        public CreateDBImportJobResponse CreateDBImportJobSync(CreateDBImportJobRequest req)
        {
             JsonResponseModel<CreateDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateDBInstance)用于创建包年包月的云数据库实例（包括主实例、灾备实例和只读实例），可通过传入实例规格、MySQL 版本号、购买时长和数量等信息创建云数据库实例。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为1，且 TaskStatus 为0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5 、 MySQL 5.6 、 MySQL 5.7 版本；
        /// 4. 支持创建主实例、只读实例、灾备实例；
        /// 5. 当入参指定 Port，ParamList 或 Password 时，该实例会进行初始化操作；
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
        /// CreateDBInstance接口的同步版本，本接口(CreateDBInstance)用于创建包年包月的云数据库实例（包括主实例、灾备实例和只读实例），可通过传入实例规格、MySQL 版本号、购买时长和数量等信息创建云数据库实例。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为1，且 TaskStatus 为0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5 、 MySQL 5.6 、 MySQL 5.7 版本；
        /// 4. 支持创建主实例、只读实例、灾备实例；
        /// 5. 当入参指定 Port，ParamList 或 Password 时，该实例会进行初始化操作；
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
        /// 本接口(CreateDBInstanceHour)用于创建按量计费的实例，可通过传入实例规格、MySQL 版本号和数量等信息创建云数据库实例，支持主实例、灾备实例和只读实例的创建。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为 1，且 TaskStatus 为 0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5、MySQL 5.6 和 MySQL 5.7 版本；
        /// 4. 支持创建主实例、灾备实例和只读实例；
        /// 5. 当入参指定 Port，ParamList 或 Password 时，该实例会进行初始化操作；
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
        /// CreateDBInstanceHour接口的同步版本，本接口(CreateDBInstanceHour)用于创建按量计费的实例，可通过传入实例规格、MySQL 版本号和数量等信息创建云数据库实例，支持主实例、灾备实例和只读实例的创建。
        /// 
        /// 该接口为异步接口，您还可以使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询该实例的详细信息。当该实例的 Status 为 1，且 TaskStatus 为 0，表示实例已经发货成功。
        /// 
        /// 1. 首先请使用 [获取云数据库可售卖规格](https://cloud.tencent.com/document/api/236/17229) 接口查询可创建的实例规格信息，然后请使用 [查询数据库价格](https://cloud.tencent.com/document/api/236/18566) 接口查询可创建实例的售卖价格；
        /// 2. 单次创建实例最大支持 100 个，实例时长最大支持 36 个月；
        /// 3. 支持创建 MySQL 5.5、MySQL 5.6 和 MySQL 5.7 版本；
        /// 4. 支持创建主实例、灾备实例和只读实例；
        /// 5. 当入参指定 Port，ParamList 或 Password 时，该实例会进行初始化操作；
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
        /// 本接口(CreateDeployGroup)用于创建放置实例的置放群组
        /// </summary>
        /// <param name="req"><see cref="CreateDeployGroupRequest"/></param>
        /// <returns><see cref="CreateDeployGroupResponse"/></returns>
        public async Task<CreateDeployGroupResponse> CreateDeployGroup(CreateDeployGroupRequest req)
        {
             JsonResponseModel<CreateDeployGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDeployGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeployGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDeployGroup接口的同步版本，本接口(CreateDeployGroup)用于创建放置实例的置放群组
        /// </summary>
        /// <param name="req">参考<see cref="CreateDeployGroupRequest"/></param>
        /// <returns>参考<see cref="CreateDeployGroupResponse"/>实例</returns>
        public CreateDeployGroupResponse CreateDeployGroupSync(CreateDeployGroupRequest req)
        {
             JsonResponseModel<CreateDeployGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDeployGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeployGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateParamTemplate）用于创建参数模板。
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public async Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateParamTemplate接口的同步版本，该接口（CreateParamTemplate）用于创建参数模板。
        /// </summary>
        /// <param name="req">参考<see cref="CreateParamTemplateRequest"/></param>
        /// <returns>参考<see cref="CreateParamTemplateResponse"/>实例</returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteAccounts)用于删除云数据库的账户。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public async Task<DeleteAccountsResponse> DeleteAccounts(DeleteAccountsRequest req)
        {
             JsonResponseModel<DeleteAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteAccounts接口的同步版本，本接口(DeleteAccounts)用于删除云数据库的账户。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAccountsRequest"/></param>
        /// <returns>参考<see cref="DeleteAccountsResponse"/>实例</returns>
        public DeleteAccountsResponse DeleteAccountsSync(DeleteAccountsRequest req)
        {
             JsonResponseModel<DeleteAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteBackup)用于删除数据库备份。
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public async Task<DeleteBackupResponse> DeleteBackup(DeleteBackupRequest req)
        {
             JsonResponseModel<DeleteBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteBackup接口的同步版本，本接口(DeleteBackup)用于删除数据库备份。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteBackupRequest"/></param>
        /// <returns>参考<see cref="DeleteBackupResponse"/>实例</returns>
        public DeleteBackupResponse DeleteBackupSync(DeleteBackupRequest req)
        {
             JsonResponseModel<DeleteBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据置放群组ID删除置放群组（置放群组中有资源存在时不能删除该置放群组）
        /// </summary>
        /// <param name="req"><see cref="DeleteDeployGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeployGroupsResponse"/></returns>
        public async Task<DeleteDeployGroupsResponse> DeleteDeployGroups(DeleteDeployGroupsRequest req)
        {
             JsonResponseModel<DeleteDeployGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeployGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeployGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteDeployGroups接口的同步版本，根据置放群组ID删除置放群组（置放群组中有资源存在时不能删除该置放群组）
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDeployGroupsRequest"/></param>
        /// <returns>参考<see cref="DeleteDeployGroupsResponse"/>实例</returns>
        public DeleteDeployGroupsResponse DeleteDeployGroupsSync(DeleteDeployGroupsRequest req)
        {
             JsonResponseModel<DeleteDeployGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeployGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeployGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DeleteParamTemplate）用于删除参数模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public async Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteParamTemplate接口的同步版本，该接口（DeleteParamTemplate）用于删除参数模板。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteParamTemplateRequest"/></param>
        /// <returns>参考<see cref="DeleteParamTemplateResponse"/>实例</returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteTimeWindow)用于删除云数据库实例的维护时间窗口。删除实例维护时间窗口之后，默认的维护时间窗为 03:00-04:00，即当选择在维护时间窗口内切换访问新实例时，默认会在 03:00-04:00 点进行切换访问新实例。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeWindowRequest"/></param>
        /// <returns><see cref="DeleteTimeWindowResponse"/></returns>
        public async Task<DeleteTimeWindowResponse> DeleteTimeWindow(DeleteTimeWindowRequest req)
        {
             JsonResponseModel<DeleteTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteTimeWindow接口的同步版本，本接口(DeleteTimeWindow)用于删除云数据库实例的维护时间窗口。删除实例维护时间窗口之后，默认的维护时间窗为 03:00-04:00，即当选择在维护时间窗口内切换访问新实例时，默认会在 03:00-04:00 点进行切换访问新实例。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTimeWindowRequest"/></param>
        /// <returns>参考<see cref="DeleteTimeWindowResponse"/>实例</returns>
        public DeleteTimeWindowResponse DeleteTimeWindowSync(DeleteTimeWindowRequest req)
        {
             JsonResponseModel<DeleteTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAccountPrivileges)用于查询云数据库账户支持的权限信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public async Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
             JsonResponseModel<DescribeAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeAccountPrivileges接口的同步版本，本接口(DescribeAccountPrivileges)用于查询云数据库账户支持的权限信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountPrivilegesResponse"/>实例</returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
             JsonResponseModel<DescribeAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAccounts)用于查询云数据库的所有账户信息。
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
        /// DescribeAccounts接口的同步版本，本接口(DescribeAccounts)用于查询云数据库的所有账户信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountsResponse"/>实例</returns>
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
        /// 本接口(DescribeAsyncRequestInfo)用于查询云数据库实例异步任务的执行结果。
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
        /// DescribeAsyncRequestInfo接口的同步版本，本接口(DescribeAsyncRequestInfo)用于查询云数据库实例异步任务的执行结果。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeAsyncRequestInfoResponse"/>实例</returns>
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
        /// 本接口(DescribeBackupConfig)用于查询数据库备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public async Task<DescribeBackupConfigResponse> DescribeBackupConfig(DescribeBackupConfigRequest req)
        {
             JsonResponseModel<DescribeBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBackupConfig接口的同步版本，本接口(DescribeBackupConfig)用于查询数据库备份配置信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupConfigResponse"/>实例</returns>
        public DescribeBackupConfigResponse DescribeBackupConfigSync(DescribeBackupConfigRequest req)
        {
             JsonResponseModel<DescribeBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackupDatabases)用于查询备份文件包含的库 (已废弃)。
        /// 旧版本支持全量备份后，用户如果分库表下载逻辑备份文件，需要用到此接口。
        /// 新版本支持(CreateBackup)创建逻辑备份的时候，直接发起指定库表备份，用户直接下载该备份文件即可。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDatabasesRequest"/></param>
        /// <returns><see cref="DescribeBackupDatabasesResponse"/></returns>
        public async Task<DescribeBackupDatabasesResponse> DescribeBackupDatabases(DescribeBackupDatabasesRequest req)
        {
             JsonResponseModel<DescribeBackupDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBackupDatabases接口的同步版本，本接口(DescribeBackupDatabases)用于查询备份文件包含的库 (已废弃)。
        /// 旧版本支持全量备份后，用户如果分库表下载逻辑备份文件，需要用到此接口。
        /// 新版本支持(CreateBackup)创建逻辑备份的时候，直接发起指定库表备份，用户直接下载该备份文件即可。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupDatabasesRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupDatabasesResponse"/>实例</returns>
        public DescribeBackupDatabasesResponse DescribeBackupDatabasesSync(DescribeBackupDatabasesRequest req)
        {
             JsonResponseModel<DescribeBackupDatabasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackupTables)用于查询指定的数据库的备份数据表名 (已废弃)。
        /// 旧版本支持全量备份后，用户如果分库表下载逻辑备份文件，需要用到此接口。
        /// 新版本支持(CreateBackup)创建逻辑备份的时候，直接发起指定库表备份，用户直接下载该备份文件即可。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupTablesRequest"/></param>
        /// <returns><see cref="DescribeBackupTablesResponse"/></returns>
        public async Task<DescribeBackupTablesResponse> DescribeBackupTables(DescribeBackupTablesRequest req)
        {
             JsonResponseModel<DescribeBackupTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBackupTables接口的同步版本，本接口(DescribeBackupTables)用于查询指定的数据库的备份数据表名 (已废弃)。
        /// 旧版本支持全量备份后，用户如果分库表下载逻辑备份文件，需要用到此接口。
        /// 新版本支持(CreateBackup)创建逻辑备份的时候，直接发起指定库表备份，用户直接下载该备份文件即可。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupTablesRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupTablesResponse"/>实例</returns>
        public DescribeBackupTablesResponse DescribeBackupTablesSync(DescribeBackupTablesRequest req)
        {
             JsonResponseModel<DescribeBackupTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBackups)用于查询云数据库实例的备份数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public async Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest req)
        {
             JsonResponseModel<DescribeBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBackups接口的同步版本，本接口(DescribeBackups)用于查询云数据库实例的备份数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBackupsRequest"/></param>
        /// <returns>参考<see cref="DescribeBackupsResponse"/>实例</returns>
        public DescribeBackupsResponse DescribeBackupsSync(DescribeBackupsRequest req)
        {
             JsonResponseModel<DescribeBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeBinlogs)用于查询云数据库实例的二进制数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public async Task<DescribeBinlogsResponse> DescribeBinlogs(DescribeBinlogsRequest req)
        {
             JsonResponseModel<DescribeBinlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBinlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBinlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBinlogs接口的同步版本，本接口(DescribeBinlogs)用于查询云数据库实例的二进制数据。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBinlogsRequest"/></param>
        /// <returns>参考<see cref="DescribeBinlogsResponse"/>实例</returns>
        public DescribeBinlogsResponse DescribeBinlogsSync(DescribeBinlogsRequest req)
        {
             JsonResponseModel<DescribeBinlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBinlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBinlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBImportRecords)用于查询云数据库导入任务操作日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBImportRecordsResponse"/></returns>
        public async Task<DescribeDBImportRecordsResponse> DescribeDBImportRecords(DescribeDBImportRecordsRequest req)
        {
             JsonResponseModel<DescribeDBImportRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBImportRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBImportRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBImportRecords接口的同步版本，本接口(DescribeDBImportRecords)用于查询云数据库导入任务操作日志。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBImportRecordsResponse"/>实例</returns>
        public DescribeDBImportRecordsResponse DescribeDBImportRecordsSync(DescribeDBImportRecordsRequest req)
        {
             JsonResponseModel<DescribeDBImportRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBImportRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBImportRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceCharset)用于查询云数据库实例的字符集，获取字符集的名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceCharsetResponse"/></returns>
        public async Task<DescribeDBInstanceCharsetResponse> DescribeDBInstanceCharset(DescribeDBInstanceCharsetRequest req)
        {
             JsonResponseModel<DescribeDBInstanceCharsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceCharset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceCharsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBInstanceCharset接口的同步版本，本接口(DescribeDBInstanceCharset)用于查询云数据库实例的字符集，获取字符集的名称。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstanceCharsetResponse"/>实例</returns>
        public DescribeDBInstanceCharsetResponse DescribeDBInstanceCharsetSync(DescribeDBInstanceCharsetRequest req)
        {
             JsonResponseModel<DescribeDBInstanceCharsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceCharset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceCharsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceConfig)用于云数据库实例的配置信息，包括同步模式，部署模式等。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceConfigResponse"/></returns>
        public async Task<DescribeDBInstanceConfigResponse> DescribeDBInstanceConfig(DescribeDBInstanceConfigRequest req)
        {
             JsonResponseModel<DescribeDBInstanceConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBInstanceConfig接口的同步版本，本接口(DescribeDBInstanceConfig)用于云数据库实例的配置信息，包括同步模式，部署模式等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstanceConfigResponse"/>实例</returns>
        public DescribeDBInstanceConfigResponse DescribeDBInstanceConfigSync(DescribeDBInstanceConfigRequest req)
        {
             JsonResponseModel<DescribeDBInstanceConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceGTID)用于查询云数据库实例是否开通了 GTID，不支持版本为 5.5 以及以下的实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceGTIDResponse"/></returns>
        public async Task<DescribeDBInstanceGTIDResponse> DescribeDBInstanceGTID(DescribeDBInstanceGTIDRequest req)
        {
             JsonResponseModel<DescribeDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBInstanceGTID接口的同步版本，本接口(DescribeDBInstanceGTID)用于查询云数据库实例是否开通了 GTID，不支持版本为 5.5 以及以下的实例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstanceGTIDResponse"/>实例</returns>
        public DescribeDBInstanceGTIDResponse DescribeDBInstanceGTIDSync(DescribeDBInstanceGTIDRequest req)
        {
             JsonResponseModel<DescribeDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstanceRebootTime)用于查询云数据库实例重启预计所需的时间。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceRebootTimeResponse"/></returns>
        public async Task<DescribeDBInstanceRebootTimeResponse> DescribeDBInstanceRebootTime(DescribeDBInstanceRebootTimeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceRebootTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceRebootTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceRebootTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBInstanceRebootTime接口的同步版本，本接口(DescribeDBInstanceRebootTime)用于查询云数据库实例重启预计所需的时间。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns>参考<see cref="DescribeDBInstanceRebootTimeResponse"/>实例</returns>
        public DescribeDBInstanceRebootTimeResponse DescribeDBInstanceRebootTimeSync(DescribeDBInstanceRebootTimeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceRebootTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceRebootTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceRebootTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目 ID、实例 ID、访问地址、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
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
        /// DescribeDBInstances接口的同步版本，本接口(DescribeDBInstances)用于查询云数据库实例列表，支持通过项目 ID、实例 ID、访问地址、实例状态等过滤条件来筛选实例。支持查询主实例、灾备实例和只读实例信息列表。
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
        /// 本接口(DescribeDBPrice)用于查询云数据库实例的价格，支持查询按量计费或者包年包月的价格。可传入实例类型、购买时长、购买数量、内存大小、硬盘大小和可用区信息等来查询实例价格。
        /// 
        /// 注意：对某个地域进行询价，请使用对应地域的接入点，接入点信息请参照 <a href="https://cloud.tencent.com/document/api/236/15832">服务地址</a> 文档。例如：对广州地域进行询价，请把请求发到：cdb.ap-guangzhou.tencentcloudapi.com。同理对上海地域询价，把请求发到：cdb.ap-shanghai.tencentcloudapi.com。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDBPriceResponse"/></returns>
        public async Task<DescribeDBPriceResponse> DescribeDBPrice(DescribeDBPriceRequest req)
        {
             JsonResponseModel<DescribeDBPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBPrice接口的同步版本，本接口(DescribeDBPrice)用于查询云数据库实例的价格，支持查询按量计费或者包年包月的价格。可传入实例类型、购买时长、购买数量、内存大小、硬盘大小和可用区信息等来查询实例价格。
        /// 
        /// 注意：对某个地域进行询价，请使用对应地域的接入点，接入点信息请参照 <a href="https://cloud.tencent.com/document/api/236/15832">服务地址</a> 文档。例如：对广州地域进行询价，请把请求发到：cdb.ap-guangzhou.tencentcloudapi.com。同理对上海地域询价，把请求发到：cdb.ap-shanghai.tencentcloudapi.com。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBPriceRequest"/></param>
        /// <returns>参考<see cref="DescribeDBPriceResponse"/>实例</returns>
        public DescribeDBPriceResponse DescribeDBPriceSync(DescribeDBPriceRequest req)
        {
             JsonResponseModel<DescribeDBPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public async Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBSecurityGroups接口的同步版本，本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBSecurityGroupsResponse"/>实例</returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBSwitchRecords)用于查询云数据库实例切换记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBSwitchRecordsResponse"/></returns>
        public async Task<DescribeDBSwitchRecordsResponse> DescribeDBSwitchRecords(DescribeDBSwitchRecordsRequest req)
        {
             JsonResponseModel<DescribeDBSwitchRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSwitchRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSwitchRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBSwitchRecords接口的同步版本，本接口(DescribeDBSwitchRecords)用于查询云数据库实例切换记录。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns>参考<see cref="DescribeDBSwitchRecordsResponse"/>实例</returns>
        public DescribeDBSwitchRecordsResponse DescribeDBSwitchRecordsSync(DescribeDBSwitchRecordsRequest req)
        {
             JsonResponseModel<DescribeDBSwitchRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSwitchRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSwitchRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDBZoneConfig)用于查询可创建的云数据库各地域可售卖的规格配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeDBZoneConfigResponse"/></returns>
        public async Task<DescribeDBZoneConfigResponse> DescribeDBZoneConfig(DescribeDBZoneConfigRequest req)
        {
             JsonResponseModel<DescribeDBZoneConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBZoneConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBZoneConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDBZoneConfig接口的同步版本，本接口(DescribeDBZoneConfig)用于查询可创建的云数据库各地域可售卖的规格配置。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDBZoneConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeDBZoneConfigResponse"/>实例</returns>
        public DescribeDBZoneConfigResponse DescribeDBZoneConfigSync(DescribeDBZoneConfigRequest req)
        {
             JsonResponseModel<DescribeDBZoneConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBZoneConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBZoneConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDatabases)用于查询云数据库实例的数据库信息。
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
        /// DescribeDatabases接口的同步版本，本接口(DescribeDatabases)用于查询云数据库实例的数据库信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDatabasesRequest"/></param>
        /// <returns>参考<see cref="DescribeDatabasesResponse"/>实例</returns>
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
        /// 该接口（DescribeDefaultParams）用于查询默认的可设置参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns><see cref="DescribeDefaultParamsResponse"/></returns>
        public async Task<DescribeDefaultParamsResponse> DescribeDefaultParams(DescribeDefaultParamsRequest req)
        {
             JsonResponseModel<DescribeDefaultParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDefaultParams接口的同步版本，该接口（DescribeDefaultParams）用于查询默认的可设置参数列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns>参考<see cref="DescribeDefaultParamsResponse"/>实例</returns>
        public DescribeDefaultParamsResponse DescribeDefaultParamsSync(DescribeDefaultParamsRequest req)
        {
             JsonResponseModel<DescribeDefaultParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeDeployGroupList)用于查询用户的置放群组列表，可以指定置放群组 ID 或置放群组名称。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployGroupListRequest"/></param>
        /// <returns><see cref="DescribeDeployGroupListResponse"/></returns>
        public async Task<DescribeDeployGroupListResponse> DescribeDeployGroupList(DescribeDeployGroupListRequest req)
        {
             JsonResponseModel<DescribeDeployGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeployGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeployGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeployGroupList接口的同步版本，本接口(DescribeDeployGroupList)用于查询用户的置放群组列表，可以指定置放群组 ID 或置放群组名称。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeployGroupListRequest"/></param>
        /// <returns>参考<see cref="DescribeDeployGroupListResponse"/>实例</returns>
        public DescribeDeployGroupListResponse DescribeDeployGroupListSync(DescribeDeployGroupListRequest req)
        {
             JsonResponseModel<DescribeDeployGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeployGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeployGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceMonitorInfo）用于查询云数据库物理机当天的监控信息，暂只支持内存488G、硬盘6T的实例查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorInfoResponse"/></returns>
        public async Task<DescribeDeviceMonitorInfoResponse> DescribeDeviceMonitorInfo(DescribeDeviceMonitorInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceMonitorInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceMonitorInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceMonitorInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDeviceMonitorInfo接口的同步版本，本接口（DescribeDeviceMonitorInfo）用于查询云数据库物理机当天的监控信息，暂只支持内存488G、硬盘6T的实例查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDeviceMonitorInfoResponse"/>实例</returns>
        public DescribeDeviceMonitorInfoResponse DescribeDeviceMonitorInfoSync(DescribeDeviceMonitorInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceMonitorInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceMonitorInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceMonitorInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeInstanceParamRecords）用于查询实例参数修改历史。
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
        /// DescribeInstanceParamRecords接口的同步版本，该接口（DescribeInstanceParamRecords）用于查询实例参数修改历史。
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
        /// 该接口（DescribeInstanceParams）用于查询实例的参数列表。
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
        /// DescribeInstanceParams接口的同步版本，该接口（DescribeInstanceParams）用于查询实例的参数列表。
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
        /// 该接口（DescribeParamTemplateInfo）用于查询参数模板详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public async Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeParamTemplateInfo接口的同步版本，该接口（DescribeParamTemplateInfo）用于查询参数模板详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeParamTemplateInfoResponse"/>实例</returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeParamTemplates）查询参数模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public async Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeParamTemplates接口的同步版本，该接口（DescribeParamTemplates）查询参数模板列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns>参考<see cref="DescribeParamTemplatesResponse"/>实例</returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProjectSecurityGroups接口的同步版本，本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeProjectSecurityGroupsResponse"/>实例</returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeRollbackRangeTime)用于查询云数据库实例可回档的时间范围。
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackRangeTimeResponse"/></returns>
        public async Task<DescribeRollbackRangeTimeResponse> DescribeRollbackRangeTime(DescribeRollbackRangeTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackRangeTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRollbackRangeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackRangeTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRollbackRangeTime接口的同步版本，本接口(DescribeRollbackRangeTime)用于查询云数据库实例可回档的时间范围。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns>参考<see cref="DescribeRollbackRangeTimeResponse"/>实例</returns>
        public DescribeRollbackRangeTimeResponse DescribeRollbackRangeTimeSync(DescribeRollbackRangeTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackRangeTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRollbackRangeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackRangeTimeResponse>>(strResp);
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
        /// DescribeSlowLogs接口的同步版本，本接口(DescribeSlowLogs)用于获取云数据库实例的慢查询日志。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSlowLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeSlowLogsResponse"/>实例</returns>
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
        /// 本接口(DescribeSupportedPrivileges)用于查询云数据库的支持的权限信息，包括全局权限，数据库权限，表权限以及列权限。
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeSupportedPrivilegesResponse"/></returns>
        public async Task<DescribeSupportedPrivilegesResponse> DescribeSupportedPrivileges(DescribeSupportedPrivilegesRequest req)
        {
             JsonResponseModel<DescribeSupportedPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSupportedPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportedPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSupportedPrivileges接口的同步版本，本接口(DescribeSupportedPrivileges)用于查询云数据库的支持的权限信息，包括全局权限，数据库权限，表权限以及列权限。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns>参考<see cref="DescribeSupportedPrivilegesResponse"/>实例</returns>
        public DescribeSupportedPrivilegesResponse DescribeSupportedPrivilegesSync(DescribeSupportedPrivilegesRequest req)
        {
             JsonResponseModel<DescribeSupportedPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSupportedPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportedPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeTables)用于查询云数据库实例的数据库表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public async Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTables接口的同步版本，本接口(DescribeTables)用于查询云数据库实例的数据库表信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTablesRequest"/></param>
        /// <returns>参考<see cref="DescribeTablesResponse"/>实例</returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeTagsOfInstanceIds)用于获取云数据库实例的标签信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeTagsOfInstanceIdsResponse"/></returns>
        public async Task<DescribeTagsOfInstanceIdsResponse> DescribeTagsOfInstanceIds(DescribeTagsOfInstanceIdsRequest req)
        {
             JsonResponseModel<DescribeTagsOfInstanceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagsOfInstanceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsOfInstanceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTagsOfInstanceIds接口的同步版本，本接口(DescribeTagsOfInstanceIds)用于获取云数据库实例的标签信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns>参考<see cref="DescribeTagsOfInstanceIdsResponse"/>实例</returns>
        public DescribeTagsOfInstanceIdsResponse DescribeTagsOfInstanceIdsSync(DescribeTagsOfInstanceIdsRequest req)
        {
             JsonResponseModel<DescribeTagsOfInstanceIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagsOfInstanceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsOfInstanceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeTasks)用于查询云数据库实例任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTasks接口的同步版本，本接口(DescribeTasks)用于查询云数据库实例任务列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeTasksResponse"/>实例</returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeTimeWindow)用于查询云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeTimeWindowResponse"/></returns>
        public async Task<DescribeTimeWindowResponse> DescribeTimeWindow(DescribeTimeWindowRequest req)
        {
             JsonResponseModel<DescribeTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTimeWindow接口的同步版本，本接口(DescribeTimeWindow)用于查询云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTimeWindowRequest"/></param>
        /// <returns>参考<see cref="DescribeTimeWindowResponse"/>实例</returns>
        public DescribeTimeWindowResponse DescribeTimeWindowSync(DescribeTimeWindowRequest req)
        {
             JsonResponseModel<DescribeTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeUploadedFiles)用于查询用户导入的SQL文件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns><see cref="DescribeUploadedFilesResponse"/></returns>
        public async Task<DescribeUploadedFilesResponse> DescribeUploadedFiles(DescribeUploadedFilesRequest req)
        {
             JsonResponseModel<DescribeUploadedFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUploadedFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUploadedFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUploadedFiles接口的同步版本，本接口(DescribeUploadedFiles)用于查询用户导入的SQL文件列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns>参考<see cref="DescribeUploadedFilesResponse"/>实例</returns>
        public DescribeUploadedFilesResponse DescribeUploadedFilesSync(DescribeUploadedFilesRequest req)
        {
             JsonResponseModel<DescribeUploadedFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUploadedFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUploadedFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisassociateSecurityGroups接口的同步版本，本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req">参考<see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="DisassociateSecurityGroupsResponse"/>实例</returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(InitDBInstances)用于初始化云数据库实例，包括初始化密码、默认字符集、实例端口号等
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
        /// InitDBInstances接口的同步版本，本接口(InitDBInstances)用于初始化云数据库实例，包括初始化密码、默认字符集、实例端口号等
        /// </summary>
        /// <param name="req">参考<see cref="InitDBInstancesRequest"/></param>
        /// <returns>参考<see cref="InitDBInstancesResponse"/>实例</returns>
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
        /// 本接口(InquiryPriceUpgradeInstances)用于查询云数据库实例升级的价格，支持查询按量计费或者包年包月实例的升级价格，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeInstancesResponse"/></returns>
        public async Task<InquiryPriceUpgradeInstancesResponse> InquiryPriceUpgradeInstances(InquiryPriceUpgradeInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpgradeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// InquiryPriceUpgradeInstances接口的同步版本，本接口(InquiryPriceUpgradeInstances)用于查询云数据库实例升级的价格，支持查询按量计费或者包年包月实例的升级价格，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceUpgradeInstancesRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceUpgradeInstancesResponse"/>实例</returns>
        public InquiryPriceUpgradeInstancesResponse InquiryPriceUpgradeInstancesSync(InquiryPriceUpgradeInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpgradeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(IsolateDBInstance)用于隔离云数据库实例，隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
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
        /// IsolateDBInstance接口的同步版本，本接口(IsolateDBInstance)用于隔离云数据库实例，隔离后不能通过IP和端口访问数据库。隔离的实例可在回收站中进行开机。若为欠费隔离，请尽快进行充值。
        /// </summary>
        /// <param name="req">参考<see cref="IsolateDBInstanceRequest"/></param>
        /// <returns>参考<see cref="IsolateDBInstanceResponse"/>实例</returns>
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
        /// 本接口(ModifyAccountDescription)用于修改云数据库账户的备注信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAccountDescription接口的同步版本，本接口(ModifyAccountDescription)用于修改云数据库账户的备注信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns>参考<see cref="ModifyAccountDescriptionResponse"/>实例</returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyAccountPassword)用于修改云数据库账户的密码。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyAccountPasswordResponse"/></returns>
        public async Task<ModifyAccountPasswordResponse> ModifyAccountPassword(ModifyAccountPasswordRequest req)
        {
             JsonResponseModel<ModifyAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAccountPassword接口的同步版本，本接口(ModifyAccountPassword)用于修改云数据库账户的密码。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns>参考<see cref="ModifyAccountPasswordResponse"/>实例</returns>
        public ModifyAccountPasswordResponse ModifyAccountPasswordSync(ModifyAccountPasswordRequest req)
        {
             JsonResponseModel<ModifyAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyAccountPrivileges)用于修改云数据库的账户的权限信息。
        /// 
        /// 注意，修改账号权限时，需要传入该账号下的全量权限信息。用户可以先通过 [查询云数据库账户的权限信息
        /// ](https://cloud.tencent.com/document/api/236/17500) 查询该账号下的全量权限信息，然后进行权限修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public async Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAccountPrivileges接口的同步版本，本接口(ModifyAccountPrivileges)用于修改云数据库的账户的权限信息。
        /// 
        /// 注意，修改账号权限时，需要传入该账号下的全量权限信息。用户可以先通过 [查询云数据库账户的权限信息
        /// ](https://cloud.tencent.com/document/api/236/17500) 查询该账号下的全量权限信息，然后进行权限修改。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns>参考<see cref="ModifyAccountPrivilegesResponse"/>实例</returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyAutoRenewFlag)用于修改云数据库实例的自动续费标记。仅支持包年包月的实例设置自动续费标记。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public async Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAutoRenewFlag接口的同步版本，本接口(ModifyAutoRenewFlag)用于修改云数据库实例的自动续费标记。仅支持包年包月的实例设置自动续费标记。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyAutoRenewFlagResponse"/>实例</returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyBackupConfig)用于修改数据库备份配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public async Task<ModifyBackupConfigResponse> ModifyBackupConfig(ModifyBackupConfigRequest req)
        {
             JsonResponseModel<ModifyBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyBackupConfig接口的同步版本，本接口(ModifyBackupConfig)用于修改数据库备份配置信息。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyBackupConfigRequest"/></param>
        /// <returns>参考<see cref="ModifyBackupConfigResponse"/>实例</returns>
        public ModifyBackupConfigResponse ModifyBackupConfigSync(ModifyBackupConfigRequest req)
        {
             JsonResponseModel<ModifyBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceName)用于修改云数据库实例的名称。
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
        /// ModifyDBInstanceName接口的同步版本，本接口(ModifyDBInstanceName)用于修改云数据库实例的名称。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceNameResponse"/>实例</returns>
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
        /// 本接口(ModifyDBInstanceProject)用于修改云数据库实例的所属项目。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public async Task<ModifyDBInstanceProjectResponse> ModifyDBInstanceProject(ModifyDBInstanceProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstanceProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDBInstanceProject接口的同步版本，本接口(ModifyDBInstanceProject)用于修改云数据库实例的所属项目。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceProjectResponse"/>实例</returns>
        public ModifyDBInstanceProjectResponse ModifyDBInstanceProjectSync(ModifyDBInstanceProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstanceProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
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
        /// ModifyDBInstanceSecurityGroups接口的同步版本，本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceSecurityGroupsResponse"/>实例</returns>
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
        /// 本接口(ModifyDBInstanceVipVport)用于修改云数据库实例的IP和端口号，也可进行基础网络转 VPC 网络和 VPC 网络下的子网变更。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVipVportResponse"/></returns>
        public async Task<ModifyDBInstanceVipVportResponse> ModifyDBInstanceVipVport(ModifyDBInstanceVipVportRequest req)
        {
             JsonResponseModel<ModifyDBInstanceVipVportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceVipVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceVipVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDBInstanceVipVport接口的同步版本，本接口(ModifyDBInstanceVipVport)用于修改云数据库实例的IP和端口号，也可进行基础网络转 VPC 网络和 VPC 网络下的子网变更。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns>参考<see cref="ModifyDBInstanceVipVportResponse"/>实例</returns>
        public ModifyDBInstanceVipVportResponse ModifyDBInstanceVipVportSync(ModifyDBInstanceVipVportRequest req)
        {
             JsonResponseModel<ModifyDBInstanceVipVportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceVipVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceVipVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyInstanceParam)用于修改云数据库实例的参数。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public async Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
             JsonResponseModel<ModifyInstanceParamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstanceParam接口的同步版本，本接口(ModifyInstanceParam)用于修改云数据库实例的参数。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstanceParamRequest"/></param>
        /// <returns>参考<see cref="ModifyInstanceParamResponse"/>实例</returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
             JsonResponseModel<ModifyInstanceParamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyInstanceTag)用于对实例标签进行添加、修改或者删除。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTagRequest"/></param>
        /// <returns><see cref="ModifyInstanceTagResponse"/></returns>
        public async Task<ModifyInstanceTagResponse> ModifyInstanceTag(ModifyInstanceTagRequest req)
        {
             JsonResponseModel<ModifyInstanceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyInstanceTag接口的同步版本，本接口(ModifyInstanceTag)用于对实例标签进行添加、修改或者删除。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyInstanceTagRequest"/></param>
        /// <returns>参考<see cref="ModifyInstanceTagResponse"/>实例</returns>
        public ModifyInstanceTagResponse ModifyInstanceTagSync(ModifyInstanceTagRequest req)
        {
             JsonResponseModel<ModifyInstanceTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改置放群组的名称或者描述
        /// </summary>
        /// <param name="req"><see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns><see cref="ModifyNameOrDescByDpIdResponse"/></returns>
        public async Task<ModifyNameOrDescByDpIdResponse> ModifyNameOrDescByDpId(ModifyNameOrDescByDpIdRequest req)
        {
             JsonResponseModel<ModifyNameOrDescByDpIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNameOrDescByDpId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNameOrDescByDpIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyNameOrDescByDpId接口的同步版本，修改置放群组的名称或者描述
        /// </summary>
        /// <param name="req">参考<see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns>参考<see cref="ModifyNameOrDescByDpIdResponse"/>实例</returns>
        public ModifyNameOrDescByDpIdResponse ModifyNameOrDescByDpIdSync(ModifyNameOrDescByDpIdRequest req)
        {
             JsonResponseModel<ModifyNameOrDescByDpIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNameOrDescByDpId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNameOrDescByDpIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（ModifyParamTemplate）用于修改参数模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public async Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyParamTemplate接口的同步版本，该接口（ModifyParamTemplate）用于修改参数模板。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyParamTemplateRequest"/></param>
        /// <returns>参考<see cref="ModifyParamTemplateResponse"/>实例</returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyTimeWindow)用于更新云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req"><see cref="ModifyTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyTimeWindowResponse"/></returns>
        public async Task<ModifyTimeWindowResponse> ModifyTimeWindow(ModifyTimeWindowRequest req)
        {
             JsonResponseModel<ModifyTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTimeWindow接口的同步版本，本接口(ModifyTimeWindow)用于更新云数据库实例的维护时间窗口。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTimeWindowRequest"/></param>
        /// <returns>参考<see cref="ModifyTimeWindowResponse"/>实例</returns>
        public ModifyTimeWindowResponse ModifyTimeWindowSync(ModifyTimeWindowRequest req)
        {
             JsonResponseModel<ModifyTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(OfflineIsolatedInstances)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态，即通过 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询到 Status 值为 5 的实例。
        /// 
        /// 该接口为异步操作，部分资源的回收可能存在延迟。您可以通过使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口，指定实例 InstanceId 和状态 Status 为 [5,6,7] 进行查询，若返回实例为空，则实例资源已全部释放。
        /// 
        /// 注意，实例下线后，相关资源和数据将无法找回，请谨慎操作。
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns><see cref="OfflineIsolatedInstancesResponse"/></returns>
        public async Task<OfflineIsolatedInstancesResponse> OfflineIsolatedInstances(OfflineIsolatedInstancesRequest req)
        {
             JsonResponseModel<OfflineIsolatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OfflineIsolatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// OfflineIsolatedInstances接口的同步版本，本接口(OfflineIsolatedInstances)用于立即下线隔离状态的云数据库实例。进行操作的实例状态必须为隔离状态，即通过 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口查询到 Status 值为 5 的实例。
        /// 
        /// 该接口为异步操作，部分资源的回收可能存在延迟。您可以通过使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口，指定实例 InstanceId 和状态 Status 为 [5,6,7] 进行查询，若返回实例为空，则实例资源已全部释放。
        /// 
        /// 注意，实例下线后，相关资源和数据将无法找回，请谨慎操作。
        /// </summary>
        /// <param name="req">参考<see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns>参考<see cref="OfflineIsolatedInstancesResponse"/>实例</returns>
        public OfflineIsolatedInstancesResponse OfflineIsolatedInstancesSync(OfflineIsolatedInstancesRequest req)
        {
             JsonResponseModel<OfflineIsolatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OfflineIsolatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(OpenDBInstanceGTID)用于开启云数据库实例的 GTID，只支持版本为 5.6 以及以上的实例。
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="OpenDBInstanceGTIDResponse"/></returns>
        public async Task<OpenDBInstanceGTIDResponse> OpenDBInstanceGTID(OpenDBInstanceGTIDRequest req)
        {
             JsonResponseModel<OpenDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// OpenDBInstanceGTID接口的同步版本，本接口(OpenDBInstanceGTID)用于开启云数据库实例的 GTID，只支持版本为 5.6 以及以上的实例。
        /// </summary>
        /// <param name="req">参考<see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns>参考<see cref="OpenDBInstanceGTIDResponse"/>实例</returns>
        public OpenDBInstanceGTIDResponse OpenDBInstanceGTIDSync(OpenDBInstanceGTIDRequest req)
        {
             JsonResponseModel<OpenDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(OpenWanService)用于开通实例外网访问。
        /// 
        /// 注意，实例开通外网访问之前，需要先将实例进行 [实例初始化](https://cloud.tencent.com/document/api/236/15873) 操作。
        /// </summary>
        /// <param name="req"><see cref="OpenWanServiceRequest"/></param>
        /// <returns><see cref="OpenWanServiceResponse"/></returns>
        public async Task<OpenWanServiceResponse> OpenWanService(OpenWanServiceRequest req)
        {
             JsonResponseModel<OpenWanServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenWanServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// OpenWanService接口的同步版本，本接口(OpenWanService)用于开通实例外网访问。
        /// 
        /// 注意，实例开通外网访问之前，需要先将实例进行 [实例初始化](https://cloud.tencent.com/document/api/236/15873) 操作。
        /// </summary>
        /// <param name="req">参考<see cref="OpenWanServiceRequest"/></param>
        /// <returns>参考<see cref="OpenWanServiceResponse"/>实例</returns>
        public OpenWanServiceResponse OpenWanServiceSync(OpenWanServiceRequest req)
        {
             JsonResponseModel<OpenWanServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenWanServiceResponse>>(strResp);
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
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public async Task<RenewDBInstanceResponse> RenewDBInstance(RenewDBInstanceRequest req)
        {
             JsonResponseModel<RenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RenewDBInstance接口的同步版本，本接口(RenewDBInstance)用于续费云数据库实例，仅支持付费模式为包年包月的实例。按量计费实例不需要续费。
        /// </summary>
        /// <param name="req">参考<see cref="RenewDBInstanceRequest"/></param>
        /// <returns>参考<see cref="RenewDBInstanceResponse"/>实例</returns>
        public RenewDBInstanceResponse RenewDBInstanceSync(RenewDBInstanceRequest req)
        {
             JsonResponseModel<RenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(RestartDBInstances)用于重启云数据库实例。
        /// 
        /// 注意：
        /// 1、本接口只支持主实例进行重启操作；
        /// 2、实例状态必须为正常，并且没有其他异步任务在执行中。
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public async Task<RestartDBInstancesResponse> RestartDBInstances(RestartDBInstancesRequest req)
        {
             JsonResponseModel<RestartDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RestartDBInstances接口的同步版本，本接口(RestartDBInstances)用于重启云数据库实例。
        /// 
        /// 注意：
        /// 1、本接口只支持主实例进行重启操作；
        /// 2、实例状态必须为正常，并且没有其他异步任务在执行中。
        /// </summary>
        /// <param name="req">参考<see cref="RestartDBInstancesRequest"/></param>
        /// <returns>参考<see cref="RestartDBInstancesResponse"/>实例</returns>
        public RestartDBInstancesResponse RestartDBInstancesSync(RestartDBInstancesRequest req)
        {
             JsonResponseModel<RestartDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（StartBatchRollback）用于批量回档云数据库实例的库表。
        /// </summary>
        /// <param name="req"><see cref="StartBatchRollbackRequest"/></param>
        /// <returns><see cref="StartBatchRollbackResponse"/></returns>
        public async Task<StartBatchRollbackResponse> StartBatchRollback(StartBatchRollbackRequest req)
        {
             JsonResponseModel<StartBatchRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartBatchRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartBatchRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StartBatchRollback接口的同步版本，该接口（StartBatchRollback）用于批量回档云数据库实例的库表。
        /// </summary>
        /// <param name="req">参考<see cref="StartBatchRollbackRequest"/></param>
        /// <returns>参考<see cref="StartBatchRollbackResponse"/>实例</returns>
        public StartBatchRollbackResponse StartBatchRollbackSync(StartBatchRollbackRequest req)
        {
             JsonResponseModel<StartBatchRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartBatchRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartBatchRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(StopDBImportJob)用于终止数据导入任务。
        /// </summary>
        /// <param name="req"><see cref="StopDBImportJobRequest"/></param>
        /// <returns><see cref="StopDBImportJobResponse"/></returns>
        public async Task<StopDBImportJobResponse> StopDBImportJob(StopDBImportJobRequest req)
        {
             JsonResponseModel<StopDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// StopDBImportJob接口的同步版本，本接口(StopDBImportJob)用于终止数据导入任务。
        /// </summary>
        /// <param name="req">参考<see cref="StopDBImportJobRequest"/></param>
        /// <returns>参考<see cref="StopDBImportJobResponse"/>实例</returns>
        public StopDBImportJobResponse StopDBImportJobSync(StopDBImportJobRequest req)
        {
             JsonResponseModel<StopDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(SwitchForUpgrade)用于切换访问新实例，针对主升级中的实例处于待切换状态时，用户可主动发起该流程。
        /// </summary>
        /// <param name="req"><see cref="SwitchForUpgradeRequest"/></param>
        /// <returns><see cref="SwitchForUpgradeResponse"/></returns>
        public async Task<SwitchForUpgradeResponse> SwitchForUpgrade(SwitchForUpgradeRequest req)
        {
             JsonResponseModel<SwitchForUpgradeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchForUpgrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchForUpgradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SwitchForUpgrade接口的同步版本，本接口(SwitchForUpgrade)用于切换访问新实例，针对主升级中的实例处于待切换状态时，用户可主动发起该流程。
        /// </summary>
        /// <param name="req">参考<see cref="SwitchForUpgradeRequest"/></param>
        /// <returns>参考<see cref="SwitchForUpgradeResponse"/>实例</returns>
        public SwitchForUpgradeResponse SwitchForUpgradeSync(SwitchForUpgradeRequest req)
        {
             JsonResponseModel<SwitchForUpgradeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchForUpgrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchForUpgradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(UpgradeDBInstance)用于升级或降级云数据库实例的配置，实例类型支持主实例、灾备实例和只读实例。
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
        /// UpgradeDBInstance接口的同步版本，本接口(UpgradeDBInstance)用于升级或降级云数据库实例的配置，实例类型支持主实例、灾备实例和只读实例。
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
        /// 本接口(UpgradeDBInstanceEngineVersion)用于升级云数据库实例版本，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceEngineVersionResponse"/></returns>
        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceEngineVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstanceEngineVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceEngineVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// UpgradeDBInstanceEngineVersion接口的同步版本，本接口(UpgradeDBInstanceEngineVersion)用于升级云数据库实例版本，实例类型支持主实例、灾备实例和只读实例。
        /// </summary>
        /// <param name="req">参考<see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns>参考<see cref="UpgradeDBInstanceEngineVersionResponse"/>实例</returns>
        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersionSync(UpgradeDBInstanceEngineVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceEngineVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstanceEngineVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceEngineVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(VerifyRootAccount)用于校验云数据库实例的 ROOT 账号是否有足够的权限进行授权操作。
        /// </summary>
        /// <param name="req"><see cref="VerifyRootAccountRequest"/></param>
        /// <returns><see cref="VerifyRootAccountResponse"/></returns>
        public async Task<VerifyRootAccountResponse> VerifyRootAccount(VerifyRootAccountRequest req)
        {
             JsonResponseModel<VerifyRootAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyRootAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyRootAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VerifyRootAccount接口的同步版本，本接口(VerifyRootAccount)用于校验云数据库实例的 ROOT 账号是否有足够的权限进行授权操作。
        /// </summary>
        /// <param name="req">参考<see cref="VerifyRootAccountRequest"/></param>
        /// <returns>参考<see cref="VerifyRootAccountResponse"/>实例</returns>
        public VerifyRootAccountResponse VerifyRootAccountSync(VerifyRootAccountRequest req)
        {
             JsonResponseModel<VerifyRootAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyRootAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyRootAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
