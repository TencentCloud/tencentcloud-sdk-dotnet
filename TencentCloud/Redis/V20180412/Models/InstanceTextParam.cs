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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceTextParam : AbstractModel
    {
        
        /// <summary>
        /// <p>参数名称。</p>
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// <p>参数类型。例如：text。</p>
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// <p>参数修改后是否需要重启。</p><ul><li>true：需要。</li><li>false：不需要。</li></ul>
        /// </summary>
        [JsonProperty("NeedRestart")]
        public string NeedRestart{ get; set; }

        /// <summary>
        /// <p>参数默认值。</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>参数当前运行值。</p>
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// <p>参数说明。</p>
        /// </summary>
        [JsonProperty("Tips")]
        public string Tips{ get; set; }

        /// <summary>
        /// <p>参数可取值。</p>
        /// </summary>
        [JsonProperty("TextValue")]
        public string[] TextValue{ get; set; }

        /// <summary>
        /// <p>参数修改状态。</p><ul><li>1: 修改中。</li><li>2：修改完成。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>参数类型</p><p>枚举值：</p><ul><li>redis： cache节点支持的参数</li><li>redis-interface： 代理proxy支持的参数</li><li>tendis： tendis支持的参数</li></ul>
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// <p>当前实例是否支持该特性</p>
        /// </summary>
        [JsonProperty("FeatureSupported")]
        public bool? FeatureSupported{ get; set; }

        /// <summary>
        /// <p>新特性上线日期</p><p>参数格式：时间格式YYYY-MM-DD</p>
        /// </summary>
        [JsonProperty("NewFeatureOnlineTime")]
        public string NewFeatureOnlineTime{ get; set; }

        /// <summary>
        /// <p>正则校验规则</p>
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// <p>输入格式描述</p>
        /// </summary>
        [JsonProperty("InputDescription")]
        public string InputDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Tips", this.Tips);
            this.SetParamArraySimple(map, prefix + "TextValue.", this.TextValue);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "FeatureSupported", this.FeatureSupported);
            this.SetParamSimple(map, prefix + "NewFeatureOnlineTime", this.NewFeatureOnlineTime);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "InputDescription", this.InputDescription);
        }
    }
}

