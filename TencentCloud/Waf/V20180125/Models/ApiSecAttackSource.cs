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

    public class ApiSecAttackSource : AbstractModel
    {
        
        /// <summary>
        /// 攻击来源ip
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// 威胁等级
        /// </summary>
        [JsonProperty("EventLevel")]
        public string EventLevel{ get; set; }

        /// <summary>
        /// BOT标签
        /// </summary>
        [JsonProperty("BotLabel")]
        public string BotLabel{ get; set; }

        /// <summary>
        /// 变更时间
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// 地理位置
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 关联事件数量
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// 攻击数量
        /// </summary>
        [JsonProperty("AttackCount")]
        public long? AttackCount{ get; set; }

        /// <summary>
        /// 缺失参数名，当事件类型是缺失参数名，缺失参数名和密码时，返回此字段
        /// </summary>
        [JsonProperty("MissUserName")]
        public string MissUserName{ get; set; }

        /// <summary>
        /// 当是水平越权和垂直越权时，返回此字段
        /// </summary>
        [JsonProperty("AttackDetail")]
        public string[] AttackDetail{ get; set; }

        /// <summary>
        /// 缺失密码参数，当事件类型是缺失参数名，缺失参数名和密码时，返回此字段
        /// </summary>
        [JsonProperty("MissPassword")]
        public string MissPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "EventLevel", this.EventLevel);
            this.SetParamSimple(map, prefix + "BotLabel", this.BotLabel);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "AttackCount", this.AttackCount);
            this.SetParamSimple(map, prefix + "MissUserName", this.MissUserName);
            this.SetParamArraySimple(map, prefix + "AttackDetail.", this.AttackDetail);
            this.SetParamSimple(map, prefix + "MissPassword", this.MissPassword);
        }
    }
}

