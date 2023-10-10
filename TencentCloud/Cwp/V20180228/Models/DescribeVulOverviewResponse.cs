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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 重点关注漏洞统计
        /// </summary>
        [JsonProperty("FollowVul")]
        public VulOverview FollowVul{ get; set; }

        /// <summary>
        /// 全部漏洞统计
        /// </summary>
        [JsonProperty("AllVul")]
        public VulOverview AllVul{ get; set; }

        /// <summary>
        /// 影响主机统计
        /// </summary>
        [JsonProperty("EffectHost")]
        public VulOverview EffectHost{ get; set; }

        /// <summary>
        /// 漏洞攻击事件（近1月）统计
        /// </summary>
        [JsonProperty("VulAttackEvent")]
        public VulOverview VulAttackEvent{ get; set; }

        /// <summary>
        /// 已防御攻击（近1月）统计
        /// </summary>
        [JsonProperty("VulDefenceEvent")]
        public VulOverview VulDefenceEvent{ get; set; }

        /// <summary>
        /// 漏洞库统计
        /// </summary>
        [JsonProperty("VulStore")]
        public VulOverview VulStore{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FollowVul.", this.FollowVul);
            this.SetParamObj(map, prefix + "AllVul.", this.AllVul);
            this.SetParamObj(map, prefix + "EffectHost.", this.EffectHost);
            this.SetParamObj(map, prefix + "VulAttackEvent.", this.VulAttackEvent);
            this.SetParamObj(map, prefix + "VulDefenceEvent.", this.VulDefenceEvent);
            this.SetParamObj(map, prefix + "VulStore.", this.VulStore);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

