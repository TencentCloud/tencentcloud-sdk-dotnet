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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAICallRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 被叫
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// 用于设定AI座席人设、说话规则、任务等的全局提示词。
        /// </summary>
        [JsonProperty("SystemPrompt")]
        public string SystemPrompt{ get; set; }

        /// <summary>
        /// LLM类型
        /// </summary>
        [JsonProperty("LLMType")]
        public string LLMType{ get; set; }

        /// <summary>
        /// 模型（当前仅支持openai协议的模型）
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// API密钥
        /// </summary>
        [JsonProperty("APIKey")]
        public string APIKey{ get; set; }

        /// <summary>
        /// API URL，仅支持兼容openai协议的模型，填写url时后缀不要带/chat/completions
        /// </summary>
        [JsonProperty("APIUrl")]
        public string APIUrl{ get; set; }

        /// <summary>
        /// 音色，目前仅支持以下音色:
        /// 汉语：
        /// ZhiMei：智美，客服女声
        /// ZhiXi： 智希 通用女声
        /// ZhiQi：智琪 客服女声
        /// ZhiTian：智甜 女童声
        /// AiXiaoJing：爱小静 对话女声
        /// 
        /// 英语:
        /// WeRose：英文女声
        /// Monika：英文女声
        /// 
        /// 日语：
        /// Nanami
        /// 
        /// 韩语：
        /// SunHi
        /// 
        /// 印度尼西亚语(印度尼西亚)：
        /// Gadis
        /// 
        /// 马来语（马来西亚）:
        /// Yasmin
        /// 
        ///  泰米尔语（马来西亚）:
        /// Kani
        /// 
        /// 泰语（泰国）:
        /// Achara
        /// 
        /// 越南语(越南):
        /// HoaiMy
        /// 
        /// </summary>
        [JsonProperty("VoiceType")]
        public string VoiceType{ get; set; }

        /// <summary>
        /// 主叫号码列表
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// 用于设定AI座席欢迎语。
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }

        /// <summary>
        /// 0：使用welcomeMessage(为空时，被叫先说话；不为空时，机器人先说话)
        /// 1:   使用ai根据prompt自动生成welcomeMessage并先说话
        /// </summary>
        [JsonProperty("WelcomeType")]
        public long? WelcomeType{ get; set; }

        /// <summary>
        /// 最大等待时长(毫秒)，默认60秒，超过这个时间用户没说话，自动挂断
        /// </summary>
        [JsonProperty("MaxDuration")]
        public long? MaxDuration{ get; set; }

        /// <summary>
        /// 语音识别支持的语言, 默认是"zh" 中文,
        /// 填写数组,最长4个语言，第一个语言为主要识别语言，后面为可选语言，
        /// 注意:主要语言为中国方言时，可选语言无效
        /// 目前全量支持的语言如下，等号左面是语言英文名，右面是Language字段需要填写的值，该值遵循ISO639：
        /// 1. Chinese = "zh" # 中文
        /// 2. Chinese_TW = "zh-TW" # 中国台湾
        /// 3. Chinese_DIALECT = "zh-dialect" # 中国方言
        /// 4. English = "en" # 英语
        /// 5. Vietnamese = "vi" # 越南语
        /// 6. Japanese = "ja" # 日语
        /// 7. Korean = "ko" # 汉语
        /// 8. Indonesia = "id" # 印度尼西亚语
        /// 9. Thai = "th" # 泰语
        /// 10. Portuguese = "pt" # 葡萄牙语
        /// 11. Turkish = "tr" # 土耳其语
        /// 12. Arabic = "ar" # 阿拉伯语
        /// 13. Spanish = "es" # 西班牙语
        /// 14. Hindi = "hi" # 印地语
        /// 15. French = "fr" # 法语
        /// 16. Malay = "ms" # 马来语
        /// 17. Filipino = "fil" # 菲律宾语
        /// 18. German = "de" # 德语
        /// 19. Italian = "it" # 意大利语
        /// 20. Russian = "ru" # 俄语
        /// </summary>
        [JsonProperty("Languages")]
        public string[] Languages{ get; set; }

        /// <summary>
        /// 打断AI说话模式，默认为0，0表示服务端自动打断，1表示服务端不打断，由端上发送打断信令进行打断
        /// </summary>
        [JsonProperty("InterruptMode")]
        public long? InterruptMode{ get; set; }

        /// <summary>
        /// InterruptMode为0时使用，单位为毫秒，默认为500ms。表示服务端检测到持续InterruptSpeechDuration毫秒的人声则进行打断。
        /// </summary>
        [JsonProperty("InterruptSpeechDuration")]
        public long? InterruptSpeechDuration{ get; set; }

        /// <summary>
        /// 模型是否支持(或者开启)call_end function calling
        /// </summary>
        [JsonProperty("EndFunctionEnable")]
        public bool? EndFunctionEnable{ get; set; }

        /// <summary>
        /// EndFunctionEnable为true时生效；call_end function calling的desc，默认为 "End the call when user has to leave (like says bye) or you are instructed to do so."
        /// </summary>
        [JsonProperty("EndFunctionDesc")]
        public string EndFunctionDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "SystemPrompt", this.SystemPrompt);
            this.SetParamSimple(map, prefix + "LLMType", this.LLMType);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
            this.SetParamSimple(map, prefix + "APIUrl", this.APIUrl);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
            this.SetParamSimple(map, prefix + "WelcomeType", this.WelcomeType);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
            this.SetParamArraySimple(map, prefix + "Languages.", this.Languages);
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamSimple(map, prefix + "InterruptSpeechDuration", this.InterruptSpeechDuration);
            this.SetParamSimple(map, prefix + "EndFunctionEnable", this.EndFunctionEnable);
            this.SetParamSimple(map, prefix + "EndFunctionDesc", this.EndFunctionDesc);
        }
    }
}

