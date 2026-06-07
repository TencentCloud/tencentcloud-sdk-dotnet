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

    public class CfwInsStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>防火墙实例id</p>
        /// </summary>
        [JsonProperty("CfwInsId")]
        public string CfwInsId{ get; set; }

        /// <summary>
        /// <p>防火墙类型，nat：nat防火墙；ew：vpc间防火墙</p>
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// <p>实例所属地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>实例运行状态，Running：正常运行；BypassAutoFix：bypass修复；Updating：升级中；Expand：扩容中；BypassManual：手动触发bypass中；BypassAuto：自动触发bypass中；BypassTcDrop：丢包触发bypass中</p><p>枚举值：</p><ul><li>Running： 正常运行</li><li>BypassAutoFix： 自动bypass已修复</li><li>Updating： 实例升级中</li><li>Expand： 实例扩容中</li><li>BypassManual： 手动触发bypass中</li><li>BypassAuto： 自动触发bypass中</li><li>BypassTcDrop： 丢包触发bypass中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>事件时间</p>
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// <p>恢复时间</p>
        /// </summary>
        [JsonProperty("RecoverTime")]
        public string RecoverTime{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("CfwInsName")]
        public string CfwInsName{ get; set; }

        /// <summary>
        /// <p>Normal: 正常模式<br>OnlyRoute: 透明模式</p>
        /// </summary>
        [JsonProperty("TrafficMode")]
        public string TrafficMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CfwInsId", this.CfwInsId);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "RecoverTime", this.RecoverTime);
            this.SetParamSimple(map, prefix + "CfwInsName", this.CfwInsName);
            this.SetParamSimple(map, prefix + "TrafficMode", this.TrafficMode);
        }
    }
}

