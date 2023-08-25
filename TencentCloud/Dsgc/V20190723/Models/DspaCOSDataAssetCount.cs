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

    public class DspaCOSDataAssetCount : AbstractModel
    {
        
        /// <summary>
        /// 数组资产类型，0代表关系型数据库资产，1代表对象存储COS资产
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataAssetType")]
        public long? DataAssetType{ get; set; }

        /// <summary>
        /// 已扫描的存储桶的个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalBucketCnt")]
        public long? TotalBucketCnt{ get; set; }

        /// <summary>
        /// 对象总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalObjectCnt")]
        public long? TotalObjectCnt{ get; set; }

        /// <summary>
        /// 敏感数据类型个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveCategoryCnt")]
        public long? SensitiveCategoryCnt{ get; set; }

        /// <summary>
        /// 敏感数据条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveDataCnt")]
        public long? SensitiveDataCnt{ get; set; }

        /// <summary>
        /// 敏感等级分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveLevel")]
        public SensitiveLevel[] SensitiveLevel{ get; set; }

        /// <summary>
        /// 敏感存储桶个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveBucketCnt")]
        public long? SensitiveBucketCnt{ get; set; }

        /// <summary>
        /// 敏感对象个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveObjectCnt")]
        public long? SensitiveObjectCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalBucketCnt", this.TotalBucketCnt);
            this.SetParamSimple(map, prefix + "TotalObjectCnt", this.TotalObjectCnt);
            this.SetParamSimple(map, prefix + "SensitiveCategoryCnt", this.SensitiveCategoryCnt);
            this.SetParamSimple(map, prefix + "SensitiveDataCnt", this.SensitiveDataCnt);
            this.SetParamArrayObj(map, prefix + "SensitiveLevel.", this.SensitiveLevel);
            this.SetParamSimple(map, prefix + "SensitiveBucketCnt", this.SensitiveBucketCnt);
            this.SetParamSimple(map, prefix + "SensitiveObjectCnt", this.SensitiveObjectCnt);
            this.SetParamArrayObj(map, prefix + "CategoryDistributed.", this.CategoryDistributed);
        }
    }
}

