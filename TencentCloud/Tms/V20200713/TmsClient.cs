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

namespace TencentCloud.Tms.V20200713
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tms.V20200713.Models;

   public class TmsClient : AbstractClient{

       private const string endpoint = "tms.tencentcloudapi.com";
       private const string version = "2020-07-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 举报恶意账号
        /// </summary>
        /// <param name="req"><see cref="AccountTipoffAccessRequest"/></param>
        /// <returns><see cref="AccountTipoffAccessResponse"/></returns>
        public async Task<AccountTipoffAccessResponse> AccountTipoffAccess(AccountTipoffAccessRequest req)
        {
             JsonResponseModel<AccountTipoffAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AccountTipoffAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AccountTipoffAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 举报恶意账号
        /// </summary>
        /// <param name="req"><see cref="AccountTipoffAccessRequest"/></param>
        /// <returns><see cref="AccountTipoffAccessResponse"/></returns>
        public AccountTipoffAccessResponse AccountTipoffAccessSync(AccountTipoffAccessRequest req)
        {
             JsonResponseModel<AccountTipoffAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AccountTipoffAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AccountTipoffAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台获取用户词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTextLibRequest"/></param>
        /// <returns><see cref="DescribeTextLibResponse"/></returns>
        public async Task<DescribeTextLibResponse> DescribeTextLib(DescribeTextLibRequest req)
        {
             JsonResponseModel<DescribeTextLibResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTextLib");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTextLibResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台获取用户词库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTextLibRequest"/></param>
        /// <returns><see cref="DescribeTextLibResponse"/></returns>
        public DescribeTextLibResponse DescribeTextLibSync(DescribeTextLibRequest req)
        {
             JsonResponseModel<DescribeTextLibResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTextLib");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTextLibResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTextStatRequest"/></param>
        /// <returns><see cref="DescribeTextStatResponse"/></returns>
        public async Task<DescribeTextStatResponse> DescribeTextStat(DescribeTextStatRequest req)
        {
             JsonResponseModel<DescribeTextStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTextStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTextStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeTextStatRequest"/></param>
        /// <returns><see cref="DescribeTextStatResponse"/></returns>
        public DescribeTextStatResponse DescribeTextStatSync(DescribeTextStatRequest req)
        {
             JsonResponseModel<DescribeTextStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTextStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTextStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别可能令人反感、不安全或不适宜的文本内容，同时支持用户配置词库黑白名单，打击自定义识别类型的图片。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public async Task<TextModerationResponse> TextModeration(TextModerationRequest req)
        {
             JsonResponseModel<TextModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本内容检测（Text Moderation）服务使用了深度学习技术，识别可能令人反感、不安全或不适宜的文本内容，同时支持用户配置词库黑白名单，打击自定义识别类型的图片。
        /// </summary>
        /// <param name="req"><see cref="TextModerationRequest"/></param>
        /// <returns><see cref="TextModerationResponse"/></returns>
        public TextModerationResponse TextModerationSync(TextModerationRequest req)
        {
             JsonResponseModel<TextModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
