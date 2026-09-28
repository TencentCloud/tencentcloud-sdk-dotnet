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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeadLockLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>服务产品类型。取值：sqlserver（云数据库 Sqlserver）。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>实例 ID。SQLServer: mssql-xxxx。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>查询开始时间，格式 yyyy-MM-dd HH:mm:ss，按 UTC+8 解析；也兼容带偏移的 ISO-8601（如 2026-09-16T00:00:00+08:00）。半开区间左闭。</p><p>参数格式：2026-09-16 00:00:00</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询结束时间，格式同 StartTime。EndTime 必须大于 StartTime，且总查询窗口不超过 24 小时。半开区间右开。</p><p>参数格式：2026-09-16 23:59:59</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>分页偏移量，非负整数，默认 0。当 Offset&gt;0 时必须同时传入 ResultVersion，否则报 INVALID_PARAMETER。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>单页返回死锁事件数量，范围 [1, 100]。默认 20。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>是否在响应中包含原始死锁图 XML（XmlReport）。默认 false，避免响应体过大。仅在需要绘制完整死锁环时置 true。</p>
        /// </summary>
        [JsonProperty("IncludeXml")]
        public bool? IncludeXml{ get; set; }

        /// <summary>
        /// <p>结果集版本号，最大 128 字符。首次查询无需传入；翻页时必须透传首次响应中的 ResultVersion，服务端会校验结果集是否发生变化，变化时返回 RESULT_CHANGED 提示重新拉取首页。</p>
        /// </summary>
        [JsonProperty("ResultVersion")]
        public string ResultVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "IncludeXml", this.IncludeXml);
            this.SetParamSimple(map, prefix + "ResultVersion", this.ResultVersion);
        }
    }
}

