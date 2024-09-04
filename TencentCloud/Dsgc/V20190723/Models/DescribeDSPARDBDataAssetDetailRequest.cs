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

    public class DescribeDSPARDBDataAssetDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例Id
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 合规组Id
        /// </summary>
        [JsonProperty("ComplianceId")]
        public long? ComplianceId{ get; set; }

        /// <summary>
        /// 过滤数组。支持的Name：
        /// DataSourceID 数据源ID
        /// DbName 数据库名称
        /// CategoryID 敏感数据分类ID
        /// RuleID 规则ID
        /// LevelID 敏感分级ID
        /// ResourceRegion 资源所在地域
        /// SensitiveField 过滤敏感字段，可选值为1，或者无此SensitiveField字段
        /// DataSourceType 数据源类型，不填默认过滤非自建的所有关系型数据源类型，填selfbuilt-db只过滤自建类型
        /// 注意：每个name默认支持最多5个values。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 可信分排序，ASC-升序
        /// DESC降序
        /// </summary>
        [JsonProperty("CreditScore")]
        public string CreditScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "CreditScore", this.CreditScore);
        }
    }
}

