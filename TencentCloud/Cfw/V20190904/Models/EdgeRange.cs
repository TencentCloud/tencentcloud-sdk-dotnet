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

    public class EdgeRange : AbstractModel
    {
        
        /// <summary>
        /// 规则生效的范围id，是在哪对vpc之间还是针对所有vpc间生效
        /// </summary>
        [JsonProperty("EdgeId")]
        public string EdgeId{ get; set; }

        /// <summary>
        /// EdgeId对应的名称
        /// </summary>
        [JsonProperty("EdgeName")]
        public string EdgeName{ get; set; }

        /// <summary>
        /// 本端网络实例Id
        /// </summary>
        [JsonProperty("SrcId")]
        public string SrcId{ get; set; }

        /// <summary>
        /// 本端网络实例所属地域
        /// </summary>
        [JsonProperty("SrcRegion")]
        public string SrcRegion{ get; set; }

        /// <summary>
        /// 本端网络实例名称
        /// </summary>
        [JsonProperty("SrcName")]
        public string SrcName{ get; set; }

        /// <summary>
        /// 本端网络实例cidr，多个以逗号分隔
        /// </summary>
        [JsonProperty("SrcCidr")]
        public string SrcCidr{ get; set; }

        /// <summary>
        /// 对端网络实例Id
        /// </summary>
        [JsonProperty("DstId")]
        public string DstId{ get; set; }

        /// <summary>
        /// 对端网络实例所属地域
        /// </summary>
        [JsonProperty("DstRegion")]
        public string DstRegion{ get; set; }

        /// <summary>
        /// 对端网络实例名称
        /// </summary>
        [JsonProperty("DstName")]
        public string DstName{ get; set; }

        /// <summary>
        /// 对端网络实例cidr，多个以逗号分隔
        /// </summary>
        [JsonProperty("DstCidr")]
        public string DstCidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EdgeId", this.EdgeId);
            this.SetParamSimple(map, prefix + "EdgeName", this.EdgeName);
            this.SetParamSimple(map, prefix + "SrcId", this.SrcId);
            this.SetParamSimple(map, prefix + "SrcRegion", this.SrcRegion);
            this.SetParamSimple(map, prefix + "SrcName", this.SrcName);
            this.SetParamSimple(map, prefix + "SrcCidr", this.SrcCidr);
            this.SetParamSimple(map, prefix + "DstId", this.DstId);
            this.SetParamSimple(map, prefix + "DstRegion", this.DstRegion);
            this.SetParamSimple(map, prefix + "DstName", this.DstName);
            this.SetParamSimple(map, prefix + "DstCidr", this.DstCidr);
        }
    }
}

