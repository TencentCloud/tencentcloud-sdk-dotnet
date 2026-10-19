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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Capabilities : AbstractModel
    {
        
        /// <summary>
        /// <p>要添加的capabilities</p><p>取值参考：[&quot;SYS_ADMIN&quot;]</p>
        /// </summary>
        [JsonProperty("Add")]
        public string[] Add{ get; set; }

        /// <summary>
        /// <p>要移除的capabilities</p><p>取值参考：[&quot;ALL&quot;]</p>
        /// </summary>
        [JsonProperty("Drop")]
        public string[] Drop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Add.", this.Add);
            this.SetParamArraySimple(map, prefix + "Drop.", this.Drop);
        }
    }
}

