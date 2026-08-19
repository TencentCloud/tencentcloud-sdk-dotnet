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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExposureTrendResponse : AbstractModel
    {
        
        /// <summary>
        /// 暴露周期趋势数量统计信息
        /// </summary>
        [JsonProperty("ExposeTrendList")]
        public ExposeTrendItem[] ExposeTrendList{ get; set; }

        /// <summary>
        /// 暴露周期新增数量统计
        /// </summary>
        [JsonProperty("ExposeIncrement")]
        public ulong? ExposeIncrement{ get; set; }

        /// <summary>
        /// 近1天（24h）完全开放数量
        /// </summary>
        [JsonProperty("OpenCount")]
        public ulong? OpenCount{ get; set; }

        /// <summary>
        /// 近1天（24h）受限访问数量
        /// </summary>
        [JsonProperty("AclCount")]
        public ulong? AclCount{ get; set; }

        /// <summary>
        /// 近1天（24h）无法访问数量
        /// </summary>
        [JsonProperty("CloseCount")]
        public ulong? CloseCount{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ExposeTrendList.", this.ExposeTrendList);
            this.SetParamSimple(map, prefix + "ExposeIncrement", this.ExposeIncrement);
            this.SetParamSimple(map, prefix + "OpenCount", this.OpenCount);
            this.SetParamSimple(map, prefix + "AclCount", this.AclCount);
            this.SetParamSimple(map, prefix + "CloseCount", this.CloseCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

