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

    public class TrainingData : AbstractModel
    {
        
        /// <summary>
        /// Catalog名称
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// Schema名称
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// Table名称
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 目标标签列
        /// </summary>
        [JsonProperty("TargetLabel")]
        public Label TargetLabel{ get; set; }

        /// <summary>
        /// 忽略的列
        /// </summary>
        [JsonProperty("DiscardedLabels")]
        public Label[] DiscardedLabels{ get; set; }

        /// <summary>
        /// 预测列
        /// </summary>
        [JsonProperty("PredictionLabel")]
        public Label PredictionLabel{ get; set; }

        /// <summary>
        /// 时间间隔单位
        /// </summary>
        [JsonProperty("EvaluationInterval")]
        public string EvaluationInterval{ get; set; }

        /// <summary>
        /// 时序步长
        /// </summary>
        [JsonProperty("ForecastHorizon")]
        public long? ForecastHorizon{ get; set; }

        /// <summary>
        /// 结果集Catalog名称
        /// </summary>
        [JsonProperty("StorageCatalog")]
        public string StorageCatalog{ get; set; }

        /// <summary>
        /// 结果集Schema名称
        /// </summary>
        [JsonProperty("StorageSchema")]
        public string StorageSchema{ get; set; }

        /// <summary>
        /// 结果集Table名称
        /// </summary>
        [JsonProperty("StorageTable")]
        public string StorageTable{ get; set; }

        /// <summary>
        /// 选中的列
        /// </summary>
        [JsonProperty("SelectedLabels")]
        public Label[] SelectedLabels{ get; set; }

        /// <summary>
        /// 特征查找配置
        /// </summary>
        [JsonProperty("FeatureLookup")]
        public FeatureLookup[] FeatureLookup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamObj(map, prefix + "TargetLabel.", this.TargetLabel);
            this.SetParamArrayObj(map, prefix + "DiscardedLabels.", this.DiscardedLabels);
            this.SetParamObj(map, prefix + "PredictionLabel.", this.PredictionLabel);
            this.SetParamSimple(map, prefix + "EvaluationInterval", this.EvaluationInterval);
            this.SetParamSimple(map, prefix + "ForecastHorizon", this.ForecastHorizon);
            this.SetParamSimple(map, prefix + "StorageCatalog", this.StorageCatalog);
            this.SetParamSimple(map, prefix + "StorageSchema", this.StorageSchema);
            this.SetParamSimple(map, prefix + "StorageTable", this.StorageTable);
            this.SetParamArrayObj(map, prefix + "SelectedLabels.", this.SelectedLabels);
            this.SetParamArrayObj(map, prefix + "FeatureLookup.", this.FeatureLookup);
        }
    }
}

