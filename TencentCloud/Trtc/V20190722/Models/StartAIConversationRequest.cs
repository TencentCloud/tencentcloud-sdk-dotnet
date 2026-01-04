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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartAIConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的[SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid)，和开启转录任务的房间使用的SdkAppId相同。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// TRTC的[RoomId](https://cloud.tencent.com/document/product/647/46351#roomid)，表示开启对话任务的房间号。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 机器人参数
        /// </summary>
        [JsonProperty("AgentConfig")]
        public AgentConfig AgentConfig{ get; set; }

        /// <summary>
        /// 调用方传入的唯一Id，可用于客户侧防止重复发起任务以及可以通过该字段查询任务状态。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// TRTC房间号的类型，0代表数字房间号，1代表字符串房间号。不填默认是数字房间号。
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// 语音识别配置。
        /// </summary>
        [JsonProperty("STTConfig")]
        public STTConfig STTConfig{ get; set; }

        /// <summary>
        /// 必填参数，LLM配置。需符合openai规范，为JSON字符串，示例如下：<pre> { <br> &emsp;  "LLMType": "大模型类型",  // String 必填，如："openai" <br> &emsp;  "Model": "您的模型名称", // String 必填，指定使用的模型<br>    "APIKey": "您的LLM API密钥", // String 必填 <br> &emsp;  "APIUrl": "https://api.xxx.com/chat/completions", // String 必填，LLM API访问的URL<br> &emsp;  "History": 10, // Integer 选填，设置 LLM 的上下文轮次，默认值为0，最大值50<br> &emsp;  "HistoryMode": 1, // Integer 选填，1表示LLM上下文中的内容会和播放音频做同步，没有播放的音频对应的文本不会出现在上下文中。0表示不会做同步，默认值为0<br> &emsp;  "Streaming": true // Boolean 非必填，指定是否使用流式传输<br> &emsp;} </pre>
        /// </summary>
        [JsonProperty("LLMConfig")]
        public string LLMConfig{ get; set; }

        /// <summary>
        /// 必填参数，TTS配置，详见 [TTS配置说明](https://cloud.tencent.com/document/product/647/115414 )， 为JSON字符串: TRTC TTS的配置如下：```{  "TTSType": "flow",  // 【必填】固定为此值  "VoiceId": "v-female-R2s4N9qJ", // 【必填】精品音色 ID /克隆音色 ID, 可选择不同音色, ID 库参考下方音色列表  "Model": "flow_01_turbo", // 【必填】当前默认的 TTS 模型版本（对应 Flash 版本）  "Speed": 1.0,    //【可选】调节语速 范围 [0.5-2.0],默认 1.0; 取值越大，语速越快  "Volume": 1.0,   // 【可选】调节音量 [0, 10] 默认值 1.0; 取值越大，音量越高  "Pitch": 0,   // 【可选】调节语调 [-12,12],默认值为 0,其中 0 为原音色输出。  "Language": "zh" //【可选】建议填写，目前支持填写中文：zh 英文：en 粤语方言：yue; 参数参考：(ISO 639-1) }```
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
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamSimple(map, prefix + "LLMConfig", this.LLMConfig);
            this.SetParamSimple(map, prefix + "TTSConfig", this.TTSConfig);
            this.SetParamSimple(map, prefix + "AvatarConfig", this.AvatarConfig);
            this.SetParamSimple(map, prefix + "ExperimentalParams", this.ExperimentalParams);
        }
    }
}

