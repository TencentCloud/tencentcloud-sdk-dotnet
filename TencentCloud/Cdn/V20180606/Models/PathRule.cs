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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PathRule : AbstractModel
    {
        
        /// <summary>
        /// 是否是正则匹配。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regex")]
        public bool? Regex{ get; set; }

        /// <summary>
        /// URL路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 路径匹配时的回源源站。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 路径匹配时的回源Host头部。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 源站所属区域，支持CN，OV。分别表示国内或海外。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginArea")]
        public string OriginArea{ get; set; }

        /// <summary>
        /// 路径匹配时的回源URI路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForwardUri")]
        public string ForwardUri{ get; set; }

        /// <summary>
        /// 路径匹配时的回源头部设置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestHeaders")]
        public HttpHeaderRule[] RequestHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "OriginArea", this.OriginArea);
            this.SetParamSimple(map, prefix + "ForwardUri", this.ForwardUri);
            this.SetParamArrayObj(map, prefix + "RequestHeaders.", this.RequestHeaders);
        }
    }
}

