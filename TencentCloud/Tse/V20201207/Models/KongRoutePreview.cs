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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KongRoutePreview : AbstractModel
    {
        
        /// <summary>
        /// 服务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 服务名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Methods")]
        public string[] Methods{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Paths")]
        public string[] Paths{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocols")]
        public string[] Protocols{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreserveHost")]
        public bool? PreserveHost{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpsRedirectStatusCode")]
        public long? HttpsRedirectStatusCode{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StripPath")]
        public bool? StripPath{ get; set; }

        /// <summary>
        /// 无
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 是否开启了强制HTTPS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForceHttps")]
        [System.Obsolete]
        public bool? ForceHttps{ get; set; }

        /// <summary>
        /// 服务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 服务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// 目的端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DestinationPorts")]
        public ulong?[] DestinationPorts{ get; set; }

        /// <summary>
        /// 路由的Headers
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Headers")]
        public KVMapping[] Headers{ get; set; }

        /// <summary>
        /// 是否缓存请求body，默认true
        /// </summary>
        [JsonProperty("RequestBuffering")]
        public bool? RequestBuffering{ get; set; }

        /// <summary>
        /// 是否缓存响应body，默认true
        /// </summary>
        [JsonProperty("ResponseBuffering")]
        public bool? ResponseBuffering{ get; set; }

        /// <summary>
        /// 正则优先级
        /// </summary>
        [JsonProperty("RegexPriority")]
        public long? RegexPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Methods.", this.Methods);
            this.SetParamArraySimple(map, prefix + "Paths.", this.Paths);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamArraySimple(map, prefix + "Protocols.", this.Protocols);
            this.SetParamSimple(map, prefix + "PreserveHost", this.PreserveHost);
            this.SetParamSimple(map, prefix + "HttpsRedirectStatusCode", this.HttpsRedirectStatusCode);
            this.SetParamSimple(map, prefix + "StripPath", this.StripPath);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ForceHttps", this.ForceHttps);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamArraySimple(map, prefix + "DestinationPorts.", this.DestinationPorts);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "RequestBuffering", this.RequestBuffering);
            this.SetParamSimple(map, prefix + "ResponseBuffering", this.ResponseBuffering);
            this.SetParamSimple(map, prefix + "RegexPriority", this.RegexPriority);
        }
    }
}

