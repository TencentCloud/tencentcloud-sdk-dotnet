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
        /// 配置项名称
        /// </summary>
        [JsonProperty("ConfKey")]
        public string ConfKey{ get; set; }

        /// <summary>
        /// 配置项内容
        /// </summary>
        [JsonProperty("ConfValue")]
        public string ConfValue{ get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 是否需要重启
        /// </summary>
        [JsonProperty("NeedRestart")]
        public bool? NeedRestart{ get; set; }

        /// <summary>
        /// 是否可编辑
        /// </summary>
        [JsonProperty("Editable")]
        public bool? Editable{ get; set; }

        /// <summary>
        /// 配置项解释
        /// </summary>
        [JsonProperty("ConfDesc")]
        public string ConfDesc{ get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 规则名称类型
        /// </summary>
        [JsonProperty("ModifyRuleType")]
        public string ModifyRuleType{ get; set; }

        /// <summary>
        /// 规则名称内容
        /// </summary>
        [JsonProperty("ModifyRuleValue")]
        public string ModifyRuleValue{ get; set; }

        /// <summary>
        /// 修改人的uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


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
        }
    }
}

