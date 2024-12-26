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

namespace TencentCloud.Captcha.V20190722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Captcha.V20190722.Models;

   public class CaptchaClient : AbstractClient{

       private const string endpoint = "captcha.tencentcloudapi.com";
       private const string version = "2019-07-22";
       private const string sdkVersion = "SDK_NET_3.0.1151";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CaptchaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CaptchaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询安全验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="DescribeCaptchaAppIdInfoResponse"/></returns>
        public Task<DescribeCaptchaAppIdInfoResponse> DescribeCaptchaAppIdInfo(DescribeCaptchaAppIdInfoRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaAppIdInfoResponse>(req, "DescribeCaptchaAppIdInfo");
        }

        /// <summary>
        /// 查询安全验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="DescribeCaptchaAppIdInfoResponse"/></returns>
        public DescribeCaptchaAppIdInfoResponse DescribeCaptchaAppIdInfoSync(DescribeCaptchaAppIdInfoRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaAppIdInfoResponse>(req, "DescribeCaptchaAppIdInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3  分钟级查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataResponse"/></returns>
        public Task<DescribeCaptchaDataResponse> DescribeCaptchaData(DescribeCaptchaDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaDataResponse>(req, "DescribeCaptchaData");
        }

        /// <summary>
        /// 安全验证码分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3  分钟级查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataResponse"/></returns>
        public DescribeCaptchaDataResponse DescribeCaptchaDataSync(DescribeCaptchaDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaDataResponse>(req, "DescribeCaptchaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码查询请求数据概况，例如：按照时间段查询数据  昨日请求量、昨日恶意比例、昨日验证量、昨日通过量、昨日恶意拦截量……
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataSumResponse"/></returns>
        public Task<DescribeCaptchaDataSumResponse> DescribeCaptchaDataSum(DescribeCaptchaDataSumRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaDataSumResponse>(req, "DescribeCaptchaDataSum");
        }

        /// <summary>
        /// 安全验证码查询请求数据概况，例如：按照时间段查询数据  昨日请求量、昨日恶意比例、昨日验证量、昨日通过量、昨日恶意拦截量……
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaDataSumResponse"/></returns>
        public DescribeCaptchaDataSumResponse DescribeCaptchaDataSumSync(DescribeCaptchaDataSumRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaDataSumResponse>(req, "DescribeCaptchaDataSum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码小程序插件分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3 小时级查询（五小时左右延迟）
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataResponse"/></returns>
        public Task<DescribeCaptchaMiniDataResponse> DescribeCaptchaMiniData(DescribeCaptchaMiniDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniDataResponse>(req, "DescribeCaptchaMiniData");
        }

        /// <summary>
        /// 安全验证码小程序插件分类查询数据接口，请求量type=0、通过量type=1、验证量type=2、拦截量type=3 小时级查询（五小时左右延迟）
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataResponse"/></returns>
        public DescribeCaptchaMiniDataResponse DescribeCaptchaMiniDataSync(DescribeCaptchaMiniDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniDataResponse>(req, "DescribeCaptchaMiniData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码小程序插件查询请求数据概况
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataSumResponse"/></returns>
        public Task<DescribeCaptchaMiniDataSumResponse> DescribeCaptchaMiniDataSum(DescribeCaptchaMiniDataSumRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniDataSumResponse>(req, "DescribeCaptchaMiniDataSum");
        }

        /// <summary>
        /// 安全验证码小程序插件查询请求数据概况
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniDataSumRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniDataSumResponse"/></returns>
        public DescribeCaptchaMiniDataSumResponse DescribeCaptchaMiniDataSumSync(DescribeCaptchaMiniDataSumRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniDataSumResponse>(req, "DescribeCaptchaMiniDataSum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码小程序插件用户操作数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniOperDataResponse"/></returns>
        public Task<DescribeCaptchaMiniOperDataResponse> DescribeCaptchaMiniOperData(DescribeCaptchaMiniOperDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniOperDataResponse>(req, "DescribeCaptchaMiniOperData");
        }

        /// <summary>
        /// 安全验证码小程序插件用户操作数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniOperDataResponse"/></returns>
        public DescribeCaptchaMiniOperDataResponse DescribeCaptchaMiniOperDataSync(DescribeCaptchaMiniOperDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniOperDataResponse>(req, "DescribeCaptchaMiniOperData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 核查验证码票据结果(小程序插件)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniResultResponse"/></returns>
        public Task<DescribeCaptchaMiniResultResponse> DescribeCaptchaMiniResult(DescribeCaptchaMiniResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniResultResponse>(req, "DescribeCaptchaMiniResult");
        }

        /// <summary>
        /// 核查验证码票据结果(小程序插件)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniResultResponse"/></returns>
        public DescribeCaptchaMiniResultResponse DescribeCaptchaMiniResultSync(DescribeCaptchaMiniResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniResultResponse>(req, "DescribeCaptchaMiniResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 核查验证码小程序插件票据接入风控结果(已停用)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniRiskResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniRiskResultResponse"/></returns>
        public Task<DescribeCaptchaMiniRiskResultResponse> DescribeCaptchaMiniRiskResult(DescribeCaptchaMiniRiskResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniRiskResultResponse>(req, "DescribeCaptchaMiniRiskResult");
        }

        /// <summary>
        /// 核查验证码小程序插件票据接入风控结果(已停用)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaMiniRiskResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaMiniRiskResultResponse"/></returns>
        public DescribeCaptchaMiniRiskResultResponse DescribeCaptchaMiniRiskResultSync(DescribeCaptchaMiniRiskResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaMiniRiskResultResponse>(req, "DescribeCaptchaMiniRiskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码用户操作数据查询，验证码加载耗时type = 1 、拦截情况type = 2、 一周通过平均尝试次数 type = 3、尝试次数分布 type = 4
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaOperDataResponse"/></returns>
        public Task<DescribeCaptchaOperDataResponse> DescribeCaptchaOperData(DescribeCaptchaOperDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaOperDataResponse>(req, "DescribeCaptchaOperData");
        }

        /// <summary>
        /// 安全验证码用户操作数据查询，验证码加载耗时type = 1 、拦截情况type = 2、 一周通过平均尝试次数 type = 3、尝试次数分布 type = 4
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaOperDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaOperDataResponse"/></returns>
        public DescribeCaptchaOperDataResponse DescribeCaptchaOperDataSync(DescribeCaptchaOperDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaOperDataResponse>(req, "DescribeCaptchaOperData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rce融合验证核查验证码票据结果(Web及APP)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaRceResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaRceResultResponse"/></returns>
        public Task<DescribeCaptchaRceResultResponse> DescribeCaptchaRceResult(DescribeCaptchaRceResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaRceResultResponse>(req, "DescribeCaptchaRceResult");
        }

        /// <summary>
        /// Rce融合验证核查验证码票据结果(Web及APP)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaRceResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaRceResultResponse"/></returns>
        public DescribeCaptchaRceResultResponse DescribeCaptchaRceResultSync(DescribeCaptchaRceResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaRceResultResponse>(req, "DescribeCaptchaRceResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 核查验证码票据结果(Web及APP)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public Task<DescribeCaptchaResultResponse> DescribeCaptchaResult(DescribeCaptchaResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaResultResponse>(req, "DescribeCaptchaResult");
        }

        /// <summary>
        /// 核查验证码票据结果(Web及APP)
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaResultRequest"/></param>
        /// <returns><see cref="DescribeCaptchaResultResponse"/></returns>
        public DescribeCaptchaResultResponse DescribeCaptchaResultSync(DescribeCaptchaResultRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaResultResponse>(req, "DescribeCaptchaResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码用户操作票据数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaTicketDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaTicketDataResponse"/></returns>
        public Task<DescribeCaptchaTicketDataResponse> DescribeCaptchaTicketData(DescribeCaptchaTicketDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaTicketDataResponse>(req, "DescribeCaptchaTicketData");
        }

        /// <summary>
        /// 安全验证码用户操作票据数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaTicketDataRequest"/></param>
        /// <returns><see cref="DescribeCaptchaTicketDataResponse"/></returns>
        public DescribeCaptchaTicketDataResponse DescribeCaptchaTicketDataSync(DescribeCaptchaTicketDataRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaTicketDataResponse>(req, "DescribeCaptchaTicketData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全验证码获取用户注册所有APPId和应用名称
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaUserAllAppIdRequest"/></param>
        /// <returns><see cref="DescribeCaptchaUserAllAppIdResponse"/></returns>
        public Task<DescribeCaptchaUserAllAppIdResponse> DescribeCaptchaUserAllAppId(DescribeCaptchaUserAllAppIdRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaUserAllAppIdResponse>(req, "DescribeCaptchaUserAllAppId");
        }

        /// <summary>
        /// 安全验证码获取用户注册所有APPId和应用名称
        /// </summary>
        /// <param name="req"><see cref="DescribeCaptchaUserAllAppIdRequest"/></param>
        /// <returns><see cref="DescribeCaptchaUserAllAppIdResponse"/></returns>
        public DescribeCaptchaUserAllAppIdResponse DescribeCaptchaUserAllAppIdSync(DescribeCaptchaUserAllAppIdRequest req)
        {
            return InternalRequestAsync<DescribeCaptchaUserAllAppIdResponse>(req, "DescribeCaptchaUserAllAppId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个CaptchaAppID验证的统计数据，包括：请求量、验证量、验证通过量、验证拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetRequestStatisticsResponse"/></returns>
        public Task<GetRequestStatisticsResponse> GetRequestStatistics(GetRequestStatisticsRequest req)
        {
            return InternalRequestAsync<GetRequestStatisticsResponse>(req, "GetRequestStatistics");
        }

        /// <summary>
        /// 查询单个CaptchaAppID验证的统计数据，包括：请求量、验证量、验证通过量、验证拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetRequestStatisticsResponse"/></returns>
        public GetRequestStatisticsResponse GetRequestStatisticsSync(GetRequestStatisticsRequest req)
        {
            return InternalRequestAsync<GetRequestStatisticsResponse>(req, "GetRequestStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个CaptchaAppID票据校验数据，包括：票据校验量、票据校验通过量、票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTicketStatisticsResponse"/></returns>
        public Task<GetTicketStatisticsResponse> GetTicketStatistics(GetTicketStatisticsRequest req)
        {
            return InternalRequestAsync<GetTicketStatisticsResponse>(req, "GetTicketStatistics");
        }

        /// <summary>
        /// 查询单个CaptchaAppID票据校验数据，包括：票据校验量、票据校验通过量、票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTicketStatisticsResponse"/></returns>
        public GetTicketStatisticsResponse GetTicketStatisticsSync(GetTicketStatisticsRequest req)
        {
            return InternalRequestAsync<GetTicketStatisticsResponse>(req, "GetTicketStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询全部验证的统计数据，包括：总请求量、总验证量、总验证通过量、总验证拦截量等数据。
        /// </summary>
        /// <param name="req"><see cref="GetTotalRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalRequestStatisticsResponse"/></returns>
        public Task<GetTotalRequestStatisticsResponse> GetTotalRequestStatistics(GetTotalRequestStatisticsRequest req)
        {
            return InternalRequestAsync<GetTotalRequestStatisticsResponse>(req, "GetTotalRequestStatistics");
        }

        /// <summary>
        /// 查询全部验证的统计数据，包括：总请求量、总验证量、总验证通过量、总验证拦截量等数据。
        /// </summary>
        /// <param name="req"><see cref="GetTotalRequestStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalRequestStatisticsResponse"/></returns>
        public GetTotalRequestStatisticsResponse GetTotalRequestStatisticsSync(GetTotalRequestStatisticsRequest req)
        {
            return InternalRequestAsync<GetTotalRequestStatisticsResponse>(req, "GetTotalRequestStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询全部票据校验的统计数据，包括：总票据校验量、总票据校验通过量、总票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTotalTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalTicketStatisticsResponse"/></returns>
        public Task<GetTotalTicketStatisticsResponse> GetTotalTicketStatistics(GetTotalTicketStatisticsRequest req)
        {
            return InternalRequestAsync<GetTotalTicketStatisticsResponse>(req, "GetTotalTicketStatistics");
        }

        /// <summary>
        /// 查询全部票据校验的统计数据，包括：总票据校验量、总票据校验通过量、总票据校验拦截量。
        /// </summary>
        /// <param name="req"><see cref="GetTotalTicketStatisticsRequest"/></param>
        /// <returns><see cref="GetTotalTicketStatisticsResponse"/></returns>
        public GetTotalTicketStatisticsResponse GetTotalTicketStatisticsSync(GetTotalTicketStatisticsRequest req)
        {
            return InternalRequestAsync<GetTotalTicketStatisticsResponse>(req, "GetTotalTicketStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="UpdateCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="UpdateCaptchaAppIdInfoResponse"/></returns>
        public Task<UpdateCaptchaAppIdInfoResponse> UpdateCaptchaAppIdInfo(UpdateCaptchaAppIdInfoRequest req)
        {
            return InternalRequestAsync<UpdateCaptchaAppIdInfoResponse>(req, "UpdateCaptchaAppIdInfo");
        }

        /// <summary>
        /// 更新验证码应用APPId信息
        /// </summary>
        /// <param name="req"><see cref="UpdateCaptchaAppIdInfoRequest"/></param>
        /// <returns><see cref="UpdateCaptchaAppIdInfoResponse"/></returns>
        public UpdateCaptchaAppIdInfoResponse UpdateCaptchaAppIdInfoSync(UpdateCaptchaAppIdInfoRequest req)
        {
            return InternalRequestAsync<UpdateCaptchaAppIdInfoResponse>(req, "UpdateCaptchaAppIdInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
