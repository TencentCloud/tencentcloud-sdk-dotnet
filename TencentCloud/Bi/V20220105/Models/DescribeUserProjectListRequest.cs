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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserProjectListRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("AllPage")]
        public bool? AllPage{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 是否过滤掉企业管理员
        /// </summary>
        [JsonProperty("IsFilterPerAuthUser")]
        public bool? IsFilterPerAuthUser{ get; set; }

        /// <summary>
        /// 是否过滤掉当前用户
        /// </summary>
        [JsonProperty("IsFilterCurrentUser")]
        public bool? IsFilterCurrentUser{ get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AllPage", this.AllPage);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "IsFilterPerAuthUser", this.IsFilterPerAuthUser);
            this.SetParamSimple(map, prefix + "IsFilterCurrentUser", this.IsFilterCurrentUser);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

