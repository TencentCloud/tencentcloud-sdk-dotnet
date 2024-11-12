/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetLoadInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 系统负载
        /// </summary>
        [JsonProperty("CpuLoad")]
        public AssetLoadSummary CpuLoad{ get; set; }

        /// <summary>
        /// 内存使用率
        /// </summary>
        [JsonProperty("MemLoad")]
        public AssetLoadSummary MemLoad{ get; set; }

        /// <summary>
        /// 硬盘使用率
        /// </summary>
        [JsonProperty("DiskLoad")]
        public AssetLoadSummary DiskLoad{ get; set; }

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
            this.SetParamObj(map, prefix + "CpuLoad.", this.CpuLoad);
            this.SetParamObj(map, prefix + "MemLoad.", this.MemLoad);
            this.SetParamObj(map, prefix + "DiskLoad.", this.DiskLoad);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

