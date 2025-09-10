/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartAIConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// GME的SdkAppId和开启转录任务的房间使用的SdkAppId相同。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// GME的RoomId表示开启对话任务的房间号。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 机器人参数
        /// </summary>
        [JsonProperty("AgentConfig")]
        public AgentConfig AgentConfig{ get; set; }

        /// <summary>
        /// 语音识别配置。
        /// </summary>
        [JsonProperty("STTConfig")]
        public STTConfig STTConfig{ get; set; }

        /// <summary>
        /// LLM配置。需符合openai规范，为JSON字符串，示例如下：
        /// <pre> { <br> &emsp;  "LLMType": "大模型类型",  // String 必填，如："openai" <br> &emsp;  "Model": "您的模型名称", // String 必填，指定使用的模型<br>    "APIKey": "您的LLM API密钥", // String 必填 <br> &emsp;  "APIUrl": "https://api.xxx.com/chat/completions", // String 必填，LLM API访问的URL<br> &emsp;  "Streaming": true // Boolean 非必填，指定是否使用流式传输<br> &emsp;} </pre>
        /// </summary>
        [JsonProperty("LLMConfig")]
        public string LLMConfig{ get; set; }

        /// <summary>
        ///                                         "description": "TTS配置，为JSON字符串，腾讯云TTS示例如下： <pre>{ <br> &emsp; \"AppId\": 您的应用ID, // Integer 必填<br> &emsp; \"TTSType\": \"TTS类型\", // String TTS类型, 固定为\"tencent\"<br> &emsp; \"SecretId\": \"您的密钥ID\", // String 必填<br> &emsp; \"SecretKey\":  \"您的密钥Key\", // String 必填<br> &emsp; \"VoiceType\": 101001, // Integer  必填，音色 ID，包括标准音色与精品音色，精品音色拟真度更高，价格不同于标准音色。<br> &emsp; \"Speed\": 1.25, // Integer 非必填，语速，范围：[-2，6]，分别对应不同语速： -2: 代表0.6倍 -1: 代表0.8倍 0: 代表1.0倍（默认） 1: 代表1.2倍 2: 代表1.5倍  6: 代表2.5倍  如果需要更细化的语速，可以保留小数点后 2 位，例如0.5/1.25/2.81等。 参数值与实际语速转换\"Volume\": 5, // Integer 非必填，音量大小，范围：[0，10]，分别对应11个等级的音量，默认值为0，代表正常音量。<br> &emsp; \"EmotionCategory\":  \"angry\", // String 非必填 控制合成音频的情感，仅支持多情感音色使用。取值: neutral(中性)、sad(悲伤)、happy(高兴)、angry(生气)、fear(恐惧)、news(新闻)、story(故事)、radio(广播)、poetry(诗歌)、call(客服)、sajiao(撒娇)、disgusted(厌恶)、amaze(震惊)、peaceful(平静)、exciting(兴奋)、aojiao(傲娇)、jieshuo(解说)。<br> &emsp; \"EmotionIntensity\":  150 // Integer 非必填 控制合成音频情感程度，取值范围为 [50,200]，默认为 100；只有 EmotionCategory 不为空时生效。<br> &emsp; }</pre>",
        /// </summary>
        [JsonProperty("TTSConfig")]
        public string TTSConfig{ get; set; }

        /// <summary>
        /// 数字人配置，为JSON字符串。**数字人配置需要提工单加白后才能使用**
        /// </summary>
        [JsonProperty("AvatarConfig")]
        public string AvatarConfig{ get; set; }

        /// <summary>
        /// 实验性参数,联系后台使用
        /// </summary>
        [JsonProperty("ExperimentalParams")]
        public string ExperimentalParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamObj(map, prefix + "AgentConfig.", this.AgentConfig);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamSimple(map, prefix + "LLMConfig", this.LLMConfig);
            this.SetParamSimple(map, prefix + "TTSConfig", this.TTSConfig);
            this.SetParamSimple(map, prefix + "AvatarConfig", this.AvatarConfig);
            this.SetParamSimple(map, prefix + "ExperimentalParams", this.ExperimentalParams);
        }
    }
}

