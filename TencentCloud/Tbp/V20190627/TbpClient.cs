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

namespace TencentCloud.Tbp.V20190627
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tbp.V20190627.Models;

   public class TbpClient : AbstractClient{

       private const string endpoint = "tbp.tencentcloudapi.com";
       private const string version = "2019-06-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TbpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TbpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接收调用侧的文本输入，返回应答文本。
        /// </summary>
        /// <param name="req"><see cref="TextProcessRequest"/></param>
        /// <returns><see cref="TextProcessResponse"/></returns>
        public async Task<TextProcessResponse> TextProcess(TextProcessRequest req)
        {
             JsonResponseModel<TextProcessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextProcess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextProcessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TextProcess接口的同步版本，接收调用侧的文本输入，返回应答文本。
        /// </summary>
        /// <param name="req">参考<see cref="TextProcessRequest"/></param>
        /// <returns>参考<see cref="TextProcessResponse"/>实例</returns>
        public TextProcessResponse TextProcessSync(TextProcessRequest req)
        {
             JsonResponseModel<TextProcessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextProcess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextProcessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会话重置接口。
        /// </summary>
        /// <param name="req"><see cref="TextResetRequest"/></param>
        /// <returns><see cref="TextResetResponse"/></returns>
        public async Task<TextResetResponse> TextReset(TextResetRequest req)
        {
             JsonResponseModel<TextResetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextReset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextResetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TextReset接口的同步版本，会话重置接口。
        /// </summary>
        /// <param name="req">参考<see cref="TextResetRequest"/></param>
        /// <returns>参考<see cref="TextResetResponse"/>实例</returns>
        public TextResetResponse TextResetSync(TextResetRequest req)
        {
             JsonResponseModel<TextResetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextReset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextResetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
