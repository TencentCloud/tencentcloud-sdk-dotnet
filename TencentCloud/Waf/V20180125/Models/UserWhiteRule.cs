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

    public class UserWhiteRule : AbstractModel
    {
        
        /// <summary>
        /// 白名单的id
        /// </summary>
        [JsonProperty("WhiteRuleId")]
        public ulong? WhiteRuleId{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("SignatureId")]
        public string SignatureId{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 匹配域
        /// </summary>
        [JsonProperty("MatchField")]
        public string MatchField{ get; set; }

        /// <summary>
        /// 匹配参数
        /// </summary>
        [JsonProperty("MatchParams")]
        public string MatchParams{ get; set; }

        /// <summary>
        /// 匹配方法
        /// </summary>
        [JsonProperty("MatchMethod")]
        public string MatchMethod{ get; set; }

        /// <summary>
        /// 匹配内容
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 规则ID列表
        /// </summary>
        [JsonProperty("SignatureIds")]
        public string[] SignatureIds{ get; set; }

        /// <summary>
        /// 大类规则ID列表
        /// </summary>
        [JsonProperty("TypeIds")]
        public string[] TypeIds{ get; set; }

        /// <summary>
        /// 大类规则ID
        /// </summary>
        [JsonProperty("TypeId")]
        public string TypeId{ get; set; }

        /// <summary>
        /// 0:按照特定规则ID加白, 1:按照规则类型加白
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 匹配规则列表
        /// </summary>
        [JsonProperty("MatchInfo")]
        public UserWhiteRuleItem[] MatchInfo{ get; set; }

        /// <summary>
        /// MatchInfo字符串
        /// </summary>
        [JsonProperty("MatchInfoStr")]
        public string MatchInfoStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhiteRuleId", this.WhiteRuleId);
            this.SetParamSimple(map, prefix + "SignatureId", this.SignatureId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MatchField", this.MatchField);
            this.SetParamSimple(map, prefix + "MatchParams", this.MatchParams);
            this.SetParamSimple(map, prefix + "MatchMethod", this.MatchMethod);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArraySimple(map, prefix + "SignatureIds.", this.SignatureIds);
            this.SetParamArraySimple(map, prefix + "TypeIds.", this.TypeIds);
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "MatchInfo.", this.MatchInfo);
            this.SetParamSimple(map, prefix + "MatchInfoStr", this.MatchInfoStr);
        }
    }
}

