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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAttachedUserAllPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 目标用户Uin
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }

        /// <summary>
        /// 每页数量，必须大于 0 且小于等于 200。
        /// </summary>
        [JsonProperty("Rp")]
        public ulong? Rp{ get; set; }

        /// <summary>
        /// 页码，从 1开始，不能大于 200。
        /// </summary>
        [JsonProperty("Page")]
        public ulong? Page{ get; set; }

        /// <summary>
        /// 关联类型。0:返回直接关联和随组关联策略，1:只返回直接关联策略，2:只返回随组关联策略。
        /// </summary>
        [JsonProperty("AttachType")]
        public ulong? AttachType{ get; set; }

        /// <summary>
        /// 策略类型。1表示自定义策略，2表示预设策略。
        /// </summary>
        [JsonProperty("StrategyType")]
        public ulong? StrategyType{ get; set; }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "Rp", this.Rp);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "AttachType", this.AttachType);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

