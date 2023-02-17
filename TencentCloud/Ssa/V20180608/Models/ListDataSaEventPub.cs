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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDataSaEventPub : AbstractModel
    {
        
        /// <summary>
        /// 受影响资产
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 安全事件名称
        /// </summary>
        [JsonProperty("EventType1")]
        public long? EventType1{ get; set; }

        /// <summary>
        /// 安全事件1级分类
        /// </summary>
        [JsonProperty("EventType2")]
        public long? EventType2{ get; set; }

        /// <summary>
        /// 安全事件2级分类
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 安全事件状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 攻击源ip
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// 攻击目标ip
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// 攻击目标端口
        /// </summary>
        [JsonProperty("DstPort")]
        public long? DstPort{ get; set; }

        /// <summary>
        /// 受影响资产
        /// </summary>
        [JsonProperty("Asset")]
        public string Asset{ get; set; }

        /// <summary>
        /// 私有字段和公有字段映射的原始采集数据唯一标识的MD5值
        /// </summary>
        [JsonProperty("OldIdMd5")]
        public string OldIdMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "EventType1", this.EventType1);
            this.SetParamSimple(map, prefix + "EventType2", this.EventType2);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "Asset", this.Asset);
            this.SetParamSimple(map, prefix + "OldIdMd5", this.OldIdMd5);
        }
    }
}

