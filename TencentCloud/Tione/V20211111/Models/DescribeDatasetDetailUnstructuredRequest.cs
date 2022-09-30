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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatasetDetailUnstructuredRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据集ID
        /// </summary>
        [JsonProperty("DatasetId")]
        public string DatasetId{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回个数，默认20，目前最大支持2000条数据
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 标签过滤参数，对应标签值
        /// </summary>
        [JsonProperty("LabelList")]
        public string[] LabelList{ get; set; }

        /// <summary>
        /// 标注状态过滤参数:
        /// STATUS_ANNOTATED，已标注
        /// STATUS_NON_ANNOTATED，未标注
        /// STATUS_ALL，全部
        /// 默认为STATUS_ALL
        /// </summary>
        [JsonProperty("AnnotationStatus")]
        public string AnnotationStatus{ get; set; }

        /// <summary>
        /// 数据集ID列表
        /// </summary>
        [JsonProperty("DatasetIds")]
        public string[] DatasetIds{ get; set; }

        /// <summary>
        /// 要筛选的文本分类场景标签信息
        /// </summary>
        [JsonProperty("TextClassificationLabels")]
        public TextLabelDistributionInfo[] TextClassificationLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasetId", this.DatasetId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "LabelList.", this.LabelList);
            this.SetParamSimple(map, prefix + "AnnotationStatus", this.AnnotationStatus);
            this.SetParamArraySimple(map, prefix + "DatasetIds.", this.DatasetIds);
            this.SetParamArrayObj(map, prefix + "TextClassificationLabels.", this.TextClassificationLabels);
        }
    }
}

