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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InOutputUCBRuleEntry : AbstractModel
    {
        
        /// <summary>
        /// 键
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 操作符
        /// </summary>
        [JsonProperty("Op")]
        public string Op{ get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("Value")]
        public UCBEntryValue Value{ get; set; }

        /// <summary>
        /// 可选的补充操作符
        /// </summary>
        [JsonProperty("OpOp")]
        public string OpOp{ get; set; }

        /// <summary>
        /// 可选的补充参数
        /// </summary>
        [JsonProperty("OpArg")]
        public string[] OpArg{ get; set; }

        /// <summary>
        /// 可选的补充值
        /// </summary>
        [JsonProperty("OpValue")]
        public float? OpValue{ get; set; }

        /// <summary>
        /// Header参数值时使用
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 区域选择
        /// </summary>
        [JsonProperty("Areas")]
        public Area[] Areas{ get; set; }

        /// <summary>
        /// 语言环境
        /// </summary>
        [JsonProperty("Lang")]
        public string Lang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Op", this.Op);
            this.SetParamObj(map, prefix + "Value.", this.Value);
            this.SetParamSimple(map, prefix + "OpOp", this.OpOp);
            this.SetParamArraySimple(map, prefix + "OpArg.", this.OpArg);
            this.SetParamSimple(map, prefix + "OpValue", this.OpValue);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Areas.", this.Areas);
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
        }
    }
}

