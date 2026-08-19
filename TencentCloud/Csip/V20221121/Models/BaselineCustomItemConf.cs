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

    public class BaselineCustomItemConf : AbstractModel
    {
        
        /// <summary>
        /// <p>内置检测项规则 ID，与 CustomItemID 二选一传入。</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public ulong? RuleID{ get; set; }

        /// <summary>
        /// <p>用户自定义的判定值列表，需符合检测项 WebEditParam 定义的取值约束。</p>
        /// </summary>
        [JsonProperty("CustomValueList")]
        public string[] CustomValueList{ get; set; }

        /// <summary>
        /// <p>已存在的自定义配置 ID；新增时可不传，编辑时回填。</p>
        /// </summary>
        [JsonProperty("CustomItemID")]
        public ulong? CustomItemID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "CustomValueList.", this.CustomValueList);
            this.SetParamSimple(map, prefix + "CustomItemID", this.CustomItemID);
        }
    }
}

