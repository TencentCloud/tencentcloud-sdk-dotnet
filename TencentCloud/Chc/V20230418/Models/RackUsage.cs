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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RackUsage : AbstractModel
    {
        
        /// <summary>
        /// 机架ID
        /// </summary>
        [JsonProperty("RackId")]
        public ulong? RackId{ get; set; }

        /// <summary>
        /// 已使用的机位数量
        /// </summary>
        [JsonProperty("UsedNum")]
        public ulong? UsedNum{ get; set; }

        /// <summary>
        /// 空闲机位数量
        /// </summary>
        [JsonProperty("UnusedNum")]
        public ulong? UnusedNum{ get; set; }

        /// <summary>
        /// 机架简称
        /// </summary>
        [JsonProperty("RackShortName")]
        public string RackShortName{ get; set; }

        /// <summary>
        /// 机位总数
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 机位使用率
        /// </summary>
        [JsonProperty("UsedRate")]
        public float? UsedRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RackId", this.RackId);
            this.SetParamSimple(map, prefix + "UsedNum", this.UsedNum);
            this.SetParamSimple(map, prefix + "UnusedNum", this.UnusedNum);
            this.SetParamSimple(map, prefix + "RackShortName", this.RackShortName);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "UsedRate", this.UsedRate);
        }
    }
}

