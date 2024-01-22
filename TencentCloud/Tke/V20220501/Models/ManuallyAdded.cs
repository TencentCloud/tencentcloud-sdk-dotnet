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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManuallyAdded : AbstractModel
    {
        
        /// <summary>
        /// 加入中的节点数量
        /// </summary>
        [JsonProperty("Joining")]
        public long? Joining{ get; set; }

        /// <summary>
        /// 初始化中的节点数量
        /// </summary>
        [JsonProperty("Initializing")]
        public long? Initializing{ get; set; }

        /// <summary>
        /// 正常的节点数量
        /// </summary>
        [JsonProperty("Normal")]
        public long? Normal{ get; set; }

        /// <summary>
        /// 节点总数
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Joining", this.Joining);
            this.SetParamSimple(map, prefix + "Initializing", this.Initializing);
            this.SetParamSimple(map, prefix + "Normal", this.Normal);
            this.SetParamSimple(map, prefix + "Total", this.Total);
        }
    }
}

