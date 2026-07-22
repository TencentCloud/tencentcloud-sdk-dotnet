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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAlertCenterOmitResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Cloud API 处理返回码。0 表示 Action 处理函数未返回顶层错误，-1 表示入口参数校验或路由处理失败。忽略记录的数据库处理结果由 Status 表示；ReturnCode=0 不代表一定有记录被更新。</p>
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }

        /// <summary>
        /// <p>Cloud API 处理信息。Action 处理函数未返回顶层错误时为 success；入口参数校验或路由处理失败时为 failed，并同时返回 Error。</p>
        /// </summary>
        [JsonProperty("ReturnMsg")]
        public string ReturnMsg{ get; set; }

        /// <summary>
        /// <p>忽略处理状态。0 表示目标表更新语句执行时未返回数据库错误，但接口不检查受影响行数，因此不保证有记录命中；-1 表示参数归一化后无有效目标或下游处理失败；-3 表示下游报告重复记录错误。应结合 ReturnCode 判断入口校验是否通过。</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMsg", this.ReturnMsg);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

