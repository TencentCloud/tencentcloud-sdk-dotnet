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

    public class EditBashRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 正则表达式
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// 规则ID（新增时不填）
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 客户端ID数组
        /// </summary>
        [JsonProperty("Uuids")]
        public string[] Uuids{ get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 危险等级(0:无，1: 高危 2:中危 3: 低危)
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 是否全局规则(默认否)
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// 0=黑名单， 1=白名单
        /// </summary>
        [JsonProperty("White")]
        public ulong? White{ get; set; }

        /// <summary>
        /// 事件列表点击“加入白名单”时,需要传EventId 事件的id
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }

        /// <summary>
        /// 是否处理旧事件为白名单 0=不处理 1=处理
        /// </summary>
        [JsonProperty("DealOldEvents")]
        public ulong? DealOldEvents{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "Uuids.", this.Uuids);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "White", this.White);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DealOldEvents", this.DealOldEvents);
        }
    }
}

