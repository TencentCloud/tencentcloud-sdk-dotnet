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

namespace TencentCloud.Tsi.V20210325
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tsi.V20210325.Models;

   public class TsiClient : AbstractClient{

       private const string endpoint = "tsi.tencentcloudapi.com";
       private const string version = "2021-03-25";
       private const string sdkVersion = "SDK_NET_3.0.1041";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TsiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TsiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取同传结果。
        /// </summary>
        /// <param name="req"><see cref="TongChuanDisplayRequest"/></param>
        /// <returns><see cref="TongChuanDisplayResponse"/></returns>
        public Task<TongChuanDisplayResponse> TongChuanDisplay(TongChuanDisplayRequest req)
        {
            return InternalRequestAsync<TongChuanDisplayResponse>(req, "TongChuanDisplay");
        }

        /// <summary>
        /// 获取同传结果。
        /// </summary>
        /// <param name="req"><see cref="TongChuanDisplayRequest"/></param>
        /// <returns><see cref="TongChuanDisplayResponse"/></returns>
        public TongChuanDisplayResponse TongChuanDisplaySync(TongChuanDisplayRequest req)
        {
            return InternalRequestAsync<TongChuanDisplayResponse>(req, "TongChuanDisplay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口提供上传音频，将音频进行语音识别并翻译成文本的服务，目前开放中英互译的同传服务。 待识别和翻译的音频文件格式是 pcm，pcm采样率要求16kHz、位深16bit、单声道、每个分片时长200ms~500ms，音频内语音清晰。
        /// </summary>
        /// <param name="req"><see cref="TongChuanRecognizeRequest"/></param>
        /// <returns><see cref="TongChuanRecognizeResponse"/></returns>
        public Task<TongChuanRecognizeResponse> TongChuanRecognize(TongChuanRecognizeRequest req)
        {
            return InternalRequestAsync<TongChuanRecognizeResponse>(req, "TongChuanRecognize");
        }

        /// <summary>
        /// 本接口提供上传音频，将音频进行语音识别并翻译成文本的服务，目前开放中英互译的同传服务。 待识别和翻译的音频文件格式是 pcm，pcm采样率要求16kHz、位深16bit、单声道、每个分片时长200ms~500ms，音频内语音清晰。
        /// </summary>
        /// <param name="req"><see cref="TongChuanRecognizeRequest"/></param>
        /// <returns><see cref="TongChuanRecognizeResponse"/></returns>
        public TongChuanRecognizeResponse TongChuanRecognizeSync(TongChuanRecognizeRequest req)
        {
            return InternalRequestAsync<TongChuanRecognizeResponse>(req, "TongChuanRecognize")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口提供上传音频，将音频进行语音识别并翻译成文本的服务，目前开放中英互译的同传服务。 待识别和翻译的音频文件格式是 pcm，pcm采样率要求16kHz、位深16bit、单声道、每个分片时长200ms~500ms，音频内语音清晰。
        /// </summary>
        /// <param name="req"><see cref="TongChuanSyncRequest"/></param>
        /// <returns><see cref="TongChuanSyncResponse"/></returns>
        public Task<TongChuanSyncResponse> TongChuanSync(TongChuanSyncRequest req)
        {
            return InternalRequestAsync<TongChuanSyncResponse>(req, "TongChuanSync");
        }

        /// <summary>
        /// 本接口提供上传音频，将音频进行语音识别并翻译成文本的服务，目前开放中英互译的同传服务。 待识别和翻译的音频文件格式是 pcm，pcm采样率要求16kHz、位深16bit、单声道、每个分片时长200ms~500ms，音频内语音清晰。
        /// </summary>
        /// <param name="req"><see cref="TongChuanSyncRequest"/></param>
        /// <returns><see cref="TongChuanSyncResponse"/></returns>
        public TongChuanSyncResponse TongChuanSyncSync(TongChuanSyncRequest req)
        {
            return InternalRequestAsync<TongChuanSyncResponse>(req, "TongChuanSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
