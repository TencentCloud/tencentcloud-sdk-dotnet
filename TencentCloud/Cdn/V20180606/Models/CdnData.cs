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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdnData : AbstractModel
    {
        
        /// <summary>
        /// 查询指定的指标名称：
        /// flux：流量，单位为 byte
        /// bandwidth：带宽，单位为 bps
        /// request：请求数，单位为 次
        /// fluxHitRate：流量命中率，单位为 %
        /// statusCode：状态码，返回 2XX、3XX、4XX、5XX 汇总数据，单位为 个
        /// 2XX：返回 2XX 状态码汇总及各 2 开头状态码数据，单位为 个
        /// 3XX：返回 3XX 状态码汇总及各 3 开头状态码数据，单位为 个
        /// 4XX：返回 4XX 状态码汇总及各 4 开头状态码数据，单位为 个
        /// 5XX：返回 5XX 状态码汇总及各 5 开头状态码数据，单位为 个
        /// 或指定查询的某一具体状态码
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 明细数据组合
        /// </summary>
        [JsonProperty("DetailData")]
        public TimestampData[] DetailData{ get; set; }

        /// <summary>
        /// 汇总数据组合
        /// </summary>
        [JsonProperty("SummarizedData")]
        public SummarizedData SummarizedData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArrayObj(map, prefix + "DetailData.", this.DetailData);
            this.SetParamObj(map, prefix + "SummarizedData.", this.SummarizedData);
        }
    }
}

