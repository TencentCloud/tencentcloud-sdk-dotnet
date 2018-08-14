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

namespace TencentCloud.Youmall.V20180228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Youmall.V20180228.Models;

   public class YoumallClient : AbstractClient{

       private const string endpoint = "youmall.tencentcloudapi.com";
       private const string version = "2018-02-28";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public YoumallClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public YoumallClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 指定门店获取所有顾客详情列表，包含客户ID、图片、年龄、性别
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonInfoRequest"/></param>
        /// <returns>参考<see cref="DescribePersonInfoResponse"/>实例</returns>
        public async Task<DescribePersonInfoResponse> DescribePersonInfo(DescribePersonInfoRequest req)
        {
             JsonResponseModel<DescribePersonInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取门店指定时间范围内的所有用户到访信息记录，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePersonVisitInfoRequest"/></param>
        /// <returns>参考<see cref="DescribePersonVisitInfoResponse"/>实例</returns>
        public async Task<DescribePersonVisitInfoResponse> DescribePersonVisitInfo(DescribePersonVisitInfoRequest req)
        {
             JsonResponseModel<DescribePersonVisitInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonVisitInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonVisitInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按小时提供查询日期范围内门店的每天每小时累计客流人数数据，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopHourTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopHourTrafficInfoResponse"/>实例</returns>
        public async Task<DescribeShopHourTrafficInfoResponse> DescribeShopHourTrafficInfo(DescribeShopHourTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeShopHourTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShopHourTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopHourTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据客户身份标识获取客户下所有的门店信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopInfoResponse"/>实例</returns>
        public async Task<DescribeShopInfoResponse> DescribeShopInfo(DescribeShopInfoRequest req)
        {
             JsonResponseModel<DescribeShopInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShopInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按天提供查询日期范围内门店的单日累计客流人数，支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeShopTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeShopTrafficInfoResponse"/>实例</returns>
        public async Task<DescribeShopTrafficInfoResponse> DescribeShopTrafficInfo(DescribeShopTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeShopTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShopTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShopTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按天提供查询日期范围内，客户指定门店下的所有区域（优Mall部署时已配置区域）的累计客流人次和平均停留时间。支持的时间范围：过去365天，含当天。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZoneTrafficInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeZoneTrafficInfoResponse"/>实例</returns>
        public async Task<DescribeZoneTrafficInfoResponse> DescribeZoneTrafficInfo(DescribeZoneTrafficInfoRequest req)
        {
             JsonResponseModel<DescribeZoneTrafficInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZoneTrafficInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZoneTrafficInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用本接口在优Mall中注册自己集团的到店通知回调接口地址，接口协议为HTTP或HTTPS。注册后，若集团有特殊身份（例如老客）到店通知，优Mall后台将主动将到店信息push给该接口
        /// </summary>
        /// <param name="req">参考<see cref="RegisterCallbackRequest"/></param>
        /// <returns>参考<see cref="RegisterCallbackResponse"/>实例</returns>
        public async Task<RegisterCallbackResponse> RegisterCallback(RegisterCallbackRequest req)
        {
             JsonResponseModel<RegisterCallbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterCallback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterCallbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
