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

    public class DescribeIpAccessControlRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 计数标识
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 动作，40表示查询白名单，42表示查询黑名单
        /// </summary>
        [JsonProperty("ActionType")]
        public ulong? ActionType{ get; set; }

        /// <summary>
        /// 最小有效时间的时间戳
        /// </summary>
        [JsonProperty("VtsMin")]
        [System.Obsolete]
        public ulong? VtsMin{ get; set; }

        /// <summary>
        /// 最大有效时间的时间戳
        /// </summary>
        [JsonProperty("VtsMax")]
        [System.Obsolete]
        public ulong? VtsMax{ get; set; }

        /// <summary>
        /// 最小创建时间的时间戳
        /// </summary>
        [JsonProperty("CtsMin")]
        public ulong? CtsMin{ get; set; }

        /// <summary>
        /// 最大创建时间的时间戳
        /// </summary>
        [JsonProperty("CtsMax")]
        public ulong? CtsMax{ get; set; }

        /// <summary>
        /// 分页偏移量，取Limit整数倍。最小值为0，最大值= Total/Limit向上取整
        /// </summary>
        [JsonProperty("OffSet")]
        public ulong? OffSet{ get; set; }

        /// <summary>
        /// 每页返回的数量，默认为20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 排序参数
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 生效状态，1表示生效中，2表示过期，0表示全部
        /// </summary>
        [JsonProperty("ValidStatus")]
        public long? ValidStatus{ get; set; }

        /// <summary>
        /// 最小有效时间的时间戳
        /// </summary>
        [JsonProperty("ValidTimeStampMin")]
        public string ValidTimeStampMin{ get; set; }

        /// <summary>
        /// 最大有效时间的时间戳
        /// </summary>
        [JsonProperty("ValidTimeStampMax")]
        public string ValidTimeStampMax{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 0表示全部，1表示永久生效，2表示定时生效，3表示周粒度生效，4表示月粒度生效
        /// </summary>
        [JsonProperty("TimerType")]
        public long? TimerType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "VtsMin", this.VtsMin);
            this.SetParamSimple(map, prefix + "VtsMax", this.VtsMax);
            this.SetParamSimple(map, prefix + "CtsMin", this.CtsMin);
            this.SetParamSimple(map, prefix + "CtsMax", this.CtsMax);
            this.SetParamSimple(map, prefix + "OffSet", this.OffSet);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "ValidStatus", this.ValidStatus);
            this.SetParamSimple(map, prefix + "ValidTimeStampMin", this.ValidTimeStampMin);
            this.SetParamSimple(map, prefix + "ValidTimeStampMax", this.ValidTimeStampMax);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "TimerType", this.TimerType);
        }
    }
}

