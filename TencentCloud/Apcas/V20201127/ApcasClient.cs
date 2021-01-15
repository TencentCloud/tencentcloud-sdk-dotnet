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

namespace TencentCloud.Apcas.V20201127
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apcas.V20201127.Models;

   public class ApcasClient : AbstractClient{

       private const string endpoint = "apcas.tencentcloudapi.com";
       private const string version = "2020-11-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApcasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApcasClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询画像洞察任务详情
        /// </summary>
        /// <param name="req"><see cref="GetTaskDetailRequest"/></param>
        /// <returns><see cref="GetTaskDetailResponse"/></returns>
        public async Task<GetTaskDetailResponse> GetTaskDetail(GetTaskDetailRequest req)
        {
             JsonResponseModel<GetTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询画像洞察任务详情
        /// </summary>
        /// <param name="req"><see cref="GetTaskDetailRequest"/></param>
        /// <returns><see cref="GetTaskDetailResponse"/></returns>
        public GetTaskDetailResponse GetTaskDetailSync(GetTaskDetailRequest req)
        {
             JsonResponseModel<GetTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询当前账号AppID下的画像洞察任务列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskListRequest"/></param>
        /// <returns><see cref="GetTaskListResponse"/></returns>
        public async Task<GetTaskListResponse> GetTaskList(GetTaskListRequest req)
        {
             JsonResponseModel<GetTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询当前账号AppID下的画像洞察任务列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskListRequest"/></param>
        /// <returns><see cref="GetTaskListResponse"/></returns>
        public GetTaskListResponse GetTaskListSync(GetTaskListRequest req)
        {
             JsonResponseModel<GetTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据传入的设备号（IMEI、IDFA、手机号、手机号MD5），返回意向评级结果
        /// </summary>
        /// <param name="req"><see cref="PredictRatingRequest"/></param>
        /// <returns><see cref="PredictRatingResponse"/></returns>
        public async Task<PredictRatingResponse> PredictRating(PredictRatingRequest req)
        {
             JsonResponseModel<PredictRatingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PredictRating");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PredictRatingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据传入的设备号（IMEI、IDFA、手机号、手机号MD5），返回意向评级结果
        /// </summary>
        /// <param name="req"><see cref="PredictRatingRequest"/></param>
        /// <returns><see cref="PredictRatingResponse"/></returns>
        public PredictRatingResponse PredictRatingSync(PredictRatingRequest req)
        {
             JsonResponseModel<PredictRatingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PredictRating");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PredictRatingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询调用明细
        /// </summary>
        /// <param name="req"><see cref="QueryCallDetailsRequest"/></param>
        /// <returns><see cref="QueryCallDetailsResponse"/></returns>
        public async Task<QueryCallDetailsResponse> QueryCallDetails(QueryCallDetailsRequest req)
        {
             JsonResponseModel<QueryCallDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCallDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询调用明细
        /// </summary>
        /// <param name="req"><see cref="QueryCallDetailsRequest"/></param>
        /// <returns><see cref="QueryCallDetailsResponse"/></returns>
        public QueryCallDetailsResponse QueryCallDetailsSync(QueryCallDetailsRequest req)
        {
             JsonResponseModel<QueryCallDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCallDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按时间维度获取调用量统计
        /// </summary>
        /// <param name="req"><see cref="QueryCallStatRequest"/></param>
        /// <returns><see cref="QueryCallStatResponse"/></returns>
        public async Task<QueryCallStatResponse> QueryCallStat(QueryCallStatRequest req)
        {
             JsonResponseModel<QueryCallStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCallStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按时间维度获取调用量统计
        /// </summary>
        /// <param name="req"><see cref="QueryCallStatRequest"/></param>
        /// <returns><see cref="QueryCallStatResponse"/></returns>
        public QueryCallStatResponse QueryCallStatSync(QueryCallStatRequest req)
        {
             JsonResponseModel<QueryCallStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCallStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCallStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日/月/周/总调用量统计数据
        /// </summary>
        /// <param name="req"><see cref="QueryGeneralStatRequest"/></param>
        /// <returns><see cref="QueryGeneralStatResponse"/></returns>
        public async Task<QueryGeneralStatResponse> QueryGeneralStat(QueryGeneralStatRequest req)
        {
             JsonResponseModel<QueryGeneralStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryGeneralStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryGeneralStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日/月/周/总调用量统计数据
        /// </summary>
        /// <param name="req"><see cref="QueryGeneralStatRequest"/></param>
        /// <returns><see cref="QueryGeneralStatResponse"/></returns>
        public QueryGeneralStatResponse QueryGeneralStatSync(QueryGeneralStatRequest req)
        {
             JsonResponseModel<QueryGeneralStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryGeneralStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryGeneralStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传群体画像的ID列表（支持的ID类型：0:imei 7:IDFA 8:MD5(imei)），后台返回生成的画像分析任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadIdRequest"/></param>
        /// <returns><see cref="UploadIdResponse"/></returns>
        public async Task<UploadIdResponse> UploadId(UploadIdRequest req)
        {
             JsonResponseModel<UploadIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传群体画像的ID列表（支持的ID类型：0:imei 7:IDFA 8:MD5(imei)），后台返回生成的画像分析任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadIdRequest"/></param>
        /// <returns><see cref="UploadIdResponse"/></returns>
        public UploadIdResponse UploadIdSync(UploadIdRequest req)
        {
             JsonResponseModel<UploadIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
