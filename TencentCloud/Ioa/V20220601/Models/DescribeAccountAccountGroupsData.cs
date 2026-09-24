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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccountAccountGroupsData : AbstractModel
    {
        
        /// <summary>
        /// <p>组Id(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public long? AccountGroupId{ get; set; }

        /// <summary>
        /// <p>组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountGroupName")]
        public string AccountGroupName{ get; set; }

        /// <summary>
        /// <p>主组标识(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterFlag")]
        public long? MasterFlag{ get; set; }

        /// <summary>
        /// <p>组路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountGroupNamePaths")]
        public string[] AccountGroupNamePaths{ get; set; }

        /// <summary>
        /// <p>组路径Id(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountGroupPathIds")]
        public long?[] AccountGroupPathIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "AccountGroupName", this.AccountGroupName);
            this.SetParamSimple(map, prefix + "MasterFlag", this.MasterFlag);
            this.SetParamArraySimple(map, prefix + "AccountGroupNamePaths.", this.AccountGroupNamePaths);
            this.SetParamArraySimple(map, prefix + "AccountGroupPathIds.", this.AccountGroupPathIds);
        }
    }
}

