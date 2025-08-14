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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OwaspRuleType : AbstractModel
    {
        
        /// <summary>
        /// 类型ID
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 类型描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 类型分类
        /// </summary>
        [JsonProperty("Classification")]
        public string Classification{ get; set; }

        /// <summary>
        /// 规则类型的防护模式，0：观察、1：拦截
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// 规则类型的防护等级，100：宽松、200：正常、300：严格、400：超严格
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 规则类型的开关状态，0：关闭、1：开启
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 规则类型下的所有规则总是
        /// </summary>
        [JsonProperty("TotalRule")]
        public ulong? TotalRule{ get; set; }

        /// <summary>
        /// 规则类型下的启用的规则总数
        /// </summary>
        [JsonProperty("ActiveRule")]
        public ulong? ActiveRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Classification", this.Classification);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TotalRule", this.TotalRule);
            this.SetParamSimple(map, prefix + "ActiveRule", this.ActiveRule);
        }
    }
}

