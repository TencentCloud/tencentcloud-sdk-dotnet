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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InterconnectPair : AbstractModel
    {
        
        /// <summary>
        /// 集合A
        /// </summary>
        [JsonProperty("GroupA")]
        public AccessInstanceInfo[] GroupA{ get; set; }

        /// <summary>
        /// 集合B
        /// </summary>
        [JsonProperty("GroupB")]
        public AccessInstanceInfo[] GroupB{ get; set; }

        /// <summary>
        /// 互联模式："CrossConnect": 交叉互联（组A内每个实例和组B内每个实例互联），"FullMesh": 全互联（组A实际和组B内容一致，相当于组内两两互联）
        /// </summary>
        [JsonProperty("InterconnectMode")]
        public string InterconnectMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "GroupA.", this.GroupA);
            this.SetParamArrayObj(map, prefix + "GroupB.", this.GroupB);
            this.SetParamSimple(map, prefix + "InterconnectMode", this.InterconnectMode);
        }
    }
}

