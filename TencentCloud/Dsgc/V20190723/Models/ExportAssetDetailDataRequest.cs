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

    public class ExportAssetDetailDataRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例Id，格式“dspa-xxxxxxxx”
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 合规组id
        /// </summary>
        [JsonProperty("ComplianceId")]
        public ulong? ComplianceId{ get; set; }

        /// <summary>
        /// 资产类型（rdb,cvm_db,cos）
        /// </summary>
        [JsonProperty("MetaDataType")]
        public string MetaDataType{ get; set; }

        /// <summary>
        /// 过滤数组。支持的Name：
        /// DataSourceID 数据源ID
        /// DbName 数据库名称
        /// CategoryID 敏感数据分类ID
        /// RuleID 规则ID
        /// LevelID 敏感分级ID
        /// ResourceRegion 资源所在地域
        /// DataSourceType 数据源类型，不填默认过滤非自建的所有关系型数据源类型，填selfbuilt-db只过滤自建类型
        /// 注意：每个name默认支持最多5个values。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamSimple(map, prefix + "MetaDataType", this.MetaDataType);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

