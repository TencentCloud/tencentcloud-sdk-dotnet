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

namespace TencentCloud.Casb.V20200507
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Casb.V20200507.Models;

   public class CasbClient : AbstractClient{

       private const string endpoint = "casb.tencentcloudapi.com";
       private const string version = "2020-05-07";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CasbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CasbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 同region下 根据用户输入的CasbId,MetaDataId 复制策略到DstCasbId,MetaDataId中。
        /// 场景1：
        /// 相同CasbId，不同MetadataId 下策略复制
        /// 场景2：
        /// 不同Casbid,不同MetaDataId 下策略复制
        /// 场景3:
        /// 相同CasbId,相同MetaDataId 且 DatabaseName不同 策略复制
        /// </summary>
        /// <param name="req"><see cref="CopyCryptoColumnPolicyRequest"/></param>
        /// <returns><see cref="CopyCryptoColumnPolicyResponse"/></returns>
        public async Task<CopyCryptoColumnPolicyResponse> CopyCryptoColumnPolicy(CopyCryptoColumnPolicyRequest req)
        {
             JsonResponseModel<CopyCryptoColumnPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyCryptoColumnPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyCryptoColumnPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同region下 根据用户输入的CasbId,MetaDataId 复制策略到DstCasbId,MetaDataId中。
        /// 场景1：
        /// 相同CasbId，不同MetadataId 下策略复制
        /// 场景2：
        /// 不同Casbid,不同MetaDataId 下策略复制
        /// 场景3:
        /// 相同CasbId,相同MetaDataId 且 DatabaseName不同 策略复制
        /// </summary>
        /// <param name="req"><see cref="CopyCryptoColumnPolicyRequest"/></param>
        /// <returns><see cref="CopyCryptoColumnPolicyResponse"/></returns>
        public CopyCryptoColumnPolicyResponse CopyCryptoColumnPolicySync(CopyCryptoColumnPolicyRequest req)
        {
             JsonResponseModel<CopyCryptoColumnPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyCryptoColumnPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyCryptoColumnPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
