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

namespace TencentCloud.Tem.V20210701
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tem.V20210701.Models;

   public class TemClient : AbstractClient{

       private const string endpoint = "tem.tencentcloudapi.com";
       private const string version = "2021-07-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TemClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TemClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取分批发布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployApplicationDetailRequest"/></param>
        /// <returns><see cref="DescribeDeployApplicationDetailResponse"/></returns>
        public async Task<DescribeDeployApplicationDetailResponse> DescribeDeployApplicationDetail(DescribeDeployApplicationDetailRequest req)
        {
             JsonResponseModel<DescribeDeployApplicationDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeployApplicationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeployApplicationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分批发布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployApplicationDetailRequest"/></param>
        /// <returns><see cref="DescribeDeployApplicationDetailResponse"/></returns>
        public DescribeDeployApplicationDetailResponse DescribeDeployApplicationDetailSync(DescribeDeployApplicationDetailRequest req)
        {
             JsonResponseModel<DescribeDeployApplicationDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeployApplicationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeployApplicationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开始下一批次发布
        /// </summary>
        /// <param name="req"><see cref="ResumeDeployApplicationRequest"/></param>
        /// <returns><see cref="ResumeDeployApplicationResponse"/></returns>
        public async Task<ResumeDeployApplicationResponse> ResumeDeployApplication(ResumeDeployApplicationRequest req)
        {
             JsonResponseModel<ResumeDeployApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeDeployApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDeployApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开始下一批次发布
        /// </summary>
        /// <param name="req"><see cref="ResumeDeployApplicationRequest"/></param>
        /// <returns><see cref="ResumeDeployApplicationResponse"/></returns>
        public ResumeDeployApplicationResponse ResumeDeployApplicationSync(ResumeDeployApplicationRequest req)
        {
             JsonResponseModel<ResumeDeployApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeDeployApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeDeployApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚分批发布
        /// </summary>
        /// <param name="req"><see cref="RevertDeployApplicationRequest"/></param>
        /// <returns><see cref="RevertDeployApplicationResponse"/></returns>
        public async Task<RevertDeployApplicationResponse> RevertDeployApplication(RevertDeployApplicationRequest req)
        {
             JsonResponseModel<RevertDeployApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevertDeployApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevertDeployApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚分批发布
        /// </summary>
        /// <param name="req"><see cref="RevertDeployApplicationRequest"/></param>
        /// <returns><see cref="RevertDeployApplicationResponse"/></returns>
        public RevertDeployApplicationResponse RevertDeployApplicationSync(RevertDeployApplicationRequest req)
        {
             JsonResponseModel<RevertDeployApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevertDeployApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevertDeployApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
