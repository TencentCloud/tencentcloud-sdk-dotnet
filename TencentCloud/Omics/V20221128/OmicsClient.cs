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

namespace TencentCloud.Omics.V20221128
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Omics.V20221128.Models;

   public class OmicsClient : AbstractClient{

       private const string endpoint = "omics.tencentcloudapi.com";
       private const string version = "2022-11-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OmicsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OmicsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询任务批次列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunGroupsRequest"/></param>
        /// <returns><see cref="DescribeRunGroupsResponse"/></returns>
        public async Task<DescribeRunGroupsResponse> DescribeRunGroups(DescribeRunGroupsRequest req)
        {
             JsonResponseModel<DescribeRunGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRunGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务批次列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunGroupsRequest"/></param>
        /// <returns><see cref="DescribeRunGroupsResponse"/></returns>
        public DescribeRunGroupsResponse DescribeRunGroupsSync(DescribeRunGroupsRequest req)
        {
             JsonResponseModel<DescribeRunGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRunGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunsRequest"/></param>
        /// <returns><see cref="DescribeRunsResponse"/></returns>
        public async Task<DescribeRunsResponse> DescribeRuns(DescribeRunsRequest req)
        {
             JsonResponseModel<DescribeRunsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRunsRequest"/></param>
        /// <returns><see cref="DescribeRunsResponse"/></returns>
        public DescribeRunsResponse DescribeRunsSync(DescribeRunsRequest req)
        {
             JsonResponseModel<DescribeRunsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRunsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作业详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunCallsRequest"/></param>
        /// <returns><see cref="GetRunCallsResponse"/></returns>
        public async Task<GetRunCallsResponse> GetRunCalls(GetRunCallsRequest req)
        {
             JsonResponseModel<GetRunCallsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRunCalls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRunCallsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作业详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunCallsRequest"/></param>
        /// <returns><see cref="GetRunCallsResponse"/></returns>
        public GetRunCallsResponse GetRunCallsSync(GetRunCallsRequest req)
        {
             JsonResponseModel<GetRunCallsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRunCalls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRunCallsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunStatusRequest"/></param>
        /// <returns><see cref="GetRunStatusResponse"/></returns>
        public async Task<GetRunStatusResponse> GetRunStatus(GetRunStatusRequest req)
        {
             JsonResponseModel<GetRunStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRunStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRunStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务详情。
        /// </summary>
        /// <param name="req"><see cref="GetRunStatusRequest"/></param>
        /// <returns><see cref="GetRunStatusResponse"/></returns>
        public GetRunStatusResponse GetRunStatusSync(GetRunStatusRequest req)
        {
             JsonResponseModel<GetRunStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRunStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRunStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入表格文件。
        /// </summary>
        /// <param name="req"><see cref="ImportTableFileRequest"/></param>
        /// <returns><see cref="ImportTableFileResponse"/></returns>
        public async Task<ImportTableFileResponse> ImportTableFile(ImportTableFileRequest req)
        {
             JsonResponseModel<ImportTableFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportTableFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportTableFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入表格文件。
        /// </summary>
        /// <param name="req"><see cref="ImportTableFileRequest"/></param>
        /// <returns><see cref="ImportTableFileResponse"/></returns>
        public ImportTableFileResponse ImportTableFileSync(ImportTableFileRequest req)
        {
             JsonResponseModel<ImportTableFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportTableFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportTableFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行应用。
        /// </summary>
        /// <param name="req"><see cref="RunApplicationRequest"/></param>
        /// <returns><see cref="RunApplicationResponse"/></returns>
        public async Task<RunApplicationResponse> RunApplication(RunApplicationRequest req)
        {
             JsonResponseModel<RunApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行应用。
        /// </summary>
        /// <param name="req"><see cref="RunApplicationRequest"/></param>
        /// <returns><see cref="RunApplicationResponse"/></returns>
        public RunApplicationResponse RunApplicationSync(RunApplicationRequest req)
        {
             JsonResponseModel<RunApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
