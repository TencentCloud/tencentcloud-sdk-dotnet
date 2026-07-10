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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDspmIdentifyDistributionStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>统计类型</p><p>枚举值：</p><ul><li>FieldTop5Asset： 识别字段Top5</li><li>FieldCategoryDistribution： 识别字段分类分布</li><li>FieldLevelDistribution： 识别字段级别分布</li><li>AssetDistribution： 识别资产分布</li></ul>
        /// </summary>
        [JsonProperty("StatType")]
        public string StatType{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>资产类型</p><p>枚举值：</p><ul><li>cdb： 云数据库MySQL</li><li>mariadb： 云数据库MariaDB</li></ul>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>识别模板id</p>
        /// </summary>
        [JsonProperty("ComplianceId")]
        public ulong? ComplianceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatType", this.StatType);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
        }
    }
}

