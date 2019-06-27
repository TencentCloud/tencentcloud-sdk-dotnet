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

namespace TencentCloud.Asr.V20190614
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Asr.V20190614.Models;

   public class AsrClient : AbstractClient{

       private const string endpoint = "asr.tencentcloudapi.com";
       private const string version = "2019-06-14";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public AsrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public AsrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 识别60s内的短语音。当音频文件通过请求中body内容上传时，请求大小不能超过600KB；当音频以url方式传输时，音频时长不可超过60s。所有请求参数放在POST请求的body中，编码类型采用采用x-www-form-urlencoded，参数进行urlencode编码后传输。现暂只支持中文普通话识别，支持识别8k16bit和16k16bit的mp3或者wav音频。
        /// </summary>
        /// <param name="req">参考<see cref="SentenceRecognitionRequest"/></param>
        /// <returns>参考<see cref="SentenceRecognitionResponse"/>实例</returns>
        public async Task<SentenceRecognitionResponse> SentenceRecognition(SentenceRecognitionRequest req)
        {
             JsonResponseModel<SentenceRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SentenceRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentenceRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
