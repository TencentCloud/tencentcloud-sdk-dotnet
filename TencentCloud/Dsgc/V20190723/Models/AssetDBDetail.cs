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

    public class AssetDBDetail : AbstractModel
    {
        
        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DdName")]
        public string DdName{ get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// 表的数量
        /// </summary>
        [JsonProperty("TableNums")]
        public long? TableNums{ get; set; }

        /// <summary>
        /// 敏感表数量
        /// </summary>
        [JsonProperty("SensitiveTableNums")]
        public long? SensitiveTableNums{ get; set; }

        /// <summary>
        /// 字段的数量
        /// </summary>
        [JsonProperty("FieldNums")]
        public long? FieldNums{ get; set; }

        /// <summary>
        /// 敏感字段的数量
        /// </summary>
        [JsonProperty("SensitiveFieldNums")]
        public long? SensitiveFieldNums{ get; set; }

        /// <summary>
        /// 敏感数据分布
        /// </summary>
        [JsonProperty("DistributionData")]
        public Note[] DistributionData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "DdName", this.DdName);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "TableNums", this.TableNums);
            this.SetParamSimple(map, prefix + "SensitiveTableNums", this.SensitiveTableNums);
            this.SetParamSimple(map, prefix + "FieldNums", this.FieldNums);
            this.SetParamSimple(map, prefix + "SensitiveFieldNums", this.SensitiveFieldNums);
            this.SetParamArrayObj(map, prefix + "DistributionData.", this.DistributionData);
        }
    }
}

