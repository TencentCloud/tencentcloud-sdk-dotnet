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

namespace TencentCloud.Bri.V20190328
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bri.V20190328.Models;

   public class BriClient : AbstractClient{

       private const string endpoint = "bri.tencentcloudapi.com";
       private const string version = "2019-03-28";
       private const string sdkVersion = "SDK_NET_3.0.1239";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BriClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BriClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 产品不在使用，业务已经下线
        /// 
        /// 输入业务名 (bri_num, bri_dev, bri_ip, bri_apk, bri_url, bri_social 六种之一)  及其 相应字段, 获取业务风险分数和标签。
        /// 
        /// 当业务名为bri_num时，必须填PhoneNumber字段.
        /// 
        /// 当业务名为bri_dev时, 必须填Imei字段.
        /// 
        /// 当业务名为bri_ip时，必须填IP字段.
        /// 
        /// 当业务名为bri_apk时，必须填 (PackageName,CertMd5,FileSize) 三个字段 或者 FileMd5一个字段.
        /// 
        /// 当业务名为bri_url时，必须填Url字段.
        /// 
        /// 当业务名为bri_social时，必须填QQ和Wechat字段两者其中一个或者两个.
        /// </summary>
        /// <param name="req"><see cref="DescribeBRIRequest"/></param>
        /// <returns><see cref="DescribeBRIResponse"/></returns>
        public Task<DescribeBRIResponse> DescribeBRI(DescribeBRIRequest req)
        {
            return InternalRequestAsync<DescribeBRIResponse>(req, "DescribeBRI");
        }

        /// <summary>
        /// 产品不在使用，业务已经下线
        /// 
        /// 输入业务名 (bri_num, bri_dev, bri_ip, bri_apk, bri_url, bri_social 六种之一)  及其 相应字段, 获取业务风险分数和标签。
        /// 
        /// 当业务名为bri_num时，必须填PhoneNumber字段.
        /// 
        /// 当业务名为bri_dev时, 必须填Imei字段.
        /// 
        /// 当业务名为bri_ip时，必须填IP字段.
        /// 
        /// 当业务名为bri_apk时，必须填 (PackageName,CertMd5,FileSize) 三个字段 或者 FileMd5一个字段.
        /// 
        /// 当业务名为bri_url时，必须填Url字段.
        /// 
        /// 当业务名为bri_social时，必须填QQ和Wechat字段两者其中一个或者两个.
        /// </summary>
        /// <param name="req"><see cref="DescribeBRIRequest"/></param>
        /// <returns><see cref="DescribeBRIResponse"/></returns>
        public DescribeBRIResponse DescribeBRISync(DescribeBRIRequest req)
        {
            return InternalRequestAsync<DescribeBRIResponse>(req, "DescribeBRI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
