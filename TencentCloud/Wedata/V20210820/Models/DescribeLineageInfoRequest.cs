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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLineageInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 实体原始唯一ID
        /// </summary>
        [JsonProperty("ResourceOriId")]
        public string ResourceOriId{ get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 血缘唯一ID
        /// </summary>
        [JsonProperty("QualifiedId")]
        public string QualifiedId{ get; set; }

        /// <summary>
        /// 查询方向
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 查询入度
        /// </summary>
        [JsonProperty("InputDepth")]
        public long? InputDepth{ get; set; }

        /// <summary>
        /// 查询出度
        /// </summary>
        [JsonProperty("OutputDepth")]
        public long? OutputDepth{ get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 血缘类型（分页使用）
        /// </summary>
        [JsonProperty("LineageType")]
        public string LineageType{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceOriId", this.ResourceOriId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "QualifiedId", this.QualifiedId);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "InputDepth", this.InputDepth);
            this.SetParamSimple(map, prefix + "OutputDepth", this.OutputDepth);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "LineageType", this.LineageType);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

