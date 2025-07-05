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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleUpRule : AbstractModel
    {
        
        /// <summary>
        /// 自动扩容策略开启，关闭
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 集群用量占比，到达这个值后开始扩容,范围[10-90]
        /// </summary>
        [JsonProperty("ScaleThreshold")]
        public ulong? ScaleThreshold{ get; set; }

        /// <summary>
        /// 扩容后使用量跟集群总量比例,范围[10-90]
        /// </summary>
        [JsonProperty("TargetThreshold")]
        public ulong? TargetThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ScaleThreshold", this.ScaleThreshold);
            this.SetParamSimple(map, prefix + "TargetThreshold", this.TargetThreshold);
        }
    }
}

