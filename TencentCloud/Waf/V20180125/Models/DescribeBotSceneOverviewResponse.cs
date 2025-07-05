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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBotSceneOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// BOT总开关
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 场景总数
        /// </summary>
        [JsonProperty("SceneCount")]
        public long? SceneCount{ get; set; }

        /// <summary>
        /// 生效场景数
        /// </summary>
        [JsonProperty("ValidSceneCount")]
        public long? ValidSceneCount{ get; set; }

        /// <summary>
        /// 当前开启的、匹配范围为全局、优先级最高的场景
        /// </summary>
        [JsonProperty("CurrentGlobalScene")]
        public GlobalSceneInfo CurrentGlobalScene{ get; set; }

        /// <summary>
        /// 自定义规则总数，不包括BOT白名单
        /// </summary>
        [JsonProperty("CustomRuleNums")]
        public long? CustomRuleNums{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SceneCount", this.SceneCount);
            this.SetParamSimple(map, prefix + "ValidSceneCount", this.ValidSceneCount);
            this.SetParamObj(map, prefix + "CurrentGlobalScene.", this.CurrentGlobalScene);
            this.SetParamSimple(map, prefix + "CustomRuleNums", this.CustomRuleNums);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

