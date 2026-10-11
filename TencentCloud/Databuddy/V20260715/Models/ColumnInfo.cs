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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ColumnInfo : AbstractModel
    {
        
        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 字段描述
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 字段设置
        /// </summary>
        [JsonProperty("FieldSetting")]
        public string FieldSetting{ get; set; }

        /// <summary>
        /// 是否为主键
        /// </summary>
        [JsonProperty("IsPrimaryKey")]
        public bool? IsPrimaryKey{ get; set; }

        /// <summary>
        /// 字段策略
        /// </summary>
        [JsonProperty("DataMaskStrategyInfo")]
        public DataMaskStrategyInfo DataMaskStrategyInfo{ get; set; }

        /// <summary>
        /// 字段级标签列表，仅当请求中FetchOption.FetchTags=true时返回，默认不返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public CommonTagInfo[] Tags{ get; set; }

        /// <summary>
        /// 字段关联的字典维度信息，仅当请求中FetchOption.FetchDictDimensions=true时返回，默认不返回；若该字段未关联任何字典维度则为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DictDimension")]
        public DictDimensionInfo DictDimension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "FieldSetting", this.FieldSetting);
            this.SetParamSimple(map, prefix + "IsPrimaryKey", this.IsPrimaryKey);
            this.SetParamObj(map, prefix + "DataMaskStrategyInfo.", this.DataMaskStrategyInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "DictDimension.", this.DictDimension);
        }
    }
}

