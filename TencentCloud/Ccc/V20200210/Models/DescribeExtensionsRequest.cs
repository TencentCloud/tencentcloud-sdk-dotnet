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

    public class DescribeExtensionsRequest : AbstractModel
    {
        
        /// <summary>
        /// TCCC 实例应用 ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 分页页号（从0开始）
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 筛选分机号列表
        /// </summary>
        [JsonProperty("ExtensionIds")]
        public string[] ExtensionIds{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 模糊查询字段（模糊查询分机号、分机名称、坐席邮箱、坐席名称）
        /// </summary>
        [JsonProperty("FuzzingKeyWord")]
        public string FuzzingKeyWord{ get; set; }

        /// <summary>
        /// 是否需要返回话机当前状态
        /// </summary>
        [JsonProperty("IsNeedStatus")]
        public bool? IsNeedStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamArraySimple(map, prefix + "ExtensionIds.", this.ExtensionIds);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "FuzzingKeyWord", this.FuzzingKeyWord);
            this.SetParamSimple(map, prefix + "IsNeedStatus", this.IsNeedStatus);
        }
    }
}

