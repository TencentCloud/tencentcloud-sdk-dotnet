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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Resource : AbstractModel
    {
        
        /// <summary>
        /// 资源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// tke资源层信息
        /// </summary>
        [JsonProperty("TKEMeta")]
        public TkeMeta[] TKEMeta{ get; set; }

        /// <summary>
        /// cvm资源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CVMMeta")]
        public CVMMeta[] CVMMeta{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamArrayObj(map, prefix + "TKEMeta.", this.TKEMeta);
            this.SetParamArrayObj(map, prefix + "CVMMeta.", this.CVMMeta);
        }
    }
}

