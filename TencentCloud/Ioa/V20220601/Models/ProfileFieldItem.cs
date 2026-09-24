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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProfileFieldItem : AbstractModel
    {
        
        /// <summary>
        /// <p>键值id</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>排序key(只支持32位)</p>
        /// </summary>
        [JsonProperty("Key")]
        public long? Key{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>输入类型(只支持32位)</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>是否必选(只支持32位)</p>
        /// </summary>
        [JsonProperty("IsMust")]
        public long? IsMust{ get; set; }

        /// <summary>
        /// <p>是否显示(只支持32位)</p>
        /// </summary>
        [JsonProperty("IsShow")]
        public long? IsShow{ get; set; }

        /// <summary>
        /// <p>是否自定义(只支持32位)</p>
        /// </summary>
        [JsonProperty("IsCustom")]
        public long? IsCustom{ get; set; }

        /// <summary>
        /// <p>下一个选项key(只支持32位)</p>
        /// </summary>
        [JsonProperty("NextOptionKey")]
        public long? NextOptionKey{ get; set; }

        /// <summary>
        /// <p>选项数据</p>
        /// </summary>
        [JsonProperty("Options")]
        public string Options{ get; set; }

        /// <summary>
        /// <p>是否覆盖(只支持32位)</p>
        /// </summary>
        [JsonProperty("IsReplace")]
        public long? IsReplace{ get; set; }

        /// <summary>
        /// <p>是否可以修改分组</p>
        /// </summary>
        [JsonProperty("GroupEditable")]
        public bool? GroupEditable{ get; set; }

        /// <summary>
        /// <p>是否有规则</p>
        /// </summary>
        [JsonProperty("HasRules")]
        public bool? HasRules{ get; set; }

        /// <summary>
        /// <p>规则id</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// <p>名称-英文</p>
        /// </summary>
        [JsonProperty("TitleEn")]
        public string TitleEn{ get; set; }

        /// <summary>
        /// <p>选项数据-英文</p>
        /// </summary>
        [JsonProperty("OptionsEn")]
        public string OptionsEn{ get; set; }

        /// <summary>
        /// <p>选项数据(包含中英文)</p>
        /// </summary>
        [JsonProperty("OptionsItem")]
        public OptionsItem[] OptionsItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsMust", this.IsMust);
            this.SetParamSimple(map, prefix + "IsShow", this.IsShow);
            this.SetParamSimple(map, prefix + "IsCustom", this.IsCustom);
            this.SetParamSimple(map, prefix + "NextOptionKey", this.NextOptionKey);
            this.SetParamSimple(map, prefix + "Options", this.Options);
            this.SetParamSimple(map, prefix + "IsReplace", this.IsReplace);
            this.SetParamSimple(map, prefix + "GroupEditable", this.GroupEditable);
            this.SetParamSimple(map, prefix + "HasRules", this.HasRules);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "TitleEn", this.TitleEn);
            this.SetParamSimple(map, prefix + "OptionsEn", this.OptionsEn);
            this.SetParamArrayObj(map, prefix + "OptionsItem.", this.OptionsItem);
        }
    }
}

