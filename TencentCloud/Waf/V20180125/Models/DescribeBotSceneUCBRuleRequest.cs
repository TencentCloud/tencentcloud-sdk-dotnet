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

    public class DescribeBotSceneUCBRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 翻页组件的起始页
        /// </summary>
        [JsonProperty("Skip")]
        public ulong? Skip{ get; set; }

        /// <summary>
        /// 翻页组件的页数据条数
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序参数
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 1.BOT全局白名单处调用时，传"global";2.BOT场景配置处调用时，传具体的场景ID
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 需要过滤的动作
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 需要过滤的规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 兼容老数据和新旧版前端
        /// </summary>
        [JsonProperty("VersionFlag")]
        public string VersionFlag{ get; set; }

        /// <summary>
        /// 生效方式：0-全部 1-永久生效 2-定时生效 3-周粒度生效 4-月粒度生效
        /// </summary>
        [JsonProperty("TimerType")]
        public ulong? TimerType{ get; set; }

        /// <summary>
        /// 0-全部 1-生效中 2-已过期
        /// </summary>
        [JsonProperty("ValidStatus")]
        public ulong? ValidStatus{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Skip", this.Skip);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VersionFlag", this.VersionFlag);
            this.SetParamSimple(map, prefix + "TimerType", this.TimerType);
            this.SetParamSimple(map, prefix + "ValidStatus", this.ValidStatus);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

