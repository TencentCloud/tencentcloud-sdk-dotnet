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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>日志保存时长（天）</p><p>枚举值：</p><ul><li>7： 7天</li><li>30： 30天</li><li>90： 90天</li><li>180： 180天</li><li>365： 365天</li><li>1095： 1095天</li><li>1825： 1825天</li></ul>
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// <p>高频存储时长（天）</p><p>枚举值：</p><ul><li>7： 7天</li><li>30： 30天</li><li>90： 90天</li><li>180： 180天</li><li>365： 365天</li><li>1095： 1095天</li><li>1825： 1825天</li></ul>
        /// </summary>
        [JsonProperty("HotLogExpireDay")]
        public ulong? HotLogExpireDay{ get; set; }

        /// <summary>
        /// <p>审计类型</p><p>枚举值：</p><ul><li>complex： 精细审计，审计日志更全面，包含对象类型、对象等，开启后对性能有一定影响</li><li>simple： 极速审计，审计日志覆盖绝大多数字段，开启审计后对性能影响较小</li></ul>
        /// </summary>
        [JsonProperty("AuditType")]
        public string AuditType{ get; set; }

        /// <summary>
        /// <p>产品名称</p><p>入参限制：postgres</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HotLogExpireDay", this.HotLogExpireDay);
            this.SetParamSimple(map, prefix + "AuditType", this.AuditType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

