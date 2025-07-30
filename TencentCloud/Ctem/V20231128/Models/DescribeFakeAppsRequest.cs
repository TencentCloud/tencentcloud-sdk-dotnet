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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFakeAppsRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业ID列表，可多选
        /// </summary>
        [JsonProperty("CustomerIdList")]
        public long?[] CustomerIdList{ get; set; }

        /// <summary>
        /// 是否新增数据
        /// </summary>
        [JsonProperty("IsNew")]
        public bool? IsNew{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页偏移
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 子公司ID列表
        /// </summary>
        [JsonProperty("EnterpriseUidList")]
        public string[] EnterpriseUidList{ get; set; }

        /// <summary>
        /// 数据输出格式：json、file，默认不填为json
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 创建时间-开始
        /// </summary>
        [JsonProperty("CreateAtStart")]
        public string CreateAtStart{ get; set; }

        /// <summary>
        /// 创建时间-结束
        /// </summary>
        [JsonProperty("CreateAtEnd")]
        public string CreateAtEnd{ get; set; }

        /// <summary>
        /// 更新时间-开始
        /// </summary>
        [JsonProperty("UpdateAtStart")]
        public string UpdateAtStart{ get; set; }

        /// <summary>
        /// 更新时间-结束
        /// </summary>
        [JsonProperty("UpdateAtEnd")]
        public string UpdateAtEnd{ get; set; }

        /// <summary>
        /// 查询数组
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 是否显示被忽略的数据
        /// </summary>
        [JsonProperty("Ignored")]
        public bool? Ignored{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CustomerIdList.", this.CustomerIdList);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "EnterpriseUidList.", this.EnterpriseUidList);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "CreateAtStart", this.CreateAtStart);
            this.SetParamSimple(map, prefix + "CreateAtEnd", this.CreateAtEnd);
            this.SetParamSimple(map, prefix + "UpdateAtStart", this.UpdateAtStart);
            this.SetParamSimple(map, prefix + "UpdateAtEnd", this.UpdateAtEnd);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Ignored", this.Ignored);
        }
    }
}

