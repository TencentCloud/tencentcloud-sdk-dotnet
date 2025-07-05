/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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
       private const string sdkVersion = "SDK_NET_3.0.1273";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建渠道备案小程序二维码
        /// </summary>
        /// <param name="req"><see cref="CreateWeappQRUrlRequest"/></param>
        /// <returns><see cref="CreateWeappQRUrlResponse"/></returns>
        public Task<CreateWeappQRUrlResponse> CreateWeappQRUrl(CreateWeappQRUrlRequest req)
        {
            return InternalRequestAsync<CreateWeappQRUrlResponse>(req, "CreateWeappQRUrl");
        }

        /// <summary>
        /// 创建渠道备案小程序二维码
        /// </summary>
        /// <param name="req"><see cref="CreateWeappQRUrlRequest"/></param>
        /// <returns><see cref="CreateWeappQRUrlResponse"/></returns>
        public CreateWeappQRUrlResponse CreateWeappQRUrlSync(CreateWeappQRUrlRequest req)
        {
            return InternalRequestAsync<CreateWeappQRUrlResponse>(req, "CreateWeappQRUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实名认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGetAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeGetAuthInfoResponse"/></returns>
        public Task<DescribeGetAuthInfoResponse> DescribeGetAuthInfo(DescribeGetAuthInfoRequest req)
        {
            return InternalRequestAsync<DescribeGetAuthInfoResponse>(req, "DescribeGetAuthInfo");
        }

        /// <summary>
        /// 获取实名认证信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGetAuthInfoRequest"/></param>
        /// <returns><see cref="DescribeGetAuthInfoResponse"/></returns>
        public DescribeGetAuthInfoResponse DescribeGetAuthInfoSync(DescribeGetAuthInfoRequest req)
        {
            return InternalRequestAsync<DescribeGetAuthInfoResponse>(req, "DescribeGetAuthInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将备案ICP订单下的一个网站信息 同步给订单下其他网站，需要被同步的网站被检查通过(isCheck:true)；
        /// 只有指定的网站信息字段能被同步
        /// </summary>
        /// <param name="req"><see cref="SyncIcpOrderWebInfoRequest"/></param>
        /// <returns><see cref="SyncIcpOrderWebInfoResponse"/></returns>
        public Task<SyncIcpOrderWebInfoResponse> SyncIcpOrderWebInfo(SyncIcpOrderWebInfoRequest req)
        {
            return InternalRequestAsync<SyncIcpOrderWebInfoResponse>(req, "SyncIcpOrderWebInfo");
        }

        /// <summary>
        /// 将备案ICP订单下的一个网站信息 同步给订单下其他网站，需要被同步的网站被检查通过(isCheck:true)；
        /// 只有指定的网站信息字段能被同步
        /// </summary>
        /// <param name="req"><see cref="SyncIcpOrderWebInfoRequest"/></param>
        /// <returns><see cref="SyncIcpOrderWebInfoResponse"/></returns>
        public SyncIcpOrderWebInfoResponse SyncIcpOrderWebInfoSync(SyncIcpOrderWebInfoRequest req)
        {
            return InternalRequestAsync<SyncIcpOrderWebInfoResponse>(req, "SyncIcpOrderWebInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
