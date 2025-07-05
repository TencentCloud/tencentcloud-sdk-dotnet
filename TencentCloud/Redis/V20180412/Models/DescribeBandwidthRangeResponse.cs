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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBandwidthRangeResponse : AbstractModel
    {
        
        /// <summary>
        /// 标准带宽。指购买实例时，系统为每个节点分配的带宽。
        /// </summary>
        [JsonProperty("BaseBandwidth")]
        public long? BaseBandwidth{ get; set; }

        /// <summary>
        /// 指实例的附加带宽。标准带宽不满足需求的情况下，用户可自行增加的带宽。<ul><li>开启副本只读时，实例总带宽 = 附加带宽 * 分片数 + 标准带宽 * 分片数 * Max ([只读副本数量, 1])，标准架构的分片数 = 1。</li><li>没有开启副本只读时，实例总带宽 = 附加带宽 * 分片数 + 标准带宽 * 分片数，标准架构的分片数 = 1。</li></ul>
        /// </summary>
        [JsonProperty("AddBandwidth")]
        public long? AddBandwidth{ get; set; }

        /// <summary>
        /// 附加带宽设置下限。
        /// </summary>
        [JsonProperty("MinAddBandwidth")]
        public long? MinAddBandwidth{ get; set; }

        /// <summary>
        /// 附加带宽设置上限。
        /// </summary>
        [JsonProperty("MaxAddBandwidth")]
        public long? MaxAddBandwidth{ get; set; }

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
            this.SetParamSimple(map, prefix + "BaseBandwidth", this.BaseBandwidth);
            this.SetParamSimple(map, prefix + "AddBandwidth", this.AddBandwidth);
            this.SetParamSimple(map, prefix + "MinAddBandwidth", this.MinAddBandwidth);
            this.SetParamSimple(map, prefix + "MaxAddBandwidth", this.MaxAddBandwidth);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

