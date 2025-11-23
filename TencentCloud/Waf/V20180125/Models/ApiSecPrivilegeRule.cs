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

    public class ApiSecPrivilegeRule : AbstractModel
    {
        
        /// <summary>
        /// 规则名称，不可重复
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 1:开，0:关
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 最多输入20个api
        /// </summary>
        [JsonProperty("ApiName")]
        public string[] ApiName{ get; set; }

        /// <summary>
        /// 鉴权位置
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// 鉴权参数列表
        /// </summary>
        [JsonProperty("ParameterList")]
        public string[] ParameterList{ get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 规则来源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 带有匹配方式的api列表
        /// </summary>
        [JsonProperty("ApiNameOp")]
        public ApiNameOp[] ApiNameOp{ get; set; }

        /// <summary>
        /// 应用对象取值，1表示手动填写，2表示从api资产中获取
        /// </summary>
        [JsonProperty("Option")]
        public ulong? Option{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "ApiName.", this.ApiName);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamArraySimple(map, prefix + "ParameterList.", this.ParameterList);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArrayObj(map, prefix + "ApiNameOp.", this.ApiNameOp);
            this.SetParamSimple(map, prefix + "Option", this.Option);
        }
    }
}

