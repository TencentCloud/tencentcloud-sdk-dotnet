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

    public class IndexMetaField : AbstractModel
    {
        
        /// <summary>
        /// <p>索引类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// <p>索引名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// <p>索引元数据JSON</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexMetaJson")]
        public string IndexMetaJson{ get; set; }

        /// <summary>
        /// <p>索引状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexStatus")]
        public string IndexStatus{ get; set; }

        /// <summary>
        /// <p>索引存储大小，单位Byte</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexStorage")]
        public long? IndexStorage{ get; set; }

        /// <summary>
        /// <p>索引创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexCreateTime")]
        public string IndexCreateTime{ get; set; }

        /// <summary>
        /// <p>后备索引</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackingIndices")]
        public BackingIndexMetaField[] BackingIndices{ get; set; }

        /// <summary>
        /// <p>索引所属集群ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>索引所属集群名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>索引所属集群版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// <p>索引生命周期字段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexPolicyField")]
        public IndexPolicyField IndexPolicyField{ get; set; }

        /// <summary>
        /// <p>索引自治字段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexOptionsField")]
        public IndexOptionsField IndexOptionsField{ get; set; }

        /// <summary>
        /// <p>索引配置字段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexSettingsField")]
        public IndexSettingsField IndexSettingsField{ get; set; }

        /// <summary>
        /// <p>索引别名字段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexAliasesField")]
        public string[] IndexAliasesField{ get; set; }

        /// <summary>
        /// <p>索引所属集群APP ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>索引文档数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexDocs")]
        public ulong? IndexDocs{ get; set; }

        /// <summary>
        /// <p>当前字段数</p>
        /// </summary>
        [JsonProperty("FieldCount")]
        public long? FieldCount{ get; set; }

        /// <summary>
        /// <p>当前上限</p>
        /// </summary>
        [JsonProperty("FieldLimit")]
        public long? FieldLimit{ get; set; }

        /// <summary>
        /// <p>使用率</p>
        /// </summary>
        [JsonProperty("FieldUsageRatio")]
        public string FieldUsageRatio{ get; set; }

        /// <summary>
        /// <p>占用分片数</p>
        /// </summary>
        [JsonProperty("OccupiedShards")]
        public long? OccupiedShards{ get; set; }

        /// <summary>
        /// <p>索引开启状态</p>
        /// </summary>
        [JsonProperty("IndexOpenStatus")]
        public string IndexOpenStatus{ get; set; }

        /// <summary>
        /// <p>索引字段数硬上限</p>
        /// </summary>
        [JsonProperty("FieldLimitHardCap")]
        public long? FieldLimitHardCap{ get; set; }

        /// <summary>
        /// <p>上限可调整最小值</p>
        /// </summary>
        [JsonProperty("FieldLimitMin")]
        public long? FieldLimitMin{ get; set; }

        /// <summary>
        /// <p>剩余调整次数</p>
        /// </summary>
        [JsonProperty("FieldAutoAdjustRemaining")]
        public long? FieldAutoAdjustRemaining{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IndexType", this.IndexType);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "IndexMetaJson", this.IndexMetaJson);
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
            this.SetParamArraySimple(map, prefix + "IndexAliasesField.", this.IndexAliasesField);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "IndexDocs", this.IndexDocs);
            this.SetParamSimple(map, prefix + "FieldCount", this.FieldCount);
            this.SetParamSimple(map, prefix + "FieldLimit", this.FieldLimit);
            this.SetParamSimple(map, prefix + "FieldUsageRatio", this.FieldUsageRatio);
            this.SetParamSimple(map, prefix + "OccupiedShards", this.OccupiedShards);
            this.SetParamSimple(map, prefix + "IndexOpenStatus", this.IndexOpenStatus);
            this.SetParamSimple(map, prefix + "FieldLimitHardCap", this.FieldLimitHardCap);
            this.SetParamSimple(map, prefix + "FieldLimitMin", this.FieldLimitMin);
            this.SetParamSimple(map, prefix + "FieldAutoAdjustRemaining", this.FieldAutoAdjustRemaining);
        }
    }
}

