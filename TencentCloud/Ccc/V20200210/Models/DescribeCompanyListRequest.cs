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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCompanyListRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页尺寸，上限 100
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 分页页码，从 0 开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string[] CompanyName{ get; set; }

        /// <summary>
        /// 审核状态，1-待审核，2-审核通过，3-驳回
        /// </summary>
        [JsonProperty("State")]
        public long?[] State{ get; set; }

        /// <summary>
        /// 申请ID
        /// </summary>
        [JsonProperty("ApplyID")]
        public long?[] ApplyID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamArraySimple(map, prefix + "CompanyName.", this.CompanyName);
            this.SetParamArraySimple(map, prefix + "State.", this.State);
            this.SetParamArraySimple(map, prefix + "ApplyID.", this.ApplyID);
        }
    }
}

