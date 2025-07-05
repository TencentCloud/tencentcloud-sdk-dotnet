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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReservedPreDomainInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名,每次最多支持500条域名查询
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// 状态，用于筛选，可不填写(1. 成功 2. 失败（失败Reason字段将会被赋值）3. 域名交割中 4. 域名交割完成 5. 预约 6. 竞价)
        /// </summary>
        [JsonProperty("ReservedStatus")]
        public long? ReservedStatus{ get; set; }

        /// <summary>
        /// 根据预约时间排序，仅支持："desc","asc"。
        /// </summary>
        [JsonProperty("ReservedTimeSort")]
        public string ReservedTimeSort{ get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
            this.SetParamSimple(map, prefix + "ReservedStatus", this.ReservedStatus);
            this.SetParamSimple(map, prefix + "ReservedTimeSort", this.ReservedTimeSort);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

