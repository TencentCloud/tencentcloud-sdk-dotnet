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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ESDataAssetCountDto : AbstractModel
    {
        
        /// <summary>
        /// es
        /// </summary>
        [JsonProperty("DataAssetType")]
        public long? DataAssetType{ get; set; }

        /// <summary>
        /// 敏感索引个数
        /// </summary>
        [JsonProperty("SensitiveIndexCnt")]
        public long? SensitiveIndexCnt{ get; set; }

        /// <summary>
        /// 总的索引个数
        /// </summary>
        [JsonProperty("TotalIndexCnt")]
        public long? TotalIndexCnt{ get; set; }

        /// <summary>
        /// 敏感字段个数
        /// </summary>
        [JsonProperty("SensitiveFieldCnt")]
        public long? SensitiveFieldCnt{ get; set; }

        /// <summary>
        /// 总的字段个数
        /// </summary>
        [JsonProperty("TotalFieldCnt")]
        public long? TotalFieldCnt{ get; set; }

        /// <summary>
        /// 敏感分类的个数
        /// </summary>
        [JsonProperty("SensitiveCategoryCnt")]
        public long? SensitiveCategoryCnt{ get; set; }

        /// <summary>
        /// 敏感分级的分布
        /// </summary>
        [JsonProperty("SensitiveLevel")]
        public SensitiveLevel[] SensitiveLevel{ get; set; }

        /// <summary>
        /// 敏感分类的分布
        /// </summary>
        [JsonProperty("CategoryDistributed")]
        public DspaDataCategoryDistributed[] CategoryDistributed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataAssetType", this.DataAssetType);
            this.SetParamSimple(map, prefix + "SensitiveIndexCnt", this.SensitiveIndexCnt);
            this.SetParamSimple(map, prefix + "TotalIndexCnt", this.TotalIndexCnt);
            this.SetParamSimple(map, prefix + "SensitiveFieldCnt", this.SensitiveFieldCnt);
            this.SetParamSimple(map, prefix + "TotalFieldCnt", this.TotalFieldCnt);
            this.SetParamSimple(map, prefix + "SensitiveCategoryCnt", this.SensitiveCategoryCnt);
            this.SetParamArrayObj(map, prefix + "SensitiveLevel.", this.SensitiveLevel);
            this.SetParamArrayObj(map, prefix + "CategoryDistributed.", this.CategoryDistributed);
        }
    }
}

