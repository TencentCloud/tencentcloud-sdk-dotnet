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

    public class CustomGuardrailBehaviorConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>审核方向：input 只审核业务请求，output 只审核业务响应，both 两者均审核；创建默认 input。送审包及审核日志使用 request/response 表示方向，不使用 input/output。</p>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// <p>命中后的处理：block 执行阻断或符合条件的输出替换；observe 仅观察记录命中，不执行命中阻断或替换。创建默认 block。审核调用异常另由 FailureMode 处理，不应把 observe 当作所有故障无条件放行。</p>
        /// </summary>
        [JsonProperty("HandleAction")]
        public string HandleAction{ get; set; }

        /// <summary>
        /// <p>审核调用超时，单位毫秒，范围 50～5000，创建默认 500。不是整个模型生成/SSE 连接的总时长限制；流式多批次分别发生审核 HTTP 调用。应按引擎网络及处理耗时设置，示例中的 5000 是显式测试值，不是默认值。</p>
        /// </summary>
        [JsonProperty("TimeoutMs")]
        public long? TimeoutMs{ get; set; }

        /// <summary>
        /// <p>审核失败时的策略：open 尝试失败放行（创建默认值，有内容未审核即放行风险）；closed 失败关闭。此项处理网络、超时、响应契约等异常，不改变正常 block 判定。open 不能绕过所有 Relay 安全/生命周期错误，也不保证已派发业务请求可安全重放。</p>
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

