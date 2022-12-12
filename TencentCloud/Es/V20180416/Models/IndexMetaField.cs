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

    public class IndexMetaField : AbstractModel
    {
        
        /// <summary>
        /// 索引类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// 索引名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// 索引状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexStatus")]
        public string IndexStatus{ get; set; }

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
        /// 后备索引
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackingIndices")]
        public BackingIndexMetaField[] BackingIndices{ get; set; }

        /// <summary>
        /// 索引所属集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 索引所属集群名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 索引所属集群版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 索引生命周期字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexPolicyField")]
        public IndexPolicyField IndexPolicyField{ get; set; }

        /// <summary>
        /// 索引自治字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexOptionsField")]
        public IndexOptionsField IndexOptionsField{ get; set; }

        /// <summary>
        /// 索引配置字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexSettingsField")]
        public IndexSettingsField IndexSettingsField{ get; set; }

        /// <summary>
        /// 索引所属集群APP ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 索引文档数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexDocs")]
        public ulong? IndexDocs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IndexType", this.IndexType);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "IndexStatus", this.IndexStatus);
            this.SetParamSimple(map, prefix + "IndexStorage", this.IndexStorage);
            this.SetParamSimple(map, prefix + "IndexCreateTime", this.IndexCreateTime);
            this.SetParamArrayObj(map, prefix + "BackingIndices.", this.BackingIndices);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamObj(map, prefix + "IndexPolicyField.", this.IndexPolicyField);
            this.SetParamObj(map, prefix + "IndexOptionsField.", this.IndexOptionsField);
            this.SetParamObj(map, prefix + "IndexSettingsField.", this.IndexSettingsField);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "IndexDocs", this.IndexDocs);
        }
    }
}

