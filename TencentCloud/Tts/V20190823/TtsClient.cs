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

namespace TencentCloud.Tts.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tts.V20190823.Models;

   public class TtsClient : AbstractClient{

       private const string endpoint = "tts.tencentcloudapi.com";
       private const string version = "2019-08-23";
       private const string sdkVersion = "SDK_NET_3.0.1018";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口服务对10万字符以内的文本进行语音合成，异步返回音频结果。满足一次性合成较长文本的客户需求，如阅读播报、新闻媒体等场景。
        /// 
        /// <li>支持音频格式：mp3,wav,pcm</li>
        /// <li>支持音频采样率：16000 Hz, 8000 Hz</li>
        /// <li>支持中文普通话、英文、中英文混读、粤语合成</li>
        /// <li>支持语速、音量设置</li>
        /// <li>支持回调或轮询的方式获取结果，结果获取请参考 长文本语音合成结果查询。</li>
        /// <li>提交长文本语音合成请求后，合成结果在3小时内完成，音频文件在服务端可保存24小时</li>
        /// 
        /// <p></p>
        /// 
        /// 长文本合成支持 SSML，语法详见 [SSML 标记语言](https://cloud.tencent.com/document/product/1073/49575)，使用时需满足如下使用规范：
        /// <li>使用 SSML 标签，需置于 speak 闭合标签内部；</li>
        /// <li>合成文本可包含多组 speak 闭合标签，且无数量限制；</li>
        /// <li>每个 speak 闭合标签内部，字符数不超过 150 字（标签字符本身不计算在内）；</li>
        /// <li>每个 speak 闭合标签内部，使用 break 标签数目最大为 10 个。如需要使用更多，可拆解到多个 speak 标签中；</li>
        /// 
        /// <p></p>
        /// </summary>
        /// <param name="req"><see cref="CreateTtsTaskRequest"/></param>
        /// <returns><see cref="CreateTtsTaskResponse"/></returns>
        public Task<CreateTtsTaskResponse> CreateTtsTask(CreateTtsTaskRequest req)
        {
            return InternalRequestAsync<CreateTtsTaskResponse>(req, "CreateTtsTask");
        }

        /// <summary>
        /// 本接口服务对10万字符以内的文本进行语音合成，异步返回音频结果。满足一次性合成较长文本的客户需求，如阅读播报、新闻媒体等场景。
        /// 
        /// <li>支持音频格式：mp3,wav,pcm</li>
        /// <li>支持音频采样率：16000 Hz, 8000 Hz</li>
        /// <li>支持中文普通话、英文、中英文混读、粤语合成</li>
        /// <li>支持语速、音量设置</li>
        /// <li>支持回调或轮询的方式获取结果，结果获取请参考 长文本语音合成结果查询。</li>
        /// <li>提交长文本语音合成请求后，合成结果在3小时内完成，音频文件在服务端可保存24小时</li>
        /// 
        /// <p></p>
        /// 
        /// 长文本合成支持 SSML，语法详见 [SSML 标记语言](https://cloud.tencent.com/document/product/1073/49575)，使用时需满足如下使用规范：
        /// <li>使用 SSML 标签，需置于 speak 闭合标签内部；</li>
        /// <li>合成文本可包含多组 speak 闭合标签，且无数量限制；</li>
        /// <li>每个 speak 闭合标签内部，字符数不超过 150 字（标签字符本身不计算在内）；</li>
        /// <li>每个 speak 闭合标签内部，使用 break 标签数目最大为 10 个。如需要使用更多，可拆解到多个 speak 标签中；</li>
        /// 
        /// <p></p>
        /// </summary>
        /// <param name="req"><see cref="CreateTtsTaskRequest"/></param>
        /// <returns><see cref="CreateTtsTaskResponse"/></returns>
        public CreateTtsTaskResponse CreateTtsTaskSync(CreateTtsTaskRequest req)
        {
            return InternalRequestAsync<CreateTtsTaskResponse>(req, "CreateTtsTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在调用长文本语音合成请求接口后，有回调和轮询两种方式获取识别结果。
        /// 
        /// <li>当采用回调方式时，合成完毕后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见 长文本语音合成结果查询 。</li>
        /// <li>当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。</li>
        /// </summary>
        /// <param name="req"><see cref="DescribeTtsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTtsTaskStatusResponse"/></returns>
        public Task<DescribeTtsTaskStatusResponse> DescribeTtsTaskStatus(DescribeTtsTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTtsTaskStatusResponse>(req, "DescribeTtsTaskStatus");
        }

        /// <summary>
        /// 在调用长文本语音合成请求接口后，有回调和轮询两种方式获取识别结果。
        /// 
        /// <li>当采用回调方式时，合成完毕后会将结果通过 POST 请求的形式通知到用户在请求时填写的回调 URL，具体请参见 长文本语音合成结果查询 。</li>
        /// <li>当采用轮询方式时，需要主动提交任务ID来轮询识别结果，共有任务成功、等待、执行中和失败四种结果，具体信息请参见下文说明。</li>
        /// </summary>
        /// <param name="req"><see cref="DescribeTtsTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTtsTaskStatusResponse"/></returns>
        public DescribeTtsTaskStatusResponse DescribeTtsTaskStatusSync(DescribeTtsTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTtsTaskStatusResponse>(req, "DescribeTtsTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云语音合成技术（TTS）可以将任意文本转化为语音，实现让机器和应用张口说话。
        /// 腾讯TTS技术可以应用到很多场景，比如，移动APP语音播报新闻；智能设备语音提醒；依靠网上现有节目或少量录音，快速合成明星语音，降低邀约成本；支持车载导航语音合成的个性化语音播报。
        /// 基础合成支持 SSML，语法详见 [SSML 标记语言](https://cloud.tencent.com/document/product/1073/49575)。
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="TextToVoiceRequest"/></param>
        /// <returns><see cref="TextToVoiceResponse"/></returns>
        public Task<TextToVoiceResponse> TextToVoice(TextToVoiceRequest req)
        {
            return InternalRequestAsync<TextToVoiceResponse>(req, "TextToVoice");
        }

        /// <summary>
        /// 腾讯云语音合成技术（TTS）可以将任意文本转化为语音，实现让机器和应用张口说话。
        /// 腾讯TTS技术可以应用到很多场景，比如，移动APP语音播报新闻；智能设备语音提醒；依靠网上现有节目或少量录音，快速合成明星语音，降低邀约成本；支持车载导航语音合成的个性化语音播报。
        /// 基础合成支持 SSML，语法详见 [SSML 标记语言](https://cloud.tencent.com/document/product/1073/49575)。
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="TextToVoiceRequest"/></param>
        /// <returns><see cref="TextToVoiceResponse"/></returns>
        public TextToVoiceResponse TextToVoiceSync(TextToVoiceRequest req)
        {
            return InternalRequestAsync<TextToVoiceResponse>(req, "TextToVoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
