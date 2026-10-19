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

    public class OverviewResourceQuotaDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>南北向带宽与流量详情数据。</p>
        /// </summary>
        [JsonProperty("NorthSouthDetail")]
        public OverviewNorthSouthDetail NorthSouthDetail{ get; set; }

        /// <summary>
        /// <p>东西向带宽与流量详情数据。</p>
        /// </summary>
        [JsonProperty("EastWestDetail")]
        public OverviewEastWestDetail EastWestDetail{ get; set; }

        /// <summary>
        /// <p>NDR 带宽与流量详情数据。</p>
        /// </summary>
        [JsonProperty("NDRDetail")]
        public OverviewNDRDetail NDRDetail{ get; set; }

        /// <summary>
        /// <p>账号下资源、实例、规则和扩容配额详情数据。</p>
        /// </summary>
        [JsonProperty("QuotaDetail")]
        public OverviewQuotaDetail QuotaDetail{ get; set; }

        /// <summary>
        /// <p>日志存储使用量、保留天数和各类日志容量详情数据。</p>
        /// </summary>
        [JsonProperty("LogStorageDetail")]
        public OverviewLogStorageDetail LogStorageDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "NorthSouthDetail.", this.NorthSouthDetail);
            this.SetParamObj(map, prefix + "EastWestDetail.", this.EastWestDetail);
            this.SetParamObj(map, prefix + "NDRDetail.", this.NDRDetail);
            this.SetParamObj(map, prefix + "QuotaDetail.", this.QuotaDetail);
            this.SetParamObj(map, prefix + "LogStorageDetail.", this.LogStorageDetail);
        }
    }
}

