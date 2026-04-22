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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>配置项名称</p>
        /// </summary>
        [JsonProperty("ConfKey")]
        public string ConfKey{ get; set; }

        /// <summary>
        /// <p>配置项内容</p>
        /// </summary>
        [JsonProperty("ConfValue")]
        public string ConfValue{ get; set; }

        /// <summary>
        /// <p>默认值</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>是否需要重启</p>
        /// </summary>
        [JsonProperty("NeedRestart")]
        public bool? NeedRestart{ get; set; }

        /// <summary>
        /// <p>是否可编辑</p>
        /// </summary>
        [JsonProperty("Editable")]
        public bool? Editable{ get; set; }

        /// <summary>
        /// <p>配置项解释</p>
        /// </summary>
        [JsonProperty("ConfDesc")]
        public string ConfDesc{ get; set; }

        /// <summary>
        /// <p>文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>规则名称类型</p>
        /// </summary>
        [JsonProperty("ModifyRuleType")]
        public string ModifyRuleType{ get; set; }

        /// <summary>
        /// <p>规则名称内容</p>
        /// </summary>
        [JsonProperty("ModifyRuleValue")]
        public string ModifyRuleValue{ get; set; }

        /// <summary>
        /// <p>修改人的uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>取值范围</p>
        /// </summary>
        [JsonProperty("ValueRange")]
        public string ValueRange{ get; set; }

        /// <summary>
        /// <p>标记异常</p>
        /// </summary>
        [JsonProperty("AbnormalParam")]
        public string AbnormalParam{ get; set; }

        /// <summary>
        /// <p>是否生效</p>
        /// </summary>
        [JsonProperty("ConfigEffective")]
        public string ConfigEffective{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfKey", this.ConfKey);
            this.SetParamSimple(map, prefix + "ConfValue", this.ConfValue);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "Editable", this.Editable);
            this.SetParamSimple(map, prefix + "ConfDesc", this.ConfDesc);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "ModifyRuleType", this.ModifyRuleType);
            this.SetParamSimple(map, prefix + "ModifyRuleValue", this.ModifyRuleValue);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "ValueRange", this.ValueRange);
            this.SetParamSimple(map, prefix + "AbnormalParam", this.AbnormalParam);
            this.SetParamSimple(map, prefix + "ConfigEffective", this.ConfigEffective);
        }
    }
}

