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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceTypeConfigDTO : AbstractModel
    {
        
        /// <summary>
        /// json xml urlencoded amf0 amf3 hessian1 hessian2
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReqSourceType")]
        public string ReqSourceType{ get; set; }

        /// <summary>
        /// json xml urlencoded amf0 amf3 hessian1 hessian2
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReqTargetType")]
        public string ReqTargetType{ get; set; }

        /// <summary>
        /// json xml urlencoded amf0 amf3 hessian1 hessian2
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResSourceType")]
        public string ResSourceType{ get; set; }

        /// <summary>
        /// json xml urlencoded amf0 amf3 hessian1 hessian2
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResTargetType")]
        public string ResTargetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReqSourceType", this.ReqSourceType);
            this.SetParamSimple(map, prefix + "ReqTargetType", this.ReqTargetType);
            this.SetParamSimple(map, prefix + "ResSourceType", this.ResSourceType);
            this.SetParamSimple(map, prefix + "ResTargetType", this.ResTargetType);
        }
    }
}

