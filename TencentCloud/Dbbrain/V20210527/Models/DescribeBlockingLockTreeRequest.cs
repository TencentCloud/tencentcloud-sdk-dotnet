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

    public class DescribeBlockingLockTreeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>服务产品类型，固定为sqlserver。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>lock monitor 扫描轮次 ID（可从 DescribeBlockingTimeRange 返回的 MonitorLoops 列表选择，也可从 DescribeBlockingLogs / DescribeBlockingTrees 返回的 MonitorLoop 字段获取）。与 BlockingTime 二选一，MonitorLoop 优先。</p>
        /// </summary>
        [JsonProperty("MonitorLoop")]
        public string MonitorLoop{ get; set; }

        /// <summary>
        /// <p>阻塞时间点，格式：yyyy-MM-dd HH:mm:ss。当 MonitorLoop 为空时使用该字段定位：后端会在该时间点±1分钟范围内寻找最接近的 MonitorLoop 并下钻其阻塞树。与 MonitorLoop 二选一。BlockingTime 必须在最近 30 天内，否则返回 InvalidParameterValue。</p>
        /// </summary>
        [JsonProperty("BlockingTime")]
        public string BlockingTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "MonitorLoop", this.MonitorLoop);
            this.SetParamSimple(map, prefix + "BlockingTime", this.BlockingTime);
        }
    }
}

