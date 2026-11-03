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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGuardrailBehaviorConfigInput : AbstractModel
    {
        
        /// <summary>
        /// <p>必填，仅允许 input（仅输入）或 both（输入加输出），与控制台一致；不允许 output、空值或省略。送审包方向使用 request/response。</p>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// <p>必填，observe 只观察记录，block 执行命中阻断或符合条件的输出替换。不再自动补默认值。审核异常另由 FailureMode 处理。</p>
        /// </summary>
        [JsonProperty("HandleAction")]
        public string HandleAction{ get; set; }

        /// <summary>
        /// <p>必填整数，50～5000 毫秒，0 无效且不再代表默认值。控制台初始显示 500，但 API 调用方仍须传入。这是每次审核 HTTP 调用的超时，不是整个模型生成或 SSE 连接时长。</p>
        /// </summary>
        [JsonProperty("TimeoutMs")]
        public long? TimeoutMs{ get; set; }

        /// <summary>
        /// <p>必填，open 为异常时尝试放行（存在未审核内容放行风险），closed 为异常时拦截；不得省略或为空。不改变正常命中结论，open 不能绕过所有 Relay 安全或生命周期错误。</p>
        /// </summary>
        [JsonProperty("FailureMode")]
        public string FailureMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "HandleAction", this.HandleAction);
            this.SetParamSimple(map, prefix + "TimeoutMs", this.TimeoutMs);
            this.SetParamSimple(map, prefix + "FailureMode", this.FailureMode);
        }
    }
}

