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

    public class CreateSkillScanResponse : AbstractModel
    {
        
        /// <summary>
        /// 文件的 SHA256 Hash，用于轮询 DescribeSkillScanResult 接口
        /// 参数格式：sha256:<64位hex>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// 本次请求实际绑定的引擎版本号。调用方应保存并在后续 DescribeSkillScanResult 时显式传入
        /// </summary>
        [JsonProperty("EngineVersion")]
        public long? EngineVersion{ get; set; }

        /// <summary>
        /// 任务状态，固定为 SCANNING，表示任务已接收
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 可读的操作结果描述
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

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
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

