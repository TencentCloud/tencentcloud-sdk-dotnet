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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageScanInquireInfo : AbstractModel
    {
        
        /// <summary>
        /// 计费项
        /// </summary>
        [JsonProperty("InquireKey")]
        public string InquireKey{ get; set; }

        /// <summary>
        /// 总容量
        /// </summary>
        [JsonProperty("Capcity")]
        public ulong? Capcity{ get; set; }

        /// <summary>
        /// 已使用量
        /// </summary>
        [JsonProperty("Useage")]
        public ulong? Useage{ get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 计费状态
        /// (Pending:待购)
        /// (Normal:正常)
        /// (Isolate:隔离)
        /// </summary>
        [JsonProperty("PurchaseStatus")]
        public string PurchaseStatus{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// 购买扫描数
        /// </summary>
        [JsonProperty("PayNum")]
        public ulong? PayNum{ get; set; }

        /// <summary>
        /// 试用扫描数
        /// </summary>
        [JsonProperty("TrialNum")]
        public ulong? TrialNum{ get; set; }

        /// <summary>
        /// 购买已使用量
        /// </summary>
        [JsonProperty("PayUsage")]
        public ulong? PayUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InquireKey", this.InquireKey);
            this.SetParamSimple(map, prefix + "Capcity", this.Capcity);
            this.SetParamSimple(map, prefix + "Useage", this.Useage);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PurchaseStatus", this.PurchaseStatus);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "PayNum", this.PayNum);
            this.SetParamSimple(map, prefix + "TrialNum", this.TrialNum);
            this.SetParamSimple(map, prefix + "PayUsage", this.PayUsage);
        }
    }
}

