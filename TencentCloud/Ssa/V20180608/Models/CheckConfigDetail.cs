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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckConfigDetail : AbstractModel
    {
        
        /// <summary>
        /// 检查项Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 检查项名称
        /// </summary>
        [JsonProperty("CheckName")]
        public string CheckName{ get; set; }

        /// <summary>
        /// 检查项内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 检查项处置方案
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 检查项帮助文档
        /// </summary>
        [JsonProperty("Doc")]
        public string Doc{ get; set; }

        /// <summary>
        /// 未通过总数
        /// </summary>
        [JsonProperty("ErrorCount")]
        public long? ErrorCount{ get; set; }

        /// <summary>
        /// 是否通过检查
        /// </summary>
        [JsonProperty("IsPass")]
        public long? IsPass{ get; set; }

        /// <summary>
        /// 通过检查项
        /// </summary>
        [JsonProperty("SafeCount")]
        public long? SafeCount{ get; set; }

        /// <summary>
        /// 忽略检查项
        /// </summary>
        [JsonProperty("IgnoreCount")]
        public long? IgnoreCount{ get; set; }

        /// <summary>
        /// 风险检查项
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 检查项英文
        /// </summary>
        [JsonProperty("NameEn")]
        public string NameEn{ get; set; }

        /// <summary>
        /// 检查项类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// res_count
        /// </summary>
        [JsonProperty("ResCount")]
        public long? ResCount{ get; set; }

        /// <summary>
        /// 是否忽略
        /// </summary>
        [JsonProperty("IsIgnore")]
        public long? IsIgnore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "CheckName", this.CheckName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Doc", this.Doc);
            this.SetParamSimple(map, prefix + "ErrorCount", this.ErrorCount);
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamSimple(map, prefix + "SafeCount", this.SafeCount);
            this.SetParamSimple(map, prefix + "IgnoreCount", this.IgnoreCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "NameEn", this.NameEn);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ResCount", this.ResCount);
            this.SetParamSimple(map, prefix + "IsIgnore", this.IsIgnore);
        }
    }
}

