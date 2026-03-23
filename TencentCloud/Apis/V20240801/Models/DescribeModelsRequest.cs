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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页限制
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// ID列表
        /// </summary>
        [JsonProperty("IDs")]
        public string[] IDs{ get; set; }

        /// <summary>
        /// 排除的ID列表
        /// </summary>
        [JsonProperty("NotIDs")]
        public string[] NotIDs{ get; set; }

        /// <summary>
        /// 凭据ID
        /// </summary>
        [JsonProperty("CredentialID")]
        public string CredentialID{ get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("Sort")]
        public DescribeModelsSort Sort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "IDs.", this.IDs);
            this.SetParamArraySimple(map, prefix + "NotIDs.", this.NotIDs);
            this.SetParamSimple(map, prefix + "CredentialID", this.CredentialID);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
        }
    }
}

