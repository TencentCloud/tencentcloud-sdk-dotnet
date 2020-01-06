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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWorkersResponse : AbstractModel
    {
        
        /// <summary>
        /// 空闲机器总数量
        /// </summary>
        [JsonProperty("Idle")]
        public ulong? Idle{ get; set; }

        /// <summary>
        /// 区域个数
        /// </summary>
        [JsonProperty("RegionNum")]
        public ulong? RegionNum{ get; set; }

        /// <summary>
        /// 各个区域的机器情况
        /// </summary>
        [JsonProperty("RegionDetail")]
        public WorkerRegionInfo[] RegionDetail{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Idle", this.Idle);
            this.SetParamSimple(map, prefix + "RegionNum", this.RegionNum);
            this.SetParamArrayObj(map, prefix + "RegionDetail.", this.RegionDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

