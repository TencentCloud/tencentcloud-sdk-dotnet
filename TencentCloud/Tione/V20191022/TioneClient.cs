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

namespace TencentCloud.Tione.V20191022
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tione.V20191022.Models;

   public class TioneClient : AbstractClient{

       private const string endpoint = "tione.tencentcloudapi.com";
       private const string version = "2019-10-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TioneClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TioneClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建Notebook实例
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookInstanceRequest"/></param>
        /// <returns><see cref="CreateNotebookInstanceResponse"/></returns>
        public async Task<CreateNotebookInstanceResponse> CreateNotebookInstance(CreateNotebookInstanceRequest req)
        {
             JsonResponseModel<CreateNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Notebook实例
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookInstanceRequest"/></param>
        /// <returns><see cref="CreateNotebookInstanceResponse"/></returns>
        public CreateNotebookInstanceResponse CreateNotebookInstanceSync(CreateNotebookInstanceRequest req)
        {
             JsonResponseModel<CreateNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Notebook授权Url
        /// </summary>
        /// <param name="req"><see cref="CreatePresignedNotebookInstanceUrlRequest"/></param>
        /// <returns><see cref="CreatePresignedNotebookInstanceUrlResponse"/></returns>
        public async Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest req)
        {
             JsonResponseModel<CreatePresignedNotebookInstanceUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePresignedNotebookInstanceUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePresignedNotebookInstanceUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Notebook授权Url
        /// </summary>
        /// <param name="req"><see cref="CreatePresignedNotebookInstanceUrlRequest"/></param>
        /// <returns><see cref="CreatePresignedNotebookInstanceUrlResponse"/></returns>
        public CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrlSync(CreatePresignedNotebookInstanceUrlRequest req)
        {
             JsonResponseModel<CreatePresignedNotebookInstanceUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePresignedNotebookInstanceUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePresignedNotebookInstanceUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingJobRequest"/></param>
        /// <returns><see cref="CreateTrainingJobResponse"/></returns>
        public async Task<CreateTrainingJobResponse> CreateTrainingJob(CreateTrainingJobRequest req)
        {
             JsonResponseModel<CreateTrainingJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrainingJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建训练任务
        /// </summary>
        /// <param name="req"><see cref="CreateTrainingJobRequest"/></param>
        /// <returns><see cref="CreateTrainingJobResponse"/></returns>
        public CreateTrainingJobResponse CreateTrainingJobSync(CreateTrainingJobRequest req)
        {
             JsonResponseModel<CreateTrainingJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrainingJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTrainingJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除notebook实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookInstanceRequest"/></param>
        /// <returns><see cref="DeleteNotebookInstanceResponse"/></returns>
        public async Task<DeleteNotebookInstanceResponse> DeleteNotebookInstance(DeleteNotebookInstanceRequest req)
        {
             JsonResponseModel<DeleteNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除notebook实例
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookInstanceRequest"/></param>
        /// <returns><see cref="DeleteNotebookInstanceResponse"/></returns>
        public DeleteNotebookInstanceResponse DeleteNotebookInstanceSync(DeleteNotebookInstanceRequest req)
        {
             JsonResponseModel<DeleteNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Notebook实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstanceRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstanceResponse"/></returns>
        public async Task<DescribeNotebookInstanceResponse> DescribeNotebookInstance(DescribeNotebookInstanceRequest req)
        {
             JsonResponseModel<DescribeNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Notebook实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstanceRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstanceResponse"/></returns>
        public DescribeNotebookInstanceResponse DescribeNotebookInstanceSync(DescribeNotebookInstanceRequest req)
        {
             JsonResponseModel<DescribeNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Notebook实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstancesRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstancesResponse"/></returns>
        public async Task<DescribeNotebookInstancesResponse> DescribeNotebookInstances(DescribeNotebookInstancesRequest req)
        {
             JsonResponseModel<DescribeNotebookInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Notebook实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookInstancesRequest"/></param>
        /// <returns><see cref="DescribeNotebookInstancesResponse"/></returns>
        public DescribeNotebookInstancesResponse DescribeNotebookInstancesSync(DescribeNotebookInstancesRequest req)
        {
             JsonResponseModel<DescribeNotebookInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询训练任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingJobRequest"/></param>
        /// <returns><see cref="DescribeTrainingJobResponse"/></returns>
        public async Task<DescribeTrainingJobResponse> DescribeTrainingJob(DescribeTrainingJobRequest req)
        {
             JsonResponseModel<DescribeTrainingJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrainingJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询训练任务
        /// </summary>
        /// <param name="req"><see cref="DescribeTrainingJobRequest"/></param>
        /// <returns><see cref="DescribeTrainingJobResponse"/></returns>
        public DescribeTrainingJobResponse DescribeTrainingJobSync(DescribeTrainingJobRequest req)
        {
             JsonResponseModel<DescribeTrainingJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrainingJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrainingJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StartNotebookInstanceRequest"/></param>
        /// <returns><see cref="StartNotebookInstanceResponse"/></returns>
        public async Task<StartNotebookInstanceResponse> StartNotebookInstance(StartNotebookInstanceRequest req)
        {
             JsonResponseModel<StartNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StartNotebookInstanceRequest"/></param>
        /// <returns><see cref="StartNotebookInstanceResponse"/></returns>
        public StartNotebookInstanceResponse StartNotebookInstanceSync(StartNotebookInstanceRequest req)
        {
             JsonResponseModel<StartNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StopNotebookInstanceRequest"/></param>
        /// <returns><see cref="StopNotebookInstanceResponse"/></returns>
        public async Task<StopNotebookInstanceResponse> StopNotebookInstance(StopNotebookInstanceRequest req)
        {
             JsonResponseModel<StopNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止Notebook实例
        /// </summary>
        /// <param name="req"><see cref="StopNotebookInstanceRequest"/></param>
        /// <returns><see cref="StopNotebookInstanceResponse"/></returns>
        public StopNotebookInstanceResponse StopNotebookInstanceSync(StopNotebookInstanceRequest req)
        {
             JsonResponseModel<StopNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingJobRequest"/></param>
        /// <returns><see cref="StopTrainingJobResponse"/></returns>
        public async Task<StopTrainingJobResponse> StopTrainingJob(StopTrainingJobRequest req)
        {
             JsonResponseModel<StopTrainingJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopTrainingJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTrainingJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止训练任务
        /// </summary>
        /// <param name="req"><see cref="StopTrainingJobRequest"/></param>
        /// <returns><see cref="StopTrainingJobResponse"/></returns>
        public StopTrainingJobResponse StopTrainingJobSync(StopTrainingJobRequest req)
        {
             JsonResponseModel<StopTrainingJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopTrainingJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopTrainingJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新Notebook实例
        /// </summary>
        /// <param name="req"><see cref="UpdateNotebookInstanceRequest"/></param>
        /// <returns><see cref="UpdateNotebookInstanceResponse"/></returns>
        public async Task<UpdateNotebookInstanceResponse> UpdateNotebookInstance(UpdateNotebookInstanceRequest req)
        {
             JsonResponseModel<UpdateNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新Notebook实例
        /// </summary>
        /// <param name="req"><see cref="UpdateNotebookInstanceRequest"/></param>
        /// <returns><see cref="UpdateNotebookInstanceResponse"/></returns>
        public UpdateNotebookInstanceResponse UpdateNotebookInstanceSync(UpdateNotebookInstanceRequest req)
        {
             JsonResponseModel<UpdateNotebookInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateNotebookInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNotebookInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
