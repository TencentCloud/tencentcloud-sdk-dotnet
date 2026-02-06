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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTimingL4DataResponse : AbstractModel
    {
        
        /// <summary>
        /// 查询结果的总条数。
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// <p>四层时序流量数据列表。<br>对于不同的查询指标，根据指标值类型的不同，会从不同的参数返回时序数据。<br>目前存在的值类型有以下两种：</p><ul><li><strong>Integer</strong>：<code>Integer</code> 值类型的指标将从 <code>Data.N.TypeValue</code> 返回对应时序数据。<br>对应的查询指标 <code>MetricName</code> 有：<ul><li><code>l4Flow_flux</code>：访问总流量；</li><li><code>l4Flow_inFlux</code>：访问入流量；</li><li><code>l4Flow_outFlux</code>：访问出流量；</li><li><code>l4Flow_inBandwidth</code>：访问入向带宽峰值；</li><li><code>l4Flow_outBandwidth</code>：访问出向带宽峰值；</li><li><code>l4Flow_connections</code>：访问并发连接数。</li></ul></li><li><strong>Float</strong>：<code>Float</code> 值类型的指标将从 <code>Data.N.FloatTypeValue</code> 返回对应时序数据。<br>对应的查询指标 <code>MetricName</code> 有：<ul><li><code>l4Flow_newConnectionsRate</code>：新建连接数速率。</li></ul></li>
        /// </ul><p>本接口暂不支持指定维度查询，默认按主账号汇总返回数据，即 <code>Data.N.TypeKey = AppId</code>，AppId 是腾讯云主账号唯一标识，N 恒等于 1。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Data")]
        public TimingDataRecord[] Data{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

