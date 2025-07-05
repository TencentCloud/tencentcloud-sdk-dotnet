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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PathRule : AbstractModel
    {
        
        /// <summary>
        /// 是否开启通配符“*”匹配：
        /// false：关闭
        /// true：开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regex")]
        public bool? Regex{ get; set; }

        /// <summary>
        /// 匹配的URL路径，仅支持Url路径，不支持参数。默认完全匹配，开启通配符“*”匹配后，最多支持5个通配符，最大长度为1024个字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 路径匹配时的回源源站。暂不支持开了私有读写的COS源。不填写时沿用默认源站。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 路径匹配时回源的Host头部。不填写时沿用默认ServerName。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 源站所属区域，支持CN，OV：
        /// CN：中国境内
        /// OV：中国境外
        /// 默认为CN。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginArea")]
        public string OriginArea{ get; set; }

        /// <summary>
        /// 路径匹配时回源的URI路径，必须以“/”开头，不包含参数部分。最大长度为1024个字符。可使用$1, $2, $3, $4, $5分别捕获匹配路径中的通配符号“*”，最多支持10个捕获值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForwardUri")]
        public string ForwardUri{ get; set; }

        /// <summary>
        /// 路径匹配时回源的头部设置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestHeaders")]
        public HttpHeaderRule[] RequestHeaders{ get; set; }

        /// <summary>
        /// 当Regex为false时，Path是否开启完全匹配。
        /// false：关闭
        /// true：开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullMatch")]
        public bool? FullMatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "OriginArea", this.OriginArea);
            this.SetParamSimple(map, prefix + "ForwardUri", this.ForwardUri);
            this.SetParamArrayObj(map, prefix + "RequestHeaders.", this.RequestHeaders);
            this.SetParamSimple(map, prefix + "FullMatch", this.FullMatch);
        }
    }
}

