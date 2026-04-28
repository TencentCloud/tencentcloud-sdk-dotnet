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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerlessSpace : AbstractModel
    {
        
        /// <summary>
        /// <p>Serverless索引空间ID</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>Serverless索引空间名</p>
        /// </summary>
        [JsonProperty("SpaceName")]
        public string SpaceName{ get; set; }

        /// <summary>
        /// <p>Serverless索引空间状态</p><p>枚举值：</p><ul><li>0： 创建中</li><li>1： 正常</li><li>2： 流程中</li><li>-3： 已删除</li><li>-4： 隔离中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>创建日期</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>空间内索引数量</p>
        /// </summary>
        [JsonProperty("IndexCount")]
        public long? IndexCount{ get; set; }

        /// <summary>
        /// <p>kibana公网uri</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaUrl")]
        public string KibanaUrl{ get; set; }

        /// <summary>
        /// <p>kibana内网url</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaPrivateUrl")]
        public string KibanaPrivateUrl{ get; set; }

        /// <summary>
        /// <p>空间内网访问地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexAccessUrl")]
        public string IndexAccessUrl{ get; set; }

        /// <summary>
        /// <p>空间白名单</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaPublicAcl")]
        public EsAcl KibanaPublicAcl{ get; set; }

        /// <summary>
        /// <p>空间检索分析域名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaEmbedUrl")]
        public string KibanaEmbedUrl{ get; set; }

        /// <summary>
        /// <p>数据联路</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiDataList")]
        public DiData DiDataList{ get; set; }

        /// <summary>
        /// <p>空间vpc信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcInfo")]
        public VpcInfo[] VpcInfo{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>可用区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>kibana公网开关，0关闭，1开启</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableKibanaPublicAccess")]
        public long? EnableKibanaPublicAccess{ get; set; }

        /// <summary>
        /// <p>kibana内网开关，0关闭，1开启</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableKibanaPrivateAccess")]
        public long? EnableKibanaPrivateAccess{ get; set; }

        /// <summary>
        /// <p>空间所属appid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>//默认en， 可选zh-CN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaLanguage")]
        public string KibanaLanguage{ get; set; }

        /// <summary>
        /// <p>0</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// <p>空间标签信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// <p>是否开启mcp服务</p>
        /// </summary>
        [JsonProperty("EnableMcpAccess")]
        public long? EnableMcpAccess{ get; set; }

        /// <summary>
        /// <p>mcp的访问地址</p>
        /// </summary>
        [JsonProperty("McpAccess")]
        public string McpAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "SpaceName", this.SpaceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IndexCount", this.IndexCount);
            this.SetParamSimple(map, prefix + "KibanaUrl", this.KibanaUrl);
            this.SetParamSimple(map, prefix + "KibanaPrivateUrl", this.KibanaPrivateUrl);
            this.SetParamSimple(map, prefix + "IndexAccessUrl", this.IndexAccessUrl);
            this.SetParamObj(map, prefix + "KibanaPublicAcl.", this.KibanaPublicAcl);
            this.SetParamSimple(map, prefix + "KibanaEmbedUrl", this.KibanaEmbedUrl);
            this.SetParamObj(map, prefix + "DiDataList.", this.DiDataList);
            this.SetParamArrayObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "EnableKibanaPublicAccess", this.EnableKibanaPublicAccess);
            this.SetParamSimple(map, prefix + "EnableKibanaPrivateAccess", this.EnableKibanaPrivateAccess);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "KibanaLanguage", this.KibanaLanguage);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "EnableMcpAccess", this.EnableMcpAccess);
            this.SetParamSimple(map, prefix + "McpAccess", this.McpAccess);
        }
    }
}

