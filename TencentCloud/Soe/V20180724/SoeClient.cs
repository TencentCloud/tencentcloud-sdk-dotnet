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

namespace TencentCloud.Soe.V20180724
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Soe.V20180724.Models;

   public class SoeClient : AbstractClient{

       private const string endpoint = "soe.tencentcloudapi.com";
       private const string version = "2018-07-24";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public SoeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public SoeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 初始化发音评估过程，每一轮评估前进行调用。语音输入模式分为流式模式和非流式模式，流式模式支持数据分片传输，可以加快评估响应速度。评估模式分为词模式和句子模式，词模式会标注每个音节的详细信息；句子模式会有完整度和流利度的评估。
        /// </summary>
        /// <param name="req">参考<see cref="InitOralProcessRequest"/></param>
        /// <returns>参考<see cref="InitOralProcessResponse"/>实例</returns>
        public async Task<InitOralProcessResponse> InitOralProcess(InitOralProcessRequest req)
        {
             JsonResponseModel<InitOralProcessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitOralProcess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitOralProcessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传输音频数据，必须在完成发音评估初始化接口之后调用，且SessonId要与初始化接口保持一致。分片传输时，尽量保证SeqId顺序传输。当使用mp3格式时目前仅支持16k采样率16bit单声道编码方式。
        /// </summary>
        /// <param name="req">参考<see cref="TransmitOralProcessRequest"/></param>
        /// <returns>参考<see cref="TransmitOralProcessResponse"/>实例</returns>
        public async Task<TransmitOralProcessResponse> TransmitOralProcess(TransmitOralProcessRequest req)
        {
             JsonResponseModel<TransmitOralProcessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransmitOralProcess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransmitOralProcessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
