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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInvocationDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>云桌面实例ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>任务ID。</p>
        /// </summary>
        [JsonProperty("InvokeId")]
        public string InvokeId{ get; set; }

        /// <summary>
        /// <p>需要返回的任务输出行号起始索引。</p>
        /// </summary>
        [JsonProperty("OutputLinesOffset")]
        public ulong? OutputLinesOffset{ get; set; }

        /// <summary>
        /// <p>需要返回的任务输出行数。</p>
        /// </summary>
        [JsonProperty("OutputLinesLimit")]
        public ulong? OutputLinesLimit{ get; set; }

        /// <summary>
        /// <p>任务的输出内容是否合并成一个字符串。默认为true。</p>
        /// </summary>
        [JsonProperty("MergeOutputLines")]
        public bool? MergeOutputLines{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InvokeId", this.InvokeId);
            this.SetParamSimple(map, prefix + "OutputLinesOffset", this.OutputLinesOffset);
            this.SetParamSimple(map, prefix + "OutputLinesLimit", this.OutputLinesLimit);
            this.SetParamSimple(map, prefix + "MergeOutputLines", this.MergeOutputLines);
        }
    }
}

