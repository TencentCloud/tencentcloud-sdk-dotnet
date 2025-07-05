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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetUserQuotaInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID。
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 用户购买的DB配额。
        /// </summary>
        [JsonProperty("DbTotalQuota")]
        public long? DbTotalQuota{ get; set; }

        /// <summary>
        /// 用户购买的COS存储量配额。
        /// </summary>
        [JsonProperty("CosTotalQuota")]
        public long? CosTotalQuota{ get; set; }

        /// <summary>
        /// 用户可用的DB配额。
        /// </summary>
        [JsonProperty("DbRemainQuota")]
        public long? DbRemainQuota{ get; set; }

        /// <summary>
        /// 用户可用的COS存储量配额。
        /// </summary>
        [JsonProperty("CosRemainQuota")]
        public float? CosRemainQuota{ get; set; }

        /// <summary>
        /// COS存储量单位，例如TB。
        /// </summary>
        [JsonProperty("CosQuotaUnit")]
        public string CosQuotaUnit{ get; set; }

        /// <summary>
        /// db月解绑次数
        /// </summary>
        [JsonProperty("DBUnbindNum")]
        public long? DBUnbindNum{ get; set; }

        /// <summary>
        /// cos月解绑次数
        /// </summary>
        [JsonProperty("COSUnbindNum")]
        public long? COSUnbindNum{ get; set; }

        /// <summary>
        /// 用户购买的实例配额。
        /// </summary>
        [JsonProperty("InsTotalQuota")]
        public long? InsTotalQuota{ get; set; }

        /// <summary>
        /// 用户可用的实例配额。
        /// </summary>
        [JsonProperty("InsRemainQuota")]
        public long? InsRemainQuota{ get; set; }

        /// <summary>
        /// 用户购买的版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "DbTotalQuota", this.DbTotalQuota);
            this.SetParamSimple(map, prefix + "CosTotalQuota", this.CosTotalQuota);
            this.SetParamSimple(map, prefix + "DbRemainQuota", this.DbRemainQuota);
            this.SetParamSimple(map, prefix + "CosRemainQuota", this.CosRemainQuota);
            this.SetParamSimple(map, prefix + "CosQuotaUnit", this.CosQuotaUnit);
            this.SetParamSimple(map, prefix + "DBUnbindNum", this.DBUnbindNum);
            this.SetParamSimple(map, prefix + "COSUnbindNum", this.COSUnbindNum);
            this.SetParamSimple(map, prefix + "InsTotalQuota", this.InsTotalQuota);
            this.SetParamSimple(map, prefix + "InsRemainQuota", this.InsRemainQuota);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

