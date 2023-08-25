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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaRDBDataAssetCount : AbstractModel
    {
        
        /// <summary>
        /// 数组资产类型，0代表关系型数据库资产，1代表对象存储COS资产
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataAssetType")]
        public long? DataAssetType{ get; set; }

        /// <summary>
        /// 已扫描的数据库的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalDbCnt")]
        public long? TotalDbCnt{ get; set; }

        /// <summary>
        /// 数据库表的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalTableCnt")]
        public long? TotalTableCnt{ get; set; }

        /// <summary>
        /// 敏感数据类型个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveCategoryCnt")]
        public long? SensitiveCategoryCnt{ get; set; }

        /// <summary>
        /// 敏感字段的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveFieldCnt")]
        public long? SensitiveFieldCnt{ get; set; }

        /// <summary>
        /// 敏感等级分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveLevel")]
        public SensitiveLevel[] SensitiveLevel{ get; set; }

        /// <summary>
        /// 敏感数据库的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveDbCnt")]
        public long? SensitiveDbCnt{ get; set; }

        /// <summary>
        /// 敏感数据库表的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveTableCnt")]
        public long? SensitiveTableCnt{ get; set; }

        /// <summary>
        /// 扫描字段的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalFieldCnt")]
        public long? TotalFieldCnt{ get; set; }

        /// <summary>
        /// 数据分类分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CategoryDistributed")]
        public DspaDataCategoryDistributed[] CategoryDistributed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataAssetType", this.DataAssetType);
            this.SetParamSimple(map, prefix + "TotalDbCnt", this.TotalDbCnt);
            this.SetParamSimple(map, prefix + "TotalTableCnt", this.TotalTableCnt);
            this.SetParamSimple(map, prefix + "SensitiveCategoryCnt", this.SensitiveCategoryCnt);
            this.SetParamSimple(map, prefix + "SensitiveFieldCnt", this.SensitiveFieldCnt);
            this.SetParamArrayObj(map, prefix + "SensitiveLevel.", this.SensitiveLevel);
            this.SetParamSimple(map, prefix + "SensitiveDbCnt", this.SensitiveDbCnt);
            this.SetParamSimple(map, prefix + "SensitiveTableCnt", this.SensitiveTableCnt);
            this.SetParamSimple(map, prefix + "TotalFieldCnt", this.TotalFieldCnt);
            this.SetParamArrayObj(map, prefix + "CategoryDistributed.", this.CategoryDistributed);
        }
    }
}

