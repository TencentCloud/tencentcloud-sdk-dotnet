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

    public class TurnDetection : AbstractModel
    {
        
        /// <summary>
        /// TurnDetectionMode为3时生效，语义断句的灵敏程度
        /// 
        /// 
        /// 功能简介：根据用户所说的话来判断其已完成发言来分割音频
        /// 
        /// 
        /// 可选: "low" | "medium" | "high" | "auto"
        /// 
        /// 
        /// auto 是默认值，与 medium 相同。
        /// low 将让用户有足够的时间说话。
        /// high 将尽快对音频进行分块。
        /// 
        /// 
        /// 如果您希望模型在对话模式下更频繁地响应，可以将 SemanticEagerness 设置为 high
        /// 如果您希望在用户停顿时，AI能够等待片刻，可以将 SemanticEagerness 设置为 low
        /// 无论什么模式，最终都会分割送个大模型进行回复
        /// </summary>
        [JsonProperty("SemanticEagerness")]
        public string SemanticEagerness{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SemanticEagerness", this.SemanticEagerness);
        }
    }
}

