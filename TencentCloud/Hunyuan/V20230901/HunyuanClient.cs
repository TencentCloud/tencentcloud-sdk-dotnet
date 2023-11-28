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

namespace TencentCloud.Hunyuan.V20230901
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hunyuan.V20230901.Models;

   public class HunyuanClient : AbstractClient{

       private const string endpoint = "hunyuan.tencentcloudapi.com";
       private const string version = "2023-09-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HunyuanClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HunyuanClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 腾讯混元大模型高级版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，SDK GitHub仓库examples/hunyuan/v20230901/目录有提供[参考示例](https://github.com/TencentCloud/tencentcloud-sdk-python/blob/master/examples/hunyuan/v20230901/chat_std.py)。
        /// </summary>
        /// <param name="req"><see cref="ChatProRequest"/></param>
        /// <returns><see cref="ChatProResponse"/></returns>
        public async Task<ChatProResponse> ChatPro(ChatProRequest req)
        {
             JsonResponseModel<ChatProResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChatPro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯混元大模型高级版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，SDK GitHub仓库examples/hunyuan/v20230901/目录有提供[参考示例](https://github.com/TencentCloud/tencentcloud-sdk-python/blob/master/examples/hunyuan/v20230901/chat_std.py)。
        /// </summary>
        /// <param name="req"><see cref="ChatProRequest"/></param>
        /// <returns><see cref="ChatProResponse"/></returns>
        public ChatProResponse ChatProSync(ChatProRequest req)
        {
             JsonResponseModel<ChatProResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChatPro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯混元大模型标准版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，SDK GitHub仓库examples/hunyuan/v20230901/目录有提供[参考示例](https://github.com/TencentCloud/tencentcloud-sdk-python/blob/master/examples/hunyuan/v20230901/chat_std.py)。
        /// </summary>
        /// <param name="req"><see cref="ChatStdRequest"/></param>
        /// <returns><see cref="ChatStdResponse"/></returns>
        public async Task<ChatStdResponse> ChatStd(ChatStdRequest req)
        {
             JsonResponseModel<ChatStdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChatStd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatStdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯混元大模型标准版是由腾讯研发的大语言模型，具备强大的中文创作能力，复杂语境下的逻辑推理能力，以及可靠的任务执行能力。本接口为SSE协议。
        /// 
        ///  1.本接口暂不支持返回图片内容。
        ///  2.默认单账号限制并发数为5路，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        ///  3.请使用SDK调用本接口 ，SDK GitHub仓库examples/hunyuan/v20230901/目录有提供[参考示例](https://github.com/TencentCloud/tencentcloud-sdk-python/blob/master/examples/hunyuan/v20230901/chat_std.py)。
        /// </summary>
        /// <param name="req"><see cref="ChatStdRequest"/></param>
        /// <returns><see cref="ChatStdResponse"/></returns>
        public ChatStdResponse ChatStdSync(ChatStdRequest req)
        {
             JsonResponseModel<ChatStdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChatStd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatStdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于计算文本对应Token数、字符数。
        /// </summary>
        /// <param name="req"><see cref="GetTokenCountRequest"/></param>
        /// <returns><see cref="GetTokenCountResponse"/></returns>
        public async Task<GetTokenCountResponse> GetTokenCount(GetTokenCountRequest req)
        {
             JsonResponseModel<GetTokenCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTokenCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTokenCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于计算文本对应Token数、字符数。
        /// </summary>
        /// <param name="req"><see cref="GetTokenCountRequest"/></param>
        /// <returns><see cref="GetTokenCountResponse"/></returns>
        public GetTokenCountResponse GetTokenCountSync(GetTokenCountRequest req)
        {
             JsonResponseModel<GetTokenCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTokenCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTokenCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
