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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PositionStatusItem : AbstractModel
    {
        
        /// <summary>
        /// 状态值
        /// </summary>
        [JsonProperty("PositionStatus")]
        public ulong? PositionStatus{ get; set; }

        /// <summary>
        /// 对应的机位数量
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PositionStatus", this.PositionStatus);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

