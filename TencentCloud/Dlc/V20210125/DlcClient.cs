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

namespace TencentCloud.Dlc.V20210125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dlc.V20210125.Models;

   public class DlcClient : AbstractClient{

       private const string endpoint = "dlc.tencentcloudapi.com";
       private const string version = "2021-01-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DlcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DlcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（CreateDatabase）用于生成建库SQL语句。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public async Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest req)
        {
             JsonResponseModel<CreateDatabaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDatabase）用于生成建库SQL语句。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public CreateDatabaseResponse CreateDatabaseSync(CreateDatabaseRequest req)
        {
             JsonResponseModel<CreateDatabaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateScript）用于创建sql脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptRequest"/></param>
        /// <returns><see cref="CreateScriptResponse"/></returns>
        public async Task<CreateScriptResponse> CreateScript(CreateScriptRequest req)
        {
             JsonResponseModel<CreateScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateScript）用于创建sql脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptRequest"/></param>
        /// <returns><see cref="CreateScriptResponse"/></returns>
        public CreateScriptResponse CreateScriptSync(CreateScriptRequest req)
        {
             JsonResponseModel<CreateScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTable）用于生成建表SQL。
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public async Task<CreateTableResponse> CreateTable(CreateTableRequest req)
        {
             JsonResponseModel<CreateTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTable）用于生成建表SQL。
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public CreateTableResponse CreateTableSync(CreateTableRequest req)
        {
             JsonResponseModel<CreateTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTask）用于创建sql查询任务。
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTask）用于创建sql查询任务。
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DeleteScript）用于删除sql脚本。
        /// </summary>
        /// <param name="req"><see cref="DeleteScriptRequest"/></param>
        /// <returns><see cref="DeleteScriptResponse"/></returns>
        public async Task<DeleteScriptResponse> DeleteScript(DeleteScriptRequest req)
        {
             JsonResponseModel<DeleteScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DeleteScript）用于删除sql脚本。
        /// </summary>
        /// <param name="req"><see cref="DeleteScriptRequest"/></param>
        /// <returns><see cref="DeleteScriptResponse"/></returns>
        public DeleteScriptResponse DeleteScriptSync(DeleteScriptRequest req)
        {
             JsonResponseModel<DeleteScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询数据库列表。
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
        /// 本接口（DescribeDatabases）用于查询数据库列表。
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
        /// 该接口（DescribeScripts）用于获取所有SQL查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsRequest"/></param>
        /// <returns><see cref="DescribeScriptsResponse"/></returns>
        public async Task<DescribeScriptsResponse> DescribeScripts(DescribeScriptsRequest req)
        {
             JsonResponseModel<DescribeScriptsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeScripts）用于获取所有SQL查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsRequest"/></param>
        /// <returns><see cref="DescribeScriptsResponse"/></returns>
        public DescribeScriptsResponse DescribeScriptsSync(DescribeScriptsRequest req)
        {
             JsonResponseModel<DescribeScriptsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个表的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public async Task<DescribeTableResponse> DescribeTable(DescribeTableRequest req)
        {
             JsonResponseModel<DescribeTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个表的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public DescribeTableResponse DescribeTableSync(DescribeTableRequest req)
        {
             JsonResponseModel<DescribeTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribleTables）用于查询数据表列表。
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
        /// 本接口（DescribleTables）用于查询数据表列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
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
        /// 该接口（DescribleTasks）用于查询任务列表
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
        /// 该接口（DescribleTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
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
        /// 本接口（DescribeViews）用于查询数据视图列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public async Task<DescribeViewsResponse> DescribeViews(DescribeViewsRequest req)
        {
             JsonResponseModel<DescribeViewsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeViews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeViewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeViews）用于查询数据视图列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public DescribeViewsResponse DescribeViewsSync(DescribeViewsRequest req)
        {
             JsonResponseModel<DescribeViewsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeViews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeViewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
