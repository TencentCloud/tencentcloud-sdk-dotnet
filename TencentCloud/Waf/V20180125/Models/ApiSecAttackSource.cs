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
        /// <p>攻击来源ip</p>
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// <p>威胁等级</p>
        /// </summary>
        [JsonProperty("EventLevel")]
        public string EventLevel{ get; set; }

        /// <summary>
        /// <p>BOT标签</p>
        /// </summary>
        [JsonProperty("BotLabel")]
        public string BotLabel{ get; set; }

        /// <summary>
        /// <p>变更时间</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// <p>地理位置</p>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>关联事件数量</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// <p>攻击数量</p>
        /// </summary>
        [JsonProperty("AttackCount")]
        public long? AttackCount{ get; set; }

        /// <summary>
        /// <p>缺失参数名，当事件类型是缺失参数名，缺失参数名和密码时，返回此字段</p>
        /// </summary>
        [JsonProperty("MissUserName")]
        public string MissUserName{ get; set; }

        /// <summary>
        /// <p>当是水平越权和垂直越权时，返回此字段</p>
        /// </summary>
        [JsonProperty("AttackDetail")]
        public string[] AttackDetail{ get; set; }

        /// <summary>
        /// <p>缺失密码参数，当事件类型是缺失参数名，缺失参数名和密码时，返回此字段</p>
        /// </summary>
        [JsonProperty("MissPassword")]
        public string MissPassword{ get; set; }

        /// <summary>
        /// <p>事件描述</p>
        /// </summary>
        [JsonProperty("EventDescription")]
        public string EventDescription{ get; set; }

        /// <summary>
        /// <p>事件描述(英文)</p>
        /// </summary>
        [JsonProperty("EventDescriptionEng")]
        public string EventDescriptionEng{ get; set; }

        /// <summary>
        /// <p>攻击样本</p>
        /// </summary>
        [JsonProperty("Sample")]
        public ApiEventSample Sample{ get; set; }


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
            this.SetParamSimple(map, prefix + "EventDescription", this.EventDescription);
            this.SetParamSimple(map, prefix + "EventDescriptionEng", this.EventDescriptionEng);
            this.SetParamObj(map, prefix + "Sample.", this.Sample);
        }
    }
}

