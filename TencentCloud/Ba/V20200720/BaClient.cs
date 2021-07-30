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

namespace TencentCloud.Ba.V20200720
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ba.V20200720.Models;

   public class BaClient : AbstractClient{

       private const string endpoint = "ba.tencentcloudapi.com";
       private const string version = "2020-07-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建渠道备案小程序二维码
        /// </summary>
        /// <param name="req"><see cref="CreateWeappQRUrlRequest"/></param>
        /// <returns><see cref="CreateWeappQRUrlResponse"/></returns>
        public async Task<CreateWeappQRUrlResponse> CreateWeappQRUrl(CreateWeappQRUrlRequest req)
        {
             JsonResponseModel<CreateWeappQRUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWeappQRUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWeappQRUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建渠道备案小程序二维码
        /// </summary>
        /// <param name="req"><see cref="CreateWeappQRUrlRequest"/></param>
        /// <returns><see cref="CreateWeappQRUrlResponse"/></returns>
        public CreateWeappQRUrlResponse CreateWeappQRUrlSync(CreateWeappQRUrlRequest req)
        {
             JsonResponseModel<CreateWeappQRUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWeappQRUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWeappQRUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实名认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGetAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeGetAuthInfoResponse"/></returns>
        public async Task<DescribeGetAuthInfoResponse> DescribeGetAuthInfo(DescribeGetAuthInfoRequest req)
        {
             JsonResponseModel<DescribeGetAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGetAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGetAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实名认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGetAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeGetAuthInfoResponse"/></returns>
        public DescribeGetAuthInfoResponse DescribeGetAuthInfoSync(DescribeGetAuthInfoRequest req)
        {
             JsonResponseModel<DescribeGetAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGetAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGetAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将备案ICP订单下的一个网站信息 同步给订单下其他网站，需要被同步的网站被检查通过(isCheck:true)；
        /// 只有指定的网站信息字段能被同步
        /// </summary>
        /// <param name="req"><see cref="SyncIcpOrderWebInfoRequest"/></param>
        /// <returns><see cref="SyncIcpOrderWebInfoResponse"/></returns>
        public async Task<SyncIcpOrderWebInfoResponse> SyncIcpOrderWebInfo(SyncIcpOrderWebInfoRequest req)
        {
             JsonResponseModel<SyncIcpOrderWebInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncIcpOrderWebInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncIcpOrderWebInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将备案ICP订单下的一个网站信息 同步给订单下其他网站，需要被同步的网站被检查通过(isCheck:true)；
        /// 只有指定的网站信息字段能被同步
        /// </summary>
        /// <param name="req"><see cref="SyncIcpOrderWebInfoRequest"/></param>
        /// <returns><see cref="SyncIcpOrderWebInfoResponse"/></returns>
        public SyncIcpOrderWebInfoResponse SyncIcpOrderWebInfoSync(SyncIcpOrderWebInfoRequest req)
        {
             JsonResponseModel<SyncIcpOrderWebInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncIcpOrderWebInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncIcpOrderWebInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
