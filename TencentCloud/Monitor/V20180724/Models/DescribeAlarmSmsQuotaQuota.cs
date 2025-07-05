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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmSmsQuotaQuota : AbstractModel
    {
        
        /// <summary>
        /// 配额类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 配额名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 免费配额剩余量
        /// </summary>
        [JsonProperty("FreeLeft")]
        public long? FreeLeft{ get; set; }

        /// <summary>
        /// 付费配额剩余量
        /// </summary>
        [JsonProperty("PurchaseLeft")]
        public long? PurchaseLeft{ get; set; }

        /// <summary>
        /// 已使用量
        /// </summary>
        [JsonProperty("Used")]
        public long? Used{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "FreeLeft", this.FreeLeft);
            this.SetParamSimple(map, prefix + "PurchaseLeft", this.PurchaseLeft);
            this.SetParamSimple(map, prefix + "Used", this.Used);
        }
    }
}

