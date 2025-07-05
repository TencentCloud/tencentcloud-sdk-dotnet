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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosDetailSets : AbstractModel
    {
        
        /// <summary>
        /// 存储桶名称
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 用量开始时间
        /// </summary>
        [JsonProperty("DosageBeginTime")]
        public string DosageBeginTime{ get; set; }

        /// <summary>
        /// 用量结束时间
        /// </summary>
        [JsonProperty("DosageEndTime")]
        public string DosageEndTime{ get; set; }

        /// <summary>
        /// 子产品名称
        /// </summary>
        [JsonProperty("SubProductCodeName")]
        public string SubProductCodeName{ get; set; }

        /// <summary>
        /// 计费项名称
        /// </summary>
        [JsonProperty("BillingItemCodeName")]
        public string BillingItemCodeName{ get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        [JsonProperty("DosageValue")]
        public string DosageValue{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "DosageBeginTime", this.DosageBeginTime);
            this.SetParamSimple(map, prefix + "DosageEndTime", this.DosageEndTime);
            this.SetParamSimple(map, prefix + "SubProductCodeName", this.SubProductCodeName);
            this.SetParamSimple(map, prefix + "BillingItemCodeName", this.BillingItemCodeName);
            this.SetParamSimple(map, prefix + "DosageValue", this.DosageValue);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

