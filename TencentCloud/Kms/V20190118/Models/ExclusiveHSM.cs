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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExclusiveHSM : AbstractModel
    {
        
        /// <summary>
        /// <p>独享集群Id</p>
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// <p>独享集群名称</p>
        /// </summary>
        [JsonProperty("HsmClusterName")]
        public string HsmClusterName{ get; set; }

        /// <summary>
        /// <p>根密钥的使用量</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("CmkUserCount")]
        public ulong? CmkUserCount{ get; set; }

        /// <summary>
        /// <p>根密钥的额度</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("CmkLimit")]
        public ulong? CmkLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamSimple(map, prefix + "HsmClusterName", this.HsmClusterName);
            this.SetParamSimple(map, prefix + "CmkUserCount", this.CmkUserCount);
            this.SetParamSimple(map, prefix + "CmkLimit", this.CmkLimit);
        }
    }
}

