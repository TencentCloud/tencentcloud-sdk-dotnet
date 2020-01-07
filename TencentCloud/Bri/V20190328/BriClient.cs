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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BriClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 输入业务名 (bri_num, bri_dev, bri_ip, bri_apk, bri_url 五种之一)  及其 相应字段, 获取业务风险分数和标签。
        /// 
        /// 当业务名为bri_num时，必须填PhoneNumber字段.
        /// 
        /// 当业务名为bri_dev时, 必须填Imei字段.
        /// 
        /// 当业务名为bri_ip时，必须填Ip字段.
        /// 
        /// 当业务名为bri_apk时，必须填 (PackageName,CertMd5,FileSize) 三个字段 或者 FileMd5一个字段.
        /// 
        /// 当业务名为bri_url时，必须填Url字段.
        /// </summary>
        /// <param name="req"><see cref="DescribeBRIRequest"/></param>
        /// <returns><see cref="DescribeBRIResponse"/></returns>
        public async Task<DescribeBRIResponse> DescribeBRI(DescribeBRIRequest req)
        {
             JsonResponseModel<DescribeBRIResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBRI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBRIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBRI接口的同步版本，输入业务名 (bri_num, bri_dev, bri_ip, bri_apk, bri_url 五种之一)  及其 相应字段, 获取业务风险分数和标签。
        /// 
        /// 当业务名为bri_num时，必须填PhoneNumber字段.
        /// 
        /// 当业务名为bri_dev时, 必须填Imei字段.
        /// 
        /// 当业务名为bri_ip时，必须填Ip字段.
        /// 
        /// 当业务名为bri_apk时，必须填 (PackageName,CertMd5,FileSize) 三个字段 或者 FileMd5一个字段.
        /// 
        /// 当业务名为bri_url时，必须填Url字段.
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBRIRequest"/></param>
        /// <returns>参考<see cref="DescribeBRIResponse"/>实例</returns>
        public DescribeBRIResponse DescribeBRISync(DescribeBRIRequest req)
        {
             JsonResponseModel<DescribeBRIResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBRI");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBRIResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
