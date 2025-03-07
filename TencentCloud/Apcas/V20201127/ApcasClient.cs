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
       private const string sdkVersion = "SDK_NET_3.0.1194";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApcasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询画像洞察任务详情
        /// </summary>
        /// <param name="req"><see cref="GetTaskDetailRequest"/></param>
        /// <returns><see cref="GetTaskDetailResponse"/></returns>
        public Task<GetTaskDetailResponse> GetTaskDetail(GetTaskDetailRequest req)
        {
            return InternalRequestAsync<GetTaskDetailResponse>(req, "GetTaskDetail");
        }

        /// <summary>
        /// 查询画像洞察任务详情
        /// </summary>
        /// <param name="req"><see cref="GetTaskDetailRequest"/></param>
        /// <returns><see cref="GetTaskDetailResponse"/></returns>
        public GetTaskDetailResponse GetTaskDetailSync(GetTaskDetailRequest req)
        {
            return InternalRequestAsync<GetTaskDetailResponse>(req, "GetTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前账号AppID下的画像洞察任务列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskListRequest"/></param>
        /// <returns><see cref="GetTaskListResponse"/></returns>
        public Task<GetTaskListResponse> GetTaskList(GetTaskListRequest req)
        {
            return InternalRequestAsync<GetTaskListResponse>(req, "GetTaskList");
        }

        /// <summary>
        /// 查询当前账号AppID下的画像洞察任务列表
        /// </summary>
        /// <param name="req"><see cref="GetTaskListRequest"/></param>
        /// <returns><see cref="GetTaskListResponse"/></returns>
        public GetTaskListResponse GetTaskListSync(GetTaskListRequest req)
        {
            return InternalRequestAsync<GetTaskListResponse>(req, "GetTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据传入的设备号（IMEI、IDFA、手机号、手机号MD5），返回意向评级结果
        /// </summary>
        /// <param name="req"><see cref="PredictRatingRequest"/></param>
        /// <returns><see cref="PredictRatingResponse"/></returns>
        public Task<PredictRatingResponse> PredictRating(PredictRatingRequest req)
        {
            return InternalRequestAsync<PredictRatingResponse>(req, "PredictRating");
        }

        /// <summary>
        /// 根据传入的设备号（IMEI、IDFA、手机号、手机号MD5），返回意向评级结果
        /// </summary>
        /// <param name="req"><see cref="PredictRatingRequest"/></param>
        /// <returns><see cref="PredictRatingResponse"/></returns>
        public PredictRatingResponse PredictRatingSync(PredictRatingRequest req)
        {
            return InternalRequestAsync<PredictRatingResponse>(req, "PredictRating")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询调用明细
        /// </summary>
        /// <param name="req"><see cref="QueryCallDetailsRequest"/></param>
        /// <returns><see cref="QueryCallDetailsResponse"/></returns>
        public Task<QueryCallDetailsResponse> QueryCallDetails(QueryCallDetailsRequest req)
        {
            return InternalRequestAsync<QueryCallDetailsResponse>(req, "QueryCallDetails");
        }

        /// <summary>
        /// 查询调用明细
        /// </summary>
        /// <param name="req"><see cref="QueryCallDetailsRequest"/></param>
        /// <returns><see cref="QueryCallDetailsResponse"/></returns>
        public QueryCallDetailsResponse QueryCallDetailsSync(QueryCallDetailsRequest req)
        {
            return InternalRequestAsync<QueryCallDetailsResponse>(req, "QueryCallDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按时间维度获取调用量统计
        /// </summary>
        /// <param name="req"><see cref="QueryCallStatRequest"/></param>
        /// <returns><see cref="QueryCallStatResponse"/></returns>
        public Task<QueryCallStatResponse> QueryCallStat(QueryCallStatRequest req)
        {
            return InternalRequestAsync<QueryCallStatResponse>(req, "QueryCallStat");
        }

        /// <summary>
        /// 按时间维度获取调用量统计
        /// </summary>
        /// <param name="req"><see cref="QueryCallStatRequest"/></param>
        /// <returns><see cref="QueryCallStatResponse"/></returns>
        public QueryCallStatResponse QueryCallStatSync(QueryCallStatRequest req)
        {
            return InternalRequestAsync<QueryCallStatResponse>(req, "QueryCallStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取日/月/周/总调用量统计数据
        /// </summary>
        /// <param name="req"><see cref="QueryGeneralStatRequest"/></param>
        /// <returns><see cref="QueryGeneralStatResponse"/></returns>
        public Task<QueryGeneralStatResponse> QueryGeneralStat(QueryGeneralStatRequest req)
        {
            return InternalRequestAsync<QueryGeneralStatResponse>(req, "QueryGeneralStat");
        }

        /// <summary>
        /// 获取日/月/周/总调用量统计数据
        /// </summary>
        /// <param name="req"><see cref="QueryGeneralStatRequest"/></param>
        /// <returns><see cref="QueryGeneralStatResponse"/></returns>
        public QueryGeneralStatResponse QueryGeneralStatSync(QueryGeneralStatRequest req)
        {
            return InternalRequestAsync<QueryGeneralStatResponse>(req, "QueryGeneralStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传群体画像的ID列表（支持的ID类型：0:imei 7:IDFA 8:MD5(imei)），后台返回生成的画像分析任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadIdRequest"/></param>
        /// <returns><see cref="UploadIdResponse"/></returns>
        public Task<UploadIdResponse> UploadId(UploadIdRequest req)
        {
            return InternalRequestAsync<UploadIdResponse>(req, "UploadId");
        }

        /// <summary>
        /// 上传群体画像的ID列表（支持的ID类型：0:imei 7:IDFA 8:MD5(imei)），后台返回生成的画像分析任务ID
        /// </summary>
        /// <param name="req"><see cref="UploadIdRequest"/></param>
        /// <returns><see cref="UploadIdResponse"/></returns>
        public UploadIdResponse UploadIdSync(UploadIdRequest req)
        {
            return InternalRequestAsync<UploadIdResponse>(req, "UploadId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
