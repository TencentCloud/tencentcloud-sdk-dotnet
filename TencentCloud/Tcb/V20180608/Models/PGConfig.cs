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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PGConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>规格</p>
        /// </summary>
        [JsonProperty("PGSpec")]
        public string PGSpec{ get; set; }

        /// <summary>
        /// <p>磁盘大小</p><p>单位：GB</p>
        /// </summary>
        [JsonProperty("PGStorage")]
        public long? PGStorage{ get; set; }

        /// <summary>
        /// <p>实例类型（独享/共享）</p><p>参数格式：SHARED：共享，DEDICATED：独享； 仅满足要求的套餐支持独享；仅有独享pg支持指定pg参数（如规格、磁盘）</p>
        /// </summary>
        [JsonProperty("TenantType")]
        public string TenantType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PGSpec", this.PGSpec);
            this.SetParamSimple(map, prefix + "PGStorage", this.PGStorage);
            this.SetParamSimple(map, prefix + "TenantType", this.TenantType);
        }
    }
}

