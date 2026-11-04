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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectedResourceOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>受保护资源总数</p>
        /// </summary>
        [JsonProperty("TotalProtectedCount")]
        public long? TotalProtectedCount{ get; set; }

        /// <summary>
        /// <p>总资源数</p>
        /// </summary>
        [JsonProperty("TotalResourceCount")]
        public long? TotalResourceCount{ get; set; }

        /// <summary>
        /// <p>CVM整机备份受保护统计</p>
        /// </summary>
        [JsonProperty("Cvm")]
        public ResourceProtectStat Cvm{ get; set; }

        /// <summary>
        /// <p>CVM文件备份受保护统计</p>
        /// </summary>
        [JsonProperty("CFS")]
        public ResourceProtectStat CFS{ get; set; }

        /// <summary>
        /// <p>CFS文件备份受保护统计</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSAgent")]
        public ResourceProtectStat CFSAgent{ get; set; }

        /// <summary>
        /// <p>COS备份受保护统计</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("COSAgent")]
        public ResourceProtectStat COSAgent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalProtectedCount", this.TotalProtectedCount);
            this.SetParamSimple(map, prefix + "TotalResourceCount", this.TotalResourceCount);
            this.SetParamObj(map, prefix + "Cvm.", this.Cvm);
            this.SetParamObj(map, prefix + "CFS.", this.CFS);
            this.SetParamObj(map, prefix + "CFSAgent.", this.CFSAgent);
            this.SetParamObj(map, prefix + "COSAgent.", this.COSAgent);
        }
    }
}

