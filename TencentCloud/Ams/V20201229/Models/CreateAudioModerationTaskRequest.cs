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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAudioModerationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 该字段表示输入的音频审核任务信息，具体输入内容请参见TaskInput数据结构的详细描述。<br> 备注：最多同时可创建**10个任务**。
        /// </summary>
        [JsonProperty("Tasks")]
        public TaskInput[] Tasks{ get; set; }

        /// <summary>
        /// 该字段表示使用的策略的具体编号，该字段需要先在[内容安全控制台](https://console.cloud.tencent.com/cms/clouds/manage)中配置。
        /// 备注：不同Biztype关联不同的业务场景与识别能力策略，调用前请确认正确的Biztype。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 该字段表示输入的音频审核类型，取值含：**AUDIO**（点播音频）、**LIVE_AUDIO**（直播音频）、**AUDIO_AIGC**（AI生成识别）三种，默认值为AUDIO。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 可选参数，该字段表示回调签名的key信息，用于保证数据的安全性。 签名方法为在返回的HTTP头部添加 X-Signature 的字段，值为： seed + body 的 SHA256 编码和Hex字符串，在收到回调数据后，可以根据返回的body，用 **sha256(seed + body)**, 计算出 `X-Signature` 进行验证。<br>具体使用实例可参考 [回调签名示例](https://cloud.tencent.com/document/product/1219/104000#42dd87d2-580f-46cf-a953-639a787d1eda)。
        /// </summary>
        [JsonProperty("Seed")]
        public string Seed{ get; set; }

        /// <summary>
        /// 接收审核信息回调地址。如果设置了该字段，在审核过程中发现违规音频片段结果将发送至该接口。更多详情请参阅[回调配置说明](https://cloud.tencent.com/document/product/1219/104000)。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 该字段表示待检测对象对应的用户相关信息，若填入则可甄别相应违规风险用户
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamObj(map, prefix + "User.", this.User);
        }
    }
}

