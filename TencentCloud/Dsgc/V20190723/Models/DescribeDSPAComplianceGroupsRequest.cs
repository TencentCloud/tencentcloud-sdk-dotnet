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

    public class DescribeDSPAComplianceGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 合规组ID
        /// </summary>
        [JsonProperty("ComplianceGroupId")]
        public long? ComplianceGroupId{ get; set; }

        /// <summary>
        /// 合规组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 偏移量，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回结果集数量，默认值是10000，最大值为10000，根据该资源的个数限制条件，该资源的个数不会超过10000，所以如果不输入该字段，默认获取全量数据
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 合规组类型可选值：0 默认合规组, 1 系统合规组, 2 自定义合规组
        /// </summary>
        [JsonProperty("ComplianceGroupTypeList")]
        public long?[] ComplianceGroupTypeList{ get; set; }

        /// <summary>
        /// 是否仅显示已开启模板
        /// </summary>
        [JsonProperty("IsFilterCloseComplianceGroup")]
        public bool? IsFilterCloseComplianceGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "ComplianceGroupId", this.ComplianceGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "ComplianceGroupTypeList.", this.ComplianceGroupTypeList);
            this.SetParamSimple(map, prefix + "IsFilterCloseComplianceGroup", this.IsFilterCloseComplianceGroup);
        }
    }
}

