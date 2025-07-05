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

    public class AlgDetectJS : AbstractModel
    {
        
        /// <summary>
        /// 操作名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 工作量证明 (proof_Of-Work)校验强度，默认low，取值有：
        /// <li>low：低；</li>
        /// <li>middle：中；</li>
        /// <li>high：高。</li>
        /// </summary>
        [JsonProperty("WorkLevel")]
        public string WorkLevel{ get; set; }

        /// <summary>
        /// 执行方式，js延迟执行的时间。单位为ms，默认500，取值：0～1000。
        /// </summary>
        [JsonProperty("ExecuteMode")]
        public long? ExecuteMode{ get; set; }

        /// <summary>
        /// 客户端末启用JS（末完成检测）统计周期。单位为秒，默认10，取值：5～3600。
        /// </summary>
        [JsonProperty("InvalidStatTime")]
        public long? InvalidStatTime{ get; set; }

        /// <summary>
        /// 客户端末启用JS（末完成检测）触发阈值。单位为次，默认300，取值：1～100000000。
        /// </summary>
        [JsonProperty("InvalidThreshold")]
        public long? InvalidThreshold{ get; set; }

        /// <summary>
        /// Bot主动特征识别客户端行为校验结果。
        /// </summary>
        [JsonProperty("AlgDetectResults")]
        public AlgDetectResult[] AlgDetectResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "WorkLevel", this.WorkLevel);
            this.SetParamSimple(map, prefix + "ExecuteMode", this.ExecuteMode);
            this.SetParamSimple(map, prefix + "InvalidStatTime", this.InvalidStatTime);
            this.SetParamSimple(map, prefix + "InvalidThreshold", this.InvalidThreshold);
            this.SetParamArrayObj(map, prefix + "AlgDetectResults.", this.AlgDetectResults);
        }
    }
}

