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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerlessIndexMetaField : AbstractModel
    {
        
        /// <summary>
        /// 索引所属集群APP ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 索引名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// 索引文档数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexDocs")]
        public long? IndexDocs{ get; set; }

        /// <summary>
        /// 索引存储大小，单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexStorage")]
        public long? IndexStorage{ get; set; }

        /// <summary>
        /// 索引创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexCreateTime")]
        public string IndexCreateTime{ get; set; }

        /// <summary>
        /// 索引实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 索引自治字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexOptionsField")]
        public ServerlessIndexOptionsField IndexOptionsField{ get; set; }

        /// <summary>
        /// 索引配置字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexSettingsField")]
        public ServerlessIndexSettingsField IndexSettingsField{ get; set; }

        /// <summary>
        /// 索引所属连接相关信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexNetworkField")]
        public ServerlessIndexNetworkField IndexNetworkField{ get; set; }

        /// <summary>
        /// Kibana公网域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaUrl")]
        public string KibanaUrl{ get; set; }

        /// <summary>
        /// Kibana内网域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KibanaPrivateUrl")]
        public string KibanaPrivateUrl{ get; set; }

        /// <summary>
        /// 索引内网访问地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexAccessUrl")]
        public string IndexAccessUrl{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 索引空间ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 索引空间名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpaceName")]
        public string SpaceName{ get; set; }

        /// <summary>
        /// 存储类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// 3782478.47
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexTraffic")]
        public float? IndexTraffic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "IndexDocs", this.IndexDocs);
            this.SetParamSimple(map, prefix + "IndexStorage", this.IndexStorage);
            this.SetParamSimple(map, prefix + "IndexCreateTime", this.IndexCreateTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "IndexOptionsField.", this.IndexOptionsField);
            this.SetParamObj(map, prefix + "IndexSettingsField.", this.IndexSettingsField);
            this.SetParamObj(map, prefix + "IndexNetworkField.", this.IndexNetworkField);
            this.SetParamSimple(map, prefix + "KibanaUrl", this.KibanaUrl);
            this.SetParamSimple(map, prefix + "KibanaPrivateUrl", this.KibanaPrivateUrl);
            this.SetParamSimple(map, prefix + "IndexAccessUrl", this.IndexAccessUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "SpaceName", this.SpaceName);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "IndexTraffic", this.IndexTraffic);
        }
    }
}

